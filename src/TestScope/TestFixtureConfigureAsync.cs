
/* Unmerged change from project 'TestScope (netstandard2.0)'
Before:
using System.Threading.Tasks;
After:
using System.Threading.Tasks;
using TestScope;
using TestScope;
using TestScope.Testing;
*/
using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreConfigureAsync(ConfigureOptions options);

    public delegate ValueTask PostConfigureAsync(ConfigureOptions options);

    public delegate ValueTask OnConfigureAsync(ConfigureOptions options);

    public static class TestFixtureConfigureAsyncExtensions
    {
        public static TestFixture PreConfigureAsync(this TestFixture testFixture, PreConfigureAsync preConfigure)
            => testFixture.OnConfigureAsync(async (context) =>
            {
                await preConfigure.Invoke(context);
                await context.Next();
            });

        public static TestFixture PostConfigureAsync(this TestFixture testFixture, PostConfigureAsync postConfigure)
            => testFixture.OnConfigureAsync(async (context) =>
            {
                await context.Next();
                await postConfigure.Invoke(context);
            });
    }
}
