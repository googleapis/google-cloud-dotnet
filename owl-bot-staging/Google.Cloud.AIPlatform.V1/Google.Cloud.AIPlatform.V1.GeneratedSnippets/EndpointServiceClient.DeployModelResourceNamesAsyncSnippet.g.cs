// Copyright 2024 Google LLC
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
    // [START aiplatform_v1_generated_EndpointService_DeployModel_async_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEndpointServiceClientSnippets
    {
        /// <summary>Snippet for DeployModelAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task DeployModelResourceNamesAsync()
        {
            // Create client
            EndpointServiceClient endpointServiceClient = await EndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName endpoint = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]");
            DeployedModel deployedModel = new DeployedModel();
            IDictionary<string, int> trafficSplit = new Dictionary<string, int> { { "", 0 }, };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = await endpointServiceClient.DeployModelAsync(endpoint, deployedModel, trafficSplit);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = await endpointServiceClient.PollOnceDeployModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_EndpointService_DeployModel_async_flattened_resourceNames]
}
