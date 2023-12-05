﻿using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask ExecuteAsyncExt();

    public delegate ValueTask ExecuteAsyncExt<in TArg1>(TArg1 arg1);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2>(TArg1 arg1, TArg2 arg2);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3>(TArg1 arg1, TArg2 arg2, TArg3 arg3);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31);

    public delegate ValueTask ExecuteAsyncExt<in TArg1, in TArg2, in TArg3, in TArg4, in TArg5, in TArg6, in TArg7, in TArg8, in TArg9, in TArg10, in TArg11, in TArg12, in TArg13, in TArg14, in TArg15, in TArg16, in TArg17, in TArg18, in TArg19, in TArg20, in TArg21, in TArg22, in TArg23, in TArg24, in TArg25, in TArg26, in TArg27, in TArg28, in TArg29, in TArg30, in TArg31, in TArg32>(TArg1 arg1, TArg2 arg2, TArg3 arg3, TArg4 arg4, TArg5 arg5, TArg6 arg6, TArg7 arg7, TArg8 arg8, TArg9 arg9, TArg10 arg10, TArg11 arg11, TArg12 arg12, TArg13 arg13, TArg14 arg14, TArg15 arg15, TArg16 arg16, TArg17 arg17, TArg18 arg18, TArg19 arg19, TArg20 arg20, TArg21 arg21, TArg22 arg22, TArg23 arg23, TArg24 arg24, TArg25 arg25, TArg26 arg26, TArg27 arg27, TArg28 arg28, TArg29 arg29, TArg30 arg30, TArg31 arg31, TArg32 arg32);

    public static class TestFixtureExecuteExtAsyncExtensions
    {
        public static TestFixture WithExecuteAsync(this TestFixture testFixture, ExecuteAsyncExt execute)
            => testFixture.WithExecuteAsync(_ => default);

        public static TestFixture WithExecuteAsync<TArg1>(this TestFixture testFixture, ExecuteAsyncExt<TArg1> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);

                return execute.Invoke(arg1);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);

                return execute.Invoke(arg1, arg2);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);

                return execute.Invoke(arg1, arg2, arg3);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);
                var arg28 = ExecuteArgLocator<TArg28>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);
                var arg28 = ExecuteArgLocator<TArg28>.Get(options);
                var arg29 = ExecuteArgLocator<TArg29>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);
                var arg28 = ExecuteArgLocator<TArg28>.Get(options);
                var arg29 = ExecuteArgLocator<TArg29>.Get(options);
                var arg30 = ExecuteArgLocator<TArg30>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);
                var arg28 = ExecuteArgLocator<TArg28>.Get(options);
                var arg29 = ExecuteArgLocator<TArg29>.Get(options);
                var arg30 = ExecuteArgLocator<TArg30>.Get(options);
                var arg31 = ExecuteArgLocator<TArg31>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31);
            });
        public static TestFixture WithExecuteAsync<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32>(this TestFixture testFixture, ExecuteAsyncExt<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArg17, TArg18, TArg19, TArg20, TArg21, TArg22, TArg23, TArg24, TArg25, TArg26, TArg27, TArg28, TArg29, TArg30, TArg31, TArg32> execute)
            => testFixture.WithExecuteAsync(options =>
            {
                var arg1 = ExecuteArgLocator<TArg1>.Get(options);
                var arg2 = ExecuteArgLocator<TArg2>.Get(options);
                var arg3 = ExecuteArgLocator<TArg3>.Get(options);
                var arg4 = ExecuteArgLocator<TArg4>.Get(options);
                var arg5 = ExecuteArgLocator<TArg5>.Get(options);
                var arg6 = ExecuteArgLocator<TArg6>.Get(options);
                var arg7 = ExecuteArgLocator<TArg7>.Get(options);
                var arg8 = ExecuteArgLocator<TArg8>.Get(options);
                var arg9 = ExecuteArgLocator<TArg9>.Get(options);
                var arg10 = ExecuteArgLocator<TArg10>.Get(options);
                var arg11 = ExecuteArgLocator<TArg11>.Get(options);
                var arg12 = ExecuteArgLocator<TArg12>.Get(options);
                var arg13 = ExecuteArgLocator<TArg13>.Get(options);
                var arg14 = ExecuteArgLocator<TArg14>.Get(options);
                var arg15 = ExecuteArgLocator<TArg15>.Get(options);
                var arg16 = ExecuteArgLocator<TArg16>.Get(options);
                var arg17 = ExecuteArgLocator<TArg17>.Get(options);
                var arg18 = ExecuteArgLocator<TArg18>.Get(options);
                var arg19 = ExecuteArgLocator<TArg19>.Get(options);
                var arg20 = ExecuteArgLocator<TArg20>.Get(options);
                var arg21 = ExecuteArgLocator<TArg21>.Get(options);
                var arg22 = ExecuteArgLocator<TArg22>.Get(options);
                var arg23 = ExecuteArgLocator<TArg23>.Get(options);
                var arg24 = ExecuteArgLocator<TArg24>.Get(options);
                var arg25 = ExecuteArgLocator<TArg25>.Get(options);
                var arg26 = ExecuteArgLocator<TArg26>.Get(options);
                var arg27 = ExecuteArgLocator<TArg27>.Get(options);
                var arg28 = ExecuteArgLocator<TArg28>.Get(options);
                var arg29 = ExecuteArgLocator<TArg29>.Get(options);
                var arg30 = ExecuteArgLocator<TArg30>.Get(options);
                var arg31 = ExecuteArgLocator<TArg31>.Get(options);
                var arg32 = ExecuteArgLocator<TArg32>.Get(options);

                return execute.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17, arg18, arg19, arg20, arg21, arg22, arg23, arg24, arg25, arg26, arg27, arg28, arg29, arg30, arg31, arg32);
            });
    }
}