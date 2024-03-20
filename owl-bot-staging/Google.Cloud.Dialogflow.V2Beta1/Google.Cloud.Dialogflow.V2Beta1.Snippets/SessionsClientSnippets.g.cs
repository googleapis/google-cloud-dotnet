// Copyright 2024 Google LLC
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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf;
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
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
                InputAudio = ByteString.Empty,
                OutputAudioConfigMask = new FieldMask(),
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
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
                InputAudio = ByteString.Empty,
                OutputAudioConfigMask = new FieldMask(),
            };
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetectIntent</summary>
        public void DetectIntent()
        {
            // Snippet: DetectIntent(string, QueryInput, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/agent/sessions/[SESSION]";
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = sessionsClient.DetectIntent(session, queryInput);
            // End snippet
        }

        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentAsync()
        {
            // Snippet: DetectIntentAsync(string, QueryInput, CallSettings)
            // Additional: DetectIntentAsync(string, QueryInput, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/agent/sessions/[SESSION]";
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(session, queryInput);
            // End snippet
        }

        /// <summary>Snippet for DetectIntent</summary>
        public void DetectIntentResourceNames()
        {
            // Snippet: DetectIntent(SessionName, QueryInput, CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            SessionName session = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = sessionsClient.DetectIntent(session, queryInput);
            // End snippet
        }

        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentResourceNamesAsync()
        {
            // Snippet: DetectIntentAsync(SessionName, QueryInput, CallSettings)
            // Additional: DetectIntentAsync(SessionName, QueryInput, CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(session, queryInput);
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
                    SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                    QueryParams = new QueryParameters(),
                    QueryInput = new QueryInput(),
                    OutputAudioConfig = new OutputAudioConfig(),
                    InputAudio = ByteString.Empty,
                    OutputAudioConfigMask = new FieldMask(),
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
    }
}
