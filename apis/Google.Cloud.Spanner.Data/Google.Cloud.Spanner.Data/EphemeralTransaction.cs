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
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// EphemeralTransaction acquires sessions from the provided SpannerConnection on an as-needed basis.
    /// It holds no long term refcounts or state of its own and can be created and GC'd at will.
    /// </summary>
    internal sealed class EphemeralTransaction : ISpannerTransaction
    {
        private readonly SpannerConnection _connection;

        public EphemeralTransaction(SpannerConnection connection, Logger logger)
        {
            GaxPreconditions.CheckNotNull(connection, nameof(connection));
            _connection = connection;
            Logger = logger ?? Logger.DefaultLogger;
        }

        /// <summary>
        /// This property is intended for internal use only.
        /// </summary>
        private Logger Logger { get; }

        /// <summary>
        /// Acquires a read/write transaction from Spannerconnection and releases the transaction back into the pool
        /// after the operation is complete.
        /// SpannerCommand never uses implicit Transactions for write operations because they are non idempotent and
        /// may result in unexpected errors if retry is used.
        /// </summary>
        /// <param name="mutations">The list of changes to apply.</param>
        /// <param name="cancellationToken">A cancellation token used for this task.</param>
        /// <param name="timeoutSeconds">The timeout which will apply to the commit part of this method.</param>
        /// <returns></returns>
        public Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds)
        {
            GaxPreconditions.CheckNotNull(mutations, nameof(mutations));
            Logger.Debug(() => "Executing a mutation change through an ephemeral transaction.");
            int count;

            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    using (var transaction = await _connection.BeginTransactionAsync(cancellationToken)
                        .ConfigureAwait(false))
                    {
                        // Importantly, we need to set timeout on the transaction, because
                        // ExecuteMutations on SpannerTransaction doesnt actually hit the network
                        // until you commit or rollback.
                        transaction.CommitTimeout = timeoutSeconds;
                        count = await ((ISpannerTransaction) transaction)
                            .ExecuteMutationsAsync(mutations, cancellationToken, timeoutSeconds)
                            .ConfigureAwait(false);
                        await transaction.CommitAsync().ConfigureAwait(false);
                    }
                    return count;
                }, "EphemeralTransaction.ExecuteMutations", Logger);
        }

        public Task<ReliableStreamReader> ExecuteQueryAsync(
            ExecuteSqlRequest request,
            CancellationToken cancellationToken,
            int timeoutSeconds)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    GaxPreconditions.CheckNotNull(request, nameof(request));
                    Logger.Debug(() => "Executing a query through an ephemeral transaction.");

                    using (var holder = await SpannerConnection.SessionHolder
                        .Allocate(_connection, cancellationToken)
                        .ConfigureAwait(false))
                    {
                        var streamReader = _connection.SpannerClient.GetSqlStreamReader(request, holder.Session, timeoutSeconds);

                        holder.TakeOwnership();
                        streamReader.StreamClosed += (o, e) => { _connection.ReleaseSession(streamReader.Session); };

                        return streamReader;
                    }
                }, "EphemeralTransaction.ExecuteQuery", Logger);
        }
    }
}
