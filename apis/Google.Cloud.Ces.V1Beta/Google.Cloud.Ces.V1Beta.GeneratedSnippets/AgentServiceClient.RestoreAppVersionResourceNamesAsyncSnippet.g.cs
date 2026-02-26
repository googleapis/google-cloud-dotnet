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
    // [START ces_v1beta_generated_AgentService_RestoreAppVersion_async_flattened_resourceNames]
    using Google.Cloud.Ces.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAgentServiceClientSnippets
    {
        /// <summary>Snippet for RestoreAppVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RestoreAppVersionResourceNamesAsync()
        {
            // Create client
            AgentServiceClient agentServiceClient = await AgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppVersionName name = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]");
            // Make the request
            Operation<RestoreAppVersionResponse, OperationMetadata> response = await agentServiceClient.RestoreAppVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreAppVersionResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreAppVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreAppVersionResponse, OperationMetadata> retrievedResponse = await agentServiceClient.PollOnceRestoreAppVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreAppVersionResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END ces_v1beta_generated_AgentService_RestoreAppVersion_async_flattened_resourceNames]
}
