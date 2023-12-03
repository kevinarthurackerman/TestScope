using Microsoft.Extensions.DependencyInjection;

/* Unmerged change from project 'TestScope (netstandard2.0)'
Before:
using System.Threading;
After:
using System.Threading;
using TestScope;
using TestScope;
using TestScope.Testing;
*/
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
            NextAsync next,
            CancellationToken cancellationToken)
        {
            _onSetConfigurationCaching = onSetConfigurationCaching;
            ServiceCollection = serviceCollection;
            Context = context;
            Next = next;
            CancellationToken = cancellationToken;
        }

        public void SetConfigurationCaching(bool activate) => _onSetConfigurationCaching(activate);
        public IServiceCollection ServiceCollection { get; }
        public dynamic Context { get; }
        public NextAsync Next { get; }
        public CancellationToken CancellationToken { get; }
    }
}
