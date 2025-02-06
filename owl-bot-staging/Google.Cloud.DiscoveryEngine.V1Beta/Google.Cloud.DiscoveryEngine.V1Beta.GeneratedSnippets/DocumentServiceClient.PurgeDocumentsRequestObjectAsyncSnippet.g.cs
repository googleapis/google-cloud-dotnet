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
    // [START discoveryengine_v1beta_generated_DocumentService_PurgeDocuments_async]
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDocumentServiceClientSnippets
    {
        /// <summary>Snippet for PurgeDocumentsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task PurgeDocumentsRequestObjectAsync()
        {
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeDocumentsRequest request = new PurgeDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Filter = "",
                Force = false,
                GcsSource = new GcsSource(),
                ErrorConfig = new PurgeErrorConfig(),
            };
            // Make the request
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> response = await documentServiceClient.PurgeDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> retrievedResponse = await documentServiceClient.PollOncePurgeDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END discoveryengine_v1beta_generated_DocumentService_PurgeDocuments_async]
}
