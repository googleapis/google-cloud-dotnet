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
using Google.Cloud.Spanner.V1;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.BuiltInMetrics.Tests;

[Collection(PipelineCollection.Name)]
public class MetricForwarderTest : IDisposable
{
    public enum InstrumentKind { Counter, Histogram }

    private readonly Meter _sourceMeter = new(ServiceMetricsConfiguration.Spanner.SourceMeterName);

    public void Dispose() => _sourceMeter.Dispose();

    [Theory]
    [InlineData(InstrumentKind.Counter, false)]
    [InlineData(InstrumentKind.Histogram, false)]
    [InlineData(InstrumentKind.Counter, true)]
    [InlineData(InstrumentKind.Histogram, true)]
    public void Record_ForwardsValueAndRemovesResourceLabels(InstrumentKind kind, bool createBeforeForwarder)
    {
        using var listener = new PooledMeterListener();
        var forwarder = createBeforeForwarder ? null : CreateForwarder();
        var counter = _sourceMeter.CreateCounter<long>("attempt_count");
        var histogram = _sourceMeter.CreateHistogram<double>("attempt_latencies");
        using (forwarder ?? CreateForwarder())
        {
            if (kind == InstrumentKind.Counter)
            {
                counter.Add(1, CreateLabels());
            }
            else
            {
                histogram.Record(12.5, CreateLabels());
            }
        }

        var measurement = Assert.Single(listener.Measurements);
        Assert.Equal(kind == InstrumentKind.Counter ? "attempt_count" : "attempt_latencies", measurement.InstrumentName);
        Assert.Equal(kind == InstrumentKind.Counter ? (object) 1L : 12.5, measurement.Value);
        Assert.Equal(["database"], measurement.Labels.Keys);
    }

    [Fact]
    public void Record_OtherMeter_IsIgnored()
    {
        using var listener = new PooledMeterListener();
        using var forwarder = CreateForwarder();
        using var otherMeter = new Meter("Some.Other.Meter");
        otherMeter.CreateCounter<long>("attempt_count").Add(1, CreateLabels());
        Assert.Empty(listener.Measurements);
    }

    [Fact]
    public void Record_UnsupportedInstrumentType_IsIgnored()
    {
        using var listener = new PooledMeterListener();
        using var forwarder = CreateForwarder();
        _sourceMeter.CreateCounter<double>("attempt_count").Add(1, CreateLabels());
        _sourceMeter.CreateHistogram<long>("attempt_latencies").Record(1, CreateLabels());
        _sourceMeter.CreateUpDownCounter<long>("attempt_count").Add(1, CreateLabels());
        _sourceMeter.CreateObservableCounter<long>("attempt_count", () => new Measurement<long>(1, CreateLabels()));
        _sourceMeter.CreateObservableGauge<double>("attempt_latencies", () => new Measurement<double>(1.0, CreateLabels()));
        Assert.Empty(listener.Measurements);
    }

    [Fact]
    public void Record_MissingResourceLabel_IsDropped()
    {
        using var listener = new PooledMeterListener();
        using var forwarder = CreateForwarder();
        var labels = CreateLabels().Where(pair => pair.Key != "instance_id").ToArray();
        _sourceMeter.CreateCounter<long>("attempt_count").Add(1, labels);
        Assert.Empty(listener.Measurements);
    }

    [Fact]
    public void Record_AfterDispose_IsIgnored()
    {
        using var listener = new PooledMeterListener();
        var counter = _sourceMeter.CreateCounter<long>("attempt_count");
        CreateForwarder().Dispose();
        counter.Add(1, CreateLabels());
        Assert.Empty(listener.Measurements);
    }

