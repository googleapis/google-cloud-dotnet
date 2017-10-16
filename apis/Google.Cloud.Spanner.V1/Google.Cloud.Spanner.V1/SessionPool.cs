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
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Apis.Util;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// The SessionPool is the preferred method of managing Spanner Sessions.
    /// It performs pooling of sessions with an evict timer along with configurable settings to control the maximum
    /// number of pooled and active sessions.
    /// To create a session using the sessionpool, use the extension method on SpannerClient.
    /// 
    ///     var session = await SpannerClient.CreateSessionFromPoolAsync(project, spannerInstance, database, cancellationtoken);
    ///     
    /// To release a session back to the sessionpool:
    /// 
    ///     session.ReleaseToPool();
    ///   
    /// If you use the SessionPool, you must make sure sessions are properly released back into the pool and are not simply GC'd.
    /// Allowing a session to GC will incur penalties on the current process as the session will count towards the maximum allowed
    /// and it will incur a penalty on other Spanner processes because it will be an hour before the server frees the session if 
    /// it's not properly deleted.
    /// </summary>
    public sealed class SessionPool : IDisposable
    {
        /// <summary>
        /// The default session pool, used in almost all cases other than testing.
        /// </summary>
        public static SessionPool Default { get; } = new SessionPool();

        private Logger Logger { get; } = Logger.DefaultLogger;

        internal TimeSpan ShutDownTimeout { get; } = TimeSpan.FromSeconds(60);

        // This member holds information we'll use when the session later gets released.
        private readonly ConcurrentDictionary<Session, SessionPoolKey> _sessionsInUse =
            new ConcurrentDictionary<Session, SessionPoolKey>();

        private int _sessionsCreating;
        private readonly ConcurrentQueue<TaskCompletionSource<int>> _waitQueue =
            new ConcurrentQueue<TaskCompletionSource<int>>();
        private readonly object _waitSync = new object();

        private readonly ConcurrentDictionary<SessionPoolKey, SessionPoolImpl>
            _poolByClientAndDatabase = new ConcurrentDictionary<SessionPoolKey, SessionPoolImpl>();
        private readonly PriorityList<SessionPoolImpl> _priorityList = new PriorityList<SessionPoolImpl>();

        private static readonly ConcurrentDictionary<string, bool> s_blackListedSessions = new ConcurrentDictionary<string, bool>();

        static SessionPool()
        {
            GrpcEnvironment.ShuttingDown += (o, e) => Default.Dispose();
        }

        // ReSharper disable once UnusedMember.Global
        // returns the maximum difference in size between the smallest and largest pool.
        // For test purposes only.
        // poolcontents will be filled with the contents of the pool and may not be null.
        internal int GetPoolInfo(StringBuilder poolContents)
        {
            GaxPreconditions.CheckNotNull(poolContents, nameof(poolContents));
            var maxSize = 0;
            var minSize = int.MaxValue;
            poolContents.AppendLine("SessionPool.Contents (by priority):");
            var i = 0;
            foreach (var priorityListEntry in _priorityList.GetSnapshot())
            {
                poolContents.AppendLine($"SessionPool({i}) Key:${priorityListEntry.Key}"
                    + $" HashCode_of_Pool:{priorityListEntry.GetHashCode()}");
                i++;
            }
            poolContents.AppendLine("SessionPool.Contents (by client):");
            var byClientIndex = 0;
            foreach (var byClientEntry in _poolByClientAndDatabase)
            {
                poolContents.AppendLine($"SessionPool({byClientIndex}) Key:${byClientEntry.Key}"
                    + $" HashCode_of_Pool:{byClientEntry.Value.GetHashCode()}");
                var size = byClientEntry.Value.DumpSessionPoolContents(poolContents);
                if (size > 0)
                {
                    minSize = Math.Min(size, minSize);
                    maxSize = Math.Max(size, maxSize);
                }
                byClientIndex++;
            }

            return maxSize - minSize;
        }

        private Task WhenCanceled(CancellationToken cancellationToken)
        {
            var tcs = new TaskCompletionSource<bool>();
            cancellationToken.Register(s => ((TaskCompletionSource<bool>) s).SetResult(true), tcs);
            return tcs.Task;
        }

        private async Task StartSessionCreatingAsync(CancellationToken cancellationToken)
        {
            TaskCompletionSource<int> signal = new TaskCompletionSource<int>();
            var cancellationTask = WhenCanceled(cancellationToken);

            lock (_waitSync)
            {
                //we check waitQ.IsEmpty to allow us to free a session slot and signal the Q
                //in two separate steps (outside of a sync lock) to remove the possibliity
                //that a race condition could cause fairness to suffer (like someone snuck in and
                //allocated a session jumping in front of folks waiting in the Q).
                if (CurrentActiveSessions < Options.MaximumActiveSessions
                    && _waitQueue.IsEmpty)
                {
                    _sessionsCreating++;
                    return;
                }
                if (!Options.WaitOnResourcesExhausted)
                {
                    throw new RpcException(new Status(StatusCode.ResourceExhausted,
                        "Number of available Sessions exhausted."));
                }
                //we force the current request to get in line so that allocation is fair.
                _waitQueue.Enqueue(signal);
            }
            //we need to block or throw because we are out of allocations.
            await Task.WhenAny(signal.Task, cancellationTask).ConfigureAwait(false);
            if (cancellationTask.IsCanceled)
            {
                if (signal.Task.IsCompleted)
                {
                    lock (_waitSync)
                    {
                        //if somehow we got canceled AND the task was signled, lets fix the counter.
                        _sessionsCreating--;
                        SignalAnyWaitingRequests();
                    }
                }
                cancellationToken.ThrowIfCancellationRequested();
            }
        }

        private void EndSessionCreating(Session sessionResult, SessionPoolKey sessionPoolKey)
        {
            lock (_waitSync)
            {
                if (sessionResult != null)
                {
                    _sessionsInUse.AddOrUpdate(sessionResult,
                        x => sessionPoolKey,
                        (x, y) => sessionPoolKey);
                }

                _sessionsCreating--;
                LogSessionsInUse();

                //signal more queue entries (in fair order) if we still have room.
                SignalAnyWaitingRequests();
            }
        }

        /// <summary>
        /// Marks a session as expired so that it will never be pooled in the sessionpool
        /// </summary>
        /// <param name="session"></param>
        public static void MarkSessionExpired(Session session)
        {
            if (session != null)
            {
                s_blackListedSessions.TryAdd(session.Name, true);
            }
        }

        /// <summary>
        /// Returns true if the given session has been marked as expired.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public bool IsSessionExpired(Session session)
        {
            bool unused;
            return session != null && s_blackListedSessions.TryGetValue(session.Name, out unused);
        }

        /// <summary>
        /// Allocates a session from the pool if possible, or creates a new Spanner Session.
        /// </summary>
        /// <param name="spannerClient"></param>
        /// <param name="project"></param>
        /// <param name="spannerInstance"></param>
        /// <param name="spannerDatabase"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<Session> CreateSessionFromPoolAsync(
            SpannerClient spannerClient,
            string project,
            string spannerInstance,
            string spannerDatabase,
            TransactionOptions options,
            CancellationToken cancellationToken)
        {
            project.ThrowIfNullOrEmpty(nameof(project));
            spannerInstance.ThrowIfNullOrEmpty(nameof(spannerInstance));
            spannerDatabase.ThrowIfNullOrEmpty(nameof(spannerDatabase));

            await StartSessionCreatingAsync(cancellationToken).ConfigureAwait(false);
            Session sessionResult = null;
            SessionPoolKey sessionPoolKey = default;
            try
            {
                sessionPoolKey = new SessionPoolKey(spannerClient,
                    project,
                    spannerInstance,
                    spannerDatabase);
                SessionPoolImpl targetPool = _poolByClientAndDatabase.GetOrAdd(sessionPoolKey,
                    key => new SessionPoolImpl(key, Options));

                sessionResult = await targetPool.AcquireSessionAsync(options, cancellationToken).ConfigureAwait(false);
                //refresh the mru list which tells us what sessions need to be trimmed from the pool when we want
                // to add another poolEntry.
                return sessionResult;
            } finally
            {
                EndSessionCreating(sessionResult, sessionPoolKey);
            }
        }

        internal int GetPoolSize(
            SpannerClient spannerClient,
            string project,
            string spannerInstance,
            string spannerDatabase)
        {
            project.ThrowIfNullOrEmpty(nameof(project));
            spannerInstance.ThrowIfNullOrEmpty(nameof(spannerInstance));
            spannerDatabase.ThrowIfNullOrEmpty(nameof(spannerDatabase));
            var sessionPoolKey = new SessionPoolKey(spannerClient,
                project,
                spannerInstance,
                spannerDatabase);
            SessionPoolImpl targetPool = _poolByClientAndDatabase.GetOrAdd(sessionPoolKey,
                key => new SessionPoolImpl(key, Options));

            return targetPool.GetPoolSize();
        }

        private void SignalAnyWaitingRequests()
        {
            lock (_waitSync)
            {
                TaskCompletionSource<int> waitingSessionRequest;
                //if anyone is waiting, let them query for their session.
                if (CurrentActiveSessions < Options.MaximumActiveSessions
                    && _waitQueue.TryDequeue(out waitingSessionRequest))
                {
                    _sessionsCreating++;
                    waitingSessionRequest.SetResult(0);
                }
            }
        }

        private void LogSessionsInUse()
        {
            Logger.LogPerformanceCounter("Session.ActiveCount", () => _sessionsInUse.Count);
        }

        /// <summary>
        /// Releases a session back into the pool, possibly causing another entry to be evicted if the maximum pool size has been
        /// reached.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="client"></param>
        /// <returns></returns>
        public void ReleaseToPool(SpannerClient client, Session session)
        {
            session.ThrowIfNull(nameof(session));

            SessionPoolKey poolKey;
            if (_sessionsInUse.TryRemove(session, out poolKey))
            {
                LogSessionsInUse();
                try
                {
                    if (IsSessionExpired(session))
                    {
                        bool unused;
                        s_blackListedSessions.TryRemove(session.Name, out unused);
                        return;
                    }
                    var targetPool = _poolByClientAndDatabase.GetOrAdd(
                        poolKey,
                        key => new SessionPoolImpl(key, Options));

                    //Figure out if we want to pool this released session.
                    targetPool.ReleaseSessionToPool(client, session);
                    _priorityList.Add(targetPool);
                    if (CurrentPooledSessions > Options.MaximumPooledSessions)
                    {
                        var evictionPool = _priorityList.GetTop();
                        var evictionClient = evictionPool?.Key.Client;
                        var evictionSession = evictionPool?.AcquireEvictionCandidate();
                        if (evictionSession != null)
                        {
                            Task.Run(() => EvictSessionAsync(evictionClient, evictionSession));
                        }
                    }
                }
                finally
                {
                    //signal to any blocked requestor that they *may* be able to allocate a session.
                    SignalAnyWaitingRequests();
                }
            }
            else
            {
                Logger.Error(
                    () =>
                        "An attempt was made to release a session to the pool,"
                        + " but the session was not originally allocated from the pool.");
            }
        }

        private async Task EvictSessionAsync(SpannerClient evictionClient,
            Session evictionSession)
        {
            await evictionSession.RemoveFromTransactionPoolAsync().ConfigureAwait(false);
            await evictionClient.DeleteSessionAsync(evictionSession.GetSessionName()).ConfigureAwait(false);
        }

        /// <summary>
        /// Called to close a session and release it without putting it back into the pool.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public async Task CloseAsync(Session session)
        {
            session.ThrowIfNull(nameof(session));

            SessionPoolKey result;
            if (_sessionsInUse.TryRemove(session, out result))
            {
                LogSessionsInUse();
                SignalAnyWaitingRequests();
                await result.Client.DeleteSessionAsync(session.GetSessionName()).ConfigureAwait(false);
                return;
            }
            throw new InvalidOperationException(
                "Close Session was not able to locate the provided session.");
        }

        /// <summary>
        /// Releases all pooled sessions and frees resources on the server.
        /// </summary>
        /// <returns></returns>
        public Task ReleaseAll()
        {
            var entries = _poolByClientAndDatabase.Values;
            _poolByClientAndDatabase.Clear();
                // ReleaseAll should not be called while other operations are starting.
            return Task.WhenAll(entries.Select(sessionpool => sessionpool.ReleaseAllImpl()));
        }

        /// <summary>
        /// The current number of active sessions in use by the application.
        /// </summary>
        public int CurrentActiveSessions
        {
            get
            {
                lock (_waitSync)
                {
                    return _sessionsInUse.Count + _sessionsCreating;
                }
            }
        }

        /// <summary>
        /// The current number of sessions in the Session Pool.
        /// </summary>
        public int CurrentPooledSessions => SessionPoolImpl.ActiveSessionsPooled;

        /// <summary>
        /// The options for this session pool.
        /// </summary>
        public SessionPoolOptions Options { get; } = new SessionPoolOptions();

        /// <inheritdoc />
        public void Dispose()
        {
            Task.Run(ReleaseAll).Wait(ShutDownTimeout);
        }
    }
}
