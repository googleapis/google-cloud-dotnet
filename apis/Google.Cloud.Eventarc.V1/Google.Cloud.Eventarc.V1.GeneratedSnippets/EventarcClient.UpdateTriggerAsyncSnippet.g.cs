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
    // [START eventarc_v1_generated_Eventarc_UpdateTrigger_async_flattened]
    using Google.Cloud.Eventarc.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEventarcClientSnippets
    {
        /// <summary>Snippet for UpdateTriggerAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateTriggerAsync()
        {
            // Create client
            EventarcClient eventarcClient = await EventarcClient.CreateAsync();
            // Initialize request argument(s)
            Trigger trigger = new Trigger();
            FieldMask updateMask = new FieldMask();
            bool allowMissing = false;
            // Make the request
            Operation<Trigger, OperationMetadata> response = await eventarcClient.UpdateTriggerAsync(trigger, updateMask, allowMissing);

            // Poll until the returned long-running operation is complete
            Operation<Trigger, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Trigger result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Trigger, OperationMetadata> retrievedResponse = await eventarcClient.PollOnceUpdateTriggerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Trigger retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END eventarc_v1_generated_Eventarc_UpdateTrigger_async_flattened]
}
