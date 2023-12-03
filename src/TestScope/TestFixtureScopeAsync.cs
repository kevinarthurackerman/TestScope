﻿
/* Unmerged change from project 'TestScope (netstandard2.0)'
Before:
using System.Threading.Tasks;
After:
using System.Threading.Tasks;
using TestScope;
using TestScope;
using TestScope.Testing;
*/
using System.Threading.Tasks;

namespace TestScope
{
    public delegate ValueTask PreScopeAsync(ScopeOptions options);

    public delegate ValueTask PostScopeAsync(ScopeOptions options);

    public delegate ValueTask OnScopeAsync(ScopeOptions options);

    public static class TestFixtureScopeAsyncExtensions
    {
        public static TestFixture PreScopeAsync(this TestFixture testFixture, PreScopeAsync preScope)
            => testFixture.OnScopeAsync(async (context) =>
            {
                await preScope.Invoke(context);
                await context.Next();
            });

        public static TestFixture PostScopeAsync(this TestFixture testFixture, PostScopeAsync postScope)
            => testFixture.OnScopeAsync(async (context) =>
            {
                await context.Next();
                await postScope.Invoke(context);
            });
    }
}