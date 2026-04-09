// Copyright 2026 Google LLC
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
    // [START config_v1_generated_Config_DeprovisionDeploymentGroup_sync]
    using Google.Cloud.Config.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedConfigClientSnippets
    {
        /// <summary>Snippet for DeprovisionDeploymentGroup</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeprovisionDeploymentGroupRequestObject()
        {
            // Create client
            ConfigClient configClient = ConfigClient.Create();
            // Initialize request argument(s)
            DeprovisionDeploymentGroupRequest request = new DeprovisionDeploymentGroupRequest
            {
                DeploymentGroupName = DeploymentGroupName.FromProjectLocationDeploymentGroup("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_GROUP]"),
                Force = false,
                DeletePolicy = DeleteDeploymentRequest.Types.DeletePolicy.Unspecified,
            };
            // Make the request
            Operation<DeploymentGroup, OperationMetadata> response = configClient.DeprovisionDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentGroup, OperationMetadata> retrievedResponse = configClient.PollOnceDeprovisionDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentGroup retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END config_v1_generated_Config_DeprovisionDeploymentGroup_sync]
}
