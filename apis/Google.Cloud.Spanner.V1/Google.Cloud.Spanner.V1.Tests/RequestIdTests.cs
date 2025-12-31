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
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

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

        var parts = new SpannerRequestIdParts(idString);

        Assert.Equal(1, parts.VersionId);
        // The ClientId cannot be determined exaclty so we just ensure it's postive
        Assert.True(parts.ClientId > 0);
        Assert.Equal(1, parts.ChannelId);
        Assert.Equal(1, parts.RequestId);
        Assert.Equal(1, parts.AttemptNum);
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

    /// <summary>
    /// CallInvoker that throws an RpcException synchronously upon method invocation.
    /// Simulates immediate failures like client-side validation or connection errors.
    /// Used by SpannerClient tests to verify synchronous error handling.
    /// </summary>
    private class SyncFailureCallInvoker : CallInvoker
    {
        private int _invocationCount = 0;
        private readonly int _numberOfFailuresToSimulate;
        private readonly StatusCode _statusCodeToThrow;
        private readonly string _exceptionMessage;

        /// <summary>
        /// Creates a new instance of <see cref="SyncFailureCallInvoker"/>.
        /// </summary>
        /// <param name="numberOfFailuresToSimulate">The number of times to simulate a failure before succeeding.</param>
        /// <param name="statusCodeToThrow">The gRPC status code to use in the thrown exception.</param>
        /// <param name="exceptionMessage">The message to use in the thrown exception.</param>
        public SyncFailureCallInvoker(int numberOfFailuresToSimulate = int.MaxValue, StatusCode statusCodeToThrow = StatusCode.Internal, string exceptionMessage = "Test exception")
        {
            _numberOfFailuresToSimulate = numberOfFailuresToSimulate;
            _statusCodeToThrow = statusCodeToThrow;
            _exceptionMessage = exceptionMessage;
        }

        /// <summary>
        /// The list of metadata headers captured from each method invocation.
        /// </summary>
        public List<Metadata> CapturedMetadata { get; } = new List<Metadata>();

        /// <summary>
        /// Records the metadata from a call.
        /// </summary>
        /// <param name="headers">The metadata headers to record.</param>
        protected void RecordMetadata(Metadata headers)
        {
            CapturedMetadata.Add(headers);
        }

        /// <inheritdoc/>
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            RecordMetadata(options.Headers);
            MaybeThrowException();
            return (TResponse)Activator.CreateInstance(typeof(TResponse));
        }

        /// <inheritdoc/>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            RecordMetadata(options.Headers);
            MaybeThrowException();
            return new AsyncUnaryCall<TResponse>(
                Task.FromResult((TResponse)Activator.CreateInstance(typeof(TResponse))),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }

        /// <inheritdoc/>
        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            RecordMetadata(options.Headers);
            MaybeThrowException();
            return new AsyncServerStreamingCall<TResponse>(
                new EmptyAsyncStreamReader<TResponse>(),
                Task.FromResult(new Metadata()),
                () => Status.DefaultSuccess,
                () => new Metadata(),
                () => { });
        }

        /// <summary>
        /// Determines whether the current invocation should fail based on the configured failure count.
        /// </summary>
        /// <returns>True if the call should fail; otherwise, false.</returns>
        protected bool ShouldFail()
        {
            _invocationCount++;
            return _invocationCount <= _numberOfFailuresToSimulate;
        }

        /// <summary>
        /// Creates the RpcException to be thrown or returned.
        /// </summary>
        /// <returns>The configured RpcException.</returns>
        protected RpcException CreateRpcException()
        {
            return new RpcException(new Status(_statusCodeToThrow, _exceptionMessage));
        }

        /// <summary>
        /// Checks whether the current invocation should fail, and throws an exception if so.
        /// </summary>
        protected void MaybeThrowException()
        {
            if (ShouldFail())
            {
                throw CreateRpcException();
            }
        }

        /// <inheritdoc/>
        public override AsyncClientStreamingCall<TRequest, TResponse> AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException(); // SpannerClient does not support client streaming calls

        /// <inheritdoc/>
        public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) =>
            throw new NotImplementedException(); // SpannerClient does not support duplex streaming calls
    }

    /// <summary>
    /// IAsyncStreamReader{T} implementation that immediately signals the end of the stream.
    /// Used as a placeholder in test CallInvokers where no data is expected.
    /// </summary>
    /// <typeparam name="T">The message type.</typeparam>
    public class EmptyAsyncStreamReader<T> : IAsyncStreamReader<T>
    {
        /// <inheritdoc/>
        public T Current => default;

        /// <inheritdoc/>
        public Task<bool> MoveNext(System.Threading.CancellationToken cancellationToken)
        {
            return Task.FromResult(false);
        }
    }
}
