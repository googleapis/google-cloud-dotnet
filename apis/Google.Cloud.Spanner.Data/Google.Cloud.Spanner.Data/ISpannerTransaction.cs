using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1;

namespace Google.Cloud.Spanner.Data
{
    internal interface ISpannerTransaction
    {
        Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken);
        Task<ReliableStreamReader> ExecuteQueryAsync(ExecuteSqlRequest request, CancellationToken cancellationToken);
    }
}