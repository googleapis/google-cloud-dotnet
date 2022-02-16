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
    // [START aiplatform_v1_generated_IndexEndpointService_CreateIndexEndpoint_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedIndexEndpointServiceClientSnippets
    {
        /// <summary>Snippet for CreateIndexEndpoint</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateIndexEndpointResourceNames()
        {
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = indexEndpointServiceClient.CreateIndexEndpoint(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_IndexEndpointService_CreateIndexEndpoint_sync_flattened_resourceNames]
}
