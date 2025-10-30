// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests;

public class RouteToLeaderTests
{
    private const string LeaderRoutingHeader = "x-goog-spanner-route-to-leader";
    private static readonly DatabaseName s_databaseName = DatabaseName.FromProjectInstanceDatabase("project", "instance", "database");
    private static readonly SessionName s_sessionName = SessionName.FromProjectInstanceDatabaseSession("project", "instance", "database", "session");
    private static readonly ByteString s_transactionId = ByteString.CopyFromUtf8("transaction");
    private static readonly TransactionOptions s_partitionedDml = new TransactionOptions { PartitionedDml = new TransactionOptions.Types.PartitionedDml() };
    private static readonly TransactionOptions s_readWrite = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };
    private static readonly TransactionOptions s_readOnly = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() };

    [Theory]
    [CombinatorialData]
    public async Task LeaderRoutingOption_PropagatesAsync(bool leaderRoutingEnabled)
    {
        var spannerClient = await new SpannerClientBuilder
        {
            CallInvoker = NotImplementedCallInvoker.Instance,
            LeaderRoutingEnabled = leaderRoutingEnabled
        }.BuildAsync();

        Assert.Equal(leaderRoutingEnabled, spannerClient.Settings.LeaderRoutingEnabled);
    }

    [Fact]
    public void LeaderRoutingEnabledByDefault_SpannerClientBuilder() =>
        Assert.True(new SpannerClientBuilder().LeaderRoutingEnabled);

    [Fact]
    public void LeaderRoutingEnabledByDefault_SpannerSettings() =>
        Assert.True(new SpannerSettings().LeaderRoutingEnabled);

    public static TheoryData<Func<SpannerClient, Task>> SpannerClientRoutesToLeader => new TheoryData<Func<SpannerClient, Task>>
    {
        { spannerClient => spannerClient.GetSessionAsync(s_sessionName) },
        { spannerClient => spannerClient.CreateSessionAsync(s_databaseName) },
        { spannerClient => spannerClient.BatchCreateSessionsAsync(s_databaseName, sessionCount: 1) },
        { spannerClient => spannerClient.CommitAsync(s_sessionName, s_transactionId, new Mutation[]{ }) },
        { spannerClient => spannerClient.RollbackAsync(s_sessionName, s_transactionId) },
        { spannerClient => spannerClient.ExecuteBatchDmlAsync(new ExecuteBatchDmlRequest()) },
        { spannerClient => spannerClient.PartitionQueryAsync(new PartitionQueryRequest()) },
        { spannerClient => spannerClient.PartitionReadAsync(new PartitionReadRequest()) },
        // BeginTransaction is routed to leader depending on the transaction type, but since the
        // transaction type is included in the request, we can route it or not at the SpannerClient level.
        { spannerClient => spannerClient.BeginTransactionAsync(s_sessionName, s_partitionedDml) },
        { spannerClient => spannerClient.BeginTransactionAsync(s_sessionName, s_readWrite) },
    };

    public static TheoryData<Func<SpannerClient, Task>> SpannerClientDoesNotRouteToLeader => new TheoryData<Func<SpannerClient, Task>>
    {
        { async spannerClient => await spannerClient.ListSessionsAsync(s_databaseName).ToListAsync() },
        { spannerClient => spannerClient.DeleteSessionAsync(s_sessionName) },
        // BeginTransaction is routed to leader depending on the transaction type, but since the
        // transaction type is included in the request, we can route it or not at the SpannerClient level.
        { spannerClient => spannerClient.BeginTransactionAsync(s_sessionName, s_readOnly) },
        { spannerClient => spannerClient.ExecuteSqlAsync(new ExecuteSqlRequest()) },
    };

    [Theory]
    [MemberData(nameof(SpannerClientRoutesToLeader))]
    public async Task SpannerClient_RoutesToLeaderWhenEnabled(Func<SpannerClient, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);

        await operation(spannerClient);

        Assert.Contains(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    [Theory]
    [MemberData(nameof(SpannerClientDoesNotRouteToLeader))]
    public async Task SpannerClient_DoesNotRouteToLeaderWhenEnabled(Func<SpannerClient, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);

        await operation(spannerClient);

        Assert.DoesNotContain(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    [Theory]
    [MemberData(nameof(SpannerClientRoutesToLeader))]
    [MemberData(nameof(SpannerClientDoesNotRouteToLeader))]
    public async Task SpannerClient_DoesNotRouteToLeaderWhenNotEnabled(Func<SpannerClient, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings { LeaderRoutingEnabled = false }, logger: null);

        await operation(spannerClient);

        Assert.DoesNotContain(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    public static TheoryData<Func<ManagedTransaction, Task>> ManagedTransactionRoutesToLeader => new TheoryData<Func<ManagedTransaction, Task>>
    {
        { managedTransaction => managedTransaction.WithTransaction(s_transactionId, s_partitionedDml, false).ExecuteSqlAsync(new ExecuteSqlRequest(), callSettings: null) },
        { managedTransaction => managedTransaction.WithTransaction(s_transactionId, s_readWrite, false).ExecuteSqlAsync(new ExecuteSqlRequest(), callSettings: null) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_partitionedDml, false).ReadStreamReaderAsync(new ReadRequest(), callSettings: null)).NextAsync(default) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_readWrite, false).ReadStreamReaderAsync(new ReadRequest(), callSettings: null)).NextAsync(default) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_partitionedDml, false).ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).NextAsync(default) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_readWrite, false).ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).NextAsync(default) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_readWrite, false).ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).NextAsync(default) },
    };

    public static TheoryData<Func<ManagedTransaction, Task>> ManagedTransactionDoesNotRouteToLeader => new TheoryData<Func<ManagedTransaction, Task>>
    {
        { managedTransaction => managedTransaction.WithTransaction(s_transactionId, s_readOnly, false).ExecuteSqlAsync(new ExecuteSqlRequest(), callSettings: null) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_readOnly, false).ReadStreamReaderAsync(new ReadRequest(), callSettings: null)).NextAsync(default) },
        { async managedTransaction => await (await managedTransaction.WithTransaction(s_transactionId, s_readOnly, false).ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).NextAsync(default) },
    };

    [Theory]
    [MemberData(nameof(ManagedTransactionRoutesToLeader))]
    public async Task ManagedTransaction_RoutesToLeaderWhenEnabled(Func<ManagedTransaction, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);
        var managedTransaction = CreateManagedTransaction(spannerClient);

        await operation(managedTransaction);

        Assert.Contains(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    

    [Theory]
    [MemberData(nameof(ManagedTransactionDoesNotRouteToLeader))]
    public async Task ManagedTransaction_DoesNotRouteToLeaderWhenEnabled(Func<ManagedTransaction, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);
        var managedTransaction = CreateManagedTransaction(spannerClient);

        await operation(managedTransaction);

        Assert.DoesNotContain(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    [Theory]
    [MemberData(nameof(ManagedTransactionRoutesToLeader))]
    [MemberData(nameof(ManagedTransactionDoesNotRouteToLeader))]
    public async Task ManagedTransaction_DoesNotRouteToLeaderWhenNotEnabled(Func<ManagedTransaction, Task> operation)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings { LeaderRoutingEnabled = false }, logger: null);
        var managedTransaction = CreateManagedTransaction(spannerClient);

        await operation(managedTransaction);

        Assert.DoesNotContain(grpcClient.LastCallOptions.Headers, header => header.Key == LeaderRoutingHeader && header.Value == true.ToString());
    }

    private ManagedTransaction CreateManagedTransaction(SpannerClient client)
    {
        var managedSession = new ManagedSession(client, s_databaseName, null, null);
        managedSession.Session = new Session
        {
            CreateTime = Timestamp.FromDateTime(DateTime.UtcNow),
            SessionName = SessionName.FromProjectInstanceDatabaseSession("projectId", "instanceId", "databaseId", "testSessionId"),
            Multiplexed = true
        };

        var managedTransaction = new ManagedTransaction(managedSession, null, null, false, null);

        return managedTransaction;
    }

    private class FakeGrpcSpannerClient : V1.Spanner.SpannerClient
    {
        public CallOptions LastCallOptions { get; private set; }

        public override AsyncUnaryCall<Session> GetSessionAsync(GetSessionRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<Session>(options);

        public override AsyncUnaryCall<Session> CreateSessionAsync(CreateSessionRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<Session>(options);

        public override AsyncUnaryCall<Empty> DeleteSessionAsync(DeleteSessionRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<Empty>(options);

        public override AsyncUnaryCall<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<ListSessionsResponse>(options);

        public override AsyncUnaryCall<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<BatchCreateSessionsResponse>(options);

        public override AsyncUnaryCall<Transaction> BeginTransactionAsync(BeginTransactionRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<Transaction>(options);

        public override AsyncUnaryCall<CommitResponse> CommitAsync(CommitRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<CommitResponse>(options);

        public override AsyncUnaryCall<Empty> RollbackAsync(RollbackRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<Empty>(options);

        public override AsyncUnaryCall<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<ResultSet>(options);

        public override AsyncServerStreamingCall<PartialResultSet> StreamingRead(ReadRequest request, CallOptions options) =>
            FakeAsyncServerStreamingCall(options);

        public override AsyncServerStreamingCall<PartialResultSet> ExecuteStreamingSql(ExecuteSqlRequest request, CallOptions options) =>
            FakeAsyncServerStreamingCall(options);

        public override AsyncUnaryCall<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<ExecuteBatchDmlResponse>(options);

        public override AsyncUnaryCall<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<PartitionResponse>(options);

        public override AsyncUnaryCall<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, CallOptions options) =>
            FakeAsyncUnaryCall<PartitionResponse>(options);

        private AsyncUnaryCall<T> FakeAsyncUnaryCall<T>(CallOptions options)
            where T : new()
        {
            LastCallOptions = options;
            return new AsyncUnaryCall<T>(
                Task.FromResult(new T()),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }

        private AsyncServerStreamingCall<PartialResultSet> FakeAsyncServerStreamingCall(CallOptions options)
        {
            LastCallOptions = options;
            return new AsyncServerStreamingCall<PartialResultSet>(
                new FakeAsyncStreamReader(),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }
    }

    private class FakeAsyncStreamReader : IAsyncStreamReader<PartialResultSet>
    {
        private bool _hasNext = true;
        public PartialResultSet Current => new PartialResultSet
        {
            Metadata = new ResultSetMetadata(),
            Values = { Value.ForBool(true) }
        };

        public Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            var result = Task.FromResult(_hasNext);
            _hasNext = false;
            return result;
        }
    }
}
