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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Ces.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSessionServiceClientSnippets
    {
        /// <summary>Snippet for RunSession</summary>
        public void RunSessionRequestObject()
        {
            // Snippet: RunSession(RunSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            RunSessionRequest request = new RunSessionRequest
            {
                Config = new SessionConfig(),
                Inputs = { new SessionInput(), },
            };
            // Make the request
            RunSessionResponse response = sessionServiceClient.RunSession(request);
            // End snippet
        }

        /// <summary>Snippet for RunSessionAsync</summary>
        public async Task RunSessionRequestObjectAsync()
        {
            // Snippet: RunSessionAsync(RunSessionRequest, CallSettings)
            // Additional: RunSessionAsync(RunSessionRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunSessionRequest request = new RunSessionRequest
            {
                Config = new SessionConfig(),
                Inputs = { new SessionInput(), },
            };
            // Make the request
            RunSessionResponse response = await sessionServiceClient.RunSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StreamRunSession</summary>
        public async Task StreamRunSessionRequestObject()
        {
            // Snippet: StreamRunSession(RunSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            RunSessionRequest request = new RunSessionRequest
            {
                Config = new SessionConfig(),
                Inputs = { new SessionInput(), },
            };
            // Make the request, returning a streaming response
            using SessionServiceClient.StreamRunSessionStream response = sessionServiceClient.StreamRunSession(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<RunSessionResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                RunSessionResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BidiRunSession</summary>
        public async Task BidiRunSession()
        {
            // Snippet: BidiRunSession(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SessionServiceClient.BidiRunSessionStream response = sessionServiceClient.BidiRunSession();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<BidiSessionServerMessage> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    BidiSessionServerMessage responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                BidiSessionClientMessage request = new BidiSessionClientMessage
                {
                    Config = new SessionConfig(),
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for StreamChatAiAssistant</summary>
        public async Task StreamChatAiAssistantRequestObject()
        {
            // Snippet: StreamChatAiAssistant(StreamChatAiAssistantRequest, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for CancelAssistantTurn</summary>
        public void CancelAssistantTurnRequestObject()
        {
            // Snippet: CancelAssistantTurn(CancelAssistantTurnRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            CancelAssistantTurnRequest request = new CancelAssistantTurnRequest { Name = "", TurnId = "", };
            // Make the request
            CancelAssistantTurnResponse response = sessionServiceClient.CancelAssistantTurn(request);
            // End snippet
        }

        /// <summary>Snippet for CancelAssistantTurnAsync</summary>
        public async Task CancelAssistantTurnRequestObjectAsync()
        {
            // Snippet: CancelAssistantTurnAsync(CancelAssistantTurnRequest, CallSettings)
            // Additional: CancelAssistantTurnAsync(CancelAssistantTurnRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelAssistantTurnRequest request = new CancelAssistantTurnRequest { Name = "", TurnId = "", };
            // Make the request
            CancelAssistantTurnResponse response = await sessionServiceClient.CancelAssistantTurnAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateOnboardingSuggestions</summary>
        public void GenerateOnboardingSuggestionsRequestObject()
        {
            // Snippet: GenerateOnboardingSuggestions(GenerateOnboardingSuggestionsRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            GenerateOnboardingSuggestionsRequest request = new GenerateOnboardingSuggestionsRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                MaxSuggestions = 0,
            };
            // Make the request
            GenerateOnboardingSuggestionsResponse response = sessionServiceClient.GenerateOnboardingSuggestions(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateOnboardingSuggestionsAsync</summary>
        public async Task GenerateOnboardingSuggestionsRequestObjectAsync()
        {
            // Snippet: GenerateOnboardingSuggestionsAsync(GenerateOnboardingSuggestionsRequest, CallSettings)
            // Additional: GenerateOnboardingSuggestionsAsync(GenerateOnboardingSuggestionsRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateOnboardingSuggestionsRequest request = new GenerateOnboardingSuggestionsRequest
            {
                AppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                MaxSuggestions = 0,
            };
            // Make the request
            GenerateOnboardingSuggestionsResponse response = await sessionServiceClient.GenerateOnboardingSuggestionsAsync(request);
            // End snippet
        }
    }
}
