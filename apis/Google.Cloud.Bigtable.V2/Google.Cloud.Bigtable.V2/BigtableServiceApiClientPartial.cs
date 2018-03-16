// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableServiceApiSettings
    {
        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.MutateRows</c> and
        /// <c>BigtableClient.MutateRowsAsync</c> when some of the mutations fail for certain reasons.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.MutateRows</c> and <c>BigtableClient.MutateRowsAsync</c>
        /// <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        /// <seealso cref="MutateRowsSettings"/>
        public RetrySettings MutateRowsRetrySettings { get; set; } =
            new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            );

        /// <summary>
        /// <see cref="RetrySettings"/> for calls to <c>BigtableClient.ReadRows</c> when the stream
        /// of results ends prematurely.
        /// </summary>
        /// <remarks>
        /// The default <c>BigtableClient.ReadRows</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes on individual mutations:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        /// <seealso cref="ReadRowsSettings"/>
        public RetrySettings ReadRowsRetrySettings { get; set; } =
            new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            );

        partial void OnCopy(BigtableServiceApiSettings existing)
        {
            MutateRowsRetrySettings = existing.MutateRowsRetrySettings;
            ReadRowsRetrySettings = existing.ReadRowsRetrySettings;
        }
    }

    public partial class BigtableServiceApiClient
    {
        public partial class SampleRowKeysStream
        {
            /// <summary>
            /// Gets all responses from the stream.
            /// </summary>
            /// <returns>The collection of all row key samples.</returns>
            public IList<SampleRowKeysResponse> ToList() =>
                Task.Run(() => ToListAsync()).ResultWithUnwrappedExceptions();

            /// <summary>
            /// Gets all responses from the stream asynchronously.
            /// </summary>
            /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
            /// <returns>The collection of all row key samples.</returns>
            public async Task<IList<SampleRowKeysResponse>> ToListAsync(
                CancellationToken cancellationToken = default)
            {
                var responses = new List<SampleRowKeysResponse>();
                while (await ResponseStream.MoveNext(cancellationToken).ConfigureAwait(false))
                {
                    responses.Add(ResponseStream.Current);
                }
                return responses;
            }
        }
    }
    
    public partial class BigtableServiceApiClientImpl
    {
        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings) =>
            GaxPreconditions.CheckState(
                request.IsIdempotent(), 
                "Non-idempotent MutateRow requests are not allowed. Specify a version with all SetCell mutations.");

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings) =>
            GaxPreconditions.CheckState(
                request.IsIdempotent(),
                "Non-idempotent MutateRows requests are not allowed. Specify a version with all SetCell mutations.");
    }
}
