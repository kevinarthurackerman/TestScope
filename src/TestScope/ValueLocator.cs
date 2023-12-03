using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading;

namespace TestScope
{
    internal static class ArgLocator<TValue>
    {
        public static readonly Func<ExecuteOptions, TValue> Get;

        static ArgLocator()
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
}
