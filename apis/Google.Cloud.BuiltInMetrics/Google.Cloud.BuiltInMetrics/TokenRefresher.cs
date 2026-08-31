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

using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Periodically refreshes a Google credential in the background and caches the latest token for synchronous exports.
/// </summary>
internal sealed class TokenRefresher : IDisposable
{
    private const string MonitoringWriteScope = "https://www.googleapis.com/auth/monitoring.write";
    private static readonly TimeSpan s_defaultRefreshInterval = TimeSpan.FromSeconds(60);
    private static readonly TimeSpan s_defaultRefreshTimeout = TimeSpan.FromSeconds(10);

    private static readonly object s_credentialLock = new();
    // Reuse the scoped credential across restarts to keep its cached OAuth2 token.
    private static GoogleCredential s_cachedUnscopedCredential;
    private static GoogleCredential s_cachedScopedCredential;

    private readonly ITokenAccessWithHeaders _credential;
    private readonly TimeSpan _refreshInterval;
    private readonly TimeSpan _refreshTimeout;
    // _cts holds no timer or WaitHandle, so cancelling without disposing avoids ObjectDisposedException races.
    private readonly CancellationTokenSource _cts = new();
    private volatile AccessTokenWithHeaders _currentToken;

    internal AccessTokenWithHeaders CurrentToken => _currentToken;
    internal Task RefreshLoop { get; private set; }

    private TokenRefresher(ITokenAccessWithHeaders credential, TimeSpan refreshInterval, TimeSpan refreshTimeout)
    {
        _credential = credential;
        _refreshInterval = refreshInterval;
        _refreshTimeout = refreshTimeout;
    }

    internal static Task<TokenRefresher> StartAsync(
        GoogleCredential credential,
        CancellationToken cancellationToken = default) =>
        StartAsync(credential, refreshInterval: null, refreshTimeout: null, cancellationToken);

    internal static async Task<TokenRefresher> StartAsync(
        ITokenAccessWithHeaders credential,
        TimeSpan? refreshInterval = null,
        TimeSpan? refreshTimeout = null,
        CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(credential, nameof(credential));
        if (credential is GoogleCredential googleCredential)
        {
            credential = ApplyMonitoringScope(googleCredential);
        }
        var refresher = new TokenRefresher(
            credential,
            refreshInterval ?? s_defaultRefreshInterval,
            refreshTimeout ?? s_defaultRefreshTimeout);
        await refresher.RefreshAsync(cancellationToken).ConfigureAwait(false);
        refresher.RefreshLoop = refresher.RunRefreshLoopAsync();
        return refresher;
    }

    public void Dispose()
    {
        // Keep _currentToken intact so final shutdown exports can still authenticate.
        _cts.Cancel();
    }

    private async Task RunRefreshLoopAsync()
    {
        try
        {
            while (!_cts.IsCancellationRequested)
            {
                await Task.Delay(_refreshInterval, _cts.Token).ConfigureAwait(false);
                await RefreshAsync(_cts.Token).ConfigureAwait(false);
            }
        }
        catch when (_cts.IsCancellationRequested)
        {
            // Catch any exception during Dispose so an in-flight credential failure cannot fault the unawaited loop.
        }
    }

    private async Task RefreshAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        // Cap each refresh because TokenRefreshManager otherwise retries failed fetches for minutes.
        using var timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
        timeoutCts.CancelAfter(_refreshTimeout);
        try
        {
            _currentToken = await _credential
                .GetAccessTokenWithHeadersForRequestAsync(cancellationToken: timeoutCts.Token)
                .ConfigureAwait(false);
        }
        catch when (!cancellationToken.IsCancellationRequested)
        {
            // TokenRefreshManager returns cached tokens until expiry, so a failure here means no valid token remains.
            _currentToken = null;
        }
    }

    private static GoogleCredential ApplyMonitoringScope(GoogleCredential credential)
    {
        lock (s_credentialLock)
        {
            if (!ReferenceEquals(credential, s_cachedUnscopedCredential))
            {
                s_cachedScopedCredential = credential.IsCreateScopedRequired
                    ? credential.CreateScoped(MonitoringWriteScope)
                    : credential;
                s_cachedUnscopedCredential = credential;
            }
            return s_cachedScopedCredential;
        }
    }
}
