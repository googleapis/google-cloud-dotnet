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
    // [START aiplatform_v1_generated_PipelineService_BatchDeletePipelineJobs_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Collections.Generic;

    public sealed partial class GeneratedPipelineServiceClientSnippets
    {
        /// <summary>Snippet for BatchDeletePipelineJobs</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void BatchDeletePipelineJobs()
        {
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/pipelineJobs/[PIPELINE_JOB]",
            };
            // Make the request
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> response = pipelineServiceClient.BatchDeletePipelineJobs(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeletePipelineJobsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeletePipelineJobsResponse, DeleteOperationMetadata> retrievedResponse = pipelineServiceClient.PollOnceBatchDeletePipelineJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeletePipelineJobsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_PipelineService_BatchDeletePipelineJobs_sync_flattened]
}
