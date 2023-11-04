namespace TestScope;

public static partial class ScopeRunnerExtensions
{
    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1> behavior)
        where TArg1 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithToken(serviceProvider, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithToken(serviceProvider, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithToken(serviceProvider, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithToken(serviceProvider, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithToken(serviceProvider, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithToken(serviceProvider, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ScopeRunner scopeRunner, DIPipelineBehaviorAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> behavior)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        where TArg32 : notnull
        => scopeRunner.ForEachScope((serviceProvider, next, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithToken(serviceProvider, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithToken(serviceProvider, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithToken(serviceProvider, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithToken(serviceProvider, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithToken(serviceProvider, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithToken(serviceProvider, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithToken(serviceProvider, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithToken(serviceProvider, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithToken(serviceProvider, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithToken(serviceProvider, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithToken(serviceProvider, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithToken(serviceProvider, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithToken(serviceProvider, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithToken(serviceProvider, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithToken(serviceProvider, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithToken(serviceProvider, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithToken(serviceProvider, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithToken(serviceProvider, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithToken(serviceProvider, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithToken(serviceProvider, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithToken(serviceProvider, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithToken(serviceProvider, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithToken(serviceProvider, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithToken(serviceProvider, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithToken(serviceProvider, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithToken(serviceProvider, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithToken(serviceProvider, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithToken(serviceProvider, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithToken(serviceProvider, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithToken(serviceProvider, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithToken(serviceProvider, cancellationToken);
            var arg32 = ArgumentLocator<TArg32>.GetWithToken(serviceProvider, cancellationToken);

            return behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, next);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1> scopedAction)
        where TArg1 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        where TArg32 : notnull
        => scopeRunner.ExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg32 = ArgumentLocator<TArg32>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1> scopedAction)
        where TArg1 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ConfiguredScopeRunner scopeRunner, DIExecuteScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> scopedAction)
        where TArg1 : notnull
        where TArg2 : notnull
        where TArg3 : notnull
        where TArg4 : notnull
        where TArg5 : notnull
        where TArg6 : notnull
        where TArg7 : notnull
        where TArg8 : notnull
        where TArg9 : notnull
        where TArg10 : notnull
        where TArg11 : notnull
        where TArg12 : notnull
        where TArg13 : notnull
        where TArg14 : notnull
        where TArg15 : notnull
        where TArg16 : notnull
        where TArg17 : notnull
        where TArg18 : notnull
        where TArg19 : notnull
        where TArg20 : notnull
        where TArg21 : notnull
        where TArg22 : notnull
        where TArg23 : notnull
        where TArg24 : notnull
        where TArg25 : notnull
        where TArg26 : notnull
        where TArg27 : notnull
        where TArg28 : notnull
        where TArg29 : notnull
        where TArg30 : notnull
        where TArg31 : notnull
        where TArg32 : notnull
        => scopeRunner.ThenExecuteScope((serviceProvider, context, cancellationToken) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg2 = ArgumentLocator<TArg2>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg3 = ArgumentLocator<TArg3>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg4 = ArgumentLocator<TArg4>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg5 = ArgumentLocator<TArg5>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg6 = ArgumentLocator<TArg6>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg7 = ArgumentLocator<TArg7>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg8 = ArgumentLocator<TArg8>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg9 = ArgumentLocator<TArg9>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg10 = ArgumentLocator<TArg10>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg11 = ArgumentLocator<TArg11>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg12 = ArgumentLocator<TArg12>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg13 = ArgumentLocator<TArg13>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg14 = ArgumentLocator<TArg14>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg15 = ArgumentLocator<TArg15>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg16 = ArgumentLocator<TArg16>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg17 = ArgumentLocator<TArg17>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg18 = ArgumentLocator<TArg18>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg19 = ArgumentLocator<TArg19>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg20 = ArgumentLocator<TArg20>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg21 = ArgumentLocator<TArg21>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg22 = ArgumentLocator<TArg22>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg23 = ArgumentLocator<TArg23>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg24 = ArgumentLocator<TArg24>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg25 = ArgumentLocator<TArg25>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg26 = ArgumentLocator<TArg26>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg27 = ArgumentLocator<TArg27>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg28 = ArgumentLocator<TArg28>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg29 = ArgumentLocator<TArg29>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg30 = ArgumentLocator<TArg30>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg31 = ArgumentLocator<TArg31>.GetWithContextWithToken(serviceProvider, context, cancellationToken);
            var arg32 = ArgumentLocator<TArg32>.GetWithContextWithToken(serviceProvider, context, cancellationToken);

            return scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
        });

}
