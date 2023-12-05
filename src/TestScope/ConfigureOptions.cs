using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace TestScope
{
    public delegate void OnSetConfigurationCaching(bool activate);

    public readonly struct ConfigureOptions
    {
        private readonly OnSetConfigurationCaching _onSetConfigurationCaching;

        internal ConfigureOptions(
            OnSetConfigurationCaching onSetConfigurationCaching,
            IServiceCollection serviceCollection,
            dynamic context,
            NextAsync nextAsync,
            CancellationToken cancellationToken)
        {
            _onSetConfigurationCaching = onSetConfigurationCaching;
            ServiceCollection = serviceCollection;
            Context = context;
            NextAsync = nextAsync;
            CancellationToken = cancellationToken;
        }

        public void SetConfigurationCaching(bool activate) => _onSetConfigurationCaching(activate);
        public IServiceCollection ServiceCollection { get; }
        public dynamic Context { get; }
        public NextAsync NextAsync { get; }
        public CancellationToken CancellationToken { get; }
    }
}
