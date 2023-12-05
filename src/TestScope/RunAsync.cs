using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreRunAsync(RunOptions options);

    public delegate ValueTask PostRunAsync(RunOptions options);

    public delegate ValueTask OnRunAsync(RunOptions options);

    public static class RunAsyncExtensions
    {
        public static TestFixture PreRunAsync(this TestFixture testFixture, PreRunAsync action)
            => testFixture.OnRunAsync(async options =>
            {
                await action.Invoke(options);

                await options.NextAsync();
            });

        public static TestFixture PostRunAsync(this TestFixture testFixture, PostRunAsync action)
            => testFixture.OnRunAsync(async options =>
            {
                await options.NextAsync();

                await action.Invoke(options);
            });
    }
}
