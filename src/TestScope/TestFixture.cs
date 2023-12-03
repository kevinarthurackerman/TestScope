using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask NextAsync();

    public sealed class TestFixture
    {
        public static TestFixture Default { get; } = new TestFixture(
            Array.Empty<OnConfigureAsync>(),
            Array.Empty<OnRunAsync>(),
            Array.Empty<OnScopeAsync>(),
            Array.Empty<ExecuteAsync>(),
            new Ref<Configuration>());

        private readonly OnConfigureAsync[] _onConfigures;
        private readonly OnRunAsync[] _onRuns;
        private readonly OnScopeAsync[] _onScopes;
        private readonly ExecuteAsync[] _executes;
        private readonly Ref<Configuration> _cachedConfiguration;

        private TestFixture(
            OnConfigureAsync[] onConfigures,
            OnRunAsync[] onRuns,
            OnScopeAsync[] onScopes,
            ExecuteAsync[] executes,
            Ref<Configuration> cachedContext)
        {
            _onConfigures = onConfigures;
            _onRuns = onRuns;
            _onScopes = onScopes;
            _executes = executes;
            _cachedConfiguration = cachedContext;
        }

        public TestFixture OnConfigureAsync(OnConfigureAsync configureBehavior)
            => new TestFixture(
              Append(_onConfigures, configureBehavior),
              _onRuns,
              _onScopes,
              _executes,
              new Ref<Configuration>());

        public TestFixture OnRunAsync(OnRunAsync runBehavior)
            => new TestFixture(
               _onConfigures,
               Append(_onRuns, runBehavior),
               _onScopes,
               _executes,
               _cachedConfiguration);

        public TestFixture OnScopeAsync(OnScopeAsync scopeBehavior)
            => new TestFixture(
               _onConfigures,
               _onRuns,
               Append(_onScopes, scopeBehavior),
               _executes,
               _cachedConfiguration);

        public TestFixture WithExecuteAsync(ExecuteAsync execute)
            => new TestFixture(
               _onConfigures,
               _onRuns,
               _onScopes,
               Append(_executes, execute),
               _cachedConfiguration);

        public void Run()
        {
            var valueTask = RunAsyncInternal();

            if (valueTask.IsCompletedSuccessfully) return;

            var task = valueTask.AsTask();

            if (!task.IsCompleted) task.RunSynchronously();

            if (task.Exception == null) return;

            var exception = task.Exception.Flatten();

            if (exception.InnerExceptions.Count > 1)
                ExceptionDispatchInfo.Capture(exception).Throw();

            ExceptionDispatchInfo.Capture(exception.InnerException!).Throw();
        }

        public Task RunAsync(CancellationToken cancellationToken = default)
            => RunAsyncInternal(cancellationToken).AsTask();

        private async ValueTask RunAsyncInternal(CancellationToken cancellationToken = default)
        {
            var configuration = await GetConfiguration(cancellationToken);

            var rootServiceProvider = configuration.RootServiceProvider;
            var context = configuration.Context;
            var executeScopes = new List<NextAsync>();

            // set up each execute scope pipeline
            foreach (var execute in _executes)
            {
                var scope = configuration.RootServiceProvider.CreateAsyncScope();

                // wraps the execute delegate
                var executeScope = (NextAsync)(async () =>
                {
                    var options = new ExecuteOptions(
                        rootServiceProvider,
                        scope.ServiceProvider,
                        context,
                        cancellationToken);

                    await execute.Invoke(options);
                });

                // wraps each onScope delegate around the executeScope in layers
                foreach (var onScope in _onScopes.Reverse())
                {
                    var options = new ScopeOptions(
                        rootServiceProvider,
                        scope.ServiceProvider,
                        context,
                        executeScope,
                        cancellationToken);

                    executeScope = () => onScope.Invoke(options);
                }

                var executeAndDisposeScope = (NextAsync)(async () =>
                {
                    await executeScope.Invoke();
                    await scope.DisposeAsync();
                });

                executeScopes.Add(executeAndDisposeScope);
            }

            // builds the executeRun delegate
            var executeRun = (NextAsync)(async () =>
            {
                foreach (var executeScope in executeScopes)
                    await executeScope.Invoke();
            });

            // wraps each onRun delegate around the executeRun in layers
            foreach (var onRun in _onRuns.Reverse())
            {
                var options = new RunOptions(
                    rootServiceProvider,
                    context,
                    executeRun,
                    cancellationToken);

                executeRun = () => onRun.Invoke(options);
            }

            // fires execution of the executeRun delegate tree
            await executeRun.Invoke();

            async ValueTask<Configuration> GetConfiguration(CancellationToken cancellationToken)
            {
                // check cache for existing configuration and return early if found
                if (_cachedConfiguration.Value.HasValue)
                    return _cachedConfiguration.Value!.Value;

                // otherwise build configuration
                var context = new ExpandoObject();

                var serviceCollection = new ServiceCollection();
                var configurationCachingActive = true;

                var executeConfigure = (NextAsync)(() => default);

                var onSetConfigurationCaching = (OnSetConfigurationCaching)((activate) => configurationCachingActive = activate);

                foreach (var configureBehavior in _onConfigures.Reverse())
                {
                    var options = new ConfigureOptions(
                        onSetConfigurationCaching,
                        serviceCollection,
                        context,
                        executeConfigure,
                        cancellationToken);

                    executeConfigure = () => configureBehavior.Invoke(options);
                }

                await executeConfigure.Invoke();

                // build service provider
                var rootServiceProvider = serviceCollection.BuildServiceProvider();

                var configuration = new Configuration(rootServiceProvider, context);

                // cache configuration if activated
                if (configurationCachingActive)
                    _cachedConfiguration.Value = configuration;

                return configuration;
            }
        }

        private T[] Append<T>(T[] originalArray, T appendItem)
        {
            var newArray = new T[originalArray.Length + 1];
            originalArray.CopyTo(newArray, 0);
            newArray[newArray.Length - 1] = appendItem;
            return newArray;
        }

        private sealed class Ref<T> where T : struct
        {
            public T? Value { get; set; }
        }

        private readonly struct Configuration
        {
            private readonly ExpandoObject _context;

            public Configuration(IServiceProvider rootServiceProvider, ExpandoObject context)
            {
                RootServiceProvider = rootServiceProvider;
                _context = CloneContext(context);
            }

            public IServiceProvider RootServiceProvider { get; }
            public ExpandoObject Context => CloneContext(_context);

            private static ExpandoObject CloneContext(ExpandoObject context)
            {
                var clone = new ExpandoObject();

                foreach (var prop in context)
                    ((IDictionary<string, object>)clone)[prop.Key] = prop.Value;

                return clone;
            }
        }
    }
}