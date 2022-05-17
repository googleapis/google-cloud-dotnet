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
using Google.Api.Gax.Grpc;
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
    /// Represents a SQL transaction to be made in a Spanner database.
    /// A transaction in Cloud Spanner is a set of reads and writes that execute
    /// atomically at a single logical point in time across columns, rows, and
    /// tables in a database.
    /// </summary>
    public sealed class SpannerTransaction : DbTransaction, ISpannerTransaction
    {
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private DisposeBehavior _disposeBehavior = DisposeBehavior.ReleaseToPool;
        private bool _disposed = false;

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
        public TransactionMode Mode { get; }

        private readonly PooledSession _session;

        private int _commitTimeout;

        // Note: We use seconds here to follow the convention set by DbCommand.CommandTimeout.
        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to <see cref="Commit()"/> 
        /// or <see cref="Rollback"/> and generating an error.
        /// Defaults to the timeout from the connection string. A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </summary>
        public int CommitTimeout
        {
            get => _commitTimeout;
            set => _commitTimeout = GaxPreconditions.CheckArgumentRange(value, nameof(value), 0, int.MaxValue);
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
        public TimestampBound TimestampBound { get; }

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

        private Priority _commitPriority;

        /// <summary>
        /// The RPC priority to use for the commit RPC of this transaction. This can only be set for read/write transactions.
        /// This priority is not used for commands that are executed on this transaction. Use <see cref="SpannerCommand.Priority"/>
        /// to set the priority of commands. The default priority is Unspecified.
        /// </summary>
        public Priority CommitPriority
        {
            get => _commitPriority;
            set
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "Commit priority cannot be set on a read-only transaction");
                _commitPriority = value;
            }
        }

        private string _tag;

        /// <summary>
        /// The transaction tag to use for this transaction. This can only be set for read/write transactions,
        /// and must be set before any statements are executed on the transaction.
        /// </summary>
        public string Tag
        {
            get => _tag;
            set
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "Transaction tag cannot be set on a read-only transaction");
                GaxPreconditions.CheckState(!_hasExecutedStatements, "Transaction tag can only be set before any statements have been executed on the transaction");
                _tag = value;
            }
        }

        internal SpannerTransaction(
            SpannerConnection connection,
            TransactionMode mode,
            PooledSession session,
            TimestampBound timestampBound)
        {
            SpannerConnection = GaxPreconditions.CheckNotNull(connection, nameof(connection));
            CommitTimeout = SpannerConnection.Builder.Timeout;
            LogCommitStats = SpannerConnection.LogCommitStats;
            Mode = mode;
            _session = GaxPreconditions.CheckNotNull(session, nameof(session));
            TimestampBound = timestampBound;
        }

        /// <summary>
        /// Returns true if this transaction is being used by multiple <see cref="SpannerConnection"/> objects.
        /// <see cref="SpannerCommand.GetReaderPartitionsAsync"/> will automatically mark the transaction as shared
        /// because it is expected that you will be distributing the read among several tasks or processes.
        /// </summary>
        public bool Shared { get; internal set; }

        /// <summary>
        /// Specifies how resources are treated when <see cref="Dispose"/> is called.
        /// The default behavior of <see cref="DisposeBehavior.ReleaseToPool"/> will cause transactional resources
        /// to be sent back into a shared pool for re-use.
        /// Shared transactions may only set this value to either <see cref="DisposeBehavior.CloseResources"/> to close
        /// resources or <see cref="DisposeBehavior.Detach"/> to detach from the resources.
        /// A shared transaction must have one process choose <see cref="DisposeBehavior.CloseResources"/>
        /// to avoid leaks of transactional resources.
        /// </summary>
        public DisposeBehavior DisposeBehavior
        {
            get => _disposeBehavior;
            set => _disposeBehavior = GaxPreconditions.CheckEnumValue(value, nameof(DisposeBehavior));
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
        public SpannerBatchCommand CreateBatchDmlCommand() => new SpannerBatchCommand(this);

        internal Task<IEnumerable<ByteString>> GetPartitionTokensAsync(
            ReadOrQueryRequest request,
            long? partitionSizeBytes,
            long? maxPartitions,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(Mode == TransactionMode.ReadOnly, "You can only call GetPartitions on a read-only transaction.");
            _hasExecutedStatements = true;

            // Calling this method marks the used transaction as "shared" - but does not set
            // DisposeBehavior to any value. This will cause an exception during dispose that tells the developer
            // that they need to handle this condition by explicitly setting DisposeBehavior to some value.
            Shared = true;

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
            CancellationToken cancellationToken,
            int timeoutSeconds) // Ignored
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            CheckCompatibleMode(TransactionMode.ReadOnly);
            _hasExecutedStatements = true;
            // We're not making any Spanner requests here, so we don't need profiling or error translation.
            var callSettings = SpannerConnection.CreateCallSettings(
                request.GetCallSettings,
                cancellationToken);
            return Task.FromResult(request.ExecuteReadOrQueryStreamReader(_session, callSettings));
        }

        Task<long> ISpannerTransaction.ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            CheckCompatibleMode(TransactionMode.ReadWrite);
            GaxPreconditions.CheckNotNull(request, nameof(request));
            _hasExecutedStatements = true;
            request.Seqno = Interlocked.Increment(ref _lastDmlSequenceNumber);
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                // Note: ExecuteSql would work, but by using a streaming call we enable potential future scenarios
                // where the server returns interim resume tokens to avoid timeouts.
                var callSettings = SpannerConnection.CreateCallSettings(settings => settings.ExecuteStreamingSqlSettings, timeoutSeconds, cancellationToken);
                using (var reader = _session.ExecuteSqlStreamReader(request, callSettings))
                {
                    Value value = await reader.NextAsync(cancellationToken).ConfigureAwait(false);
                    if (value != null)
                    {
                        throw new SpannerException(ErrorCode.Internal, "DML returned results unexpectedly.");
                    }

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

        Task<IEnumerable<long>> ISpannerTransaction.ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            CheckCompatibleMode(TransactionMode.ReadWrite);
            GaxPreconditions.CheckNotNull(request, nameof(request));
            _hasExecutedStatements = true;
            request.Seqno = Interlocked.Increment(ref _lastDmlSequenceNumber);
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
        public void Commit(out DateTime timestamp) => timestamp = Task.Run(() => CommitAndReturnTimestampAsync(default)).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public
#if NETSTANDARD2_1_OR_GREATER
            override
#endif
            Task CommitAsync(CancellationToken cancellationToken = default) => CommitAndReturnTimestampAsync(cancellationToken);

        /// <summary>
        /// Commits the database transaction asynchronously, returning the UTC timestamp when the data was written to the database.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <returns>Returns the UTC timestamp when the data was written to the database.</returns>
        public Task<DateTime> CommitAndReturnTimestampAsync(CancellationToken cancellationToken = default)
        {
            GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot commit a readonly transaction.");
            var request = new CommitRequest
            { 
                Mutations = { _mutations },
                ReturnCommitStats = LogCommitStats,
                RequestOptions = new RequestOptions { Priority = PriorityConverter.ToProto(CommitPriority), TransactionTag = _tag ?? "" }
            };
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                var callSettings = SpannerConnection.CreateCallSettings(settings => settings.CommitSettings, CommitTimeout, cancellationToken);
                var response = await _session.CommitAsync(request, callSettings).ConfigureAwait(false);
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


        /// <inheritdoc />
        public override void Rollback() => Task.Run(() => RollbackAsync(default)).WaitWithUnwrappedExceptions();

        /// <summary>
        /// Rolls back a transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
#if NET462
        public Task RollbackAsync(CancellationToken cancellationToken = default)
#else
        public override Task RollbackAsync(CancellationToken cancellationToken = default)
#endif
        {
            GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot roll back a readonly transaction.");
            var callSettings = SpannerConnection.CreateCallSettings(settings => settings.RollbackSettings, CommitTimeout, cancellationToken);
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () => _session.RollbackAsync(new RollbackRequest(), callSettings),
                "SpannerTransaction.Rollback", SpannerConnection.Logger);
        }

        /// <summary>
        /// Identifying information about this transaction.
        /// </summary>
        public TransactionId TransactionId => new TransactionId(
            SpannerConnection.ConnectionString,
            _session.SessionName.ToString(),
            _session.TransactionId.ToBase64(),
            TimestampBound);

        /// <summary>
        /// The read timestamp of the read-only transaction if
        /// <see cref="TimestampBound.ReturnReadTimestamp" /> is true, else <c>null</c>.
        /// </summary>
        public Timestamp ReadTimestamp => _session.ReadTimestamp;

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }
            _disposed = true;
            switch (DisposeBehavior)
            {
                case DisposeBehavior.CloseResources:
                    _session.ReleaseToPool(forceDelete: true);
                    break;
                case DisposeBehavior.ReleaseToPool:
                    if (Shared)
                    {
                        // This guard will prevent accidental leaks by forcing the developer to think
                        // about how they want to manage the lifetime of the outer transactional resources.
                        throw new InvalidOperationException(
                            "When calling GetPartitionTokensAsync, you must indicate when transactional resources are released by setting DisposeBehavior=DisposeBehavior.CloseResources or DisposeBehavior.Detach");
                    }
                    _session.ReleaseToPool(forceDelete: false);
                    break;
                // Default for detach or unknown DisposeBehavior is to do nothing.
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
