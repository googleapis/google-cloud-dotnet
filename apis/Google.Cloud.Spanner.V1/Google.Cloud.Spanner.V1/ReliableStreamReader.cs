// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Google.Api.Gax.Grpc;

// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable NotAccessedField.Local
// ReSharper disable EmptyDestructor

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    ///     Provides streaming access to a Spanner SQL query that automatically retries, handles
    ///     chunking and recoverable errors.
    /// </summary>
    public sealed class ReliableStreamReader : IDisposable
    {
        private AsyncServerStreamingCall<PartialResultSet> _currentCall;
        private readonly SpannerClient _spannerClient;
        private readonly IClock _clock;
        private readonly ExecuteSqlRequest _request;
        private readonly IScheduler _scheduler;
        private readonly Session _session;
        private readonly int _timeoutSeconds;

        private int _nextIndex;
        private bool _isReading = true;
        private ResultSetMetadata _metadata;
        private int _resumeSkipCount;
        private ByteString _resumeToken;

        internal ReliableStreamReader(
            SpannerClient spannerClient,
            ExecuteSqlRequest request,
            Session session,
            int timeoutSeconds)
        {
            _spannerClient = spannerClient;
            _request = request;
            _session = session;
            _timeoutSeconds = timeoutSeconds;
            _clock = SpannerSettings.GetDefault().Clock ?? SystemClock.Instance;
            _scheduler = SpannerSettings.GetDefault().Scheduler ?? SystemScheduler.Instance;

            _request.SessionAsSessionName = _session.SessionName;
        }

        /// <summary>
        /// This property is intended for internal use only.
        /// </summary>
        public Logger Logger { get; set; } = Logger.DefaultLogger;

        /// <summary>
        /// </summary>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// </summary>
        public Session Session => _session;

        /// <inheritdoc />
        public void Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        private Task<Metadata> ConnectAsync()
        {
            Logger.LogPerformanceCounterFn("StreamReader.ConnectCount", x => x + 1);
            if (_resumeToken != null)
            {
                Logger.Debug(() => $"Resuming at location:{_resumeToken}");
                _request.ResumeToken = _resumeToken;
            }

            _currentCall = _spannerClient.ExecuteSqlStream(_request,
                _spannerClient.Settings.ExecuteSqlStreamSettings.WithExpiration(
                    _spannerClient.Settings.ConvertTimeoutToExpiration(_timeoutSeconds)));
            return WithTiming(_currentCall.ResponseHeadersAsync.WithSessionChecking(() => _session), "ResponseHeaders");
        }

        /// <summary>
        /// This helper ensures we invalidate the _currentCall state if we want to throw canceled.
        /// </summary>
        private void ThrowIfCancellationRequested(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                _currentCall?.Dispose();
                _currentCall = null;
                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        /// <summary>
        ///     Connects or reconnects to Spanner, fast forwarding to where we left off based on
        ///     our _resumeToken and _resumeSkipCount.
        /// </summary>
        /// <returns></returns>
        private async Task<bool> ReliableConnectAsync(CancellationToken cancellationToken)
        {
            if (_currentCall == null)
            {
                await WithTiming(ConnectAsync(), "ConnectAsync").ConfigureAwait(false);
                Debug.Assert(_currentCall != null, "_currentCall != null");

                for (int i = 0; i <= _resumeSkipCount; i++)
                {
                    ThrowIfCancellationRequested(cancellationToken);

                    _isReading = await WithTiming(
                            _currentCall.ResponseStream.MoveNext(cancellationToken)
                                .WithSessionChecking(() => _session),
                            "ResponseStream.MoveNext")
                        .ConfigureAwait(false);
                    if (!_isReading || _currentCall.ResponseStream.Current == null)
                    {
                        return false;
                    }
                    if (_metadata == null)
                    {
                        _metadata = _currentCall.ResponseStream.Current.Metadata;
                    }
                }
                RecordResumeToken();
            }

            return _isReading;
        }

        private static async Task<T> WithTiming<T>(Task<T> task, string name)
        {
            Stopwatch sw = null;
            if (Logger.DefaultLogger.LogPerformanceTraces)
            {
                sw = Stopwatch.StartNew();
            }

            var result = await task.ConfigureAwait(false);
            if (sw != null)
            {
                Logger.DefaultLogger.LogPerformanceCounterFn($"{name}.Duration", x => sw.ElapsedMilliseconds);
            }
            return result;
        }

        private async Task<bool> ReliableMoveNextAsync(CancellationToken cancellationToken)
        {
            try
            {
                Logger.LogPerformanceCounterFn("StreamReader.MoveNextCount", x => x + 1);
                _isReading = await _currentCall.ResponseStream.MoveNext(cancellationToken)
                    .WithSessionChecking(() => _session).ConfigureAwait(false);

                //we only increment our skip count after we know the MoveNext has succeeded
                _resumeSkipCount++;
            }
            catch (Exception e)
            {
                // execution here means the movenext failed and _resumeSkipCount has not yet been increased.
                await TryRecoverOnFailureAsync(cancellationToken, e).ConfigureAwait(false);
            }
            RecordResumeToken();
            return _isReading;
        }

        private async Task TryRecoverOnFailureAsync(CancellationToken cancellationToken, Exception exception)
        {
            _currentCall?.Dispose();
            _currentCall = null;

            //reconnect on failure which will call reliableconnect and respect resumetoken and resumeskip
            cancellationToken.ThrowIfCancellationRequested();

            Logger.Warn(
                () =>
                    $"An error occurred attemping to iterate through the sql query.  Attempting to recover. Exception:{exception}");

            //when we reconnect, we purposely do not do a *reliable*movenext.  If we fail to fast forward on the reconnect
            //we bail out completely and surface the error.
            _isReading = await ReliableConnectAsync(cancellationToken).ConfigureAwait(false);
            if (_isReading)
            {
                // we try one more time to advance. Note that we should have done an exponential backoff retry
                // on the initial connect -- but MoveNext is not idempotent, so all we can do if it fails is start
                // from scratch.  But in case something is going horribly awry, we don't want to spin indefinitely,
                // so we bail if the recovery isn't successful in moving to the next item.
                try
                {
                    _isReading = await _currentCall.ResponseStream.MoveNext(cancellationToken)
                        .WithSessionChecking(() => _session).ConfigureAwait(false);
                    _resumeSkipCount++;
                }
                catch (Exception e)
                {
                    Logger.Warn(() => $"An error occurred attemping to recover. Exception:{e}");
                    //At this point, we give up, rethrowing and setting state such that it will
                    //need to reconnect if the user calls MoveNext again.
                    _currentCall?.Dispose();
                    _currentCall = null;
                    throw;
                }
            }
        }

        private void RecordResumeToken()
        {
            if (_isReading && (_currentCall != null))
            {
                //record resume information.
                if (_currentCall.ResponseStream.Current.ResumeToken != null)
                {
                    _resumeToken = _currentCall.ResponseStream.Current.ResumeToken;
                    _resumeSkipCount = 0;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ResultSetMetadata> GetMetadataAsync(CancellationToken cancellationToken)
        {
            await ReliableConnectAsync(cancellationToken).ConfigureAwait(false);
            return _metadata;
        }

        /// <summary>
        /// </summary>
        public void Close()
        {
            if (IsClosed)
            {
                return;
            }
            IsClosed = true;
            _currentCall?.Dispose();
            StreamClosed?.Invoke(this, new StreamClosedEventArgs());
        }

        /// <summary>
        /// </summary>
        public event EventHandler<StreamClosedEventArgs> StreamClosed;

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<bool> HasDataAsync(CancellationToken cancellationToken) => ReliableConnectAsync(cancellationToken);

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Value> NextAsync(CancellationToken cancellationToken)
        {
            Value result = await NextChunkAsync(cancellationToken).ConfigureAwait(false);
            while ((result != null)
                   && _currentCall.ResponseStream.Current.ChunkedValue
                   && (_nextIndex >= _currentCall.ResponseStream.Current.Values.Count))
            {
                result.ChunkedMerge(await NextChunkAsync(cancellationToken).ConfigureAwait(false));
            }
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Value> NextChunkAsync(CancellationToken cancellationToken)
        {
            if (!await HasDataAsync(cancellationToken).ConfigureAwait(false))
            {
                return null;
            }
            if (_nextIndex >= _currentCall.ResponseStream.Current.Values.Count)
            {
                //we need to move next
                _isReading = await ReliableMoveNextAsync(cancellationToken).ConfigureAwait(false);
                _nextIndex = 0;
                if (!_isReading)
                {
                    return null;
                }
            }
            var result = _currentCall.ResponseStream.Current.Values[_nextIndex];

            _nextIndex++;
            return result;
        }

        /// <inheritdoc />
        ~ReliableStreamReader()
        {
            //If our finalizer runs, it means we were not disposed properly.
            Logger.Warn(() => "ReliableStreamReader was not disposed of properly.  A Session may have been leaked.");
        }
    }

    /// <summary>
    /// </summary>
    public sealed class StreamClosedEventArgs : EventArgs
    {
    }
}