using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// EphemeralTransaction acquires sessions from the provided SpannerConnection on an as-needed basis.
    /// It holds no long term refcounts or state of its own and can be created and GC'd at will.
    /// </summary>
    internal sealed class EphemeralTransaction : ISpannerTransaction
    {
        private readonly SpannerConnection _connection;

        public EphemeralTransaction(SpannerConnection connection)
        {
            GaxPreconditions.CheckNotNull(connection, nameof(connection));
            _connection = connection;
        }

        /// <summary>
        /// Acquires a read/write transaction from Spannerconnection and releases the transaction back into the pool
        /// after the operation is complete.
        /// SpannerCommand never uses implicit Transactions for write operations because they are non idempotent and
        /// may result in unexpected errors if retry is used.
        /// </summary>
        /// <param name="mutations"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(mutations, nameof(mutations));
            Logger.Debug(() => "Executing a mutation change through an ephemeral transaction.");
            int count;

            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                using (var transaction = await _connection.BeginTransactionAsync(cancellationToken)
                    .ConfigureAwait(false))
                {
                    count = await ((ISpannerTransaction) transaction)
                        .ExecuteMutationsAsync(mutations, cancellationToken)
                        .ConfigureAwait(false);
                    await transaction.CommitAsync().ConfigureAwait(false);
                }
                return count;
            }, "EphemeralTransaction.ExecuteMutations");
        }

        public Task<ReliableStreamReader> ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                GaxPreconditions.CheckNotNull(request, nameof(request));
                Logger.Debug(() => "Executing a query through an ephemeral transaction.");

                using (var holder = await SpannerConnection.SessionHolder
                    .Allocate(_connection, cancellationToken)
                    .ConfigureAwait(false))
                {
                    var streamReader = _connection.SpannerClient.GetSqlStreamReader(request, holder.Session);

                    holder.TakeOwnership();
                    streamReader.StreamClosed += (o, e) => { _connection.ReleaseSession(streamReader.Session); };

                    return streamReader;
                }
            }, "EphemeralTransaction.ExecuteQuery");
        }
    }
}