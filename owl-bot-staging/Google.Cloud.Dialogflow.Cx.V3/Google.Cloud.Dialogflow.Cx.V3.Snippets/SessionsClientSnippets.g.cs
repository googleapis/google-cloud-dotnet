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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Dialogflow.Cx.V3;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSessionsClientSnippets
    {
        /// <summary>Snippet for DetectIntent</summary>
        public void DetectIntentRequestObject()
        {
            // Snippet: DetectIntent(DetectIntentRequest, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            // Make the request
            DetectIntentResponse response = sessionsClient.DetectIntent(request);
            // End snippet
        }

        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentRequestObjectAsync()
        {
            // Snippet: DetectIntentAsync(DetectIntentRequest, CallSettings)
            // Additional: DetectIntentAsync(DetectIntentRequest, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ServerStreamingDetectIntent</summary>
        public async Task ServerStreamingDetectIntentRequestObject()
        {
            // Snippet: ServerStreamingDetectIntent(DetectIntentRequest, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            // Make the request, returning a streaming response
            using SessionsClient.ServerStreamingDetectIntentStream response = sessionsClient.ServerStreamingDetectIntent(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<DetectIntentResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                DetectIntentResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for StreamingDetectIntent</summary>
        public async Task StreamingDetectIntent()
        {
            // Snippet: StreamingDetectIntent(CallSettings, BidirectionalStreamingSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize streaming call, retrieving the stream object
            using SessionsClient.StreamingDetectIntentStream response = sessionsClient.StreamingDetectIntent();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingDetectIntentResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingDetectIntentResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingDetectIntentRequest request = new StreamingDetectIntentRequest
                {
                    SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                    QueryParams = new QueryParameters(),
                    QueryInput = new QueryInput(),
                    OutputAudioConfig = new OutputAudioConfig(),
                    EnablePartialResponse = false,
                    EnableDebuggingInfo = false,
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

        /// <summary>Snippet for MatchIntent</summary>
        public void MatchIntentRequestObject()
        {
            // Snippet: MatchIntent(MatchIntentRequest, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            MatchIntentRequest request = new MatchIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                PersistParameterChanges = false,
            };
            // Make the request
            MatchIntentResponse response = sessionsClient.MatchIntent(request);
            // End snippet
        }

        /// <summary>Snippet for MatchIntentAsync</summary>
        public async Task MatchIntentRequestObjectAsync()
        {
            // Snippet: MatchIntentAsync(MatchIntentRequest, CallSettings)
            // Additional: MatchIntentAsync(MatchIntentRequest, CancellationToken)
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
            // End snippet
        }

        /// <summary>Snippet for FulfillIntent</summary>
        public void FulfillIntentRequestObject()
        {
            // Snippet: FulfillIntent(FulfillIntentRequest, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            FulfillIntentRequest request = new FulfillIntentRequest
            {
                MatchIntentRequest = new MatchIntentRequest(),
                Match = new Match(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            // Make the request
            FulfillIntentResponse response = sessionsClient.FulfillIntent(request);
            // End snippet
        }

        /// <summary>Snippet for FulfillIntentAsync</summary>
        public async Task FulfillIntentRequestObjectAsync()
        {
            // Snippet: FulfillIntentAsync(FulfillIntentRequest, CallSettings)
            // Additional: FulfillIntentAsync(FulfillIntentRequest, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            FulfillIntentRequest request = new FulfillIntentRequest
            {
                MatchIntentRequest = new MatchIntentRequest(),
                Match = new Match(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            // Make the request
            FulfillIntentResponse response = await sessionsClient.FulfillIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitAnswerFeedback</summary>
        public void SubmitAnswerFeedbackRequestObject()
        {
            // Snippet: SubmitAnswerFeedback(SubmitAnswerFeedbackRequest, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            SubmitAnswerFeedbackRequest request = new SubmitAnswerFeedbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                ResponseId = "",
                AnswerFeedback = new AnswerFeedback(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AnswerFeedback response = sessionsClient.SubmitAnswerFeedback(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitAnswerFeedbackAsync</summary>
        public async Task SubmitAnswerFeedbackRequestObjectAsync()
        {
            // Snippet: SubmitAnswerFeedbackAsync(SubmitAnswerFeedbackRequest, CallSettings)
            // Additional: SubmitAnswerFeedbackAsync(SubmitAnswerFeedbackRequest, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            SubmitAnswerFeedbackRequest request = new SubmitAnswerFeedbackRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                ResponseId = "",
                AnswerFeedback = new AnswerFeedback(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AnswerFeedback response = await sessionsClient.SubmitAnswerFeedbackAsync(request);
            // End snippet
        }
    }
}
