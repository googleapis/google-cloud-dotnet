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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;

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
        private static long s_transactionCount;
        private readonly SpannerConnection _connection;
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private DisposeBehavior _disposeBehavior = DisposeBehavior.ReleaseToPool;

        /// <inheritdoc />
        public override IsolationLevel IsolationLevel => IsolationLevel.Serializable;

        /// <summary>
        /// Indicates the <see cref="TransactionMode"/> for the transaction.
        /// Cloud Spanner supports two transaction modes:
        /// Locking read-write transactions are the only transaction type that support writing
        /// data into Cloud Spanner. These transactions rely on pessimistic locking and, if
        /// necessary, two-phase commit. Locking read-write transactions may abort, requiring
        /// the application to retry.
        /// Read-only transactions provide guaranteed consistency across several reads,
        /// but do not allow writes. Read-only transactions can be configured to read at
        /// timestamps in the past. Read-only transactions do not need to be committed and
        /// do not take locks.
        /// </summary>
        public TransactionMode Mode { get; }

        private Session Session { get; }

        // Note: We use seconds here to follow the convention set by DbCommand.CommandTimeout.
        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to <see cref="Commit()"/> 
        /// or <see cref="Rollback"/> and generating an error.
        /// Defaults to <see cref="SpannerOptions.Timeout"/> which is 60 seconds.
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </summary>
        public int CommitTimeout { get; set; } = SpannerOptions.Instance.Timeout;

        /// <summary>
        /// Tells Cloud Spanner how to choose a timestamp at which to read the data for read-only
        /// transactions.
        /// The types of timestamp bounds are:
        ///  Strong (the default): read the latest data.
        ///  Bounded staleness: read a version of the data that's no staler than a bound.
        ///  Exact staleness: read the version of the data at an exact timestamp.
        /// </summary>
        public TimestampBound TimestampBound { get; }

        /// <inheritdoc />
        protected override DbConnection DbConnection => _connection;

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

        private Transaction WireTransaction { get; }

        internal SpannerTransaction(
            SpannerConnection connection,
            TransactionMode mode,
            Session session,
            Transaction transaction,
            TimestampBound timestampBound)
        {
            GaxPreconditions.CheckNotNull(connection, nameof(connection));
            GaxPreconditions.CheckNotNull(session, nameof(session));
            GaxPreconditions.CheckNotNull(transaction, nameof(transaction));

            Session = session;
            TimestampBound = timestampBound;
            WireTransaction = transaction;
            _connection = connection;
            Mode = mode;

            Logger.LogPerformanceCounter(
                "Transactions.ActiveCount",
                () => Interlocked.Increment(ref s_transactionCount));
        }

        internal static SpannerTransaction FromTransactionId(SpannerConnection connection, TransactionId transactionId)
        {
            return new SpannerTransaction(
                connection, TransactionMode.ReadOnly, new Session {Name = transactionId.Session},
                new V1.Transaction {Id = ByteString.FromBase64(transactionId.Id)}, transactionId.TimestampBound)
            {
                Shared = true,
                DisposeBehavior = DisposeBehavior.Detach  //this transaction is coming from another process potentially, so we don't auto close it.
            };
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

        private Logger Logger => _connection?.Logger ?? Logger.DefaultLogger;

        internal Task<IEnumerable<ByteString>> GetPartitionTokensAsync(
            ExecuteSqlRequest request,
            long? partitionSizeBytes,
            long? maxPartitions,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            GaxPreconditions.CheckState(
                Mode == TransactionMode.ReadOnly, "You can only call GetPartitions on a readonly transaction.");

            // Calling this method marks the used transaction as "shared" - but does not set
            // DisposeBehavior to any value. This will cause an exception during dispose that tell's the developer
            // that they need to handle this condition by explcitily setting DisposeBehavior to some value.
            Shared = true;

            var partitionRequest = new PartitionQueryRequest
            {
                Sql = request.Sql,
                Params = request.Params,
                PartitionOptions = partitionSizeBytes.HasValue || maxPartitions.HasValue ? new PartitionOptions() : null,
                Transaction = GetTransactionSelector(TransactionMode.ReadOnly),
                Session = Session.Name
            };
            if (partitionSizeBytes.HasValue)
            {
                partitionRequest.PartitionOptions.PartitionSizeBytes = partitionSizeBytes.Value;
            }
            if (maxPartitions.HasValue)
            {
                partitionRequest.PartitionOptions.MaxPartitions = maxPartitions.Value;
            }
            partitionRequest.ParamTypes.Add(request.ParamTypes);

            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    PartitionResponse response = await _connection.SpannerClient.PartitionQueryAsync(
                        partitionRequest,
                        _connection.SpannerClient.Settings.PartitionQuerySettings.WithExpiration(
                            _connection.SpannerClient.Settings.ConvertTimeoutToExpiration(timeoutSeconds)))
                            .ConfigureAwait(false);

                    return response.Partitions.Select(x => x.PartitionToken);
                }, "SpannerTransaction.GetPartitionTokensAsync", Logger);
        }

        Task<int> ISpannerTransaction.ExecuteMutationsAsync(
            List<Mutation> mutations,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(mutations, nameof(mutations));
            CheckCompatibleMode(TransactionMode.ReadWrite);
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
            {
                var taskCompletionSource = new TaskCompletionSource<int>();
                cancellationToken.ThrowIfCancellationRequested();
                lock (_mutations)
                {
                    _mutations.AddRange(mutations);
                }
                taskCompletionSource.SetResult(mutations.Count);
                return taskCompletionSource.Task;
            }, "SpannerTransaction.ExecuteMutations", Logger);
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteQueryAsync(
            ExecuteSqlRequest request,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
            {
                var taskCompletionSource =
                    new TaskCompletionSource<ReliableStreamReader>();
                request.Transaction = GetTransactionSelector(TransactionMode.ReadOnly);
                taskCompletionSource.SetResult(_connection.SpannerClient.GetSqlStreamReader(request, Session, timeoutSeconds));

                return taskCompletionSource.Task;
            }, "SpannerTransaction.ExecuteQuery", Logger);
        }

        /// <inheritdoc />
        public override void Commit() => Commit(out _);

        // Note: it would be nice just to use Commit, but that's taken by the void method.
        /// <summary>
        /// Commits the database transaction synchronously, returning the database timestamp for the commit via <paramref name="timestamp"/>.
        /// </summary>
        /// <param name="timestamp">Returns the UTC timestamp when the data was written to the database.</param>
        public void Commit(out DateTime? timestamp) => timestamp = Task.Run(() => CommitAsync(default)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Commits the database transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <returns>Returns the UTC timestamp when the data was written to the database.</returns>
        public Task<DateTime?> CommitAsync(CancellationToken cancellationToken = default)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    GaxPreconditions.CheckState(
                        Mode != TransactionMode.ReadOnly, "You cannot commit a readonly transaction.");
                    // We allow access to _mutations outside of a lock here because multithreaded
                    // access at this point should be done and only one caller can call commit.
                    var response = await TransactionPool.CommitAsync(
                        WireTransaction, Session, _mutations, CommitTimeout, cancellationToken).ConfigureAwait(false);
                    return response.CommitTimestamp?.ToDateTime();
                }, "SpannerTransaction.Commit", Logger);
        }

        /// <inheritdoc />
        public override void Rollback() => Task.Run(() => RollbackAsync(default)).WaitWithUnwrappedExceptions();

        /// <summary>
        /// Rolls back a transaction asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        public Task RollbackAsync(CancellationToken cancellationToken = default)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
                {
                    GaxPreconditions.CheckState(
                        Mode != TransactionMode.ReadOnly, "You cannot roll back a readonly transaction.");
                    return TransactionPool.RollbackAsync(WireTransaction, Session, CommitTimeout, cancellationToken);
                }, "SpannerTransaction.Rollback", Logger);
        }

        /// <summary>
        /// Identifying information about this transaction.
        /// </summary>
        public TransactionId TransactionId => new TransactionId(
            _connection.ConnectionString, Session.Name,
            WireTransaction.Id.ToBase64(), TimestampBound);


        /// <inheritdoc />
        protected override void Dispose(bool disposing) => DisposeWithClient(null);

        /// <summary>
        /// Disposes the transaction with the given client.
        /// </summary>
        /// <param name="client">The client to use when required, or null to use the connection's client.</param>
        internal void DisposeWithClient(SpannerClient client)
        {
            Logger.LogPerformanceCounter(
                "Transactions.ActiveCount",
                () => Interlocked.Decrement(ref s_transactionCount));
            if (Shared && DisposeBehavior == DisposeBehavior.ReleaseToPool)
            {
                // this guard will prevent accidental leaks by forcing the developer to think
                // about how they want to manage the lifetime of the outer transactional resources.
                throw new InvalidOperationException(
                    "When calling GetPartitionTokensAsync, you must indicate when transactional resources are released by setting DisposeBehavior=DisposeBehavior.CloseResources or DisposeBehavior.Detach");
            }

            if (DisposeBehavior == DisposeBehavior.ReleaseToPool)
            {
                client = client ?? _connection.SpannerClient;
                if (client == null)
                {
                    throw new InvalidOperationException($"Unable to release session; no SpannerClient available. Please check your resource management.");
                }
                _connection.ReleaseSession(Session, client);
            }
            else if (DisposeBehavior == DisposeBehavior.CloseResources)
            {
                //here we close out the session instead of placing it back into the queue in
                //case the developer does something clever like attempting to close it in multiple processes.
                Task.Run(() => SessionPool.Default.CloseAsync(Session));
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

        private TransactionSelector GetTransactionSelector(TransactionMode mode)
        {
            CheckCompatibleMode(mode);
            return new TransactionSelector { Id = WireTransaction.Id };
        }
    }
}
