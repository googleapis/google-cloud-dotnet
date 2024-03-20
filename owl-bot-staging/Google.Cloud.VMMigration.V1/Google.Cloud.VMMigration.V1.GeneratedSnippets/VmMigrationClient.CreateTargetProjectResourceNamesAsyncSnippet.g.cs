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
    // [START vmmigration_v1_generated_VmMigration_CreateTargetProject_async_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedVmMigrationClientSnippets
    {
        /// <summary>Snippet for CreateTargetProjectAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateTargetProjectResourceNamesAsync()
        {
            // Create client
            VmMigrationClient vmMigrationClient = await VmMigrationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TargetProject targetProject = new TargetProject();
            string targetProjectId = "";
            // Make the request
            Operation<TargetProject, OperationMetadata> response = await vmMigrationClient.CreateTargetProjectAsync(parent, targetProject, targetProjectId);

            // Poll until the returned long-running operation is complete
            Operation<TargetProject, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TargetProject result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TargetProject, OperationMetadata> retrievedResponse = await vmMigrationClient.PollOnceCreateTargetProjectAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TargetProject retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END vmmigration_v1_generated_VmMigration_CreateTargetProject_async_flattened_resourceNames]
}
