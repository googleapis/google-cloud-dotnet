// Copyright 2018, Google LLC
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
using Google.Api.Gax.Testing;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Firestore.V1.FirestoreClient;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;
using static Google.Cloud.Firestore.V1.Target.Types;

namespace Google.Cloud.Firestore.Tests
{
    public class WatchStreamTest
    {
        /// <summary>
        /// A timeout for waiting for asynchronous operations. The code is designed
        /// so that if this *does* time out, it always represents a failure. We should never
        /// actually need this much time; it just prevents tests from hanging entirely.
        /// </summary>
        private static readonly TimeSpan s_timeout = TimeSpan.FromSeconds(10);

        [Fact]
        public void Stop()
        {
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            sequence.WatchStream.Stop(CancellationToken.None);
            task.Wait();
            sequence.Verify();
        }

        [Fact]
        public void StreamReset()
        {
            ByteString token = ByteString.CopyFromUtf8("token");
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponse(WatchResponseResult.ResetStream);
            // First reset doesn't get a token
            sequence.ExpectConnect(null, StreamInitializationCause.ResetRequested);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token);
            sequence.ProvideResponse(WatchResponseResult.ResetStream);
            // Second reset does
            sequence.ExpectConnect(token, StreamInitializationCause.ResetRequested);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            sequence.WatchStream.Stop(CancellationToken.None);
            task.Wait();
            sequence.Verify();
        }

