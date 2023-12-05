using System;
using System.Threading;

namespace TestScope
{
    public readonly struct ScopeOptions
    {
        internal ScopeOptions(
            IServiceProvider rootServiceProvider,
            IServiceProvider scopeServiceProvider,
            dynamic context,
            NextAsync nextAsync,
            CancellationToken cancellationToken)
        {
            RootServiceProvider = rootServiceProvider;
            ScopeServiceProvider = scopeServiceProvider;
            Context = context;
            NextAsync = nextAsync;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider RootServiceProvider { get; }
        public IServiceProvider ScopeServiceProvider { get; }
        public dynamic Context { get; }
        public NextAsync NextAsync { get; }
        public CancellationToken CancellationToken { get; }
    }
}
