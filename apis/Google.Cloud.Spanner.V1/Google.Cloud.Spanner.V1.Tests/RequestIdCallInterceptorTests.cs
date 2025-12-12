// Copyright 2025 Google LLC
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

using Google.Cloud.Spanner.V1.Tests.Common;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.Tests;

public class RequestIdCallInterceptorTests
{
    private const string SampleDatabaseName = "projects/proj/instances/inst/databases/db";
    private const string SampleSessionName = "projects/proj/instances/inst/databases/db/sessions/sess";

    [Theory]
    [MemberData(nameof(SyncActions))]
    public void SyncCall_SyncFailure_ExceptionContainsRequestId(Action<SpannerClient> action)
    {
        var invoker = new SyncFailureCallInvoker();
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();

        var exception = Assert.Throws<RpcException>(() => action(client));

        Assert.True(exception.Data.Contains("x-goog-spanner-request-id"));
        Assert.NotNull(exception.Data["x-goog-spanner-request-id"]);
    }

    [Theory]
    [MemberData(nameof(AsyncActions))]
    public async Task AsyncCall_SyncFailure_ExceptionContainsRequestId(Func<SpannerClient, Task> action)
    {
        var invoker = new SyncFailureCallInvoker();
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();

        var exception = await Assert.ThrowsAsync<RpcException>(() => action(client));

        Assert.True(exception.Data.Contains("x-goog-spanner-request-id"));
        Assert.NotNull(exception.Data["x-goog-spanner-request-id"]);
    }


    [Theory]
    [MemberData(nameof(AsyncActions))]
    public async Task AsyncCall_AsyncFailure_ExceptionContainsRequestId(Func<SpannerClient, Task> action)
    {
        var invoker = new AsyncFailureCallInvoker();
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();

        var exception = await Assert.ThrowsAsync<RpcException>(() => action(client));

        Assert.True(exception.Data.Contains("x-goog-spanner-request-id"));
        Assert.NotNull(exception.Data["x-goog-spanner-request-id"]);
    }

    public static TheoryData<Action<SpannerClient>> SyncActions { get; } = new TheoryData<Action<SpannerClient>>
    {
        client => client.ExecuteSql(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" }),
        client => client.GetSession(new GetSessionRequest { Name = SampleSessionName }),
        client => client.DeleteSession(new DeleteSessionRequest { Name = SampleSessionName }),
        client => client.ExecuteBatchDml(new ExecuteBatchDmlRequest { Session = SampleSessionName }),
        client => client.Read(new ReadRequest { Session = SampleSessionName }),
        client => client.BeginTransaction(new BeginTransactionRequest { Session = SampleSessionName }),
        client => client.Commit(new CommitRequest { Session = SampleSessionName }),
        client => client.Rollback(new RollbackRequest { Session = SampleSessionName }),
        client => client.PartitionQuery(new PartitionQueryRequest { Session = SampleSessionName }),
        client => client.PartitionRead(new PartitionReadRequest { Session = SampleSessionName })
    };

    public static TheoryData<Func<SpannerClient, Task>> AsyncActions { get; } = new TheoryData<Func<SpannerClient, Task>>
    {
        async client =>
        {
            var stream = client.ExecuteStreamingSql(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" });
            await stream.GrpcCall.ResponseStream.MoveNext(default);
        },
        async client =>
        {
            var stream = client.ExecuteStreamingSql(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" });
            await stream.GrpcCall.ResponseHeadersAsync;
        },
        async client =>
        {
             var stream = client.ListSessionsAsync(new ListSessionsRequest { Database = SampleDatabaseName });
             await stream.ReadPageAsync(10);
        },
        async client =>
        {
             var stream = client.StreamingRead(new ReadRequest { Session = SampleSessionName });
             await stream.GrpcCall.ResponseStream.MoveNext(default);
        },
        async client =>
        {
             var stream = client.StreamingRead(new ReadRequest { Session = SampleSessionName });
             await stream.GrpcCall.ResponseHeadersAsync;
        },
        async client => await client.ExecuteSqlAsync(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" })
    };
}
