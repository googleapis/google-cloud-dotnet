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
    }
}
