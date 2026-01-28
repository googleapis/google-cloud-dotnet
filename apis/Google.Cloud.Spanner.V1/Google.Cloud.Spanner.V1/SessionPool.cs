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
        private readonly Logger _logger;
        private readonly IClock _clock;
        private readonly IScheduler _scheduler;

        /// <summary>
        /// The options governing this session pool.
        /// </summary>
        public SessionPoolOptions Options { get; }

        /// <summary>
        /// The client used for all operations in this pool.
        /// </summary>
        internal SpannerClient Client { get; }

        private readonly ConcurrentDictionary<SessionPoolSegmentKey, ManagedSession> _managedSessions =
            new ConcurrentDictionary<SessionPoolSegmentKey, ManagedSession>();

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
        }

        /// <summary>
        /// Provides a snapshot of statistics for this pool.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        [Obsolete("The session pool now relies on multiplexed sessions, which support multiple transactions. " +
            "There's no need for session pooling and these statistics are meaningless.")]
        public Statistics GetStatisticsSnapshot() => new Statistics(_managedSessions.ToArray().Select(p =>
            // These statics are now meaningless, but let's use values that show the pool seemingly healthy.
            new SessionPoolSegmentStatistics(
                p.Key,
                activeSessionCount: 0,
                poolCount:0,
                inFlightCreationCount: 0,
                pendingAcquisitionCount: 0,
                healthy: true,
                shutdown: false))
            .ToList().AsReadOnly());

        /// <summary>
        /// Provides a snapshot of statistics for the pool associated with the given <see cref="SessionPoolSegmentKey"/>.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        [Obsolete("The session pool now relies on multiplexed sessions, which support multiple transactions. " +
            "There's no need for session pooling and these statistics are meaningless.")]
        public SessionPoolSegmentStatistics GetSegmentStatisticsSnapshot(SessionPoolSegmentKey key)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));
            return _managedSessions.TryGetValue(key, out var pool) ?
                // These statics are now meaningless, but let's use values that show the pool seemingly healthy.
                new SessionPoolSegmentStatistics(
                    key,
                    activeSessionCount: 0,
                    poolCount: 0,
                    inFlightCreationCount: 0,
                    pendingAcquisitionCount: 0,
                    healthy: true,
                    shutdown: false) :
                null;
        }

        /// <summary>
        /// Provides a snapshot of statistics for the pool associated with the given database.
        /// This is equivalent to calling <see cref="GetSegmentStatisticsSnapshot(SessionPoolSegmentKey)"/> passing a segment key
        /// with a null database role.
        /// </summary>
        /// <returns>A snapshot of statistics for this pool.</returns>
        [Obsolete("The session pool now relies on multiplexed sessions, which support multiple transactions. " +
            "There's no need for session pooling and these statistics are meaningless.")]
        public SessionPoolSegmentStatistics GetSegmentStatisticsSnapshot(DatabaseName databaseName) =>
            GetSegmentStatisticsSnapshot(SessionPoolSegmentKey.Create(databaseName));

        /// <summary>
        /// Asynchronously acquires a session that will handle transaction creation as needed.
        /// This is equivalent to calling <see cref="AcquireSessionAsync(SessionPoolSegmentKey, TransactionOptions, CancellationToken)"/>
        /// passing a segment key with a null database role.
        /// </summary>
        /// <param name="databaseName">The name of the database to acquire the session for.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and, eventually, the transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(DatabaseName databaseName, TransactionOptions transactionOptions, CancellationToken cancellationToken) =>
            AcquireSessionAsync(SessionPoolSegmentKey.Create(databaseName), transactionOptions, cancellationToken);

        /// <summary>
        /// Asynchronously acquires a session, using the given <see cref="SessionPoolSegmentKey"/>.
        /// The session will handle transaction creation as needed.
        /// </summary>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> to acquire the session.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and, eventually, the transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(SessionPoolSegmentKey key, TransactionOptions transactionOptions, CancellationToken cancellationToken) =>
            AcquireSessionAsync(key, transactionOptions, singleUseTransaction: false, cancellationToken);

        /// <summary>
        /// Asynchronously acquires a session using the given <see cref="SessionPoolSegmentKey"/>.
        /// The session will handle transaction creation as needed.
        /// </summary>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> to acquire the session.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="singleUseTransaction">Whether the transaction used by this session is single use or not. May only be true if
        /// <paramref name="transactionOptions"/> is <see cref="TransactionOptions.ModeOneofCase.ReadOnly"/>.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and, eventually, the transaction.</returns>
        public Task<PooledSession> AcquireSessionAsync(SessionPoolSegmentKey key, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
            AcquireSessionAsync(key, transactionOptions, singleUseTransaction, detached: false, cancellationToken);

        private async Task<PooledSession> AcquireSessionAsync(SessionPoolSegmentKey key, TransactionOptions transactionOptions, bool singleUseTransaction, bool detached, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(key, nameof(key));

            var managedSession = _managedSessions.GetOrAdd(key, CreateManagedSession);
            var managedTransaction = await managedSession.BeginTransactionAsync(transactionOptions, singleUseTransaction, detached, cancellationToken).ConfigureAwait(false);

            return new PooledSession(managedTransaction);
        }

        /// <summary>
        /// Asynchronously acquires a session using the given <see cref="SessionPoolSegmentKey"/>.
        /// The session is detached from the session pool before being returned by this method.
        /// This session pool won't track the acquired session, which won't be returned to be pool even when released.
        /// The session will handle transaction creation as needed.
        /// </summary>
        /// <param name="key">The <see cref="SessionPoolSegmentKey"/> to acquire the session.</param>
        /// <param name="transactionOptions">The transaction options required for the session. After the operation completes,
        /// this value is no longer used, so modifications to the object will not affect the transaction. May be null.</param>
        /// <param name="singleUseTransaction">Whether the transaction used by this session is single use or not. May only be true if
        /// <paramref name="transactionOptions"/> is <see cref="TransactionOptions.ModeOneofCase.ReadOnly"/>.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The <see cref="PooledSession"/> representing the client, session and, eventually, the transaction.</returns>
        public Task<PooledSession> AcquireDetachedSessionAsync(SessionPoolSegmentKey key, TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken) =>
            AcquireSessionAsync(key, transactionOptions, singleUseTransaction, detached: true, cancellationToken);

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

            var managedTransaction = ManagedTransaction.FromTransaction(Client, BuildSession(), transactionId, BuildTransactionOptions(), readTimestamp);

            return new PooledSession(managedTransaction);

            TransactionOptions BuildTransactionOptions() => transactionMode switch
            {
                ModeOneofCase.None => new TransactionOptions (),
                ModeOneofCase.PartitionedDml => new TransactionOptions { PartitionedDml = new() },
                ModeOneofCase.ReadWrite => new TransactionOptions { ReadWrite = new() },
                ModeOneofCase.ReadOnly => new TransactionOptions() { ReadOnly = new() },
                _ => throw new ArgumentException(nameof(transactionMode), $"Unknown {typeof(ModeOneofCase).FullName}: {transactionMode}")
            };

            Session BuildSession() => new Session {
                SessionName = sessionName
            };
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
            var managedSession = _managedSessions.GetOrAdd(key, CreateManagedSession);
            return managedSession.EnsureFreshAsync(cancellationToken);
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
            GaxPreconditions.CheckNotNull(key, nameof(key));
            _ = _managedSessions.TryRemove(key, out var _);
            return Task.CompletedTask;
        }

        private ManagedSession CreateManagedSession(SessionPoolSegmentKey key) => new ManagedSession(
            ManagedSessionOptions.Create(key.DatabaseName, Client)
                .WithDatabaseRole(key.DatabaseRole)
                .WithTimeout(Options.Timeout));
    }
}
