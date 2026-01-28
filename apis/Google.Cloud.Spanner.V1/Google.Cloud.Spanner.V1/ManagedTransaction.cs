// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// A managed transaction that will acquire a Spanner transaction as needed and apply it to requests
/// executed with it.
/// </summary>
/// <remarks>
/// <para>
/// Each method in this class modifies requests passed as arguments to RPC methods, to populate
/// the session and transaction properties.
/// </para>
/// </remarks>
public sealed class ManagedTransaction : IAsyncDisposable
{
    /// <summary>
    /// Lock object for ensuring that creating a Spanner transaction is a thread safe operation.
    /// </summary>
    private readonly object _transactionCreationTaskLock = new object();
    /// <summary>
    /// The task that creates a Spanner transaction. Will be null until a Spanner transaction is required.
    /// Once the task completes succesfully, <see cref="_transaction"/> will reference the created Spanner transaction.
    /// </summary>
    private Task _transactionCreationTask;

    /// <summary>
    /// The Spanner transaction associated to this <see cref="ManagedTransaction"/>
    /// if one has been created.
    /// </summary>
    private Transaction _transaction;

    /// <summary>
    /// Guarantees access to precommit token is thread safe.
    /// </summary>
    private readonly SemaphoreSlim _precommitTokenSemaphore = new SemaphoreSlim(1);

    /// <summary>
    /// Token used by Spanner for transaction coordination when executing with multiplexed sessions.
    /// </summary>
    private MultiplexedSessionPrecommitToken _precommitToken;

    /// <summary>
    /// The timeout used when an explicit transaction is created
    /// or automatically rolled-back on dispose.
    /// May be null or positive.
    /// </summary>
    private readonly TimeSpan? _transactionOperationsTimeout;

    /// <summary>
    /// Options for the Spanner transaction that is or will be associated to this <see cref="ManagedTransaction"/>.
    /// </summary>
    private readonly TransactionOptions _transactionOptions;

    /// <summary>
    /// Whether the Spanner transaction that is or will be associated to this <see cref="ManagedTransaction"/>
    /// is single use, which means, no Spanner transction will be created client side.
    /// When true, <see cref="_transactionOptions"/> will be <see cref="TransactionOptions.ModeOneofCase.ReadOnly"/>.
    /// </summary>
    private readonly bool _singleUse;

    /// <summary>
    /// The Spanner session under which this <see cref="ManagedTransaction"/> will create
    /// the Spanner transaction, when applicable. Won't be null.
    /// </summary>
    /// <remarks>
    /// Note that we don't remember the <see cref="ManagedSession"/> this <see cref="ManagedTransaction"/>
    /// was created from because the underlying Spanner session may be refreshed, but this transaction
    /// needs to know the exact Spanner session it was created from.
    /// </remarks>
    private readonly Session _session;

    private readonly SpannerClient _client;

    /// <summary>
    /// This transaction is meant to be shared by different processes. It won't be automatically rollbacked
    /// on disposed.
    /// </summary>
    private readonly bool _shared;
    private int _disposed;
    private int _committedOrRolledBack;

    /// <summary>
    /// The name of the session. This is never null.
    /// </summary>
    public SessionName SessionName => _session.SessionName;

    /// <summary>
    /// The ID of the transaction. Will be null if a Spanner transaction hasn't been created yet.
    /// Spanner transaction is usually created when the first command that requires a transaction is
    /// executed via this <see cref="ManagedTransaction"/>.
    /// </summary>
    public ByteString TransactionId => Interlocked.CompareExchange(ref _transaction, null, null)?.Id;

    /// <summary>
    /// The read timestamp of the transaction. May be null.
    /// </summary>
    /// <remarks>
    /// Will be set iif a transaction has been started and <see cref="TransactionOptions"/> represents read-only options
    /// with <see cref="TransactionOptions.Types.ReadOnly.ReturnReadTimestamp"/> set to true
    /// or if this session was created using <see cref="FromTransaction(SpannerClient, Session, ByteString, TransactionOptions, Timestamp)"/>
    /// and a non-null was provided for the <see cref="Timestamp"/> parameter.
    /// </remarks>
    public Timestamp ReadTimestamp => Interlocked.CompareExchange(ref _transaction, null, null)?.ReadTimestamp;

    // These are internal properties that are only needed while we support the session pool.
    // Marking as deprecated from the start so we remove then on the next major version.

    [Obsolete("Used by session pool only.")]
    internal bool Shared => _shared;

