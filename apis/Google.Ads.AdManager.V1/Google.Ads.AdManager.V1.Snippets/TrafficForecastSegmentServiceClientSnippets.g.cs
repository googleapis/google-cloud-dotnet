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
    public sealed class AllGeneratedTrafficForecastSegmentServiceClientSnippets
    {
        /// <summary>Snippet for GetTrafficForecastSegment</summary>
        public void GetTrafficForecastSegmentRequestObject()
        {
            // Snippet: GetTrafficForecastSegment(GetTrafficForecastSegmentRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            GetTrafficForecastSegmentRequest request = new GetTrafficForecastSegmentRequest
            {
                TrafficForecastSegmentName = TrafficForecastSegmentName.FromNetworkCodeTrafficForecastSegment("[NETWORK_CODE]", "[TRAFFIC_FORECAST_SEGMENT]"),
            };
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.GetTrafficForecastSegment(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrafficForecastSegmentAsync</summary>
        public async Task GetTrafficForecastSegmentRequestObjectAsync()
        {
            // Snippet: GetTrafficForecastSegmentAsync(GetTrafficForecastSegmentRequest, CallSettings)
            // Additional: GetTrafficForecastSegmentAsync(GetTrafficForecastSegmentRequest, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTrafficForecastSegmentRequest request = new GetTrafficForecastSegmentRequest
            {
                TrafficForecastSegmentName = TrafficForecastSegmentName.FromNetworkCodeTrafficForecastSegment("[NETWORK_CODE]", "[TRAFFIC_FORECAST_SEGMENT]"),
            };
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.GetTrafficForecastSegmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTrafficForecastSegment</summary>
        public void GetTrafficForecastSegment()
        {
            // Snippet: GetTrafficForecastSegment(string, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/trafficForecastSegments/[TRAFFIC_FORECAST_SEGMENT]";
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.GetTrafficForecastSegment(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrafficForecastSegmentAsync</summary>
        public async Task GetTrafficForecastSegmentAsync()
        {
            // Snippet: GetTrafficForecastSegmentAsync(string, CallSettings)
            // Additional: GetTrafficForecastSegmentAsync(string, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/trafficForecastSegments/[TRAFFIC_FORECAST_SEGMENT]";
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.GetTrafficForecastSegmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrafficForecastSegment</summary>
        public void GetTrafficForecastSegmentResourceNames()
        {
            // Snippet: GetTrafficForecastSegment(TrafficForecastSegmentName, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            TrafficForecastSegmentName name = TrafficForecastSegmentName.FromNetworkCodeTrafficForecastSegment("[NETWORK_CODE]", "[TRAFFIC_FORECAST_SEGMENT]");
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.GetTrafficForecastSegment(name);
            // End snippet
        }

        /// <summary>Snippet for GetTrafficForecastSegmentAsync</summary>
        public async Task GetTrafficForecastSegmentResourceNamesAsync()
        {
            // Snippet: GetTrafficForecastSegmentAsync(TrafficForecastSegmentName, CallSettings)
            // Additional: GetTrafficForecastSegmentAsync(TrafficForecastSegmentName, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrafficForecastSegmentName name = TrafficForecastSegmentName.FromNetworkCodeTrafficForecastSegment("[NETWORK_CODE]", "[TRAFFIC_FORECAST_SEGMENT]");
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.GetTrafficForecastSegmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegments</summary>
        public void ListTrafficForecastSegmentsRequestObject()
        {
            // Snippet: ListTrafficForecastSegments(ListTrafficForecastSegmentsRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegmentsAsync</summary>
        public async Task ListTrafficForecastSegmentsRequestObjectAsync()
        {
            // Snippet: ListTrafficForecastSegmentsAsync(ListTrafficForecastSegmentsRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTrafficForecastSegmentsRequest request = new ListTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegments</summary>
        public void ListTrafficForecastSegments()
        {
            // Snippet: ListTrafficForecastSegments(string, string, int?, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegmentsAsync</summary>
        public async Task ListTrafficForecastSegmentsAsync()
        {
            // Snippet: ListTrafficForecastSegmentsAsync(string, string, int?, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegments</summary>
        public void ListTrafficForecastSegmentsResourceNames()
        {
            // Snippet: ListTrafficForecastSegments(NetworkName, string, int?, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTrafficForecastSegmentsAsync</summary>
        public async Task ListTrafficForecastSegmentsResourceNamesAsync()
        {
            // Snippet: ListTrafficForecastSegmentsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListTrafficForecastSegmentsResponse, TrafficForecastSegment> response = trafficForecastSegmentServiceClient.ListTrafficForecastSegmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TrafficForecastSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTrafficForecastSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TrafficForecastSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TrafficForecastSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TrafficForecastSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegment</summary>
        public void CreateTrafficForecastSegmentRequestObject()
        {
            // Snippet: CreateTrafficForecastSegment(CreateTrafficForecastSegmentRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            CreateTrafficForecastSegmentRequest request = new CreateTrafficForecastSegmentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TrafficForecastSegment = new TrafficForecastSegment(),
            };
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.CreateTrafficForecastSegment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegmentAsync</summary>
        public async Task CreateTrafficForecastSegmentRequestObjectAsync()
        {
            // Snippet: CreateTrafficForecastSegmentAsync(CreateTrafficForecastSegmentRequest, CallSettings)
            // Additional: CreateTrafficForecastSegmentAsync(CreateTrafficForecastSegmentRequest, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTrafficForecastSegmentRequest request = new CreateTrafficForecastSegmentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TrafficForecastSegment = new TrafficForecastSegment(),
            };
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.CreateTrafficForecastSegmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegment</summary>
        public void CreateTrafficForecastSegment()
        {
            // Snippet: CreateTrafficForecastSegment(string, TrafficForecastSegment, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.CreateTrafficForecastSegment(parent, trafficForecastSegment);
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegmentAsync</summary>
        public async Task CreateTrafficForecastSegmentAsync()
        {
            // Snippet: CreateTrafficForecastSegmentAsync(string, TrafficForecastSegment, CallSettings)
            // Additional: CreateTrafficForecastSegmentAsync(string, TrafficForecastSegment, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.CreateTrafficForecastSegmentAsync(parent, trafficForecastSegment);
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegment</summary>
        public void CreateTrafficForecastSegmentResourceNames()
        {
            // Snippet: CreateTrafficForecastSegment(NetworkName, TrafficForecastSegment, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.CreateTrafficForecastSegment(parent, trafficForecastSegment);
            // End snippet
        }

        /// <summary>Snippet for CreateTrafficForecastSegmentAsync</summary>
        public async Task CreateTrafficForecastSegmentResourceNamesAsync()
        {
            // Snippet: CreateTrafficForecastSegmentAsync(NetworkName, TrafficForecastSegment, CallSettings)
            // Additional: CreateTrafficForecastSegmentAsync(NetworkName, TrafficForecastSegment, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.CreateTrafficForecastSegmentAsync(parent, trafficForecastSegment);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegments</summary>
        public void BatchCreateTrafficForecastSegmentsRequestObject()
        {
            // Snippet: BatchCreateTrafficForecastSegments(BatchCreateTrafficForecastSegmentsRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTrafficForecastSegmentsRequest request = new BatchCreateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTrafficForecastSegmentRequest(),
                },
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegmentsAsync</summary>
        public async Task BatchCreateTrafficForecastSegmentsRequestObjectAsync()
        {
            // Snippet: BatchCreateTrafficForecastSegmentsAsync(BatchCreateTrafficForecastSegmentsRequest, CallSettings)
            // Additional: BatchCreateTrafficForecastSegmentsAsync(BatchCreateTrafficForecastSegmentsRequest, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTrafficForecastSegmentsRequest request = new BatchCreateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTrafficForecastSegmentRequest(),
                },
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegments</summary>
        public void BatchCreateTrafficForecastSegments()
        {
            // Snippet: BatchCreateTrafficForecastSegments(string, IEnumerable<CreateTrafficForecastSegmentRequest>, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTrafficForecastSegmentRequest> requests = new CreateTrafficForecastSegmentRequest[]
            {
                new CreateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegmentsAsync</summary>
        public async Task BatchCreateTrafficForecastSegmentsAsync()
        {
            // Snippet: BatchCreateTrafficForecastSegmentsAsync(string, IEnumerable<CreateTrafficForecastSegmentRequest>, CallSettings)
            // Additional: BatchCreateTrafficForecastSegmentsAsync(string, IEnumerable<CreateTrafficForecastSegmentRequest>, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTrafficForecastSegmentRequest> requests = new CreateTrafficForecastSegmentRequest[]
            {
                new CreateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegments</summary>
        public void BatchCreateTrafficForecastSegmentsResourceNames()
        {
            // Snippet: BatchCreateTrafficForecastSegments(NetworkName, IEnumerable<CreateTrafficForecastSegmentRequest>, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTrafficForecastSegmentRequest> requests = new CreateTrafficForecastSegmentRequest[]
            {
                new CreateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTrafficForecastSegmentsAsync</summary>
        public async Task BatchCreateTrafficForecastSegmentsResourceNamesAsync()
        {
            // Snippet: BatchCreateTrafficForecastSegmentsAsync(NetworkName, IEnumerable<CreateTrafficForecastSegmentRequest>, CallSettings)
            // Additional: BatchCreateTrafficForecastSegmentsAsync(NetworkName, IEnumerable<CreateTrafficForecastSegmentRequest>, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTrafficForecastSegmentRequest> requests = new CreateTrafficForecastSegmentRequest[]
            {
                new CreateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchCreateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchCreateTrafficForecastSegmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateTrafficForecastSegment</summary>
        public void UpdateTrafficForecastSegmentRequestObject()
        {
            // Snippet: UpdateTrafficForecastSegment(UpdateTrafficForecastSegmentRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            UpdateTrafficForecastSegmentRequest request = new UpdateTrafficForecastSegmentRequest
            {
                TrafficForecastSegment = new TrafficForecastSegment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.UpdateTrafficForecastSegment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTrafficForecastSegmentAsync</summary>
        public async Task UpdateTrafficForecastSegmentRequestObjectAsync()
        {
            // Snippet: UpdateTrafficForecastSegmentAsync(UpdateTrafficForecastSegmentRequest, CallSettings)
            // Additional: UpdateTrafficForecastSegmentAsync(UpdateTrafficForecastSegmentRequest, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTrafficForecastSegmentRequest request = new UpdateTrafficForecastSegmentRequest
            {
                TrafficForecastSegment = new TrafficForecastSegment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.UpdateTrafficForecastSegmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTrafficForecastSegment</summary>
        public void UpdateTrafficForecastSegment()
        {
            // Snippet: UpdateTrafficForecastSegment(TrafficForecastSegment, FieldMask, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TrafficForecastSegment response = trafficForecastSegmentServiceClient.UpdateTrafficForecastSegment(trafficForecastSegment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTrafficForecastSegmentAsync</summary>
        public async Task UpdateTrafficForecastSegmentAsync()
        {
            // Snippet: UpdateTrafficForecastSegmentAsync(TrafficForecastSegment, FieldMask, CallSettings)
            // Additional: UpdateTrafficForecastSegmentAsync(TrafficForecastSegment, FieldMask, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrafficForecastSegment trafficForecastSegment = new TrafficForecastSegment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TrafficForecastSegment response = await trafficForecastSegmentServiceClient.UpdateTrafficForecastSegmentAsync(trafficForecastSegment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegments</summary>
        public void BatchUpdateTrafficForecastSegmentsRequestObject()
        {
            // Snippet: BatchUpdateTrafficForecastSegments(BatchUpdateTrafficForecastSegmentsRequest, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateTrafficForecastSegmentsRequest request = new BatchUpdateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTrafficForecastSegmentRequest(),
                },
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegmentsAsync</summary>
        public async Task BatchUpdateTrafficForecastSegmentsRequestObjectAsync()
        {
            // Snippet: BatchUpdateTrafficForecastSegmentsAsync(BatchUpdateTrafficForecastSegmentsRequest, CallSettings)
            // Additional: BatchUpdateTrafficForecastSegmentsAsync(BatchUpdateTrafficForecastSegmentsRequest, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateTrafficForecastSegmentsRequest request = new BatchUpdateTrafficForecastSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTrafficForecastSegmentRequest(),
                },
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegments</summary>
        public void BatchUpdateTrafficForecastSegments()
        {
            // Snippet: BatchUpdateTrafficForecastSegments(string, IEnumerable<UpdateTrafficForecastSegmentRequest>, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTrafficForecastSegmentRequest> requests = new UpdateTrafficForecastSegmentRequest[]
            {
                new UpdateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegmentsAsync</summary>
        public async Task BatchUpdateTrafficForecastSegmentsAsync()
        {
            // Snippet: BatchUpdateTrafficForecastSegmentsAsync(string, IEnumerable<UpdateTrafficForecastSegmentRequest>, CallSettings)
            // Additional: BatchUpdateTrafficForecastSegmentsAsync(string, IEnumerable<UpdateTrafficForecastSegmentRequest>, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTrafficForecastSegmentRequest> requests = new UpdateTrafficForecastSegmentRequest[]
            {
                new UpdateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegmentsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegments</summary>
        public void BatchUpdateTrafficForecastSegmentsResourceNames()
        {
            // Snippet: BatchUpdateTrafficForecastSegments(NetworkName, IEnumerable<UpdateTrafficForecastSegmentRequest>, CallSettings)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = TrafficForecastSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTrafficForecastSegmentRequest> requests = new UpdateTrafficForecastSegmentRequest[]
            {
                new UpdateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegments(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTrafficForecastSegmentsAsync</summary>
        public async Task BatchUpdateTrafficForecastSegmentsResourceNamesAsync()
        {
            // Snippet: BatchUpdateTrafficForecastSegmentsAsync(NetworkName, IEnumerable<UpdateTrafficForecastSegmentRequest>, CallSettings)
            // Additional: BatchUpdateTrafficForecastSegmentsAsync(NetworkName, IEnumerable<UpdateTrafficForecastSegmentRequest>, CancellationToken)
            // Create client
            TrafficForecastSegmentServiceClient trafficForecastSegmentServiceClient = await TrafficForecastSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTrafficForecastSegmentRequest> requests = new UpdateTrafficForecastSegmentRequest[]
            {
                new UpdateTrafficForecastSegmentRequest(),
            };
            // Make the request
            BatchUpdateTrafficForecastSegmentsResponse response = await trafficForecastSegmentServiceClient.BatchUpdateTrafficForecastSegmentsAsync(parent, requests);
            // End snippet
        }
    }
}
