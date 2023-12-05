using System;
using System.Threading;

namespace TestScope
{
    public readonly struct ExecuteOptions
    {
        internal ExecuteOptions(
            IServiceProvider rootServiceProvider,
            IServiceProvider scopeServiceProvider,
            dynamic context,
            CancellationToken cancellationToken)
        {
            RootServiceProvider = rootServiceProvider;
            ScopeServiceProvider = scopeServiceProvider;
            Context = context;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider RootServiceProvider { get; }
        public IServiceProvider ScopeServiceProvider { get; }
        public dynamic Context { get; }
        public CancellationToken CancellationToken { get; }
    }
}
