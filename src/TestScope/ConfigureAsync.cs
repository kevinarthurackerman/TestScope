using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreConfigureAsync(ConfigureOptions options);

    public delegate ValueTask PostConfigureAsync(ConfigureOptions options);

    public delegate ValueTask OnConfigureAsync(ConfigureOptions options);

    public static class ConfigureAsyncExtensions
    {
        public static TestFixture PreConfigureAsync(this TestFixture testFixture, PreConfigureAsync action)
            => testFixture.OnConfigureAsync(async options =>
            {
                await action.Invoke(options);

                await options.NextAsync();
            });

        public static TestFixture PostConfigureAsync(this TestFixture testFixture, PostConfigureAsync action)
            => testFixture.OnConfigureAsync(async options =>
            {
                await options.NextAsync();

                await action.Invoke(options);
            });
    }
}
