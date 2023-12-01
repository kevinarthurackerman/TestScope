using System.Runtime.ExceptionServices;

namespace TestScope;

public static partial class ScopeRunnerExtensions
{
    /// <inheritdoc cref="ScopeRunner.ConfigureServices" />
    public static ScopeRunner ConfigureServices(this ScopeRunner scopeRunner, ConfigureServices configure)
        => scopeRunner.ConfigureServices((services, _) =>
        {
            configure(services);
            return default;
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope(this ScopeRunner scopeRunner, DIPipelineBehavior behavior)
        => scopeRunner.ForEachScope((_, next, _) =>
        {
            behavior(Next);
            return default;

            void Next()
            {
                var task = next();
                if (!task.IsCompleted)
                    task.AsTask().RunSynchronously();
            }
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope(this ScopeRunner scopeRunner, PipelineBehavior behavior)
        => scopeRunner.ForEachScope((serviceProvider, next, _) =>
        {
            behavior(serviceProvider, Next);
            return default;

            void Next()
            {
                var task = next();
                if (!task.IsCompleted)
                    task.AsTask().RunSynchronously();
            }
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope(this ScopeRunner scopeRunner, DIExecuteScope scopedAction)
        => scopeRunner.ExecuteScope((_, _, _) =>
        {
            scopedAction();
            return default;
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope(this ScopeRunner scopeRunner, ExecuteScope scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context, _) =>
        {
            scopedAction(serviceProvider, context);
            return default;
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope(this ConfiguredScopeRunner scopeRunner, DIExecuteScope scopedAction)
        => scopeRunner.ThenExecuteScope((_, _, _) =>
        {
            scopedAction();
            return default;
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope(this ConfiguredScopeRunner scopeRunner, ExecuteScope scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context, _) =>
        {
            scopedAction(serviceProvider, context);
            return default;
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.RunAsync" />
    public static void Run(this ConfiguredScopeRunner scopeRunner)
    {
        var valueTask = scopeRunner.RunAsync();

        if (valueTask.IsCompletedSuccessfully) return;

        var task = valueTask.AsTask();

        if (!task.IsCompleted)
            task.RunSynchronously();

        if (task.Exception != null)
        {
            var exception = task.Exception.Flatten();

            if (exception.InnerExceptions.Count > 1)
                ExceptionDispatchInfo.Capture(exception).Throw();

            ExceptionDispatchInfo.Capture(exception.InnerException!).Throw();
        }
    }
}
