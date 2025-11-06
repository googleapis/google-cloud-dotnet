// Copyright 2024 Google LLC
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
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.V1.Tests;

public class SpannerRequestIdTests
{
    private const string SampleDatabaseName = "projects/proj/instances/inst/databases/db";
    private const string SampleSessionName = "projects/proj/instances/inst/databases/db/sessions/sess";

    // Tests for SpannerRequestId class itself
    [Fact]
    public void SpannerRequestId_Format()
    {
        var expectedClientId = 123;
        var expectedRequestSequence = 456;
        var requestId = new SpannerRequestId(expectedClientId, expectedRequestSequence);

        // The expected format is 6 parts that break down as such:
        // {VersionId}.{s_processId}.{ClientId}.{ChannelId}.{RequestSequence}.{AttemptNum}
        var idString = requestId.IncrementAttempt();
        var parts = idString.Split('.');

        Assert.Equal(6, parts.Length);
        var versionId = parts[0];
        var processIdString = parts[1];
        var clientId = parts[2];
        var channelId = parts[3];
        var requestSequence = parts[4];
        var attemptNum = parts[5];

        Assert.Equal("1", versionId);
        Assert.Equal(expectedClientId.ToString(), clientId);
        Assert.Equal("1", channelId);
        Assert.Equal(expectedRequestSequence.ToString(), requestSequence);
        Assert.Equal("1", attemptNum);
        Assert.True(ulong.TryParse(processIdString, out _));
    }

    [Fact]
    public void SpannerRequestId_IncrementAttemptNum()
    {
        var requestId = new SpannerRequestId(1, 1);
        for (int expectedAttemptNum = 1; expectedAttemptNum < 5; expectedAttemptNum++)
        {
            var parts = requestId.IncrementAttempt().Split('.');
            Assert.Equal(6, parts.Length);
            var actualAttemptNum = parts[5];
            Assert.Equal($"{expectedAttemptNum}", actualAttemptNum);
        }
    }

    [Fact]
    public void SpannerRequestId_ProcessIdIsStatic()
    {
        var requestId1 = new SpannerRequestId(1, 1);
        var requestId2 = new SpannerRequestId(2, 2);

        // The process ID is part of the ToString() output, so we can compare the generated strings
        // and extract the process ID.
        string requestId1String = requestId1.IncrementAttempt();
        string requestId2String = requestId2.IncrementAttempt();

        string processId1 = requestId1String.Split('.')[1];
        string processId2 = requestId2String.Split('.')[1];

        Assert.Equal(processId1, processId2);
    }

    // Tests for header injection
    public static TheoryData<Action<SpannerClient>> SpannerClientActions { get; } = new TheoryData<Action<SpannerClient>>
    {
        client => client.CreateSession(new CreateSessionRequest { Database = SampleDatabaseName }),
        client => client.BatchCreateSessions(new BatchCreateSessionsRequest { Database = SampleDatabaseName }),
        client => client.GetSession(new GetSessionRequest { Name = SampleSessionName }),
        client => client.ListSessions(new ListSessionsRequest { Database = SampleDatabaseName }).AsRawResponses().First(),
        client => client.DeleteSession(new DeleteSessionRequest { Name = SampleSessionName }),
        client => client.ExecuteSql(new ExecuteSqlRequest { Session = SampleSessionName }),
        client => client.ExecuteBatchDml(new ExecuteBatchDmlRequest { Session = SampleSessionName }),
        client => client.Read(new ReadRequest { Session = SampleSessionName }),
        client => client.BeginTransaction(new BeginTransactionRequest { Session = SampleSessionName }),
        client => client.Commit(new CommitRequest { Session = SampleSessionName }),
        client => client.Rollback(new RollbackRequest { Session = SampleSessionName }),
        client => client.PartitionQuery(new PartitionQueryRequest { Session = SampleSessionName }),
        client => client.PartitionRead(new PartitionReadRequest { Session = SampleSessionName })
    };

    [Theory]
    [MemberData(nameof(SpannerClientActions))]
    public void SetsHeaderOnRpcCalls(Action<SpannerClient> action)
    {
        var invoker = new RetryFakeCallInvoker();
        var client = new SpannerClientBuilder { CallInvoker = invoker }.Build();
        action(client);
        Metadata.Entry entry = Assert.Single(invoker.CapturedMetadata[0], e => e.Key == SpannerRequestId.HeaderKey);
        Assert.NotNull(entry.Value);
    }

    [Fact]
    public void IncrementsRequestIdOnRetry()
    {
        var invoker = new RetryFakeCallInvoker(failCount: 1);
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
            .Select(m => m.Single(e => e.Key == SpannerRequestId.HeaderKey).Value)
            .Select(id => new SpannerRequestIdParts(id))
            .ToList();

        Assert.Equal((1, 1), (requestIds[0].RequestSequence, requestIds[0].AttemptNum));
        Assert.Equal((1, 2), (requestIds[1].RequestSequence, requestIds[1].AttemptNum));
        Assert.Equal((2, 1), (requestIds[2].RequestSequence, requestIds[2].AttemptNum));
        Assert.Equal((3, 1), (requestIds[3].RequestSequence, requestIds[3].AttemptNum));
    }

    /// <summary>
    /// A fake call invoker that fails the first time it's called with an "Unavailable" status,
    /// and succeeds on subsequent calls. It captures the metadata for every call.
    /// </summary>
    private class RetryFakeCallInvoker : CallInvoker
    {
        private int _callCount = 0;
        private readonly int _failCount;
        public List<Metadata> CapturedMetadata { get; } = new List<Metadata>();

        public RetryFakeCallInvoker(int failCount = 0) => _failCount = failCount;

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            CapturedMetadata.Add(options.Headers);
            _callCount++;

            if (_callCount <= _failCount)
            {
                // Fail the first time with a retryable error.
                throw new RpcException(new Status(StatusCode.Unavailable, "Transient error"));
            }

            // Succeed on the second attempt.
            return (TResponse)Activator.CreateInstance(typeof(TResponse));
        }

        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException();

        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException();

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) =>
            throw new NotImplementedException();

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            CapturedMetadata.Add(options.Headers);
            _callCount++;

            if (_callCount <= _failCount)
            {
                // Fail the first time with a retryable error.
                throw new RpcException(new Status(StatusCode.Unavailable, "Transient error"));
            }

            // Succeed on the second attempt.
            var response = (TResponse)Activator.CreateInstance(typeof(TResponse));
            return new AsyncUnaryCall<TResponse>(Task.FromResult(response), Task.FromResult(new Metadata()), () => Status.DefaultSuccess, () => new Metadata(), () => { });
        }
    }

    private struct SpannerRequestIdParts
    {
        public int VersionId { get; }
        public ulong ProcessId { get; }
        public int ClientId { get; }
        public int ChannelId { get; }
        public int RequestSequence { get; }
        public int AttemptNum { get; }

        public SpannerRequestIdParts(string requestId)
        {
            var parts = requestId.Split('.');
            Assert.Equal(6, parts.Length);

            VersionId = int.Parse(parts[0]);
            ProcessId = ulong.Parse(parts[1]);
            ClientId = int.Parse(parts[2]);
            ChannelId = int.Parse(parts[3]);
            RequestSequence = int.Parse(parts[4]);
            AttemptNum = int.Parse(parts[5]);
        }
    }
}
