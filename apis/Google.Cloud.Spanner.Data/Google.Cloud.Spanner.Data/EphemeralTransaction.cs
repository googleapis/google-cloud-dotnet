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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// EphemeralTransaction acquires and releases PooledSessions from the provided SessionPool on an as-needed basis.
    /// It needs no explicit disposal, as each operation cleans up after itself. (In the case of readers being returned,
    /// the session is only released when the ReliableStreamReader is disposed.)
    /// </summary>
    internal sealed class EphemeralTransaction : ISpannerTransaction
    {
        private readonly SpannerConnection _connection;
        private readonly TransactionOptions _transactionOptions;
        private readonly Priority _commitPriority;

        internal EphemeralTransaction(SpannerConnection connection, TransactionOptions transactionOptions, Priority commitPriority)
        {
            _connection = GaxPreconditions.CheckNotNull(connection, nameof(connection));
            _transactionOptions = transactionOptions;
            _commitPriority = commitPriority;
        }

        public Task<long> ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(Impl, "EphemeralTransaction.ExecuteDmlAsync", _connection.Logger);

            async Task<long> Impl()
            {
                using (var transaction = await _connection.BeginTransactionImplAsync(_transactionOptions, TransactionMode.ReadWrite, cancellationToken).ConfigureAwait(false))
                {
                    transaction.CommitTimeout = timeoutSeconds;
                    transaction.CommitPriority = _commitPriority;
                    while (true)
                    {
                        try
                        {
                            long count = await ((ISpannerTransaction)transaction)
                                .ExecuteDmlAsync(request, cancellationToken, timeoutSeconds)
                                .ConfigureAwait(false);

                            // This is somewhat ugly. PDML commits as it goes, so we don't need to, whereas non-partitioned
                            // DML needs the commit afterwards to finish up.
                            if (_transactionOptions.ModeCase != TransactionOptions.ModeOneofCase.PartitionedDml)
                            {
                                await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
                            }
                            return count;
                        }
                        catch (SpannerException e) when (
                            _transactionOptions.ModeCase == TransactionOptions.ModeOneofCase.PartitionedDml &&
                            e.ErrorCode == ErrorCode.Internal &&
                            e.Message.Contains("Received unexpected EOS on DATA frame from server"))
                        {
                            // Retry with the same transaction. Since this error happens in long-lived
                            // transactions (>= 30 mins), it's unnecessary to do exponential backoff.
                            continue;
                        }
                    }
                }
            }
        }

        public Task<IEnumerable<long>> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(Impl, "EphemeralTransaction.ExecuteBatchDmlAsync", _connection.Logger);

            async Task<IEnumerable<long>> Impl()
            {
                using (var transaction = await _connection.BeginTransactionImplAsync(_transactionOptions, TransactionMode.ReadWrite, cancellationToken).ConfigureAwait(false))
                {
                    transaction.CommitTimeout = timeoutSeconds;
                    transaction.CommitPriority = _commitPriority;

                    IEnumerable<long> result;

                    result = await ((ISpannerTransaction)transaction)
                        .ExecuteBatchDmlAsync(request, cancellationToken, timeoutSeconds)
                        .ConfigureAwait(false);

                    await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);

                    return result;
                }
            }
        }

        /// <summary>
        /// Acquires a read/write transaction from Spannerconnection and releases the transaction back into the pool
        /// after the operation is complete.
        /// SpannerCommand never uses implicit Transactions for write operations because they are non idempotent and
        /// may result in unexpected errors if retry is used.
        /// </summary>
        /// <param name="mutations">The list of changes to apply.</param>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <param name="timeoutSeconds">The timeout which will apply to the commit part of this method.</param>
        /// <returns>The number of rows modified.</returns>
        public Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(Impl, "EphemeralTransaction.ExecuteMutationsAsync", _connection.Logger);

            async Task<int> Impl()
            {
                using (var transaction = await _connection.BeginTransactionImplAsync(_transactionOptions, TransactionMode.ReadWrite, cancellationToken).ConfigureAwait(false))
                {
                    // Importantly, we need to set timeout on the transaction, because
                    // ExecuteMutations on SpannerTransaction doesnt actually hit the network
                    // until you commit or rollback.
                    transaction.CommitTimeout = timeoutSeconds;
                    transaction.CommitPriority = _commitPriority;
                    int count = await ((ISpannerTransaction)transaction)
                        .ExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds)
                        .ConfigureAwait(false);
                    await transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
                    return count;
                }
            }
        }

        public Task<ReliableStreamReader> ExecuteReadOrQueryAsync(ReadOrQueryRequest request, CancellationToken cancellationToken, int timeoutSeconds /* ignored */)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(Impl, "EphemeralTransaction.ExecuteReadOrQuery", _connection.Logger);

            async Task<ReliableStreamReader> Impl()
            {
                PooledSession session = await _connection.AcquireSessionAsync(_transactionOptions, cancellationToken).ConfigureAwait(false);
                var callSettings = _connection.CreateCallSettings(
                    request.GetCallSettings,
                    cancellationToken);
                var reader = request.ExecuteReadOrQueryStreamReader(session, callSettings);
                reader.StreamClosed += delegate { session.ReleaseToPool(forceDelete: false); };
                return reader;
            }
        }
    }
}
