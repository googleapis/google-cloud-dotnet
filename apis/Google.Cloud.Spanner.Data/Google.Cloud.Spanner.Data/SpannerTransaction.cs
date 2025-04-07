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

using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Base class for SpannerTransaction, used for compatibility purposes with <see cref="DbTransaction"/>.
    /// (This class is able to override a new method added to <see cref="DbTransaction"/>, even if it clashes
    /// with an existing method declaration in <see cref="SpannerTransaction"/>.)
    /// </summary>
    public abstract class SpannerTransactionBase : DbTransaction
    {
        // Ensure we only derive from this class within the same assembly.
        private protected SpannerTransactionBase()
        {
        }

        /// <summary>
        /// Commits the database transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public
#if NETSTANDARD2_1_OR_GREATER
        override
#endif
        Task CommitAsync(CancellationToken cancellationToken = default) => ((SpannerTransaction) this).CommitAsync(cancellationToken);
    }

    /// <summary>
    /// Represents a SQL transaction to be made in a Spanner database.
    /// A transaction in Cloud Spanner is a set of reads and writes that execute
    /// atomically at a single logical point in time across columns, rows, and
    /// tables in a database.
    /// </summary>
    public sealed class SpannerTransaction : SpannerTransactionBase, ISpannerTransaction
    {
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private readonly SpannerTransactionCreationOptions _creationOptions;
        // This value will be true if and only if this transaction was created by RetriableTransaction.
        private readonly bool _isRetriable = false;
        private DisposeBehavior _disposeBehavior = DisposeBehavior.Default;
        private int _disposed = 0;
        private int _commited = 0;

        // Flag indicating whether the transaction has executed at least one statement.
        // The TransactionTag may no longer be set once the transaction has executed one
        // or more statements.
        private bool _hasExecutedStatements = false;

        /// <summary>
        /// When executing multiple DML commands in a single transaction, each is given a specific sequence number
        /// to indicate the difference between "apply this DML command twice" and "I'm replaying a request due to a transient failure".
        /// The first request uses a sequence number of 1 to make it clear that it's been set deliberately.
        /// </summary>
        private int _lastDmlSequenceNumber = 0;

        /// <inheritdoc />
        public override IsolationLevel IsolationLevel => IsolationLevel.Serializable;

        /// <summary>
        /// Indicates the <see cref="TransactionMode"/> for the transaction.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cloud Spanner supports two transaction modes:
        /// <list type="bullet">
        /// <item><description>
        /// Locking read-write transactions are the only transaction type that support writing
        /// data into Cloud Spanner. These transactions rely on pessimistic locking and, if
        /// necessary, two-phase commit. Locking read-write transactions may abort, requiring
        /// the application to retry.
        /// </description></item>
        /// <item><description>
        /// Read-only transactions provide guaranteed consistency across several reads,
        /// but do not allow writes. Read-only transactions can be configured to read at
        /// timestamps in the past. Read-only transactions do not need to be committed and
        /// do not take locks.
        /// </description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public TransactionMode Mode => _creationOptions.TransactionMode;

        private readonly PooledSession _session;

        /// <summary>
        /// Options to apply to the transaction after creation, usually before committing the transaction
        /// or before executing the first transactional statement. Won't be null.
        /// </summary>
        /// <remarks>
        /// Even though the value of this property cannot be changed, instances of <see cref="SpannerTransactionOptions"/> are mutable.
        /// This is useful for ORM and similar implementations that depend on ADO.NET for transaction and command
        /// creation, which does not know about these Spanner specific options. These implementations may still
        /// access transaction and commands after creation and change these options.
        /// When a <see cref="SpannerTransaction"/> instance is created, the value supplied for <see cref="SpannerTransactionOptions"/>
        /// will be cloned and assigned to this property, or if none was suplied, a new instance will be created. But accessing this property
        /// on each <see cref="SpannerTransaction"/> instance will always return the same value.
        /// </remarks>
        public SpannerTransactionOptions TransactionOptions { get; }

        // Note: We use seconds here to follow the convention set by DbCommand.CommandTimeout.
        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to <see cref="Commit()"/>
        /// or <see cref="Rollback"/> and generating an error.
        /// Defaults to the timeout from the connection string. A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </summary>
        [Obsolete("Use SpannerTransactionOptions.CommitTimeout instead.")]
        public int CommitTimeout
        {
            get => TransactionOptions.EffectiveCommitTimeout(SpannerConnection);
            set => TransactionOptions.CommitTimeout = value;
        }

        /// <summary>
        /// Tells Cloud Spanner how to choose a timestamp at which to read the data for read-only
        /// transactions.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The types of timestamp bounds are:
        /// <list type="bullet">
        ///   <item><description>Strong (the default): read the latest data.</description></item>
        ///   <item><description>Bounded staleness: read a version of the data that's no staler than a bound.</description></item>
        ///   <item><description>Exact staleness: read the version of the data at an exact timestamp.</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        public TimestampBound TimestampBound => _creationOptions.TimestampBound ?? _creationOptions.TransactionId?.TimestampBound;

        /// <inheritdoc />
        protected override DbConnection DbConnection => SpannerConnection;

        /// <summary>
        /// <see cref="SpannerConnection"/> associated with this transaction.
        /// </summary>
        internal SpannerConnection SpannerConnection { get; }

        internal bool HasMutations
        {
            get
            {
                lock (_mutations)
                {
                    return _mutations.Any();
                }
            }
        }

        /// <summary>
        /// The RPC priority to use for the commit RPC of this transaction. This can only be set for read/write transactions.
        /// This priority is not used for commands that are executed on this transaction. Use <see cref="SpannerCommand.Priority"/>
        /// to set the priority of commands. The default priority is Unspecified.
        /// </summary>
        [Obsolete("Use SpannerTransactionOptions.CommitPriority instead.")]
        public Priority CommitPriority
        {
            get => TransactionOptions.EffectivePriority(Mode);
            set
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "Commit priority cannot be set on a read-only transaction");
                TransactionOptions.CommitPriority = value;
            }
        }

        /// <summary>
        /// The transaction tag to use for this transaction. This can only be set for read/write transactions,
        /// and must be set before any statements are executed on the transaction.
        /// </summary>
        [Obsolete("Use SpannerTransactionOptions.Tag instead.")]
        public string Tag
        {
            get => TransactionOptions.EffectiveTag(Mode, _hasExecutedStatements);
            set
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "Transaction tag cannot be set on a read-only transaction");
                GaxPreconditions.CheckState(!_hasExecutedStatements, "Transaction tag can only be set before any statements have been executed on the transaction");
                TransactionOptions.Tag = value;
            }
        }

        internal SpannerTransaction(
            SpannerConnection connection,
            PooledSession session,
            SpannerTransactionCreationOptions creationOptions,
            SpannerTransactionOptions transactionOptions,
            bool isRetriable)
        {
            SpannerConnection = GaxPreconditions.CheckNotNull(connection, nameof(connection));
            LogCommitStats = SpannerConnection.LogCommitStats;
            _session = GaxPreconditions.CheckNotNull(session, nameof(session));
            _creationOptions = GaxPreconditions.CheckNotNull(creationOptions, nameof(creationOptions));
            TransactionOptions = transactionOptions is null ? new SpannerTransactionOptions() : new SpannerTransactionOptions(transactionOptions);
            _isRetriable = isRetriable;
        }

        /// <summary>
        /// Whether this transaction is detached or not.
        /// A detached transaction's resources are not pooled, so the transaction may be
        /// shared across processes for instance, for partitioned reads.
        /// </summary>
        public bool IsDetached => _session.IsDetached;

        /// <summary>
        /// Specifies how resources are treated when <see cref="Dispose"/> is called.
        /// Defaults to <see cref="DisposeBehavior.Default"/>. For a pooled transaction, 
        /// <see cref="DisposeBehavior.Default"/> will cause transactional resources
        /// to be sent back into a shared pool for re-use.
        /// For a detached transaction the default behaviour is to do nothing with transactional resources.
        /// If set to <see cref="DisposeBehavior.CloseResources"/> all transactional resource will be closed.
        /// A detached transaction must have one process choose <see cref="DisposeBehavior.CloseResources"/>
        /// to avoid leaks of transactional resources.
        /// </summary>
        public DisposeBehavior DisposeBehavior
        {
            get => _disposeBehavior;
            set
            {
                CheckNotDisposed();
                _disposeBehavior = GaxPreconditions.CheckEnumValue(value, nameof(DisposeBehavior));
            }
        }

        /// <summary>
        /// Specifies whether this transaction should request commit statistics from the backend
        /// and log these. This property is by default equal to the value set on the SpannerConnection
        /// of this transaction, but can be overridden for a specific transaction.
        /// </summary>
        public bool LogCommitStats { get; set; }

        /// <summary>
        /// Creates a new <see cref="SpannerBatchCommand"/> to execute batched DML statements within this transaction.
        /// You can add commands to the batch by using <see cref="SpannerBatchCommand.Add(SpannerCommand)"/>,
        /// <see cref="SpannerBatchCommand.Add(SpannerCommandTextBuilder, SpannerParameterCollection)"/>
        /// and <see cref="SpannerBatchCommand.Add(string, SpannerParameterCollection)"/>.
        /// </summary>
        public SpannerBatchCommand CreateBatchDmlCommand()
        {
            CheckNotDisposed();
            return new SpannerBatchCommand(this);
        }

        internal Task<IEnumerable<ByteString>> GetPartitionTokensAsync(
            ReadOrQueryRequest request,
            long? partitionSizeBytes,
            long? maxPartitions,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(Mode == TransactionMode.ReadOnly, "You can only call GetPartitions on a read-only transaction.");
            GaxPreconditions.CheckState(IsDetached, "You can only call GetPartitions on a detached transaction.");
            _hasExecutedStatements = true;

            ApplyTransactionTag(request);

            var partitionRequest = request.ToPartitionReadOrQueryRequest(partitionSizeBytes, maxPartitions);
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
                {
                    var callSettings = SpannerConnection.CreateCallSettings(
                        partitionRequest.GetCallSettings,
                        timeoutSeconds, cancellationToken);
                    var response = await partitionRequest.PartitionReadOrQueryAsync(_session, callSettings).ConfigureAwait(false);
                    return response.Partitions.Select(x => x.PartitionToken);
                },
                "SpannerTransaction.GetPartitionTokensAsync", SpannerConnection.Logger);
        }

        Task<int> ISpannerTransaction.ExecuteMutationsAsync(
            List<Mutation> mutations,
            CancellationToken cancellationToken,
            int timeoutSeconds /* ignored */)
        {
            CheckNotDisposed();
            CheckCompatibleMode(TransactionMode.ReadWrite);
            _hasExecutedStatements = true;
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
            {
                var taskCompletionSource = new TaskCompletionSource<int>();
                cancellationToken.ThrowIfCancellationRequested();
                lock (_mutations)
                {
                    _mutations.AddRange(mutations);
                }
                taskCompletionSource.SetResult(mutations.Count);
                return taskCompletionSource.Task;
            }, "SpannerTransaction.ExecuteMutations", SpannerConnection.Logger);
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteReadOrQueryAsync(
            ReadOrQueryRequest request,
            CancellationToken cancellationToken)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckNotNull(request, nameof(request));
            CheckCompatibleMode(TransactionMode.ReadOnly);
            _hasExecutedStatements = true;

            ApplyTransactionTag(request);

            // We're not making any Spanner requests here, so we don't need profiling or error translation.
            var callSettings = SpannerConnection.CreateCallSettings(
                request.GetCallSettings,
                cancellationToken);
            return Task.FromResult(request.ExecuteReadOrQueryStreamReader(_session, callSettings));
        }

        Task<long> ISpannerTransaction.ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            CheckNotDisposed();
            CheckCompatibleMode(TransactionMode.ReadWrite);
            GaxPreconditions.CheckNotNull(request, nameof(request));
            _hasExecutedStatements = true;
            request.Seqno = Interlocked.Increment(ref _lastDmlSequenceNumber);
            ApplyTransactionTag(request.RequestOptions);
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                // Note: ExecuteSql would work, but by using a streaming call we enable potential future scenarios
                // where the server returns interim resume tokens to avoid timeouts.
                var callSettings = SpannerConnection.CreateCallSettings(settings => settings.ExecuteStreamingSqlSettings, timeoutSeconds, cancellationToken);
                using (var reader = _session.ExecuteSqlStreamReader(request, callSettings))
                {
                    await reader.NextAsync(cancellationToken).ConfigureAwait(false);
                    var stats = reader.Stats;

                    if (stats == null)
                    {
                        throw new SpannerException(ErrorCode.Internal, "DML completed without statistics.");
                    }
                    switch (stats.RowCountCase)
                    {
                        case ResultSetStats.RowCountOneofCase.RowCountExact:
                            return stats.RowCountExact;
                        case ResultSetStats.RowCountOneofCase.RowCountLowerBound:
                            return stats.RowCountLowerBound;
                        default:
                            throw new SpannerException(ErrorCode.Internal, $"Unknown row count type: {stats.RowCountCase}");
                    }
                }
            }, "SpannerTransaction.ExecuteDml", SpannerConnection.Logger);
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteDmlReaderAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            CheckNotDisposed();
            CheckCompatibleMode(TransactionMode.ReadWrite);
            GaxPreconditions.CheckNotNull(request, nameof(request));
            _hasExecutedStatements = true;
            request.Seqno = Interlocked.Increment(ref _lastDmlSequenceNumber);
            ApplyTransactionTag(request.RequestOptions);
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                var callSettings = SpannerConnection.CreateCallSettings(settings => settings.ExecuteStreamingSqlSettings, timeoutSeconds, cancellationToken);
                using var reader = _session.ExecuteSqlStreamReader(request, callSettings);
                await reader.EnsureInitializedAsync(cancellationToken).ConfigureAwait(false);
                return reader;
            }, "SpannerTransaction.ExecuteDmlReader", SpannerConnection.Logger);
        }

        Task<IEnumerable<long>> ISpannerTransaction.ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            CheckNotDisposed();
            CheckCompatibleMode(TransactionMode.ReadWrite);
            GaxPreconditions.CheckNotNull(request, nameof(request));
            _hasExecutedStatements = true;
            request.Seqno = Interlocked.Increment(ref _lastDmlSequenceNumber);
            ApplyTransactionTag(request.RequestOptions);
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                var callSettings = SpannerConnection.CreateCallSettings(settings => settings.ExecuteBatchDmlSettings, timeoutSeconds, cancellationToken);
                ExecuteBatchDmlResponse response = await _session.ExecuteBatchDmlAsync(request, callSettings).ConfigureAwait(false);
                IEnumerable<long> result = response.ResultSets.Select(rs => rs.Stats.RowCountExact);
                // Work around an issue with the emulator, which can return an ExecuteBatchDmlResponse without populating a status.
                // TODO: Remove this when the emulator has been fixed, although it does no harm if it stays longer than strictly necessary.
                if (response.Status is null)
                {
                    response.Status = new Rpc.Status { Code = (int) Rpc.Code.Ok };
                }

                if (response.Status.Code == (int) Rpc.Code.Ok)
                {
                    return result;
                }
                else
                {
                    throw new SpannerBatchNonQueryException(response.Status, result);
                }
            }, "SpannerTransaction.ExecuteBatchDml", SpannerConnection.Logger);
        }

        /// <inheritdoc />
        public override void Commit() => Commit(out _);

        // Note: it would be nice just to use Commit, but that's taken by the void method.
        /// <summary>
        /// Commits the database transaction synchronously, returning the database timestamp for the commit via <paramref name="timestamp"/>.
        /// </summary>
        /// <param name="timestamp">Returns the UTC timestamp when the data was written to the database.</param>
        public void Commit(out DateTime timestamp) => timestamp = Task.Run(() => CommitAsync(default)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Commits the database transaction asynchronously, returning the commit timestamp.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <returns>Returns the UTC timestamp when the data was written to the database.</returns>
        public new Task<DateTime> CommitAsync(CancellationToken cancellationToken = default)
        {
            CheckNotDisposed();
            GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot commit a readonly transaction.");

            var request = new CommitRequest
            {
                Mutations = { _mutations },
                ReturnCommitStats = LogCommitStats,
                RequestOptions = BuildCommitRequestOptions(),
                MaxCommitDelay = TransactionOptions.MaxCommitDelayDuration,
            };

            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                var callSettings = SpannerConnection.CreateCallSettings(
                    settings => settings.CommitSettings, TransactionOptions.EffectiveCommitTimeout(SpannerConnection), cancellationToken);
                var response = await _session.CommitAsync(request, callSettings).ConfigureAwait(false);
                Interlocked.Exchange(ref _commited, 1);
                // We dispose of the SpannerTransaction to inmediately release the session to the pool when possible.
                Dispose();
                if (response.CommitTimestamp == null)
                {
                    throw new SpannerException(ErrorCode.Internal, "Commit succeeded, but returned a response with no commit timestamp");
                }
                if (LogCommitStats)
                {
                    SpannerConnection.Logger.LogCommitStats(request, response);
                }
                return response.CommitTimestamp.ToDateTime();
            },
            "SpannerTransaction.Commit", SpannerConnection.Logger);
        }
        private RequestOptions BuildCommitRequestOptions()
        {
            var options = new RequestOptions
            {
                Priority = PriorityConverter.ToProto(TransactionOptions.EffectivePriority(Mode)),
            };
            ApplyTransactionTag(options);
            return options;
        }

        private void ApplyTransactionTag(ReadOrQueryRequest readOrQueryRequest)
        {
            var options = readOrQueryRequest.IsQuery
                ? readOrQueryRequest.ExecuteSqlRequest.RequestOptions
                : readOrQueryRequest.ReadRequest.RequestOptions;
            ApplyTransactionTag(options);
        }

        private void ApplyTransactionTag(RequestOptions options) =>
            options.TransactionTag = TransactionOptions.EffectiveTag(Mode, _hasExecutedStatements);

        /// <inheritdoc />
        public override void Rollback() => Task.Run(() => RollbackAsync(default)).WaitWithUnwrappedExceptions();

        /// <summary>
        /// Rolls back a transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