    private ManagedTransaction(
        SpannerClient client, TimeSpan? transactionOperationsTimeout,
        Session session, ByteString transactionId,
        TransactionOptions transactionOptions, bool singleUse, bool shared, Timestamp readTimestamp)
    {
        _client = GaxPreconditions.CheckNotNull(client, nameof(client));
        _session = GaxPreconditions.CheckNotNull(session, nameof(session));
        _transactionOperationsTimeout = ManagedSessionOptions.CheckNullOrPositiveTimeSpan(transactionOperationsTimeout);
        _transactionOptions = GaxPreconditions.CheckNotNull(transactionOptions, nameof(transactionOptions));

        GaxPreconditions.CheckArgument(
            _transactionOptions.ModeCase == ModeOneofCase.ReadOnly || !singleUse,
            nameof(singleUse),
            "Single use transactions are only supported for read-only transactions.");
        GaxPreconditions.CheckArgument(
            !shared || !singleUse,
            nameof(shared),
            "A shared transaction cannot be single use.");
        GaxPreconditions.CheckArgument(
            transactionId is null || shared,
            nameof(transactionId),
            "A managed transaction with a given transaction ID must be shared.");
        GaxPreconditions.CheckArgument(
            transactionId is null || _transactionOptions.ModeCase != ModeOneofCase.None,
            nameof(transactionOptions),
            "No transaction options were specified for the given transasaction ID.");
        GaxPreconditions.CheckArgument(
            readTimestamp is null || transactionId is not null,
            nameof(readTimestamp),
            "A read timestamp can only be specified if a transaction ID is also being specified.");

        _shared = shared;
        _singleUse = singleUse;
        if (transactionId is not null)
        {
            // We don't need to lock here, this is the constructor.
            _transaction = new Transaction
            {
                Id = transactionId,
                ReadTimestamp = readTimestamp,
            };
        }
    }

    /// <summary>
    /// Creates a <see cref="ManagedTransaction"/> associated to <paramref name="session"/>.
    /// </summary>
    /// <remarks>
    /// Note that obtaining a <see cref="ManagedTransaction"/> won't inmediately start a Spanner transaction.
    /// Instead, a <see cref="ManagedTransaction"/> will start a Spanner transaction when needed, usually when
    /// exeucting the first command, and will manage the Spanner transaction lifecycle.
    /// </remarks>
    internal static ManagedTransaction FromTransactionOptions(ManagedSessionOptions sessionOptions, Session session, TransactionOptions transactionOptions, bool singleUse, bool shared) =>
        new ManagedTransaction(sessionOptions.Client, sessionOptions.Timeout, session, null, transactionOptions?.Clone() ?? new TransactionOptions(), singleUse, shared, null);

    /// <summary>
    /// Creates a <see cref="ManagedTransaction"/> associated to the pair <paramref name="session"/>,
    /// <paramref name="transactionId"/>.
    /// </summary>
    /// <remarks>
    /// Note that no Spanner transaction will be started. The transaction identified by <paramref name="transactionId"/>
    /// should have been started or obtained earlier by the caller.
    /// </remarks>
    public static ManagedTransaction FromTransaction(SpannerClient client, Session session, ByteString transactionId, TransactionOptions transactionOptions, Timestamp readTimestamp) =>
        new ManagedTransaction(client, null, session, transactionId, transactionOptions?.Clone() ?? new TransactionOptions(), false, true, readTimestamp);

    /// <summary>
    /// Creates a new managed transaction from this one. This is useful for preserving lock ordering
    /// in the event of the current transaction being aborted.
    /// </summary>
    public ManagedTransaction FreshAfterAbort()
    {
        GaxPreconditions.CheckState(!_shared, "Shared managed transactions cannot be refreshed.");
        GaxPreconditions.CheckState(_transactionOptions.ModeCase == ModeOneofCase.ReadWrite, "Only read-write transaction may be refreshed.");
        GaxPreconditions.CheckState(TransactionId is not null, "There's no underlying Spanner transaction to refresh.");

        var transactionOptions = _transactionOptions.Clone();
        transactionOptions.ReadWrite.MultiplexedSessionPreviousTransactionId = TransactionId;
        return new ManagedTransaction(_client, _transactionOperationsTimeout, _session, null, transactionOptions, _singleUse, _shared, null);
    }

