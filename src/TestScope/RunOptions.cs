using System;
using System.Threading;

namespace TestScope
{
    public readonly struct RunOptions
    {
        internal RunOptions(
            IServiceProvider rootServiceProvider,
            dynamic context,
            NextAsync nextAsync,
            CancellationToken cancellationToken)
        {
            RootServiceProvider = rootServiceProvider;
            Context = context;
            NextAsync = nextAsync;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider RootServiceProvider { get; }
        public dynamic Context { get; }
        public NextAsync NextAsync { get; }
        public CancellationToken CancellationToken { get; }
    }
}
