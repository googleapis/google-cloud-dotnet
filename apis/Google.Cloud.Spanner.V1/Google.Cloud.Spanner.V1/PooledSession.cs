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
using Google.Protobuf.WellKnownTypes;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1
{
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
    public sealed class PooledSession : IDisposable
    {
        internal Session Session { get; }

        /// <summary>
        /// The name of the session. This is never null.
        /// </summary>
        public SessionName SessionName { get; }

        /// <summary>
        /// The ID of the transaction. May be null.
        /// </summary>
        public ByteString TransactionId { get; set; }

        /// <summary>
        /// The options of the transaction.
        /// </summary>
        public TransactionOptions TransactionOptions { get; set; }

        /// <summary>
        /// The read timestamp of the transaction. (Always <c>null</c> if ReturnReadTimestamp = false)
        /// </summary>
        public Timestamp ReadTimestamp { get; }

        /// <summary>
        /// Indicates whether the server has told us that the session has expired.
        /// </summary>
        internal bool ServerExpired => Session.Expired;

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

        /// <summary>
        /// Create a single instance of the semaphore with a value of 1. It means only one thread will be allowed access at a time.
        /// </summary>
        private static readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

        // Just for convenience...
        private SpannerClient Client => _pool.Client;

        private readonly SessionPool.ISessionPool _pool;
        private int _disposed;
        private int _committedOrRolledBack;

        private PooledSession(SessionPool.ISessionPool pool, SessionName sessionName, Timestamp readTimestamp, DateTime evictionTime, long refreshTicks)
        {
            _pool = pool;
            SessionName = GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            ReadTimestamp = readTimestamp;
            Session = new Session { SessionName = SessionName };
            _evictionTime = evictionTime;
            _refreshTicks = refreshTicks;
            TransactionOptions = null;
            TransactionId = null;
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
            return new PooledSession(pool, sessionName, readTimestamp: null, now + evictionDelay, now.Ticks + refreshDelay.Ticks);
        }

        /// <summary>
        /// Returns a PooledSession for the same session as this one, but not disposed, and with no transaction associated with it.
        /// The refresh and eviction times are the same as this instance.
        /// </summary>
        private PooledSession AfterReset()
        {
            MarkAsDisposed();
            return new PooledSession(_pool, SessionName, null, _evictionTime, RefreshTicks)
            {
                TransactionOptions = null,
            };
        }

        /// <summary>
        /// TODO: Add summary.
        /// </summary>
        /// <param name="transactionId"> The transaction id to which session needs to be associated with.</param>
        /// <param name="readTimestamp"> The read time stamp.</param>
        /// <returns>TODO: Add summary.</returns>
        internal PooledSession WithTransaction(ByteString transactionId, Timestamp readTimestamp = null)
        {
            MarkAsDisposed();
            return new PooledSession(_pool, SessionName, readTimestamp, _evictionTime, _refreshTicks)
            {
                TransactionId = transactionId,
            };
        }

        /// <summary> //TODO: Update Comment
        /// Always returns a new instance of <see cref="PooledSession"/>. The new instance can:
        /// 1. represent the same session as this one, but will have a fresh transaction of the
        /// same type as this <see cref="PooledSession"/> did.
        /// 2. represent an entirely different session with a fresh transaction of the same type
        /// as this <see cref="PooledSession"/> did.
        /// This method will always try to get a fresh transaction for this session.
        /// If the session has expired or it fails to get a fresh transaction, then it will
        /// acquire a session in the normal way.
        /// This <see cref="PooledSession"/> instance will be disposed of to ensure that all operations
        /// with the underlying session are done through the new instance.
        /// </summary>
        /// <remarks>
        /// Use this method when executing operations that are best done using the same
        /// session. For instance, when retrying aborted commits it is better if the transaction work and commit
        /// are retried with the same session, because after each abort the sessions' lock priority increments.
        /// </remarks>
        /// <returns>A new instance of <see cref="PooledSession"/>.</returns>
        /// <exception cref="InvalidOperationException">If transaction mode of this <see cref="PooledSession.TransactionOptions"/>
        /// is <see cref="ModeOneofCase.None"/>.</exception>
        public Task<PooledSession> WithFreshTransactionOrNewAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(transactionOptions, nameof(transactionOptions));
            GaxPreconditions.CheckArgument(transactionOptions.ModeCase == TransactionOptions.ModeCase, nameof(transactionOptions), $"{nameof(TransactionOptions)} should be of the same type as this session's {nameof(TransactionOptions)} which is {TransactionOptions.ModeCase}");

            // Calling AfterReset() will mark this instance as disposed.
            // The pool will take care of releasing back to the pool if needed.
            return _pool.WithFreshTransactionOrNewAsync(AfterReset(), transactionOptions, cancellationToken);
        }

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
        /// Releases this session back to the session pool. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <remarks>
        /// This method is equivalent to calling <see cref="ReleaseToPool(bool)"/> with an argument of <c>false</c>.
        /// </remarks>
        public void Dispose() => ReleaseToPool(false);

        /// <summary>
        /// Usually disposing of a <see cref="PooledSession"/> instance should release its
        /// underlying session to the pool. But when we create a new instance of <see cref="PooledSession"/>
        /// from an existing instance of <see cref="PooledSession"/>, that is, with the same underlying session,
        /// the original instance shouldn't be allowed to be disposed of normally so that the underlying session
        /// is not released back to the pool.
        /// </summary>
        /// <returns><code>true</code> if the <see cref="PooledSession"/> had not been disposed before.
        /// <code>false</code> otherwise.</returns>
        private bool MarkAsDisposed() => Interlocked.Exchange(ref _disposed, 1) != 1;

        /// <summary>
        /// Remembers that the transaction in this session has been successfully commmitted or rolled back.
        /// If a session is disposed but still has a read/write transaction that hasn't been committed or rolled back,
        /// the transaction will be rolled back before the session is reused.
        /// </summary>
        private void MarkAsCommittedOrRolledBack() => Interlocked.Exchange(ref _committedOrRolledBack, 1);

        private bool IsCommittedOrRolledBack() => Interlocked.CompareExchange(ref _committedOrRolledBack, 0, 0) == 1;

        /// <summary>
        /// Returns this session to the session pool from which it was acquired, unless
        /// it has become invalid. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <param name="forceDelete">true to force the session to be deleted; false to allow the session to be reused.</param>
        public void ReleaseToPool(bool forceDelete)
        {
            if (MarkAsDisposed())
            {
                // A read/write transaction that hasn't been committed or rolled back might have taken out a database lock: roll it
                // back as part of releasing the session. (We don't block on the rollback happening though.)
                ByteString transactionToRollback = TransactionOptions?.ModeCase == ModeOneofCase.ReadWrite && !IsCommittedOrRolledBack() ? TransactionId : null;
                _pool.Release(AfterReset(), transactionToRollback, forceDelete || ServerExpired || ShouldBeEvicted);
            }
            else
            {
                // Log?
            }
        }

        /// <summary>
        /// Detaches this session from the session pool from which it was acquired, so that the session pool
        /// stops tracking this session and counting it as active.
        /// This method should only be called once per instance; subsequent calls are ignored.
        /// No other methods can be called after this.
        /// </summary>
        /// <remarks>
        /// This method should be called only for sessions that are meant to be explicitly shared across processes.
        /// Note that we don't attempt to rollback a transaction that is being detached, or attempt to delete the session,
        /// under the assumption that it will be reused across processes.
        /// If there's a process capable of knowing when all other processes are done using the session, then that process could call
        /// <see cref="SessionPool.CreateDetachedSession(SessionName, ByteString, TransactionOptions)"/> (or an overload) to create an instance
        /// of <see cref="PooledSession"/> representing the shared transaction and then call <see cref="ReleaseToPool(bool)"/> passing true
        /// to force session deletion and clean up resources.
        /// Else, the application can rely on Spaner service garbage collection to clean up this session once it becomes stale.
        /// </remarks>
        public void DetachFromPool()
        {
            if (MarkAsDisposed())
            {
                _pool.Detach(AfterReset());
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public async Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var transactionId = TransactionId;
            if (transactionId == null)
            {
                var beginRequest = new BeginTransactionRequest { Options = TransactionOptions };
                var transaction = await BeginTransactionAsync(beginRequest, null).ConfigureAwait(false); // TODO: Probably we'll need to pass callSettings for BeginTransaction.
                transactionId = transaction.Id;
            }

            request.SessionAsSessionName = SessionName;
            request.TransactionId = transactionId;

            var response = await RecordSuccessAndExpiredSessions(Client.CommitAsync(request, callSettings)).ConfigureAwait(false);
            MarkAsCommittedOrRolledBack();
            return response;
        }

        /// <summary>
        /// Executes a Rollback RPC asynchronously.
        /// </summary>
        /// <param name="request">The rollback request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task RollbackAsync(RollbackRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(TransactionId != null, "Cannot roll back a PooledSession with no associated transaction");
            request.SessionAsSessionName = SessionName;
            request.TransactionId = TransactionId;

            await RecordSuccessAndExpiredSessions(Client.RollbackAsync(request, callSettings)).ConfigureAwait(false);
            MarkAsCommittedOrRolledBack();
        }

        /// <summary>
        /// Executes a PartitionRead RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, CallSettings callSettings) =>
            PartitionReadOrQueryAsync(PartitionReadOrQueryRequest.FromRequest(request), callSettings);

        /// <summary>
        /// Executes a PartitionQuery RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, CallSettings callSettings) =>
            PartitionReadOrQueryAsync(PartitionReadOrQueryRequest.FromRequest(request), callSettings);

        /// <summary>
        /// Executes a PartitionRead RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        internal Task<PartitionResponse> PartitionReadOrQueryAsync(PartitionReadOrQueryRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(TransactionId != null, "Cannot call PartitionReadOrQueryAsync with no associated transaction");
            request.SessionAsSessionName = SessionName;
            request.Transaction = new TransactionSelector { Id = TransactionId };

            return RecordSuccessAndExpiredSessions(request.PartitionAsync(Client, callSettings));
        }

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">The read request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ReadStreamReader(ReadRequest request, CallSettings callSettings) =>
            ExecuteReadOrQueryStreamReader(ReadOrQueryRequest.FromRequest(request), callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ExecuteSqlStreamReader(ExecuteSqlRequest request, CallSettings callSettings) =>
            ExecuteReadOrQueryStreamReader(ReadOrQueryRequest.FromRequest(request), callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request
        /// </summary>
        /// <param name="request">The read request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming read request.</returns>
        internal ReliableStreamReader ExecuteReadOrQueryStreamReader(ReadOrQueryRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            request.SessionAsSessionName = SessionName;
            SpannerClientImpl.ApplyResourcePrefixHeaderFromSession(ref callSettings, request.Session);

            // ExecuteWithTransactionSelector will be invoked in the MoveNext() method of ResultStream.
            ResultStream stream = new ResultStream(Client, request, this, callSettings);
            return new ReliableStreamReader(stream, Client.Settings.Logger);
        }

        /// <summary>
        /// Executes an ExecuteSql RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            request.SessionAsSessionName = SessionName;

            return ExecuteWithTransactionSelector(AsyncWork, request.Transaction);

            async Task<ResultSet> AsyncWork(TransactionSelector transaction)
            {
                request.Transaction = transaction;
                return await RecordSuccessAndExpiredSessions(Client.ExecuteSqlAsync(request, callSettings)).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes an ExecuteBatchDml RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            request.SessionAsSessionName = SessionName;
            return ExecuteWithTransactionSelector(AsyncWork, request.Transaction);

            async Task<ExecuteBatchDmlResponse> AsyncWork(TransactionSelector transaction)
            {
                request.Transaction = transaction;
                return await RecordSuccessAndExpiredSessions(Client.ExecuteBatchDmlAsync(request, callSettings)).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Executes a BeginTransaction RPC asynchronously.
        /// </summary>
        /// <remarks>
        /// This method does not affect <see cref="TransactionId"/> of this object. Instead, typical usage will be to call this method followed
        /// by <see cref="WithTransaction(ByteString, Timestamp)"/> to create a new <see cref="PooledSession"/> using the transaction.
        /// </remarks>
        /// <param name="request">The begin-transaction request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            if (TransactionOptions == null)
            {
                TransactionOptions = request.Options;
            }
            else if (TransactionOptions.ModeCase != request.Options.ModeCase)
            {
                // May be this check is not necessary but it's good to have.
                throw new InvalidOperationException("BeginTransactionRequest and Session's TransactionOptions should have same mode.");
            }

            request.SessionAsSessionName = SessionName;
            return RecordSuccessAndExpiredSessions(Client.BeginTransactionAsync(request, callSettings));
        }

        private async Task<T> RecordSuccessAndExpiredSessions<T>(Task<T> task)
        {
            var result = await task.WithSessionExpiryChecking(Session).ConfigureAwait(false);
            UpdateRefreshTime();
            return result;
        }

        private async Task RecordSuccessAndExpiredSessions(Task task)
        {
            await task.WithSessionExpiryChecking(Session).ConfigureAwait(false);
            UpdateRefreshTime();
        }

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

        /// <summary>
        /// Executes the <paramref name="asyncWork"/> with appropritae transaction selector.
        /// </summary>
        /// <typeparam name="TResult"> The type of result to be retunred.</typeparam>
        /// <param name="asyncWork"> Async task that will assign appropriate transaction selector
        /// to the request and then execute the request.</param>
        /// <param name="cancellationToken"> The cancellation token.</param>
        /// <param name="currentTransactionSelector"> The current transaction selector of request that needs to be updated.</param>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<TResult> ExecuteWithTransactionSelector<TResult>(Func<TransactionSelector, Task<TResult>> asyncWork, TransactionSelector currentTransactionSelector, CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckNotNull(asyncWork, nameof(asyncWork));

            // If transaction options is null it means tramsaction is not required
            // to execute this operation. Which means It should have been invoked from Read Only Transaction.
            // If current tramsaction selector if request is of type single use, the no need to inline begin a new transaction.
            if (TransactionOptions == null ||
                currentTransactionSelector?.SelectorCase == TransactionSelector.SelectorOneofCase.SingleUse)
            {
                return await asyncWork(currentTransactionSelector).ConfigureAwait(false);
            }

            // Transaction has been already started by an earlier operation.
            if (TransactionId != null)
            {
                return await asyncWork(new TransactionSelector { Id = TransactionId }).ConfigureAwait(false);
            }

            // Null Transaction Id means a new trasaction needs to inline begin/started.
            // Only one thread should inline begin the transction.

            var enteredSemaphoreSlim = false; // Intially false for all threads.
            if (TransactionId == null)
            {
                await _semaphoreSlim.WaitAsync().ConfigureAwait(false); // All except one thrad will wait here for semaphore to release.
                enteredSemaphoreSlim = true; // True for first thread trying to inline begin.
            }

            // Transaction was aready inline begin by another thread in parallel while this was on hold. 
            if (TransactionId != null)
            {
                return await asyncWork(new TransactionSelector { Id = TransactionId }).ConfigureAwait(false);
            }

            TResult result = default;
            try
            {
                result = await asyncWork(new TransactionSelector { Begin = TransactionOptions }).ConfigureAwait(false);

                if (TransactionId == null)
                {
                    if (result is PartialResultSet)
                    {
                        TransactionId = ((PartialResultSet) (object) result).Metadata.Transaction.Id;
                    }
                    else if (result is ExecuteBatchDmlResponse)
                    {
                        TransactionId = ((ExecuteBatchDmlResponse) (object) result).ResultSets.FirstOrDefault().Metadata.Transaction.Id;
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid response type.");
                    }
                }

                return result;
            }
            catch
            {
                if (result != null && result is ExecuteBatchDmlResponse)
                {
                    TransactionId = ((ExecuteBatchDmlResponse) (object) result).ResultSets?.FirstOrDefault().Metadata.Transaction.Id;
                    throw;
                }

                //Retry if inline fails.
                var request = new BeginTransactionRequest { Options = TransactionOptions };
                var transaction = await BeginTransactionAsync(request, null).ConfigureAwait(false); // TODO: Probably we'll need to pass callSettings for BeginTransaction.
                TransactionId = transaction.Id;
                return await asyncWork(new TransactionSelector { Id = TransactionId }).ConfigureAwait(false);
            }
            finally
            {
                if (enteredSemaphoreSlim)
                {
                    _semaphoreSlim.Release();
                }
            }
        }
    }
}
