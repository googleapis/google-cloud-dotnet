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

using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.Tests.MetricsCapture;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerBuiltInMetricsInterceptorTests
{
    private const string TestProjectId = "test-project";
    private const string TestInstanceId = "test-instance";
    private const string TestDatabaseId = "test-database";

    private static readonly SpannerBuiltInMetrics.ClientIdentity s_clientIdentity = SpannerBuiltInMetrics.Labeler.GenerateIdentity();
    private static readonly FakeStopwatchProvider s_stopwatchProvider = new();
    private static readonly SpannerBuiltInMetrics.MetricsInterceptor s_interceptor = new(s_clientIdentity, s_stopwatchProvider);

    private static readonly Metadata s_serverTimingMetadata = new Metadata { { "server-timing", "gfet4t7; dur=12.5" } };
    private static readonly DatabaseName s_dbName = new(TestProjectId, TestInstanceId, TestDatabaseId);
    private static readonly SessionName s_sessionName = SessionName.FromProjectInstanceDatabaseSession(TestProjectId, TestInstanceId, TestDatabaseId, "test-session");

    private static SpannerClient CreateClient(FakeCallInvoker invoker) =>
        new SpannerClientBuilder
        {
            CallInvoker = invoker.Intercept(s_interceptor)
        }.Build();

    public static TheoryData<Action<SpannerClient>, string> SpannerClientSyncSuccessCases => new()
    {
        { client => client.CreateSession(s_dbName), "CreateSession" },
        { client => client.ExecuteSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), "ExecuteSql" },
        { client => client.Commit(new CommitRequest { SessionAsSessionName = s_sessionName }), "Commit" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientSyncSuccessCases))]
    public async Task SpannerClient_RecordsMetrics_Sync_Success(
        Action<SpannerClient> callSync,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata));

        var measurements = await RunWithMeterListenerAsync(() => callSync(client));

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: expectedMethod);
    }

    public static TheoryData<Action<SpannerClient>, StatusCode, string> SpannerClientSyncFailureCases => new()
    {
        { client => client.CreateSession(s_dbName), StatusCode.Unknown, "CreateSession" },
        { client => client.CreateSession(s_dbName), StatusCode.DeadlineExceeded, "CreateSession" },
        { client => client.ExecuteSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), StatusCode.Unknown, "ExecuteSql" },
        { client => client.ExecuteSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), StatusCode.DeadlineExceeded, "ExecuteSql" },
        { client => client.Commit(new CommitRequest { SessionAsSessionName = s_sessionName }), StatusCode.Unknown, "Commit" },
        { client => client.Commit(new CommitRequest { SessionAsSessionName = s_sessionName }), StatusCode.DeadlineExceeded, "Commit" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientSyncFailureCases))]
    public async Task SpannerClient_RecordsMetrics_Sync_Failure(
        Action<SpannerClient> callSync,
        StatusCode expectedStatus,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata, expectedStatus));

        var measurements = await RunWithMeterListenerAsync(() => Assert.ThrowsAny<RpcException>(() => callSync(client)));

        ValidateEmittedMetrics(measurements, expectedStatus, methodName: expectedMethod);
    }

    public static TheoryData<Func<SpannerClient, Task>, string> SpannerClientAsyncSuccessCases => new()
    {
        { client => client.CreateSessionAsync(s_dbName), "CreateSession" },
        { client => client.ExecuteSqlAsync(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), "ExecuteSql" },
        { client => client.CommitAsync(new CommitRequest { SessionAsSessionName = s_sessionName }), "Commit" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientAsyncSuccessCases))]
    public async Task SpannerClient_RecordsMetrics_Async_Success(
        Func<SpannerClient, Task> callAsync,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata));

        var measurements = await RunWithMeterListenerAsync(() => callAsync(client));

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: expectedMethod);
    }

    public static TheoryData<Func<SpannerClient, Task>, StatusCode, string> SpannerClientAsyncFailureCases => new()
    {
        { client => client.CreateSessionAsync(s_dbName), StatusCode.Unknown, "CreateSession" },
        { client => client.CreateSessionAsync(s_dbName), StatusCode.DeadlineExceeded, "CreateSession" },
        { client => client.ExecuteSqlAsync(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), StatusCode.Unknown, "ExecuteSql" },
        { client => client.ExecuteSqlAsync(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName }), StatusCode.DeadlineExceeded, "ExecuteSql" },
        { client => client.CommitAsync(new CommitRequest { SessionAsSessionName = s_sessionName }), StatusCode.Unknown, "Commit" },
        { client => client.CommitAsync(new CommitRequest { SessionAsSessionName = s_sessionName }), StatusCode.DeadlineExceeded, "Commit" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientAsyncFailureCases))]
    public async Task SpannerClient_RecordsMetrics_Async_Failure(
        Func<SpannerClient, Task> callAsync,
        StatusCode expectedStatus,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata, expectedStatus));

        var measurements = await RunWithMeterListenerAsync(() => Assert.ThrowsAnyAsync<RpcException>(() => callAsync(client)));

        ValidateEmittedMetrics(measurements, expectedStatus, methodName: expectedMethod);
    }

    public static TheoryData<Func<SpannerClient, Task>, string> SpannerClientStreamingSuccessCases => new()
    {
        { client => ConsumeStreamAsync(client.ExecuteStreamingSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName })), "ExecuteStreamingSql" },
        { client => ConsumeStreamAsync(client.StreamingRead(new ReadRequest { SessionAsSessionName = s_sessionName })), "StreamingRead" },
        { client => ConsumeStreamAsync(client.BatchWrite(new BatchWriteRequest { SessionAsSessionName = s_sessionName })), "BatchWrite" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientStreamingSuccessCases))]
    public async Task SpannerClient_RecordsMetrics_Streaming_Success(
        Func<SpannerClient, Task> callStreaming,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata));

        var measurements = await RunWithMeterListenerAsync(() => callStreaming(client));

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: expectedMethod);
    }

    public static TheoryData<Func<SpannerClient, Task>, StatusCode, string> SpannerClientStreamingFailureCases => new()
    {
        { client => ConsumeStreamAsync(client.ExecuteStreamingSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName })), StatusCode.Unknown, "ExecuteStreamingSql" },
        { client => ConsumeStreamAsync(client.ExecuteStreamingSql(new ExecuteSqlRequest { SessionAsSessionName = s_sessionName })), StatusCode.DeadlineExceeded, "ExecuteStreamingSql" },
        { client => ConsumeStreamAsync(client.StreamingRead(new ReadRequest { SessionAsSessionName = s_sessionName })), StatusCode.Unknown, "StreamingRead" },
        { client => ConsumeStreamAsync(client.StreamingRead(new ReadRequest { SessionAsSessionName = s_sessionName })), StatusCode.DeadlineExceeded, "StreamingRead" },
        { client => ConsumeStreamAsync(client.BatchWrite(new BatchWriteRequest { SessionAsSessionName = s_sessionName })), StatusCode.Unknown, "BatchWrite" },
        { client => ConsumeStreamAsync(client.BatchWrite(new BatchWriteRequest { SessionAsSessionName = s_sessionName })), StatusCode.DeadlineExceeded, "BatchWrite" },
    };

    [Theory]
    [MemberData(nameof(SpannerClientStreamingFailureCases))]
    public async Task SpannerClient_RecordsMetrics_Streaming_Failure(
        Func<SpannerClient, Task> callStreaming,
        StatusCode expectedStatus,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata, expectedStatus));

        var measurements = await RunWithMeterListenerAsync(() => Assert.ThrowsAnyAsync<RpcException>(() => callStreaming(client)));

        ValidateEmittedMetrics(measurements, expectedStatus, methodName: expectedMethod);
    }

    public static TheoryData<Func<ManagedTransaction, ReliableStreamReader>, string> ReliableStreamSuccessCases => new()
    {
        { transaction => transaction.ExecuteSqlStreamReader(new ExecuteSqlRequest(), null), "ExecuteStreamingSql" },
        { transaction => transaction.ReadStreamReader(new ReadRequest(), null), "StreamingRead" },
    };

    [Theory]
    [MemberData(nameof(ReliableStreamSuccessCases))]
    public async Task SpannerClient_RecordsMetrics_ReliableStream_Success(
        Func<ManagedTransaction, ReliableStreamReader> createReader,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata));

        var measurements = await RunWithMeterListenerAsync(() => ConsumeReaderAsync(createReader(CreateTransaction(client))));

        ValidateEmittedMetrics(measurements, StatusCode.OK, methodName: expectedMethod);
    }

    public static TheoryData<Func<ManagedTransaction, ReliableStreamReader>, StatusCode, string> ReliableStreamFailureCases => new()
    {
        { transaction => transaction.ExecuteSqlStreamReader(new ExecuteSqlRequest(), null), StatusCode.Unknown, "ExecuteStreamingSql" },
        { transaction => transaction.ExecuteSqlStreamReader(new ExecuteSqlRequest(), null), StatusCode.DeadlineExceeded, "ExecuteStreamingSql" },
        { transaction => transaction.ReadStreamReader(new ReadRequest(), null), StatusCode.Unknown, "StreamingRead" },
        { transaction => transaction.ReadStreamReader(new ReadRequest(), null), StatusCode.DeadlineExceeded, "StreamingRead" },
    };

    [Theory]
    [MemberData(nameof(ReliableStreamFailureCases))]
    public async Task SpannerClient_RecordsMetrics_ReliableStream_Failure(
        Func<ManagedTransaction, ReliableStreamReader> createReader,
        StatusCode expectedStatus,
        string expectedMethod)
    {
        var client = CreateClient(new FakeCallInvoker(s_serverTimingMetadata, expectedStatus));

        var measurements = await RunWithMeterListenerAsync(
            () => Assert.ThrowsAnyAsync<RpcException>(() => ConsumeReaderAsync(createReader(CreateTransaction(client)))));

        ValidateEmittedMetrics(measurements, expectedStatus, methodName: expectedMethod);
    }

    private static ManagedTransaction CreateTransaction(SpannerClient client) =>
        ManagedTransaction.FromTransaction(
            client,
            new Session { SessionName = s_sessionName },
            transactionId: null,
            transactionOptions: null,
            readTimestamp: null);

    private static Task ConsumeStreamAsync<T>(ServerStreamingBase<T> stream) =>
        ConsumeStreamAsync(stream.GrpcCall.ResponseStream);

    private static async Task ConsumeStreamAsync<T>(IAsyncStreamReader<T> stream)
    {
        while (await stream.MoveNext(CancellationToken.None).ConfigureAwait(false))
        {
        }
    }

    private static async Task ConsumeReaderAsync(ReliableStreamReader reader)
    {
        using (reader)
        {
            while (await reader.NextAsync(CancellationToken.None).ConfigureAwait(false) is not null)
            {
            }
        }
    }

    private static void ValidateEmittedMetrics(
        IEnumerable<Measurement> measurements,
        StatusCode expectedStatus,
        string methodName = "CreateSession")
    {
        var scoped = FilterMeasurements(measurements, methodName);
        ValidateMetricValue(scoped);
        ValidateMetricLabels(scoped);

        List<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements, string methodName) =>
            measurements
                .Where(m => m.GetTag("method") == methodName && m.GetTag("client_uid") == s_clientIdentity.Id)
                .ToList();

        void ValidateMetricValue(List<Measurement> scopedMeasurements)
        {
            Assert.Equal(1L, Assert.Single(scopedMeasurements, m => m.Name == "attempt_count").Value);
            Assert.Equal(s_stopwatchProvider.ElapsedTimeMs, Assert.Single(scopedMeasurements, m => m.Name == "attempt_latencies").Value);
            Assert.Equal(12.5, Assert.Single(scopedMeasurements, m => m.Name == "gfe_latencies").Value);
        }

        void ValidateMetricLabels(List<Measurement> scopedMeasurements)
        {
            Assert.All(scopedMeasurements, m =>
            {
                Assert.NotNull(m);
                Assert.Equal(TestProjectId, m.GetTag("project_id"));
                Assert.Equal(TestInstanceId, m.GetTag("instance_id"));
                Assert.Equal(TestDatabaseId, m.GetTag("database"));
                Assert.Equal(methodName, m.GetTag("method"));
                Assert.Equal(expectedStatus.ToString(), m.GetTag("status"));
                Assert.Equal(s_clientIdentity.Hash, m.GetTag("client_hash"));
                Assert.Equal(s_clientIdentity.Id, m.GetTag("client_uid"));
                Assert.False(string.IsNullOrEmpty(m.GetTag("client_name")));
                Assert.False(string.IsNullOrEmpty(m.GetTag("location")));
                Assert.Equal("unknown", m.GetTag("instance_config"));
                Assert.Equal("false", m.GetTag("directpath_enabled"));
                Assert.Equal("false", m.GetTag("directpath_used"));
            });
        }
    }
}
