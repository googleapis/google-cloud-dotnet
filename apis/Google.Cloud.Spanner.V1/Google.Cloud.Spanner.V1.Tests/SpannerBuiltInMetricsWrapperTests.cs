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

using NSubstitute;
using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsWrapperTests
{
    private static readonly Grpc.Core.Status s_timeoutStatus = new(Grpc.Core.StatusCode.DeadlineExceeded, "timeout");
    private static readonly Exception s_rpcException = new Grpc.Core.RpcException(s_timeoutStatus);

    [Fact]
    public void WrapperOverridesAllCoreVirtualMethods()
    {
        var baseType = typeof(SpannerClient);
        var wrapperType = typeof(SpannerBuiltInMetrics).GetNestedType("BuiltInMetricsWrapper", BindingFlags.NonPublic);
        var methods = baseType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        var missedMethods = new System.Collections.Generic.List<string>();
        foreach (var m in methods)
        {
            if (m.IsVirtual && !m.IsFinal)
            {
                var parameters = m.GetParameters();
                if (parameters.Length == 2 &&
                    typeof(Google.Protobuf.IMessage).IsAssignableFrom(parameters[0].ParameterType) &&
                    parameters[1].ParameterType == typeof(Google.Api.Gax.Grpc.CallSettings))
                {
                    var paramTypes = parameters.Select(p => p.ParameterType).ToArray();
                    var wm = wrapperType.GetMethod(m.Name, paramTypes);
                    if (wm == null || wm.DeclaringType != wrapperType)
                    {
                        missedMethods.Add(m.Name);
                    }
                }
            }
        }
        Assert.Empty(missedMethods);
    }


    [Fact]
    public async Task ConsecutiveCalls_RecordsMultipleMetrics()
    {
        var mockClient = Substitute.For<SpannerClient>();
        mockClient.ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), null).Returns(Task.FromResult(new ResultSet()));

        var wrapper = new SpannerBuiltInMetrics.BuiltInMetricsWrapper(mockClient);

        using var meterListener = CreateMeterListener(out var recordedData);
        meterListener.Start();

        var request = new ExecuteSqlRequest();

        // Execute exactly 3 repeated payload invocations.
        await wrapper.ExecuteSqlAsync(request, null);
        await wrapper.ExecuteSqlAsync(request, null);
        await wrapper.ExecuteSqlAsync(request, null);

        meterListener.RecordObservableInstruments();

        // Evaluate numerical accrual constraints robustly.
        Assert.Equal(3, recordedData.CountRecordings);
        Assert.Equal(3, recordedData.LatencyRecordings);
        Assert.Equal(nameof(SpannerClient.ExecuteSqlAsync), recordedData.Method);
        Assert.Equal(Grpc.Core.StatusCode.OK.ToString(), recordedData.Status);
    }


    [Theory]
    [MemberData(nameof(SuccessfulResponses))]
    public async Task RecordsTelemetryOnSuccess(
        Action<SpannerClient> setupClient,
        Func<SpannerClient, Task> invoke,
        string expectedMethod,
        string expectedStatus)
    {
        var mockClient = Substitute.For<SpannerClient>();
        setupClient(mockClient);

        var wrapper = new SpannerBuiltInMetrics.BuiltInMetricsWrapper(mockClient);

        using var meterListener = CreateMeterListener(out var recordedData);
        meterListener.Start();

        await invoke(wrapper);

        meterListener.RecordObservableInstruments();
        AssertRecordedData(recordedData, expectedMethod, expectedStatus);
    }

    [Theory]
    [MemberData(nameof(UnsuccessfulResponses))]
    public async Task RecordsTelemetryOnException(
        Action<SpannerClient> setupClient,
        Func<SpannerClient, Task> invoke,
        string expectedMethod,
        string expectedStatus,
        Exception expectedException)
    {
        var mockClient = Substitute.For<SpannerClient>();
        setupClient(mockClient);

        var wrapper = new SpannerBuiltInMetrics.BuiltInMetricsWrapper(mockClient);

        using var meterListener = CreateMeterListener(out var recordedData);
        meterListener.Start();

        var thrownException = await Assert.ThrowsAnyAsync<Exception>(() => invoke(wrapper));
        Assert.Equal(expectedException.GetType(), thrownException.GetType());

        meterListener.RecordObservableInstruments();
        AssertRecordedData(recordedData, expectedMethod, expectedStatus);
    }

    public static TheoryData<Action<SpannerClient>, Func<SpannerClient, Task>, string, string> SuccessfulResponses => new()
    {
        {
            c => c.CreateSession(Arg.Any<CreateSessionRequest>(), null).Returns(new Session()),
            w => { w.CreateSession(new CreateSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.CreateSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.CreateSessionAsync(Arg.Any<CreateSessionRequest>(), null).Returns(Task.FromResult(new Session())),
            w => w.CreateSessionAsync(new CreateSessionRequest(), null),
            nameof(SpannerClient.CreateSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.BatchCreateSessions(Arg.Any<BatchCreateSessionsRequest>(), null).Returns(new BatchCreateSessionsResponse()),
            w => { w.BatchCreateSessions(new BatchCreateSessionsRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.BatchCreateSessions),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.BatchCreateSessionsAsync(Arg.Any<BatchCreateSessionsRequest>(), null).Returns(Task.FromResult(new BatchCreateSessionsResponse())),
            w => w.BatchCreateSessionsAsync(new BatchCreateSessionsRequest(), null),
            nameof(SpannerClient.BatchCreateSessionsAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.GetSession(Arg.Any<GetSessionRequest>(), null).Returns(new Session()),
            w => { w.GetSession(new GetSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.GetSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.GetSessionAsync(Arg.Any<GetSessionRequest>(), null).Returns(Task.FromResult(new Session())),
            w => w.GetSessionAsync(new GetSessionRequest(), null),
            nameof(SpannerClient.GetSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.ListSessions(Arg.Any<ListSessionsRequest>(), null).Returns((Google.Api.Gax.PagedEnumerable<ListSessionsResponse, Session>)null),
            w => { w.ListSessions(new ListSessionsRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ListSessions),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ListSessionsAsync(Arg.Any<ListSessionsRequest>(), null).Returns((Google.Api.Gax.PagedAsyncEnumerable<ListSessionsResponse, Session>)null),
            w => { w.ListSessionsAsync(new ListSessionsRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ListSessionsAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.DeleteSession(Arg.Any<DeleteSessionRequest>(), null),
            w => { w.DeleteSession(new DeleteSessionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.DeleteSession),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.DeleteSessionAsync(Arg.Any<DeleteSessionRequest>(), null).Returns(Task.CompletedTask),
            w => w.DeleteSessionAsync(new DeleteSessionRequest(), null),
            nameof(SpannerClient.DeleteSessionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.ExecuteSql(Arg.Any<ExecuteSqlRequest>(), null).Returns(new ResultSet()),
            w => { w.ExecuteSql(new ExecuteSqlRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteSql),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ExecuteSqlAsync(Arg.Any<ExecuteSqlRequest>(), null).Returns(Task.FromResult(new ResultSet())),
            w => w.ExecuteSqlAsync(new ExecuteSqlRequest(), null),
            nameof(SpannerClient.ExecuteSqlAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.ExecuteBatchDml(Arg.Any<ExecuteBatchDmlRequest>(), null).Returns(new ExecuteBatchDmlResponse()),
            w => { w.ExecuteBatchDml(new ExecuteBatchDmlRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteBatchDml),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ExecuteBatchDmlAsync(Arg.Any<ExecuteBatchDmlRequest>(), null).Returns(Task.FromResult(new ExecuteBatchDmlResponse())),
            w => w.ExecuteBatchDmlAsync(new ExecuteBatchDmlRequest(), null),
            nameof(SpannerClient.ExecuteBatchDmlAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Read(Arg.Any<ReadRequest>(), null).Returns(new ResultSet()),
            w => { w.Read(new ReadRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Read),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.ReadAsync(Arg.Any<ReadRequest>(), null).Returns(Task.FromResult(new ResultSet())),
            w => w.ReadAsync(new ReadRequest(), null),
            nameof(SpannerClient.ReadAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.BeginTransaction(Arg.Any<BeginTransactionRequest>(), null).Returns(new Transaction()),
            w => { w.BeginTransaction(new BeginTransactionRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.BeginTransaction),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.BeginTransactionAsync(Arg.Any<BeginTransactionRequest>(), null).Returns(Task.FromResult(new Transaction())),
            w => w.BeginTransactionAsync(new BeginTransactionRequest(), null),
            nameof(SpannerClient.BeginTransactionAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Commit(Arg.Any<CommitRequest>(), null).Returns(new CommitResponse()),
            w => { w.Commit(new CommitRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Commit),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.CommitAsync(Arg.Any<CommitRequest>(), null).Returns(Task.FromResult(new CommitResponse())),
            w => w.CommitAsync(new CommitRequest(), null),
            nameof(SpannerClient.CommitAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.Rollback(Arg.Any<RollbackRequest>(), null),
            w => { w.Rollback(new RollbackRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.Rollback),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.RollbackAsync(Arg.Any<RollbackRequest>(), null).Returns(Task.CompletedTask),
            w => w.RollbackAsync(new RollbackRequest(), null),
            nameof(SpannerClient.RollbackAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.PartitionQuery(Arg.Any<PartitionQueryRequest>(), null).Returns(new PartitionResponse()),
            w => { w.PartitionQuery(new PartitionQueryRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.PartitionQuery),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.PartitionQueryAsync(Arg.Any<PartitionQueryRequest>(), null).Returns(Task.FromResult(new PartitionResponse())),
            w => w.PartitionQueryAsync(new PartitionQueryRequest(), null),
            nameof(SpannerClient.PartitionQueryAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },

        {
            c => c.PartitionRead(Arg.Any<PartitionReadRequest>(), null).Returns(new PartitionResponse()),
            w => { w.PartitionRead(new PartitionReadRequest(), null); return Task.CompletedTask; },
            nameof(SpannerClient.PartitionRead),
            Grpc.Core.StatusCode.OK.ToString()
        },
        {
            c => c.PartitionReadAsync(Arg.Any<PartitionReadRequest>(), null).Returns(Task.FromResult(new PartitionResponse())),
            w => w.PartitionReadAsync(new PartitionReadRequest(), null),
            nameof(SpannerClient.PartitionReadAsync),
            Grpc.Core.StatusCode.OK.ToString()
        },
    };

    public static TheoryData<Action<SpannerClient>, Func<SpannerClient, Task>, string, string, Exception> UnsuccessfulResponses => new()
    {
        {
            client => client.ExecuteSql(Arg.Any<ExecuteSqlRequest>(), null).Returns(x => throw s_rpcException),
            wrapper => { wrapper.ExecuteSql(new ExecuteSqlRequest { Session = "projects/p/instances/i/databases/d/sessions/s" }, null); return Task.CompletedTask; },
            nameof(SpannerClient.ExecuteSql),
            Grpc.Core.StatusCode.DeadlineExceeded.ToString(),
            s_rpcException
        },
        {
            client => client.CommitAsync(Arg.Any<CommitRequest>(), null).Returns(Task.FromException<CommitResponse>(new InvalidOperationException("boom"))),
            wrapper => wrapper.CommitAsync(new CommitRequest { Session = "projects/p/instances/i/databases/d/sessions/s" }, null),
            nameof(SpannerClient.CommitAsync),
            Grpc.Core.StatusCode.Unknown.ToString().ToUpperInvariant(),
            new InvalidOperationException("boom")
        }
    };

    private class RecordedData
    {
        public int CountRecordings { get; set; }
        public int LatencyRecordings { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
    }

    private static MeterListener CreateMeterListener(out RecordedData recordedData)
    {
        var data = new RecordedData();
        recordedData = data;

        var listener = new MeterListener();
        listener.InstrumentPublished = (instrument, l) =>
        {
            if (instrument.Name == "operation_count" || instrument.Name == "operation_latencies")
            {
                l.EnableMeasurementEvents(instrument);
            }
        };

        listener.SetMeasurementEventCallback<long>((instrument, measurement, tags, state) =>
        {
            if (instrument.Name == "operation_count")
            {
                data.CountRecordings++;
                data.Status = tags.ToArray().FirstOrDefault(t => t.Key == "status").Value?.ToString();
                data.Method = tags.ToArray().FirstOrDefault(t => t.Key == "method").Value?.ToString();
            }
        });

        listener.SetMeasurementEventCallback<double>((instrument, measurement, tags, state) =>
        {
            if (instrument.Name == "operation_latencies")
            {
                data.LatencyRecordings++;
            }
        });

        return listener;
    }

    private static void AssertRecordedData(RecordedData data, string expectedMethod, string expectedStatus)
    {
        Assert.Equal(1, data.CountRecordings);
        Assert.Equal(1, data.LatencyRecordings);
        Assert.Equal(expectedMethod, data.Method);
        Assert.Equal(expectedStatus, data.Status);
    }
}
