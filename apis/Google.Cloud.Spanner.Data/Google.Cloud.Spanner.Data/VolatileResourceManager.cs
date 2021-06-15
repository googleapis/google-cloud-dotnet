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

using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Google.Cloud.Spanner.Data
{
    internal sealed class VolatileResourceManager : ISinglePhaseNotification, ISpannerTransaction, IDisposable
    {
        private readonly object _lock = new object();
        private readonly SpannerConnection _spannerConnection;
        private readonly TimestampBound _timestampBound;
        private readonly TransactionId _transactionId;
        private Task<SpannerTransaction> _transactionTask;
        private bool _disposed = false;

        internal VolatileResourceManager(SpannerConnection spannerConnection, TimestampBound timestampBound, TransactionId transactionId)
        {
            _spannerConnection = spannerConnection;
            _timestampBound = timestampBound;
            _transactionId = transactionId;
        }

        private Logger Logger => _spannerConnection.Logger;

        private SpannerTransaction SpannerTransaction
        {
            get
            {
                lock (_lock)
                {
                    return _transactionTask?.Result;
                }
            }
        }

        public void Dispose()
        {
            try
            {
                SpannerTransaction transaction = null;
                lock (_lock)
                {
                    transaction = _transactionTask?.Result;
                    // Protect against multiple disposals
                    _transactionTask = null;
                    _disposed = true;
                }
                transaction?.Dispose();
            }
            catch (Exception e)
            {
                Logger.Error("Error disposing", e);
            }
        }

        public void Commit(Enlistment enlistment)
        {
            try
            {
                if (SpannerTransaction != null && !SpannerTransaction.HasMutations)
                {
                    // In the case where our resource manager doesn't have any mutations, it was a read,
                    // which we will no-op and allow through even if it was a two phase commit.
                    // This allows cases such as nested transactions where the inner transaction is a readonly
                    // timestamp bound read and doesn't have anything to commit.
                    Logger.Debug(() => "Received a COMMIT for a two phase commit but without changes. This is allowed.");
                    enlistment.Done();

                    // For write transactions with no mutations, this ensures the transaction
                    // gets closed and the locks get released if any were made.
                    CommitToSpanner();
                    return;
                }
                Logger.Warn("Received a call to Commit, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
                throw new NotSupportedException(
                    "Spanner only supports single phase commit (2-P Commit not supported)." +
                    " This error can happen when attempting to use multiple transaction resources but may also happen for" +
                    " other reasons that cause a Transaction to use two-phase commit.");
            }
            finally
            {
                Dispose();
            }
        }

        public void InDoubt(Enlistment enlistment)
        {
            Logger.Warn("Got an InDoubt call, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            enlistment.Done();
        }

        public void Prepare(PreparingEnlistment preparingEnlistment)
        {
            if (SpannerTransaction != null && !SpannerTransaction.HasMutations)
            {
                // In the case where our resource manager doesn't have any mutations, it was a read,
                // which we will no-op and allow through even if it was a two phase commit.
                // This allows cases such as nested transactions where the inner transaction is a readonly
                // timestamp bound read and doesn't have anything to commit.
                Logger.Debug(() => "Received a PREPARE for a two phase commit but without changes. This is allowed.");
                preparingEnlistment.Prepared();
                return;
            }
            Logger.Warn(() => "Received a call to Prepare, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            try
            {
                preparingEnlistment.ForceRollback(new NotSupportedException(
                    "Spanner only supports single phase commit (Prepare not supported)."
                    + " This error can happen when attempting to use multiple transaction resources but may also happen for"
                    + " other reasons that cause a Transaction to use two-phase commit."));
            }
            finally
            {
                // We've forced a rollback, but the expectation is that *this* resource
                // manager won't have done anything yet, given that we've "failed" to prepare.
                // Therefore we need to clean ourselves up. The other resource managers that have already
                // been prepared will be cleaned up by the transaction manager.
                Dispose();
            }
        }

        public void Rollback(Enlistment enlistment)
        {
            try
            {
                // We don't need to roll back if we're in a read-only transaction, and indeed doing so will cause an error.
                if (SpannerTransaction != null && SpannerTransaction.Mode != TransactionMode.ReadOnly)
                {
                    ExecuteHelper.WithErrorTranslationAndProfiling(() => SpannerTransaction.Rollback(), "VolatileResourceManager.Rollback", Logger);
                }
                enlistment.Done();
            }
            catch (Exception e)
            {
                Logger.Error("Error attempting to rollback a transaction.", e);
            }
            finally
            {
                Dispose();
            }
        }

        public void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment)
        {
            try
            {
                CommitToSpanner();
                singlePhaseEnlistment.Committed();
            }
            catch (SpannerException e)
            {
                singlePhaseEnlistment.Aborted(e);
            }
            catch (Exception e)
            {
                singlePhaseEnlistment.InDoubt(e);
            }
            finally
            {
                Dispose();
            }
        }

        private void CommitToSpanner()
        {
            // If it's a read-only transaction, then just tell the outer transaction that everything is good.
            // This can happen with a read-only transaction or a write transaction where we never
            // executed any mutations.
            if (SpannerTransaction != null && SpannerTransaction.Mode != TransactionMode.ReadOnly)
            {
                ExecuteHelper.WithErrorTranslationAndProfiling(() => SpannerTransaction.Commit(), "VolatileResourceManager.Commit", Logger);
            }
        }

        public async Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            return await transaction.ExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<ReliableStreamReader> ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            return await transaction.ExecuteQueryAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<long> ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            return await transaction.ExecuteDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<IEnumerable<long>> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            return await transaction.ExecuteBatchDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        private async Task<SpannerTransaction> GetTransactionAsync(CancellationToken cancellationToken, int timeoutSeconds)
        {
            // Note that we delay transaction creation (and thereby session allocation) until the first operation
            // (ExecuteMutations, ExecuteQuery, ExecuteDml)
            var createdTransaction = false;
            lock (_lock)
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException("The transaction has already been disposed");
                }
                if (_transactionTask == null)
                {
                    _transactionTask =
                        _timestampBound != null ? _spannerConnection.BeginReadOnlyTransactionAsync(_timestampBound, cancellationToken)
                        : _transactionId != null ? Task.FromResult(_spannerConnection.BeginReadOnlyTransaction(_transactionId))
                        : _spannerConnection.BeginTransactionAsync(cancellationToken);
                    createdTransaction = true;
                }
            }
            var transaction = await _transactionTask.ConfigureAwait(false);
            if (createdTransaction)
            {
                // The commit timeout is irrelevant for read-only transactions, but it's easier to set it unconditionally.
                transaction.CommitTimeout = timeoutSeconds;
            }
            return transaction;
        }
    }
}
