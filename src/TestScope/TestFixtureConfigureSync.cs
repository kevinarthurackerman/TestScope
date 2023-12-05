namespace TestScope
{
    public delegate void PreConfigure(ConfigureOptions options);

    public delegate void PostConfigure(ConfigureOptions options);

    public static class TestFixtureConfigureSyncExtensions
    {
        public static TestFixture PreConfigure(this TestFixture testFixture, PreConfigure preConfigure)
            => testFixture.OnConfigureAsync((context) =>
            {
                preConfigure.Invoke(context);
                return context.NextAsync();
            });

        public static TestFixture PostConfigure(this TestFixture testFixture, PostConfigure postConfigure)
            => testFixture.OnConfigureAsync(async (context) =>
            {
                await context.NextAsync();
                postConfigure.Invoke(context);
            });
    }
}
