// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Bigtable.V2.Snippets
{
    // [START bigtable_v2_generated_BigtableServiceApi_MutateRows_sync_flattened1]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.V2;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBigtableServiceApiClientSnippets
    {
        /// <summary>Snippet for MutateRows</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task MutateRows1()
        {
            // Create client
            BigtableServiceApiClient bigtableServiceApiClient = BigtableServiceApiClient.Create();
            // Initialize request argument(s)
            string tableName = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<MutateRowsRequest.Types.Entry> entries = new MutateRowsRequest.Types.Entry[]
            {
                new MutateRowsRequest.Types.Entry(),
            };
            // Make the request, returning a streaming response
            BigtableServiceApiClient.MutateRowsStream response = bigtableServiceApiClient.MutateRows(tableName, entries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<MutateRowsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                MutateRowsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END bigtable_v2_generated_BigtableServiceApi_MutateRows_sync_flattened1]
}
