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
    // [START dataproc_v1_generated_NodeGroupController_ResizeNodeGroup_async_flattened]
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNodeGroupControllerClientSnippets
    {
        /// <summary>Snippet for ResizeNodeGroupAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ResizeNodeGroupAsync()
        {
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            int size = 0;
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.ResizeNodeGroupAsync(name, size);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceResizeNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataproc_v1_generated_NodeGroupController_ResizeNodeGroup_async_flattened]
}