    [Fact]
    public void Record_ProviderSetupFails_DoesNotThrow()
    {
        using var env = new TemporaryEnvironmentVariable("OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY", "bogus");
        using var forwarder = CreateForwarder();
        Assert.Null(Record.Exception(() => _sourceMeter.CreateCounter<long>("attempt_count").Add(1, CreateLabels())));
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task Record_SpannerClientExecuteSql_ForwardsAllMetricsWithoutResourceLabels(bool asyncCall)
    {
        using var listener = new PooledMeterListener();
        using var forwarder = CreateForwarder();
        var client = new SpannerClientBuilder { CallInvoker = new FakeSpannerCallInvoker() }.Build();
        string databaseId = $"db-{Guid.NewGuid():N}";
        var session = SessionName.FromProjectInstanceDatabaseSession("project", "instance", databaseId, "session");
        var request = new ExecuteSqlRequest { SessionAsSessionName = session, Sql = "SELECT 1" };

        Exception exception = asyncCall
            ? await Record.ExceptionAsync(() => client.ExecuteSqlAsync(request))
            : Record.Exception(() => client.ExecuteSql(request));
        Assert.IsType<RpcException>(exception);

        var measurements = listener.Measurements
            .Where(m => m.Labels.TryGetValue("database", out var db) && (string) db == databaseId).ToList();
        string[] expectedInstruments =
            ["attempt_count", "attempt_latencies", "gfe_latencies", "operation_count", "operation_latencies"];
        Assert.Equal(expectedInstruments, measurements.Select(m => m.InstrumentName).OrderBy(n => n, StringComparer.Ordinal));
        Assert.Single(measurements.Select(m => m.MeterName).Distinct());
        Assert.Equal(12.5, Assert.Single(measurements, m => m.InstrumentName == "gfe_latencies").Value);

        string operationMethod = asyncCall ? nameof(SpannerClient.ExecuteSqlAsync) : nameof(SpannerClient.ExecuteSql);
        Assert.All(measurements, m =>
        {
            bool isCount = m.InstrumentName.EndsWith("_count", StringComparison.Ordinal);
            Assert.Equal(isCount ? "1" : "ms", m.Unit);
            Assert.True(isCount ? 1L.Equals(m.Value) : Assert.IsType<double>(m.Value) >= 0.0);
            bool isOperation = m.InstrumentName.StartsWith("operation_", StringComparison.Ordinal);
            Assert.Equal(isOperation ? operationMethod : nameof(SpannerClient.ExecuteSql), m.Labels["method"]);
            Assert.Equal(nameof(StatusCode.NotFound), m.Labels["status"]);
            Assert.DoesNotContain(ServiceMetricsConfiguration.Spanner.ResourceLabelNames, m.Labels.ContainsKey);
        });
    }

    internal static KeyValuePair<string, object>[] CreateLabels(string instanceId = "instance") =>
    [
        new("project_id", "project"), new("instance_id", instanceId), new("location", "us-central1"),
        new("instance_config", "regional-us-central1"), new("client_hash", "0000ff"), new("database", "database")
    ];

    private static MetricForwarder CreateForwarder() =>
        new(ServiceMetricsConfiguration.All, new RecordingHandler(), GoogleCredential.FromAccessToken("token"), new FakeClock());

    private sealed class FakeSpannerCallInvoker : CallInvoker
    {
        private static readonly Status s_notFound = new(StatusCode.NotFound, "not found");
        private static readonly Metadata s_headers = new() { { "server-timing", "gfet4t7; dur=12.5" } };

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            new(Task.FromException<TResponse>(new RpcException(s_notFound)), Task.FromResult(s_headers),
                () => s_notFound, () => new Metadata(), () => { });

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            Method<TRequest, TResponse> m, string host, CallOptions o, TRequest req) => throw new NotSupportedException();
        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            Method<TRequest, TResponse> m, string host, CallOptions o, TRequest req) => throw new NotSupportedException();
        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(
            Method<TRequest, TResponse> m, string host, CallOptions o) => throw new NotSupportedException();
        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
            Method<TRequest, TResponse> m, string host, CallOptions o) => throw new NotSupportedException();
    }
}
