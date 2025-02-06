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
    // [START dialogflow_v2_generated_ConversationProfiles_SetSuggestionFeatureConfig_async_flattened1]
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedConversationProfilesClientSnippets
    {
        /// <summary>Snippet for SetSuggestionFeatureConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SetSuggestionFeatureConfig1Async()
        {
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            string conversationProfile = "";
            // Make the request
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> response = await conversationProfilesClient.SetSuggestionFeatureConfigAsync(conversationProfile);

            // Poll until the returned long-running operation is complete
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationProfile, SetSuggestionFeatureConfigOperationMetadata> retrievedResponse = await conversationProfilesClient.PollOnceSetSuggestionFeatureConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationProfile retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dialogflow_v2_generated_ConversationProfiles_SetSuggestionFeatureConfig_async_flattened1]
}
