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

namespace Google.Cloud.Shell.V1.Snippets
{
    using Google.Cloud.Shell.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedCloudShellServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for RemovePublicKeyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task RemovePublicKeyRequestObjectAsync()
        {
            // Create client
            CloudShellServiceClient cloudShellServiceClient = await CloudShellServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemovePublicKeyRequest request = new RemovePublicKeyRequest
            {
                Environment = "",
                Key = "",
            };
            // Make the request
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> response = await cloudShellServiceClient.RemovePublicKeyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemovePublicKeyResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemovePublicKeyResponse, RemovePublicKeyMetadata> retrievedResponse = await cloudShellServiceClient.PollOnceRemovePublicKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemovePublicKeyResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
}
