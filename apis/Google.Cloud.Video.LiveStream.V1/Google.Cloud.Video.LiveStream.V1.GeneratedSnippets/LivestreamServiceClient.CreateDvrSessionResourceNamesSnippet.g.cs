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
    // [START livestream_v1_generated_LivestreamService_CreateDvrSession_sync_flattened_resourceNames]
    using Google.Cloud.Video.LiveStream.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedLivestreamServiceClientSnippets
    {
        /// <summary>Snippet for CreateDvrSession</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateDvrSessionResourceNames()
        {
            // Create client
            LivestreamServiceClient livestreamServiceClient = LivestreamServiceClient.Create();
            // Initialize request argument(s)
            ChannelName parent = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]");
            DvrSession dvrSession = new DvrSession();
            string dvrSessionId = "";
            // Make the request
            Operation<DvrSession, OperationMetadata> response = livestreamServiceClient.CreateDvrSession(parent, dvrSession, dvrSessionId);

            // Poll until the returned long-running operation is complete
            Operation<DvrSession, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DvrSession result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DvrSession, OperationMetadata> retrievedResponse = livestreamServiceClient.PollOnceCreateDvrSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DvrSession retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END livestream_v1_generated_LivestreamService_CreateDvrSession_sync_flattened_resourceNames]
}
