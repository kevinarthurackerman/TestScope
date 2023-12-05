namespace TestScope
{
    public delegate void Execute(ExecuteOptions options);

    public static class ExecuteSyncExtensions
    {
        public static TestFixture WithExecute(this TestFixture testFixture, Execute action)
            => testFixture.WithExecuteAsync(options =>
            {
                action.Invoke(options);
                return default;
            });
    }
}
