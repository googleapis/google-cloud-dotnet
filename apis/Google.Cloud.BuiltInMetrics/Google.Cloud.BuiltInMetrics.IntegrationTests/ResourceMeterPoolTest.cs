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

using Google.Api.Gax.Testing;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.ClientTesting;
using Google.Cloud.Monitoring.V3;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.IntegrationTests;

/// <summary>
/// Tests <see cref="ResourceMeterPool"/> against live telemetry.googleapis.com with a fake clock for eviction.
/// </summary>
[Collection(IntegrationTestCollection.Name)]
public class ResourceMeterPoolTest
{
    private const string MonitoringWriteScope = "https://www.googleapis.com/auth/monitoring.write";
    private const string AttemptCountMetric = "spanner.googleapis.com/client/attempt_count";
    private static readonly TimeSpan s_firstExportTimeout = TimeSpan.FromSeconds(90);
    private static readonly TimeSpan s_minimumSeriesGap = TimeSpan.FromSeconds(10);

    // Cloud Monitoring may reject a restarted cumulative series unless it starts after the previous series ends.
    // Eviction skips the final export, so the old series ends at its last periodic export.
    [Fact]
    public async Task RecreatedEntry_StartsSeriesAfterPreviousSeriesEnds()
    {
        string projectId = TestEnvironment.GetTestProjectId();
        var credential = await GoogleCredential.GetApplicationDefaultAsync();
        string clientName = SpannerBuiltInMetricsTest.CreateClientName();
        var labels = SpannerBuiltInMetricsTest.CreateLabels(projectId, clientName);
        Assert.True(ResourceKey.TrySplitLabels(ServiceMetricsConfiguration.Spanner, labels, out var key, out var tags));
        string filter = $"metric.labels.client_name = \"{clientName}\"";
        var monitoringClient = await MetricServiceClient.CreateAsync();
        var clock = new FakeClock(DateTime.UtcNow);
        using var handler = new ExportRecordingHandler();
        using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);
        var counter = meter.CreateCounter<long>("attempt_count");

        IReadOnlyList<Point> firstPoints;
        using (var pool = new ResourceMeterPool(handler, Scope(credential), clock))
        {
            pool.Record(key, counter, 1L, in tags);
            // Evict right after the 60-second periodic export so the first entry cannot export again at 120 seconds.
            await handler.WaitForExportAsync(s_firstExportTimeout);
            var sinceFirstExport = Stopwatch.StartNew();
            Assert.Equal(HttpStatusCode.OK, Assert.Single(handler.Exports).StatusCode);

            clock.Advance(ResourceMeterPool.IdleTimeout);
            pool.EvictIdleEntries();

            firstPoints = await MonitoringPoller.WaitForPointsAsync(monitoringClient, projectId, AttemptCountMetric, filter);

            var remainingGap = s_minimumSeriesGap - sinceFirstExport.Elapsed;
            if (remainingGap > TimeSpan.Zero)
            {
                await Task.Delay(remainingGap);
            }

            pool.Record(key, counter, 1L, in tags);
            // Pool disposal exports the new series.
        }

        Assert.Equal(2, handler.Exports.Count);
        Assert.All(handler.Exports, export => Assert.Equal(HttpStatusCode.OK, export.StatusCode));

        var firstEnd = firstPoints.Max(point => point.Interval.EndTime);
        await MonitoringPoller.WaitForPointsAsync(
            monitoringClient, projectId, AttemptCountMetric, filter, points => points.Any(point => point.Interval.StartTime > firstEnd));
    }

    [SkippableFact]
    public async Task UserCredential_ExportWithUserProjectIsAccepted()
    {
        var credential = await GoogleCredential.GetApplicationDefaultAsync();
        Skip.IfNot(credential.UnderlyingCredential is UserCredential, "Application default credentials are not user credentials.");
        Skip.If(credential.QuotaProject is null, "The user credential has no quota project.");
        using var handler = new ExportRecordingHandler();
        using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);
        var counter = meter.CreateCounter<long>("attempt_count");
        var labels = SpannerBuiltInMetricsTest.CreateLabels(
            TestEnvironment.GetTestProjectId(), SpannerBuiltInMetricsTest.CreateClientName());
        Assert.True(ResourceKey.TrySplitLabels(ServiceMetricsConfiguration.Spanner, labels, out var key, out var tags));

        using (var pool = new ResourceMeterPool(handler, Scope(credential), new FakeClock()))
        {
            pool.Record(key, counter, 1L, in tags);
        }

        Assert.Equal((credential.QuotaProject, HttpStatusCode.OK), Assert.Single(handler.Exports));
    }

    private static GoogleCredential Scope(GoogleCredential credential) =>
        credential.IsCreateScopedRequired ? credential.CreateScoped(MonitoringWriteScope) : credential;

    private sealed class ExportRecordingHandler() : DelegatingHandler(new HttpClientHandler())
    {
        private readonly SemaphoreSlim _exportSignal = new(0);

        internal ConcurrentQueue<(string UserProject, HttpStatusCode StatusCode)> Exports { get; } = new();

        internal async Task WaitForExportAsync(TimeSpan timeout) =>
            Assert.True(await _exportSignal.WaitAsync(timeout), $"Timed out after {timeout.TotalSeconds} seconds waiting for export.");

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) =>
            Record(request, await base.SendAsync(request, cancellationToken).ConfigureAwait(false));

#if NET5_0_OR_GREATER
        // On .NET 8+, the OTLP exporter sends through synchronous HttpClient.Send.
        protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken) =>
            Record(request, base.Send(request, cancellationToken));
#endif

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _exportSignal.Dispose();
            }
            base.Dispose(disposing);
        }

        private HttpResponseMessage Record(HttpRequestMessage request, HttpResponseMessage response)
        {
            string userProject = request.Headers.TryGetValues("x-goog-user-project", out var values) ? values.Single() : null;
            Exports.Enqueue((userProject, response.StatusCode));
            _exportSignal.Release();
            return response;
        }
    }
}
