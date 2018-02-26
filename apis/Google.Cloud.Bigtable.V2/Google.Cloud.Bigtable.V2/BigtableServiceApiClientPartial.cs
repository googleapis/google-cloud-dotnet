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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableServiceApiSettings
    {
        partial void OnConstruction()
        {
            var originalMutateRowsSettings = MutateRowsSettings;
            GaxPreconditions.CheckState(
                originalMutateRowsSettings.Timing != null &&
                originalMutateRowsSettings.Timing.Type == CallTimingType.Expiration,
                "The default MutateRowsSettings are not in the expected state");
            MutateRowsSettings = originalMutateRowsSettings.WithCallTiming(
                CallTiming.FromRetry(new RetrySettings(
                    retryBackoff: GetDefaultRetryBackoff(),
                    timeoutBackoff: GetDefaultTimeoutBackoff(),
                    totalExpiration: originalMutateRowsSettings.Timing.Expiration,
                    retryFilter: IdempotentRetryFilter
                )));
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
        private const string ResourcePrefixHeader = "google-cloud-resource-prefix";

        partial void Modify_ReadRowsRequest(ref ReadRowsRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_SampleRowKeysRequest(ref SampleRowKeysRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_MutateRowRequest(ref MutateRowRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckState(request.IsIdempotent(), "Non-idempotent MutateRow requests are not allowed. Specify a version with all SetCell mutations.");
            ApplyResourcePrefixHeader(ref settings, request.TableName);
        }

        partial void Modify_MutateRowsRequest(ref MutateRowsRequest request, ref CallSettings settings)
        {
            GaxPreconditions.CheckState(request.IsIdempotent(), "Non-idempotent MutateRows requests are not allowed. Specify a version with all SetCell mutations.");
            ApplyResourcePrefixHeader(ref settings, request.TableName);
        }

        partial void Modify_CheckAndMutateRowRequest(ref CheckAndMutateRowRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        partial void Modify_ReadModifyWriteRowRequest(ref ReadModifyWriteRowRequest request, ref CallSettings settings) =>
            ApplyResourcePrefixHeader(ref settings, request.TableName);

        private static void ApplyResourcePrefixHeader(ref CallSettings settings, string resource)
        {
            settings = settings.WithHeader(ResourcePrefixHeader, resource);
        }
    }
}
