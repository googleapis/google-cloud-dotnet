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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.BuiltInMetrics;

/// <summary>
/// Starts and disposes the built-in metrics reporter.
/// </summary>
internal sealed class MetricReporter : IDisposable
{
    private readonly HttpMessageHandler _httpHandler;
    private TokenRefresher _tokenRefresher;
    private ResourceMeterPool _pool;
    private MetricForwarder _forwarder;

    private MetricReporter(HttpMessageHandler httpHandler) =>
        _httpHandler = httpHandler;

    internal MetricReporter(
        MetricForwarder forwarder,
        TokenRefresher tokenRefresher,
        ResourceMeterPool pool,
        HttpMessageHandler httpHandler)
    {
        _forwarder = forwarder;
        _tokenRefresher = tokenRefresher;
        _pool = pool;
        _httpHandler = httpHandler;
    }

    internal static Task<IDisposable> StartAsync(GoogleCredential credential, CancellationToken cancellationToken) =>
        StartAsync(credential, static () => new HttpClientHandler(), SystemClock.Instance, cancellationToken);

    internal static async Task<IDisposable> StartAsync(
        GoogleCredential credential,
        Func<HttpMessageHandler> createHttpHandler,
        IClock clock,
        CancellationToken cancellationToken)
    {
        AuthorizingOtlpMetricExporter.CheckEnvironmentSettings();
        var reporter = new MetricReporter(createHttpHandler());
        try
        {
            reporter._tokenRefresher = await TokenRefresher.StartAsync(credential, cancellationToken).ConfigureAwait(false);
            reporter._pool = new ResourceMeterPool(
                clock,
                (service, resourceValues) => ResourceMeter.Create(
                    service, resourceValues, reporter._httpHandler, () => reporter._tokenRefresher.CurrentToken));
            reporter._forwarder = new MetricForwarder(ServiceMetricsConfiguration.All, reporter._pool);
            return reporter;
        }
        catch
        {
            reporter.Dispose();
            throw;
        }
    }

    public void Dispose()
    {
        _forwarder?.Dispose();
        // Stop background refreshes before flushing the pool so a refresh error cannot clear CurrentToken mid-flush.
        _tokenRefresher?.Dispose();
        _pool?.Dispose();
        // If pool disposal timed out, OpenTelemetry catches ObjectDisposedException from late exports.
        _httpHandler?.Dispose();
    }
}
