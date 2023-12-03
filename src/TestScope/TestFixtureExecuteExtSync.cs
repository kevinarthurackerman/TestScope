namespace TestScope
{
    public delegate void ExecuteExt();

    public delegate void ExecuteExt<in TArg1>(TArg1 arg1);

    public delegate void ExecuteExt<in TArg1, in TArg2>(TArg1 arg1, TArg2 arg2);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3>(TArg1 arg1, TArg2 arg2, TArg3 arg3);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31);

    public delegate void ExecuteExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31, in TArg32>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32);

    public static class TestFixtureExecuteExtSyncExtensions
    {
        public static TestFixture WithExecute(this TestFixture testFixture, ExecuteExt execute)
            => testFixture.WithExecuteAsync(_ =>
            {
                execute.Invoke();
                return default;
            });

        public static TestFixture WithExecute<TArg1>(this TestFixture testFixture, ExecuteExt<TArg1> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);

                execute.Invoke(arg1);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);

                execute.Invoke(arg1, arg2);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);

                execute.Invoke(arg1, arg2, arg3);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);
                var arg28 = ArgLocator<TArg28>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);
                var arg28 = ArgLocator<TArg28>.Get(options);
                var arg29 = ArgLocator<TArg29>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);
                var arg28 = ArgLocator<TArg28>.Get(options);
                var arg29 = ArgLocator<TArg29>.Get(options);
                var arg30 = ArgLocator<TArg30>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);
                var arg28 = ArgLocator<TArg28>.Get(options);
                var arg29 = ArgLocator<TArg29>.Get(options);
                var arg30 = ArgLocator<TArg30>.Get(options);
                var arg31 = ArgLocator<TArg31>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
                
                return default;
            });
        public static TestFixture WithExecute<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this TestFixture testFixture, ExecuteExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ArgLocator<TArg1>.Get(options);
                var arg2 = ArgLocator<TArg2>.Get(options);
                var arg3 = ArgLocator<TArg3>.Get(options);
                var arg4 = ArgLocator<TArg4>.Get(options);
                var arg5 = ArgLocator<TArg5>.Get(options);
                var arg6 = ArgLocator<TArg6>.Get(options);
                var arg7 = ArgLocator<TArg7>.Get(options);
                var arg8 = ArgLocator<TArg8>.Get(options);
                var arg9 = ArgLocator<TArg9>.Get(options);
                var arg10 = ArgLocator<TArg10>.Get(options);
                var arg11 = ArgLocator<TArg11>.Get(options);
                var arg12 = ArgLocator<TArg12>.Get(options);
                var arg13 = ArgLocator<TArg13>.Get(options);
                var arg14 = ArgLocator<TArg14>.Get(options);
                var arg15 = ArgLocator<TArg15>.Get(options);
                var arg16 = ArgLocator<TArg16>.Get(options);
                var arg17 = ArgLocator<TArg17>.Get(options);
                var arg18 = ArgLocator<TArg18>.Get(options);
                var arg19 = ArgLocator<TArg19>.Get(options);
                var arg20 = ArgLocator<TArg20>.Get(options);
                var arg21 = ArgLocator<TArg21>.Get(options);
                var arg22 = ArgLocator<TArg22>.Get(options);
                var arg23 = ArgLocator<TArg23>.Get(options);
                var arg24 = ArgLocator<TArg24>.Get(options);
                var arg25 = ArgLocator<TArg25>.Get(options);
                var arg26 = ArgLocator<TArg26>.Get(options);
                var arg27 = ArgLocator<TArg27>.Get(options);
                var arg28 = ArgLocator<TArg28>.Get(options);
                var arg29 = ArgLocator<TArg29>.Get(options);
                var arg30 = ArgLocator<TArg30>.Get(options);
                var arg31 = ArgLocator<TArg31>.Get(options);
                var arg32 = ArgLocator<TArg32>.Get(options);

                execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
                
                return default;
            });
    }
}