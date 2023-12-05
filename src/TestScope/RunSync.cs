namespace TestScope
{
    public delegate void PreRun(RunOptions options);

    public delegate void PostRun(RunOptions options);

    public static class RunSyncExtensions
    {
        public static TestFixture PreRun(this TestFixture testFixture, PreRun action)
            => testFixture.OnRunAsync(options =>
            {
                action.Invoke(options);

                return options.NextAsync();
            });

        public static TestFixture PostRun(this TestFixture testFixture, PostRun action)
            => testFixture.OnRunAsync(async options =>
            {
                await options.NextAsync();

                action.Invoke(options);
            });
    }
}
