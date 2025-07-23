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
    // [START discoveryengine_v1_generated_AssistantService_StreamAssist_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.DiscoveryEngine.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAssistantServiceClientSnippets
    {
        /// <summary>Snippet for StreamAssist</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task StreamAssistRequestObject()
        {
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            StreamAssistRequest request = new StreamAssistRequest
            {
                AssistantName = AssistantName.FromProjectLocationCollectionEngineAssistant("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]", "[ASSISTANT]"),
                Query = new Query(),
                SessionAsSessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                UserMetadata = new AssistUserMetadata(),
                ToolsSpec = new StreamAssistRequest.Types.ToolsSpec(),
                GenerationSpec = new StreamAssistRequest.Types.GenerationSpec(),
            };
            // Make the request, returning a streaming response
            using AssistantServiceClient.StreamAssistStream response = assistantServiceClient.StreamAssist(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamAssistResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamAssistResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END discoveryengine_v1_generated_AssistantService_StreamAssist_sync]
}
