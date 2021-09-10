// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Testing;
using Google.Api.Gax.Testing;
using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Google.Rpc;
using Google.Rpc.Context;
using Grpc.Core;
using Moq;
using Moq.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Status = Grpc.Core.Status;
using static Google.Cloud.Spanner.V1.SpannerClientImpl;

namespace Google.Cloud.Spanner.V1.Tests
{
    /// <summary>
    /// Helpers for tests that need general SpannerClient instances.
    /// The mocks generated with these helpers guarantee the basic
    /// SpannerClient workings. If you need more granularity in what
    /// SpannerClient methods return you should write specific mocks.
    /// </summary>
    internal static class SpannerClientHelpers
    {
        internal const string ProjectId = "dummy-project";
        internal const string Instance = "dummy-instance";
        internal const string Database = "dummy-database";
        private static readonly string s_retryInfoMetadataKey = RetryInfo.Descriptor.FullName + "-bin";

        /// <summary>
        /// Creates a mock SpannerClient configured with settings that include a fake clock
        /// and a fake scheduler.
        /// </summary>
        internal static Mock<SpannerClient> CreateMockClient(Logger logger, MockBehavior behavior = MockBehavior.Strict)
        {
            var fakeScheduler = new FakeScheduler();
            var settings = SpannerSettings.GetDefault();
            settings.Scheduler = fakeScheduler;
            settings.Clock = fakeScheduler.Clock;
            settings.Logger = logger;
            var mock = new Mock<SpannerClient>(behavior);
            mock.SetupProperty(client => client.Settings, settings);
            return mock;
        }

