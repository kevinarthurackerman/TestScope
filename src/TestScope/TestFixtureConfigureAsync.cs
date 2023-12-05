
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
                await context.NextAsync();
            });

        public static TestFixture PostConfigureAsync(this TestFixture testFixture, PostConfigureAsync postConfigure)
            => testFixture.OnConfigureAsync(async (context) =>
            {
                await context.NextAsync();
                await postConfigure.Invoke(context);
            });
    }
}
