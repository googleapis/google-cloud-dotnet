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
        private readonly object _transactionCreationTaskLock = new object();
        private Task _transactionCreationTask;

        /// <summary>
        /// The name of the session. This is never null.
        /// </summary>
        public SessionName SessionName => Session.SessionName;

        /// <summary>
        /// The Spanner session resource associated to this pooled session.
        /// Won't be null.
        /// </summary>
        internal Session Session { get; }

        private Transaction _transaction;
        /// <summary>
        /// The ID of the transaction. May be null.
        /// </summary>
        /// <remarks>
        /// Transactions are acquired when they are needed so this will be null in the
        /// following cases:
        /// <list type="bullet">
        /// <item>
        /// <see cref="TransactionOptions"/> is <see cref="TransactionOptions.ModeOneofCase.None"/>,
        /// including when the session is idle in the pool.
        /// </item>
        /// <item>
        /// <see cref="SingleUseTransaction"/> is true. No transactions will exist client side.
        /// </item>
        /// <item>
        /// The session has been acquired from the pool with some transaction options but no command execution has
        /// been attempted since.
        /// </item>
        /// <item>
        /// The first command execution is underway and the transaction is being created either
        /// by inlining or explicitly.
        /// </item>
        /// </list>
        /// </remarks>
        public ByteString TransactionId => Interlocked.CompareExchange(ref _transaction, null, null)?.Id;

        /// <summary>
        /// Whether this session is detached from the session pool or not.
        /// </summary>
        /// <remarks>
        /// Detached sessions are used for transactional operations performed across several processes,
        /// for instance, partitioned reads. See the <see cref="ReleaseToPool(bool)"/> documentation for
        /// information on how to release resources of a detached session gracefully.
        /// </remarks>
        public bool IsDetached => !_pool.TracksSessions;

        /// <summary>
        /// The options for the transaction that is or will be associated with this session. Won't be null.
        /// </summary>
        /// <remarks>
        /// Will be <see cref="TransactionOptions.ModeOneofCase.None"/> if <see cref="TransactionId"/>
        /// is null.
        /// </remarks>
        private TransactionOptions TransactionOptions { get; }

        /// <summary>
        /// The transaction mode for the transaction that is or may be associated with this session.
        /// Available for testing.
        /// </summary>
        internal TransactionOptions.ModeOneofCase TransactionMode => TransactionOptions.ModeCase;

        /// <summary>
        /// Whether the transaction associated to this session is single use or not.
        /// If this is true then <see cref="TransactionOptions"/> will be <see cref="TransactionOptions.ModeOneofCase.ReadOnly"/>
        /// and <see cref="TransactionId"/> will be null.
        /// </summary>
        internal bool SingleUseTransaction { get; }

        /// <summary>
        /// The read timestamp of the transaction. May be null.
        /// </summary>
        /// <remarks>
        /// Will be set iif a transaction has been started and <see cref="TransactionOptions"/> represents read-only options
        /// with <see cref="Types.ReadOnly.ReturnReadTimestamp"/> set to true
        /// or if this session was created using <see cref="SessionPool.CreateDetachedSession(SessionName, ByteString, ModeOneofCase, Timestamp)"/>
        /// and a value was provided for the <see cref="Timestamp"/> parameter.
        /// </remarks>
        public Timestamp ReadTimestamp => Interlocked.CompareExchange(ref _transaction, null, null)?.ReadTimestamp;

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

        // Just for convenience...
        private SpannerClient Client => _pool.Client;

        private readonly SessionPool.ISessionPool _pool;
        private int _disposed;
        private int _committedOrRolledBack;

        private PooledSession(SessionPool.ISessionPool pool, SessionName sessionName, ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp, DateTime evictionTime, long refreshTicks)
        {
            _pool = pool;
            Session = new Session
            {
                SessionName = GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName))
            };
            TransactionOptions = transactionOptions?.Clone() ?? new TransactionOptions();

            GaxPreconditions.CheckArgument(
                TransactionOptions.ModeCase == ModeOneofCase.ReadOnly || !singleUseTransaction,
                nameof(singleUseTransaction),
                "Single use transactions are only supported for read-only transactions.");
            GaxPreconditions.CheckArgument(
                transactionId is null || TransactionOptions.ModeCase != ModeOneofCase.None,
                nameof(transactionOptions),
                "No transaction options were specified for the given transasaction ID.");
            GaxPreconditions.CheckArgument(
                readTimestamp is null || transactionId is not null,
                nameof(readTimestamp),
                "A read timestamp can only be specified if a transaction ID is also being specified.");

            SingleUseTransaction = singleUseTransaction;
            if (transactionId is not null)
            {
                // We don't need to lock here, this is the constructor.
                _transaction = new Transaction
                {
                    Id = transactionId,
                    ReadTimestamp = readTimestamp,
                };
            }
            _evictionTime = evictionTime;
            _refreshTicks = refreshTicks;
        }

        /// <summary>
        /// Decides whether we need a transaction ID or not and whether that can be obtained by transaction inlining.
        /// Sets the correct transaction selector before executing the given command.
        /// </summary>
        /// <remarks>All RPCs executed within the session should call this method for guaranteeing they are
        /// using the correct transaction selector.</remarks>
        /// <typeparam name="TResponse">The type of the command response.</typeparam>
        /// <param name="transactionSelectorSetter">Called by this method to set the correct transaction selector.</param>
        /// <param name="commandAsync">The command (RPC) that will be executed after the transaction selector has maybe been set.
        /// Callers may fail if command is executed but no transaction selector has been set.</param>
        /// <param name="inlinedTransactionExtractor">Will extract transaction information from the command's response if
        /// transaction inlining was succesful. May be null, which indicates that command does not support transaction inlining.</param>
        /// <param name="skipTransactionCreation">If true, transaction creation may be skipped. This is used by commit and rollback
        /// so that a transaction is not created just for inmediate commit or rollback. Note that if there are pending mutations, commit
        /// should set this parameter to false.</param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task whose result will be the result from having executed <paramref name="commandAsync"/>.</returns>
        internal async Task<TResponse> ExecuteMaybeWithTransactionSelectorAsync<TResponse>(
            Action<TransactionSelector> transactionSelectorSetter,
            Func<Task<TResponse>> commandAsync,
            Func<TResponse, Transaction> inlinedTransactionExtractor,
            bool skipTransactionCreation,
            CancellationToken cancellationToken)
        {
            // If this session is configured to use no transaction we just execute the command.
            if (TransactionOptions.ModeCase == ModeOneofCase.None)
            {
                return await commandAsync().ConfigureAwait(false);
            }

            // If this is to be a single use transaction, we set the selector to single use and execute the command.
            if (SingleUseTransaction)
            {
                transactionSelectorSetter(new TransactionSelector { SingleUse = TransactionOptions });
                return await commandAsync().ConfigureAwait(false);
            }

            // If we already have a transaction ID, we set the selector to that and execute the command.
            // TransactionId is accessed and modified via Interlock.CompareExchange so these two are atomic operations.
            // But also, if TransactionId is about to be modified right after this check, that's not a problem, because next
            // we'll be awaiting on the task that does the modifying.
            if (TransactionId is ByteString transactionId)
            {
                transactionSelectorSetter(new TransactionSelector { Id = transactionId });
                return await commandAsync().ConfigureAwait(false);
            }

            // We now know that we don't have a transaction ID but we need one to execute
            // the command we have been given.
            // We now need to check if we are already creating a transaction or not.
            // If we are, we just get ready to wait for it.
            // If we are not, but we need to, we start and save the task that does so,
            // and get ready to wait for it.

            // This is the function that will wait for the transaction task to be done.
            // We need to initialize a function within the lock, so we can execute
            // async code, outside the lock.
            // We initialize it with just command, in case no transaction is being created
            // and the caller does not require one. This is the case for commits and rollbacks
            // executed when no transaction has been created before.
            // Commits and rollbacks will know how to handle transaction absence.
            Func<Task<TResponse>> commandMaybeWithTransactionAsync = commandAsync;

            lock (_transactionCreationTaskLock)
            {
                // We are not creating a transaction. We might need to do so.
                if (_transactionCreationTask is null)
                {
                    // We need to create a transaction.
                    if (!skipTransactionCreation)
                    {
                        // The calling command does not support inlining
                        // or the transaction mode Partitioned DML, which cannot be inline.
                        // Either way we need to create a transaction explicitly.
                        if (inlinedTransactionExtractor is null || TransactionOptions.ModeCase == ModeOneofCase.PartitionedDml)
                        {
                            _transactionCreationTask = Task.Run(() => SetExplicitTransactionAsync(cancellationToken), cancellationToken);
                            commandMaybeWithTransactionAsync = () => CommandWithTransactionAsync(cancellationToken);
                        }
                        // The calling command supports inlining.
                        // We attempt inlining but if that fails, we create a transaction explicitly.
                        else
                        {
                            // Create a task for executing the command which inlines transaction creation.
                            // If this task succeeds we'll have both the transaction ID and the response from the command.
                            // If this task fails we'll have to attempt to begin a transaction explicitly, which will give us a transaction ID,
                            // and then we'll have to execute the command with that transaction.
                            Task<TResponse> commandWithInliningTask = Task.Run(CommandWithInliningAsync, cancellationToken);

                            // Now, create two tasks, one that is done when we have a transaction ID (via inlining or explicit),
                            // and one that is done when the command is done (with inlining or explicit).

                            // The transaction creation task is the combination of attempting inlining,
                            // and if that fails, explicitly creating a transaction.
                            _transactionCreationTask = Task.Run(async () =>
                            {
                                try
                                {
                                    await SetInlinedTransactionAsync(commandWithInliningTask).ConfigureAwait(false);
                                }
                                catch (Exception ex)
                                {
                                    Client.Settings.Logger.Warn("Transaction creation via inlining failed. " +
                                        "Attempting to begin an explicit transaction.",
                                        ex);
                                    await SetExplicitTransactionAsync(cancellationToken).ConfigureAwait(false);
                                }
                            }, cancellationToken);

                            // The command execution task is the combination of attempting inlining,
                            // and if that fails, executing the command with the explicitly created transaction.
                            commandMaybeWithTransactionAsync = async () =>
                            {
                                try
                                {
                                    var response = await commandWithInliningTask.ConfigureAwait(false);
                                    // If we are here, inlining was successful so we have a transaction.
                                    // We only wait for the _transactionCreationTaks to be done to guarantee
                                    // that the transaction ID obtained via inlining has been stored and can
                                    // be access via TransactionId. In turn this guarantees command executors
                                    // that there's an ID available inmediately after a successful command execution.
                                    await _transactionCreationTask.ConfigureAwait(false);
                                    return response;
                                }
                                catch (Exception ex)
                                {
                                    Client.Settings.Logger.Warn("Command execution with transaction inlining failed. " +
                                        "Waiting for an explicit transaction to be created to attempt command execution.",
                                        ex);
                                    // If we got here, transaction inlining (plus command execution) failed.
                                    // That means that _transactionCreationTask is attempting to created an explicit
                                    // transaction.
                                    // So now we wait for that transaction to be created and the execute the command normally.
                                    return await CommandWithTransactionAsync(cancellationToken).ConfigureAwait(false);
                                }
                            };
                        }
                    }

                    // No transaction is being created, but we don't need to do so.
                    // commandWithTransactionAsync is already initialized to just commandAsync.
                }
                // We are creating a transaction, let's get ready to wait for that to be done and use it.
                else
                {
                    commandMaybeWithTransactionAsync = () => CommandWithTransactionAsync(cancellationToken);
                }
            }

            return await commandMaybeWithTransactionAsync().ConfigureAwait(false);

            async Task<TResponse> CommandWithTransactionAsync(CancellationToken cancellationToken)
            {
                // This is only called when we know the _transactionCreationTask has been initialized
                await _transactionCreationTask.WithCancellationToken(cancellationToken).ConfigureAwait(false);
                // Now we know there's a transaction id.
                transactionSelectorSetter(new TransactionSelector { Id = TransactionId });
                return await commandAsync().ConfigureAwait(false);
            }

            Task<TResponse> CommandWithInliningAsync()
            {
                transactionSelectorSetter(new TransactionSelector { Begin = TransactionOptions });
                return commandAsync();
            }

            async Task SetExplicitTransactionAsync(CancellationToken cancellationToken)
            {
                Transaction transaction = await BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
                SetTransaction(transaction);
            }

            async Task SetInlinedTransactionAsync(Task<TResponse> commandWithInliningTask)
            {
                TResponse response = await commandWithInliningTask.ConfigureAwait(false);
                Transaction transaction = inlinedTransactionExtractor(response)
                    ?? throw new InvalidOperationException("The inlined transaction extractor returned a null transaction. " +
                    "This is possibly because of a bug in library code or because an operation that supported transaction inlining has stopped doing so.");
                SetTransaction(transaction);
            }

            void SetTransaction(Transaction transaction)
            {
                if (Interlocked.CompareExchange(ref _transaction, transaction, null) is not null)
                {
                    throw new InvalidOperationException("This session already contains a transaction. This is a bug in library code.");
                }
            }

            Task<Transaction> BeginTransactionAsync(CancellationToken cancellationToken)
            {
                var request = new BeginTransactionRequest
                {
                    Options = TransactionOptions,
                    SessionAsSessionName = SessionName,
                };
                var callSettings = Client.Settings.BeginTransactionSettings
                    .WithExpiration(Expiration.FromTimeout(_pool.Options.Timeout))
                    .WithCancellationToken(cancellationToken);
                return RecordSuccessAndExpiredSessions(Client.BeginTransactionAsync(request, callSettings));
            }
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
            return new PooledSession(pool, sessionName, transactionId: null, transactionOptions: null, singleUseTransaction: false, readTimestamp: null, now + evictionDelay, now.Ticks + refreshDelay.Ticks);
        }

        /// <summary>
        /// Returns a PooledSession for the same session as this one with <see cref="TransactionMode"/> set to <see cref="TransactionOptions.ModeOneofCase.None"/>.
        /// The refresh and eviction times are the same as this instance.
        /// This instance will be <see cref="MarkAsDisposed"/> to ensure that all operations with the underlying session are done through the new instance.
        /// </summary>
        private PooledSession AfterReset()
        {
            MarkAsDisposed();
            return new PooledSession(_pool, SessionName, transactionId: null, transactionOptions: null, singleUseTransaction: false, readTimestamp: null, _evictionTime, RefreshTicks);
        }

        /// <summary>
        /// Returns a PooledSession for the same session as this with the given <paramref name="transactionOptions"/> and no associated transaction.
        /// The refresh and eviction times are the same as this instance.
        /// This instance will be <see cref="MarkAsDisposed"/> to ensure that all operations with the underlying session are done through the new instance.
        /// </summary>
        internal PooledSession WithTransactionOptions(TransactionOptions transactionOptions, bool singleUseTransaction)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(transactionOptions, nameof(transactionOptions));
            MarkAsDisposed();
            return new PooledSession(_pool, SessionName, transactionId: null, transactionOptions, singleUseTransaction, readTimestamp: null, _evictionTime, RefreshTicks);
        }

        /// <summary>
        /// Returns a PooledSession for the same session as this one with the given transaction related values.
        /// The refresh and eviction times are the same as this instance.
        /// This instance will be <see cref="MarkAsDisposed"/> to ensure that all operations with the underlying session are done through the new instance.
        /// </summary>
        internal PooledSession WithTransaction(ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp = null)
        {
            MarkAsDisposed();
            return new PooledSession(_pool, SessionName, transactionId, transactionOptions, singleUseTransaction, readTimestamp, _evictionTime, _refreshTicks);
        }

        /// <summary>
        /// Always returns a new instance of <see cref="PooledSession"/>. The new instance can:
        /// 1. represent the same session as this one, with the same transaction options,
        /// but it won't have a transaction associated to it
        /// 2. represent an entirely different session with the same transaction options
        /// as this <see cref="PooledSession"/> did and no transaction associated to it
        /// If this session has expired then this method will acquire a new session in the normal way.
        /// This <see cref="PooledSession"/> instance will be disposed of to ensure that all operations
        /// with the underlying session are done through the new instance.
        /// </summary>
        /// <remarks>
        /// Use this method when executing operations that are best done using the same
        /// session. For instance, when retrying aborted commits it is better if the transaction work and commit
        /// are retried with the same session, because after each abort the sessions' lock priority increments.
        /// </remarks>
        public Task<PooledSession> RefreshedOrNewAsync(CancellationToken cancellationToken)
        {
            CheckNotDisposed();

            // Calling AfterReset() will mark this instance as disposed.
            // The pool will take care of releasing back to the pool if needed.
            return _pool.RefreshedOrNewAsync(AfterReset(), TransactionOptions, SingleUseTransaction, cancellationToken);
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
        /// Returns this session to the session pool from which it was acquired, unless this is a detached session
        /// or it has become invalid. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <param name="forceDelete">true to force the session to be deleted; false to allow the session to be reused.</param>
        /// <remarks>
        /// If <see cref="IsDetached"/> is true, the session won't be returned to the pool because its underlying
        /// resources may be being used by other processes. The last process to use this session's underlying resources should
        /// call <see cref="ReleaseToPool(bool)"/> with <paramref name="forceDelete"/> set to true, so that the session resources
        /// are gracefully freed.
        /// </remarks>
        public void ReleaseToPool(bool forceDelete)
        {
            if (MarkAsDisposed())
            {
                // A read/write transaction that hasn't been committed or rolled back might have taken out a database lock: roll it
                // back as part of releasing the session. (We don't block on the rollback happening though.)
                ByteString transactionToRollback = TransactionOptions.ModeCase == ModeOneofCase.ReadWrite && !IsCommittedOrRolledBack() ? TransactionId : null;
                _pool.Release(AfterReset(), transactionToRollback, forceDelete || ServerExpired || ShouldBeEvicted);
            }
            else
            {
                // Log?
            }
        }

        /// <summary>
        /// Returns a new <see cref="PooledSession"/> instance identical to this one, except for the given pool.
        /// No other methods can be called after this.
        /// </summary>
        /// <remarks>
        /// This method is an implementation detail that allows us to acquire a pooled session from <see cref="SessionPool.TargetedSessionPool"/>
        /// and turn it into a detached session by moving it to <see cref="SessionPool.DetachedSessionPool"/>.
        /// </remarks>
        internal PooledSession WithPool(SessionPool.ISessionPool pool)
        {
            GaxPreconditions.CheckNotNull(pool, nameof(pool));
            CheckNotDisposed();
            if (IsCommittedOrRolledBack())
            {
                throw new InvalidOperationException("A session with a completed transaction cannot be moved to a different pool.");
            }

            // We mark this instance as disposed because we'll be changing the associated pool,
            // which means we don't want this instance to be usable after.
            MarkAsDisposed();

            return new PooledSession(pool, SessionName, TransactionId, TransactionOptions, SingleUseTransaction, ReadTimestamp, _evictionTime, RefreshTicks);
        }

        /// <summary>
        /// Executes a Commit RPC asynchronously.
        /// </summary>
        /// <param name="request">The commit request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: CommitAsync,
                inlinedTransactionExtractor: null, // Commit does not support inline transactions.
                skipTransactionCreation: request.Mutations.Count == 0, // If there are only mutations we won't have a transaction but we need one.
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector) 
            {
                switch (transactionSelector.SelectorCase)
                {
                    case TransactionSelector.SelectorOneofCase.Id:
                        request.TransactionId = transactionSelector.Id;
                        break;
                    case TransactionSelector.SelectorOneofCase.Begin:
                        throw new InvalidOperationException("Commit does not support inline transactions. This is a bug in library code.");
                    case TransactionSelector.SelectorOneofCase.SingleUse:
                        throw new InvalidOperationException("A single use transaction cannot be committed.");
                    default:
                        throw new InvalidOperationException("Cannot commit a PooledSession with no associated transaction");
                }
            }

            async Task<CommitResponse> CommitAsync()
            {
                // If a transaction had been started, by now SetTransaction should have been called with a transaction ID.
                // If not, there's an attempt to commit a non-existent transaction.
                if (request.TransactionId is null || request.TransactionId.IsEmpty)
                {
                    throw new InvalidOperationException("Cannot commit a PooledSession with no associated transaction. " +
                        "A transaction has not been acquired for this PooledSession because no command execution has been attempted.");
                }

                var response = await RecordSuccessAndExpiredSessions(Client.CommitAsync(request, callSettings)).ConfigureAwait(false);
                MarkAsCommittedOrRolledBack();
                return response;
            }
        }

        /// <summary>
        /// Executes a Rollback RPC asynchronously.
        /// </summary>
        /// <param name="request">The rollback request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task RollbackAsync(RollbackRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: RollbackAsync,
                inlinedTransactionExtractor: null, // Rollback does not support inline transactions.
                skipTransactionCreation: true, // If there's no transaction by the time roll back is called, we fail, we don't need to create one.
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector)
            {
                switch (transactionSelector.SelectorCase)
                {
                    case TransactionSelector.SelectorOneofCase.Id:
                        request.TransactionId = transactionSelector.Id;
                        break;
                    case TransactionSelector.SelectorOneofCase.Begin:
                        throw new InvalidOperationException("Rollback does not support inline transactions. This is a bug in library code.");
                    case TransactionSelector.SelectorOneofCase.SingleUse:
                        throw new InvalidOperationException("A single use transaction cannot be rolled back.");
                    default:
                        throw new InvalidOperationException("Cannot roll back a PooledSession with no associated transaction");
                }
            }

            async Task<bool> RollbackAsync()
            {
                // If a transaction had been started, by now SetTransaction should have been called with a transaction ID.
                // If not, there's an attempt to roll back a transaction that was never started.
                // Possibly starting the transaction is what failed, but if we fail here as well, we are passing the burden to calling code
                // to know whether a transaction was actually acquired before calling rollback, and we don't want to do that.
                // Attemting to roll back an empty transaction is no-op.
                if (request.TransactionId is null || request.TransactionId.IsEmpty)
                {
                    return false;
                }

                await RecordSuccessAndExpiredSessions(Client.RollbackAsync(request, callSettings)).ConfigureAwait(false);
                MarkAsCommittedOrRolledBack();
                // Just so we can use the same ExecuteMaybeWithTransactionAsync method that expects a result.
                return true;
            }
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

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: PartitionReadOrQueryAsync,
                inlinedTransactionExtractor: GetInlinedTransaction,
                skipTransactionCreation: false,
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector)
            {
                switch (transactionSelector.SelectorCase)
                {
                    case TransactionSelector.SelectorOneofCase.Id:
                    case TransactionSelector.SelectorOneofCase.Begin:
                        request.Transaction = transactionSelector;
                        break;
                    case TransactionSelector.SelectorOneofCase.SingleUse:
                        throw new InvalidOperationException("A single use transaction cannot be used for creating partitioned reads or queries.");
                    default:
                        throw new InvalidOperationException("Cannot call PartitionReadOrQueryAsync with no associated transaction.");
                }
            }

            Task<PartitionResponse> PartitionReadOrQueryAsync()
            {
                // By now SetTransaction should have been called with a valid transaction selector.
                // If not, there's a bug in code because we said not to skip transaction creation.
                if (request.Transaction is null )
                {
                    throw new InvalidOperationException("Cannot call PartitionReadOrQueryAsync with no associated transaction.");
                }

                return RecordSuccessAndExpiredSessions(request.PartitionAsync(Client, callSettings));
            }

            Transaction GetInlinedTransaction(PartitionResponse response) => response?.Transaction;
        }

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">
        /// The read request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ReadStreamReader(ReadRequest request, CallSettings callSettings) =>
            ExecuteReadOrQueryStreamReader(ReadOrQueryRequest.FromRequest(request), callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">
        /// The query request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
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
            Client.MaybeApplyRouteToLeaderHeader(ref callSettings, TransactionMode);
            MaybeApplyDirectedReadOptions(request.UnderlyingRequest);

            ResultStream stream = new ResultStream(Client, request, this, callSettings);
            return new ReliableStreamReader(stream, Client.Settings.Logger);
        }

        /// <summary>
        /// Executes an ExecuteSql RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallSettings callSettings)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: ExecuteSqlAsync,
                inlinedTransactionExtractor: GetInlinedTransaction,
                skipTransactionCreation: false,
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

            Task<ResultSet> ExecuteSqlAsync()
            {
                Client.MaybeApplyRouteToLeaderHeader(ref callSettings, TransactionMode);
                MaybeApplyDirectedReadOptions(request);
                return RecordSuccessAndExpiredSessions(Client.ExecuteSqlAsync(request, callSettings));
            }

            Transaction GetInlinedTransaction(ResultSet response) => response?.Metadata?.Transaction;
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

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: ExecuteBatchDmlAsync,
                inlinedTransactionExtractor: GetInlinedTransaction,
                skipTransactionCreation: false,
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

            Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync() => RecordSuccessAndExpiredSessions(Client.ExecuteBatchDmlAsync(request, callSettings));

            Transaction GetInlinedTransaction(ExecuteBatchDmlResponse response) => response?.ResultSets?.FirstOrDefault()?.Metadata?.Transaction;
        }

        private void MaybeApplyDirectedReadOptions(IReadOrQueryRequest request)
        {
            if (TransactionMode == ModeOneofCase.ReadOnly // Directed reads apply only to single use or read only transactions. Single use are read only.
                && request.DirectedReadOptions is null) // Request specific options have priority over client options.
            {
                request.DirectedReadOptions = Client.Settings.DirectedReadOptions;
            }

            // We don't validate that DirectedReadOptions is null when this is a non-read-only transaction.
            // We just pass the request along as we received it. The service should fail if there are options set.
            // This was agreed as part of the client library desing.
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
    }
}