        internal static Mock<SpannerClient> SetupBatchCreateSessionsAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.BatchCreateSessionsAsync(It.IsNotNull<BatchCreateSessionsRequest>(), It.IsAny<CallSettings>()))
                .Returns<BatchCreateSessionsRequest, CallSettings>((request, _) =>
                {
                    BatchCreateSessionsResponse response = new BatchCreateSessionsResponse();

                    for (int i = 0; i < request.SessionCount; i++)
                    {
                        var session = request.SessionTemplate.Clone();
                        session.CreateTime = session.ApproximateLastUseTime = spannerClientMock.GetNowTimestamp();
                        session.Expired = false;
                        session.Name = Guid.NewGuid().ToString();
                        session.SessionName = new SessionName(ProjectId, Instance, Database, session.Name);

                        response.Session.Add(session);
                    }

                    return Task.FromResult(response);
                });
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupBeginTransactionAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.BeginTransactionAsync(It.IsNotNull<BeginTransactionRequest>(), It.IsAny<CallSettings>()))
                .Returns(Task.FromResult(
                    new Transaction
                    {
                        Id = ByteString.CopyFromUtf8(Guid.NewGuid().ToString())
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupPartitionAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.PartitionReadAsync(It.IsNotNull<PartitionReadRequest>(), It.IsAny<CallSettings>()))
                .Returns<PartitionReadRequest, CallSettings>((request, _) => Task.FromResult(
                    new PartitionResponse
                    {
                        Partitions = { Enumerable.Range(0, (int) request.PartitionOptions.MaxPartitions)
                            .Select(token => new Partition { PartitionToken = ByteString.CopyFromUtf8(token.ToString())}) }
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupExecuteBatchDmlAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.ExecuteBatchDmlAsync(It.IsNotNull<ExecuteBatchDmlRequest>(), It.IsAny<CallSettings>()))
                .Returns(Task.FromResult(
                    new ExecuteBatchDmlResponse
                    {
                        Status = new Rpc.Status
                        {
                            Code = (int)StatusCode.OK
                        },
                        ResultSets =
                        {
                            new ResultSet
                            {
                                Stats = new ResultSetStats
                                {
                                    RowCountExact = 10
                                }
                            }
                        }
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupExecuteBatchDmlAsync_Fails(this Mock<SpannerClient> spannerClientMock, int failures, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            spannerClientMock
                .SetupSequence(client => client.ExecuteBatchDmlAsync(It.IsNotNull<ExecuteBatchDmlRequest>(), It.IsAny<CallSettings>()))
                .SetupFailures(failures, statusCode, exceptionMessage, exceptionRetryDelay)
                .Returns(Task.FromResult(
                    new ExecuteBatchDmlResponse
                    {
                        Status = new Rpc.Status
                        {
                            Code = (int)StatusCode.OK
                        },
                        ResultSets =
                        {
                            new ResultSet
                            {
                                Stats = new ResultSetStats
                                {
                                    RowCountExact = 10
                                }
                            }
                        }
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupCommitAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.CommitAsync(It.IsNotNull<CommitRequest>(), It.IsAny<CallSettings>()))
                .Returns(Task.FromResult(
                    new CommitResponse
                    {
                        CommitTimestamp = spannerClientMock.GetNowTimestamp()
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupCommitAsync_Fails(this Mock<SpannerClient> spannerClientMock, int failures, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            spannerClientMock
                .SetupSequence(client => client.CommitAsync(It.IsNotNull<CommitRequest>(), It.IsAny<CallSettings>()))
                .SetupFailures(failures, statusCode, exceptionMessage, exceptionRetryDelay)
                .Returns(Task.FromResult(
                    new CommitResponse
                    {
                        CommitTimestamp = spannerClientMock.GetNowTimestamp()
                    }));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupCommitAsync_FailsAlways(this Mock<SpannerClient> spannerClientMock, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            spannerClientMock
                .Setup(client => client.CommitAsync(It.IsNotNull<CommitRequest>(), It.IsAny<CallSettings>()))
                .Throws(BuildRpcException(exceptionRetryDelay, statusCode, exceptionMessage));

            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupRollbackAsync(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.RollbackAsync(It.IsNotNull<RollbackRequest>(), It.IsAny<CallSettings>()))
                .Returns(Task.FromResult(true));
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupExecuteStreamingSql(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.ExecuteStreamingSql(
                    It.IsAny<ExecuteSqlRequest>(),
                    It.IsAny<CallSettings>()))
                .Returns<ExecuteSqlRequest, CallSettings>((request, _) =>
                {
                    IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                    .Select((resumeToken, index) => new PartialResultSet
                    {
                        ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                        Values = { Value.ForNumber(index) }
                    })
                    .ToList();
                    IEnumerable<PartialResultSet> callResults = request.ResumeToken.IsEmpty
                        ? results
                        : results.SkipWhile(r => r.ResumeToken != request.ResumeToken).Skip(1);
                    var asyncResults = new AsyncStreamAdapter<PartialResultSet>(callResults.ToAsyncEnumerable().GetAsyncEnumerator(default));

                    var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                        Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                    return new ExecuteStreamingSqlStreamImpl(call);
                });
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupStreamingRead(this Mock<SpannerClient> spannerClientMock)
        {
            spannerClientMock
                .Setup(client => client.StreamingRead(
                    It.IsAny<ReadRequest>(),
                    It.IsAny<CallSettings>()))
                .Returns<ReadRequest, CallSettings>((request, _) =>
                {
                    IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                        .Select((resumeToken, index) => new PartialResultSet
                        {
                            ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                            Values = { Value.ForNumber(index) }
                        })
                        .ToList();
                    IEnumerable<PartialResultSet> callResults = request.ResumeToken.IsEmpty
                        ? results
                        : results.SkipWhile(r => r.ResumeToken != request.ResumeToken).Skip(1);
                    var asyncResults = new AsyncStreamAdapter<PartialResultSet>(callResults.ToAsyncEnumerable().GetAsyncEnumerator(default));

                    var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                        Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                    return new StreamingReadStreamImpl(call);
                });
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupExecuteStreamingSqlForDml(this Mock<SpannerClient> spannerClientMock, ResultSetStats.RowCountOneofCase type)
        {
            ResultSetStats stats = new ResultSetStats();
            if (type == ResultSetStats.RowCountOneofCase.RowCountExact)
            {
                stats.RowCountExact = 10;
            }
            else
            {
                stats.RowCountLowerBound = 100;
            }
            spannerClientMock
                .SetupSequence(client => client.ExecuteStreamingSql(
                    It.IsAny<ExecuteSqlRequest>(),
                    It.IsAny<CallSettings>()))
                .Returns(() =>
                {
                    IEnumerable<PartialResultSet> results = new string[] { "token1" }
                    .Select((resumeToken, index) => new PartialResultSet
                    {
                        ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                        Stats = stats
                    })
                    .ToList();
                    var asyncResults = new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator(default));
                    var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                        Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                    return new ExecuteStreamingSqlStreamImpl(call);
                });
            return spannerClientMock;
        }

        internal static Mock<SpannerClient> SetupExecuteStreamingSqlForDmlThrowingEosError(this Mock<SpannerClient> spannerClientMock)
        {
            const string eosError = "Received unexpected EOS on DATA frame from server";
            spannerClientMock
                .SetupSequence(client => client.ExecuteStreamingSql(
                    It.IsAny<ExecuteSqlRequest>(),
                    It.IsAny<CallSettings>()))
		.Throws(new SpannerException(ErrorCode.Internal, eosError))
		.Throws(new SpannerException(ErrorCode.Internal, eosError))
                .Returns(() =>
                {
                    IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                    .Select((resumeToken, index) => new PartialResultSet
                    {
                        ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                        Stats = new ResultSetStats
                        {
                            RowCountExact = 10
                        }
                    })
                    .ToList();
                    var asyncResults = new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator(default));
                    var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                        Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                    return new ExecuteStreamingSqlStreamImpl(call);
                });
            return spannerClientMock;
        }

        private static ISetupSequentialResult<TResult> SetupFailures<TResult>(this ISetupSequentialResult<TResult> setup, int failures, StatusCode statusCode, string exceptionMessage, TimeSpan? exceptionRetryDelay)
        {
            var exception = BuildRpcException(exceptionRetryDelay, statusCode, exceptionMessage);
            for (int i = 0; i < failures; i++)
            {
                setup = setup.Throws(exception);
            }

            return setup;
        }

        private static RpcException BuildRpcException(TimeSpan? exceptionRetryDelay, StatusCode exceptionStatus, string exceptionMessage)
        {
            var status = new Status(exceptionStatus, exceptionMessage);
            if (!exceptionRetryDelay.HasValue)
            {
                return new RpcException(status);
            }
            RetryInfo retry = new RetryInfo
            {
                RetryDelay = Duration.FromTimeSpan(exceptionRetryDelay.Value)
            };
            Metadata trailers = new Metadata
            {
                { s_retryInfoMetadataKey, retry.ToByteArray() }
            };
            return new RpcException(status, trailers);
        }

        private static Timestamp GetNowTimestamp(this Mock<SpannerClient> spannerClientMock)
        {
            var clock = spannerClientMock.Object.Settings.Clock;
            return Timestamp.FromDateTime(clock.GetCurrentDateTimeUtc());
        }
    }
}
