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
using OpenTelemetry;
using OpenTelemetry.Metrics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

// The net8.0 build of the OTLP exporter sends with HttpClient.Send, and the net462 build (Windows only)
// sends with HttpClient.SendAsync. So these tests cover both paths across the two target frameworks.
[Collection(PipelineCollection.Name)]
public class AuthorizingOtlpMetricExporterTest
{
    private static readonly Uri s_expectedEndpoint = new("https://telemetry.googleapis.com/v1/metrics");

    [Fact]
    public void Export_SendsToTelemetryEndpoint()
    {
        using var handler = new RecordingHandler();

        Assert.True(Export(handler, GoogleCredential.FromAccessToken("token")));

        Assert.Equal(s_expectedEndpoint, Assert.Single(handler.Requests).RequestUri);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("quota-project")]
    public void Export_SetsCredentialHeaders(string quotaProject)
    {
        using var handler = new RecordingHandler();
        var credential = GoogleCredential.FromAccessToken("token");
        if (quotaProject is not null)
        {
            credential = credential.CreateWithQuotaProject(quotaProject);
        }

        Assert.True(Export(handler, credential));

        Assert.Equal("Bearer token", handler.GetLastHeader("Authorization"));
        Assert.Equal(quotaProject, handler.GetLastHeader("x-goog-user-project"));
    }

    [Fact]
    public void Export_RefreshesTokenAndReplacesHeadersAcrossFlushes()
    {
        using var handler = new RecordingHandler();
        var tokens = new Queue<AccessTokenWithHeaders>(
        [
            CreateToken("token-1", ("x-goog-user-project", "project-1"), ("x-goog-extra", "extra-1")),
            CreateToken("token-2", ("x-goog-user-project", "project-2"))
        ]);

        Assert.True(Export(handler, new CallbackTokenAccess(tokens.Dequeue), points: 2));

        Assert.Equal(2, handler.Requests.Count);
        var first = handler.Requests[0];
        Assert.Equal("Bearer token-1", first.GetHeader("Authorization"));
        Assert.Equal("project-1", first.GetHeader("x-goog-user-project"));
        Assert.Equal("extra-1", first.GetHeader("x-goog-extra"));

        var second = handler.Requests[1];
        Assert.Equal("Bearer token-2", second.GetHeader("Authorization"));
        Assert.Equal("project-2", second.GetHeader("x-goog-user-project"));
        Assert.Null(second.GetHeader("x-goog-extra"));
    }

    [Fact]
    public void Export_CredentialThrows_ReturnsFalseWithoutSendingRequest()
    {
        using var handler = new RecordingHandler();
        var credential = new CallbackTokenAccess(() => throw new InvalidOperationException("Token fetch failed"));

        Assert.False(Export(handler, credential));
        Assert.Equal(0, handler.RequestCount);
    }

    [Theory]
    [InlineData(false, 0)]
    [InlineData(true, 1)]
    public void Export_SkippedOrEmptyBatch_SkipsTokenFetchAndRequest(bool skipExport, int points)
    {
        using var handler = new RecordingHandler();
        int tokenFetches = 0;
        var credential = new CallbackTokenAccess(() =>
        {
            Interlocked.Increment(ref tokenFetches);
            return CreateToken("token");
        });

        Assert.True(Export(handler, credential, skipExport, points));
        Assert.Equal(0, tokenFetches);
        Assert.Equal(0, handler.RequestCount);
    }

    [Fact]
    public void Export_IgnoresAmbientOtlpEnvironmentVariables()
    {
        using var endpointVar = new TemporaryEnvironmentVariable(
            "OTEL_EXPORTER_OTLP_ENDPOINT", "https://collector.example.com/v1/metrics");
        using var headersVar = new TemporaryEnvironmentVariable(
            "OTEL_EXPORTER_OTLP_HEADERS", "x-ambient-header=secret");
        using var handler = new RecordingHandler();

        Assert.True(Export(handler, GoogleCredential.FromAccessToken("token")));

        var request = Assert.Single(handler.Requests);
        Assert.Equal(s_expectedEndpoint, request.RequestUri);
        Assert.Equal("Bearer token", request.GetHeader("Authorization"));
        Assert.Null(request.GetHeader("x-ambient-header"));
    }

    // Flushes zero or more recorded points through a new exporter.
    private static bool Export(
        RecordingHandler handler, ITokenAccessWithHeaders credential, bool skipExport = false, int points = 1)
    {
        string meterName = $"Test.{Guid.NewGuid():N}";
        using var httpClient = new HttpClient(handler);
        using var exporter = new AuthorizingOtlpMetricExporter(httpClient, credential) { SkipExport = skipExport };
        using var meterProvider = Sdk.CreateMeterProviderBuilder()
            .AddMeter(meterName)
            .AddReader(new BaseExportingMetricReader(exporter))
            .Build();
        using var meter = new Meter(meterName);
        var counter = meter.CreateCounter<long>("count");
        if (points == 0)
        {
            return meterProvider.ForceFlush();
        }
        bool flushed = true;
        for (int i = 0; i < points; i++)
        {
            counter.Add(1);
            flushed &= meterProvider.ForceFlush();
        }
        // Disposing the meter provider collects cumulative instruments again during reader shutdown.
        exporter.SkipExport = true;
        return flushed;
    }

    private static AccessTokenWithHeaders CreateToken(string token, params (string Name, string Value)[] headers) =>
        new(token, headers.ToDictionary(h => h.Name, h => (IReadOnlyList<string>) new[] { h.Value }));

    private sealed class CallbackTokenAccess(Func<AccessTokenWithHeaders> getToken) : ITokenAccessWithHeaders
    {
        public Task<string> GetAccessTokenForRequestAsync(string authUri = null, CancellationToken cancellationToken = default) =>
            Task.FromResult(getToken().AccessToken);

        public Task<AccessTokenWithHeaders> GetAccessTokenWithHeadersForRequestAsync(
            string authUri = null, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(getToken());
        }
    }
}
