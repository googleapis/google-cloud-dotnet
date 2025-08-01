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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START compute_v1_generated_InterconnectAttachmentGroups_Insert_sync]
    using Google.Cloud.Compute.V1;
    using lro = Google.LongRunning;

    public sealed partial class GeneratedInterconnectAttachmentGroupsClientSnippets
    {
        /// <summary>Snippet for Insert</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void InsertRequestObject()
        {
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectAttachmentGroupRequest request = new InsertInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroupResource = new InterconnectAttachmentGroup(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END compute_v1_generated_InterconnectAttachmentGroups_Insert_sync]
}
