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
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace Google.Cloud.Spanner.Data
{
    internal sealed class VolatileResourceManager : ISinglePhaseNotification, ISpannerTransaction, IDisposable
    {
        private readonly SpannerConnection _spannerConnection;
        private readonly TimestampBound _timestampBound;
        private readonly TransactionId _transactionId;
        private Lazy<Task<SpannerTransaction>> _transaction;
        private bool _hasExecutedDml;

        internal VolatileResourceManager(SpannerConnection spannerConnection, TimestampBound timestampBound, TransactionId transactionId)
        {
            _spannerConnection = spannerConnection;
            _timestampBound = timestampBound;
            _transaction = new Lazy<Task<SpannerTransaction>>(CreateTransactionAsync, LazyThreadSafetyMode.ExecutionAndPublication);
            _transactionId = transactionId;
        }

        private SpannerTransaction SpannerTransaction => SpannerTransactionTask.Result;

        private Task<SpannerTransaction> SpannerTransactionTask => _transaction == null
            ? throw new ObjectDisposedException("The transaction has already been disposed")
            : _transaction.Value;

        private bool IsTransactionCreated => _transaction != null && _transaction.IsValueCreated;

        private bool HasExecutedDmlOrMutations => IsTransactionCreated && (_hasExecutedDml || SpannerTransaction.HasMutations);

        private ILogger Logger => _spannerConnection.Logger;

        private Task<SpannerTransaction> CreateTransactionAsync()
        {
            return _timestampBound != null ? _spannerConnection.BeginReadOnlyTransactionAsync(_timestampBound)
                : _transactionId != null ? Task.FromResult(_spannerConnection.BeginReadOnlyTransaction(_transactionId))
                : _spannerConnection.BeginTransactionAsync();
        }

        public void Dispose()
        {
            try
            {
                if (IsTransactionCreated)
                {
                    SpannerTransaction.Dispose();
                }
                _transaction = null;
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error disposing");
            }
        }

        public void Commit(Enlistment enlistment)
        {
            try
            {
                if (!HasExecutedDmlOrMutations)
                {
                    // In the case where our resource manager doesn't have any mutations, it was a read,
                    // which we will no-op and allow through even if it was a two phase commit.
                    // This allows cases such as nested transactions where the inner transaction is a readonly
                    // timestamp bound read and doesn't have anything to commit.
                    Logger.LogDebug("Received a COMMIT for a two phase commit but without changes. This is allowed.");
                    enlistment.Done();

                    // For write transactions with no mutations, this ensures the transaction
                    // gets closed and the locks get released if any were made.
                    CommitToSpanner();
                    return;
                }
                Logger.LogWarning("Received a call to Commit, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
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
            Logger.LogWarning("Got an InDoubt call, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            enlistment.Done();
        }

        public void Prepare(PreparingEnlistment preparingEnlistment)
        {
            if (!HasExecutedDmlOrMutations)
            {
                // In the case where our resource manager doesn't have any mutations, it was a read,
                // which we will no-op and allow through even if it was a two phase commit.
                // This allows cases such as nested transactions where the inner transaction is a readonly
                // timestamp bound read and doesn't have anything to commit.
                Logger.LogDebug("Received a PREPARE for a two phase commit but without changes. This is allowed.");
                preparingEnlistment.Prepared();
                return;
            }
            Logger.LogWarning("Received a call to Prepare, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
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
                if (IsTransactionCreated && SpannerTransaction.Mode != TransactionMode.ReadOnly)
                {
                    ExecuteHelper.WithErrorTranslationAndProfiling(() => SpannerTransaction.Rollback(), "VolatileResourceManager.Rollback", Logger);
                }
                enlistment.Done();
            }
            catch (Exception e)
            {
                Logger.LogError(e, "Error attempting to rollback a transaction.");
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
            if (IsTransactionCreated && SpannerTransaction.Mode != TransactionMode.ReadOnly)
            {
                ExecuteHelper.WithErrorTranslationAndProfiling(() => SpannerTransaction.Commit(), "VolatileResourceManager.Commit", Logger);
            }
        }

        public async Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await SpannerTransactionTask.ConfigureAwait(false);
            return await transaction.ExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<ReliableStreamReader> ExecuteReadOrQueryAsync(ReadOrQueryRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            ISpannerTransaction transaction = await SpannerTransactionTask.ConfigureAwait(false);
            return await transaction.ExecuteReadOrQueryAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<long> ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            _hasExecutedDml = true;
            ISpannerTransaction transaction = await SpannerTransactionTask.ConfigureAwait(false);
            return await transaction.ExecuteDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<IEnumerable<long>> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            _hasExecutedDml = true;
            ISpannerTransaction transaction = await SpannerTransactionTask.ConfigureAwait(false);
            return await transaction.ExecuteBatchDmlAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }
    }
}
