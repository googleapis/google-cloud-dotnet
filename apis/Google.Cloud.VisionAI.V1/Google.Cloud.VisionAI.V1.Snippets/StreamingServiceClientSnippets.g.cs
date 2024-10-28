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
    using Google.Cloud.VisionAI.V1;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStreamingServiceClientSnippets
    {
        /// <summary>Snippet for SendPackets</summary>
        public async Task SendPackets()
        {
            // Snippet: SendPackets(CallSettings, BidirectionalStreamingSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using StreamingServiceClient.SendPacketsStream response = streamingServiceClient.SendPackets();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<SendPacketsResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    SendPacketsResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                SendPacketsRequest request = new SendPacketsRequest
                {
                    Packet = new Packet(),
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

        /// <summary>Snippet for ReceivePackets</summary>
        public async Task ReceivePackets()
        {
            // Snippet: ReceivePackets(CallSettings, BidirectionalStreamingSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using StreamingServiceClient.ReceivePacketsStream response = streamingServiceClient.ReceivePackets();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<ReceivePacketsResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    ReceivePacketsResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                ReceivePacketsRequest request = new ReceivePacketsRequest
                {
                    SetupRequest = new ReceivePacketsRequest.Types.SetupRequest(),
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

        /// <summary>Snippet for ReceiveEvents</summary>
        public async Task ReceiveEvents()
        {
            // Snippet: ReceiveEvents(CallSettings, BidirectionalStreamingSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize streaming call, retrieving the stream object
            using StreamingServiceClient.ReceiveEventsStream response = streamingServiceClient.ReceiveEvents();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<ReceiveEventsResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    ReceiveEventsResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                ReceiveEventsRequest request = new ReceiveEventsRequest
                {
                    SetupRequest = new ReceiveEventsRequest.Types.SetupRequest(),
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

        /// <summary>Snippet for AcquireLease</summary>
        public void AcquireLeaseRequestObject()
        {
            // Snippet: AcquireLease(AcquireLeaseRequest, CallSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize request argument(s)
            AcquireLeaseRequest request = new AcquireLeaseRequest
            {
                Series = "",
                Owner = "",
                Term = new Duration(),
                LeaseType = LeaseType.Unspecified,
            };
            // Make the request
            Lease response = streamingServiceClient.AcquireLease(request);
            // End snippet
        }

        /// <summary>Snippet for AcquireLeaseAsync</summary>
        public async Task AcquireLeaseRequestObjectAsync()
        {
            // Snippet: AcquireLeaseAsync(AcquireLeaseRequest, CallSettings)
            // Additional: AcquireLeaseAsync(AcquireLeaseRequest, CancellationToken)
            // Create client
            StreamingServiceClient streamingServiceClient = await StreamingServiceClient.CreateAsync();
            // Initialize request argument(s)
            AcquireLeaseRequest request = new AcquireLeaseRequest
            {
                Series = "",
                Owner = "",
                Term = new Duration(),
                LeaseType = LeaseType.Unspecified,
            };
            // Make the request
            Lease response = await streamingServiceClient.AcquireLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLease</summary>
        public void RenewLeaseRequestObject()
        {
            // Snippet: RenewLease(RenewLeaseRequest, CallSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                Id = "",
                Series = "",
                Owner = "",
                Term = new Duration(),
            };
            // Make the request
            Lease response = streamingServiceClient.RenewLease(request);
            // End snippet
        }

        /// <summary>Snippet for RenewLeaseAsync</summary>
        public async Task RenewLeaseRequestObjectAsync()
        {
            // Snippet: RenewLeaseAsync(RenewLeaseRequest, CallSettings)
            // Additional: RenewLeaseAsync(RenewLeaseRequest, CancellationToken)
            // Create client
            StreamingServiceClient streamingServiceClient = await StreamingServiceClient.CreateAsync();
            // Initialize request argument(s)
            RenewLeaseRequest request = new RenewLeaseRequest
            {
                Id = "",
                Series = "",
                Owner = "",
                Term = new Duration(),
            };
            // Make the request
            Lease response = await streamingServiceClient.RenewLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReleaseLease</summary>
        public void ReleaseLeaseRequestObject()
        {
            // Snippet: ReleaseLease(ReleaseLeaseRequest, CallSettings)
            // Create client
            StreamingServiceClient streamingServiceClient = StreamingServiceClient.Create();
            // Initialize request argument(s)
            ReleaseLeaseRequest request = new ReleaseLeaseRequest
            {
                Id = "",
                Series = "",
                Owner = "",
            };
            // Make the request
            ReleaseLeaseResponse response = streamingServiceClient.ReleaseLease(request);
            // End snippet
        }

        /// <summary>Snippet for ReleaseLeaseAsync</summary>
        public async Task ReleaseLeaseRequestObjectAsync()
        {
            // Snippet: ReleaseLeaseAsync(ReleaseLeaseRequest, CallSettings)
            // Additional: ReleaseLeaseAsync(ReleaseLeaseRequest, CancellationToken)
            // Create client
            StreamingServiceClient streamingServiceClient = await StreamingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseLeaseRequest request = new ReleaseLeaseRequest
            {
                Id = "",
                Series = "",
                Owner = "",
            };
            // Make the request
            ReleaseLeaseResponse response = await streamingServiceClient.ReleaseLeaseAsync(request);
            // End snippet
        }
    }
}
