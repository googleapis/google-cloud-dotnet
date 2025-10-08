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

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ManagedTransaction
    {
        private readonly ManagedSession _multiplexSession;
        private Transaction _transaction;
        private readonly object _transactionCreationTaskLock = new object();
        private Task _transactionCreationTask;
        private readonly object _precommitTokenUpdateLock = new object();

        /// <summary>
        /// The name of the session. This is never null.
        /// </summary>
        public SessionName SessionName => _multiplexSession.SessionName;

        /// <summary>
        /// The Spanner session resource associated to this pooled session.
        /// Won't be null.
        /// </summary>
        internal Session Session => _multiplexSession.Session;

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

        private SpannerClient Client => _multiplexSession.Client;

        /// <summary>
        /// Whether the transaction associated to this session is single use or not.
        /// If this is true then <see cref="TransactionOptions"/> will be <see cref="TransactionOptions.ModeOneofCase.ReadOnly"/>
        /// and <see cref="TransactionId"/> will be null.
        /// </summary>
        internal bool SingleUseTransaction { get; }

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
        /// The read timestamp of the transaction. May be null.
        /// </summary>
        /// <remarks>
        /// Will be set iif a transaction has been started and <see cref="TransactionOptions"/> represents read-only options
        /// with <see cref="Types.ReadOnly.ReturnReadTimestamp"/> set to true
        /// or if this session was created using <see cref="SessionPool.CreateDetachedSession(SessionName, ByteString, ModeOneofCase, Timestamp)"/>
        /// and a value was provided for the <see cref="Timestamp"/> parameter.
        /// </remarks>
        public Timestamp ReadTimestamp => Interlocked.CompareExchange(ref _transaction, null, null)?.ReadTimestamp;

        // internal for testing
        internal MultiplexedSessionPrecommitToken PrecommitToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="multiplexSession"></param>
        /// <param name="transactionId"></param>
        /// <param name="transactionOptions"></param>
        /// <param name="singleUseTransaction"></param>
        /// <param name="readTimestamp"></param>
        public ManagedTransaction(ManagedSession multiplexSession, ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp)
        {
            _multiplexSession = multiplexSession;

            TransactionOptions = transactionOptions?.Clone() ?? new TransactionOptions();

            GaxPreconditions.CheckArgument(
                TransactionOptions.ModeCase == ModeOneofCase.ReadOnly || !singleUseTransaction,
                nameof(singleUseTransaction),
                "Single use transactions are only supported for read-only transactions.");
            GaxPreconditions.CheckArgument(
                transactionId is null || TransactionOptions.ModeCase != ModeOneofCase.None,
                nameof(transactionOptions),
                $"No transaction options were specified for the given transasaction ID {transactionId is null}, {transactionId?.ToBase64()}, {TransactionOptions.ModeCase}.");
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
        }

        internal ManagedTransaction WithTransaction(ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp = null)
        {
            return new ManagedTransaction(_multiplexSession, transactionId, transactionOptions, singleUseTransaction, readTimestamp);
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
        /// <param name="mutationKey"></param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        /// <returns>A task whose result will be the result from having executed <paramref name="commandAsync"/>.</returns>
        internal async Task<TResponse> ExecuteMaybeWithTransactionSelectorAsync<TResponse>(
            Action<TransactionSelector> transactionSelectorSetter,
            Func<Task<TResponse>> commandAsync,
            Func<TResponse, Transaction> inlinedTransactionExtractor,
            bool skipTransactionCreation,
            CancellationToken cancellationToken,
            Mutation mutationKey = null)
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
                Transaction transaction = await BeginTransactionAsync(cancellationToken, mutationKey).ConfigureAwait(false);
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
                    throw new InvalidOperationException("A transaction has already been set on this instance. This is a bug in library code.");
                }
            }

            async Task<Transaction> BeginTransactionAsync(CancellationToken cancellationToken, Mutation mutationKey = null)
            {
                var request = new BeginTransactionRequest
                {
                    Options = TransactionOptions,
                    SessionAsSessionName = SessionName,
                    MutationKey = mutationKey
                };
                var callSettings = Client.Settings.BeginTransactionSettings
                    .WithExpiration(Expiration.FromTimeout(_multiplexSession.Options.Timeout))
                    .WithCancellationToken(cancellationToken);

                Transaction response = await RecordSuccessAndExpiredSessions(Client.BeginTransactionAsync(request, callSettings)).ConfigureAwait(false);
                UpdatePrecommitToken(response.PrecommitToken);

                return response;
            }
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
            MaybeWaitOnSessionRefresh();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;
            request.PrecommitToken = FetchPrecommitToken();

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: CommitAsync,
                inlinedTransactionExtractor: null, // Commit does not support inline transactions.
                skipTransactionCreation: request.Mutations.Count == 0, // If there are only mutations we won't have a transaction but we need one.
                callSettings?.CancellationToken ?? default,
                // Multiplex sessions needs a mutation key in transaction create for a purely mutation based transaction
                mutationKey: request.Mutations.Count > 0 ? request.Mutations.ElementAt(0) : null);

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
                        throw new InvalidOperationException("Cannot commit with no associated transaction");
                }
            }

            async Task<CommitResponse> CommitAsync()
            {
                // If a transaction had been started, by now SetTransaction should have been called with a transaction ID.
                // If not, there's an attempt to commit a non-existent transaction.
                if (request.TransactionId is null || request.TransactionId.IsEmpty)
                {
                    throw new InvalidOperationException("Cannot commit without an associated transaction. " +
                        "A transaction has not been acquired because no command execution has been attempted.");
                }

                const int MaxRetries = 2; // Allow up to 2 attempts: the initial attempt plus one retry.
                CommitResponse finalResponse;

                // Initial attempt
                finalResponse = await ExecuteCommitOnceAsync(request, callSettings).ConfigureAwait(false);

                for (int retryAttempt = 1; retryAttempt < MaxRetries; retryAttempt++)
                {
                    // Check if the server signaled for a retry *after* the initial attempt
                    if (finalResponse.MultiplexedSessionRetryCase != CommitResponse.MultiplexedSessionRetryOneofCase.PrecommitToken)
                    {
                        // No retry token received, exit the loop and return the last response.
                        return finalResponse;
                    }

                    // --- Retry Logic ---
                    // Fetch latest precommit token returned in the earlier response for the retry
                    // Execute the commit call again. The result will be stored in finalResponse.
                    finalResponse = await ExecuteCommitOnceAsync(request, callSettings).ConfigureAwait(false);
                }

                // After two attempts (initial + one retry), check if the server *still* signals for another retry.
                // This handles the third time the token is set (after the second execution).
                if (finalResponse.MultiplexedSessionRetryCase == CommitResponse.MultiplexedSessionRetryOneofCase.PrecommitToken)
                {
                    throw new InvalidOperationException("Unexpected MultiplexedSessionRetryOneofCase found on response after retry.");
                }

                return finalResponse;

                async Task<CommitResponse> ExecuteCommitOnceAsync(CommitRequest request, CallSettings callSettings)
                {
                    // The original logic of the Commit call and session updates
                    request.PrecommitToken = FetchPrecommitToken();
                    CommitResponse response = await RecordSuccessAndExpiredSessions(Client.CommitAsync(request, callSettings)).ConfigureAwait(false);
                    UpdatePrecommitToken(response.PrecommitToken);
                    return response;
                }
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
            MaybeWaitOnSessionRefresh();
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
                        throw new InvalidOperationException("Cannot roll back with no associated transaction");
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
                //MarkAsCommittedOrRolledBack();
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
            MaybeWaitOnSessionRefresh();
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
                if (request.Transaction is null)
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
            MaybeWaitOnSessionRefresh();
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
            MaybeWaitOnSessionRefresh();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: ExecuteSqlAsync,
                inlinedTransactionExtractor: GetInlinedTransaction,
                skipTransactionCreation: false,
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

            async Task<ResultSet> ExecuteSqlAsync() // TODO: Purva check consequences of making this an async method
            {
                Client.MaybeApplyRouteToLeaderHeader(ref callSettings, TransactionMode);
                MaybeApplyDirectedReadOptions(request);
                ResultSet response = await RecordSuccessAndExpiredSessions(Client.ExecuteSqlAsync(request, callSettings)).ConfigureAwait(false);
                UpdatePrecommitToken(response.PrecommitToken);
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
            MaybeWaitOnSessionRefresh();
            GaxPreconditions.CheckNotNull(request, nameof(request));

            request.SessionAsSessionName = SessionName;

            return ExecuteMaybeWithTransactionSelectorAsync(
                transactionSelectorSetter: SetCommandTransaction,
                commandAsync: ExecuteBatchDmlAsync,
                inlinedTransactionExtractor: GetInlinedTransaction,
                skipTransactionCreation: false,
                callSettings?.CancellationToken ?? default);

            void SetCommandTransaction(TransactionSelector transactionSelector) => request.Transaction = transactionSelector;

            async Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync() // TODO: Purva to check consequence of making this method async
            {
                ExecuteBatchDmlResponse response = await RecordSuccessAndExpiredSessions(Client.ExecuteBatchDmlAsync(request, callSettings)).ConfigureAwait(false);
                UpdatePrecommitToken(response.PrecommitToken);
                return response;
            }

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

        private void MaybeWaitOnSessionRefresh()
        {
            _multiplexSession.MaybeRefreshWithTimePeriodCheck();
        }

        private async Task<T> RecordSuccessAndExpiredSessions<T>(Task<T> task)
        {
            var result = await task.WithSessionExpiryChecking(Session).ConfigureAwait(false);
            return result;
        }

        private async Task RecordSuccessAndExpiredSessions(Task task)
        {
            await task.WithSessionExpiryChecking(Session).ConfigureAwait(false);
        }

        internal void UpdatePrecommitToken(MultiplexedSessionPrecommitToken token)
        {
            lock (_precommitTokenUpdateLock)
            {
                if (PrecommitToken == null || PrecommitToken.SeqNum < token?.SeqNum)
                {
                    PrecommitToken = token;
                }
            }
        }

        internal MultiplexedSessionPrecommitToken FetchPrecommitToken()
        {
            lock (_precommitTokenUpdateLock)
            {
                return PrecommitToken;
            }
        }
    }
}
