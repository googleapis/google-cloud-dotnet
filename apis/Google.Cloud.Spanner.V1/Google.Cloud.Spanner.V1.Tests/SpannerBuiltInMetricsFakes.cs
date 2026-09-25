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

using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Tests;

// Test doubles shared by the built-in metrics tests.
internal class FakeStopwatch : SpannerBuiltInMetrics.IStopwatch
{
    public double ElapsedMilliseconds { get; set; }
    public bool Stopped { get; private set; }
    public void Stop() => Stopped = true;
}

internal class FakeStopwatchProvider : SpannerBuiltInMetrics.IStopwatchProvider
{
    public double ElapsedTimeMs { get; } = 123.0;
    public SpannerBuiltInMetrics.IStopwatch StartNew() => new FakeStopwatch { ElapsedMilliseconds = ElapsedTimeMs };
}

internal class FakeAsyncStreamReader<T>(IEnumerable<T> items, Exception exception = null) : IAsyncStreamReader<T>
{
    private readonly IEnumerator<T> _enumerator = items.GetEnumerator();

    public T Current => _enumerator.Current;

    public Task<bool> MoveNext(CancellationToken cancellationToken) =>
        exception is null ? Task.FromResult(_enumerator.MoveNext()) : Task.FromException<bool>(exception);
}

internal class FakeCallInvoker(Metadata responseHeaders, StatusCode status = StatusCode.OK) : CallInvoker
{
    private readonly RpcException _exception =
        status == StatusCode.OK ? null : new RpcException(new Status(status, "Test error"));

    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
        new AsyncUnaryCall<TResponse>(
            _exception is null ? Task.FromResult(CreateResponse<TResponse>()) : Task.FromException<TResponse>(_exception),
            Task.FromResult(responseHeaders),
            GetStatus,
            () => new Metadata(),
            () => { });

    public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
        new AsyncServerStreamingCall<TResponse>(
            _exception is null
                ? new FakeAsyncStreamReader<TResponse>([CreateResponse<TResponse>()])
                : new FakeAsyncStreamReader<TResponse>([], _exception),
            Task.FromResult(responseHeaders),
            GetStatus,
            () => new Metadata(),
            () => { });

    public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
        throw new NotImplementedException("BlockingUnaryCall should not be invoked when ResponseMetadataHandler is configured");

    public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
        throw new NotImplementedException();

    public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
        throw new NotImplementedException();

    private Status GetStatus() => _exception?.Status ?? Status.DefaultSuccess;

    private static TResponse CreateResponse<TResponse>() => (TResponse) Activator.CreateInstance(typeof(TResponse));
}

// A single telemetry measurement event captured from the built-in metrics meter.
internal class Measurement(string name, object value, KeyValuePair<string, object>[] tags)
{
    public string Name { get; } = name;
    public object Value { get; } = value;

    public string GetTag(string key) => tags.FirstOrDefault(t => t.Key == key).Value?.ToString();
}

internal static class MetricsCapture
{
    internal static Task<IReadOnlyList<Measurement>> RunWithMeterListenerAsync(Action action) =>
        RunWithMeterListenerAsync(() =>
        {
            action();
            return Task.CompletedTask;
        });

    internal static async Task<IReadOnlyList<Measurement>> RunWithMeterListenerAsync(Func<Task> action)
    {
        // Use a thread-safe collection because metrics (such as attempt latency and server-timing)
        // are emitted concurrently across threads during call completion.
        var measurements = new ConcurrentQueue<Measurement>();
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
            measurements.Enqueue(new Measurement(instrument.Name, measurement, tags.ToArray())));
        listener.SetMeasurementEventCallback<long>((instrument, measurement, tags, state) =>
            measurements.Enqueue(new Measurement(instrument.Name, measurement, tags.ToArray())));

        // Start listening and execute the action that emits metrics
        listener.Start();
        await action();
        listener.Dispose();

        return measurements.ToList();
    }
}
