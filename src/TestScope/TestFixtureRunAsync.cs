using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreRunAsync(RunOptions options);

    public delegate ValueTask PostRunAsync(RunOptions options);

    public delegate ValueTask OnRunAsync(RunOptions options);

    public static class TestFixtureRunAsyncExtensions
    {
        public static TestFixture PreRunAsync(this TestFixture testFixture, PreRunAsync preRun)
            => testFixture.OnRunAsync(async (context) =>
            {
                await preRun.Invoke(context);
                await context.Next();
            });

        public static TestFixture PostRunAsync(this TestFixture testFixture, PostRunAsync postRun)
            => testFixture.OnRunAsync(async (context) =>
            {
                await context.Next();
                await postRun.Invoke(context);
            });
    }
}
