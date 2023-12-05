using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;

namespace TestScope
{
    internal static class ExecuteArgLocator<TValue>
    {
        public static readonly Func<ExecuteOptions, TValue> Get;

        static ExecuteArgLocator()
        {
            if (typeof(TValue) == typeof(ExecuteOptions))
            {
                Get = options => (TValue)(object)options;
                return;
            }

            if (typeof(TValue) == typeof(object))
            {
                Get = options => (TValue)(object)options.Context;
                return;
            }

            if (typeof(TValue) == typeof(CancellationToken))
            {
                Get = options => (TValue)(object)options.CancellationToken;
                return;
            }

            Get = options => (TValue)options.ScopeServiceProvider.GetRequiredService(typeof(TValue));
        }
    }

    internal static class ScopeArgLocator<TValue>
    {
        public static readonly Func<ScopeOptions, TValue> Get;

        static ScopeArgLocator()
        {
            if (typeof(TValue) == typeof(ScopeOptions))
            {
                Get = options => (TValue)(object)options;
                return;
            }

            if (typeof(TValue) == typeof(NextAsync))
            {
                Get = options => (TValue)(object)options.NextAsync;
                return;
            }

            if (typeof(TValue) == typeof(object))
            {
                Get = options => (TValue)(object)options.Context;
                return;
            }

            if (typeof(TValue) == typeof(CancellationToken))
            {
                Get = options => (TValue)(object)options.CancellationToken;
                return;
            }

            Get = options => (TValue)options.ScopeServiceProvider.GetRequiredService(typeof(TValue));
        }
    }
}
