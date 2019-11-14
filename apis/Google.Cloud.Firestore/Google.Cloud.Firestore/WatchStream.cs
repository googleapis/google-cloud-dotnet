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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Firestore.V1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore
{
    internal sealed class WatchStream
    {
        private static readonly HashSet<StatusCode> s_transientErrorStatusCodes = new HashSet<StatusCode>
        {
            StatusCode.Aborted,
            StatusCode.Cancelled,
            StatusCode.Unknown,
            StatusCode.DeadlineExceeded,
            StatusCode.ResourceExhausted,
            StatusCode.Internal,
            StatusCode.Unavailable,
            StatusCode.Unauthenticated
        };

        internal const int WatchTargetId = 0x4323; // "C#"
        private readonly IScheduler _scheduler;
        private readonly FirestoreDb _db;
        // The token source for all network operations. This is cancelled when a stop is requested,
        // even if the user never cancels a token.
        private readonly CancellationTokenSource _networkCancellationTokenSource;
        // The token source for the callback. This is cancelled if the user cancels either the initial
        // cancellation token provided to Listen, or the cancellation token provided to StopAsync.
        private readonly CancellationTokenSource _callbackCancellationTokenSource;
        private readonly IWatchState _state;
        private readonly RetrySettings.IJitter _backoffJitter;
        private readonly BackoffSettings _backoffSettings;
        private readonly Target _target;
        private readonly CallSettings _listenCallSettings;

        private readonly object _stateLock = new object();

        // Only mutable variables within the class: if the user calls Stop and passes in a cancellation token,
        // we link it with _callbackCancellationTokenSource, and need to be able to dispose of that registration
        // on exit. These variables are protected by _stateLock.
        private CancellationTokenRegistration _stopCancellationTokenRegistration;
        private bool _finished;

        internal WatchStream(IWatchState state, Target target, FirestoreDb db, CancellationToken cancellationToken)
            : this(SystemScheduler.Instance, state, target, db, cancellationToken)
        {
        }

        internal WatchStream(IScheduler scheduler, IWatchState state, Target target, FirestoreDb db, CancellationToken cancellationToken)
        {
            _scheduler = scheduler;
            _state = state;
            _target = target;
            _db = db;
            _callbackCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            _networkCancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(_callbackCancellationTokenSource.Token);
            _listenCallSettings = CallSettings.FromHeader(FirestoreClientImpl.ResourcePrefixHeader, db.RootPath);

            // TODO: Make these configurable?
            _backoffSettings = new BackoffSettings(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(30), 2.0);
            _backoffJitter = RetrySettings.RandomJitter;
        }

        internal async Task StartAsync()
        {
            // State used within the method. This is modified by local methods too.
            StreamInitializationCause cause = StreamInitializationCause.WatchStarting;
            FirestoreClient.ListenStream underlyingStream = null;
            TimeSpan nextBackoff = TimeSpan.Zero;

            try
            {
                // This won't actually run forever. Calling Stop will cancel the cancellation token, and we'll end up with
                // an exception which may or may not be caught.
                while (true)
                {
                    var serverResponse = await GetNextResponse().ConfigureAwait(false);
                    _callbackCancellationTokenSource.Token.ThrowIfCancellationRequested();
                    var result = await _state.HandleResponseAsync(serverResponse, _callbackCancellationTokenSource.Token).ConfigureAwait(false);
                    switch (result)
                    {
                        case WatchResponseResult.Continue:
                            break;
                        case WatchResponseResult.ResetStream:
                            await CloseStreamAsync().ConfigureAwait(false);
                            cause = StreamInitializationCause.ResetRequested;
                            break;
                        case WatchResponseResult.StreamHealthy:
                            nextBackoff = TimeSpan.Zero;
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown result type: {result}");
                    }
                    // What about other exception types?
                }
            }
            // Swallow cancellation exceptions unless one of the user-provided cancellation tokens has been
            // cancelled, in which case it's fine to let it through.
            catch (OperationCanceledException) when (!_callbackCancellationTokenSource.Token.IsCancellationRequested)
            {
                // We really do just swallow the exception. No need for logging.
            }
            finally
            {
                lock (_stateLock)
                {
                    _networkCancellationTokenSource.Dispose();
                    _callbackCancellationTokenSource.Dispose();
                    _stopCancellationTokenRegistration.Dispose();
                    _finished = true;
                }
                // Make sure we clean up even if we get an exception we don't handle explicitly.
                await CloseStreamAsync().ConfigureAwait(false);
            }


            // Local method responsible for fetching the next response from the server stream, including
            // stream initialization and error handling.
            async Task<ListenResponse> GetNextResponse()
            {
                while (true)
                {
                    try
                    {
                        // If we're just starting, or we've closed the stream or it broke, restart.
                        if (underlyingStream == null)
                        {
                            await _scheduler.Delay(_backoffJitter.GetDelay(nextBackoff), _networkCancellationTokenSource.Token).ConfigureAwait(false);
                            nextBackoff = _backoffSettings.NextDelay(nextBackoff);
                            underlyingStream = _db.Client.Listen(_listenCallSettings);
                            await underlyingStream.TryWriteAsync(CreateRequest(_state.ResumeToken)).ConfigureAwait(false);
                            _state.OnStreamInitialization(cause);
                        }
                        // Wait for a response or end-of-stream
                        var next = await underlyingStream.GrpcCall.ResponseStream.MoveNext(_networkCancellationTokenSource.Token).ConfigureAwait(false);

                        // If the server provided a response, return it
                        if (next)
                        {
                            return underlyingStream.GrpcCall.ResponseStream.Current;
                        }
                        // Otherwise, close the current stream and restart.
                        await CloseStreamAsync().ConfigureAwait(false);
                        cause = StreamInitializationCause.StreamCompleted;
                    }
                    catch (RpcException e) when (s_transientErrorStatusCodes.Contains(e.Status.StatusCode))
                    {
                        // Close the current stream, ready to create a new one.
                        await CloseStreamAsync().ConfigureAwait(false);
                        // Extend the back-off if necessary.
                        if (e.Status.StatusCode == StatusCode.ResourceExhausted)
                        {
                            nextBackoff = _backoffSettings.NextDelay(nextBackoff);
                        }
                        cause = StreamInitializationCause.RpcError;
                    }
                }
            }

            async Task CloseStreamAsync()
            {
                if (underlyingStream != null)
                {
                    try
                    {
                        var completeTask = underlyingStream.TryWriteCompleteAsync();
                        if (completeTask != null)
                        {
                            await completeTask.ConfigureAwait(false);
                        }
                    }
                    catch (RpcException)
                    {
                        // Swallow gRPC errors when trying to "complete" the stream. This may be in response to the network connection
                        // being dropped, at which point completing the stream will fail; we don't want the listener to stop at that
                        // point. Instead, it will reconnect.
                    }
                    underlyingStream.GrpcCall.Dispose();
                }
                underlyingStream = null;
            }
        }

        internal void Stop(CancellationToken userCancellationToken)
        {
            lock (_stateLock)
            {
                if (!_finished)
                {
                    if (userCancellationToken.CanBeCanceled)
                    {
                        _stopCancellationTokenRegistration = userCancellationToken.Register(() => _callbackCancellationTokenSource.Cancel());
                    }
                    _networkCancellationTokenSource.Cancel();
                }
            }
        }

        internal static Target CreateTarget(DocumentReference doc) =>
            new Target
            {
                Documents = new Target.Types.DocumentsTarget { Documents = { doc.Path } },
                TargetId = WatchTargetId
            };

        internal static Target CreateTarget(Query query) =>
            new Target
            {
                Query = new Target.Types.QueryTarget { Parent = query.ParentPath, StructuredQuery = query.ToStructuredQuery() },
                TargetId = WatchTargetId
            };

        // Visible for testing
        internal ListenRequest CreateRequest(ByteString resumeToken)
        {
            var request = new ListenRequest
            {
                AddTarget = _target.Clone(),
                Database = _db.RootPath
            };
            if (resumeToken != null)
            {
                request.AddTarget.ResumeToken = resumeToken;
            }
            return request;
        }
    }
}
