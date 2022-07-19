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

namespace Google.Cloud.BeyondCorp.ClientConnectorServices.V1.Snippets
{
    // [START beyondcorp_v1_generated_ClientConnectorServicesService_CreateClientConnectorService_async_flattened]
    using Google.Cloud.BeyondCorp.ClientConnectorServices.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedClientConnectorServicesServiceClientSnippets
    {
        /// <summary>Snippet for CreateClientConnectorServiceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateClientConnectorServiceAsync()
        {
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            string clientConnectorServiceId = "";
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.CreateClientConnectorServiceAsync(parent, clientConnectorService, clientConnectorServiceId);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceCreateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END beyondcorp_v1_generated_ClientConnectorServicesService_CreateClientConnectorService_async_flattened]
}
