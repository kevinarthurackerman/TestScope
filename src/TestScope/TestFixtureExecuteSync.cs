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
