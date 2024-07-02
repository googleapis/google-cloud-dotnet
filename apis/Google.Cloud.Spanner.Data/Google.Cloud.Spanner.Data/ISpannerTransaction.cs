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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    internal interface ISpannerTransaction
    {
        // Note: mutations is guaranteed not to be null here.
        Task<int> ExecuteMutationsAsync(List<Mutation> mutations, CancellationToken cancellationToken, int timeoutSeconds);

        // Note: this returns Task<long> to reflect the results from Spanner faithfully. The caller can then decide what to
        // do if they need to return an int result type.
        Task<long> ExecuteDmlAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds);

        // Note: this returns Task<ReliableStreamReader> to allow affected rows to be returned.
        Task<ReliableStreamReader> ExecuteDmlReaderAsync(ExecuteSqlRequest request, CancellationToken cancellationToken, int timeoutSeconds);

        // Note: this returns Task<IEnumerable<long>> to reflect the results from Spanner faithfully. The caller can then decide what to
        // do if they need to return an int result type.
        Task<IEnumerable<long>> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CancellationToken cancellationToken, int timeoutSeconds);

        Task<ReliableStreamReader> ExecuteReadOrQueryAsync(ReadOrQueryRequest request, CancellationToken cancellationToken);
    }
}
