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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// A pool of sessions associated with a SpannerClient.
    /// Sessions can be acquired by specifying the desired transaction options, if any.
    /// A session/transaction pair is then returned, which should be returned to the pool when
    /// it is no longer required. Sessions are kept alive automatically, and retired if they
    /// are expired by the server.
    /// </summary>
    public sealed partial class SessionPool
    {
        private readonly ISessionPool _detachedSessionPool;
        private readonly Logger _logger;
        private readonly IClock _clock;
        private readonly IScheduler _scheduler;

        private readonly SemaphoreSlim _batchSessionCreateSemaphore;

        /// <summary>
        /// The options governing this session pool.
        /// </summary>
        public SessionPoolOptions Options { get; }

        /// <summary>
        /// The client used for all operations in this pool.
        /// </summary>
        internal SpannerClient Client { get; }

        private readonly ConcurrentDictionary<SessionPoolSegmentKey, TargetedSessionPool> _targetedPools =
            new ConcurrentDictionary<SessionPoolSegmentKey, TargetedSessionPool>();

        /// <summary>
        /// Creates a session pool for the given client.
        /// </summary>
        /// <param name="client">The client to use for this session pool. Must not be null.</param>
        /// <param name="options">The options for this session pool. Must not be null.</param>
        public SessionPool(SpannerClient client, SessionPoolOptions options)
        {
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
            _clock = client.Settings.Clock ?? SystemClock.Instance;
            _scheduler = client.Settings.Scheduler ?? SystemScheduler.Instance;
            Options = GaxPreconditions.CheckNotNull(options, nameof(options));
            _logger = client.Settings.Logger; // Just to avoid fetching it all the time
            _detachedSessionPool = new DetachedSessionPool(this);
            _batchSessionCreateSemaphore = new SemaphoreSlim( (int) Math.Ceiling(
                Options.MaximumConcurrentSessionCreates / (double) Options.CreateSessionMaximumBatchSize));
            if (Options.MaintenanceLoopDelay != TimeSpan.Zero)
            {
                Task.Run(() => PoolMaintenanceLoop(this));
            }
        }

        /// <summary>
        /// A long-running loop performing pool maintenance. Each iteration runs <see cref="MaintainPool"/>.
        /// This is a static method to allow the target pool to be garbage collected, at which point the
        /// method will complete. (This method only retains a week reference to the specified pool.)
        /// </summary>
        /// <param name="pool">The pool to maintain.</param>
        /// <returns>A task which completes when the maintenance loop has finished, due to the session pool being
        /// garbage collected</returns>
        private static async Task PoolMaintenanceLoop(SessionPool pool)
        {
            // Keep a weak reference so that the pool can be garbage collected and we can stop the
            // maintenance task.
            var weakRef = new WeakReference<SessionPool>(pool);
            // Make sure that even if the pool variable is captured due to compiler implementation details,
            // it won't prevent garbage collection.
            pool = null;
            while (true)
            {
                if (!weakRef.TryGetTarget(out var localPool))
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
                var scheduler = localPool._scheduler;
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
        /// This is equivalent to calling <see cref="GetSegmentStatisticsSnapshot(SessionPoolSegmentKey)"/> passing a segment key
        /// with a null database role.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        [Obsolete("Use the overload GetPoolStatisticsSnapshot(DatabaseName) instead.")]
        public DatabaseStatistics GetStatisticsSnapshot(DatabaseName databaseName)
        {
            var poolStatistics = GetSegmentStatisticsSnapshot(databaseName);
            return (poolStatistics is null) ? null : new DatabaseStatistics(poolStatistics);
        }

        /// <summary>
        /// Provides a snapshot of statistics for the pool associated with the given <see cref="SessionPoolSegmentKey"/>.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        public SessionPoolSegmentStatistics GetSegmentStatisticsSnapshot(SessionPoolSegmentKey key)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            return _targetedPools.TryGetValue(key, out var pool) ? pool.GetStatisticsSnapshot() : null;
        }

        /// <summary>
        /// Provides a snapshot of statistics for the pool associated with the given database.
        /// This is equivalent to calling <see cref="GetSegmentStatisticsSnapshot(SessionPoolSegmentKey)"/> passing a segment key
        /// with a null database role.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        public SessionPoolSegmentStatistics GetSegmentStatisticsSnapshot(DatabaseName databaseName) =>
            _targetedPools.TryGetValue(SessionPoolSegmentKey.Create(databaseName), out var pool) ? pool.GetStatisticsSnapshot() : null;

        /// <summary>
        /// Asynchronously acquires a session, potentially associated with a transaction.
        /// This is equivalent to calling <see cref="AcquireSessionAsync(SessionPoolSegmentKey, TransactionOptions, CancellationToken)"/>
        /// passing a segment key with a null database role.
        /// </summary>
        /// <param name="databaseName">The name of the database to acquire the session for.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(DatabaseName databaseName, TransactionOptions transactionOptions, CancellationToken cancellationToken) =>
            AcquireSessionAsync(SessionPoolSegmentKey.Create(databaseName), transactionOptions, cancellationToken);

        /// <summary>
        /// Asynchronously acquires a session using the given <see cref="SessionPoolSegmentKey"/>, potentially associated with a transaction.
        /// </summary>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> to acquire the session.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(SessionPoolSegmentKey key, TransactionOptions transactionOptions, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            var targetedPool = _targetedPools.GetOrAdd(key, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: true));
            return targetedPool.AcquireSessionAsync(transactionOptions, cancellationToken);
        }

        /// <summary>
        /// Creates a <see cref="PooledSession"/> with a known name and transaction ID/mode, with the client associated
        /// with this pool, but is otherwise not part of this pool. This method does not query the server for the session state.
        /// When the returned <see cref="PooledSession"/> is released, it will not become part of this pool, and the transaction
        /// will not be rolled back.
        /// </summary>
        /// <remarks>
        /// This is typically used for partitioned queries, where the same session is used across multiple machines, so should
        /// not be reused by the pool.
        /// </remarks>
        /// <param name="sessionName">The name of the transaction. Must not be null.</param>
        /// <param name="transactionId">The ID of the transaction. Must not be null.</param>
        /// <param name="transactionMode">The mode of the transaction.</param>
        /// <returns>A <see cref="PooledSession"/> for the given session and transaction.</returns>
        public PooledSession CreateDetachedSession(SessionName sessionName, ByteString transactionId, ModeOneofCase transactionMode) =>
            CreateDetachedSession(sessionName, transactionId, transactionMode, readTimestamp: null);

        /// <summary>
        /// Creates a <see cref="PooledSession"/> with a known name and transaction ID/mode, with the client associated
        /// with this pool, but is otherwise not part of this pool. This method does not query the server for the session state.
        /// When the returned <see cref="PooledSession"/> is released, it will not become part of this pool, and the transaction
        /// will not be rolled back.
        /// </summary>
        /// <remarks>
        /// This is typically used for partitioned queries, where the same session is used across multiple machines, so should
        /// not be reused by the pool.
        /// </remarks>
        /// <param name="sessionName">The name of the transaction. Must not be null.</param>
        /// <param name="transactionId">The ID of the transaction. Must not be null.</param>
        /// <param name="transactionMode">The mode of the transaction.</param>
        /// <param name="readTimestamp">The read timestamp of the transaction.</param>
        /// <returns>A <see cref="PooledSession"/> for the given session and transaction.</returns>
        public PooledSession CreateDetachedSession(SessionName sessionName, ByteString transactionId, ModeOneofCase transactionMode, Timestamp readTimestamp)
        {
            GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
            return PooledSession.FromSessionName(_detachedSessionPool, sessionName).WithTransaction(transactionId, transactionMode, readTimestamp);
        }

        /// <summary>
        /// Returns a task indicating when the session pool associated with the given database name is populated up to its minimum size.
        /// This is equivalent to calling <see cref="WhenPoolReady(SessionPoolSegmentKey, CancellationToken)"/> passing a segment key
        /// with a null database role.
        /// </summary>
        /// <remarks>
        /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
        /// the returned task will be faulted with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="databaseName">The database whose session pool should be populated. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
        public Task WhenPoolReady(DatabaseName databaseName, CancellationToken cancellationToken = default) =>
            WhenPoolReady(SessionPoolSegmentKey.Create(databaseName), cancellationToken);

        /// <summary>
        /// Returns a task indicating when the session pool for the given <see cref="SessionPoolSegmentKey"/> is populated up to its minimum size.
        /// </summary>
        /// <remarks>
        /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
        /// the returned task will be faulted with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> whose session pool should be populated.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
        public Task WhenPoolReady(SessionPoolSegmentKey key, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            var targetedPool = _targetedPools.GetOrAdd(key, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: true)); ;
            return targetedPool.WhenPoolReady(cancellationToken);
        }

        /// <summary>
        /// Shuts down the session pool associated with the given database name.
        /// Further attempts to acquire sessions will fail immediately.
        /// This is equivalent to calling <see cref="ShutdownPoolAsync(SessionPoolSegmentKey, CancellationToken)"/> passing a segment key
        /// with a null database role.
        /// </summary>
        /// <remarks>
        /// This call will delete all pooled sessions, and wait for all active sessions to be released back to the pool
        /// and also deleted.
        /// </remarks>
        /// <param name="databaseName">The database whose session pool should be shut down. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the returned task. This does not cancel the shutdown itself.</param>
        /// <returns>A task which will complete when the session pool has finished shutting down.</returns>
        public Task ShutdownPoolAsync(DatabaseName databaseName, CancellationToken cancellationToken) =>
            ShutdownPoolAsync(SessionPoolSegmentKey.Create(databaseName), cancellationToken);

        /// <summary>
        /// Shuts down the session pool of the given SessionPoolSegmentKey.
        /// Further attempts to acquire sessions will fail immediately.
        /// </summary>
        /// <remarks>
        /// This call will delete all pooled sessions, and wait for all active sessions to be released back to the pool
        /// and also deleted.
        /// </remarks>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> whose session pool should be shutdown.</param>
        /// <param name="cancellationToken">An optional token for canceling the returned task. This does not cancel the shutdown itself.</param>
        /// <returns>A task which will complete when the session pool has finished shutting down.</returns>
        public Task ShutdownPoolAsync(SessionPoolSegmentKey key, CancellationToken cancellationToken)
        {
            // Note that we do potentially create a pool, so that we consistently end the call with a shut-down session pool
            // associated with the given name.
            GaxPreconditions.CheckNotNull(key, nameof(key));
            var targetedPool = _targetedPools.GetOrAdd(key, key => new TargetedSessionPool(this, key, acquireSessionsImmediately: false));
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
    }
}
