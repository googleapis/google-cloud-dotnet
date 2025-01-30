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
    // [START apikeys_v2_generated_ApiKeys_CreateKey_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ApiKeys.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedApiKeysClientSnippets
    {
        /// <summary>Snippet for CreateKey</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateKeyResourceNames()
        {
            // Create client
            ApiKeysClient apiKeysClient = ApiKeysClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Key key = new Key();
            string keyId = "";
            // Make the request
            Operation<Key, Empty> response = apiKeysClient.CreateKey(parent, key, keyId);

            // Poll until the returned long-running operation is complete
            Operation<Key, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Key result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Key, Empty> retrievedResponse = apiKeysClient.PollOnceCreateKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Key retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END apikeys_v2_generated_ApiKeys_CreateKey_sync_flattened_resourceNames]
}
