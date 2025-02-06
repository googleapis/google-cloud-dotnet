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

namespace GoogleCSharpSnippets
{
    // [START accesscontextmanager_v1_generated_AccessContextManager_CreateAccessLevel_async_flattened_resourceNames]
    using Google.Identity.AccessContextManager.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAccessContextManagerClientSnippets
    {
        /// <summary>Snippet for CreateAccessLevelAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateAccessLevelResourceNamesAsync()
        {
            // Create client
            AccessContextManagerClient accessContextManagerClient = await AccessContextManagerClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName parent = AccessPolicyName.FromAccessPolicy("[ACCESS_POLICY]");
            AccessLevel accessLevel = new AccessLevel();
            // Make the request
            Operation<AccessLevel, AccessContextManagerOperationMetadata> response = await accessContextManagerClient.CreateAccessLevelAsync(parent, accessLevel);

            // Poll until the returned long-running operation is complete
            Operation<AccessLevel, AccessContextManagerOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessLevel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessLevel, AccessContextManagerOperationMetadata> retrievedResponse = await accessContextManagerClient.PollOnceCreateAccessLevelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessLevel retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END accesscontextmanager_v1_generated_AccessContextManager_CreateAccessLevel_async_flattened_resourceNames]
}
