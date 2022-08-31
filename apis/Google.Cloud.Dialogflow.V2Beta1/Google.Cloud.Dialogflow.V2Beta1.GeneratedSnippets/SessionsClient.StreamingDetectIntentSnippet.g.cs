// Copyright 2022 Google LLC
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

namespace Google.Cloud.Dialogflow.V2Beta1.Snippets
{
    // [START dialogflow_v2beta1_generated_Sessions_StreamingDetectIntent_sync]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSessionsClientSnippets
    {
        /// <summary>Snippet for StreamingDetectIntent</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task StreamingDetectIntent()
        {
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize streaming call, retrieving the stream object
            SessionsClient.StreamingDetectIntentStream response = sessionsClient.StreamingDetectIntent();

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
        }
    }
    // [END dialogflow_v2beta1_generated_Sessions_StreamingDetectIntent_sync]
}
