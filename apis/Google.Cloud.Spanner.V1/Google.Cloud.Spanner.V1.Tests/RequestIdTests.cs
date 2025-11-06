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

using Grpc.Core;
using Google.Api.Gax.Grpc;
using System;
using System.Linq;
using Xunit;
using Google.Cloud.Spanner.V1.Tests.Common;

namespace Google.Cloud.Spanner.V1.Tests;

public class RequestIdTests
{
    private const string SampleDatabaseName = "projects/proj/instances/inst/databases/db";
    private const string SampleSessionName = "projects/proj/instances/inst/databases/db/sessions/sess";

    [Theory]
    [MemberData(nameof(SpannerClientActions))]
    public void RequestId_Format(Action<SpannerClient> action)
    {
        var invoker = new SyncFailureCallInvoker(0);
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();

        action(client);

        // The expected format is 6 parts that break down as such:
        // {VersionId}.{ProcessId}.{ClientId}.{ChannelId}.{RequestId}.{AttemptNum}
        Metadata headerMetadata = invoker.CapturedMetadata[0];
        var idString = headerMetadata.Get("x-goog-spanner-request-id").Value;

        var parts = idString.Split('.');

        Assert.Equal(6, parts.Length);
        var versionId = parts[0];
        var processId = parts[1];
        var clientId = parts[2];
        var channelId = parts[3];
        var requestId = parts[4];
        var attemptNum = parts[5];

        Assert.Equal("1", versionId);
        Assert.True(ulong.TryParse(processId, out _));
        Assert.True(int.TryParse(clientId, out _));
        Assert.Equal("1", channelId);
        Assert.True(int.TryParse(requestId, out _));
        Assert.Equal("1", attemptNum);
    }

    [Theory]
    [MemberData(nameof(SpannerClientActions))]
    public void SetsHeaderOnRpcCalls(Action<SpannerClient> action)
    {
        var invoker = new SyncFailureCallInvoker(0);
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
        action(client);
        Metadata.Entry entry = Assert.Single(invoker.CapturedMetadata[0], e => e.Key == "x-goog-spanner-request-id");
        Assert.NotNull(entry.Value);
    }

    [Fact]
    public void IncrementsRequestIdOnRetry()
    {
        var invoker = new SyncFailureCallInvoker(numberOfFailuresToSimulate: 1, statusCodeToThrow: StatusCode.ResourceExhausted);
        var settings = new SpannerSettings
        {
            // Configure the CreateSession call to retry on Unavailable errors.
            CallSettings = CallSettings.FromRetry(RetrySettings.FromExponentialBackoff(
                maxAttempts: 3,
                initialBackoff: TimeSpan.FromMilliseconds(1),
                maxBackoff: TimeSpan.FromMilliseconds(1),
                backoffMultiplier: 1.0,
                retryFilter: RetrySettings.FilterForStatusCodes(StatusCode.Unavailable)))
        };
        var client = new SpannerClientBuilder { CallInvoker = invoker, Settings = settings }.Build();

        client.CreateSession(new CreateSessionRequest { Database = SampleDatabaseName });
        client.CreateSession(new CreateSessionRequest { Database = SampleDatabaseName });
        client.CreateSession(new CreateSessionRequest { Database = SampleDatabaseName });

        // Assert that the invoker was called four times for the three client calls.
        // The first call should have failed the first time and succeeded on retry.
        Assert.Equal(4, invoker.CapturedMetadata.Count);

        var requestIds = invoker.CapturedMetadata
            .Select(m => m.Single(e => e.Key == "x-goog-spanner-request-id").Value)
            .Select(id => new SpannerRequestIdParts(id))
            .ToList();

        Assert.Equal((1, 1), (requestIds[0].RequestId, requestIds[0].AttemptNum));
        Assert.Equal((1, 2), (requestIds[1].RequestId, requestIds[1].AttemptNum));
        Assert.Equal((2, 1), (requestIds[2].RequestId, requestIds[2].AttemptNum));
        Assert.Equal((3, 1), (requestIds[3].RequestId, requestIds[3].AttemptNum));
    }

    [Fact]
    public void RequestIdSource_ProcessId_OverwritingBehavior() =>
        // The process ID should only ever be set once per process.
        Assert.Throws<InvalidOperationException>(() =>
            {
                // Note in the case of test re-runs within the same process the
                // "first_override" may cause the exception to be thrown as it was
                // set prior.
                SpannerClientImpl.ProcessId = 1UL;
                SpannerClientImpl.ProcessId = 2UL;
            });

    public static TheoryData<Action<SpannerClient>> SpannerClientActions { get; } = new TheoryData<Action<SpannerClient>>
    {
        client => client.ExecuteSql(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" }),
        client => client.ExecuteStreamingSql(new ExecuteSqlRequest { Session = SampleSessionName, Sql = "SELECT 1" }),
        client => client.GetSession(new GetSessionRequest { Name = SampleSessionName }),
        client => client.ListSessions(new ListSessionsRequest { Database = SampleDatabaseName }).AsRawResponses().First(),
        client => client.DeleteSession(new DeleteSessionRequest { Name = SampleSessionName }),
        client => client.ExecuteSql(new ExecuteSqlRequest { Session = SampleSessionName }),
        client => client.ExecuteBatchDml(new ExecuteBatchDmlRequest { Session = SampleSessionName }),
        client => client.Read(new ReadRequest { Session = SampleSessionName }),
        client => client.StreamingRead(new ReadRequest { Session = SampleSessionName }),
        client => client.BeginTransaction(new BeginTransactionRequest { Session = SampleSessionName }),
        client => client.Commit(new CommitRequest { Session = SampleSessionName }),
        client => client.Rollback(new RollbackRequest { Session = SampleSessionName }),
        client => client.PartitionQuery(new PartitionQueryRequest { Session = SampleSessionName }),
        client => client.PartitionRead(new PartitionReadRequest { Session = SampleSessionName }),
    };

    private struct SpannerRequestIdParts
    {
        public int VersionId { get; }
        public ulong ProcessId { get; }
        public int ClientId { get; }
        public int ChannelId { get; }
        public int RequestId { get; }
        public int AttemptNum { get; }

        public SpannerRequestIdParts(string requestId)
        {
            var parts = requestId.Split('.');
            Assert.Equal(6, parts.Length);

            VersionId = int.Parse(parts[0]);
            ProcessId = ulong.Parse(parts[1]);
            ClientId = int.Parse(parts[2]);
            ChannelId = int.Parse(parts[3]);
            RequestId = int.Parse(parts[4]);
            AttemptNum = int.Parse(parts[5]);
        }
    }
}
