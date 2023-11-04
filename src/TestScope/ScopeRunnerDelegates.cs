using Microsoft.Extensions.DependencyInjection;

namespace TestScope;

public delegate ValueTask ConfigureServicesAsync(IServiceCollection services, CancellationToken cancellationToken);

public delegate ValueTask PipelineBehaviorAsync(IServiceProvider services, NextAsync next, CancellationToken cancellationToken);

public delegate ValueTask NextAsync();

public delegate ValueTask ExecuteScopeAsync(IServiceProvider services, dynamic context, CancellationToken cancellationToken);

public delegate ValueTask DIPipelineBehaviorAsync(NextAsync next);

public delegate ValueTask DIExecuteScopeAsync();

public delegate void ConfigureServices(IServiceCollection services);

public delegate void PipelineBehavior(IServiceProvider services, Next next);

public delegate void Next();

public delegate void ExecuteScope(IServiceProvider services, dynamic context);

public delegate void DIPipelineBehavior(Next next);

public delegate void DIExecuteScope();
