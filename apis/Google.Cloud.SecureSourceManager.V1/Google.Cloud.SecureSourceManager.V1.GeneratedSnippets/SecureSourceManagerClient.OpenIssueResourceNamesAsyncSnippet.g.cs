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
    // [START securesourcemanager_v1_generated_SecureSourceManager_OpenIssue_async_flattened_resourceNames]
    using Google.Cloud.SecureSourceManager.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSecureSourceManagerClientSnippets
    {
        /// <summary>Snippet for OpenIssueAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task OpenIssueResourceNamesAsync()
        {
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.OpenIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END securesourcemanager_v1_generated_SecureSourceManager_OpenIssue_async_flattened_resourceNames]
}
