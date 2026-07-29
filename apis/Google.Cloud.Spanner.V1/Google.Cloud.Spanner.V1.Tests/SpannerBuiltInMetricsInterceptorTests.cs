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

using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsInterceptorTests
{
    private const string TestProjectId = "test-project";
    private const string TestInstanceId = "test-instance";
    private const string TestDatabaseId = "test-database";
    private const string TestMethodName = "TestMethod";

    private class FakeStopwatchProvider : SpannerBuiltInMetrics.IStopwatchProvider
    {
        public double ElapsedTimeMs { get; set; } = 123.0;

        public SpannerBuiltInMetrics.IStopwatch StartNew() => new FakeStopwatch(this);

        private class FakeStopwatch(FakeStopwatchProvider provider) : SpannerBuiltInMetrics.IStopwatch
        {
            public double ElapsedMilliseconds => provider.ElapsedTimeMs;
        }
    }

    private static readonly SpannerBuiltInMetrics.ClientIdentity s_clientIdentity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
    private static readonly FakeStopwatchProvider s_stopwatchProvider = new FakeStopwatchProvider();
    private static readonly SpannerBuiltInMetrics.MetricsInterceptor s_interceptor =
        new SpannerBuiltInMetrics.MetricsInterceptor(s_clientIdentity, s_stopwatchProvider);

    private static readonly FakeRequest s_fakeRequest = new FakeRequest();
    private static readonly ClientInterceptorContext<FakeRequest, string> s_unaryContext = CreateContext(MethodType.Unary);

    private static readonly Exception s_exception = new RpcException(new Status(StatusCode.DeadlineExceeded, "Test"));
    private static readonly Metadata s_metadataWithGfe = new Metadata { { "server-timing", "gfet4t7; dur=12.5" } };

    public static TheoryData<Func<Task>> SuccessCalls => new TheoryData<Func<Task>>
    {
        () =>
        {
            var call = s_interceptor.AsyncUnaryCall(
                s_fakeRequest,
                s_unaryContext,
                (req, ctx) => new AsyncUnaryCall<string>(
                    Task.FromResult("1"),
                    Task.FromResult(s_metadataWithGfe),
                    () => Status.DefaultSuccess,
                    () => new Metadata(),
                    () => { }));
            return call.ResponseAsync;
        },

        () =>
        {
            s_interceptor.BlockingUnaryCall(
                s_fakeRequest,
                s_unaryContext,
                (req, ctx) => "1");
            return Task.CompletedTask;
        },
    };

    public static TheoryData<Func<Task>> ExceptionCalls => new TheoryData<Func<Task>>
    {
        () =>
        {
            var call = s_interceptor.AsyncUnaryCall(
                s_fakeRequest,
                s_unaryContext,
                (req, ctx) => new AsyncUnaryCall<string>(
                    Task.FromException<string>(s_exception),
                    Task.FromResult(s_metadataWithGfe),
                    () => ((RpcException)s_exception).Status,
                    () => new Metadata(),
                    () => { }));
            return call.ResponseAsync;
        },

        () =>
        {
            s_interceptor.BlockingUnaryCall(
                s_fakeRequest, s_unaryContext, (req, ctx) => throw s_exception);
            return Task.CompletedTask;
        },
    };

    [Theory]
    [MemberData(nameof(SuccessCalls))]
    public async Task RecordsMetrics_Success(Func<Task> makeCall)
    {
        var measurements = await RunWithMeterListenerAsync(makeCall);
        ValidateEmittedMetrics(measurements, StatusCode.OK);
    }

    [Theory]
    [MemberData(nameof(ExceptionCalls))]
    public async Task RecordsMetrics_Exception(Func<Task> makeCall)
    {
        var measurements = await RunWithMeterListenerAsync(() => Assert.ThrowsAnyAsync<RpcException>(makeCall));
        ValidateEmittedMetrics(measurements, StatusCode.DeadlineExceeded);
    }

    [Fact]
    public async Task RetrySimulation_RecordsMultipleAttempts()
    {
        var exceptionCall = new AsyncUnaryCall<string>(
            Task.FromException<string>(s_exception),
            Task.FromResult(new Metadata()),
            () => ((RpcException)s_exception).Status,
            () => new Metadata(),
            () => { });

        var successCall = new AsyncUnaryCall<string>(
            Task.FromResult(""),
            Task.FromResult(new Metadata()),
            () => Status.DefaultSuccess,
            () => new Metadata(),
            () => { });

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            await Assert.ThrowsAnyAsync<RpcException>(() => s_interceptor.AsyncUnaryCall(
                s_fakeRequest, s_unaryContext, (req, ctx) => exceptionCall).ResponseAsync);

            await s_interceptor.AsyncUnaryCall(
                s_fakeRequest, s_unaryContext, (req, ctx) => successCall).ResponseAsync;
        });

        var attemptCountMetrics = measurements
            .Where(m => m.Name == "attempt_count")
            .Where(m => m.Tags.Any(t => t.Key == "method" && (string)t.Value == TestMethodName))
            .ToList();

        var recordedStatuses = attemptCountMetrics
            .SelectMany(m => m.Tags.Where(t => t.Key == "status"))
            .Select(t => (string)t.Value)
            .ToList();

        // Validate strictly that precisely 1 retry loop (DeadlineExceeded) and 1 succeeding attempt (OK) were thoroughly logged.
        Assert.Equal(2, recordedStatuses.Count);
        Assert.Contains("DeadlineExceeded", recordedStatuses);
        Assert.Contains("OK", recordedStatuses);
    }

    public static TheoryData<string, double?, double?> ServerTimingTestCases => new()
    {
        { "gfet4t7; dur=12.5", 12.5, null },
        { "gfet4t7; dur = 42", 42.0, null },
        { "other; dur=5, gfet4t7; dur=12.5", 12.5, null },
        { "other_metric; dur=12.5", null, null },
        { "not_gfet4t7; dur=99.0", null, null },
        { "not_afe; dur=99.0", null, null },
        { "gfet4t7; dur=invalid", null, null },
    };

    [Theory]
    [MemberData(nameof(ServerTimingTestCases))]
    public async Task RecordsMetrics_AsyncUnaryCall_ExtractsServerTiming(
        string serverTimingHeader,
        double? expectedGfeLatency,
        double? expectedAfeLatency)
    {
        var metadata = new Metadata { { "server-timing", serverTimingHeader } };

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            await s_interceptor.AsyncUnaryCall(
                s_fakeRequest,
                s_unaryContext,
                (req, ctx) => new AsyncUnaryCall<string>(
                    Task.FromResult("1"),
                    Task.FromResult(metadata),
                    () => Status.DefaultSuccess,
                    () => new Metadata(),
                    () => { })).ResponseAsync;
        });


    private static void ValidateServerTimingMeasurements(
        IEnumerable<Measurement> measurements,
        double? expectedGfeLatency,
        double? expectedAfeLatency)
    {
        var testMeasurements = measurements
            .Where(m => m.Tags.Any(t => t.Key == "method" && (string)t.Value == TestMethodName))
            .ToList();

        var recordedLatencies = testMeasurements
            .Where(m => m.Name == "gfe_latencies")
            .Select(m => (double)m.Value)
            .ToList();

        if (expectedGfeLatency.HasValue)
        {
            Assert.Contains(expectedGfeLatency.Value, recordedLatencies);
        }
        if (expectedAfeLatency.HasValue)
        {
            Assert.Contains(expectedAfeLatency.Value, recordedLatencies);
        }
        if (!expectedGfeLatency.HasValue && !expectedAfeLatency.HasValue)
        {
            Assert.Empty(recordedLatencies);
        }
    }

    // Represents a successfully captured telemetry metric measurement event.
    private record Measurement(string Name, object Value, KeyValuePair<string, object>[] Tags);

    /// <summary>
    /// Verifies that the attempt level built in metrics were recorded
    /// </summary>
    private static void ValidateEmittedMetrics(IEnumerable<Measurement> measurements, StatusCode expectedStatus)
    {
        var testMeasurements = measurements.Where(m => m.Tags.Any(t => t.Key == "method" && (string)t.Value == TestMethodName)).ToList();

        // Assert attempt count was recorded once.
        var attemptCount = testMeasurements.FirstOrDefault(m => m.Name == "attempt_count");
        Assert.NotNull(attemptCount);
        Assert.Equal(1L, (long)attemptCount.Value);
        ValidateMetricTags(attemptCount, expectedStatus);

        // Assert attempt latencies were recorded with the strictly injected fake duration.
        var attemptLatencies = testMeasurements.FirstOrDefault(m => m.Name == "attempt_latencies" && (double)m.Value == s_stopwatchProvider.ElapsedTimeMs);
        Assert.NotNull(attemptLatencies);
        ValidateMetricTags(attemptLatencies, expectedStatus);

        var gfeLatency = testMeasurements.FirstOrDefault(m => m.Name == "gfe_latencies");
        if (gfeLatency != null)
        {
            Assert.Equal(12.5, (double)gfeLatency.Value);
            ValidateMetricTags(gfeLatency, expectedStatus);
        }
    }

    /// <summary>
    /// Asserts all labels are properly generated.
    /// </summary>
    private static void ValidateMetricTags(Measurement measurement, StatusCode expectedStatus)
    {
        Assert.NotNull(measurement);
        var tags = measurement.Tags;
        Assert.Contains(tags, t => t.Key == "project_id" && (string)t.Value == TestProjectId);
        Assert.Contains(tags, t => t.Key == "instance_id" && (string)t.Value == TestInstanceId);
        Assert.Contains(tags, t => t.Key == "database" && (string)t.Value == TestDatabaseId);
        Assert.Contains(tags, t => t.Key == "method" && (string)t.Value == TestMethodName);
        Assert.Contains(tags, t => t.Key == "status" && (string)t.Value == expectedStatus.ToString());
        Assert.Contains(tags, t => t.Key == "client_hash" && (string)t.Value == s_clientIdentity.Hash);
        Assert.Contains(tags, t => t.Key == "client_uid" && (string)t.Value == s_clientIdentity.Id);
        Assert.Contains(tags, t => t.Key == "client_name" && !string.IsNullOrEmpty((string)t.Value));
        Assert.Contains(tags, t => t.Key == "location" && !string.IsNullOrEmpty((string)t.Value));
        Assert.Contains(tags, t => t.Key == "instance_config" && (string)t.Value == "unknown");
        Assert.Contains(tags, t => t.Key == "directpath_enabled" && (string)t.Value == "false");
        Assert.Contains(tags, t => t.Key == "directpath_used" && (string)t.Value == "false");
    }

    /// <summary>
    /// Executes the given async action while listening to the Spanner Built-In Metrics meter.
    /// </summary>
    private static async Task<IReadOnlyList<Measurement>> RunWithMeterListenerAsync(Func<Task> action)
    {
        var measurements = new List<Measurement>();
        using var listener = new MeterListener();

        // Arrange our listener so it tracks metrics on the BuiltInMetrics meter
        listener.InstrumentPublished = (instrument, l) =>
        {
            if (instrument.Meter.Name == SpannerBuiltInMetrics.MeterName)
            {
                l.EnableMeasurementEvents(instrument);
            }
        };

        // Record all metrics that are emitted
        listener.SetMeasurementEventCallback<double>((instrument, measurement, tags, state) =>
            measurements.Add(new Measurement(instrument.Name, measurement, tags.ToArray())));
        listener.SetMeasurementEventCallback<long>((instrument, measurement, tags, state) =>
            measurements.Add(new Measurement(instrument.Name, measurement, tags.ToArray())));

        // Start listening and execute the action that emits metrics
        listener.Start();
        await action();
        listener.Dispose();

        return measurements;
    }

    private class FakeRequest : IDatabaseNameProvider
    {
        public DatabaseName DatabaseName => DatabaseName.FromProjectInstanceDatabase(TestProjectId, TestInstanceId, TestDatabaseId);
        public string ProjectId => TestProjectId;
        public string InstanceId => TestInstanceId;
        public string DatabaseId => TestDatabaseId;
    }

    private static ClientInterceptorContext<FakeRequest, string> CreateContext(MethodType methodType) =>
        new ClientInterceptorContext<FakeRequest, string>(
            new Method<FakeRequest, string>(
                methodType,
                "SomeSession",
                TestMethodName,
                Marshallers.Create(req => Array.Empty<byte>(), bytes => new FakeRequest()),
                Marshallers.StringMarshaller),
            null,
            new CallOptions());

}
