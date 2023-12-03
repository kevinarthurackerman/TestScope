namespace TestScope
{
    public delegate void Execute(ExecuteOptions options);

    public static class TestFixtureExecuteSyncExtensions
    {
        public static TestFixture WithExecute(this TestFixture testFixture, Execute execute)
            => testFixture.WithExecuteAsync((options) =>
            {
                execute.Invoke(options);
                return default;
            });
    }
}
