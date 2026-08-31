// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Auth.OAuth2;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class TokenRefresherTest
{
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public async Task StartAsync_NullCredential_ThrowsArgumentNullException(bool useGoogleCredentialOverload)
    {
        Task<TokenRefresher> StartAsync() => useGoogleCredentialOverload
            ? TokenRefresher.StartAsync((GoogleCredential) null)
            : TokenRefresher.StartAsync((ITokenAccessWithHeaders) null);

        await Assert.ThrowsAsync<ArgumentNullException>(StartAsync);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("quota-project")]
    public async Task StartAsync_CachesTokenFromCredential(string quotaProject)
    {
        var credential = GoogleCredential.FromAccessToken("token");
        if (quotaProject is not null)
        {
            credential = credential.CreateWithQuotaProject(quotaProject);
        }

        using var refresher = await TokenRefresher.StartAsync(credential);

        Assert.NotNull(refresher.CurrentToken);
        Assert.Equal("token", refresher.CurrentToken.AccessToken);
        string actualQuotaProject = refresher.CurrentToken.Headers.TryGetValue("x-goog-user-project", out var values)
            ? Assert.Single(values)
            : null;
        Assert.Equal(quotaProject, actualQuotaProject);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task StartAsync_ScopeRequiringCredential_AppliesMonitoringWriteScope(bool useInterfaceOverload)
    {
        Uri tokenUri = null;
        var credential = MetricReporterTest.CreateComputeCredential(request =>
        {
            tokenUri = request.RequestUri;
            return MetricReporterTest.CreateTokenResponse();
        });
        Assert.True(credential.IsCreateScopedRequired);

        using var refresher = useInterfaceOverload
            ? await TokenRefresher.StartAsync((ITokenAccessWithHeaders) credential)
            : await TokenRefresher.StartAsync(credential);

        Assert.Equal("?scopes=https://www.googleapis.com/auth/monitoring.write", tokenUri?.Query);
        Assert.Equal("scoped-token", refresher.CurrentToken?.AccessToken);
    }

    [Fact]
    public async Task StartAsync_SameGoogleCredential_ReusesCachedScopedCredential()
    {
        int tokenRequests = 0;
        var credential = MetricReporterTest.CreateComputeCredential(_ =>
        {
            Interlocked.Increment(ref tokenRequests);
            return MetricReporterTest.CreateTokenResponse();
        });

        (await TokenRefresher.StartAsync(credential)).Dispose();
        (await TokenRefresher.StartAsync(credential)).Dispose();

        Assert.Equal(1, tokenRequests);
    }

    [Fact]
    public async Task StartAsync_DifferentGoogleCredential_ReplacesCachedScopedCredential()
    {
        var credential1 = MetricReporterTest.CreateComputeCredential(_ => MetricReporterTest.CreateTokenResponse("token-1"));
        var credential2 = MetricReporterTest.CreateComputeCredential(_ => MetricReporterTest.CreateTokenResponse("token-2"));

        using var refresher1 = await TokenRefresher.StartAsync(credential1);
        using var refresher2 = await TokenRefresher.StartAsync(credential2);

        Assert.Equal("token-1", refresher1.CurrentToken?.AccessToken);
        Assert.Equal("token-2", refresher2.CurrentToken?.AccessToken);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task StartAsync_InitialRefreshFails_LeavesTokenNull(bool timeout)
    {
        var credential = new DelegateTokenAccess(async ct =>
        {
            if (timeout)
            {
                await Task.Delay(Timeout.InfiniteTimeSpan, ct);
            }
            throw new InvalidOperationException("Token endpoint unavailable");
        });

        var startTask = TokenRefresher.StartAsync(credential, refreshTimeout: TimeSpan.FromMilliseconds(30));
        await AwaitWithTimeoutAsync(startTask);
        using var refresher = await startTask;

        Assert.Null(refresher.CurrentToken);
    }

    [Fact]
    public async Task StartAsync_CallerCancelled_ThrowsOperationCanceledException()
    {
        using var cts = new CancellationTokenSource();
        var credential = new DelegateTokenAccess(async ct =>
        {
            cts.Cancel();
            await Task.Delay(Timeout.InfiniteTimeSpan, ct);
            return new AccessTokenWithHeaders("token", null);
        });

        await Assert.ThrowsAnyAsync<OperationCanceledException>(
            () => TokenRefresher.StartAsync(credential, cancellationToken: cts.Token));
    }

    [Fact]
    public async Task StartAsync_UpdatesTokenPeriodically()
    {
        DelegateTokenAccess credential = null;
        credential = new DelegateTokenAccess(_ =>
            Task.FromResult(new AccessTokenWithHeaders($"token-{credential.CallCount}", null)));

        using var refresher = await TokenRefresher.StartAsync(credential, refreshInterval: TimeSpan.FromMilliseconds(15));
        await WaitForConditionAsync(() => refresher.CurrentToken?.AccessToken != "token-1");

        Assert.StartsWith("token-", refresher.CurrentToken?.AccessToken, StringComparison.Ordinal);
        Assert.NotEqual("token-1", refresher.CurrentToken?.AccessToken);
    }

    [Fact]
    public async Task StartAsync_RefreshFailureClearsCachedToken()
    {
        DelegateTokenAccess credential = null;
        credential = new DelegateTokenAccess(_ => credential.CallCount == 1
            ? Task.FromResult(new AccessTokenWithHeaders("token-1", null))
            : Task.FromException<AccessTokenWithHeaders>(new InvalidOperationException("Refresh failed after expiry")));

        using var refresher = await TokenRefresher.StartAsync(credential, refreshInterval: TimeSpan.FromMilliseconds(15));
        Assert.Equal("token-1", refresher.CurrentToken?.AccessToken);

        await WaitForConditionAsync(() => refresher.CurrentToken is null);
        Assert.Null(refresher.CurrentToken);
    }

    [Fact]
    public async Task Dispose_StopsPeriodicRefresh()
    {
        var credential = new DelegateTokenAccess(_ => Task.FromResult(new AccessTokenWithHeaders("token", null)));
        var refresher = await TokenRefresher.StartAsync(credential, refreshInterval: TimeSpan.FromMilliseconds(15));

        await credential.AssertStopsRefreshingAsync(refresher, refresher.Dispose);
    }

    [Fact]
    public async Task Dispose_RetainsCachedToken()
    {
        var refresher = await TokenRefresher.StartAsync(GoogleCredential.FromAccessToken("token"));

        refresher.Dispose();

        Assert.Equal("token", refresher.CurrentToken?.AccessToken);
    }

    [Fact]
    public async Task Dispose_CredentialThrowsDuringShutdown_DoesNotFaultBackgroundLoop()
    {
        var inRefresh = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        var releaseRefresh = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
        DelegateTokenAccess credential = null;
        credential = new DelegateTokenAccess(async _ =>
        {
            if (credential.CallCount == 1)
            {
                return new AccessTokenWithHeaders("token-1", null);
            }
            inRefresh.TrySetResult(true);
            await releaseRefresh.Task;
            throw new InvalidOperationException("Refresh transport failed during shutdown");
        });

        var refresher = await TokenRefresher.StartAsync(credential, refreshInterval: TimeSpan.FromMilliseconds(10));
        await AwaitWithTimeoutAsync(inRefresh.Task);

        refresher.Dispose();
        releaseRefresh.SetResult(true);

        await AwaitWithTimeoutAsync(refresher.RefreshLoop);
        Assert.Equal(TaskStatus.RanToCompletion, refresher.RefreshLoop.Status);
    }

    internal static async Task AwaitWithTimeoutAsync(Task task)
    {
        var completed = await Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(5)));
        Assert.Same(task, completed);
        await task;
    }

    internal static async Task WaitForConditionAsync(Func<bool> condition)
    {
        var deadline = DateTime.UtcNow + TimeSpan.FromSeconds(5);
        while (!condition() && DateTime.UtcNow < deadline)
        {
            await Task.Delay(10);
        }
        Assert.True(condition());
    }

    internal sealed class DelegateTokenAccess(Func<CancellationToken, Task<AccessTokenWithHeaders>> getTokenAsync)
        : ITokenAccessWithHeaders
    {
        private int _callCount;

        internal int CallCount => Volatile.Read(ref _callCount);

        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            throw new NotSupportedException();

        public Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(
            string authUri = null, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Interlocked.Increment(ref _callCount);
            return getTokenAsync(cancellationToken);
        }

        internal async Task AssertStopsRefreshingAsync(TokenRefresher refresher, Action stop)
        {
            await WaitForConditionAsync(() => CallCount >= 2);
            stop();
            int countAfterStop = CallCount;
            await AwaitWithTimeoutAsync(refresher.RefreshLoop);
            // Allow one refresh that already passed the cancellation check when stop ran.
            Assert.InRange(CallCount, countAfterStop, countAfterStop + 1);
        }
    }
}
