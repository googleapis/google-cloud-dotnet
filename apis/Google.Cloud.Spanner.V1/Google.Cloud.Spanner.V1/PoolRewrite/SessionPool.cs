// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.PoolRewrite
{
    /// <summary>
    /// A pool of sessions associated with a SpannerClient.
    /// Sessions can be acquired by specifying the desired transaction options, if any.
    /// A session/transaction pair is then returned, which should be returned to the pool when
    /// it is no longer required. Sessions are kept alive automatically, and retired if they
    /// are expired by the server.
    /// </summary>
    public sealed class SessionPool
    {
        private readonly ISessionPool _detachedSessionPool;

        private readonly Logger _logger;

        private readonly SemaphoreSlim _sessionAcquisitionSemaphore;

        /// <summary>
        /// The options governing this session pool.
        /// </summary>
        public SessionPoolOptions Options { get; }

        private readonly ConcurrentDictionary<DatabaseName, TargetedSessionPool> _targetedPools =
            new ConcurrentDictionary<DatabaseName, TargetedSessionPool>();

        internal SpannerClient Client { get; }

        // TODO: Is this really ugly? It avoids having to scan in the SessionPoolManager...

        /// <summary>
        /// An opaque parent reference; used to allow pool managers to keep track of individual session pools.
        /// TODO: Remove if possible.
        /// </summary>
        public object Parent { get; }

        /// <summary>
        /// Creates a session pool for the given client.
        /// </summary>
        /// <param name="client">The client to use for this session pool. Must not be null.</param>
        /// <param name="options">The options for this session pool. Must not be null.</param>
        /// <param name="logger">The logger to use. May be null, in which case the default logger is used.</param>
        /// <param name="parent">The parent reference. May be null.</param>
        public SessionPool(SpannerClient client, SessionPoolOptions options, Logger logger, object parent)
        {
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
            Options = GaxPreconditions.CheckNotNull(options, nameof(options));
            _logger = logger ?? Logger.DefaultLogger;
            Parent = parent;
            _detachedSessionPool = new DetachedSessionPool(this);
            _sessionAcquisitionSemaphore = new SemaphoreSlim(Options.MaximumConcurrentSessionCreates);
            Task.Run(() => PoolMaintenanceLoop(this));
        }

        /// <summary>
        /// A long-running loop performing pool maintenance. Each iteration runs <see cref="MaintainPool"/>.
        /// This is a static method to allow the target pool to be garbage collected, at which point the 
        /// </summary>
        /// <param name="pool">The pool to maintain.</param>
        /// <returns></returns>
        private static async Task PoolMaintenanceLoop(SessionPool pool)
        {
            // Keep a weak reference so that the pool can be garbage collected and we can stop the
            // maintenance task.
            var weakRef = new WeakReference(pool);
            // Make sure that even if the pool variable is captured due to compiler implementation details,
            // it won't prevent garbage collection.
            pool = null;
            while (true)
            {
                var localPool = (SessionPool) weakRef.Target;
                if (localPool == null)
                {
                    return;
                }
                try
                {
                    localPool.MaintainPool();
                }
                catch (Exception e)
                {
                    localPool._logger.Error($"Error running {nameof(SessionPool)} maintenance task", e);
                }
                var scheduler = localPool.Options.Scheduler;
                var delay = localPool.Options.MaintenanceLoopDelay;
                // Allow the pool to be collected while we're waiting.
                localPool = null;
                await scheduler.Delay(delay, CancellationToken.None).ConfigureAwait(false);
            }
        }

        private void MaintainPool()
        {
            var snapshot = _targetedPools.ToArray();
            foreach (var pool in snapshot.Select(pair => pair.Value))
            {
                pool.MaintainPool();
            }
        }

        /// <summary>
        /// Provides a snapshot of statistics for this pool.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        public Statistics GetStatisticsSnapshot() =>
            new Statistics(_targetedPools.ToArray().Select(p => p.Value.GetStatisticsSnapshot()).ToList().AsReadOnly());

        /// <summary>
        /// Provides a snapshot of statistics for a database-specific pool.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        public DatabaseStatistics GetStatisticsSnapshot(DatabaseName databaseName)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            return _targetedPools.TryGetValue(databaseName, out var pool) ? pool.GetStatisticsSnapshot() : null;
        }

        /// <summary>
        /// Asynchronously acquires a session, potentially associated with a transaction.
        /// </summary>
        /// <param name="databaseName">The name of the database to acquire the session for.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(DatabaseName databaseName, TransactionOptions transactionOptions, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            var targetedPool = _targetedPools.GetOrAdd(databaseName, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: true));
            return targetedPool.AcquireSessionAsync(transactionOptions, cancellationToken);
        }

        // TODO: Rename?

        /// <summary>
        /// Creates a <see cref="PooledSession"/> with a known name and transaction ID, with the client associated
        /// with this pool. This method does not query the server for the session state.
        /// </summary>
        /// <param name="sessionName"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public PooledSession RecreateSession(SessionName sessionName, ByteString transactionId) =>
            // TODO: The use of "read-only" here is a bit weird. We don't know it's read-only, at least in theory. But
            // it so happens that we won't care, because the transaction mode of a client session is only relevant within SessionPoolBase.
            // It would be nice if this weirdness didn't exist.
            PooledSession.FromSessionName(_detachedSessionPool, sessionName).WithTransaction(transactionId, ModeOneofCase.ReadOnly);

        // FIXME: Rename

        /// <summary>
        /// Waits for the session pool associated with the given database name to be populated up to its minimum size.
        /// </summary>
        /// <remarks>
        /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
        /// the returned task will be faulted with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="databaseName">The database whose session pool should be populated. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
        public Task WaitForPoolAsync(DatabaseName databaseName, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            var targetedPool = _targetedPools.GetOrAdd(databaseName, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: true));
            return targetedPool.WaitForPoolAsync(cancellationToken);
        }

        /// <summary>
        /// Shuts down the session pool associated with the given database name.
        /// Further attempts to acquire sessions will fail immediately.
        /// </summary>
        /// <remarks>
        /// This call will delete all pooled sessions, and wait for all active sessions to be released back to the pool
        /// and also deleted.
        /// </remarks>
        /// <param name="databaseName">The database whose session pool should be shut down. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the returned task. This does not cancel the shutdown itself.</param>
        /// <returns>A task which will complete when the session pool has finished shutting down.</returns>
        public Task ShutdownPoolAsync(DatabaseName databaseName, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            // Note that we do potentially create a pool, so that we consistently end the call with a shut-down session pool
            // associated with the given name.
            var targetedPool = _targetedPools.GetOrAdd(databaseName, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: false));
            return targetedPool.ShutdownPoolAsync(cancellationToken);
        }

        /// <summary>
        /// Awooga! Async void method! This is almost always a bad idea, but in this case we have "fire and forget" background
        /// tasks (all created within this method). We want to log errors, but that's all.
        /// </summary>
        private async void ConsumeBackgroundTask(Task task, string purpose)
        {
            try
            {
                await task.ConfigureAwait(false);
            }
            catch (Exception e)
            {
                _logger.Error($"Error in background session pool task for {purpose}", e);
            }
        }

        private void DeleteSessionFireAndForget(PooledSession session)
        {
            ConsumeBackgroundTask(DeleteSessionAsync(session), "session deletion");
        }

        private async Task DeleteSessionAsync(PooledSession session)
        {
            try
            {
                await Client.DeleteSessionAsync(new DeleteSessionRequest { SessionName = session.SessionName }).ConfigureAwait(false);
            }
            catch (RpcException e)
            {
                _logger.Warn("Failed to delete session. Session will be abandoned to garbage collection.", e);
            }
        }

        internal interface ISessionPool
        {
            SpannerClient Client { get; }
            void Release(PooledSession session, bool deleteSession);
            SessionPoolOptions Options { get; }
            Logger Logger { get; }
        }

        private abstract class SessionPoolBase : ISessionPool
        {
            public SpannerClient Client => Parent.Client;
            public SessionPoolOptions Options => Parent.Options;
            public Logger Logger => Parent._logger;
            protected SessionPool Parent { get; }
            public abstract void Release(PooledSession session, bool deleteSession);
            protected SessionPoolBase(SessionPool parent) => Parent = parent;
        }

        private sealed class TargetedSessionPool : SessionPoolBase
        {
            private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };

            // Read-only state
            private readonly object _lock = new object();
            private readonly DatabaseName _databaseName;
            private readonly SessionPool _parent;
            private readonly CreateSessionRequest _createSessionRequest;

            // Mutable state, which should be accessed within the lock

            // TODO: Use linked lists instead?
            private readonly ConcurrentQueue<PooledSession> _readOnlySessions = new ConcurrentQueue<PooledSession>();
            private readonly ConcurrentQueue<PooledSession> _readWriteSessions = new ConcurrentQueue<PooledSession>();
            private readonly ConcurrentQueue<TaskCompletionSource<PooledSession>> _pendingAcquisitions =
                new ConcurrentQueue<TaskCompletionSource<PooledSession>>();
            // Convenience property. Should only be used within the lock.
            private int PoolSize => _readOnlySessions.Count + _readWriteSessions.Count;

            // Tasks waiting for the pool to reach its minimum size or become unhealthy.
            private readonly LinkedList<TaskCompletionSource<int>> _minimumSizeWaiters = new LinkedList<TaskCompletionSource<int>>();

            // Assume the pool is healthy to start with.
            private int _healthy = 1;
            private bool Healthy => Interlocked.CompareExchange(ref _healthy, 0, 0) == 1;

            // The task (completion source) associated with shutting down the session pool, if any.
            // Note that this task has no cancellation token associated with it, even if the original call did.
            private TaskCompletionSource<int> _shutdownTask = null;
            private bool Shutdown => Interlocked.CompareExchange(ref _shutdownTask, null, null) != null;

            /// <summary>
            /// The difference between "acquire" and "release" calls, including pending "acquire" calls. Not guarded by the lock,
            /// but should be modified using Interlocked and accessed via the property.
            /// </summary>
            private int _activeSessionCount;

            /// <summary>
            /// The number of sessions we're currently trying to create. Not guarded by the lock, but should be accessed using Interlocked.
            /// </summary>
            private int _inFlightSessionCreationCount;

            /// <summary>
            /// Thread-safe read-only access to active session count.
            /// </summary>
            internal int ActiveSessionCount => Interlocked.CompareExchange(ref _activeSessionCount, 0, 0);

            /// <summary>
            /// Thread-safe read-only access to in-flight session creation count.
            /// </summary>
            internal int InFlightSessionCreationCount => Interlocked.CompareExchange(ref _inFlightSessionCreationCount, 0, 0);

            // Statistics maintained purely for diagnostic purposes. This lets us evaluate
            // how effective transaction pre-warming is.
            private long _rwTransactionRequests;
            private long _rwTransactionRequestsPrewarmed;

            internal TargetedSessionPool(SessionPool parent, DatabaseName databaseName, bool acquireSessionsImmediately) : base(parent)
            {
                _parent = parent;
                _databaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
                _createSessionRequest = new CreateSessionRequest { DatabaseAsDatabaseName = databaseName };
                if (acquireSessionsImmediately)
                {
                    StartAcquisitionTasksIfNecessary();
                }
            }

            public async Task<PooledSession> AcquireSessionAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                bool success = false;
                try
                {
                    Interlocked.Increment(ref _activeSessionCount);
                    PooledSession session = await AcquireSessionImplAsync(transactionOptions, cancellationToken).ConfigureAwait(false);
                    success = true;
                    return session;
                }
                finally
                {
                    if (!success)
                    {
                        Interlocked.Decrement(ref _activeSessionCount);
                    }
                }
            }

            /// <summary>
            /// Waits for the session pool to be populated up to its minimum size.
            /// </summary>
            /// <remarks>
            /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
            /// the returned task will be faulted with an <see cref="RpcException"/>.
            /// </remarks>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
            internal async Task WaitForPoolAsync(CancellationToken cancellationToken = default)
            {
                Task task;
                LinkedListNode<TaskCompletionSource<int>> node;
                // Check whether we know the result immediately.
                lock (_lock)
                {
                    if (!Healthy)
                    {
                        throw new RpcException(new Status(StatusCode.Unknown, "Session pool was unhealthy"));
                    }
                    if (PoolSize >= Options.MinimumPooledSessions)
                    {
                        return;
                    }
                    var tcs = new TaskCompletionSource<int>();
                    node = _minimumSizeWaiters.AddLast(tcs);
                    task = TcsWithCancellationToken(tcs, cancellationToken);
                }
                await task.ConfigureAwait(false);
                lock (_lock)
                {
                    node.List.Remove(node);
                }
            }

            private async Task<PooledSession> AcquireSessionImplAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                var transactionMode = transactionOptions?.ModeCase ?? ModeOneofCase.None;
                var sessionAcquisitionTask = GetSessionAcquisitionTask(transactionMode, cancellationToken);
                var session = await sessionAcquisitionTask.ConfigureAwait(false);

                // Now we've "taken" this session, we may want to start acquiring more to replenish the pool
                StartAcquisitionTasksIfNecessary();

                // Note: deliberately no test for refresh or eviction.
                // We do this when a session is released, and in the maintenance task.
                // These happen frequently enough that we shouldn't need to worry about them here.

                // Update statistics for prewarming - only after we've already acquired the session.
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    Interlocked.Increment(ref _rwTransactionRequests);
                    if (session.TransactionMode == transactionMode)
                    {
                        Interlocked.Increment(ref _rwTransactionRequestsPrewarmed);
                    }
                }

                if (session.TransactionMode != transactionMode)
                {
                    // If we asked for a session with no transaction but we got one *with* a tranasction,
                    // we don't need to perform any RPCs - but we do need to return a PooledSession with
                    // no transaction ID.
                    if (transactionMode == ModeOneofCase.None)
                    {
                        session = session.WithTransaction(null, ModeOneofCase.None);
                    }
                    else
                    {
                        bool success = false;
                        try
                        {
                            session = await BeginTransactionAsync(session, transactionOptions, cancellationToken).ConfigureAwait(false);
                            success = true;
                        }
                        finally
                        {
                            // If we succeeded in getting a session but not a transaction, we can reuse the session later, but still fail this call.
                            // It counts as "inactive" because the failure will decrement the active session count already.
                            if (!success)
                            {
                                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
                            }
                        }
                    }
                }

                return session;
            }

            private Task<PooledSession> GetSessionAcquisitionTask(ModeOneofCase transactionMode, CancellationToken cancellationToken)
            {
                // Three scenarios for initial session picking:
                // - No transaction options: take a read-only session as-is
                // - Read/write transaction options: take a read/write session as-is
                // - Other options (a non-single-use read-only bound, or PDML): take a read-only session, but fetch a transaction with it before returning it.
                // If there's no session of the appropriate type, take the other kind instead - at the cost of either wasting an existing read/write
                // transaction, or having to acquire a read/write transaction.
                ConcurrentQueue<PooledSession> preferredQueue = _readOnlySessions;
                ConcurrentQueue<PooledSession> alternateQueue = _readWriteSessions;
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    preferredQueue = _readWriteSessions;
                    alternateQueue = _readOnlySessions;
                }
                lock (_lock)
                {
                    // First try the pool.
                    if (preferredQueue.TryDequeue(out var session) || alternateQueue.TryDequeue(out session))
                    {
                        // Slight inefficiency wrapping this in a task, but it makes the implementation simpler.
                        return Task.FromResult(session);
                    }

                    // No pool entries. Check whether we've reached the limit of active sessions.
                    if (ActiveSessionCount >= Options.MaximumActiveSessions && Options.WaitOnResourcesExhausted == ResourcesExhaustedBehavior.Fail)
                    {
                        // Not really an RpcException, but the cleanest way of representing it.
                        // (The ADO.NET provider will convert it to a SpannerException with the same code.)
                        throw new RpcException(new Status(StatusCode.ResourceExhausted, "Local maximum number of active sessions exceeded."));
                    }

                    // If the pool is currently healthy, register a TCS in the queue that will be checked by incoming sessions.
                    if (Healthy)
                    {
                        TaskCompletionSource<PooledSession> receivingTcs = new TaskCompletionSource<PooledSession>();
                        _pendingAcquisitions.Enqueue(receivingTcs);
                        return TcsWithCancellationToken(receivingTcs, cancellationToken);
                    }
                    else
                    {
                        // Otherwise, drop out of the lock to create a session from scratch "inline" (still asynchronously, but not via an in-flight request).
                    }
                }
                // Effectively the "else" block above, but outside the lock
                return CreatePooledSessionAsync(cancellationToken);
            }

            /// <summary>
            /// Release a session back to the pool (or refresh) but don't change the number of active sessions.
            /// </summary>
            /// <param name="session">The session to queue. Should be "active" (i.e. not disposed)</param>
            /// <param name="maybeCreateReadWriteTransaction">Whether to allow the session to go through a cycle of acquiring a read/write transaction.
            /// This is true unless we've just come from attempting to create a read/write transaction, in which case either we succeeded (no need
            /// to create a new one) or failed (in which case we should just keep it read-only).
            /// </param>
            private void ReleaseInactiveSession(PooledSession session, bool maybeCreateReadWriteTransaction)
            {
                if (Shutdown)
                {
                    Parent.DeleteSessionFireAndForget(session);
                    return;
                }

                if (session.RequiresRefresh)
                {
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                    return;
                }

                // There are a couple of cases where we need to take an action outside the lock after breaking
                // out of the loop. It's simplest to remember that in a delegate.
                Action outsideLockAction = null;

                // We need to atomically (within the lock) decide between:
                // - Adding the session to a pool queue (adding performed within the lock)
                // - Providing the session to a waiting caller (setting the result peformed outside the lock)
                // - If it's currently not got a transaction but we need more read/write transactions, starting a transaction
                // In the last case, we will come back to this code to make another decision later.
                while (true)
                {
                    TaskCompletionSource<PooledSession> pendingAquisition;
                    lock (_lock)
                    {
                        // Only add a session to a queue if there are no pending acquisitions.
                        if (!_pendingAcquisitions.TryDequeue(out pendingAquisition))
                        {
                            // Options:
                            // - Decide to create a new read/write transaction (will get back here later)
                            // - Enqueue the current session as read-only or read/write depending on its mode
                            ConcurrentQueue<PooledSession> queue;

                            // If the session already has a read/write transaction, add it to the read/write pool immediately.
                            // Otherwise, work out whether we *want* it to be read/write.
                            if (session.TransactionMode == ModeOneofCase.ReadWrite)
                            {
                                queue = _readWriteSessions;
                            }
                            else
                            {
                                var readCount = _readOnlySessions.Count;
                                var writeCount = _readWriteSessions.Count;
                                // Avoid division by zero by including the new session in the denominator.
                                var writeProportion = writeCount / (writeCount + readCount + 1.0);
                                bool createReadWriteTransaction = maybeCreateReadWriteTransaction && writeProportion < Options.WriteSessionsFraction;
                                if (createReadWriteTransaction)
                                {
                                    // Exit the loop, and acquire a read/write transaction
                                    outsideLockAction = () => Parent.ConsumeBackgroundTask(TryCreateReadWriteTransactionAndReturnToPool(session), "transaction creation");
                                    break;
                                }
                                else
                                {
                                    // Determine the right queue based on its transaction mode.
                                    queue = session.TransactionMode == ModeOneofCase.ReadWrite ? _readWriteSessions : _readOnlySessions;
                                }
                            }

                            // We definitely have a queue now, so add the session to it, and
                            // potentially release tasks waiting for the pool to reach minimum size.
                            queue.Enqueue(session);

                            if (PoolSize >= Options.MinimumPooledSessions && _minimumSizeWaiters.Count > 0)
                            {
                                var minimumSizeWaiters = _minimumSizeWaiters.ToList();
                                outsideLockAction = () => minimumSizeWaiters.ForEach(tcs => tcs.TrySetResult(0));
                            }
                            break;
                        }
                    }

                    // We perform TrySetResult outside the lock, to avoid executing any synchronous continuations inside the lock.
                    if (pendingAquisition.TrySetResult(session))
                    {
                        return;
                    }
                    // The task had been cancelled by the caller. Go round the loop again. (There may or may not be more pending acquisitions.)
                }

                // If we've got anything to execute outside the lock, do so now.
                outsideLockAction?.Invoke();                
            }

            /// <summary>
            /// Refreshes a session by setting executing a trivial SELECT SQL statement.
            /// This is performed via the client session itself so it can update its next refresh time.
            /// </summary>
            private async Task RefreshAsync(PooledSession session)
            {
                // While we're refreshing a session, it's as if we're creating a new one - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                try
                {
                    await session.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = "SELECT 1" }, Options.Timeout, CancellationToken.None).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    _parent._logger.Warn("Failed to refresh session. Session will be deleted.", e);
                    Parent.DeleteSessionFireAndForget(session);
                    return;
                }
                finally
                {
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
                // We now definitely don't have a transaction.
                ReleaseInactiveSession(session.WithTransaction(null, ModeOneofCase.None), maybeCreateReadWriteTransaction: true);
            }

            private async Task TryCreateReadWriteTransactionAndReturnToPool(PooledSession session)
            {
                try
                {
                    session = await BeginTransactionAsync(session, s_readWriteOptions, CancellationToken.None).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    // Failed to create a read/write transaction; release this back to the pool, but making
                    // sure we don't come back here.
                    Parent._logger.Warn("Failed to create read/write transaction for pooled session", e);
                }
                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
            }

            private async Task<PooledSession> BeginTransactionAsync(PooledSession session, TransactionOptions options, CancellationToken cancellationToken)
            {
                // While we're creating a transaction, it's as if we're preparing a new session - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                var request = new BeginTransactionRequest { Options = options };
                try
                {
                    var transaction = await session.BeginTransactionAsync(request, Options.Timeout, cancellationToken).ConfigureAwait(false);
                    return session.WithTransaction(transaction.Id, options.ModeCase);
                }
                finally
                {
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
            }

            /// <summary>
            /// Release a session back to the pool (or refresh or evict it) and decrement the number of active sessions.
            /// </summary>
            public override void Release(PooledSession session, bool deleteSession)
            {
                Interlocked.Decrement(ref _activeSessionCount);
                if (deleteSession)
                {
                    Parent.DeleteSessionFireAndForget(session);
                }
                else
                {
                    ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                }
            }

            internal void MaintainPool()
            {
                if (Shutdown)
                {
                    return;
                }
                EvictAndRefreshSessions();
                StartAcquisitionTasksIfNecessary();
                _parent._logger.Debug(() => $"After maintenance: {GetStatisticsSnapshot()}");
            }

            private void EvictAndRefreshSessions()
            {
                LinkedList<PooledSession> sessionsToEvict = new LinkedList<PooledSession>();
                LinkedList<PooledSession> staleSessions = new LinkedList<PooledSession>();
                lock (_lock)
                {
                    RemoveStaleOrExpiredItemsFromQueue(_readOnlySessions);
                    RemoveStaleOrExpiredItemsFromQueue(_readWriteSessions);
                }

                foreach (var session in sessionsToEvict)
                {
                    Parent.DeleteSessionFireAndForget(session);
                }
                foreach (var session in staleSessions)
                {
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                }

                void RemoveStaleOrExpiredItemsFromQueue(ConcurrentQueue<PooledSession> queue)
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        // This shouldn't happen, as nothing else should touch the queue while we're in a
                        // lock, but we don't want to throw an exception
                        if (!queue.TryDequeue(out var session))
                        {
                            break;
                        }
                        if (session.ShouldBeEvicted)
                        {
                            sessionsToEvict.AddLast(session);
                        }
                        else if (session.RequiresRefresh)
                        {
                            staleSessions.AddLast(session);
                        }
                        else
                        {
                            // The session is fine - put it back on the queue.
                            queue.Enqueue(session);
                        }
                    }
                }
            }

            /// <summary>
            /// Starts tasks to create new sessions if that's necessary to get the pool to a minimum size or to
            /// service queued callers. It's possible that we'll end up with more sessions than we want or need
            /// if an active request calls this at exactly the same time as the maintenance task, but that's not too
            /// bad.
            /// </summary>
            private void StartAcquisitionTasksIfNecessary()
            {
                if (!Healthy || Shutdown)
                {
                    return;
                }

                // Take snapshots of all values to be consistent.
                int minPoolSize;
                int maxActiveSessions;
                int poolSize;
                int pendingAcquisitionCount;
                int inFlightRequests;
                int activeSessions;
                lock (_lock)
                {
                    poolSize = _readWriteSessions.Count + _readOnlySessions.Count;
                    inFlightRequests = InFlightSessionCreationCount;
                    pendingAcquisitionCount = _pendingAcquisitions.Count;
                    minPoolSize = Options.MinimumPooledSessions;
                    maxActiveSessions = Options.MaximumActiveSessions;
                    activeSessions = ActiveSessionCount;
                }

                // Determine how many more requests to start.
                // We want to make sure that if all existing and new requests succeed:
                // - All queuing callers will have a session
                // - The pool will have at least as many entries the options specify
                // However, we don't want to end up with more than the maximum number of active sessions
                // in the options.

                // In reality, the current pool size should be 0 if pendingAcquisitionCount is non-zero, and
                // vice versa. However, we don't strictly enforce this, and the maths works out more simply if
                // we don't worry about it.

                // How many more requests do we need to make in order to get the pool to the minimum size, after satisfying
                // pending callers, assuming that all the in-flight requests succeed, and there are no more requests?
                int newRequestsToSatisfyPool = (pendingAcquisitionCount + minPoolSize) - (poolSize + inFlightRequests);
                // How many more requests *can* we make without going over the maximum number of active sessions?
                int maxAvailableRequests = maxActiveSessions - (activeSessions + poolSize + inFlightRequests);

                int actualNewRequests = Math.Min(newRequestsToSatisfyPool, maxAvailableRequests);

                for (int i = 0; i < actualNewRequests; i++)
                {
                    Parent.ConsumeBackgroundTask(PrepareNewSessionAsync(), "session creation");
                }

                async Task PrepareNewSessionAsync()
                {
                    try
                    {
                        var session = await CreatePooledSessionAsync(CancellationToken.None).ConfigureAwait(false);
                        ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                    }
                    // Note: we expect this to always actually be an RpcException, but we don't want to end up unhealthy
                    // with a lot of 
                    catch (Exception e)
                    {
                        Parent._logger.Warn(() => $"Failed to create session for {_databaseName}", e);

                        // CreatePooledSessionAsync will have caused the session pool to become unhealthy already, so we shouldn't get
                        // any new waiting callers at this point. 
                        // Propagate this exception to all waiting callers.
                        List<TaskCompletionSource<PooledSession>> pendingAcquisitionsList = new List<TaskCompletionSource<PooledSession>>();
                        List<TaskCompletionSource<int>> minimumSizeWaiters;
                        lock (_lock)
                        {
                            // Don't set the exception in the lock.
                            while (_pendingAcquisitions.TryDequeue(out var acquisition))
                            {
                                pendingAcquisitionsList.Add(acquisition);
                            }
                            minimumSizeWaiters = _minimumSizeWaiters.ToList();
                        }
                        pendingAcquisitionsList.ForEach(tcs => tcs.TrySetException(e));
                        minimumSizeWaiters.ForEach(tcs => tcs.TrySetException(e));
                    }
                }
            }

            private async Task<PooledSession> CreatePooledSessionAsync(CancellationToken cancellationToken)
            {
                bool success = false;
                bool canceled = false;
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                try
                {
                    var callSettings = Client.Settings.CreateSessionSettings
                        .WithExpiration(Client.Settings.ConvertTimeoutToExpiration(Options.Timeout))
                        .WithCancellationToken(cancellationToken);
                    Session sessionProto;

                    bool acquiredSemaphore = false;
                    try
                    {
                        await _parent._sessionAcquisitionSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                        acquiredSemaphore = true;
                        sessionProto = await Client.CreateSessionAsync(_createSessionRequest, callSettings).ConfigureAwait(false);
                        success = true;
                        return PooledSession.FromSessionName(this, sessionProto.SessionName);
                    }
                    catch (OperationCanceledException)
                    {
                        canceled = true;
                        throw;
                    }
                    finally
                    {
                        if (acquiredSemaphore)
                        {
                            _parent._sessionAcquisitionSemaphore.Release();
                        }
                    }
                }
                finally
                {
                    // Atomically set _healthy and determine whether we were previously healthy, but only if either we've succeeded,
                    // or we failed for a reason other than cancellation. We don't want to go unhealthy just because a caller cancelled
                    // a cancellation token before we had chance to create the session.
                    if (success || !canceled)
                    {
                        bool wasHealthy = Interlocked.Exchange(ref _healthy, success ? 1 : 0) == 1;
                        if (wasHealthy != success)
                        {
                            Parent._logger.Info(() => $"Session pool for {_databaseName} is now {(success ? "healthy" : "unhealthy")}.");
                        }
                    }
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
            }

            internal DatabaseStatistics GetStatisticsSnapshot()
            {
                lock (_lock)
                {
                    return new DatabaseStatistics(
                        _databaseName,
                        _readOnlySessions.Count,
                        _readWriteSessions.Count,
                        InFlightSessionCreationCount,
                        _pendingAcquisitions.Count,
                        Interlocked.CompareExchange(ref _rwTransactionRequests, 0L, 0L),
                        Interlocked.CompareExchange(ref _rwTransactionRequestsPrewarmed, 0L, 0L),
                        Healthy,
                        Shutdown);
                }
            }

            internal Task ShutdownPoolAsync(CancellationToken cancellationToken)
            {
                // Shutdown can only be started once, but we can acquire the same task as often as we want.
                var newTcs = new TaskCompletionSource<int>();
                var previousTcs = Interlocked.CompareExchange(ref _shutdownTask, newTcs, null);

                if (previousTcs == null)
                {
                    _parent.ConsumeBackgroundTask(ExecuteShutdownAsync(newTcs), "shutdown");
                }

                // Return the appropriate TCS, with the given cancellation token.
                var tcs = previousTcs ?? newTcs;
                return TcsWithCancellationToken(tcs, cancellationToken);
            }

            /// <summary>
            /// Performs the actual shutdown of the pool. This method should only be called once per pool.
            /// </summary>
            private async Task ExecuteShutdownAsync(TaskCompletionSource<int> tcsToSignal)
            {
                // It's somewhat ugly to do this in a loop, and after the first iteration we'll *mostly* just be waiting for
                // the active session count and in-flight session creation count to hit 0... but it means we don't need to worry
                // about race conditions of one thread checking the shutdown flag just before it was set, but then adding a
                // pending acquisition just after we've cancelled everything.
                _parent._logger.Debug(() => $"Executing shutdown for {_databaseName}");
                try
                {
                    while (true)
                    {
                        if (PoolSize == 0 &&
                            ActiveSessionCount == 0 &&
                            InFlightSessionCreationCount == 0 &&
                            _pendingAcquisitions.Count == 0 &&
                            _minimumSizeWaiters.Count == 0)
                        {
                            // It's possible that there are some sessions still being deleted at this point, but waiting for those
                            // tasks to complete would be awkward and it's very unlikely to make any material difference.
                            break;
                        }

                        _parent._logger.Debug(() => $"Pending shutdown: {GetStatisticsSnapshot()}");

                        var sessionsToDelete = new List<PooledSession>();
                        List<TaskCompletionSource<int>> minSizeWaitersToCancel;
                        List<TaskCompletionSource<PooledSession>> pendingAcquisitionsToCancel = new List<TaskCompletionSource<PooledSession>>();
                        lock (_lock)
                        {
                            while (_readOnlySessions.TryDequeue(out var session))
                            {
                                sessionsToDelete.Add(session);
                            }
                            while (_readWriteSessions.TryDequeue(out var session))
                            {
                                sessionsToDelete.Add(session);
                            }
                            // These will clear themselves out of the list when they complete, even with a fault.
                            minSizeWaitersToCancel = _minimumSizeWaiters.ToList();
                            while (_pendingAcquisitions.TryDequeue(out var pendingAcquisitions))
                            {
                                pendingAcquisitionsToCancel.Add(pendingAcquisitions);
                            }
                        }

                        pendingAcquisitionsToCancel.ForEach(tcs => tcs.TrySetCanceled());
                        minSizeWaitersToCancel.ForEach(tcs => tcs.TrySetCanceled());
                        List<Task> tasks = sessionsToDelete.Select(cs => _parent.DeleteSessionAsync(cs)).ToList();

                        try
                        {
                            await Task.WhenAll(tasks).ConfigureAwait(false);
                        }
                        catch
                        {
                            var failureCount = tasks.Count(t => t.Status != TaskStatus.RanToCompletion);
                            _parent._logger.Warn($"{failureCount} out of {tasks.Count} deletion tasks failed during shutdown");
                        }

                        await Task.Delay(1000).ConfigureAwait(false);
                    }
                }
                // However we complete, signal that shutdown is finished.
                finally
                {
                    _parent._logger.Debug(() => $"Shutdown complete for {_databaseName}");
                    tcsToSignal.TrySetResult(0);
                }
            }
        }

        // TODO: Rename?
        private sealed class DetachedSessionPool : SessionPoolBase
        {
            internal DetachedSessionPool(SessionPool parent) : base(parent)
            {
            }

            public override void Release(PooledSession session, bool deleteSession)
            {
                if (deleteSession)
                {
                    Parent.DeleteSessionFireAndForget(session);
                }
            }
        }

        // FIXME: Work out somewhere decent to put this.
        private static Task<T> TcsWithCancellationToken<T>(TaskCompletionSource<T> tcs, CancellationToken cancellationToken)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return tcs.Task;
            }
            return Wait();
            
            async Task<T> Wait()
            {
                using (var registration = cancellationToken.Register(() => tcs.TrySetCanceled()))
                {
                    return await tcs.Task.ConfigureAwait(false);
                }
            }
        }

        /// <summary>
        /// A snapshot of statistics for a <see cref="SessionPool"/>.
        /// </summary>
        public sealed class Statistics
        {
            /// <summary>
            /// The total number of read-only sessions in the pool.
            /// </summary>
            public int TotalReadPoolCount => PerDatabaseStatistics.Sum(d => d.ReadPoolCount);
            /// <summary>
            /// The total number of read/write sessions in the pool.
            /// </summary>
            public int TotalReadWritePoolCount => PerDatabaseStatistics.Sum(d => d.ReadWritePoolCount);
            /// <summary>
            /// The total number of active sessions.
            /// </summary>
            public int TotalActiveSessions => PerDatabaseStatistics.Sum(d => d.ActiveSessionCount);

            /// <summary>
            /// The total number of session creation (or refresh, or transaction creation) requests in flight.
            /// </summary>
            public int TotalInFlightCreationCount => PerDatabaseStatistics.Sum(d => d.InFlightCreationCount);

            /// <summary>
            /// The total number of client calls awaiting sessions.
            /// </summary>
            public int TotalPendingAcquisitionCount => PerDatabaseStatistics.Sum(d => d.PendingAcquisitionCount);

            /// <summary>
            /// The statistics broken down by database.
            /// </summary>
            public IReadOnlyList<DatabaseStatistics> PerDatabaseStatistics { get; }

            internal Statistics(IReadOnlyList<DatabaseStatistics> perDatabaseStatistics) =>
                PerDatabaseStatistics = perDatabaseStatistics;
        }

        /// <summary>
        /// A snapshot of statistics for one database within a <see cref="SessionPool"/>.
        /// </summary>
        public sealed class DatabaseStatistics
        {
            /// <summary>
            /// The database this set of statistics corresponds to.
            /// </summary>
            public DatabaseName DatabaseName { get; }

            /// <summary>
            /// The number of read-only sessions in the pool.
            /// </summary>
            public int ReadPoolCount { get; }

            /// <summary>
            /// The number of read/write sessions in the pool.
            /// </summary>
            public int ReadWritePoolCount { get; }

            /// <summary>
            /// The number of active sessions.
            /// </summary>
            public int ActiveSessionCount { get; }

            /// <summary>
            /// The number of session creation (or refresh, or transaction creation) requests in flight.
            /// </summary>
            public int InFlightCreationCount { get; }
            
            /// <summary>
            /// The number of client calls awaiting sessions.
            /// </summary>
            public int PendingAcquisitionCount { get; }

            /// <summary>
            /// The number of times a read/write transaction was requested.
            /// </summary>
            public long ReadWriteTransactionRequests { get; }

            /// <summary>
            /// The number of times a read/write transaction was satisfied with a pre-warmed transaction.
            /// </summary>
            public long ReadWriteTransactionRequestsPrewarmed { get; }

            /// <summary>
            /// Whether the pool is healthy or not.
            /// </summary>
            public bool Healthy { get; }

            /// <summary>
            /// Whether the pool has been shut down or not. (This indicates the start
            /// of shutdown, not necessarily the end.)
            /// </summary>
            public bool Shutdown{ get; }

            /// <summary>
            /// Constructs a new instance.
            /// </summary>
            internal DatabaseStatistics(
                DatabaseName databaseName,
                int readPoolCount,
                int readWritePoolCount,
                int inFlightCreationCount,
                int pendingAcquisitionCount,
                long readWriteTransactionRequests,
                long readWriteTransactionRequestsPrewarmed,
                bool healthy,
                bool shutdown)
            {
                DatabaseName = databaseName;
                ReadPoolCount = readPoolCount;
                ReadWritePoolCount = readWritePoolCount;
                InFlightCreationCount = inFlightCreationCount;
                PendingAcquisitionCount = pendingAcquisitionCount;
                ReadWriteTransactionRequests = readWriteTransactionRequests;
                ReadWriteTransactionRequestsPrewarmed = readWriteTransactionRequestsPrewarmed;
                Healthy = healthy;
                Shutdown = shutdown;
            }

            /// <inheritdoc />
            public override string ToString()
            {
                string status = Shutdown ? "Shutdown"
                    : Healthy ? "Healthy"
                    : "Unhealthy";
                // TODO: Use multiple lines? There are definite pros and cons both ways.
                return $"Database: {DatabaseName}; Active: {ActiveSessionCount}; Read pool: {ReadPoolCount}; Write pool: {ReadWritePoolCount}; In-flight creation: {InFlightCreationCount}; Pending acquisitions: {PendingAcquisitionCount}; Status: {status}; Read/write prewarming: {ReadWriteTransactionRequestsPrewarmed}/{ReadWriteTransactionRequests}";
            }
        }
    }
}
