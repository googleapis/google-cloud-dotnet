using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;

namespace Google.Cloud.Spanner.V1
{
    public partial class Session : IDisposable
    {
        private readonly CancellationTokenSource _cancellation = new CancellationTokenSource();
        private Task _keepAlive;
        private int _lastAccessTime = Environment.TickCount;
        private ITokenAccess _credential;
        private ServiceEndpoint _endpoint;
        private static int _activeSessions;
        private static readonly object s_createSync = new object();

        internal void InitializePoolManagedSession(ITokenAccess credential, ServiceEndpoint endpoint)
        {
            _endpoint = endpoint;
            _credential = credential;
            _keepAlive = Task.Run(() => KeepAlive(new WeakReference<Session>(this), SessionName), _cancellation.Token);
        }

        internal ITokenAccess AssociatedCredential => _credential;
        internal ServiceEndpoint AssociatedEndPoint => _endpoint;

        private static bool TryGetCancellationToken(WeakReference<Session> thisReference, out CancellationTokenSource result)
        {
            Session strongRef;
            if (!thisReference.TryGetTarget(out strongRef))
            {
                result = null;
                return false;
            }
            result = strongRef._cancellation;
            return true;
        }
        private static bool TryGetLastAccesstime(WeakReference<Session> thisReference, out int result)
        {
            Session strongRef;
            if (!thisReference.TryGetTarget(out strongRef))
            {
                result = 0;
                return false;
            }
            result = strongRef._lastAccessTime;
            return true;
        }
        private static bool TryGetCredential(WeakReference<Session> thisReference, out ITokenAccess result)
        {
            Session strongRef;
            if (!thisReference.TryGetTarget(out strongRef))
            {
                result = null;
                return false;
            }
            result = strongRef._credential;
            return true;
        }
        private static bool TryGetEndPoint(WeakReference<Session> thisReference, out ServiceEndpoint result)
        {
            Session strongRef;
            if (!thisReference.TryGetTarget(out strongRef))
            {
                result = null;
                return false;
            }
            result = strongRef._endpoint;
            return true;
        }
        private static async Task KeepAlive(WeakReference<Session> thisSession, SessionName sessionName)
        {
            thisSession.ThrowIfNull(nameof(thisSession));
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = sessionName,
                Sql = "SELECT 1",
            };

            while (true)
            {
                CancellationTokenSource cancellationTokenSource;
                if (!TryGetCancellationToken(thisSession, out cancellationTokenSource))
                {
                    return;
                }

                int waitTime = Math.Min((int) KeepAliveIntervalMinutes.TotalMilliseconds, 60000);
                await Task.Delay(waitTime, cancellationTokenSource.Token);

                int lastAccessTime;
                if (!TryGetLastAccesstime(thisSession, out lastAccessTime))
                {
                    return;
                }
                int additionalWaitTime = unchecked (lastAccessTime + waitTime - Environment.TickCount);
                // If the session was used for any reason, waste not and wait again until idle time kicks in.
                while (additionalWaitTime > 0 && additionalWaitTime < waitTime)
                {
                    await Task.Delay(additionalWaitTime, cancellationTokenSource.Token);
                    if (!TryGetLastAccesstime(thisSession, out lastAccessTime))
                    {
                        return;
                    }
                    additionalWaitTime = unchecked(lastAccessTime + waitTime - Environment.TickCount);
                }

                // Send Idle Request here...
                ITokenAccess credential;
                ServiceEndpoint endpoint;
                if (!TryGetCredential(thisSession, out credential) || !TryGetEndPoint(thisSession, out endpoint))
                {
                    return;
                }
                var client = await ClientPool.AcquireClientAsync(credential, endpoint);
                try
                {
                    await client.ExecuteSqlAsync(request);
                }
                catch (Exception)
                {
                    //log it?
                    //check for transient errors?
                    return; //might need to recreate, but for now, we'll let the upper level recovery handle this issue.
                }
            }
        }

        internal void MarkUsed()
        {
            _lastAccessTime = Environment.TickCount;
        }

        internal SessionName GetSessionAndMark()
        {
            MarkUsed();
            return SessionName;
        }

        internal static int MaximumActiveSessions { get; set; } = int.MaxValue;

        /// <summary>
        /// 
        /// </summary>
        public static TimeSpan KeepAliveIntervalMinutes { get; set; } = TimeSpan.FromMinutes(30);

        /// <summary>
        /// 
        /// </summary>
        public static bool WaitOnResourcesExhausted { get; set; } = true;

        internal static async Task<Session> CreateAsync(SpannerClient client, string project, 
            string instance, string database, CancellationToken cancellationToken)
        {
            bool allocated = false;

            while (!allocated)
            {
                while (!Monitor.TryEnter(s_createSync))
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    //consider adding a small task delay here to avoid a spin locking too long.
                    await Task.Yield();
                }
                try
                {
                    if (_activeSessions < MaximumActiveSessions)
                    {
                        Interlocked.Increment(ref _activeSessions);
                        allocated = true;
                    }
                    else if (!WaitOnResourcesExhausted)
                    {
                        throw new InvalidOperationException("Resources Exhausted!");
                    }
                }
                finally
                {
                    Monitor.Exit(s_createSync);
                }
            }
            Session result = null;
            try
            {
                var databaseName = new DatabaseName(project, instance, database);
                result = await client.CreateSessionAsync(databaseName, cancellationToken);
                result.DatabaseName = databaseName;
            }
            finally
            {
                if (result == null)
                {
                    Interlocked.Decrement(ref _activeSessions);
                }
            }
            return result;
        }

        internal DatabaseName DatabaseName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        internal static int ActiveSessions => _activeSessions;

        internal async Task DisposeAsync()
        {
            if (_cancellation.IsCancellationRequested)
            {
                return;
            }
            _cancellation.Cancel();
            await _keepAlive;
            Interlocked.Decrement(ref _activeSessions);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                //TODO finalizer warning, recovery...
                DisposeAsync().Start();
                GC.SuppressFinalize(this);
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
        }

        /// <inheritdoc />
        ~Session()
        {
            Dispose(false);
        }
    }
}