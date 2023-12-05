using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreScopeAsync(ScopeOptions options);

    public delegate ValueTask PostScopeAsync(ScopeOptions options);

    public delegate ValueTask OnScopeAsync(ScopeOptions options);

    public static class ScopeAsyncExtensions
    {
        public static TestFixture PreScopeAsync(this TestFixture testFixture, PreScopeAsync action)
            => testFixture.OnScopeAsync(async options =>
            {
                await action.Invoke(options);

                await options.NextAsync();
            });

        public static TestFixture PostScopeAsync(this TestFixture testFixture, PostScopeAsync action)
            => testFixture.OnScopeAsync(async options =>
            {
                await options.NextAsync();

                await action.Invoke(options);
            });
    }
}
