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
    // [START ces_v1beta_generated_SessionService_StreamChatAiAssistant_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Ces.V1Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSessionServiceClientSnippets
    {
        /// <summary>Snippet for StreamChatAiAssistant</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task StreamChatAiAssistantRequestObject()
        {
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            StreamChatAiAssistantRequest request = new StreamChatAiAssistantRequest
            {
                AssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
                Message = "",
                AttachedGcsUris = { "", },
                ContextToken = "",
                ConfirmationResponse = new AssistantConfirmationResponse(),
                ClientCapabilities =
                {
                    StreamChatAiAssistantRequest.Types.ClientCapability.Unspecified,
                },
                OperationCompletedEvent = new OperationCompletedEvent(),
                ResumeFromSequenceNumber = 0L,
                AttachOnly = false,
            };
            // Make the request, returning a streaming response
            using SessionServiceClient.StreamChatAiAssistantStream response = sessionServiceClient.StreamChatAiAssistant(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<StreamChatAiAssistantResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                StreamChatAiAssistantResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END ces_v1beta_generated_SessionService_StreamChatAiAssistant_sync]
}
