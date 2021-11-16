// Copyright 2021 Google LLC
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

namespace Google.Cloud.PubSub.V1.Snippets
{
    using Google.Api.Gax.Grpc;
    using Google.Cloud.PubSub.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSubscriberClientStandaloneSnippets
    {
        /// <summary>Snippet for StreamingPull</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task StreamingPull()
        {
            // Create client
            SubscriberClient subscriberClient = SubscriberClient.Create();
            // Initialize streaming call, retrieving the stream object
            SubscriberClient.StreamingPullStream response = subscriberClient.StreamingPull();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingPullResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingPullResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingPullRequest request = new StreamingPullRequest
                {
                    SubscriptionAsSubscriptionName = SubscriptionName.FromProjectSubscription("[PROJECT]", "[SUBSCRIPTION]"),
                    AckIds = { "", },
                    ModifyDeadlineSeconds = { 0, },
                    ModifyDeadlineAckIds = { "", },
                    StreamAckDeadlineSeconds = 0,
                    ClientId = "",
                    MaxOutstandingMessages = 0L,
                    MaxOutstandingBytes = 0L,
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
}
