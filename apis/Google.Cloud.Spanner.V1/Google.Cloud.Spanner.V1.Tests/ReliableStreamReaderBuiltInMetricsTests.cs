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

using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.Tests.MetricsCapture;
using static Google.Cloud.Spanner.V1.Tests.SpannerBuiltInMetricsInterceptorTests;
using static Google.Cloud.Spanner.V1.Tests.SpannerBuiltInMetricsWrapperTests;

namespace Google.Cloud.Spanner.V1.Tests;

public class ReliableStreamReaderBuiltInMetricsTests
{
    private static readonly SpannerBuiltInMetrics.ClientIdentity s_readerClientIdentity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
    private static readonly ExecuteSqlRequest s_request = new() { SessionAsSessionName = s_sessionName };

    public static TheoryData<Exception, StatusCode> StreamCompletionCases => new()
    {
        { null, StatusCode.OK },
        { new RpcException(new Status(StatusCode.NotFound, "Test")), StatusCode.NotFound },
        { new RpcException(new Status(StatusCode.DeadlineExceeded, "Test")), StatusCode.DeadlineExceeded },
        { new RpcException(new Status(StatusCode.Cancelled, "Cancelled")), StatusCode.Cancelled },
        { new OperationCanceledException("Operation was cancelled."), StatusCode.Unknown },
    };

    [Theory]
    [MemberData(nameof(StreamCompletionCases))]
    public async Task ConsumedStream_EmitsMetrics(Exception exception, StatusCode expectedStatus)
    {
        var (reader, stopwatch) = CreateReader(exception);

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            if (exception is not null)
            {
                var thrown = await Assert.ThrowsAnyAsync<Exception>(() => ConsumeReaderAsync(reader));
                Assert.Equal(exception.Message, thrown.Message);
            }
            else
            {
                await ConsumeReaderAsync(reader);
            }
        });

        AssertRecordedData(measurements, s_readerClientIdentity.Id, "ExecuteStreamingSql", expectedStatus.ToString());
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task ClosedBeforeCompletion_Emits()
    {
        var (reader, stopwatch) = CreateReader();

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            await reader.NextAsync(CancellationToken.None);
            reader.Close();
        });

        AssertRecordedData(measurements, s_readerClientIdentity.Id, "ExecuteStreamingSql", StatusCode.Unknown.ToString());
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task DisposedBeforeCompletion_Emits()
    {
        var (reader, stopwatch) = CreateReader();

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            await reader.NextAsync(CancellationToken.None);
            reader.Dispose();
        });

        AssertRecordedData(measurements, s_readerClientIdentity.Id, "ExecuteStreamingSql", StatusCode.Unknown.ToString());
        Assert.True(stopwatch.Stopped);
    }

    [Fact]
    public async Task ClosedAfterCompletion_EmitsOnce()
    {
        var (reader, stopwatch) = CreateReader();

        var measurements = await RunWithMeterListenerAsync(async () =>
        {
            // Only the first call should result in metrics being emitted
            await ConsumeReaderAsync(reader);
            reader.Close();
            reader.Dispose();
        });

        AssertRecordedData(measurements, s_readerClientIdentity.Id, "ExecuteStreamingSql", StatusCode.OK.ToString());
        Assert.True(stopwatch.Stopped);
    }

    private static (ReliableStreamReader reader, FakeStopwatch stopwatch) CreateReader(Exception exception = null)
    {
        var stopwatch = (FakeStopwatch) s_stopwatchProvider.StartNew();
        var resultSet = new PartialResultSet
        {
            Values = { Value.ForString("val1"), Value.ForString("val2") },
            Metadata = new ResultSetMetadata
            {
                RowType = new StructType
                {
                    Fields = { new StructType.Types.Field { Name = "col1", Type = new Type { Code = TypeCode.String } } }
                }
            }
        };

        var fakeStream = new FakeAsyncStreamReader<PartialResultSet>([resultSet], exception);
        var reader = new ReliableStreamReader(
            fakeStream,
            Logger.DefaultLogger,
            stopwatch,
            "ExecuteStreamingSql",
            s_request,
            s_readerClientIdentity);
        return (reader, stopwatch);
    }

    private static async Task ConsumeReaderAsync(ReliableStreamReader reader)
    {
        while (await reader.NextAsync(CancellationToken.None) != null)
        {
        }
    }
}
