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
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;

// ReSharper disable UnusedParameter.Local

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

            Logger.LogPerformanceCounter(
                "Transactions.ActiveCount",
                () => Interlocked.Increment(ref s_transactionCount));

            Session = session;
            TimestampBound = timestampBound;
            WireTransaction = transaction;
            _connection = connection;
            Mode = mode;
        }

        Task<int> ISpannerTransaction.ExecuteMutationsAsync(
            List<Mutation> mutations,
            CancellationToken cancellationToken)
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
                }, "SpannerTransaction.ExecuteMutations");
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteQueryAsync(
            ExecuteSqlRequest request,
            CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
                {
                    var taskCompletionSource =
                        new TaskCompletionSource<ReliableStreamReader>();
                    request.Transaction = GetTransactionSelector(TransactionMode.ReadOnly);
                    taskCompletionSource.SetResult(_connection.SpannerClient.GetSqlStreamReader(request, Session));

                    return taskCompletionSource.Task;
                }, "SpannerTransaction.ExecuteQuery");
        }

        /// <inheritdoc />
        public override void Commit()
        {
            if (!Task.Run(CommitAsync).Wait(SpannerOptions.Instance.Timeout))
            {
                throw new TimeoutException("The Commit did not complete in time.");
            }
        }

        /// <summary>
        /// Commits the database transaction asynchronously.
        /// </summary>
        /// <returns>Returns the UTC timestamp when the data was written to the database.</returns>
        public Task<DateTime?> CommitAsync()
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    GaxPreconditions.CheckState(
                        Mode != TransactionMode.ReadOnly, "You cannot commit a readonly transaction.");
                    // We allow access to _mutations outside of a lock here because multithreaded
                    // access at this point should be done and only one caller can call commit.
                    var response = await WireTransaction.CommitAsync(Session, _mutations).ConfigureAwait(false);
                    return response.CommitTimestamp?.ToDateTime();
                }, "SpannerTransaction.Commit");
        }

        /// <inheritdoc />
        public override void Rollback()
        {
            if (!Task.Run(RollbackAsync).Wait(SpannerOptions.Instance.Timeout))
            {
                throw new TimeoutException("The Rollback did not complete in time.");
            }
        }

        /// <summary>
        /// Rolls back a transaction asynchronously.
        /// </summary>
        public Task RollbackAsync()
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                () =>
                {
                    GaxPreconditions.CheckState(
                        Mode != TransactionMode.ReadOnly, "You cannot roll back a readonly transaction.");
                    return WireTransaction.RollbackAsync(Session);
                }, "SpannerTransaction.Rollback");
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            Logger.LogPerformanceCounter(
                "Transactions.ActiveCount",
                () => Interlocked.Decrement(ref s_transactionCount));
            _connection.ReleaseSession(Session);
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
            return new TransactionSelector {Id = WireTransaction.Id};
        }
    }
}