    /// <summary>
    /// Decides whether we need a transaction ID or not and whether that can be obtained by transaction inlining.
    /// Sets the correct transaction selector before executing the given command.
    /// </summary>
    /// <remarks>All RPCs executed within the managed transaction should call this method for guaranteeing they are
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
    /// <param name="mutation">If this is a mutations only commit, the transaction is begun explicitly,
    /// and a mutatation is included in the begin transaction request.</param>
    /// <param name="transactionTag">A transaction tag to specify on an explict transaction.</param>
    /// <param name="cancellationToken">The cancellation token for the operation.</param>
    /// <returns>A task whose result will be the result from having executed <paramref name="commandAsync"/>.</returns>
    internal async Task<TResponse> ExecuteMaybeWithTransactionSelectorAsync<TResponse>(
        Action<TransactionSelector> transactionSelectorSetter,
        Func<Task<TResponse>> commandAsync,
        Func<TResponse, Transaction> inlinedTransactionExtractor,
        bool skipTransactionCreation,
        Mutation mutation,
        string transactionTag,
        CancellationToken cancellationToken)
    {
        // If this session is configured to use no transaction we just execute the command.
        if (_transactionOptions.ModeCase == ModeOneofCase.None)
        {
            return await commandAsync().ConfigureAwait(false);
        }

        // If this is to be a single use transaction, we set the selector to single use and execute the command.
        if (_singleUse)
        {
            transactionSelectorSetter(new TransactionSelector { SingleUse = _transactionOptions });
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
                    if (inlinedTransactionExtractor is null || _transactionOptions.ModeCase == ModeOneofCase.PartitionedDml)
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
                                await SetInlinedTransactionAsync(commandWithInliningTask, cancellationToken).ConfigureAwait(false);
                            }
                            catch (Exception ex)
                            {
                                _client.Settings.Logger.Warn("Transaction creation via inlining failed. " +
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
                                _client.Settings.Logger.Warn("Command execution with transaction inlining failed. " +
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
            transactionSelectorSetter(new TransactionSelector { Begin = _transactionOptions });
            return commandAsync();
        }

        async Task SetExplicitTransactionAsync(CancellationToken cancellationToken)
        {
            Transaction transaction = await BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
            await SetTransactionAsync(transaction, cancellationToken).ConfigureAwait(false);
        }

        async Task SetInlinedTransactionAsync(Task<TResponse> commandWithInliningTask, CancellationToken cancellationToken)
        {
            TResponse response = await commandWithInliningTask.ConfigureAwait(false);
            Transaction transaction = inlinedTransactionExtractor(response)
                ?? throw new InvalidOperationException("The inlined transaction extractor returned a null transaction. " +
                "This is possibly because of a bug in library code or because an operation that supported transaction inlining has stopped doing so.");
            await SetTransactionAsync(transaction, cancellationToken).ConfigureAwait(false);
        }

        async Task SetTransactionAsync(Transaction transaction, CancellationToken cancellationToken)
        {
            await MaybeUpdatePrecommitToken(transaction.PrecommitToken, cancellationToken).ConfigureAwait(false);
            if (Interlocked.CompareExchange(ref _transaction, transaction, null) is not null)
            {
                throw new InvalidOperationException("This session already contains a transaction. This is a bug in library code.");
            }
        }

        Task<Transaction> BeginTransactionAsync(CancellationToken cancellationToken)
        {
            var request = new BeginTransactionRequest
            {
                Options = _transactionOptions,
                SessionAsSessionName = SessionName,
                MutationKey = mutation,
                RequestOptions = new RequestOptions
                {
                    TransactionTag = transactionTag ?? ""
                }
            };
            var callSettings = _client.Settings.BeginTransactionSettings
                .WithCancellationToken(cancellationToken);
            if (_transactionOperationsTimeout.HasValue)
            {
                callSettings = callSettings.WithExpiration(Expiration.FromTimeout(_transactionOperationsTimeout.Value));
            }
            return _client.BeginTransactionAsync(request, callSettings);
        }
    }

    /// <summary>
    /// Rollbacks the Spanner transaction if it was read/write, it hasn't been committed or rollbacked
    /// and the managed transaction is not shared.
    /// </summary>
    public async ValueTask DisposeAsync()
    {
        if (MarkAsDisposed() &&
            !_shared &&
            _transactionOptions.ModeCase == ModeOneofCase.ReadWrite &&
            !IsCommittedOrRolledBack())
        {
            var callSettings = _client?.Settings.RollbackSettings;
            if (_transactionOperationsTimeout.HasValue)
            {
                callSettings = callSettings.WithExpiration(Expiration.FromTimeout(_transactionOperationsTimeout.Value));
            }
            await RollbackAsync(new RollbackRequest(), callSettings, disposing: true).ConfigureAwait(false);
        }
    }

    private bool MarkAsDisposed() => Interlocked.Exchange(ref _disposed, 1) != 1;

    private void CheckNotDisposed()
    {
        if (Interlocked.CompareExchange(ref _disposed, 0, 0) == 1)
        {
            throw new ObjectDisposedException($"{nameof(ManagedTransaction)} for {SessionName} has been disposed, and cannot be reused.");
        }
    }

    /// <summary>
    /// Remembers that the transaction in this session has been successfully commmitted or rolled back.
    /// If a session is disposed but still has a read/write transaction that hasn't been committed or rolled back,
    /// the transaction will be rolled back before the session is reused.
    /// </summary>
    private void MarkAsCommittedOrRolledBack() => Interlocked.Exchange(ref _committedOrRolledBack, 1);

    private bool IsCommittedOrRolledBack() => Interlocked.CompareExchange(ref _committedOrRolledBack, 0, 0) == 1;

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
        var cancellationToken = callSettings?.CancellationToken ?? default;

        return ExecuteMaybeWithTransactionSelectorAsync(
            transactionSelectorSetter: SetCommandTransaction,
            commandAsync: CommitAsync,
            inlinedTransactionExtractor: null, // Commit does not support inline transactions.
            skipTransactionCreation: request.Mutations.Count == 0, // If there are only mutations we won't have a transaction but we need one.
            mutation: GetMutationWithKeys(),
            transactionTag: request.RequestOptions?.TransactionTag,
            cancellationToken);

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
                    throw new InvalidOperationException("Cannot commit a managed transaction with no associated Spanner transaction");
            }
        }

