using System;
using Google.Api.Gax.Grpc;
using Grpc.Core;

// ReSharper disable EmptyDestructor

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Provides streaming access to a Spanner SQL query that automatically retries, handles
    /// chunking and recoverable errors.
    /// </summary>
    internal sealed class ReliableStreamReader : IDisposable
    {
        //WIP: add actual stream reads, retries, etc.
        private readonly AsyncServerStreamingCall<PartialResultSet> _currentCall;
        private readonly object _sync = new object();
        private SpannerClient _spannerClient;
        private ExecuteSqlRequest _request;
        private readonly Session _session;
        private CallSettings _callSettings;

        internal ReliableStreamReader(SpannerClient spannerClientImpl, ExecuteSqlRequest request, Session session)
        {
            _spannerClient = spannerClientImpl;
            _request = request;
            _session = session;
            _callSettings = null;

            _request.SessionAsSessionName = _session.SessionName;
            _currentCall = _spannerClient.ExecuteSqlStream(_request, _callSettings);
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

        /// <inheritdoc />
        ~ReliableStreamReader()
        {
            //Log Warning about leaked session.
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class StreamClosedEventArgs : EventArgs
    {
    }
}
