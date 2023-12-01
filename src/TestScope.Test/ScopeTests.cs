using Microsoft.Extensions.DependencyInjection;

namespace TestScope.Test;

[TestClass]
public class ScopeTests
{
    [TestMethod]
    public void ShouldBeTransient() => ScopeRunner.Default
        .ConfigureServices(sp => sp.AddTransient(_ => new Tuple<Guid>(Guid.NewGuid())))
        .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2) => Assert.AreNotEqual(value1.Item1, value2.Item1))
        .Run();

    [TestMethod]
    public void ShouldBeScoped() => ScopeRunner.Default
        .ConfigureServices(sp => sp.AddScoped(_ => new Tuple<Guid>(Guid.NewGuid())))
        .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
        {
            Assert.AreEqual(value1.Item1, value2.Item1);
            context.FirstScopeId = value1.Item1;
        })
        .ThenExecuteScope((Tuple<Guid> value, dynamic context) => Assert.AreNotEqual(context.FirstScopeId, value.Item1))
        .Run();

    [TestMethod]
    public void ShouldBeSingleton() => ScopeRunner.Default
        .ConfigureServices(sp => sp.AddSingleton(_ => new Tuple<Guid>(Guid.NewGuid())))
        .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
        {
            Assert.AreEqual(value1.Item1, value2.Item1);
            context.FirstScopeId = value1.Item1;
        })
        .ThenExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
        {
            Assert.AreEqual(context.FirstScopeId, value1.Item1);
            Assert.AreEqual(value1.Item1, value2.Item1);
            context.FirstScopeId = value1.Item1;
        })
        .Run();

    [TestMethod]
    public async Task ShouldBeTransientAsync()
    {
        await ScopeRunner.Default
            .ConfigureServices(sp => sp.AddTransient(_ => new Tuple<Guid>(Guid.NewGuid())))
            .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2) => Assert.AreNotEqual(value1.Item1, value2.Item1))
            .RunAsync();
    }

    [TestMethod]
    public async Task ShouldBeScopedAsync()
    {
        var result = ScopeRunner.Default
            .ConfigureServices(sp => sp.AddScoped(_ => new Tuple<Guid>(Guid.NewGuid())))
            .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
            {
                Assert.AreEqual(value1.Item1, value2.Item1);
                context.FirstScopeId = value1.Item1;
            })
            .ThenExecuteScope((Tuple<Guid> value, dynamic context) => Assert.AreNotEqual(context.FirstScopeId, value.Item1))
            .RunAsync();

        await result;
    }

    [TestMethod]
    public async Task ShouldBeSingletonAsync()
    {
        await ScopeRunner.Default
            .ConfigureServices(sp => sp.AddSingleton(_ => new Tuple<Guid>(Guid.NewGuid())))
            .ExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
            {
                Assert.AreEqual(value1.Item1, value2.Item1);
                context.FirstScopeId = value1.Item1;
            })
            .ThenExecuteScope((Tuple<Guid> value1, Tuple<Guid> value2, dynamic context) =>
            {
                Assert.AreEqual(context.FirstScopeId, value1.Item1);
                Assert.AreEqual(value1.Item1, value2.Item1);
                context.FirstScopeId = value1.Item1;
            })
            .RunAsync();
    }
}