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
    public delegate void PreRun(RunOptions options);

    public delegate void PostRun(RunOptions options);

    public static class TestFixtureRunSyncExtensions
    {
        public static TestFixture PreRun(this TestFixture testFixture, PreRun preRun)
            => testFixture.OnRunAsync((context) =>
            {
                preRun.Invoke(context);
                return context.Next();
            });

        public static TestFixture PostRun(this TestFixture testFixture, PostRun postRun)
            => testFixture.OnRunAsync(async (context) =>
            {
                await context.Next();
                postRun.Invoke(context);
            });
    }
}
