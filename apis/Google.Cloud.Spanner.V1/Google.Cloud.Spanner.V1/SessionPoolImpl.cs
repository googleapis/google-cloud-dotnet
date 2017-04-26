using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1
{
    internal class SessionPoolImpl : IComparable
    {
        private readonly List<SessionPoolEntry> _sessionMruStack = new List<SessionPoolEntry>();
        private int _lastAccessTime;

        private static int s_activeSessionsPooled;


        public static int ActiveSessionsPooled => s_activeSessionsPooled;

        public SessionPoolKey Key { get; }

        internal SessionPoolImpl(SessionPoolKey key)
        {
            Key = key;
        }


        internal async Task ReleaseAllImpl()
        {
            SessionPoolEntry[] entries;
            lock (_sessionMruStack)
            {
                entries = _sessionMruStack.ToArray();
            }
            await Task.WhenAll(entries.Select(sessionpoolentry => EvictImmediately(sessionpoolentry.Session, CancellationToken.None)).ToArray());
        }

        private Task EvictSessionPoolEntry(Session session, CancellationToken cancellationToken)
        {
            var task = Task.Delay(SessionPool.PoolEvictTimeSpan, cancellationToken);
            return task.ContinueWith(async (delayTask, o) => 
            {
                await EvictImmediately(session, cancellationToken);
            }, null, cancellationToken);
        }

        private async Task EvictImmediately(Session session, CancellationToken cancellationToken)
        {
            SessionPoolEntry entry = default(SessionPoolEntry);
            lock (_sessionMruStack)
            {
                var found = _sessionMruStack.FindIndex(x => ReferenceEquals(x.Session, session));
                if (found != -1)
                {
                    entry = _sessionMruStack[found];
                    _sessionMruStack.RemoveAt(found);
                    Interlocked.Decrement(ref s_activeSessionsPooled);
                }
            }
            if (entry.Session != null)
            {
                await Key.Client.DeleteSessionAsync(entry.Session.SessionName, cancellationToken);
            }
        }

        private bool TryPop(out SessionPoolEntry entry)
        {
            lock (_sessionMruStack)
            {
                if (_sessionMruStack.Count > 0)
                {
                    entry = _sessionMruStack[0];
                    _sessionMruStack.RemoveAt(0);
                    Interlocked.Decrement(ref s_activeSessionsPooled);
                    return true;
                }
            }
            entry = default(SessionPoolEntry);
            return false;
        }

        private void Push(SessionPoolEntry entry)
        {
            lock (_sessionMruStack)
            {
                _sessionMruStack.Insert(0, entry);
                Interlocked.Increment(ref s_activeSessionsPooled);
            }
        }

        public async Task<Session> AcquireSessionAsync(CancellationToken cancellationToken)
        {
            SessionPoolEntry sessionEntry;
            if (!TryPop(out sessionEntry))
            {
                //create a new session, blocking or throwing if at the limit.
                return await Key.Client.CreateSessionAsync(new DatabaseName(Key.Project, Key.Instance, Key.Database), cancellationToken);
            }
            MarkUsed();
            //note that the evict task will only actually delete the session if it was able to remove it from the pool.
            //at this point, this is not possible because we removed it from the pool, so even if the task completes (which
            // is possible due to a race), it will see that the session isn't pooled and cancel out.
            sessionEntry.EvictTaskCancellationSource.Cancel();
            return sessionEntry.Session;
        }

        public Session AcquireEvictionCandidate()
        {
            SessionPoolEntry sessionEntry = default(SessionPoolEntry);
            lock (_sessionMruStack)
            {
                if (_sessionMruStack.Count > 0)
                {
                    sessionEntry = _sessionMruStack[_sessionMruStack.Count - 1];
                    _sessionMruStack.RemoveAt(_sessionMruStack.Count - 1);
                    Interlocked.Decrement(ref s_activeSessionsPooled);
                }
            }
            if (sessionEntry.Session == null || sessionEntry.EvictTaskCancellationSource == null)
            {
                return null;
            }
            sessionEntry.EvictTaskCancellationSource.Cancel();
            return sessionEntry.Session;
        }

        private void MarkUsed()
        {
            _lastAccessTime = Environment.TickCount;
        }

        public void ReleaseSessionToPool(Session session)
        {
            //start evict timer.
            SessionPoolEntry entry = new SessionPoolEntry {
                Session = session,
                EvictTaskCancellationSource = new CancellationTokenSource()
            };

            Push(entry);
            //kick off the pool eviction timer.  This gets canceled when the item is pulled from the pool.
            Task.Run(() => EvictSessionPoolEntry(entry.Session, entry.EvictTaskCancellationSource.Token),
                entry.EvictTaskCancellationSource.Token);
        }

        public int CompareTo(object obj)
        {
            SessionPoolImpl other = obj as SessionPoolImpl;
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
