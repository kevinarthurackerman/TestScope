using System;
using System.Threading;

namespace TestScope
{
    public readonly struct RunOptions
    {
        internal RunOptions(
            IServiceProvider rootServiceProvider,
            dynamic context,
            NextAsync next,
            CancellationToken cancellationToken)
        {
            RootServiceProvider = rootServiceProvider;
            Context = context;
            Next = next;
            CancellationToken = cancellationToken;
        }

        public IServiceProvider RootServiceProvider { get; }
        public dynamic Context { get; }
        public NextAsync Next { get; }
        public CancellationToken CancellationToken { get; }
    }
}
