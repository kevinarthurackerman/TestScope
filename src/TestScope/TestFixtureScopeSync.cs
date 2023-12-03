/* Unmerged change from project 'TestScope (netstandard2.0)'
Before:
namespace TestScope.Testing
After:
using TestScope;
using TestScope;
using TestScope.Testing
*/
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
                return context.Next();
            });

        public static TestFixture PostScope(this TestFixture testFixture, PostScope postScope)
            => testFixture.OnScopeAsync(async (context) =>
            {
                await context.Next();
                postScope.Invoke(context);
            });
    }
}
