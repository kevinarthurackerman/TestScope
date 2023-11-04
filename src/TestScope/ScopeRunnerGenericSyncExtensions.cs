namespace TestScope;

public static partial class ScopeRunnerExtensions
{
    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);

            behavior(arg1, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);

            behavior(arg1, arg2, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);
            var arg28 = ArgumentLocator<TArg28>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);
            var arg28 = ArgumentLocator<TArg28>.Get(serviceProvider);
            var arg29 = ArgumentLocator<TArg29>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);
            var arg28 = ArgumentLocator<TArg28>.Get(serviceProvider);
            var arg29 = ArgumentLocator<TArg29>.Get(serviceProvider);
            var arg30 = ArgumentLocator<TArg30>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);
            var arg28 = ArgumentLocator<TArg28>.Get(serviceProvider);
            var arg29 = ArgumentLocator<TArg29>.Get(serviceProvider);
            var arg30 = ArgumentLocator<TArg30>.Get(serviceProvider);
            var arg31 = ArgumentLocator<TArg31>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, next);
        });

    /// <inheritdoc cref="ScopeRunner.ForEachScope" />
    public static ScopeRunner ForEachScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ScopeRunner scopeRunner, DIPipelineBehavior<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> behavior)
        => scopeRunner.ForEachScope((serviceProvider, next) =>
        {
            var arg1 = ArgumentLocator<TArg1>.Get(serviceProvider);
            var arg2 = ArgumentLocator<TArg2>.Get(serviceProvider);
            var arg3 = ArgumentLocator<TArg3>.Get(serviceProvider);
            var arg4 = ArgumentLocator<TArg4>.Get(serviceProvider);
            var arg5 = ArgumentLocator<TArg5>.Get(serviceProvider);
            var arg6 = ArgumentLocator<TArg6>.Get(serviceProvider);
            var arg7 = ArgumentLocator<TArg7>.Get(serviceProvider);
            var arg8 = ArgumentLocator<TArg8>.Get(serviceProvider);
            var arg9 = ArgumentLocator<TArg9>.Get(serviceProvider);
            var arg10 = ArgumentLocator<TArg10>.Get(serviceProvider);
            var arg11 = ArgumentLocator<TArg11>.Get(serviceProvider);
            var arg12 = ArgumentLocator<TArg12>.Get(serviceProvider);
            var arg13 = ArgumentLocator<TArg13>.Get(serviceProvider);
            var arg14 = ArgumentLocator<TArg14>.Get(serviceProvider);
            var arg15 = ArgumentLocator<TArg15>.Get(serviceProvider);
            var arg16 = ArgumentLocator<TArg16>.Get(serviceProvider);
            var arg17 = ArgumentLocator<TArg17>.Get(serviceProvider);
            var arg18 = ArgumentLocator<TArg18>.Get(serviceProvider);
            var arg19 = ArgumentLocator<TArg19>.Get(serviceProvider);
            var arg20 = ArgumentLocator<TArg20>.Get(serviceProvider);
            var arg21 = ArgumentLocator<TArg21>.Get(serviceProvider);
            var arg22 = ArgumentLocator<TArg22>.Get(serviceProvider);
            var arg23 = ArgumentLocator<TArg23>.Get(serviceProvider);
            var arg24 = ArgumentLocator<TArg24>.Get(serviceProvider);
            var arg25 = ArgumentLocator<TArg25>.Get(serviceProvider);
            var arg26 = ArgumentLocator<TArg26>.Get(serviceProvider);
            var arg27 = ArgumentLocator<TArg27>.Get(serviceProvider);
            var arg28 = ArgumentLocator<TArg28>.Get(serviceProvider);
            var arg29 = ArgumentLocator<TArg29>.Get(serviceProvider);
            var arg30 = ArgumentLocator<TArg30>.Get(serviceProvider);
            var arg31 = ArgumentLocator<TArg31>.Get(serviceProvider);
            var arg32 = ArgumentLocator<TArg32>.Get(serviceProvider);

            behavior(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32, next);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);

            scopedAction(arg1);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);
            var arg31 = ArgumentLocator<TArg31>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
        });

    /// <inheritdoc cref="ScopeRunner.ExecuteScope" />
    public static ConfiguredScopeRunner ExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> scopedAction)
        => scopeRunner.ExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);
            var arg31 = ArgumentLocator<TArg31>.GetWithContext(serviceProvider, context);
            var arg32 = ArgumentLocator<TArg32>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);

            scopedAction(arg1);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);
            var arg31 = ArgumentLocator<TArg31>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
        });

    /// <inheritdoc cref="ConfiguredScopeRunner.ThenExecuteScope" />
    public static ConfiguredScopeRunner ThenExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this ConfiguredScopeRunner scopeRunner, DIExecuteScope<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> scopedAction)
        => scopeRunner.ThenExecuteScope((serviceProvider, context) =>
        {
            var arg1 = ArgumentLocator<TArg1>.GetWithContext(serviceProvider, context);
            var arg2 = ArgumentLocator<TArg2>.GetWithContext(serviceProvider, context);
            var arg3 = ArgumentLocator<TArg3>.GetWithContext(serviceProvider, context);
            var arg4 = ArgumentLocator<TArg4>.GetWithContext(serviceProvider, context);
            var arg5 = ArgumentLocator<TArg5>.GetWithContext(serviceProvider, context);
            var arg6 = ArgumentLocator<TArg6>.GetWithContext(serviceProvider, context);
            var arg7 = ArgumentLocator<TArg7>.GetWithContext(serviceProvider, context);
            var arg8 = ArgumentLocator<TArg8>.GetWithContext(serviceProvider, context);
            var arg9 = ArgumentLocator<TArg9>.GetWithContext(serviceProvider, context);
            var arg10 = ArgumentLocator<TArg10>.GetWithContext(serviceProvider, context);
            var arg11 = ArgumentLocator<TArg11>.GetWithContext(serviceProvider, context);
            var arg12 = ArgumentLocator<TArg12>.GetWithContext(serviceProvider, context);
            var arg13 = ArgumentLocator<TArg13>.GetWithContext(serviceProvider, context);
            var arg14 = ArgumentLocator<TArg14>.GetWithContext(serviceProvider, context);
            var arg15 = ArgumentLocator<TArg15>.GetWithContext(serviceProvider, context);
            var arg16 = ArgumentLocator<TArg16>.GetWithContext(serviceProvider, context);
            var arg17 = ArgumentLocator<TArg17>.GetWithContext(serviceProvider, context);
            var arg18 = ArgumentLocator<TArg18>.GetWithContext(serviceProvider, context);
            var arg19 = ArgumentLocator<TArg19>.GetWithContext(serviceProvider, context);
            var arg20 = ArgumentLocator<TArg20>.GetWithContext(serviceProvider, context);
            var arg21 = ArgumentLocator<TArg21>.GetWithContext(serviceProvider, context);
            var arg22 = ArgumentLocator<TArg22>.GetWithContext(serviceProvider, context);
            var arg23 = ArgumentLocator<TArg23>.GetWithContext(serviceProvider, context);
            var arg24 = ArgumentLocator<TArg24>.GetWithContext(serviceProvider, context);
            var arg25 = ArgumentLocator<TArg25>.GetWithContext(serviceProvider, context);
            var arg26 = ArgumentLocator<TArg26>.GetWithContext(serviceProvider, context);
            var arg27 = ArgumentLocator<TArg27>.GetWithContext(serviceProvider, context);
            var arg28 = ArgumentLocator<TArg28>.GetWithContext(serviceProvider, context);
            var arg29 = ArgumentLocator<TArg29>.GetWithContext(serviceProvider, context);
            var arg30 = ArgumentLocator<TArg30>.GetWithContext(serviceProvider, context);
            var arg31 = ArgumentLocator<TArg31>.GetWithContext(serviceProvider, context);
            var arg32 = ArgumentLocator<TArg32>.GetWithContext(serviceProvider, context);

            scopedAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
        });

}
