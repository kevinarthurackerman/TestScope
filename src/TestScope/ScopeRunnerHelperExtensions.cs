using Microsoft.Extensions.DependencyInjection;

namespace TestScope;

public static partial class ScopeRunnerExtensions
{
    private static class ArgumentLocator<TArg>
    {
        internal static readonly Func<IServiceProvider, TArg> Get;
        internal static readonly Func<IServiceProvider, dynamic, TArg> GetWithContext;
        internal static readonly Func<IServiceProvider, CancellationToken, TArg> GetWithToken;
        internal static readonly Func<IServiceProvider, dynamic, CancellationToken, TArg> GetWithContextWithToken;

        static ArgumentLocator()
        {
            if (typeof(TArg) == typeof(CancellationToken))
            {
                Get = (_) => throw new InvalidOperationException("Cannot request a CancellationToken in a sync context.");
                GetWithContext = (_, _) => throw new InvalidOperationException("Cannot request a CancellationToken in a sync context.");
                GetWithToken = (_, cancellationToken) => (TArg)(object)cancellationToken;
                GetWithContextWithToken = (_, _, cancellationToken) => (TArg)(object)cancellationToken;
                return;
            }

            if (typeof(TArg) == typeof(Object))
            {
                Get = (_) => throw new InvalidOperationException("Cannot request a dynamic context outside a scope.");
                GetWithContext = (_, context) => context;
                GetWithToken = (_, _) => throw new InvalidOperationException("Cannot request a dynamic context outside a scope.");
                GetWithContextWithToken = (_, context, _) => context;
                return;
            }

            Get = (serviceProvider) => serviceProvider.GetRequiredService<TArg>();
            GetWithContext = (serviceProvider, _) => serviceProvider.GetRequiredService<TArg>();
            GetWithToken = (serviceProvider, _) => serviceProvider.GetRequiredService<TArg>();
            GetWithContextWithToken = (serviceProvider, _, _) => serviceProvider.GetRequiredService<TArg>();
        }
    }
}
