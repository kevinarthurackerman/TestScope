# TestScope
The purpose of this library is to make it easy to simulate the request pattern of a typical application in tests. Additionally, this library provides a convenient way to mock services on a test-by-test basis, set the context in which a test runs (ex: a user is logged in), and inject your services into the test.

## Test Lifecycle
Supports synchronous and asynchronous flows, and even mixed flows!

### Sync Flow
``` csharp
[TestMethod]
public void ShouldDoSomething() => TestFixture.Default
    .PreConfigure(opts => ...)
    .PostConfigure(opts => ...)
    .PreRun(opts => ...)
    .PostRun(opts => ...)
    .PreScope(opts => ...)
    .PostScope(opts => ...)
    .WithExecute((Service1 service1, Service2 service2, ...) => ...)
    .Run();
```

#### Async Flow
``` csharp
[TestMethod]
public Task ShouldDoSomethingAsync(CancellationToken ctx) => TestFixture.Default
    .PreConfigureAsync(async opts => ...)
    .OnConfigureAsync(async opts => ...)
    .PostConfigureAsync(async opts => ...)
    .PreRunAsync(async opts => ...)
    .OnRunAsync(async opts => ...)
    .PostRunAsync(async opts => ...)
    .PreScopeAsync(async opts => ...)
    .OnScopeAsync(async opts => ...)
    .PostScopeAsync(async opts => ...)
    .WithExecuteAsync(async (Service1 service1, Service2 service2, ...) => ...)
    .RunAsync(ctx);
```

### Lifetime Nesting
```
Configure1
| Configure2
| | Configure3
Run1
| Run2
| | Run3
| | Scope1
| | | Scope 2
| | | | Scope3
| | | | | Execute1
| | Scope1
| | | Scope 2
| | | | Scope3
| | | | | Execute2
| | Scope1
| | | Scope 2
| | | | Scope3
| | | | | Execute3
```

### Pre/Post/On Configure/ConfigureAsync
These delegates run before the service provider is constructed give you access to mutate a copy of the services collection before running the tests. This means that you can have a default set of services that is used by your production application and by your tests, but mock out specific services to behave differently for your test.

### Pre/Post/On Run/RunAsync
These delegates wrap the entire test execution of your test scopes and can be used for set up and clean up. For instance, you could open a transaction at the beginning of your tests and then cancel it at the end to avoid modifying the state of your test environment and in a way that may affect or invalidate other tests.

### Pre/Post/On Scope/ScopeAsync
These delegates wrap each request your test mocks out. For instance, you may want to have each request that executes advance a clock service to simulate time passing between each request automatically.

### WithExecute/WithExecuteAsync
These delegates represent each request to be executed to simulate a test scenario. An example of this would be in the first request a customer is sent a bill, and in the second request the customer pays the bill. These are two separate actions that are performed at two different points in time by two different users.

### On...Async Methods
These are always async and must call `await opts.NextAsync()` in order to advance the pipeline. These methods are useful because you can perform actions before and after the rest of the pipeline is ran and pass context within the method.

``` csharp
.OnScopeAsync(async opts => 
{
    var logger = opts.ScopeServiceProvider.GetRequiredService<ILogger>();
    var startTime = DateTime.UtcNow;
    await NextAsync();
    var stopTime = DateTime.UtcNow;
    logger.LogInformation("Test started at {0} and completed at {1}, startTime, stopTime);
})
```

### Pre/Pre...Async/Post/Post...Async Methods
These can be synchronous or asynchronous and are called on the way into or out of the pipeline. You can think of every "Pre" method being followed by a call to "NextAsync" and every "Post" method being called after a call to "NextAsync".