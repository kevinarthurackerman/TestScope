namespace TestScope
{
    public delegate void PreRun(RunOptions options);

    public delegate void PostRun(RunOptions options);

    public static class TestFixtureRunSyncExtensions
    {
        public static TestFixture PreRun(this TestFixture testFixture, PreRun preRun)
            => testFixture.OnRunAsync((context) =>
            {
                preRun.Invoke(context);
                return context.NextAsync();
            });

        public static TestFixture PostRun(this TestFixture testFixture, PostRun postRun)
            => testFixture.OnRunAsync(async (context) =>
            {
                await context.NextAsync();
                postRun.Invoke(context);
            });
    }
}
