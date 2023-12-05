namespace TestScope
{
    public delegate void PreScope(ScopeOptions options);

    public delegate void PostScope(ScopeOptions options);

    public static class ScopeSyncExtensions
    {
        public static TestFixture PreScope(this TestFixture testFixture, PreScope action)
            => testFixture.OnScopeAsync(options =>
            {
                action.Invoke(options);

                return options.NextAsync();
            });

        public static TestFixture PostScope(this TestFixture testFixture, PostScope action)
            => testFixture.OnScopeAsync(async options =>
            {
                await options.NextAsync();

                action.Invoke(options);
            });
    }
}
