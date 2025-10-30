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

using Google.Api.Gax;
using Google.Api.Gax.Testing;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Api.Gax.Grpc.ClientHelper;

namespace Google.Cloud.Spanner.Data.Tests;

public class DirectedReadTests
{
    internal static DirectedReadOptions IncludeDirectedReadOptions { get; } = new DirectedReadOptions
    {
        IncludeReplicas = new DirectedReadOptions.Types.IncludeReplicas
        {
            AutoFailoverDisabled = true,
            ReplicaSelections =
            {
                new DirectedReadOptions.Types.ReplicaSelection
                {
                    Location = "us-east1",
                    Type = DirectedReadOptions.Types.ReplicaSelection.Types.Type.ReadOnly
                }
            }
        }
    };
    internal static DirectedReadOptions ExcludeDirectedReadOptions { get; } = new DirectedReadOptions
    {
        ExcludeReplicas = new DirectedReadOptions.Types.ExcludeReplicas
        {
            ReplicaSelections =
            {
                new DirectedReadOptions.Types.ReplicaSelection
                {
                    Location = "us-east1",
                    Type = DirectedReadOptions.Types.ReplicaSelection.Types.Type.ReadWrite
                }
            }
        }
    };

    private static readonly SessionName s_sessionName = SessionName.FromProjectInstanceDatabaseSession("project", "instance", "database", "session");
    private static readonly ByteString s_transactionId = ByteString.CopyFromUtf8("transaction");
    private static readonly DatabaseName s_databaseName = DatabaseName.FromProjectInstanceDatabase("project", "instance", "database");
    private static readonly TransactionOptions s_partitionedDml = new TransactionOptions { PartitionedDml = new TransactionOptions.Types.PartitionedDml() };
    private static readonly TransactionOptions s_readWrite = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };
    private static readonly TransactionOptions s_readOnly = new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() };

    public static TheoryData<TransactionOptions> NonReadOnlyTransactionOptions => new TheoryData<TransactionOptions>
    {
        s_partitionedDml, s_readWrite
    };

    [Fact]
    public async Task DirectedReadOption_DefaultPropagatesAsync()
    {
        var spannerClient = await new SpannerClientBuilder
        {
            CallInvoker = NotImplementedCallInvoker.Instance,
        }.BuildAsync();

        Assert.Null(spannerClient.Settings.DirectedReadOptions);
    }

    [Fact]
    public async Task DirectedReadOption_CustomPropagatesAsync()
    {
        var spannerClient = await new SpannerClientBuilder
        {
            CallInvoker = NotImplementedCallInvoker.Instance,
            DirectedReadOptions = IncludeDirectedReadOptions
        }.BuildAsync();

        Assert.Equal(IncludeDirectedReadOptions, spannerClient.Settings.DirectedReadOptions);
        Assert.NotSame(IncludeDirectedReadOptions, spannerClient.Settings.DirectedReadOptions);
    }

    [Fact]
    public void DirectedReadOptionsUnsetByDefault_SpannerClientBuilder() =>
        Assert.Null(new SpannerClientBuilder().DirectedReadOptions);

    [Fact]
    public void DirectedReadOptionsUnsetByDefault_SpannerSettings() =>
        Assert.Null(new SpannerSettings().DirectedReadOptions);

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromClient_ExecuteSqlAsync(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await managedTransaction.ExecuteSqlAsync(new ExecuteSqlRequest(), callSettings: null);
        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromRequest_ExecuteSqlAsync(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);
        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await managedTransaction.ExecuteSqlAsync(new ExecuteSqlRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_RequestOptionsTakePrecedenceOverClientOptions_ExecuteSqlAsync(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = ExcludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await managedTransaction.ExecuteSqlAsync(new ExecuteSqlRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    // Note: We don't have an equivalent "NonReadOnlyTransaction_IgnoresOptionsFromRequest" test because in that case
    // we just past the request along as we received it, with or without the directed read options.
    // The service should fail if there are options set.
    // This was agreed as part of the client library desing.
    [Theory]
    [MemberData(nameof(NonReadOnlyTransactionOptions))]
    public async Task PooledSession_NonReadOnlyTransaction_IgnoresOptionsFromClient_ExecuteSqlAsync(TransactionOptions options)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, options, singleUseTransaction: false);

        await managedTransaction.ExecuteSqlAsync(new ExecuteSqlRequest(), callSettings: null);
        Assert.Null(grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromClient_ExecuteSqlStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await (await managedTransaction.ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).HasDataAsync(default);
        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromRequest_ExecuteSqlStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await (await managedTransaction.ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null)).HasDataAsync(default);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_RequestOptionsTakePrecedenceOverClientOptions_ExecuteSqlStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = ExcludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await (await managedTransaction.ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null)).HasDataAsync(default);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    // Note: We don't have an equivalent "NonReadOnlyTransaction_IgnoresOptionsFromRequest" test because in that case
    // we just past the request along as we received it, with or without the directed read options.
    // The service should fail if there are options set.
    // This was agreed as part of the client library desing.
    [Theory]
    [MemberData(nameof(NonReadOnlyTransactionOptions))]
    public async Task PooledSession_NonReadOnlyTransaction_IgnoresOptionsFromClient_ExecuteSqlStreamReader(TransactionOptions options)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, options, singleUseTransaction: false);

        await(await  managedTransaction.ExecuteSqlStreamReaderAsync(new ExecuteSqlRequest(), callSettings: null)).HasDataAsync(default);
        Assert.Null(grpcClient.LastExecuteSqlRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromClient_ReadStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        var reader = await managedTransaction.ReadStreamReaderAsync(new ReadRequest(), callSettings: null);
        await reader.HasDataAsync(default);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastReadRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_SetsOptionsFromRequest_ReadStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();
        var spannerClient = new SpannerClientImpl(grpcClient, settings: null, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await (await managedTransaction.ReadStreamReaderAsync(new ReadRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null)).HasDataAsync(default);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastReadRequest.DirectedReadOptions);
    }

    [Theory]
    [CombinatorialData]
    public async Task PooledSession_RequestOptionsTakePrecedenceOverClientOptions_ReadStreamReader(bool singleUseTransaction)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = ExcludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, s_readOnly, singleUseTransaction);

        await (await managedTransaction.ReadStreamReaderAsync(new ReadRequest
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, callSettings: null)).HasDataAsync(default);

        Assert.Equal(IncludeDirectedReadOptions, grpcClient.LastReadRequest.DirectedReadOptions);
    }

    // Note: We don't have an equivalent "NonReadOnlyTransaction_IgnoresOptionsFromRequest" test because in that case
    // we just past the request along as we received it, with or without the directed read options.
    // The service should fail if there are options set.
    // This was agreed as part of the client library desing.
    [Theory]
    [MemberData(nameof(NonReadOnlyTransactionOptions))]
    public async Task PooledSession_NonReadOnlyTransaction_IgnoresOptionsFromClient_ReadStreamReader(TransactionOptions options)
    {
        var grpcClient = new FakeGrpcSpannerClient();

        var spannerClient = new SpannerClientImpl(grpcClient, new SpannerSettings
        {
            DirectedReadOptions = IncludeDirectedReadOptions
        }, logger: null);

        var managedTransaction = CreateManagedTransaction(spannerClient);
        managedTransaction = managedTransaction.WithTransaction(s_transactionId, options, singleUseTransaction: false);

        await (await managedTransaction.ReadStreamReaderAsync(new ReadRequest(), callSettings: null)).HasDataAsync(default);
        Assert.Null(grpcClient.LastReadRequest.DirectedReadOptions);
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

    public class FakeGrpcSpannerClient : V1.Spanner.SpannerClient
    {
        public ExecuteSqlRequest LastExecuteSqlRequest { get; private set; }
        public ReadRequest LastReadRequest { get; private set; }

        public override AsyncUnaryCall<Session> GetSessionAsync(GetSessionRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<Session> CreateSessionAsync(CreateSessionRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<Empty> DeleteSessionAsync(DeleteSessionRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<Transaction> BeginTransactionAsync(BeginTransactionRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<CommitResponse> CommitAsync(CommitRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<Empty> RollbackAsync(RollbackRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallOptions options)
        {
            LastExecuteSqlRequest = request;
            return FakeAsyncUnaryCall<ResultSet>(options);
        }

        public override AsyncServerStreamingCall<PartialResultSet> StreamingRead(ReadRequest request, CallOptions options)
        {
            LastReadRequest = request;
            return FakeAsyncServerStreamingCall(options);
        }

        public override AsyncServerStreamingCall<PartialResultSet> ExecuteStreamingSql(ExecuteSqlRequest request, CallOptions options)
        {
            LastExecuteSqlRequest = request;
            return FakeAsyncServerStreamingCall(options);
        }

        public override AsyncUnaryCall<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, CallOptions options) => throw new NotImplementedException();

        public override AsyncUnaryCall<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, CallOptions options) => throw new NotImplementedException();

        private AsyncUnaryCall<T> FakeAsyncUnaryCall<T>(CallOptions options)
            where T : new()
        {
            return new AsyncUnaryCall<T>(
                Task.FromResult(new T()),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }

        private AsyncServerStreamingCall<PartialResultSet> FakeAsyncServerStreamingCall(CallOptions options)
        {
            return new AsyncServerStreamingCall<PartialResultSet>(
                new FakeAsyncStreamReader(),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }
    }

    private class FakeSessionPool : SessionPool.ISessionPool
    {
        public FakeSessionPool(SpannerClient spannerClient) => Client = spannerClient;
        public SpannerClient Client { get; }

        public IClock Clock => new FakeClock();

        public SessionPoolOptions Options => new SessionPoolOptions();

        public bool TracksSessions => throw new NotImplementedException();

        public void Detach(PooledSession session) => throw new NotImplementedException();
        public Task<PooledSession> RefreshedOrNewAsync(PooledSession session, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) => throw new NotImplementedException();
        public void Release(PooledSession session, ByteString transactionToRollback, bool deleteSession) => throw new NotImplementedException();
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
