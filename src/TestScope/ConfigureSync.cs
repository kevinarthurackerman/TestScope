namespace TestScope
{
    public delegate void PreConfigure(ConfigureOptions options);

    public delegate void PostConfigure(ConfigureOptions options);

    public static class ConfigureSyncExtensions
    {
        public static TestFixture PreConfigure(this TestFixture testFixture, PreConfigure action)
            => testFixture.OnConfigureAsync(options =>
            {
                action.Invoke(options);

                return options.NextAsync();
            });

        public static TestFixture PostConfigure(this TestFixture testFixture, PostConfigure action)
            => testFixture.OnConfigureAsync(async options =>
            {
                await options.NextAsync();

                action.Invoke(options);
            });
    }
}
