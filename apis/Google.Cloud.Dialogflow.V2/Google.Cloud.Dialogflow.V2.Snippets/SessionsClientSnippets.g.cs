// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dialogflow.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedSessionsClientSnippets
    {
        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentAsync()
        {
            // Snippet: DetectIntentAsync(SessionName,QueryInput,CallSettings)
            // Additional: DetectIntentAsync(SessionName,QueryInput,CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(session, queryInput);
            // End snippet
        }

        /// <summary>Snippet for DetectIntent</summary>
        public void DetectIntent()
        {
            // Snippet: DetectIntent(SessionName,QueryInput,CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[SESSION]");
            QueryInput queryInput = new QueryInput();
            // Make the request
            DetectIntentResponse response = sessionsClient.DetectIntent(session, queryInput);
            // End snippet
        }

        /// <summary>Snippet for DetectIntentAsync</summary>
        public async Task DetectIntentAsync_RequestObject()
        {
            // Snippet: DetectIntentAsync(DetectIntentRequest,CallSettings)
            // Additional: DetectIntentAsync(DetectIntentRequest,CancellationToken)
            // Create client
            SessionsClient sessionsClient = await SessionsClient.CreateAsync();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            // Make the request
            DetectIntentResponse response = await sessionsClient.DetectIntentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DetectIntent</summary>
        public void DetectIntent_RequestObject()
        {
            // Snippet: DetectIntent(DetectIntentRequest,CallSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize request argument(s)
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            // Make the request
            DetectIntentResponse response = sessionsClient.DetectIntent(request);
            // End snippet
        }

        /// <summary>Snippet for StreamingDetectIntent</summary>
        public async Task StreamingDetectIntent()
        {
            // Snippet: StreamingDetectIntent(CallSettings,BidirectionalStreamingSettings)
            // Create client
            SessionsClient sessionsClient = SessionsClient.Create();
            // Initialize streaming call, retrieving the stream object
            SessionsClient.StreamingDetectIntentStream duplexStream = sessionsClient.StreamingDetectIntent();

            // Sending requests and retrieving responses can be arbitrarily interleaved.
            // Exact sequence will depend on client/server behavior.

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                var responseStream = duplexStream.GrpcCall.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    StreamingDetectIntentResponse response = responseStream.Current;
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
                    Session = "",
                    QueryInput = new QueryInput(),
                };
                // Stream a request to the server
                await duplexStream.WriteAsync(request);

                // Set "done" to true when sending requests is complete
            }
            // Complete writing requests to the stream
            await duplexStream.WriteCompleteAsync();
            // Await the response handler.
            // This will complete once all server responses have been processed.
            await responseHandlerTask;
            // End snippet
        }

    }
}
