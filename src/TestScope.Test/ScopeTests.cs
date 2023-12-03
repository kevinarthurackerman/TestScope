using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestScope.Test
{
    [TestClass]
    public class ScopeTests
    {
        [TestMethod]
        public void ShouldBeTransient() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddTransient(_ => Id.New))
            .WithExecute((Id id1, Id id2) => Assert.AreNotEqual(id1, id2))
            .Run();

        [TestMethod]
        public void ShouldBeScoped() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddScoped(_ => Id.New))
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(id1, id2);
                context.FirstScopeId = id1;
            })
            .WithExecute((Id id, dynamic context) => Assert.AreNotEqual(context.FirstScopeId, id))
            .Run();

        [TestMethod]
        public void ShouldBeSingleton() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddSingleton(_ => Id.New))
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(id1, id2);
                context.FirstScopeId = id1;
            })
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(context.FirstScopeId, id1);
                Assert.AreEqual(id1, id2);
            })
            .Run();

        [TestMethod]
        public Task ShouldBeTransientAsync() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddTransient(_ => Id.New))
            .WithExecute((Id id1, Id id2) => Assert.AreNotEqual(id1, id2))
            .RunAsync();

        [TestMethod]
        public Task ShouldBeScopedAsync() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddScoped(_ => Id.New))
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(id1, id2);
                context.FirstScopeId = id1;
            })
            .WithExecute((Id id, dynamic context) => Assert.AreNotEqual(context.FirstScopeId, id))
            .RunAsync();

        [TestMethod]
        public Task ShouldBeSingletonAsync() => TestFixture.Default
            .PreConfigure(x => x.ServiceCollection.AddSingleton(_ => Id.New))
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(id1, id2);
                context.FirstScopeId = id1;
            })
            .WithExecute((Id id1, Id id2, dynamic context) =>
            {
                Assert.AreEqual(context.FirstScopeId, id1);
                Assert.AreEqual(id1, id2);
            })
            .RunAsync();
    }
}