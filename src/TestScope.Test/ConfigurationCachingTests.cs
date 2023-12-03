using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestScope.Test
{
    [TestClass]
    public class ConfigurationCachingTests
    {
        [TestMethod]
        public void ShouldCacheConfiguration()
        {
            var testFixture = TestFixture.Default
                .PreConfigure(x => x.ServiceCollection.AddSingleton(_ => Id.New));

            Id? prevId = null;

            testFixture.WithExecute((Id id) => prevId = id).Run();

            testFixture.WithExecute((Id id) => Assert.AreEqual(prevId, id)).Run();
        }

        [TestMethod]
        public void ShouldNotCacheConfiguration()
        {
            var testFixture = TestFixture.Default
                .PreConfigure(x => x.ServiceCollection.AddSingleton(_ => Id.New))
                .PreConfigure(x => x.SetConfigurationCaching(false));

            Id? prevId = null;

            testFixture.WithExecute((Id id) => prevId = id).Run();

            testFixture.WithExecute((Id id) => Assert.AreNotEqual(prevId, id)).Run();
        }
    }
}