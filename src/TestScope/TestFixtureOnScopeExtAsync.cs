using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask OnScopeAsyncExt<in TArg1>(TArg1 arg1);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2>(TArg1 arg1, TArg2 arg2);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3>(TArg1 arg1, TArg2 arg2, TArg3 arg3);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31);

    public delegate ValueTask OnScopeAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31, in TArg32>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32);

    public static class TestFixtureOnScopeExtAsyncExtensions
    {
        public static TestFixture OnScopeAsync<TArg1>(this TestFixture testFixture, OnScopeAsyncExt<TArg1> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);

                return scopeBehavior.Invoke(arg1);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);
                var arg28 = ScopeArgLocator<TArg28>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);
                var arg28 = ScopeArgLocator<TArg28>.Get(options);
                var arg29 = ScopeArgLocator<TArg29>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);
                var arg28 = ScopeArgLocator<TArg28>.Get(options);
                var arg29 = ScopeArgLocator<TArg29>.Get(options);
                var arg30 = ScopeArgLocator<TArg30>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);
                var arg28 = ScopeArgLocator<TArg28>.Get(options);
                var arg29 = ScopeArgLocator<TArg29>.Get(options);
                var arg30 = ScopeArgLocator<TArg30>.Get(options);
                var arg31 = ScopeArgLocator<TArg31>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
            });

        public static TestFixture OnScopeAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this TestFixture testFixture, OnScopeAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> scopeBehavior)
            => testFixture.OnScopeAsync(options =>
            {
                var arg1 = ScopeArgLocator<TArg1>.Get(options);
                var arg2 = ScopeArgLocator<TArg2>.Get(options);
                var arg3 = ScopeArgLocator<TArg3>.Get(options);
                var arg4 = ScopeArgLocator<TArg4>.Get(options);
                var arg5 = ScopeArgLocator<TArg5>.Get(options);
                var arg6 = ScopeArgLocator<TArg6>.Get(options);
                var arg7 = ScopeArgLocator<TArg7>.Get(options);
                var arg8 = ScopeArgLocator<TArg8>.Get(options);
                var arg9 = ScopeArgLocator<TArg9>.Get(options);
                var arg10 = ScopeArgLocator<TArg10>.Get(options);
                var arg11 = ScopeArgLocator<TArg11>.Get(options);
                var arg12 = ScopeArgLocator<TArg12>.Get(options);
                var arg13 = ScopeArgLocator<TArg13>.Get(options);
                var arg14 = ScopeArgLocator<TArg14>.Get(options);
                var arg15 = ScopeArgLocator<TArg15>.Get(options);
                var arg16 = ScopeArgLocator<TArg16>.Get(options);
                var arg17 = ScopeArgLocator<TArg17>.Get(options);
                var arg18 = ScopeArgLocator<TArg18>.Get(options);
                var arg19 = ScopeArgLocator<TArg19>.Get(options);
                var arg20 = ScopeArgLocator<TArg20>.Get(options);
                var arg21 = ScopeArgLocator<TArg21>.Get(options);
                var arg22 = ScopeArgLocator<TArg22>.Get(options);
                var arg23 = ScopeArgLocator<TArg23>.Get(options);
                var arg24 = ScopeArgLocator<TArg24>.Get(options);
                var arg25 = ScopeArgLocator<TArg25>.Get(options);
                var arg26 = ScopeArgLocator<TArg26>.Get(options);
                var arg27 = ScopeArgLocator<TArg27>.Get(options);
                var arg28 = ScopeArgLocator<TArg28>.Get(options);
                var arg29 = ScopeArgLocator<TArg29>.Get(options);
                var arg30 = ScopeArgLocator<TArg30>.Get(options);
                var arg31 = ScopeArgLocator<TArg31>.Get(options);
                var arg32 = ScopeArgLocator<TArg32>.Get(options);

                return scopeBehavior.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
            });

    }
}