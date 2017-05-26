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
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerTransaction : DbTransaction, ISpannerTransaction
    {
        private static long s_transactionCount;
        private readonly SpannerConnection _connection;
        private readonly List<Mutation> _mutations = new List<Mutation>();
        private readonly Transaction _transaction;

        internal SpannerTransaction(SpannerConnection connection, TransactionMode mode, Session session,
            Transaction transaction)
        {
            GaxPreconditions.CheckNotNull(connection, nameof(connection));
            GaxPreconditions.CheckNotNull(session, nameof(session));
            GaxPreconditions.CheckNotNull(transaction, nameof(transaction));

            Logger.LogPerformanceCounter("Transactions.ActiveCount",
                () => Interlocked.Increment(ref s_transactionCount));

            Session = session;
            _transaction = transaction;
            _connection = connection;
            Mode = mode;
        }

        /// <inheritdoc />
        public override IsolationLevel IsolationLevel => IsolationLevel.Serializable;

        /// <summary>
        /// </summary>
        public TransactionMode Mode { get; }

        /// <summary>
        /// </summary>
        public Session Session { get; }

        /// <inheritdoc />
        protected override DbConnection DbConnection => _connection;

        internal IEnumerable<Mutation> Mutations => _mutations;

        Task<int> ISpannerTransaction.ExecuteMutationsAsync(List<Mutation> mutations,
            CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(mutations, nameof(mutations));
            CheckCompatibleMode(TransactionMode.ReadWrite);
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
            {
                var taskCompletionSource = new TaskCompletionSource<int>();
                cancellationToken.ThrowIfCancellationRequested();
                _mutations.AddRange(mutations);
                taskCompletionSource.SetResult(mutations.Count);
                return taskCompletionSource.Task;
            }, "SpannerTransaction.ExecuteMutations");
        }

        Task<ReliableStreamReader> ISpannerTransaction.ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
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
            if (!Task.Run(CommitAsync).Wait(ConnectionPoolOptions.Instance.Timeout))
                throw new TimeoutException("The Commit did not complete in time.");
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Task CommitAsync()
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot commit a readonly transaction.");
                return _transaction.CommitAsync(Session, Mutations);
            }, "SpannerTransaction.Commit");
        }

        /// <inheritdoc />
        public override void Rollback()
        {
            if (!Task.Run(RollbackAsync).Wait(ConnectionPoolOptions.Instance.Timeout))
                throw new TimeoutException("The Rollback did not complete in time.");
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Task RollbackAsync()
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
            {
                GaxPreconditions.CheckState(Mode != TransactionMode.ReadOnly, "You cannot roll back a readonly transaction.");
                return _transaction.RollbackAsync(Session);
            }, "SpannerTransaction.Rollback");
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            Logger.LogPerformanceCounter("Transactions.ActiveCount",
                () => Interlocked.Decrement(ref s_transactionCount));
            _connection.ReleaseSession(Session);
        }

        private void CheckCompatibleMode(TransactionMode mode)
        {
            switch (mode)
            {
                case TransactionMode.ReadOnly:
                {
                    GaxPreconditions.CheckState(Mode == TransactionMode.ReadOnly || Mode == TransactionMode.ReadWrite, "You can only execute reads on a ReadWrite or ReadOnly Transaction!");
                }
                    break;
                case TransactionMode.ReadWrite:
                {
                    GaxPreconditions.CheckState(Mode == TransactionMode.ReadWrite, "You can only execute read/write commands on a ReadWrite Transaction!");
                }
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        private TransactionSelector GetTransactionSelector(TransactionMode mode)
        {
            CheckCompatibleMode(mode);
            GaxPreconditions.CheckState(_transaction != null, "Transaction should have been created prior to use.");
            return new TransactionSelector {Id = _transaction?.Id};
        }
    }
}