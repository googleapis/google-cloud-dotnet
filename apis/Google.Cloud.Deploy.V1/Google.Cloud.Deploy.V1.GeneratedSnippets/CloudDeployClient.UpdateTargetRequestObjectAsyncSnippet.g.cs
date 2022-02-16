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

namespace Google.Cloud.Deploy.V1.Snippets
{
    // [START clouddeploy_v1_generated_CloudDeploy_UpdateTarget_async]
    using Google.Cloud.Deploy.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudDeployClientSnippets
    {
        /// <summary>Snippet for UpdateTargetAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateTargetRequestObjectAsync()
        {
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTargetRequest request = new UpdateTargetRequest
            {
                UpdateMask = new FieldMask(),
                Target = new Target(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.UpdateTargetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END clouddeploy_v1_generated_CloudDeploy_UpdateTarget_async]
}
