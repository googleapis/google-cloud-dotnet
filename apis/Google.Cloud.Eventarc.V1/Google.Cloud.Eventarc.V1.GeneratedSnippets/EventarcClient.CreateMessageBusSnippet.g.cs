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
    // [START eventarc_v1_generated_Eventarc_CreateMessageBus_sync_flattened]
    using Google.Cloud.Eventarc.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedEventarcClientSnippets
    {
        /// <summary>Snippet for CreateMessageBus</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateMessageBus()
        {
            // Create client
            EventarcClient eventarcClient = EventarcClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MessageBus messageBus = new MessageBus();
            string messageBusId = "";
            // Make the request
            Operation<MessageBus, OperationMetadata> response = eventarcClient.CreateMessageBus(parent, messageBus, messageBusId);

            // Poll until the returned long-running operation is complete
            Operation<MessageBus, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MessageBus result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MessageBus, OperationMetadata> retrievedResponse = eventarcClient.PollOnceCreateMessageBus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MessageBus retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END eventarc_v1_generated_Eventarc_CreateMessageBus_sync_flattened]
}
