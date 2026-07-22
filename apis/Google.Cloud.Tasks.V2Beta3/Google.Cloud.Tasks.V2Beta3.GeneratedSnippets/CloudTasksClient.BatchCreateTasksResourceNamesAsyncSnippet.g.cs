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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START cloudtasks_v2beta3_generated_CloudTasks_BatchCreateTasks_async_flattened_resourceNames]
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using gctv = Google.Cloud.Tasks.V2Beta3;

    public sealed partial class GeneratedCloudTasksClientSnippets
    {
        /// <summary>Snippet for BatchCreateTasksAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchCreateTasksResourceNamesAsync()
        {
            // Create client
            gctv::CloudTasksClient cloudTasksClient = await gctv::CloudTasksClient.CreateAsync();
            // Initialize request argument(s)
            gctv::QueueName parent = gctv::QueueName.FromProjectLocationQueue("[PROJECT]", "[LOCATION]", "[QUEUE]");
            IEnumerable<gctv::CreateTaskRequest> requests = new gctv::CreateTaskRequest[]
            {
                new gctv::CreateTaskRequest(),
            };
            // Make the request
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> response = await cloudTasksClient.BatchCreateTasksAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gctv::BatchCreateTasksResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gctv::BatchCreateTasksResponse, gctv::BatchCreateTasksMetadata> retrievedResponse = await cloudTasksClient.PollOnceBatchCreateTasksAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gctv::BatchCreateTasksResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END cloudtasks_v2beta3_generated_CloudTasks_BatchCreateTasks_async_flattened_resourceNames]
}
