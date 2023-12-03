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
            NextAsync next,
            CancellationToken cancellationToken)
        {
            RootServiceProvider = rootServiceProvider;
            ScopeServiceProvider = scopeServiceProvider;
            Context = context;
            Next = next;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider RootServiceProvider { get; }
        public IServiceProvider ScopeServiceProvider { get; }
        public dynamic Context { get; }
        public NextAsync Next { get; }
        public CancellationToken CancellationToken { get; }
    }
}
