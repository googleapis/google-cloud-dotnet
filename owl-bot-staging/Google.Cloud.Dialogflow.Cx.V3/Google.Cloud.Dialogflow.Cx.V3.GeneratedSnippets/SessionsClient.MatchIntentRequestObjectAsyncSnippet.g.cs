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
    // [START dialogflow_v3_generated_Sessions_MatchIntent_async]
    using Google.Cloud.Dialogflow.Cx.V3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSessionsClientSnippets
    {
        /// <summary>Snippet for MatchIntentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task MatchIntentRequestObjectAsync()
        {
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            MatchIntentRequest request = new MatchIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                PersistParameterChanges = false,
            };
            // Make the request
            MatchIntentResponse response = await sessionsClient.MatchIntentAsync(request);
        }
    }
    // [END dialogflow_v3_generated_Sessions_MatchIntent_async]
}
