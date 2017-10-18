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


#if !NETSTANDARD1_5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.Data
{
    internal sealed class VolatileResourceManager : ISinglePhaseNotification, ISpannerTransaction, IDisposable
    {
        private readonly SpannerConnection _spannerConnection;
        private readonly TimestampBound _timestampBound;
        private SpannerTransaction _transaction;

        public VolatileResourceManager(SpannerConnection spannerConnection, TimestampBound timestampBound)
        {
            _spannerConnection = spannerConnection;
            _timestampBound = timestampBound;
        }

        private Logger Logger => _spannerConnection?.Logger ?? Logger.DefaultLogger;

        public void Dispose()
        {
            _transaction?.Dispose();
        }

        public void Commit(Enlistment enlistment)
        {
            if (_transaction != null && !_transaction.HasMutations)
            {
                //In the case where our resource manager doesn't have any mutations, it was a read,
                //which we will no-op and allow through even if it was a two phase commit.
                //This allows cases such as nested transactions where the inner transaction is a readonly
                //timestamp bound read and doesn't have anything to commit.
                Logger.Debug(() => "Received a COMMIT for a two phase commit but without changes. This is allowed.");
                enlistment.Done();

                // For write transactions with no mutations, this ensures the transaction
                // gets closed and the locks get released if any were made.
                CommitToSpanner();
                return;
            }
            Logger.Warn(
                () =>
                    "Got a Commit call, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            throw new NotSupportedException("Spanner only supports single phase commit (2-P Commit not supported)."
                                            +
                                            " This error can happen when attempting to use multiple transaction resources but may also happen for"
                                            + " other reasons that cause a Transaction to use two-phase commit.");
        }

        public void InDoubt(Enlistment enlistment)
        {
            Logger.Warn(
                () =>
                    "Got a InDoubt call, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            enlistment.Done();
        }

        public void Prepare(PreparingEnlistment preparingEnlistment)
        {
            if (_transaction != null && !_transaction.HasMutations) {
                //In the case where our resource manager doesn't have any mutations, it was a read,
                //which we will no-op and allow through even if it was a two phase commit.
                //This allows cases such as nested transactions where the inner transaction is a readonly
                //timestamp bound read and doesn't have anything to commit.
                Logger.Debug(() => "Received a PREPARE for a two phase commit but without changes. This is allowed.");
                preparingEnlistment.Prepared();
                return;
            }
            Logger.Warn(
                () =>
                    "Got a Prepare call, which indicates two phase commit inside a transaction scope. This is currently not supported in Spanner.");
            preparingEnlistment.ForceRollback(new NotSupportedException(
                "Spanner only supports single phase commit (Prepare not supported)."
                + " This error can happen when attempting to use multiple transaction resources but may also happen for"
                + " other reasons that cause a Transaction to use two-phase commit."));
        }

        public void Rollback(Enlistment enlistment)
        {
            try
            {
                ExecuteHelper.WithErrorTranslationAndProfiling(() =>
                    _transaction?.Rollback(), "VolatileResourceManager.Rollback", Logger);
                enlistment.Done();
            }
            catch (Exception e)
            {
                Logger.Error(
                    () =>
                        "Error attempting to rollback a transaction.", e);
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
            // If its a read-only transaction, then just tell the outer transaction that everything is good.
            // This can happen with a readonly transaction or a write transaction where we never
            // executed any mutations.
            if (_transaction?.Mode != TransactionMode.ReadOnly)
            {
                ExecuteHelper.WithErrorTranslationAndProfiling(
                    () =>
                        _transaction?.Commit(), "VolatileResourceManager.Commit", Logger);
            }
        }

        public async Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            var transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            if (transaction == null)
            {
                throw new InvalidOperationException("Unable to obtain a spanner transaction to execute within.");
            }
            return await ((ISpannerTransaction) transaction).ExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        public async Task<ReliableStreamReader> ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            var transaction = await GetTransactionAsync(cancellationToken, timeoutSeconds).ConfigureAwait(false);
            if (transaction == null)
            {
                throw new InvalidOperationException("Unable to obtain a spanner transaction to execute within.");
            }
            return await((ISpannerTransaction) transaction).ExecuteQueryAsync(request, cancellationToken, timeoutSeconds).ConfigureAwait(false);
        }

        private async Task<SpannerTransaction> GetTransactionAsync(CancellationToken cancellationToken, int timeoutSeconds)
        {
            //note that we delay transaction creation (and thereby session allocation)
            if (_timestampBound != null)
            {
                return _transaction ?? (_transaction =
                    await _spannerConnection.BeginReadOnlyTransactionAsync(_timestampBound, cancellationToken)
                        .ConfigureAwait(false));
            }
            var result = _transaction ?? (_transaction = await _spannerConnection.BeginTransactionAsync(cancellationToken)
                .ConfigureAwait(false));
            result.CommitTimeout = timeoutSeconds;
            return result;
        }
    }
}

#endif
