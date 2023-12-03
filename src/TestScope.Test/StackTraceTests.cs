using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace TestScope.Test
{
    [TestClass]
    public class StackTraceTests
    {
        [TestMethod]
        public void ShouldHaveStackTraceWhenRanSynchronously()
        {
            try
            {
                TestFixture.Default
                    .WithExecute(() => throw new InvalidOperationException("Test"))
                    .Run();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));

                var stackTraceFirstLine = ex.StackTrace!.Split(Environment.NewLine, 2)[0];

                var expected = $@"   at {GetFixtureName()}.<>c.<{GetTestName()}>b__0_0() in {GetFilePath()}:line {GetLineNumber() - 9}";

                Assert.AreEqual(expected, stackTraceFirstLine);
            }
        }

        [TestMethod]
        public async Task ShouldHaveStackTraceWhenRanAsynchronously()
        {
            try
            {
                await TestFixture.Default
                    .WithExecute(() => throw new InvalidOperationException("Test"))
                    .RunAsync();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(InvalidOperationException));

                var stackTraceFirstLine = ex.StackTrace!.Split(Environment.NewLine, 2)[0];

                var expected = $@"   at {GetFixtureName()}.<>c.<{GetTestName()}>b__1_0() in {GetFilePath()}:line {GetLineNumber() - 9}";

                Assert.AreEqual(expected, stackTraceFirstLine);
            }
        }

        private string GetFilePath([CallerFilePath] string? callerFilePath = null) => callerFilePath!;
        private string GetFixtureName() => GetType().FullName!;
        private string GetTestName([CallerMemberName] string? callerMemberName = null) => callerMemberName!;
        private int GetLineNumber([CallerLineNumber] int? callerLineNumber = null) => callerLineNumber!.Value;
    }
}