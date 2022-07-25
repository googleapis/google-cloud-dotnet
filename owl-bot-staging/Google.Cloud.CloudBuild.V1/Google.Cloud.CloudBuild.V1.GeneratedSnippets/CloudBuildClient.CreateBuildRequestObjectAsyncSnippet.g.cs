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

namespace Google.Cloud.CloudBuild.V1.Snippets
{
    // [START cloudbuild_v1_generated_CloudBuild_CreateBuild_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CloudBuild.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudBuildClientSnippets
    {
        /// <summary>Snippet for CreateBuildAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateBuildRequestObjectAsync()
        {
            // Create client
            CloudBuildClient cloudBuildClient = await CloudBuildClient.CreateAsync();
            // Initialize request argument(s)
            CreateBuildRequest request = new CreateBuildRequest
            {
                ProjectId = "",
                Build = new Build(),
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Operation<Build, BuildOperationMetadata> response = await cloudBuildClient.CreateBuildAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Build, BuildOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Build result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Build, BuildOperationMetadata> retrievedResponse = await cloudBuildClient.PollOnceCreateBuildAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Build retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END cloudbuild_v1_generated_CloudBuild_CreateBuild_async]
}
