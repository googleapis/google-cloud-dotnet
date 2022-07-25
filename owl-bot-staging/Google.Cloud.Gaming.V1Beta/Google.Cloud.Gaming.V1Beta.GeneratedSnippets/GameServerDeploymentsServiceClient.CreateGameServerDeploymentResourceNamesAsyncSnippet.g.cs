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

namespace Google.Cloud.Gaming.V1Beta.Snippets
{
    // [START gameservices_v1beta_generated_GameServerDeploymentsService_CreateGameServerDeployment_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Gaming.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGameServerDeploymentsServiceClientSnippets
    {
        /// <summary>Snippet for CreateGameServerDeploymentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateGameServerDeploymentResourceNamesAsync()
        {
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync(parent, gameServerDeployment);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gameservices_v1beta_generated_GameServerDeploymentsService_CreateGameServerDeployment_async_flattened_resourceNames]
}
