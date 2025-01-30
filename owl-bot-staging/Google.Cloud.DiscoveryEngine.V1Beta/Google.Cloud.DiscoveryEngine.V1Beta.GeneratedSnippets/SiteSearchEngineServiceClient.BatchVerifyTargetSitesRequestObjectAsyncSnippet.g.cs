// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START discoveryengine_v1beta_generated_SiteSearchEngineService_BatchVerifyTargetSites_async]
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSiteSearchEngineServiceClientSnippets
    {
        /// <summary>Snippet for BatchVerifyTargetSitesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchVerifyTargetSitesRequestObjectAsync()
        {
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = await SiteSearchEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchVerifyTargetSitesRequest request = new BatchVerifyTargetSitesRequest
            {
                ParentAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> response = await siteSearchEngineServiceClient.BatchVerifyTargetSitesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchVerifyTargetSitesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchVerifyTargetSitesResponse, BatchVerifyTargetSitesMetadata> retrievedResponse = await siteSearchEngineServiceClient.PollOnceBatchVerifyTargetSitesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchVerifyTargetSitesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END discoveryengine_v1beta_generated_SiteSearchEngineService_BatchVerifyTargetSites_async]
}
