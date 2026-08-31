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
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(ReporterCollection.Name)]
public class AuthorizingOtlpMetricExporterTest
{
    private static readonly Uri s_expectedEndpoint = new("https://telemetry.googleapis.com/v1/metrics");

    [Fact]
    public void Export_SendsToTelemetryEndpoint()
    {
        using var handler = new RecordingHandler();
        Assert.True(FlushSingleExport(handler, CreateToken("token")));
        Assert.Equal(s_expectedEndpoint, Assert.Single(handler.Requests).RequestUri);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("quota-project")]
    public void Export_SetsCredentialHeaders(string quotaProject)
    {
        using var handler = new RecordingHandler();
        var token = quotaProject is null
            ? CreateToken("token")
            : CreateToken("token", ("x-goog-user-project", quotaProject));

        Assert.True(FlushSingleExport(handler, token));

        Assert.Equal("Bearer token", handler.GetLastHeader("Authorization"));
        Assert.Equal(quotaProject, handler.GetLastHeader("x-goog-user-project"));
    }

    [Fact]
    public void Export_ReplacesHeadersWhenTokenChanges()
    {
        using var handler = new RecordingHandler();
        var currentToken = CreateToken("token-1", ("x-goog-user-project", "project-1"), ("x-goog-extra", "extra-1"));
        using (var harness = new ExporterHarness(handler, () => currentToken))
        {
            Assert.True(harness.Flush());
            currentToken = CreateToken("token-2", ("x-goog-user-project", "project-2"));
            Assert.True(harness.Flush());
        }

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
    public void Export_NullToken_ReturnsFalse()
    {
        using var handler = new RecordingHandler();
        Assert.False(FlushSingleExport(handler, token: null));
        Assert.Equal(0, handler.RequestCount);
    }

    [Theory]
    [InlineData(false, false)]
    [InlineData(true, true)]
    public void Export_DisabledOrEmptyBatch_SkipsRequest(bool disableBeforeExport, bool recordPoint)
    {
        using var handler = new RecordingHandler();
        using var harness = new ExporterHarness(
            handler,
            static () => throw new InvalidOperationException("Token should not be requested."),
            disableBeforeExport);

        Assert.True(harness.Flush(recordPoint));
        Assert.Equal(0, handler.RequestCount);
    }

    [Fact]
    public void Export_IgnoresAmbientOtlpEnvironmentVariables()
    {
        using var endpointVar = new TemporaryEnvironmentVariable(
            "OTEL_EXPORTER_OTLP_ENDPOINT", "https://collector.example.com/v1/metrics");
        using var headersVar = new TemporaryEnvironmentVariable(
            "OTEL_EXPORTER_OTLP_HEADERS", "x-ambient-header=secret");
        using var protocolVar = new TemporaryEnvironmentVariable("OTEL_EXPORTER_OTLP_PROTOCOL", "grpc");
        using var compressionVar = new TemporaryEnvironmentVariable("OTEL_EXPORTER_OTLP_COMPRESSION", "gzip");
        using var handler = new RecordingHandler();

        Assert.True(FlushSingleExport(handler, CreateToken("token")));

        var request = Assert.Single(handler.Requests);
        Assert.Equal(s_expectedEndpoint, request.RequestUri);
        Assert.Equal("Bearer token", request.GetHeader("Authorization"));
        Assert.Null(request.GetHeader("x-ambient-header"));
        Assert.Equal("application/x-protobuf", request.GetHeader("Content-Type"));
        Assert.Null(request.GetHeader("Content-Encoding"));
    }

    [Fact]
    public void CheckEnvironmentSettings_InvalidExporterVariable_Throws()
    {
        using var env = new TemporaryEnvironmentVariable("OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY", "bogus");
        Assert.ThrowsAny<Exception>(AuthorizingOtlpMetricExporter.CheckEnvironmentSettings);
    }

    private static bool FlushSingleExport(RecordingHandler handler, AccessTokenWithHeaders token)
    {
        using var harness = new ExporterHarness(handler, () => token);
        return harness.Flush();
    }

    private static AccessTokenWithHeaders CreateToken(string token, params (string Name, string Value)[] headers) =>
        new(token, headers.ToDictionary(h => h.Name, h => (IReadOnlyList<string>) new[] { h.Value }));

    private sealed class ExporterHarness : IDisposable
    {
        private readonly AuthorizingOtlpMetricExporter _exporter;
        private readonly MeterProvider _meterProvider;
        private readonly Meter _meter;
        private readonly Counter<long> _counter;

        internal ExporterHarness(RecordingHandler httpHandler, Func<AccessTokenWithHeaders> getToken, bool disableBeforeExport = false)
        {
            string meterName = $"Test.{Guid.NewGuid():N}";
            _exporter = AuthorizingOtlpMetricExporter.Create(httpHandler, getToken);
            if (disableBeforeExport)
            {
                _exporter.DisableExport();
            }
            _meterProvider = Sdk.CreateMeterProviderBuilder()
                .AddMeter(meterName)
                .AddReader(new BaseExportingMetricReader(_exporter))
                .Build();
            _meter = new Meter(meterName);
            _counter = _meter.CreateCounter<long>("count");
        }

        public void Dispose()
        {
            // Disposing the meter provider collects cumulative instruments again during reader shutdown.
            _exporter.DisableExport();
            _meter.Dispose();
            _meterProvider.Dispose();
            _exporter.Dispose();
        }

        internal bool Flush(bool recordPoint = true)
        {
            if (recordPoint)
            {
                _counter.Add(1);
            }
            return _meterProvider.ForceFlush();
        }
    }
}
