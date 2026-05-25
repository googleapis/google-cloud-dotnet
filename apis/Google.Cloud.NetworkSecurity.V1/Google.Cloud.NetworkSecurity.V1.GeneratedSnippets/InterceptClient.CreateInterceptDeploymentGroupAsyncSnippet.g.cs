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
    // [START networksecurity_v1_generated_Intercept_CreateInterceptDeploymentGroup_async_flattened]
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedInterceptClientSnippets
    {
        /// <summary>Snippet for CreateInterceptDeploymentGroupAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateInterceptDeploymentGroupAsync()
        {
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            string interceptDeploymentGroupId = "";
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentGroupAsync(parent, interceptDeploymentGroup, interceptDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1_generated_Intercept_CreateInterceptDeploymentGroup_async_flattened]
}
