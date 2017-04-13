using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;

namespace Google.Cloud.Spanner.V1
{
    public partial class Session : IDisposable
    {
        private readonly CancellationTokenSource _cancellation = new CancellationTokenSource();
        private Task _keepAlive;
        private int _lastAccessTime = Environment.TickCount;
        private ITokenAccess _credential;
        private static int _activeSessions;
        private static readonly object CreateSync = new object();

        internal void InitializePoolManagedSession(ITokenAccess credential)
        {
            _credential = credential;
            _keepAlive = Task.Run(KeepAlive, _cancellation.Token);
        }

        internal ITokenAccess AssociatedCredential => _credential;

        private async Task KeepAlive()
        {
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = SessionName,
                Sql = "SELECT 1",
            };

            while (true)
            {
                await Task.Delay(Math.Min(KeepAliveIntervalMinutes * 60000, 60000),
                    _cancellation.Token);
                if (_cancellation.IsCancellationRequested)
                {
                    return;
                }
                int additionalWaitTime = _lastAccessTime + KeepAliveIntervalMinutes * 60000 -
                                         Environment.TickCount;
                // If the session was used for any reason, waste not and wait again until idle time kicks in.
                while (additionalWaitTime > 0)
                {
                    await Task.Delay(additionalWaitTime, _cancellation.Token);
                    if (_cancellation.IsCancellationRequested)
                    {
                        return;
                    }
                    additionalWaitTime = _lastAccessTime + KeepAliveIntervalMinutes * 60000 -
                                         Environment.TickCount;
                }

                // Send Idle Request here...
                var client = await ClientPool.AcquireClientAsync(_credential);
                try
                {
                    await client.ExecuteSqlAsync(request);
                }
                catch (Exception)
                {
                    //log it?
                    //check for transient errors?
                    return; //might need to recreate
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
        public static int KeepAliveIntervalMinutes { get; set; } = 30;

        /// <summary>
        /// 
        /// </summary>
        public static bool WaitOnResourcesExhausted { get; set; } = true;

        internal static async Task<Session> CreateAsync(SpannerClient client, string datasource)
        {
            string[] parts = datasource.Split('/');
            if (parts == null || parts.Length != 3)
            {
                throw new InvalidOperationException("invalid datasource format " + datasource);
            }
            bool allocated = false;

            while (!allocated)
            {
                while (!Monitor.TryEnter(CreateSync))
                {
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
                    Monitor.Exit(CreateSync);
                }
            }
            Session result = null;
            try
            {
                result = await client.CreateSessionAsync(new DatabaseName(parts[0], parts[1], parts[2]));
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
            DisposeAsync().Start();
            if (disposing)
            {
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