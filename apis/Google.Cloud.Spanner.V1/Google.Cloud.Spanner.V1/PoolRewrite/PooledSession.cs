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
using Google.Cloud.Spanner.V1.Internal;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.PoolRewrite
{
    // TODO: Implement IDisposable? It isn't useful in the ADO.NET provider, but could be useful for
    // any other callers.

    /// <summary>
    /// A session from a <see cref="SessionPool"/>, with an associated transaction if
    /// requested. Instances must be released back to the pool via <see cref="ReleaseToPool(bool)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each method in this class modifies requests passed as arguments to RPC methods, to populate
    /// the session and transaction properties.
    /// </para>
    /// <para>
    /// This class keeps track of successful RPCs to update its internal refresh timer. This can't
    /// be applied for streaming SQL calls, as <see cref="ReliableStreamReader"/> performs the actual
    /// RPCs in that case.
    /// </para>
    /// </remarks>
    public sealed class PooledSession
    {
        private readonly Session _session;

        /// <summary>
        /// The name of the session. This is never null.
        /// </summary>
        public SessionName SessionName { get; }

        /// <summary>
        /// The ID of the transaction. May be null.
        /// </summary>
        public ByteString TransactionId { get; }

        /// <summary>
        /// The mode of the transaction. (Always None iff TransactionId is null.)
        /// </summary>
        internal ModeOneofCase TransactionMode { get; }

        /// <summary>
        /// Indicates whether the server has told us that the session has expired.
        /// </summary>
        internal bool ServerExpired => _session.Expired;

        /// <summary>
        /// The time (in ticks since 0001-01-01T00:00:00Z) at which to refresh this session.
        /// </summary>
        private long _refreshTicks;
        /// <summary>
        /// Retrieves _refreshTicks "freshly" using Interlocked.
        /// </summary>
        private long RefreshTicks => Interlocked.CompareExchange(ref _refreshTicks, 0, 0);

        /// <summary>
        /// The time at which this session should be evicted.
        /// </summary>
        private readonly DateTime _evictionTime;

        // Just for convenience...
        private SpannerClient Client => _pool.Client;

        private readonly SessionPool.ISessionPool _pool;
        private int _disposed;

        private PooledSession(SessionPool.ISessionPool pool, SessionName sessionName, ByteString transactionId, ModeOneofCase transactionMode, DateTime evictionTime, long refreshTicks)
        {
            GaxPreconditions.CheckArgument(
                (transactionId == null) == (transactionMode == ModeOneofCase.None),
                nameof(transactionMode),
                "Transaction mode and ID don't match.");
            _pool = pool;
            SessionName = GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            TransactionId = transactionId;
            TransactionMode = transactionMode;
            _session = new Session { SessionName = SessionName };
            _evictionTime = evictionTime;
            _refreshTicks = refreshTicks;
        }

        /// <summary>
        /// Creates a PooledSession representing a freshly-created session, with no associated transaction.
        /// </summary>
        internal static PooledSession FromSessionName(SessionPool.ISessionPool pool, SessionName sessionName)
        {
            var options = pool.Options;
            var now = pool.Clock.GetCurrentDateTimeUtc();
            var refreshDelay = options.SessionRefreshJitter.GetDelay(options.IdleSessionRefreshDelay);
            var evictionDelay = options.SessionEvictionJitter.GetDelay(options.PoolEvictionDelay);
            return new PooledSession(pool, sessionName, transactionId: null, ModeOneofCase.None, now + evictionDelay, now.Ticks + refreshDelay.Ticks);
        }

        /// <summary>
        /// Returns a PooledSession for the same session as this one, but not disposed, and with no transaction associated with it.
        /// The refresh and eviction times are the same as this instance.
        /// </summary>
        private PooledSession AfterReset() => new PooledSession(_pool, SessionName, null, ModeOneofCase.None, _evictionTime, RefreshTicks);

        internal PooledSession WithTransaction(ByteString transactionId, ModeOneofCase transactionMode) =>
            new PooledSession(_pool, SessionName, transactionId, transactionMode, _evictionTime, _refreshTicks);

        /// <summary>
        /// Indicates whether the associated session has expired and should be evicted from the pool.
        /// </summary>
        internal bool ShouldBeEvicted => _pool.Clock.GetCurrentDateTimeUtc() > _evictionTime;

        /// <summary>
        /// Indicates whether the associated session should be refreshed due to inactivity.
        /// </summary>
        internal bool RequiresRefresh => _pool.Clock.GetCurrentDateTimeUtc().Ticks > RefreshTicks;

        /// <summary>
        /// Indicates the next refresh time; only used by tests.
        /// </summary>
        internal DateTime RefreshTimeForTest => new DateTime(RefreshTicks, DateTimeKind.Utc);

        /// <summary>
        /// Returns this session to the session pool from which it was acquired, unless
        /// it has become invalid. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <param name="forceDelete">true to force the session to be deleted; false to allow the session to be reused.</param>
        public void ReleaseToPool(bool forceDelete)
        {
            bool wasDisposed = Interlocked.Exchange(ref _disposed, 1) == 1;
            if (!wasDisposed)
            {
                _pool.Release(AfterReset(), forceDelete || ServerExpired || ShouldBeEvicted);
            }
            else
            {
                // Log?
            }
        }

        /// <summary>
        /// Executes a Commit RPC asynchronously.
        /// </summary>
        /// <param name="request">The commit request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<CommitResponse> CommitAsync(CommitRequest request, int timeoutSeconds, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(TransactionId != null, "Cannot commit a PooledSession with no associated transaction");
            request.SessionAsSessionName = SessionName;
            request.TransactionId = TransactionId;

            var settings = CreateSettings(Client.Settings.CommitSettings, timeoutSeconds, cancellationToken);
            return RecordSuccessAndExpiredSessions(Client.CommitAsync(request, settings));
        }

        /// <summary>
        /// Executes a Rollback RPC asynchronously.
        /// </summary>
        /// <param name="request">The rollback request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task RollbackAsync(RollbackRequest request, int timeoutSeconds, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(TransactionId != null, "Cannot roll back a PooledSession with no associated transaction");
            request.SessionAsSessionName = SessionName;
            request.TransactionId = TransactionId;

            var settings = CreateSettings(Client.Settings.RollbackSettings, timeoutSeconds, cancellationToken);
            return RecordSuccessAndExpiredSessions(Client.RollbackAsync(request, settings));
        }

        /// <summary>
        /// Executes a PartitionQuery RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, int timeoutSeconds, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(TransactionId != null, "Cannot call PartitionQueryAsync with no associated transaction");
            request.SessionAsSessionName = SessionName;
            request.Transaction = new TransactionSelector { Id = TransactionId };

            var settings = CreateSettings(Client.Settings.PartitionQuerySettings, timeoutSeconds, cancellationToken);
            return RecordSuccessAndExpiredSessions(Client.PartitionQueryAsync(request, settings));
        }

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ExecuteSqlStreamReader(ExecuteSqlRequest request, int timeoutSeconds)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            if (TransactionId != null)
            {
                request.Transaction = new TransactionSelector { Id = TransactionId };
            }
            return Client.GetSqlStreamReader(request, _session, timeoutSeconds);
        }

        /// <summary>
        /// Executes an ExecuteSql RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, int timeoutSeconds, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            request.SessionAsSessionName = SessionName;
            if (TransactionId != null)
            {
                request.Transaction = new TransactionSelector { Id = TransactionId };
            }
            var settings = CreateSettings(Client.Settings.ExecuteSqlSettings, timeoutSeconds, cancellationToken);
            return RecordSuccessAndExpiredSessions(Client.ExecuteSqlAsync(request, settings));
        }

        /// <summary>
        /// Executes a BeginTransaction RPC asynchronously.
        /// </summary>
        /// <remarks>
        /// This method does not affect <see cref="TransactionId"/> of this object. Instead, typical usage will be to call this method followed
        /// by <see cref="WithTransaction(ByteString, ModeOneofCase)"/> to create a new <see cref="PooledSession"/> using the transaction.
        /// </remarks>
        /// <param name="request">The begin-transaction request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="timeoutSeconds">The timeout for this RPC, in seconds.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        internal Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, int timeoutSeconds, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            request.SessionAsSessionName = SessionName;
            var settings = CreateSettings(Client.Settings.BeginTransactionSettings, timeoutSeconds, cancellationToken);
            return RecordSuccessAndExpiredSessions(Client.BeginTransactionAsync(request, settings));
        }

        private async Task<T> RecordSuccessAndExpiredSessions<T>(Task<T> task, [CallerMemberName] string caller = null)
        {
            var result = await task.WithSessionChecking(_session).ConfigureAwait(false);
            UpdateRefreshTime();
            return result;
        }

        private async Task RecordSuccessAndExpiredSessions(Task task)
        {
            await task.WithSessionChecking(_session).ConfigureAwait(false);
            UpdateRefreshTime();
        }

        private CallSettings CreateSettings(CallSettings originalSettings, int timeoutSeconds, CancellationToken cancellationToken) =>
            originalSettings
                .WithExpiration(Client.Settings.ConvertTimeoutToExpiration(timeoutSeconds))
                .WithCancellationToken(cancellationToken);

        /// <summary>
        /// Updates the refresh time for the session based on the current time. This should
        /// be called when a successful RPC is made with the associated session.
        /// </summary>
        private void UpdateRefreshTime()
        {
            var options = _pool.Options;
            var nowTicks = _pool.Clock.GetCurrentDateTimeUtc().Ticks;
            var refreshDelay = options.SessionRefreshJitter.GetDelay(options.IdleSessionRefreshDelay);
            Interlocked.Exchange(ref _refreshTicks, nowTicks + refreshDelay.Ticks);
        }

        private void CheckNotDisposed()
        {
            if (Interlocked.CompareExchange(ref _disposed, 0, 0) == 1)
            {
                throw new ObjectDisposedException($"PooledSession for {SessionName} has been disposed, and cannot be reused.");
            }
        }
    }
}
