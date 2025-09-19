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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Status = Grpc.Core.Status;
using static Google.Cloud.Spanner.V1.SpannerClientImpl;
using NSubstitute;
using NSubstitute.Extensions;
using NSubstitute.ExceptionExtensions;
using NSubstitute.Core;

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
        internal static SpannerClient CreateMockClient(Logger logger)
        {
            var fakeScheduler = new FakeScheduler();
            var settings = SpannerSettings.GetDefault();
            settings.Scheduler = fakeScheduler;
            settings.Clock = fakeScheduler.Clock;
            settings.Logger = logger;
            var mock = Substitute.ForPartsOf<SpannerClient>();
            mock.Settings.Returns(settings);
            return mock;
        }

        internal static SpannerClient SetupMultiplexSessionCreationAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure().CreateSessionAsync(Arg.Is<CreateSessionRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(args =>
                {
                    var request = (CreateSessionRequest) args[0];
                    Session response = new Session();
                    response.CreateTime = spannerClientMock.GetNowTimestamp();
                    response.CreatorRole = request.Session.CreatorRole;
                    response.Multiplexed = request.Session.Multiplexed;
                    response.Name = Guid.NewGuid().ToString();
                    response.SessionName = new SessionName(ProjectId, Instance, Database, response.Name);

                    return Task.FromResult(response);
                });
            return spannerClientMock;
        }

        internal static SpannerClient SetupBatchCreateSessionsAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure()
                .BatchCreateSessionsAsync(Arg.Is<BatchCreateSessionsRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(args =>
                {
                    var request = (BatchCreateSessionsRequest) args[0];
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

        internal static SpannerClient SetupBeginTransactionAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure()
                .BeginTransactionAsync(Arg.Is<BeginTransactionRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(
                    new Transaction
                    {
                        Id = ByteString.CopyFromUtf8(Guid.NewGuid().ToString())
                    }));
            return spannerClientMock;
        }

        internal static SpannerClient SetupPartitionAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure()
                .PartitionReadAsync(Arg.Is<PartitionReadRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(args => Task.FromResult(
                    new PartitionResponse
                    {
                        Partitions = { BuildPartitions((int) args.Arg<PartitionReadRequest>().PartitionOptions.MaxPartitions) },
                        Transaction = MaybeGetTransaction(args.Arg<PartitionReadRequest>().Transaction)
                    }));
            return spannerClientMock;

            static IEnumerable<Partition> BuildPartitions(int partitionsCount) =>
                Enumerable.Range(0, partitionsCount).Select(token => new Partition
                {
                    PartitionToken = ByteString.CopyFromUtf8(token.ToString())
                });
        }

        internal static SpannerClient SetupExecuteBatchDmlAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure()
                .ExecuteBatchDmlAsync(Arg.Is<ExecuteBatchDmlRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(args => Task.FromResult(
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
                                },
                                Metadata = new ResultSetMetadata
                                {
                                    Transaction = MaybeGetTransaction(args.Arg<ExecuteBatchDmlRequest>().Transaction)
                                }
                            }
                        }
                    }));
            return spannerClientMock;
        }

        internal static SpannerClient SetupExecuteBatchDmlAsync_Fails(this SpannerClient spannerClientMock, int failures, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            var exception = BuildRpcException(exceptionRetryDelay, statusCode, exceptionMessage);
            var returns = new List<Func<CallInfo, Task<ExecuteBatchDmlResponse>>>();
            for (int i = 0; i < failures; i++)
            {
                returns.Add(_ => throw exception);
            }
            returns.Add(args => Task.FromResult(
                    new ExecuteBatchDmlResponse
                    {
                        Status = new Rpc.Status
                        {
                            Code = (int) StatusCode.OK
                        },
                        ResultSets =
                        {
                            new ResultSet
                            {
                                Stats = new ResultSetStats
                                {
                                    RowCountExact = 10
                                },
                                Metadata = new ResultSetMetadata
                                {
                                    Transaction = MaybeGetTransaction(args.Arg<ExecuteBatchDmlRequest>().Transaction)
                                }
                            }
                        }
                    }));

            spannerClientMock.Configure()
                .ExecuteBatchDmlAsync(Arg.Is<ExecuteBatchDmlRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(returns[0], returns.Skip(1).ToArray());
            return spannerClientMock;
        }

        internal static SpannerClient SetupCommitAsync(this SpannerClient spannerClientMock)
        {
            var timestamp = spannerClientMock.GetNowTimestamp();
            spannerClientMock.Configure()
                .CommitAsync(Arg.Is<CommitRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(
                    new CommitResponse
                    {
                        CommitTimestamp = timestamp
                    }));
            return spannerClientMock;
        }

        internal static SpannerClient SetupCommitAsync_Fails(this SpannerClient spannerClientMock, int failures, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            var timestamp = spannerClientMock.GetNowTimestamp();
            var exception = BuildRpcException(exceptionRetryDelay, statusCode, exceptionMessage);
            var returns = new List<Func<CallInfo, Task<CommitResponse>>>();
            for (int i = 0; i < failures; i++)
            {
                returns.Add(_ => throw exception);
            }
            returns.Add(_ => Task.FromResult(new CommitResponse { CommitTimestamp = timestamp }));
            spannerClientMock.Configure()
                .CommitAsync(Arg.Is<CommitRequest>(x => x != null), Arg.Any<CallSettings>())
                // Annoyingly, NSubstitute doesn't have an overload which just accepts a single collection
                .Returns(returns[0], returns.Skip(1).ToArray());
            return spannerClientMock;
        }

        internal static SpannerClient SetupCommitAsync_FailsAlways(this SpannerClient spannerClientMock, StatusCode statusCode, string exceptionMessage = "Bang!", TimeSpan? exceptionRetryDelay = null)
        {
            spannerClientMock.Configure()
                .CommitAsync(Arg.Is<CommitRequest>(x => x != null), Arg.Any<CallSettings>())
                .Throws(BuildRpcException(exceptionRetryDelay, statusCode, exceptionMessage));

            return spannerClientMock;
        }

        internal static SpannerClient SetupRollbackAsync(this SpannerClient spannerClientMock)
        {
            spannerClientMock.Configure()
                .RollbackAsync(Arg.Is<RollbackRequest>(x => x != null), Arg.Any<CallSettings>())
                .Returns(Task.FromResult(true));
            return spannerClientMock;
        }

        internal static SpannerClient SetupExecuteStreamingSql(this SpannerClient spannerClientMock) =>
            SetupExecuteStreamingSql(spannerClientMock, new ExecuteSqlRequest());

        internal static SpannerClient SetupExecuteStreamingSql(this SpannerClient spannerClientMock, ExecuteSqlRequest requestReceiver)
        {
            spannerClientMock.Configure()
                .ExecuteStreamingSql(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(args =>
                {
                    var request = args.Arg<ExecuteSqlRequest>();
                    // Copy the executed request into the receiver so that callers can perform further checking later.
                    requestReceiver.MergeFrom(request);
                    IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                    .Select((resumeToken, index) => new PartialResultSet
                    {
                        ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                        Values = { Value.ForNumber(index) },
                        Metadata = index == 0 ? new ResultSetMetadata { Transaction = MaybeGetTransaction(request.Transaction) } : null
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

        internal static SpannerClient SetupStreamingRead(this SpannerClient spannerClientMock) =>
            SetupStreamingRead(spannerClientMock, new ReadRequest());

        internal static SpannerClient SetupStreamingRead(this SpannerClient spannerClientMock, ReadRequest readRequestReceiver)
        {
            spannerClientMock.Configure()
                .StreamingRead(Arg.Any<ReadRequest>(), Arg.Any<CallSettings>())
                .Returns(args =>
                {
                    var request = args.Arg<ReadRequest>();
                    // Copy the executed request into the receiver so that callers can perform further checking later.
                    readRequestReceiver.MergeFrom(request);
                    IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                        .Select((resumeToken, index) => new PartialResultSet
                        {
                            ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                            Values = { Value.ForNumber(index) },
                            Metadata = index == 0 ? new ResultSetMetadata { Transaction = MaybeGetTransaction(request.Transaction) } : null
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

        internal static SpannerClient SetupExecuteStreamingSqlForDml(this SpannerClient spannerClientMock, ResultSetStats.RowCountOneofCase type)
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
            spannerClientMock.Configure()
                .ExecuteStreamingSql(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(args =>
                {
                    IEnumerable<PartialResultSet> results = new string[] { "token1" }
                    .Select((resumeToken, index) => new PartialResultSet
                    {
                        ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                        Stats = stats,
                        Metadata = index == 0 ? new ResultSetMetadata { Transaction = MaybeGetTransaction(args.Arg<ExecuteSqlRequest>().Transaction)} : null
                    })
                    .ToList();
                    var asyncResults = new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator(default));
                    var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                        Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                    return new ExecuteStreamingSqlStreamImpl(call);
                });
            return spannerClientMock;
        }

        internal static SpannerClient SetupExecuteStreamingSqlForDmlThrowingEosError(this SpannerClient spannerClientMock)
        {
            const string eosError = "Received unexpected EOS on DATA frame from server";
            spannerClientMock.Configure()
                .ExecuteStreamingSql(Arg.Any<ExecuteSqlRequest>(), Arg.Any<CallSettings>())
                .Returns(
                    _ => throw new SpannerException(ErrorCode.Internal, eosError),
                    _ => throw new SpannerException(ErrorCode.Internal, eosError),
                    args =>
                    {
                        IEnumerable<PartialResultSet> results = new string[] {"token1", "token2", "token3"}
                        .Select((resumeToken, index) => new PartialResultSet
                        {
                            ResumeToken = ByteString.CopyFromUtf8(resumeToken),
                            Stats = new ResultSetStats
                            {
                                RowCountExact = 10
                            },
                            Metadata = index == 0 ? new ResultSetMetadata { Transaction = MaybeGetTransaction(args.Arg<ExecuteSqlRequest>().Transaction) } : null
                        })
                        .ToList();
                        var asyncResults = new AsyncStreamAdapter<PartialResultSet>(results.ToAsyncEnumerable().GetAsyncEnumerator(default));
                        var call = new AsyncServerStreamingCall<PartialResultSet>(asyncResults,
                            Task.FromResult(new Metadata()), () => new Status(), () => new Metadata(), () => { });
                        return new ExecuteStreamingSqlStreamImpl(call);
                    });
            return spannerClientMock;
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

        private static Timestamp GetNowTimestamp(this SpannerClient spannerClientMock)
        {
            var clock = spannerClientMock.Settings.Clock;
            return Timestamp.FromDateTime(clock.GetCurrentDateTimeUtc());
        }

        internal static Transaction MaybeGetTransaction(TransactionSelector selector) => selector?.SelectorCase switch
        {
            TransactionSelector.SelectorOneofCase.Begin => new Transaction { Id = ByteString.CopyFromUtf8("transaction") },
            _ => null
        };
    }
}
