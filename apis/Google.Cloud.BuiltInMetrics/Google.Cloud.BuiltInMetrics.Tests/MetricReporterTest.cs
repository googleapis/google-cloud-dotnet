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
using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class MetricReporterTest
{
    private static readonly GoogleCredential s_credential = GoogleCredential.FromAccessToken("token");
    private readonly List<RecordingHandler> _handlers = new();

    [Fact]
    public async Task StartAsync_InvalidExporterVariable_ThrowsBeforeCreatingHandler()
    {
        using var env = new TemporaryEnvironmentVariable("OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY", "bogus");
        await Assert.ThrowsAnyAsync<Exception>(() => StartReporterAsync(s_credential));
        Assert.Empty(_handlers);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task StartAsync_TokenRefresherFails_DisposesHttpHandler(bool nullCredential)
    {
        if (nullCredential)
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => StartReporterAsync(credential: null));
        }
        else
        {
            await Assert.ThrowsAnyAsync<OperationCanceledException>(
                () => StartReporterAsync(s_credential, new CancellationToken(true)));
        }

        Assert.True(Assert.Single(_handlers).Disposed);
    }

    [Fact]
    public async Task StartAsync_InitialTokenRefreshFails_ReturnsActiveReporter()
    {
        int tokenRequests = 0;
        var credential = CreateComputeCredential(_ =>
        {
            Interlocked.Increment(ref tokenRequests);
            return new HttpResponseMessage(HttpStatusCode.NotFound);
        });

        using var handle = await BuiltInMetrics.EnableAsync(
            new BuiltInMetricsOptions { GoogleCredential = credential },
            null,
            StartReporterAsync,
            default);

        Assert.True(tokenRequests > 0);
        Assert.NotSame(BuiltInMetrics.NoOpHandle, handle);
    }

    [Fact]
    public async Task StartAsync_RestartWithSameCredential_ReusesCachedScopedCredential()
    {
        int tokenRequests = 0;
        var credential = CreateComputeCredential(_ =>
        {
            Interlocked.Increment(ref tokenRequests);
            return CreateTokenResponse();
        });

        (await StartReporterAsync(credential)).Dispose();
        (await StartReporterAsync(credential)).Dispose();

        Assert.Equal(1, tokenRequests);
    }

    [Fact]
    public async Task Dispose_ExportsRecordedDataAndDisposesHttpHandler()
    {
        using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);
        var counter = meter.CreateCounter<long>("attempt_count");
        var reporter = await StartReporterAsync(s_credential);
        counter.Add(1, MetricForwarderTest.CreateLabels());

        reporter.Dispose();

        var handler = Assert.Single(_handlers);
        Assert.Equal(1, handler.RequestCount);
        Assert.Equal("Bearer token", handler.GetLastHeader("Authorization"));
        Assert.True(handler.Disposed);
    }

    [Fact]
    public async Task Dispose_StopsForwardingMeasurements()
    {
        using var listener = new PooledMeterListener();
        using var meter = new Meter(ServiceMetricsConfiguration.Spanner.SourceMeterName);
        var counter = meter.CreateCounter<long>("attempt_count");
        var reporter = await StartReporterAsync(s_credential);

        reporter.Dispose();
        counter.Add(1, MetricForwarderTest.CreateLabels());

        Assert.Empty(listener.Measurements);
        Assert.Equal(0, Assert.Single(_handlers).RequestCount);
    }

    [Fact]
    public async Task Dispose_StopsTokenRefresher()
    {
        var credential = new TokenRefresherTest.DelegateTokenAccess(
            _ => Task.FromResult(new AccessTokenWithHeaders("token", null)));
        var refresher = await TokenRefresher.StartAsync(credential, refreshInterval: TimeSpan.FromMilliseconds(15));
        var handler = new RecordingHandler();
        var pool = new ResourceMeterPool(
            SystemClock.Instance,
            (s, v) => ResourceMeter.Create(s, v, handler, () => refresher.CurrentToken));
        var reporter = new MetricReporter(new MetricForwarder(ServiceMetricsConfiguration.All, pool), refresher, pool, handler);

        await credential.AssertStopsRefreshingAsync(refresher, reporter.Dispose);
    }

    internal static GoogleCredential CreateComputeCredential(Func<HttpRequestMessage, HttpResponseMessage> send) =>
        GoogleCredential.FromComputeCredential(
            new ComputeCredential(
                new ComputeCredential.Initializer("http://metadata.example/token")
                {
                    HttpClientFactory = new FakeHttpClientFactory(send)
                }));

    internal static HttpResponseMessage CreateTokenResponse(string accessToken = "scoped-token") =>
        new()
        {
            Content = new StringContent(
                $"{{\"access_token\":\"{accessToken}\",\"expires_in\":3600,\"token_type\":\"Bearer\"}}")
        };

    private Task<IDisposable> StartReporterAsync(GoogleCredential credential, CancellationToken token = default) =>
        MetricReporter.StartAsync(credential, () => RecordingHandler.Create(_handlers), SystemClock.Instance, token);
}
