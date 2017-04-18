using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// 
    /// </summary>
    internal class SessionPool : IComparable
    {
        private readonly SessionPoolKey _key;
        private readonly ConcurrentStack<Session> _sessionMruStack = new ConcurrentStack<Session>();
        private int _lastAccessTime;

        private static int _activeSessionsPooled;
        private static ConcurrentDictionary<SessionPoolKey, SessionPool> GlobalPool { get; } =
            new ConcurrentDictionary<SessionPoolKey, SessionPool>();
        private static readonly object s_priorityListSync = new object();
        private static SortedList<SessionPool, SessionPool> PriorityList { get; }
            = new SortedList<SessionPool, SessionPool>();

        private SessionPool(SessionPoolKey key)
        {
            _key = key;
        }

        /// <summary>
        /// Creates a new session or acquired a warm session from the session pool.
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="endpoint"></param>
        /// <param name="project"></param>
        /// <param name="spannerInstance"></param>
        /// <param name="spannerDatabase"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Session> AcquireSessionAsync(ITokenAccess credential, ServiceEndpoint endpoint,
            string project, string spannerInstance, string spannerDatabase, CancellationToken cancellationToken)
        {
            project.ThrowIfNullOrEmpty(nameof(project));
            spannerInstance.ThrowIfNullOrEmpty(nameof(project));
            spannerDatabase.ThrowIfNullOrEmpty(nameof(project));
            SessionPool targetPool = GlobalPool.GetOrAdd(
                new SessionPoolKey {
                    Credential = credential,
                    ServiceEndpoint = endpoint,
                    Project = project,
                    Instance = spannerInstance,
                    Database = spannerDatabase},
                key => new SessionPool(key));

            var session = await targetPool.AcquireSessionAsync(cancellationToken);
            //refresh the mru list which tells us what sessions need to be trimmed from the pool when we want
            // to add another poolEntry.
            lock (s_priorityListSync)
            {
                PriorityList.Remove(targetPool);
                PriorityList.Add(targetPool, targetPool);
            }
            return session;
        }

        /// <summary>
        /// Releases a Session back into the pool when no longer needed.
        /// </summary>
        /// <param name="session"></param>
        public static async Task ReleaseSessionAsync(Session session)
        {
            session.ThrowIfNull(nameof(session));
            if (session.DatabaseName == null)
            {
                throw new InvalidOperationException("Released session was not created through the pool.");
            }

            SessionPool targetPool = GlobalPool.GetOrAdd(
                new SessionPoolKey {
                    Credential = session.AssociatedCredential,
                    ServiceEndpoint = session.AssociatedEndPoint,
                    Project = session.DatabaseName.ProjectId,
                    Instance = session.DatabaseName.InstanceId,
                    Database = session.DatabaseName.DatabaseId
                },
                key => new SessionPool(key));

            Session sessionToClose = null;
            //1. Figure out if we want to pool this released session.
            // true if either
            //  a) _activeSessionsPooled < MaxIdleSessionPoolSize
            //  b) _activeSessionsPooled >= MaxIdleSessionPoolSize && targetPool isn't top on PriorityList
            //     if this is true, we evict a session from PriorityList.Top() and pool this new session.
            lock (s_priorityListSync)
            {
                Debug.Assert(PriorityList.Count > 0);
                if (_activeSessionsPooled < MaxIdleSessionPoolSize)
                {
                    targetPool.ReleaseSessionToPool(session);
                    //re-sort the MRU (if it needs it).
                    if (PriorityList.Count > 1)
                    {
                        PriorityList.Remove(targetPool);
                        PriorityList.Add(targetPool, targetPool);
                    }
                }
                else if (PriorityList.First().Value != targetPool)
                {
                    sessionToClose = PriorityList.First().Value.AcquireSessionAsync(CancellationToken.None, false).Result;
                    Debug.Assert(sessionToClose != null);
                    targetPool.ReleaseSessionToPool(session);

                    //re-sort the MRU.
                    PriorityList.Remove(targetPool);
                    PriorityList.Remove(PriorityList.First().Value);
                    PriorityList.Add(targetPool, targetPool);
                    PriorityList.Add(PriorityList.First().Value, PriorityList.First().Value);
                }
                else
                {
                    sessionToClose = session;
                }
            }
            if (sessionToClose != null)
            {
                SessionName name = sessionToClose.SessionName;
                await sessionToClose.DisposeAsync();
                var client = await ClientPool.AcquireClientAsync(sessionToClose.AssociatedCredential, sessionToClose.AssociatedEndPoint);
                await client.DeleteSessionAsync(name);
            }
        }

        public static int MaxIdleSessionPoolSize { get; set; } = 10; //TODO, should 0 be default?

        public async Task<Session> AcquireSessionAsync(CancellationToken cancellationToken, bool forceAllocate = true)
        {
            Session session;
            if (!_sessionMruStack.TryPop(out session))
            {
                if (!forceAllocate)
                {
                    return null;
                }
                var client = await ClientPool.AcquireClientAsync(_key.Credential, _key.ServiceEndpoint);

                //create a new session, blocking or throwing if at the limit.
                session = await Session.CreateAsync(client, _key.Project, _key.Instance, _key.Database, cancellationToken);
                session.InitializePoolManagedSession(_key.Credential, _key.ServiceEndpoint);
            }
            else
            {
                Interlocked.Decrement(ref _activeSessionsPooled);
            }
            MarkUsed();
            return session;
        }

        private void MarkUsed()
        {
            _lastAccessTime = Environment.TickCount;
        }

        public void ReleaseSessionToPool(Session session)
        {
            _sessionMruStack.Push(session);
            Interlocked.Increment(ref _activeSessionsPooled);
        }

        public int CompareTo(object obj)
        {
            SessionPool other = obj as SessionPool;
            if (other == null)
            {
                return -1;
            }
            if (other._sessionMruStack.Count > _sessionMruStack.Count)
            {
                return 1;
            }
            if (other._sessionMruStack.Count < _sessionMruStack.Count)
            {
                return -1;
            }
            return _lastAccessTime.CompareTo(other._lastAccessTime);
        }
    }
}
