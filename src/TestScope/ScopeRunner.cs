using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Dynamic;

namespace TestScope;

public sealed class ScopeRunner
{
    public static readonly ScopeRunner Default = new (new ServiceCollection(), Array.Empty<PipelineBehaviorAsync>());

    private readonly IServiceCollection _services;
    private readonly IEnumerable<PipelineBehaviorAsync> _pipelineBehaviors;

    internal ScopeRunner(IServiceCollection services, IEnumerable<PipelineBehaviorAsync> pipelineBehaviors)
    {
        _services = services;
        _pipelineBehaviors = pipelineBehaviors;
    }

    /// <summary>
    /// Configures services to be provided when running scope executions.
    /// </summary>
    /// <returns>A new instance of <see cref="ScopeRunner"/> that can be chained off of.</returns>
    public ScopeRunner ConfigureServices(ConfigureServicesAsync configure)
    {
        var services = new ServiceCollection { _services };
        var task = configure(services, default);
        if (!task.IsCompleted)
            task.AsTask().RunSynchronously();
        return new ScopeRunner(services, _pipelineBehaviors);
    }

    /// <summary>
    /// Adds a behavior to the scope execution pipeline to run with each scope execution.
    /// Behaviors are ran in the order in which they are registered.
    /// </summary>
    /// <returns>A new instance of <see cref="ScopeRunner"/> that can be chained off of.</returns>
    public ScopeRunner ForEachScope(PipelineBehaviorAsync behavior)
        => new (_services, _pipelineBehaviors.Append(behavior));

    /// <summary>
    /// Adds an action to be executed when Run/RunAsync is called at then end of the chain.
    /// </summary>
    /// <returns>A new instance of <see cref="ScopeRunner"/> that can be chained off of.</returns>
    public ConfiguredScopeRunner ExecuteScope(ExecuteScopeAsync scopedAction)
        => new (_services.BuildServiceProvider(), _pipelineBehaviors, new[] { scopedAction });
}

public sealed class ConfiguredScopeRunner
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IEnumerable<PipelineBehaviorAsync> _pipelineBehaviors;
    private readonly IEnumerable<ExecuteScopeAsync> _scopedActions;

    internal ConfiguredScopeRunner(
        IServiceProvider serviceProvider,
        IEnumerable<PipelineBehaviorAsync> pipelineBehaviors,
        IEnumerable<ExecuteScopeAsync> scopedActions)
    {
        _serviceProvider = serviceProvider;
        _pipelineBehaviors = pipelineBehaviors;
        _scopedActions = scopedActions;
    }

    /// <summary>
    /// Adds an action to be executed when Run/RunAsync is called at then end of the chain.
    /// </summary>
    /// <returns>A new instance of <see cref="ScopeRunner"/> that can be chained off of.</returns>
    public ConfiguredScopeRunner ThenExecuteScope(ExecuteScopeAsync scopedAction)
        => new(_serviceProvider, _pipelineBehaviors, _scopedActions.Append(scopedAction));

    /// <summary>
    /// Runs each configured scope execution.
    /// A pipeline of behaviors is configured for each run, executing the behaviors in order and ultimately running the scope action itself.
    /// </summary>
    public async ValueTask RunAsync(CancellationToken cancellationToken = default)
    {
        var context = new ExpandoObject();

        foreach (var scopedAction in _scopedActions)
        {
            using var scope = _serviceProvider.CreateScope();

            NextAsync executeRun = () => scopedAction(scope.ServiceProvider, context, cancellationToken);

            foreach (var pipelineBehavior in _pipelineBehaviors.Reverse())
                executeRun = () => pipelineBehavior(scope.ServiceProvider, executeRun, cancellationToken);

            await executeRun();
        }
    }
}
