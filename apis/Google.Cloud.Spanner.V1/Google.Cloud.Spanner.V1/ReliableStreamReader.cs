using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable NotAccessedField.Local
// ReSharper disable EmptyDestructor

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Provides streaming access to a Spanner SQL query that automatically retries, handles
    /// chunking and recoverable errors.
    /// </summary>
    public sealed class ReliableStreamReader : IDisposable
    {
        //WIP: add actual stream reads, retries, etc.
        private AsyncServerStreamingCall<PartialResultSet> _currentCall;
        private readonly object _sync = new object();
        private readonly SpannerClient _spannerClient;
        private readonly ExecuteSqlRequest _request;
        private readonly Session _session;
        private readonly CallSettings _callSettings;
        private ResultSetMetadata _metadata;
        private bool _isReading = true;

        internal ReliableStreamReader(SpannerClient spannerClientImpl, ExecuteSqlRequest request, Session session)
        {
            _spannerClient = spannerClientImpl;
            _request = request;
            _session = session;
            _callSettings = null;

            _request.SessionAsSessionName = _session.SessionName;
        }

        /// <summary>
        /// Ensures we have executed the query initially or from recovery and have read the initial metadata
        /// </summary>
        /// <returns></returns>
        private async Task<bool> StartReadingAsync(CancellationToken cancellationToken)
        {
            if (_currentCall == null)
            {
                _currentCall = _spannerClient.ExecuteSqlStream(_request, _callSettings);
                _isReading = await _currentCall.ResponseStream.MoveNext(CancellationToken.None);
                if (!_isReading)
                {
                    return false;
                }
                if (_currentCall.ResponseStream.Current == null)
                {
                    throw new InvalidOperationException("stream read error!");
                }
                _metadata = _currentCall.ResponseStream.Current.Metadata;
            }
            return _isReading;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ResultSetMetadata> GetMetadataAsync(CancellationToken cancellationToken)
        {
            await StartReadingAsync(cancellationToken);
            return _metadata;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsClosed { get; private set; }

        /// <summary>
        /// 
        /// 
        /// </summary>
        public void Close()
        {
            lock (_sync)
            {
                if (IsClosed)
                {
                    return;
                }
                IsClosed = true;
            }
            StreamClosed?.Invoke(this, new StreamClosedEventArgs());
        }

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<StreamClosedEventArgs> StreamClosed;

        void IDisposable.Dispose()
        {
            Close();
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<bool> HasData(CancellationToken cancellationToken)
        {
            return await StartReadingAsync(cancellationToken);
        }


        private int _currentIndex;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Value> Next(CancellationToken cancellationToken)
        {
            if (!await HasData(cancellationToken))
            {
                return null;
            }
            if (_currentIndex >= _currentCall.ResponseStream.Current.Values.Count)
            {
                //we need to move next
                _isReading = await _currentCall.ResponseStream.MoveNext(CancellationToken.None);
                _currentIndex = 0;
                if (!_isReading)
                {
                    return null;
                }
            }
            var result = _currentCall.ResponseStream.Current.Values[_currentIndex];
            _currentIndex++;
            return result;
        }

        /// <inheritdoc />
        ~ReliableStreamReader()
        {
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class StreamClosedEventArgs : EventArgs
    {
    }
}
