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
    // [START discoveryengine_v1_generated_SiteSearchEngineService_RecrawlUris_sync]
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedSiteSearchEngineServiceClientSnippets
    {
        /// <summary>Snippet for RecrawlUris</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RecrawlUrisRequestObject()
        {
            // Create client
            SiteSearchEngineServiceClient siteSearchEngineServiceClient = SiteSearchEngineServiceClient.Create();
            // Initialize request argument(s)
            RecrawlUrisRequest request = new RecrawlUrisRequest
            {
                SiteSearchEngineAsSiteSearchEngineName = SiteSearchEngineName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Uris = { "", },
                SiteCredential = "",
            };
            // Make the request
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> response = siteSearchEngineServiceClient.RecrawlUris(request);

            // Poll until the returned long-running operation is complete
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RecrawlUrisResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RecrawlUrisResponse, RecrawlUrisMetadata> retrievedResponse = siteSearchEngineServiceClient.PollOnceRecrawlUris(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RecrawlUrisResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END discoveryengine_v1_generated_SiteSearchEngineService_RecrawlUris_sync]
}