        [Fact]
        public void StreamComplete()
        {
            ByteString token1 = ByteString.CopyFromUtf8("token1");
            ByteString token2 = ByteString.CopyFromUtf8("token2");
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token1);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token2);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            // The stream ended. Restart with the last token.
            sequence.ExpectConnect(token2, StreamInitializationCause.StreamCompleted);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            sequence.WatchStream.Stop(CancellationToken.None);
            task.Wait();
            sequence.Verify();
        }

        [Fact]
        public void RetriableRpcException()
        {
            ByteString token1 = ByteString.CopyFromUtf8("token1");
            ByteString token2 = ByteString.CopyFromUtf8("token2");
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token1);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token2);
            sequence.RpcException(new RpcException(new Status(StatusCode.DeadlineExceeded, "This exception is transient")));
            // The server threw a retriable exception. Reinitialize.
            sequence.ExpectConnect(token2, StreamInitializationCause.RpcError);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            sequence.WatchStream.Stop(CancellationToken.None);
            task.Wait();
            sequence.Verify();
        }

        [Fact]
        public void ResourceExhaustedRpcException()
        {
            ByteString token1 = ByteString.CopyFromUtf8("token1");
            ByteString token2 = ByteString.CopyFromUtf8("token2");
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token1);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token2);
            // This exception will cause us to double our backoff.
            // TODO: Timing tests in general.
            sequence.RpcException(new RpcException(new Status(StatusCode.ResourceExhausted, "This exception is transient")));
            // The server throw a retriable exception. Reinitialize.
            sequence.ExpectConnect(token2, StreamInitializationCause.RpcError);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            sequence.WatchStream.Stop(CancellationToken.None);
            task.Wait();
            sequence.Verify();
        }

        [Fact]
        public void NonRetriableRpcException()
        {
            ByteString token1 = ByteString.CopyFromUtf8("token1");
            ByteString token2 = ByteString.CopyFromUtf8("token2");
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token1);
            sequence.ProvideResponse(WatchResponseResult.StreamHealthy, token2);
            // This exception is not retriable.
            var exception = new RpcException(new Status(StatusCode.InvalidArgument, "This exception is permanent"));
            sequence.RpcException(exception);

            Task task = sequence.RunToStability();
            Assert.Equal(TaskStatus.Faulted, task.Status);
            Assert.Equal(exception, task.Exception.InnerException);
            sequence.Verify();
        }

        [Fact]
        public void InitialTokenCancellation_WhileRunning()
        {
            var tokenSource = new CancellationTokenSource();
            var sequence = new TestSequence(tokenSource.Token);
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            tokenSource.Cancel();
            // If it doesn't finish quickly, Task.Wait will time out and the assertion will fail.
            Assert.Throws<AggregateException>(() => task.Wait(s_timeout));
            Assert.Equal(TaskStatus.Canceled, task.Status);
        }

        [Fact]
        public void InitialTokenCancellation_WhileServerHanging()
        {
            var tokenSource = new CancellationTokenSource();
            var sequence = new TestSequence(tokenSource.Token);
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.WaitForCancellation();

            Task task = sequence.RunToStability();
            tokenSource.Cancel();
            AssertTaskIsCancelledSoon(task);
            sequence.Verify();
        }

        [Fact]
        public void InitialTokenCancellation_WhileStateMachineHanging()
        {
            var tokenSource = new CancellationTokenSource();
            var sequence = new TestSequence(tokenSource.Token);
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponseHangingInStateMachine();

            Task task = sequence.RunToStability();
            tokenSource.Cancel();
            AssertTaskIsCancelledSoon(task);
            sequence.Verify();
        }

        [Fact]
        public void StopTokenCancellation()
        {
            var sequence = new TestSequence();
            sequence.ExpectConnect(null, StreamInitializationCause.WatchStarting);
            sequence.ProvideResponse(WatchResponseResult.Continue);
            sequence.ProvideResponseHangingInStateMachine();

            Task task = sequence.RunToStability();
            var tokenSource = new CancellationTokenSource();
            sequence.WatchStream.Stop(tokenSource.Token);
            tokenSource.Cancel();
            AssertTaskIsCancelledSoon(task);
            sequence.Verify();
        }

        [Fact]
        public void CreateTarget_Query()
        {
            var client = new FakeFirestoreClient();
            var db = FirestoreDb.Create("project", "db", client);
            var query = db.Collection("col").Limit(10);
            var expected = new Target
            {
                TargetId = WatchStream.WatchTargetId,
                Query = new QueryTarget
                {
                    Parent = db.DocumentsPath,
                    StructuredQuery = new StructuredQuery
                    {
                        From = { new CollectionSelector { CollectionId = "col" } },
                        Limit = 10
                    }
                }
            };
            var actual = WatchStream.CreateTarget(query);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CreateTarget_Document()
        {
            var client = new FakeFirestoreClient();
            var db = FirestoreDb.Create("project", "db", client);
            var doc = db.Document("col/doc");
            var expected = new Target
            {
                TargetId = WatchStream.WatchTargetId,
                Documents = new DocumentsTarget { Documents = { doc.Path } }
            };
            var actual = WatchStream.CreateTarget(doc);
            Assert.Equal(expected, actual);
        }

        private void AssertTaskIsCancelledSoon(Task task)
        {
            // If it doesn't finish quickly, Task.Wait will time out and the assertion will fail.
            Assert.Throws<AggregateException>(() => task.Wait(s_timeout));
            Assert.Equal(TaskStatus.Canceled, task.Status);
        }

        /// <summary>
        /// A test sequence, used to set up expectations of how the gRPC stream and the state machine interact.
        /// </summary>
        private class TestSequence
        {
            private readonly List<FakeWatchStream> _streams;
            private readonly FakeFirestoreListenClient _client;
            /// <summary>
            /// This task will complete when either the server or the state machine is deliberately hanging, waiting
            /// for cancellation.
            /// </summary>
            private readonly TaskCompletionSource<int> _completionTaskSource = new TaskCompletionSource<int>();
            private readonly FakeScheduler _scheduler;

            private FakeWatchStream _currentStream;
            private List<Func<ListenResponse>> _currentResponseList;
            private FakeWatchState _watchState;
            private int _responseIndex;

            internal WatchStream WatchStream { get; }

            internal TestSequence(CancellationToken initialCancellationToken = default)
            {
                _streams = new List<FakeWatchStream>();
                _client = new FakeFirestoreListenClient(_streams, "projects/project/databases/db");
                _watchState = new FakeWatchState(TriggerCompletion);
                var db = FirestoreDb.Create("project", "db", _client);
                var target = WatchStream.CreateTarget(db.Document("col/doc"));
                _scheduler = new FakeScheduler();
                WatchStream = new WatchStream(_scheduler, _watchState, target, db, initialCancellationToken);
            }

            /// <summary>
            /// Expect the WatchStream to call the Listen RPC, and then cll OnStreamInitialization with the given cause.
            /// </summary>
            internal void ExpectConnect(ByteString expectedResumeToken, StreamInitializationCause expectedCause)
            {
                _currentResponseList = new List<Func<ListenResponse>>();
                var expectedRequest = WatchStream.CreateRequest(expectedResumeToken);
                _currentStream = new FakeWatchStream(expectedRequest, new FakeResponseList(_currentResponseList, TriggerCompletion));
                _streams.Add(_currentStream);
                _watchState.ExpectInitialization(expectedCause);
            }

            /// <summary>
            /// Causes the fake server to provide a response, which we expect to be passed to the
            /// state machine. The resume token for the state machine is set to <paramref name="resumeToken"/> for
            /// requests which occur after this point.
            /// </summary>
            internal void ProvideResponse(WatchResponseResult result, ByteString resumeToken)
            {
                _watchState.AddResumeToken(_responseIndex, resumeToken);
                ProvideResponse(result);
            }

            /// <summary>
            /// Causes the fake server to provide a response, which we expect to be passed to the
            /// state machine.
            /// </summary>
            internal void ProvideResponse(WatchResponseResult result)
            {
                // The response is opaque to WatchStream, but we want to make sure the state machine gets the 
                var response = new ListenResponse { TargetChange = new TargetChange { TargetIds = { _responseIndex++ } } };
                _currentResponseList.Add(() => response);
                _watchState.ExpectResponse(response, result);
            }

            /// <summary>
            /// Causes the fake server to provide a response which is passed to the state machine - which then
            /// hangs (expecting its cancellation token to be cancelled).
            /// </summary>
            internal void ProvideResponseHangingInStateMachine()
            {
                var response = new ListenResponse { TargetChange = new TargetChange { TargetIds = { _responseIndex++ } } };
                _currentResponseList.Add(() => response);
                _watchState.ExpectResponseAndWaitForUserCancellation(response);
            }

            /// <summary>
            /// Causes the fake server to throw the given exception from the gRPC stream.
            /// </summary>
            internal void RpcException(RpcException exception)
            {
                _currentResponseList.Add(() => throw exception);
            }

            /// <summary>
            /// Causes the fake server to effectively wait: the gRPC stream of responses doesn't return another item.
            /// </summary>
            internal void WaitForCancellation()
            {
                _currentResponseList.Add(null);
            }

            private void TriggerCompletion() => _completionTaskSource.SetResult(0);

            /// <summary>
            /// Verifies that all the RPC stream responses and state machine calls have been consumed appropriately.
            /// </summary>
            internal void Verify()
            {
                // Check the state machine had all the expected calls
                _watchState.Verify();
                // Check that all the streams were closed and disposed, with
                _client.Verify();
            }

            /// <summary>
            /// Runs the test sequence until either the fake server is paused, or all its responses have been consumed.
            /// </summary>
            /// <returns>The task from the WatchStream.StartAsync method</returns>
            internal Task RunToStability()
            {
                Task task = null;
                _scheduler.Run(() =>
                {
                    task = WatchStream.StartAsync();
                    // Wait for:
                    // - The server to go into "hanging" mode
                    // - The listening task to complete (e.g. due to an error)
                    // - A timeout (because something is broken)
                    Task.WaitAny(new[] { task, _completionTaskSource.Task }, s_timeout);
                });
                return task;
            }
        }

        private class FakeWatchState : IWatchState
        {
            private List<(int index, ByteString token)> _resumeTokens = new List<(int, ByteString)> { (-1, null) };
            private int _lastSeenIndex = -1;
            // Very primitive mocking; we can't use Moq due to the types being internal.
            private Queue<Delegate> _expectedCalls = new Queue<Delegate>();
            private readonly Action _hangingCallback;

            public ByteString ResumeToken => _resumeTokens.Last(tuple => tuple.index <= _lastSeenIndex).token;

            internal FakeWatchState(Action hangingCallback) => _hangingCallback = hangingCallback;

            public Task<WatchResponseResult> HandleResponseAsync(ListenResponse response, CancellationToken cancellationToken)
            {
                _lastSeenIndex = response.TargetChange.TargetIds[0];
                var call = (Func<ListenResponse, CancellationToken, Task<WatchResponseResult>>) _expectedCalls.Dequeue();
                return call(response, cancellationToken);
            }

            public void OnStreamInitialization(StreamInitializationCause cause)
            {
                var call = (Action<StreamInitializationCause>) _expectedCalls.Dequeue();
                call(cause);
            }

            internal void AddResumeToken(int index, ByteString token) => _resumeTokens.Add((index, token));

            internal void ExpectResponse(ListenResponse expectedResponse, WatchResponseResult result)
            {
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
                Func<ListenResponse, CancellationToken, Task<WatchResponseResult>> call = async (response, _) =>
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
                {
                    Assert.Equal(expectedResponse, response);
                    return result;
                };
                _expectedCalls.Enqueue(call);
            }

            internal void ExpectResponseAndWaitForUserCancellation(ListenResponse expectedResponse)
            {
                Func<ListenResponse, CancellationToken, Task<WatchResponseResult>> call = async (response, cancellationToken) =>
                {
                    Assert.Equal(expectedResponse, response);
                    _hangingCallback();
                    await Task.Delay(s_timeout, cancellationToken).ConfigureAwait(false);
                    throw new InvalidOperationException("Shouldn't get here");
                };
                _expectedCalls.Enqueue(call);
            }

            internal void ExpectInitialization(StreamInitializationCause expectedCause)
            {
                Action<StreamInitializationCause> call = cause => Assert.Equal(expectedCause, cause);
                _expectedCalls.Enqueue(call);
            }

            internal void Verify() => Assert.Empty(_expectedCalls);
        }

        private class FakeFirestoreListenClient : FakeFirestoreClient
        {
            private readonly string _expectedResourceName;
            private readonly List<FakeWatchStream> _streams;
            private int _index;

            internal FakeFirestoreListenClient(List<FakeWatchStream> streams, string expectedResourceName)
            {
                _streams = streams;
                _expectedResourceName = expectedResourceName;
            }

            public override ListenStream Listen(
                CallSettings callSettings = null,
                BidirectionalStreamingSettings streamingSettings = null)
            {
                var metadata = new Metadata();
                callSettings.HeaderMutation?.Invoke(metadata);
                var resourcePrefixHeader = metadata.FirstOrDefault(entry => entry.Key == FirestoreClientImpl.ResourcePrefixHeader);
                Assert.NotNull(resourcePrefixHeader);
                Assert.Equal(_expectedResourceName, resourcePrefixHeader.Value);
                return _streams[_index++];
            }

            internal void Verify()
            {
                // All streams should have been used.
                Assert.Equal(_streams.Count, _index);

                // Each stream should be exhausted.
                for (int i = 0; i < _streams.Count; i++)
                {
                    _streams[i].Verify(i);
                }
            }
        }

        private class FakeResponseList : IAsyncStreamReader<ListenResponse>
        {
            private readonly List<Func<ListenResponse>> _responses;
            private int _index = -1;
            private readonly Action _hangingCallback;

            public ListenResponse Current => _responses[_index].Invoke();

            internal FakeResponseList(List<Func<ListenResponse>> responses, Action hangingCallback)
            {
                _responses = responses;
                _hangingCallback = hangingCallback;
            }

            public async Task<bool> MoveNext(CancellationToken cancellationToken)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (_index < _responses.Count)
                {
                    _index++;
                }
                // We use a null response provider to mean "Wait, we're expecting to be cancelled".
                if (_index < _responses.Count && _responses[_index] == null)
                {
                    _hangingCallback();
                    await Task.Delay(s_timeout, cancellationToken);
                    cancellationToken.ThrowIfCancellationRequested();
                }
                return _index < _responses.Count;
            }

            internal void Verify(int streamIndex)
            {
                // We should either have exhausted the stream or be looking at the last element.
                Assert.True(_index >= _responses.Count - 1, $"streamIndex={streamIndex}; _index = {_index}; Count={_responses.Count}");
            }
        }

        private class FakeWatchStream : ListenStream
        {
            private readonly FakeResponseList _responses;
            private readonly ListenRequest _expectedRequest;
            internal bool Completed { get; private set; }
            internal bool Disposed { get; private set; }
            private bool _requestWritten = false;
            private AsyncDuplexStreamingCall<ListenRequest, ListenResponse> _grpcCall;

            internal FakeWatchStream(ListenRequest expectedRequest, FakeResponseList responses)
            {
                _expectedRequest = expectedRequest;
                _responses = responses;
                _grpcCall = TestCalls.AsyncDuplexStreamingCall<ListenRequest, ListenResponse>(null, responses, null, null, null, () => Disposed = true);
            }

            public override AsyncDuplexStreamingCall<ListenRequest, ListenResponse> GrpcCall => _grpcCall;

            public override Task TryWriteAsync(ListenRequest message, WriteOptions options) =>
                TryWriteAsync(message);

            public override async Task TryWriteAsync(ListenRequest message)
            {
                Assert.False(_requestWritten);
                _requestWritten = true;
                Assert.Equal(_expectedRequest, message);
                await Task.Yield();
            }

            public override async Task TryWriteCompleteAsync()
            {
                Completed = true;
                await Task.Yield();
            }

            public void Verify(int streamIndex)
            {
                Assert.True(_requestWritten);
                Assert.True(Completed);
                Assert.True(Disposed);
                _responses.Verify(streamIndex);
            }
        }
    }
}