        async Task<CommitResponse> CommitAsync()
        {
            // If a transaction had been started, by now SetTransaction should have been called with a transaction ID.
            // If not, there's an attempt to commit a non-existent transaction.
            if (request.TransactionId is null || request.TransactionId.IsEmpty)
            {
                throw new InvalidOperationException("Cannot commit a managed transaction with no associated Spanner transaction. " +
                    "A transaction has not been acquired for this manged transaction because no command execution has been attempted.");
            }

            CommitResponse response;
            do
            {
                request.PrecommitToken = await GetPrecommitTokenAsync(cancellationToken).ConfigureAwait(false);
                response = await _client.CommitAsync(request, callSettings).ConfigureAwait(false);
                await MaybeUpdatePrecommitToken(response?.PrecommitToken, cancellationToken).ConfigureAwait(false);
            }
            while(response.MultiplexedSessionRetryCase == CommitResponse.MultiplexedSessionRetryOneofCase.PrecommitToken);

            MarkAsCommittedOrRolledBack();
            return response;
        }

        Mutation GetMutationWithKeys() =>
            request.Mutations.FirstOrDefault(mutation =>
                mutation.OperationCase != Mutation.OperationOneofCase.Delete ||
                (mutation.Delete?.KeySet is not null &&
                    mutation.Delete.KeySet.Keys.Count > 0));

    }

    /// <summary>
    /// Executes a Rollback RPC asynchronously.
    /// </summary>
    /// <param name="request">The rollback request. Must not be null. The request will be modified with session and transaction details
    /// from this object.</param>
    /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task RollbackAsync(RollbackRequest request, CallSettings callSettings) =>
        RollbackAsync(request, callSettings, disposing: false);

    private Task RollbackAsync(RollbackRequest request, CallSettings callSettings, bool disposing)
    {
        if (!disposing)
        {
            CheckNotDisposed();
        }
        GaxPreconditions.CheckNotNull(request, nameof(request));

        request.SessionAsSessionName = SessionName;

        return ExecuteMaybeWithTransactionSelectorAsync(
            transactionSelectorSetter: SetCommandTransaction,
            commandAsync: RollbackAsync,
            inlinedTransactionExtractor: null, // Rollback does not support inline transactions.
            skipTransactionCreation: true, // If there's no transaction by the time roll back is called, we fail, we don't need to create one.
            mutation: null,
            transactionTag: null,
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
                    throw new InvalidOperationException("Cannot roll back a managed transaction with no associated Spanner transaction");
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

            await _client.RollbackAsync(request, callSettings).ConfigureAwait(false);
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
            mutation: null,
            transactionTag: null,
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
            if (request.Transaction is null)
            {
                throw new InvalidOperationException("Cannot call PartitionReadOrQueryAsync with no associated transaction.");
            }

            return request.PartitionAsync(_client, callSettings);
        }

        Transaction GetInlinedTransaction(PartitionResponse response) => response?.Transaction;
    }

    /// <summary>
    /// Creates a <see cref="ReliableStreamReader"/> for the given request.
    /// </summary>
    /// <param name="request">
    /// The read request. Must not be null.
    /// Will be modified to include session information.
    /// May be modified to include transaction and directed read options information.
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
    /// Will be modified to include session information.
    /// May be modified to include transaction and directed read options information.
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
        _client.MaybeApplyRouteToLeaderHeader(ref callSettings, _transactionOptions.ModeCase);
        MaybeApplyDirectedReadOptions(request.UnderlyingRequest);

        ResultStream stream = new ResultStream(_client, request, this, callSettings);
        return new ReliableStreamReader(stream, _client.Settings.Logger);
    }

    /// <summary>
    /// Executes an ExecuteSql RPC asynchronously.
    /// </summary>
    /// <param name="request">The query request. Must not be null.
    /// Will be modified to include session information.
    /// May be modified to include transaction and directed read options information.
        /// </param>
    /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
    /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
    public Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallSettings callSettings)
    {
        CheckNotDisposed();
        GaxPreconditions.CheckNotNull(request, nameof(request));

        request.SessionAsSessionName = SessionName;
        var cancellationToken = callSettings?.CancellationToken ?? default;

        return ExecuteMaybeWithTransactionSelectorAsync(
            transactionSelectorSetter: SetCommandTransaction,
            commandAsync: ExecuteSqlAsync,
            inlinedTransactionExtractor: GetInlinedTransaction,
            skipTransactionCreation: false,
            mutation: null,
            transactionTag: request.RequestOptions?.TransactionTag,
            cancellationToken);

        void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

        async Task<ResultSet> ExecuteSqlAsync()
        {
            _client.MaybeApplyRouteToLeaderHeader(ref callSettings, _transactionOptions.ModeCase);
            MaybeApplyDirectedReadOptions(request);
            var response = await _client.ExecuteSqlAsync(request, callSettings).ConfigureAwait(false);
            await MaybeUpdatePrecommitToken(response.PrecommitToken, cancellationToken).ConfigureAwait(false);
            return response;
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
        var cancellationToken = callSettings?.CancellationToken ?? default;

        return ExecuteMaybeWithTransactionSelectorAsync(
            transactionSelectorSetter: SetCommandTransaction,
            commandAsync: ExecuteBatchDmlAsync,
            inlinedTransactionExtractor: GetInlinedTransaction,
            skipTransactionCreation: false,
            mutation: null,
            transactionTag: request.RequestOptions?.TransactionTag,
            cancellationToken);

        void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

        async Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync()
        {
            var response = await _client.ExecuteBatchDmlAsync(request, callSettings).ConfigureAwait(false);
            await MaybeUpdatePrecommitToken(response.PrecommitToken, cancellationToken).ConfigureAwait (false);
            return response;
        }

        Transaction GetInlinedTransaction(ExecuteBatchDmlResponse response) => response?.ResultSets?.FirstOrDefault()?.Metadata?.Transaction;
    }

    private void MaybeApplyDirectedReadOptions(IReadOrQueryRequest request)
    {
        if (_transactionOptions.ModeCase == ModeOneofCase.ReadOnly // Directed reads apply only to single use or read only transactions. Single use are read only.
            && request.DirectedReadOptions is null) // Request specific options have priority over client options.
        {
            request.DirectedReadOptions = _client.Settings.DirectedReadOptions;
        }

        // We don't validate that DirectedReadOptions is null when this is a non-read-only transaction.
        // We just pass the request along as we received it. The service should fail if there are options set.
        // This was agreed as part of the client library desing.
    }

    internal async Task MaybeUpdatePrecommitToken(MultiplexedSessionPrecommitToken newToken, CancellationToken cancellationToken)
    {
        // Check outside the semaphore as much as possible.
        // If the new token secuence number is not greater than the current one, we return.
        // Note that if we haven't stored a token yet the secuence number comparison will be false.
        if (newToken == null || newToken.SeqNum <= _precommitToken?.SeqNum)
        {
            return;
        }
        try
        {
            await _precommitTokenSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            if (_precommitToken is null || _precommitToken.SeqNum < newToken.SeqNum)
            {
                _precommitToken = newToken;
            }
        }
        finally
        {
            _precommitTokenSemaphore.Release();
        }
    }

    private async Task<MultiplexedSessionPrecommitToken> GetPrecommitTokenAsync(CancellationToken cancellationToken)
    {
        try
        {
            await _precommitTokenSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
            return _precommitToken;
        }
        finally
        {
            _precommitTokenSemaphore.Release();
        }
    }
}
