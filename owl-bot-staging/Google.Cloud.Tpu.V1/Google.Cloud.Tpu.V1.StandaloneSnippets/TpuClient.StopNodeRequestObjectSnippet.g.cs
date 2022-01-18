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

namespace Google.Cloud.Tpu.V1.Snippets
{
    using Google.Cloud.Tpu.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedTpuClientStandaloneSnippets
    {
        /// <summary>Snippet for StopNode</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void StopNodeRequestObject()
        {
            // Create client
            TpuClient tpuClient = TpuClient.Create();
            // Initialize request argument(s)
            StopNodeRequest request = new StopNodeRequest { Name = "", };
            // Make the request
            Operation<Node, OperationMetadata> response = tpuClient.StopNode(request);

            // Poll until the returned long-running operation is complete
            Operation<Node, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Node result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Node, OperationMetadata> retrievedResponse = tpuClient.PollOnceStopNode(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Node retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
