#region

using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Logging;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

#endregion

// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable NotAccessedField.Local
// ReSharper disable EmptyDestructor

namespace Google.Cloud.Spanner.V1 {
    /// <summary>
    ///     Provides streaming access to a Spanner SQL query that automatically retries, handles
    ///     chunking and recoverable errors.
    /// </summary>
    internal sealed class ReliableStreamReader : IDisposable
    {
        private AsyncServerStreamingCall<PartialResultSet> _currentCall;
        private readonly object _sync = new object();
        private readonly SpannerClient _spannerClient;
        private readonly IClock _clock;
        private readonly ExecuteSqlRequest _request;
        private readonly IScheduler _scheduler;
        private readonly Session _session;


        private int _nextIndex;
        private bool _isReading = true;
        private ResultSetMetadata _metadata;
        private int _resumeSkipCount;
        private ByteString _resumeToken;

        internal ReliableStreamReader(SpannerClient spannerClient,
            ExecuteSqlRequest request,
            Session session) {
            _spannerClient = spannerClient;
            _request = request;
            _session = session;
            _clock = SpannerSettings.GetDefault().Clock ?? SystemClock.Instance;
            _scheduler = SpannerSettings.GetDefault().Scheduler ?? SystemScheduler.Instance;

            _request.SessionAsSessionName = _session.SessionName;
        }

        /// <summary>
        /// </summary>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// </summary>
        public Session Session => _session;

        void IDisposable.Dispose() {
            Close();
            GC.SuppressFinalize(this);
        }

        private  Task<Metadata> ConnectAsync() {
            Logger.LogPerformanceCounterFn("StreamReader.ConnectCount", x => x + 1);
            if (_resumeToken != null) {
                Logger.Debug(() => $"Resuming at location:{_resumeToken}");
                _request.ResumeToken = _resumeToken;
            }
            _currentCall = _spannerClient.ExecuteSqlStream(_request);
            return _currentCall.ResponseHeadersAsync.WithSessionChecking(() => _session);
        }

        /// <summary>
        ///     Connects or reconnects to Spanner, fast forwarding to where we left off based on
        ///     our _resumeToken and _resumeSkipCount.
        /// </summary>
        /// <returns></returns>
        private async Task<bool> ReliableConnectAsync(CancellationToken cancellationToken) {
            if (_currentCall == null) {
                await ConnectAsync().ConfigureAwait(false);

                Debug.Assert(_currentCall != null, "_currentCall != null");
                cancellationToken.ThrowIfCancellationRequested();

                for (int i = 0; i <= _resumeSkipCount; i++) {
                    //This calls a simple movenext on purpose.  If we get an error here, we'll fail out.
                    _isReading = await _currentCall.ResponseStream.MoveNext(cancellationToken).WithSessionChecking(() => _session).ConfigureAwait(false);
                    if (!_isReading || _currentCall.ResponseStream.Current == null)
                    {
                        return false;
                    }
                    if (_metadata == null) {
                        _metadata = _currentCall.ResponseStream.Current.Metadata;
                    }
                }
                RecordResumeToken();
            }
            return _isReading;
        }

        private async Task<bool> ReliableMoveNextAsync(CancellationToken cancellationToken) {
            try {
                Logger.LogPerformanceCounterFn("StreamReader.MoveNextCount", x => x + 1);
                //we increment our skip count before calling MoveNext so that a reconnect operation
                //will fast forward to the proper place.
                _resumeSkipCount++;
                _isReading = await _currentCall.ResponseStream.MoveNext(cancellationToken)
                    .WithSessionChecking(() => _session).ConfigureAwait(false);
            }
            catch (Exception e) 
            {
                _currentCall = null;

                //reconnect on failure which will call reliableconnect and respect resumetoken and resumeskip
                cancellationToken.ThrowIfCancellationRequested();

                Logger.Warn(
                    () =>
                            $"An error occurred attemping to iterate through the sql query.  Attempting to recover. Exception:{e}");

                //when we reconnect, we purposely do not do a *reliable*movenext.  If we fail to fast forward on the reconnect
                //we bail out completely and surface the error.
                return await ReliableConnectAsync(cancellationToken).ConfigureAwait(false);
            }
            RecordResumeToken();
            return _isReading;
        }

        private void RecordResumeToken() {
            if (_isReading && (_currentCall != null)) {
                //record resume information.
                if (_currentCall.ResponseStream.Current.ResumeToken != null) {
                    _resumeToken = _currentCall.ResponseStream.Current.ResumeToken;
                    _resumeSkipCount = 0;
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ResultSetMetadata> GetMetadataAsync(CancellationToken cancellationToken) {
            await ReliableConnectAsync(cancellationToken).ConfigureAwait(false);
            return _metadata;
        }

        /// <summary>
        /// </summary>
        public void Close() {
            if (IsClosed) {
                return;
            }
            IsClosed = true;
            StreamClosed?.Invoke(this, new StreamClosedEventArgs());
        }

        /// <summary>
        /// </summary>
        public event EventHandler<StreamClosedEventArgs> StreamClosed;

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> HasDataAsync(CancellationToken cancellationToken) {
            return await ReliableConnectAsync(cancellationToken);
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Value> NextAsync(CancellationToken cancellationToken) {
            Value result = await NextChunkAsync(cancellationToken).ConfigureAwait(false);
            while ((result != null)
                   && _currentCall.ResponseStream.Current.ChunkedValue
                   && (_nextIndex >= _currentCall.ResponseStream.Current.Values.Count)) {
                result.ChunkedMerge(await NextChunkAsync(cancellationToken));
            }
            return result;
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Value> NextChunkAsync(CancellationToken cancellationToken) {
            if (!await HasDataAsync(cancellationToken).ConfigureAwait(false)) {
                return null;
            }
            if (_nextIndex >= _currentCall.ResponseStream.Current.Values.Count) {
                //we need to move next
                _isReading = await ReliableMoveNextAsync(cancellationToken);
                _nextIndex = 0;
                if (!_isReading) {
                    return null;
                }
            }
            var result = _currentCall.ResponseStream.Current.Values[_nextIndex];

            _nextIndex++;
            return result;
        }

        /// <inheritdoc />
        ~ReliableStreamReader() {
            //If our finalizer runs, it means we were not disposed properly.
            Logger.Warn(() => "ReliableStreamReader was not disposed of properly.  A Session may have been leaked.");
        }
    }

    /// <summary>
    /// </summary>
    public sealed class StreamClosedEventArgs : EventArgs {
    }
}