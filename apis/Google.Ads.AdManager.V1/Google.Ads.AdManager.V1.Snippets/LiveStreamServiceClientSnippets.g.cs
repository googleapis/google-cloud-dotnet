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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLiveStreamServiceClientSnippets
    {
        /// <summary>Snippet for GetLiveStream</summary>
        public void GetLiveStreamRequestObject()
        {
            // Snippet: GetLiveStream(GetLiveStreamRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            GetLiveStreamRequest request = new GetLiveStreamRequest
            {
                LiveStreamName = LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            LiveStream response = liveStreamServiceClient.GetLiveStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveStreamAsync</summary>
        public async Task GetLiveStreamRequestObjectAsync()
        {
            // Snippet: GetLiveStreamAsync(GetLiveStreamRequest, CallSettings)
            // Additional: GetLiveStreamAsync(GetLiveStreamRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLiveStreamRequest request = new GetLiveStreamRequest
            {
                LiveStreamName = LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            LiveStream response = await liveStreamServiceClient.GetLiveStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLiveStream</summary>
        public void GetLiveStream()
        {
            // Snippet: GetLiveStream(string, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]";
            // Make the request
            LiveStream response = liveStreamServiceClient.GetLiveStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveStreamAsync</summary>
        public async Task GetLiveStreamAsync()
        {
            // Snippet: GetLiveStreamAsync(string, CallSettings)
            // Additional: GetLiveStreamAsync(string, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]";
            // Make the request
            LiveStream response = await liveStreamServiceClient.GetLiveStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveStream</summary>
        public void GetLiveStreamResourceNames()
        {
            // Snippet: GetLiveStream(LiveStreamName, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            LiveStreamName name = LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]");
            // Make the request
            LiveStream response = liveStreamServiceClient.GetLiveStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetLiveStreamAsync</summary>
        public async Task GetLiveStreamResourceNamesAsync()
        {
            // Snippet: GetLiveStreamAsync(LiveStreamName, CallSettings)
            // Additional: GetLiveStreamAsync(LiveStreamName, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveStreamName name = LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]");
            // Make the request
            LiveStream response = await liveStreamServiceClient.GetLiveStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreams</summary>
        public void ListLiveStreamsRequestObject()
        {
            // Snippet: ListLiveStreams(ListLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreamsAsync</summary>
        public async Task ListLiveStreamsRequestObjectAsync()
        {
            // Snippet: ListLiveStreamsAsync(ListLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLiveStreamsRequest request = new ListLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreams</summary>
        public void ListLiveStreams()
        {
            // Snippet: ListLiveStreams(string, string, int?, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreamsAsync</summary>
        public async Task ListLiveStreamsAsync()
        {
            // Snippet: ListLiveStreamsAsync(string, string, int?, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreams</summary>
        public void ListLiveStreamsResourceNames()
        {
            // Snippet: ListLiveStreams(NetworkName, string, int?, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLiveStreamsAsync</summary>
        public async Task ListLiveStreamsResourceNamesAsync()
        {
            // Snippet: ListLiveStreamsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListLiveStreamsResponse, LiveStream> response = liveStreamServiceClient.ListLiveStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LiveStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLiveStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LiveStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LiveStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LiveStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStream</summary>
        public void CreateLiveStreamRequestObject()
        {
            // Snippet: CreateLiveStream(CreateLiveStreamRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            CreateLiveStreamRequest request = new CreateLiveStreamRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStream = new LiveStream(),
            };
            // Make the request
            LiveStream response = liveStreamServiceClient.CreateLiveStream(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStreamAsync</summary>
        public async Task CreateLiveStreamRequestObjectAsync()
        {
            // Snippet: CreateLiveStreamAsync(CreateLiveStreamRequest, CallSettings)
            // Additional: CreateLiveStreamAsync(CreateLiveStreamRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLiveStreamRequest request = new CreateLiveStreamRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStream = new LiveStream(),
            };
            // Make the request
            LiveStream response = await liveStreamServiceClient.CreateLiveStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStream</summary>
        public void CreateLiveStream()
        {
            // Snippet: CreateLiveStream(string, LiveStream, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            LiveStream liveStream = new LiveStream();
            // Make the request
            LiveStream response = liveStreamServiceClient.CreateLiveStream(parent, liveStream);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStreamAsync</summary>
        public async Task CreateLiveStreamAsync()
        {
            // Snippet: CreateLiveStreamAsync(string, LiveStream, CallSettings)
            // Additional: CreateLiveStreamAsync(string, LiveStream, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            LiveStream liveStream = new LiveStream();
            // Make the request
            LiveStream response = await liveStreamServiceClient.CreateLiveStreamAsync(parent, liveStream);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStream</summary>
        public void CreateLiveStreamResourceNames()
        {
            // Snippet: CreateLiveStream(NetworkName, LiveStream, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            LiveStream liveStream = new LiveStream();
            // Make the request
            LiveStream response = liveStreamServiceClient.CreateLiveStream(parent, liveStream);
            // End snippet
        }

        /// <summary>Snippet for CreateLiveStreamAsync</summary>
        public async Task CreateLiveStreamResourceNamesAsync()
        {
            // Snippet: CreateLiveStreamAsync(NetworkName, LiveStream, CallSettings)
            // Additional: CreateLiveStreamAsync(NetworkName, LiveStream, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            LiveStream liveStream = new LiveStream();
            // Make the request
            LiveStream response = await liveStreamServiceClient.CreateLiveStreamAsync(parent, liveStream);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreams</summary>
        public void BatchCreateLiveStreamsRequestObject()
        {
            // Snippet: BatchCreateLiveStreams(BatchCreateLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateLiveStreamsRequest request = new BatchCreateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLiveStreamRequest(),
                },
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = liveStreamServiceClient.BatchCreateLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreamsAsync</summary>
        public async Task BatchCreateLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchCreateLiveStreamsAsync(BatchCreateLiveStreamsRequest, CallSettings)
            // Additional: BatchCreateLiveStreamsAsync(BatchCreateLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateLiveStreamsRequest request = new BatchCreateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLiveStreamRequest(),
                },
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = await liveStreamServiceClient.BatchCreateLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreams</summary>
        public void BatchCreateLiveStreams()
        {
            // Snippet: BatchCreateLiveStreams(string, IEnumerable<CreateLiveStreamRequest>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLiveStreamRequest> requests = new CreateLiveStreamRequest[]
            {
                new CreateLiveStreamRequest(),
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = liveStreamServiceClient.BatchCreateLiveStreams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreamsAsync</summary>
        public async Task BatchCreateLiveStreamsAsync()
        {
            // Snippet: BatchCreateLiveStreamsAsync(string, IEnumerable<CreateLiveStreamRequest>, CallSettings)
            // Additional: BatchCreateLiveStreamsAsync(string, IEnumerable<CreateLiveStreamRequest>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLiveStreamRequest> requests = new CreateLiveStreamRequest[]
            {
                new CreateLiveStreamRequest(),
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = await liveStreamServiceClient.BatchCreateLiveStreamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreams</summary>
        public void BatchCreateLiveStreamsResourceNames()
        {
            // Snippet: BatchCreateLiveStreams(NetworkName, IEnumerable<CreateLiveStreamRequest>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLiveStreamRequest> requests = new CreateLiveStreamRequest[]
            {
                new CreateLiveStreamRequest(),
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = liveStreamServiceClient.BatchCreateLiveStreams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLiveStreamsAsync</summary>
        public async Task BatchCreateLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchCreateLiveStreamsAsync(NetworkName, IEnumerable<CreateLiveStreamRequest>, CallSettings)
            // Additional: BatchCreateLiveStreamsAsync(NetworkName, IEnumerable<CreateLiveStreamRequest>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLiveStreamRequest> requests = new CreateLiveStreamRequest[]
            {
                new CreateLiveStreamRequest(),
            };
            // Make the request
            BatchCreateLiveStreamsResponse response = await liveStreamServiceClient.BatchCreateLiveStreamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateLiveStream</summary>
        public void UpdateLiveStreamRequestObject()
        {
            // Snippet: UpdateLiveStream(UpdateLiveStreamRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            UpdateLiveStreamRequest request = new UpdateLiveStreamRequest
            {
                LiveStream = new LiveStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LiveStream response = liveStreamServiceClient.UpdateLiveStream(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLiveStreamAsync</summary>
        public async Task UpdateLiveStreamRequestObjectAsync()
        {
            // Snippet: UpdateLiveStreamAsync(UpdateLiveStreamRequest, CallSettings)
            // Additional: UpdateLiveStreamAsync(UpdateLiveStreamRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLiveStreamRequest request = new UpdateLiveStreamRequest
            {
                LiveStream = new LiveStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LiveStream response = await liveStreamServiceClient.UpdateLiveStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLiveStream</summary>
        public void UpdateLiveStream()
        {
            // Snippet: UpdateLiveStream(LiveStream, FieldMask, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            LiveStream liveStream = new LiveStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LiveStream response = liveStreamServiceClient.UpdateLiveStream(liveStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLiveStreamAsync</summary>
        public async Task UpdateLiveStreamAsync()
        {
            // Snippet: UpdateLiveStreamAsync(LiveStream, FieldMask, CallSettings)
            // Additional: UpdateLiveStreamAsync(LiveStream, FieldMask, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            LiveStream liveStream = new LiveStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LiveStream response = await liveStreamServiceClient.UpdateLiveStreamAsync(liveStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreams</summary>
        public void BatchUpdateLiveStreamsRequestObject()
        {
            // Snippet: BatchUpdateLiveStreams(BatchUpdateLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateLiveStreamsRequest request = new BatchUpdateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLiveStreamRequest(),
                },
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = liveStreamServiceClient.BatchUpdateLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreamsAsync</summary>
        public async Task BatchUpdateLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchUpdateLiveStreamsAsync(BatchUpdateLiveStreamsRequest, CallSettings)
            // Additional: BatchUpdateLiveStreamsAsync(BatchUpdateLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateLiveStreamsRequest request = new BatchUpdateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLiveStreamRequest(),
                },
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = await liveStreamServiceClient.BatchUpdateLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreams</summary>
        public void BatchUpdateLiveStreams()
        {
            // Snippet: BatchUpdateLiveStreams(string, IEnumerable<UpdateLiveStreamRequest>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLiveStreamRequest> requests = new UpdateLiveStreamRequest[]
            {
                new UpdateLiveStreamRequest(),
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = liveStreamServiceClient.BatchUpdateLiveStreams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreamsAsync</summary>
        public async Task BatchUpdateLiveStreamsAsync()
        {
            // Snippet: BatchUpdateLiveStreamsAsync(string, IEnumerable<UpdateLiveStreamRequest>, CallSettings)
            // Additional: BatchUpdateLiveStreamsAsync(string, IEnumerable<UpdateLiveStreamRequest>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLiveStreamRequest> requests = new UpdateLiveStreamRequest[]
            {
                new UpdateLiveStreamRequest(),
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = await liveStreamServiceClient.BatchUpdateLiveStreamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreams</summary>
        public void BatchUpdateLiveStreamsResourceNames()
        {
            // Snippet: BatchUpdateLiveStreams(NetworkName, IEnumerable<UpdateLiveStreamRequest>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLiveStreamRequest> requests = new UpdateLiveStreamRequest[]
            {
                new UpdateLiveStreamRequest(),
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = liveStreamServiceClient.BatchUpdateLiveStreams(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLiveStreamsAsync</summary>
        public async Task BatchUpdateLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchUpdateLiveStreamsAsync(NetworkName, IEnumerable<UpdateLiveStreamRequest>, CallSettings)
            // Additional: BatchUpdateLiveStreamsAsync(NetworkName, IEnumerable<UpdateLiveStreamRequest>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLiveStreamRequest> requests = new UpdateLiveStreamRequest[]
            {
                new UpdateLiveStreamRequest(),
            };
            // Make the request
            BatchUpdateLiveStreamsResponse response = await liveStreamServiceClient.BatchUpdateLiveStreamsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreams</summary>
        public void BatchActivateLiveStreamsRequestObject()
        {
            // Snippet: BatchActivateLiveStreams(BatchActivateLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateLiveStreamsRequest request = new BatchActivateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = liveStreamServiceClient.BatchActivateLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreamsAsync</summary>
        public async Task BatchActivateLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchActivateLiveStreamsAsync(BatchActivateLiveStreamsRequest, CallSettings)
            // Additional: BatchActivateLiveStreamsAsync(BatchActivateLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateLiveStreamsRequest request = new BatchActivateLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = await liveStreamServiceClient.BatchActivateLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreams</summary>
        public void BatchActivateLiveStreams()
        {
            // Snippet: BatchActivateLiveStreams(string, IEnumerable<string>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = liveStreamServiceClient.BatchActivateLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreamsAsync</summary>
        public async Task BatchActivateLiveStreamsAsync()
        {
            // Snippet: BatchActivateLiveStreamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateLiveStreamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = await liveStreamServiceClient.BatchActivateLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreams</summary>
        public void BatchActivateLiveStreamsResourceNames()
        {
            // Snippet: BatchActivateLiveStreams(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = liveStreamServiceClient.BatchActivateLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLiveStreamsAsync</summary>
        public async Task BatchActivateLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchActivateLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Additional: BatchActivateLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchActivateLiveStreamsResponse response = await liveStreamServiceClient.BatchActivateLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreams</summary>
        public void BatchPauseLiveStreamsRequestObject()
        {
            // Snippet: BatchPauseLiveStreams(BatchPauseLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchPauseLiveStreamsRequest request = new BatchPauseLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = liveStreamServiceClient.BatchPauseLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreamsAsync</summary>
        public async Task BatchPauseLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchPauseLiveStreamsAsync(BatchPauseLiveStreamsRequest, CallSettings)
            // Additional: BatchPauseLiveStreamsAsync(BatchPauseLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPauseLiveStreamsRequest request = new BatchPauseLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreams</summary>
        public void BatchPauseLiveStreams()
        {
            // Snippet: BatchPauseLiveStreams(string, IEnumerable<string>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = liveStreamServiceClient.BatchPauseLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreamsAsync</summary>
        public async Task BatchPauseLiveStreamsAsync()
        {
            // Snippet: BatchPauseLiveStreamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPauseLiveStreamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreams</summary>
        public void BatchPauseLiveStreamsResourceNames()
        {
            // Snippet: BatchPauseLiveStreams(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = liveStreamServiceClient.BatchPauseLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLiveStreamsAsync</summary>
        public async Task BatchPauseLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchPauseLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Additional: BatchPauseLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchPauseLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreams</summary>
        public void BatchArchiveLiveStreamsRequestObject()
        {
            // Snippet: BatchArchiveLiveStreams(BatchArchiveLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveLiveStreamsRequest request = new BatchArchiveLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = liveStreamServiceClient.BatchArchiveLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreamsAsync</summary>
        public async Task BatchArchiveLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchArchiveLiveStreamsAsync(BatchArchiveLiveStreamsRequest, CallSettings)
            // Additional: BatchArchiveLiveStreamsAsync(BatchArchiveLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveLiveStreamsRequest request = new BatchArchiveLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = await liveStreamServiceClient.BatchArchiveLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreams</summary>
        public void BatchArchiveLiveStreams()
        {
            // Snippet: BatchArchiveLiveStreams(string, IEnumerable<string>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = liveStreamServiceClient.BatchArchiveLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreamsAsync</summary>
        public async Task BatchArchiveLiveStreamsAsync()
        {
            // Snippet: BatchArchiveLiveStreamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveLiveStreamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = await liveStreamServiceClient.BatchArchiveLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreams</summary>
        public void BatchArchiveLiveStreamsResourceNames()
        {
            // Snippet: BatchArchiveLiveStreams(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = liveStreamServiceClient.BatchArchiveLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLiveStreamsAsync</summary>
        public async Task BatchArchiveLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchArchiveLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Additional: BatchArchiveLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchArchiveLiveStreamsResponse response = await liveStreamServiceClient.BatchArchiveLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreams</summary>
        public void BatchPauseAdsLiveStreamsRequestObject()
        {
            // Snippet: BatchPauseAdsLiveStreams(BatchPauseAdsLiveStreamsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchPauseAdsLiveStreamsRequest request = new BatchPauseAdsLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = liveStreamServiceClient.BatchPauseAdsLiveStreams(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreamsAsync</summary>
        public async Task BatchPauseAdsLiveStreamsRequestObjectAsync()
        {
            // Snippet: BatchPauseAdsLiveStreamsAsync(BatchPauseAdsLiveStreamsRequest, CallSettings)
            // Additional: BatchPauseAdsLiveStreamsAsync(BatchPauseAdsLiveStreamsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPauseAdsLiveStreamsRequest request = new BatchPauseAdsLiveStreamsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseAdsLiveStreamsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreams</summary>
        public void BatchPauseAdsLiveStreams()
        {
            // Snippet: BatchPauseAdsLiveStreams(string, IEnumerable<string>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = liveStreamServiceClient.BatchPauseAdsLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreamsAsync</summary>
        public async Task BatchPauseAdsLiveStreamsAsync()
        {
            // Snippet: BatchPauseAdsLiveStreamsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPauseAdsLiveStreamsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseAdsLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreams</summary>
        public void BatchPauseAdsLiveStreamsResourceNames()
        {
            // Snippet: BatchPauseAdsLiveStreams(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = liveStreamServiceClient.BatchPauseAdsLiveStreams(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseAdsLiveStreamsAsync</summary>
        public async Task BatchPauseAdsLiveStreamsResourceNamesAsync()
        {
            // Snippet: BatchPauseAdsLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Additional: BatchPauseAdsLiveStreamsAsync(NetworkName, IEnumerable<LiveStreamName>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchPauseAdsLiveStreamsResponse response = await liveStreamServiceClient.BatchPauseAdsLiveStreamsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylists</summary>
        public void BatchRefreshMasterPlaylistsRequestObject()
        {
            // Snippet: BatchRefreshMasterPlaylists(BatchRefreshMasterPlaylistsRequest, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            BatchRefreshMasterPlaylistsRequest request = new BatchRefreshMasterPlaylistsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = liveStreamServiceClient.BatchRefreshMasterPlaylists(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylistsAsync</summary>
        public async Task BatchRefreshMasterPlaylistsRequestObjectAsync()
        {
            // Snippet: BatchRefreshMasterPlaylistsAsync(BatchRefreshMasterPlaylistsRequest, CallSettings)
            // Additional: BatchRefreshMasterPlaylistsAsync(BatchRefreshMasterPlaylistsRequest, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRefreshMasterPlaylistsRequest request = new BatchRefreshMasterPlaylistsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LiveStreamNames =
                {
                    LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
                },
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = await liveStreamServiceClient.BatchRefreshMasterPlaylistsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylists</summary>
        public void BatchRefreshMasterPlaylists()
        {
            // Snippet: BatchRefreshMasterPlaylists(string, IEnumerable<string>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = liveStreamServiceClient.BatchRefreshMasterPlaylists(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylistsAsync</summary>
        public async Task BatchRefreshMasterPlaylistsAsync()
        {
            // Snippet: BatchRefreshMasterPlaylistsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRefreshMasterPlaylistsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/liveStreams/[LIVE_STREAM]",
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = await liveStreamServiceClient.BatchRefreshMasterPlaylistsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylists</summary>
        public void BatchRefreshMasterPlaylistsResourceNames()
        {
            // Snippet: BatchRefreshMasterPlaylists(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = LiveStreamServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = liveStreamServiceClient.BatchRefreshMasterPlaylists(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRefreshMasterPlaylistsAsync</summary>
        public async Task BatchRefreshMasterPlaylistsResourceNamesAsync()
        {
            // Snippet: BatchRefreshMasterPlaylistsAsync(NetworkName, IEnumerable<LiveStreamName>, CallSettings)
            // Additional: BatchRefreshMasterPlaylistsAsync(NetworkName, IEnumerable<LiveStreamName>, CancellationToken)
            // Create client
            LiveStreamServiceClient liveStreamServiceClient = await LiveStreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LiveStreamName> names = new LiveStreamName[]
            {
                LiveStreamName.FromNetworkCodeLiveStream("[NETWORK_CODE]", "[LIVE_STREAM]"),
            };
            // Make the request
            BatchRefreshMasterPlaylistsResponse response = await liveStreamServiceClient.BatchRefreshMasterPlaylistsAsync(parent, names);
            // End snippet
        }
    }
}
