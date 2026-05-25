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
    // [START networksecurity_v1_generated_SSERealmService_CreateSACAttachment_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedSSERealmServiceClientSnippets
    {
        /// <summary>Snippet for CreateSACAttachment</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateSACAttachmentRequestObject()
        {
            // Create client
            SSERealmServiceClient sSERealmServiceClient = SSERealmServiceClient.Create();
            // Initialize request argument(s)
            CreateSACAttachmentRequest request = new CreateSACAttachmentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SacAttachmentId = "",
                SacAttachment = new SACAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<SACAttachment, OperationMetadata> response = sSERealmServiceClient.CreateSACAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<SACAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SACAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SACAttachment, OperationMetadata> retrievedResponse = sSERealmServiceClient.PollOnceCreateSACAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SACAttachment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1_generated_SSERealmService_CreateSACAttachment_sync]
}
