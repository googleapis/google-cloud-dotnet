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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.V1
{
    internal class SessionPoolImpl : IPriorityListItem<SessionPoolImpl>
    {
        private readonly SessionPoolOptions _options;

        //This is the maximum we will search for a matching transaction option session.
        //We'll normally not hit this, but this is to stop abnormal cases where almost all
        //cached sessions are of one type, but another type is requested.
        private const int MaximumLinearSearchDepth = 50;

        private readonly List<SessionPoolEntry> _sessionMruStack = new List<SessionPoolEntry>();
        private readonly SemaphoreSlim _sessionCreateThrottle;
        private int _lastAccessTime;
        private static int s_activeSessionsPooled;

        public static int ActiveSessionsPooled => s_activeSessionsPooled;

        public SessionPoolKey Key { get; }

        private Logger Logger { get; } = Logger.DefaultLogger;

        internal SessionPoolImpl(SessionPoolKey key, SessionPoolOptions options)
        {
            _options = GaxPreconditions.CheckNotNull(options, nameof(options));
            _sessionCreateThrottle = new SemaphoreSlim(_options.MaximumConcurrentSessionCreates, _options.MaximumConcurrentSessionCreates);
            Key = key;
        }

        internal int DumpSessionPoolContents(StringBuilder stringBuilder)
        {
            lock (_sessionMruStack)
            {
                int i = 0;
                foreach (var entry in _sessionMruStack)
                {
                    stringBuilder.AppendLine($"  {i}:{entry.Session?.GetHashCode()}");
                    i++;
                }
                return _sessionMruStack.Count;
            }
        }

        internal int GetPoolSize()
        {
            lock (_sessionMruStack)
            {
                return _sessionMruStack.Count;
            }
        }

        internal Task ReleaseAllImpl()
        {
            SessionPoolEntry[] entries;
            lock (_sessionMruStack)
            {
                entries = _sessionMruStack.ToArray();
            }
            return Task.WhenAll(entries.Select(sessionpoolentry => EvictImmediatelyAsync(sessionpoolentry.Session, CancellationToken.None)).ToArray());
        }

        private Task EvictSessionPoolEntry(Session session, CancellationToken cancellationToken)
        {
            var task = Task.Delay(_options.PoolEvictionDelay, cancellationToken);
            return task.ContinueWith(async (delayTask, o) => 
            {
                Logger.Debug(() => "Evict timer triggered.");
                await EvictImmediatelyAsync(session, cancellationToken).ConfigureAwait(false);
            }, null, cancellationToken);
        }

        private void LogSessionsPooled()
        {
            Logger.LogPerformanceCounter("Session.PooledCount", () => s_activeSessionsPooled);
        }

        private async Task EvictImmediatelyAsync(Session session, CancellationToken cancellationToken)
        {
            Logger.Debug(() => "Evicting a session from the pool.");
            SessionPoolEntry entry = default;
            try
            {
                lock (_sessionMruStack)
                {
                    var found = _sessionMruStack.FindIndex(x => ReferenceEquals(x.Session, session));
                    if (found != -1)
                    {
                        entry = _sessionMruStack[found];
                        _sessionMruStack.RemoveAt(found);
                        Interlocked.Decrement(ref s_activeSessionsPooled);
                        LogSessionsPooled();
                    }
                }
            }
            finally
            {
                OnPriorityChanged();
            }
            if (entry.Session != null)
            {
                try
                {
                    await Key.Client.DeleteSessionAsync(entry.Session.GetSessionName(), cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    //The session delete is best effort, but we will log an error if needed
                    //Note that this error can happen if a test deletes it's database and a later test clears
                    //out the session pool.
                    Logger.Error(() => "Unable to delete a pooled session.", e);
                }
            }
        }

        private bool TryPop(TransactionOptions transactionOptions, out SessionPoolEntry entry)
        {
            try
            {
                //we make a reasonable attempt at obtaining a session with the given TransactionOptions.
                //but its not guaranteed.
                lock (_sessionMruStack)
                {
                    if (_sessionMruStack.Count > 0)
                    {
                        Logger.Debug(() => "Searching for a session with matching transaction semantics.");
                        int indexToUse = -1;
                        for (int i = 0;
                            i < _sessionMruStack.Count && i < MaximumLinearSearchDepth;
                            i++)
                        {
                            entry = _sessionMruStack[i];
                            if (Equals(entry.Session.GetLastUsedTransactionOptions(), transactionOptions))
                            {
                                Logger.Debug(() => "found a session with matching transaction semantics.");
                                indexToUse = i;
                                if (transactionOptions?.ModeCase != TransactionOptions.ModeOneofCase.ReadWrite
                                    || entry.Session.IsPreWarmedTransactionReady())
                                {
                                    //if our prewarmed tx is ready, we can jump out immediately.
                                    break;
                                }
                            }
                        }
                        if (indexToUse == -1)
                        {
                            Logger.Debug(
                                () => "did not find a session with matching transaction semantics - popping at top.");
                            indexToUse = 0;
                        }
                        entry = _sessionMruStack[indexToUse];
                        _sessionMruStack.RemoveAt(indexToUse);

                        Interlocked.Decrement(ref s_activeSessionsPooled);
                        LogSessionsPooled();
                        return true;
                    }
                }
                entry = default;
                return false;
            }
            finally
            {
                OnPriorityChanged();
            }
        }

        private void Push(SessionPoolEntry entry)
        {
            try
            {
                lock (_sessionMruStack)
                {
                    _sessionMruStack.Insert(0, entry);
                    Interlocked.Increment(ref s_activeSessionsPooled);
                    LogSessionsPooled();
                }
            }
            finally
            {
                OnPriorityChanged();
            }
        }

        public async Task<Session> AcquireSessionAsync(TransactionOptions options, CancellationToken cancellationToken)
        {
            Logger.Debug(() => "Attempting to acquire a session from the pool.");
            SessionPoolEntry sessionEntry;
            if (!TryPop(options, out sessionEntry))
            {
                //create a new session, blocking or throwing if at the limit.
                await _sessionCreateThrottle.WaitAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    // Try to pop a session again after acquiring a throttle semaphore.
                    // we may have waited for quite a while and the pool may now have entries.
                    if (!TryPop(options, out sessionEntry))
                    {
                        Logger.Debug(
                            () => "Attempting to acquire a session from the pool failed - creating a new instance.");
                        Stopwatch sw = null;
                        if (Logger.LogPerformanceTraces)
                        {
                            sw = new Stopwatch();
                            sw.Start();
                        }

                        var result = await Key.Client.CreateSessionAsync(
                                new DatabaseName(Key.Project, Key.Instance, Key.Database), cancellationToken)
                            .ConfigureAwait(false);
                        if (sw != null)
                        {
                            Logger.LogPerformanceCounterFn("Session.CreateTime", x => sw.ElapsedMilliseconds);
                        }
                        return result;
                    }
                }
                finally
                {
                    _sessionCreateThrottle.Release();
                }
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
            try
            {
                SessionPoolEntry sessionEntry = default;
                lock (_sessionMruStack)
                {
                    if (_sessionMruStack.Count > 0)
                    {
                        sessionEntry = _sessionMruStack[_sessionMruStack.Count - 1];
                        _sessionMruStack.RemoveAt(_sessionMruStack.Count - 1);
                        Interlocked.Decrement(ref s_activeSessionsPooled);
                        LogSessionsPooled();
                    }
                }
                if (sessionEntry.Session == null || sessionEntry.EvictTaskCancellationSource == null)
                {
                    return null;
                }
                sessionEntry.EvictTaskCancellationSource.Cancel();
                return sessionEntry.Session;
            }
            finally
            {
                OnPriorityChanged();
            }
        }

        private void MarkUsed()
        {
            _lastAccessTime = Environment.TickCount;
            OnPriorityChanged();
        }

        public void ReleaseSessionToPool(SpannerClient client, Session session)
        {
            Logger.Debug(() => "Placing session back into the pool and starting the evict timer.");
            //start evict timer.
            SessionPoolEntry entry = new SessionPoolEntry(session, new CancellationTokenSource());

            if (_options.UseTransactionWarming)
            {
                client.StartPreWarmTransaction(entry.Session);
            }
            //kick off the pool eviction timer.  This gets canceled when the item is pulled from the pool.
            Task.Run(() => EvictSessionPoolEntry(entry.Session, entry.EvictTaskCancellationSource.Token),
                entry.EvictTaskCancellationSource.Token);

            //It's very important that before we allow the new session to be in the pool
            //that the state of the session is such that it can be immediately consumed.
            Push(entry);
        }

        public int CompareTo(SessionPoolImpl other)
        {
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

        private void OnPriorityChanged()
        {
            PriorityChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <inheritdoc />
        public event EventHandler<EventArgs> PriorityChanged;
    }
}
