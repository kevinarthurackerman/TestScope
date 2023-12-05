namespace TestScope
{
    public delegate void PreScope(ScopeOptions options);

    public delegate void PostScope(ScopeOptions options);

    public static class TestFixtureScopeSyncExtensions
    {
        public static TestFixture PreScope(this TestFixture testFixture, PreScope preScope)
            => testFixture.OnScopeAsync((context) =>
            {
                preScope.Invoke(context);
                return context.NextAsync();
            });

        public static TestFixture PostScope(this TestFixture testFixture, PostScope postScope)
            => testFixture.OnScopeAsync(async (context) =>
            {
                await context.NextAsync();
                postScope.Invoke(context);
            });
    }
}
