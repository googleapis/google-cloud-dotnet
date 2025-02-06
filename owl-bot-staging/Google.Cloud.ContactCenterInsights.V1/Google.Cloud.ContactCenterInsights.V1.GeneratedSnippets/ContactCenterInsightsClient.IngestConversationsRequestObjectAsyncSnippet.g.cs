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
    // [START contactcenterinsights_v1_generated_ContactCenterInsights_IngestConversations_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ContactCenterInsights.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedContactCenterInsightsClientSnippets
    {
        /// <summary>Snippet for IngestConversationsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task IngestConversationsRequestObjectAsync()
        {
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IngestConversationsRequest request = new IngestConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GcsSource = new IngestConversationsRequest.Types.GcsSource(),
                TranscriptObjectConfig = new IngestConversationsRequest.Types.TranscriptObjectConfig(),
                ConversationConfig = new IngestConversationsRequest.Types.ConversationConfig(),
                RedactionConfig = new RedactionConfig(),
                SpeechConfig = new SpeechConfig(),
                SampleSize = 0,
            };
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = await contactCenterInsightsClient.IngestConversationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceIngestConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END contactcenterinsights_v1_generated_ContactCenterInsights_IngestConversations_async]
}
