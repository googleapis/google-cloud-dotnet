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
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.Tests.MetricsCapture;
using static Google.Cloud.Spanner.V1.Tests.SpannerBuiltInMetricsInterceptorTests;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsInstrumentedAsyncStreamReaderTests
{
    private static readonly SpannerBuiltInMetrics.ClientIdentity s_readerClientIdentity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
    private static readonly ExecuteSqlRequest s_request = new() { SessionAsSessionName = s_sessionName };

    public static TheoryData<int[]> StreamItems => new()
    {
        { [] },
        { [1] },
        { [1, 2, 3] },
    };

    [Theory]
    [MemberData(nameof(StreamItems))]
    public async Task ConsumedStream_Success_EmitsMetrics(int[] items)
    {
        var (reader, stopwatch) = CreateReader(items);

        var measurements = await RunWithMeterListenerAsync(() => ConsumeReaderAsync(reader));

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: "ExecuteStreamingSql", clientIdentity: s_readerClientIdentity);
        Assert.True(stopwatch.Stopped);
    }

    public static TheoryData<Exception, StatusCode> StreamExceptions => new()
    {
        { new RpcException(new Status(StatusCode.NotFound, "Test")), StatusCode.NotFound },
        { new RpcException(new Status(StatusCode.DeadlineExceeded, "Test")), StatusCode.DeadlineExceeded },
        { new RpcException(new Status(StatusCode.Cancelled, "Cancelled")), StatusCode.Cancelled },
        { new InvalidOperationException("Test"), StatusCode.Unknown },
    };

    [Theory]
    [MemberData(nameof(StreamExceptions))]
    public async Task ConsumedStream_Failure_EmitsMetrics(Exception exception, StatusCode expectedStatus)
    {
        var (reader, stopwatch) = CreateReader(exception: exception);

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            var thrown = await Assert.ThrowsAnyAsync<Exception>(() => ConsumeReaderAsync(reader));
            Assert.Same(exception, thrown);
        });

        ValidateEmittedMetrics(measurements, expectedStatus, methodName: "ExecuteStreamingSql", clientIdentity: s_readerClientIdentity);
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task EmitMetrics_RecordsOnce()
    {
        var (reader, stopwatch) = CreateReader();

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            await ConsumeReaderAsync(reader);

            // Try to emit more metrics, these should be No-Op
            await reader.EmitMetricsAsync();
            await reader.EmitMetricsAsync();
            await ConsumeReaderAsync(reader);
        });

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: "ExecuteStreamingSql", clientIdentity: s_readerClientIdentity);
        Assert.True(stopwatch.Stopped);
    }

    /// <summary>
    /// Consumes all elements from an <see cref="IAsyncStreamReader{T}"/> until completion.
    /// </summary>
    internal static async Task ConsumeReaderAsync<T>(IAsyncStreamReader<T> reader)
    {
        while (await reader.MoveNext(default).ConfigureAwait(false))
        {
        }
    }

    private static (SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int> reader, FakeStopwatch stopwatch)
        CreateReader(int[] items = null, Exception exception = null)
    {
        var stopwatch = (FakeStopwatch) s_stopwatchProvider.StartNew();
        var reader = new SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int>(
            new FakeAsyncStreamReader<int>(items ?? [1, 2, 3], exception),
            stopwatch,
            "ExecuteStreamingSql",
            s_request,
            s_readerClientIdentity,
            Task.FromResult(s_serverTimingMetadata));
        return (reader, stopwatch);
    }
}