#if NET462
        public async Task RollbackAsync(CancellationToken cancellationToken = default)
#else
        public override async Task RollbackAsync(CancellationToken cancellationToken = default)
#endif
        {
            CheckNotDisposed();
            GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot roll back a readonly transaction.");
            var callSettings = SpannerConnection.CreateCallSettings(
                settings => settings.RollbackSettings, TransactionOptions.EffectiveCommitTimeout(SpannerConnection), cancellationToken);
            await  ExecuteHelper.WithErrorTranslationAndProfiling(
                () => _session.RollbackAsync(new RollbackRequest(), callSettings),
                "SpannerTransaction.Rollback", SpannerConnection.Logger).ConfigureAwait(false);
            Dispose();
        }

        /// <summary>
        /// Identifying information about this transaction.
        /// </summary>
        public TransactionId TransactionId => new TransactionId(
            SpannerConnection.ConnectionString,
            _session.SessionName.ToString(),
            _session.TransactionId?.ToBase64(),
            TimestampBound);

        /// <summary>
        /// The read timestamp of the read-only transaction if
        /// <see cref="TimestampBound.ReturnReadTimestamp" /> is true, else <c>null</c>.
        /// </summary>
        public Timestamp ReadTimestamp => _session.ReadTimestamp;

        private void CheckNotDisposed()
        {
            if (Interlocked.CompareExchange(ref _disposed, 0, 0) == 1)
            {
                throw new ObjectDisposedException("This transaction has been disposed and cannot be reused.");
            }
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (Interlocked.Exchange(ref _disposed, 1) == 1)
            {
                return;
            }

            if (_isRetriable && Interlocked.CompareExchange(ref _commited, 0, 0) == 0)
            {
                // If this transaction is being used by RetriableTransaction and is not yet commited,
                // we want to dispose of this instance but we don't want to do anything with the session,
                // as the RetriableTransaction will attempt to reuse it with a fresh transaction.
                // If acquiring a fresh transaction with the existing session fails, the session will be disposed
                // and a new one with a fresh transaction will be obtained.
                // If acquiring a fresh transaction succeeds, then the session will be disposed after the RetriableTransaction
                // succeeds or we have stopped retrying.
                return;
            }

            switch (DisposeBehavior)
            {
                case DisposeBehavior.CloseResources:
                    _session.ReleaseToPool(forceDelete: true);
                    break;
                case DisposeBehavior.Default:
                    // This is a no-op for a detached session.
                    // We don't have to make a distinction here.
                    _session.ReleaseToPool(forceDelete: false);
                    break;
                default:
                    // Default for unknown DisposeBehavior is to do nothing.
                    break;
            }
        }

        private void CheckCompatibleMode(TransactionMode mode)
        {
            switch (mode)
            {
                case TransactionMode.ReadOnly:
                {
                    GaxPreconditions.CheckState(
                        Mode == TransactionMode.ReadOnly || Mode == TransactionMode.ReadWrite,
                        "You can only execute reads on a ReadWrite or ReadOnly Transaction!");
                }
                    break;
                case TransactionMode.ReadWrite:
                {
                    GaxPreconditions.CheckState(
                        Mode == TransactionMode.ReadWrite,
                        "You can only execute read/write commands on a ReadWrite Transaction!");
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }
    }
}
