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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_IndexService_UpsertDatapoints_async]
    using Google.Cloud.AIPlatform.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedIndexServiceClientSnippets
    {
        /// <summary>Snippet for UpsertDatapointsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpsertDatapointsRequestObjectAsync()
        {
            // Create client
            IndexServiceClient indexServiceClient = await IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpsertDatapointsRequest request = new UpsertDatapointsRequest
            {
                IndexAsIndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                Datapoints =
                {
                    new IndexDatapoint(),
                },
            };
            // Make the request
            UpsertDatapointsResponse response = await indexServiceClient.UpsertDatapointsAsync(request);
        }
    }
    // [END aiplatform_v1_generated_IndexService_UpsertDatapoints_async]
}
