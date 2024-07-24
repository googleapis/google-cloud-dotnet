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
    // [START developerconnect_v1_generated_DeveloperConnect_CreateConnection_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DeveloperConnect.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedDeveloperConnectClientSnippets
    {
        /// <summary>Snippet for CreateConnection</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateConnectionRequestObject()
        {
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.CreateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END developerconnect_v1_generated_DeveloperConnect_CreateConnection_sync]
}
