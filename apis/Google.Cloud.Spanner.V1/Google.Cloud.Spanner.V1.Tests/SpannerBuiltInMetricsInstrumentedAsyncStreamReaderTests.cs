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
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsInstrumentedAsyncStreamReaderTests
{
    private const double TestElapsedMs = 42.0;

    public static TheoryData<Exception, StatusCode> StreamCompletionCases => new()
    {
        { null, StatusCode.OK },
        { new RpcException(new Status(StatusCode.NotFound, "Test")), StatusCode.NotFound },
        { new RpcException(new Status(StatusCode.DeadlineExceeded, "Test")), StatusCode.DeadlineExceeded },
        { new OperationCanceledException(), StatusCode.Unknown },
    };

    [Theory]
    [MemberData(nameof(StreamCompletionCases))]
    public async Task ConsumedStream_RecordsCompletion(Exception exception, StatusCode expectedStatus)
    {
        var completion = new CompletionCapture();
        var stopwatch = new FakeStopwatch { ElapsedMilliseconds = TestElapsedMs };
        var reader = CreateReader(stopwatch, completion, exception);

        await ConsumeReaderAsync(reader, exception);

        completion.AssertRecorded(expectedStatus, TestElapsedMs, expectedCallCount: 1);
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task ClosedBeforeCompletion_RecordsUnknown()
    {
        var completion = new CompletionCapture();
        var stopwatch = new FakeStopwatch { ElapsedMilliseconds = TestElapsedMs };
        var reader = CreateReader(stopwatch, completion);

        await reader.MoveNext(CancellationToken.None);
        reader.NotifyClosed();

        completion.AssertRecorded(StatusCode.Unknown, TestElapsedMs, expectedCallCount: 1);
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task ClosedAfterCompletion_RecordsOnce()
    {
        var completion = new CompletionCapture();
        var stopwatch = new FakeStopwatch { ElapsedMilliseconds = TestElapsedMs };
        var reader = CreateReader(stopwatch, completion);

        await ConsumeReaderAsync(reader);
        reader.NotifyClosed();

        // This completed successfully so we shouldn't record completion again.
        completion.AssertRecorded(StatusCode.OK, TestElapsedMs, expectedCallCount: 1);
    }

    private static SpannerBuiltInMetrics.InstrumentedAsyncStreamReader<int> CreateReader(
        FakeStopwatch stopwatch, CompletionCapture completion, Exception exception = null) =>
        new(new FakeAsyncStreamReader<int>([1, 2, 3], exception), stopwatch, completion.Record);

    private static async Task ConsumeReaderAsync(IAsyncStreamReader<int> reader, Exception exception = null)
    {
        if (exception is not null)
        {
            await Assert.ThrowsAnyAsync<Exception>(() => reader.MoveNext(CancellationToken.None));
            return;
        }

        while (await reader.MoveNext(CancellationToken.None))
        {
        }
    }

    private class CompletionCapture
    {
        private int _callCount;
        private double _elapsedMs;
        private StatusCode? _status;

        public void Record(double elapsedMs, StatusCode status)
        {
            _callCount++;
            _elapsedMs = elapsedMs;
            _status = status;
        }

        public void AssertRecorded(StatusCode expectedStatus, double expectedElapsedMs, int expectedCallCount)
        {
            Assert.Equal(expectedCallCount, _callCount);
            Assert.Equal(expectedStatus, _status);
            Assert.Equal(expectedElapsedMs, _elapsedMs);
        }
    }
}
