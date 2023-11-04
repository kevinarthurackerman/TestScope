namespace TestScope;

public static partial class ScopeRunnerExtensions
{
    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync behavior)
        => scopeRunner.ForEachScope((_, next, _) => behavior(next));

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope(this ScopeRunner scopeRunner, DIExecuteScopeAsync scopedAction)
        => scopeRunner.ExecuteScope((_, _, _) => scopedAction());

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync scopedAction)
        => scopeRunner.ThenExecuteScope((_, _, _) => scopedAction());
}
