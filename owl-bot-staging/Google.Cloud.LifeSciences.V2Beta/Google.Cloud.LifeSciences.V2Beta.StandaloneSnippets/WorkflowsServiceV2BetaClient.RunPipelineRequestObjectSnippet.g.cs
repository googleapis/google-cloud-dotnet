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

namespace Google.Cloud.LifeSciences.V2Beta.Snippets
{
    using Google.Cloud.LifeSciences.V2Beta;
    using Google.LongRunning;

    public sealed partial class GeneratedWorkflowsServiceV2BetaClientStandaloneSnippets
    {
        /// <summary>Snippet for RunPipeline</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void RunPipelineRequestObject()
        {
            // Create client
            WorkflowsServiceV2BetaClient workflowsServiceV2BetaClient = WorkflowsServiceV2BetaClient.Create();
            // Initialize request argument(s)
            RunPipelineRequest request = new RunPipelineRequest
            {
                Pipeline = new Pipeline(),
                Labels = { { "", "" }, },
                PubSubTopic = "",
                Parent = "",
            };
            // Make the request
            Operation<RunPipelineResponse, Metadata> response = workflowsServiceV2BetaClient.RunPipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<RunPipelineResponse, Metadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunPipelineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunPipelineResponse, Metadata> retrievedResponse = workflowsServiceV2BetaClient.PollOnceRunPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunPipelineResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
