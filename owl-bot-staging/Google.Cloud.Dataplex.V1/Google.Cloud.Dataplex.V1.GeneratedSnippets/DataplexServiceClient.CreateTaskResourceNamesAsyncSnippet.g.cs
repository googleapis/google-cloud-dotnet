// Copyright 2025 Google LLC
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
    // [START dataplex_v1_generated_DataplexService_CreateTask_async_flattened_resourceNames]
    using Google.LongRunning;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    public sealed partial class GeneratedDataplexServiceClientSnippets
    {
        /// <summary>Snippet for CreateTaskAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateTaskResourceNamesAsync()
        {
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataplexService_CreateTask_async_flattened_resourceNames]
}
