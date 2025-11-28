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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPlacementServiceClientSnippets
    {
        /// <summary>Snippet for GetPlacement</summary>
        public void GetPlacementRequestObject()
        {
            // Snippet: GetPlacement(GetPlacementRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            GetPlacementRequest request = new GetPlacementRequest
            {
                PlacementName = PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            Placement response = placementServiceClient.GetPlacement(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlacementAsync</summary>
        public async Task GetPlacementRequestObjectAsync()
        {
            // Snippet: GetPlacementAsync(GetPlacementRequest, CallSettings)
            // Additional: GetPlacementAsync(GetPlacementRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPlacementRequest request = new GetPlacementRequest
            {
                PlacementName = PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            Placement response = await placementServiceClient.GetPlacementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlacement</summary>
        public void GetPlacement()
        {
            // Snippet: GetPlacement(string, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/placements/[PLACEMENT]";
            // Make the request
            Placement response = placementServiceClient.GetPlacement(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlacementAsync</summary>
        public async Task GetPlacementAsync()
        {
            // Snippet: GetPlacementAsync(string, CallSettings)
            // Additional: GetPlacementAsync(string, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/placements/[PLACEMENT]";
            // Make the request
            Placement response = await placementServiceClient.GetPlacementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlacement</summary>
        public void GetPlacementResourceNames()
        {
            // Snippet: GetPlacement(PlacementName, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            PlacementName name = PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]");
            // Make the request
            Placement response = placementServiceClient.GetPlacement(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlacementAsync</summary>
        public async Task GetPlacementResourceNamesAsync()
        {
            // Snippet: GetPlacementAsync(PlacementName, CallSettings)
            // Additional: GetPlacementAsync(PlacementName, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            PlacementName name = PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]");
            // Make the request
            Placement response = await placementServiceClient.GetPlacementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPlacements</summary>
        public void ListPlacementsRequestObject()
        {
            // Snippet: ListPlacements(ListPlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            ListPlacementsRequest request = new ListPlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Placement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlacementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlacementsAsync</summary>
        public async Task ListPlacementsRequestObjectAsync()
        {
            // Snippet: ListPlacementsAsync(ListPlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPlacementsRequest request = new ListPlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Placement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPlacementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlacements</summary>
        public void ListPlacements()
        {
            // Snippet: ListPlacements(string, string, int?, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Placement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlacementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlacementsAsync</summary>
        public async Task ListPlacementsAsync()
        {
            // Snippet: ListPlacementsAsync(string, string, int?, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Placement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPlacementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlacements</summary>
        public void ListPlacementsResourceNames()
        {
            // Snippet: ListPlacements(NetworkName, string, int?, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Placement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPlacementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPlacementsAsync</summary>
        public async Task ListPlacementsResourceNamesAsync()
        {
            // Snippet: ListPlacementsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListPlacementsResponse, Placement> response = placementServiceClient.ListPlacementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Placement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPlacementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Placement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Placement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Placement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePlacement</summary>
        public void CreatePlacementRequestObject()
        {
            // Snippet: CreatePlacement(CreatePlacementRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            CreatePlacementRequest request = new CreatePlacementRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Placement = new Placement(),
            };
            // Make the request
            Placement response = placementServiceClient.CreatePlacement(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlacementAsync</summary>
        public async Task CreatePlacementRequestObjectAsync()
        {
            // Snippet: CreatePlacementAsync(CreatePlacementRequest, CallSettings)
            // Additional: CreatePlacementAsync(CreatePlacementRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePlacementRequest request = new CreatePlacementRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Placement = new Placement(),
            };
            // Make the request
            Placement response = await placementServiceClient.CreatePlacementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePlacement</summary>
        public void CreatePlacement()
        {
            // Snippet: CreatePlacement(string, Placement, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Placement placement = new Placement();
            // Make the request
            Placement response = placementServiceClient.CreatePlacement(parent, placement);
            // End snippet
        }

        /// <summary>Snippet for CreatePlacementAsync</summary>
        public async Task CreatePlacementAsync()
        {
            // Snippet: CreatePlacementAsync(string, Placement, CallSettings)
            // Additional: CreatePlacementAsync(string, Placement, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Placement placement = new Placement();
            // Make the request
            Placement response = await placementServiceClient.CreatePlacementAsync(parent, placement);
            // End snippet
        }

        /// <summary>Snippet for CreatePlacement</summary>
        public void CreatePlacementResourceNames()
        {
            // Snippet: CreatePlacement(NetworkName, Placement, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Placement placement = new Placement();
            // Make the request
            Placement response = placementServiceClient.CreatePlacement(parent, placement);
            // End snippet
        }

        /// <summary>Snippet for CreatePlacementAsync</summary>
        public async Task CreatePlacementResourceNamesAsync()
        {
            // Snippet: CreatePlacementAsync(NetworkName, Placement, CallSettings)
            // Additional: CreatePlacementAsync(NetworkName, Placement, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Placement placement = new Placement();
            // Make the request
            Placement response = await placementServiceClient.CreatePlacementAsync(parent, placement);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlacement</summary>
        public void UpdatePlacementRequestObject()
        {
            // Snippet: UpdatePlacement(UpdatePlacementRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            UpdatePlacementRequest request = new UpdatePlacementRequest
            {
                Placement = new Placement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Placement response = placementServiceClient.UpdatePlacement(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlacementAsync</summary>
        public async Task UpdatePlacementRequestObjectAsync()
        {
            // Snippet: UpdatePlacementAsync(UpdatePlacementRequest, CallSettings)
            // Additional: UpdatePlacementAsync(UpdatePlacementRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePlacementRequest request = new UpdatePlacementRequest
            {
                Placement = new Placement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Placement response = await placementServiceClient.UpdatePlacementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlacement</summary>
        public void UpdatePlacement()
        {
            // Snippet: UpdatePlacement(Placement, FieldMask, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            Placement placement = new Placement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Placement response = placementServiceClient.UpdatePlacement(placement, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePlacementAsync</summary>
        public async Task UpdatePlacementAsync()
        {
            // Snippet: UpdatePlacementAsync(Placement, FieldMask, CallSettings)
            // Additional: UpdatePlacementAsync(Placement, FieldMask, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            Placement placement = new Placement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Placement response = await placementServiceClient.UpdatePlacementAsync(placement, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacements</summary>
        public void BatchCreatePlacementsRequestObject()
        {
            // Snippet: BatchCreatePlacements(BatchCreatePlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            BatchCreatePlacementsRequest request = new BatchCreatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreatePlacementRequest(),
                },
            };
            // Make the request
            BatchCreatePlacementsResponse response = placementServiceClient.BatchCreatePlacements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacementsAsync</summary>
        public async Task BatchCreatePlacementsRequestObjectAsync()
        {
            // Snippet: BatchCreatePlacementsAsync(BatchCreatePlacementsRequest, CallSettings)
            // Additional: BatchCreatePlacementsAsync(BatchCreatePlacementsRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreatePlacementsRequest request = new BatchCreatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreatePlacementRequest(),
                },
            };
            // Make the request
            BatchCreatePlacementsResponse response = await placementServiceClient.BatchCreatePlacementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacements</summary>
        public void BatchCreatePlacements()
        {
            // Snippet: BatchCreatePlacements(string, IEnumerable<CreatePlacementRequest>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreatePlacementRequest> requests = new CreatePlacementRequest[]
            {
                new CreatePlacementRequest(),
            };
            // Make the request
            BatchCreatePlacementsResponse response = placementServiceClient.BatchCreatePlacements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacementsAsync</summary>
        public async Task BatchCreatePlacementsAsync()
        {
            // Snippet: BatchCreatePlacementsAsync(string, IEnumerable<CreatePlacementRequest>, CallSettings)
            // Additional: BatchCreatePlacementsAsync(string, IEnumerable<CreatePlacementRequest>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreatePlacementRequest> requests = new CreatePlacementRequest[]
            {
                new CreatePlacementRequest(),
            };
            // Make the request
            BatchCreatePlacementsResponse response = await placementServiceClient.BatchCreatePlacementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacements</summary>
        public void BatchCreatePlacementsResourceNames()
        {
            // Snippet: BatchCreatePlacements(NetworkName, IEnumerable<CreatePlacementRequest>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreatePlacementRequest> requests = new CreatePlacementRequest[]
            {
                new CreatePlacementRequest(),
            };
            // Make the request
            BatchCreatePlacementsResponse response = placementServiceClient.BatchCreatePlacements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePlacementsAsync</summary>
        public async Task BatchCreatePlacementsResourceNamesAsync()
        {
            // Snippet: BatchCreatePlacementsAsync(NetworkName, IEnumerable<CreatePlacementRequest>, CallSettings)
            // Additional: BatchCreatePlacementsAsync(NetworkName, IEnumerable<CreatePlacementRequest>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreatePlacementRequest> requests = new CreatePlacementRequest[]
            {
                new CreatePlacementRequest(),
            };
            // Make the request
            BatchCreatePlacementsResponse response = await placementServiceClient.BatchCreatePlacementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacements</summary>
        public void BatchUpdatePlacementsRequestObject()
        {
            // Snippet: BatchUpdatePlacements(BatchUpdatePlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdatePlacementsRequest request = new BatchUpdatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdatePlacementRequest(),
                },
            };
            // Make the request
            BatchUpdatePlacementsResponse response = placementServiceClient.BatchUpdatePlacements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacementsAsync</summary>
        public async Task BatchUpdatePlacementsRequestObjectAsync()
        {
            // Snippet: BatchUpdatePlacementsAsync(BatchUpdatePlacementsRequest, CallSettings)
            // Additional: BatchUpdatePlacementsAsync(BatchUpdatePlacementsRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdatePlacementsRequest request = new BatchUpdatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdatePlacementRequest(),
                },
            };
            // Make the request
            BatchUpdatePlacementsResponse response = await placementServiceClient.BatchUpdatePlacementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacements</summary>
        public void BatchUpdatePlacements()
        {
            // Snippet: BatchUpdatePlacements(string, IEnumerable<UpdatePlacementRequest>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdatePlacementRequest> requests = new UpdatePlacementRequest[]
            {
                new UpdatePlacementRequest(),
            };
            // Make the request
            BatchUpdatePlacementsResponse response = placementServiceClient.BatchUpdatePlacements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacementsAsync</summary>
        public async Task BatchUpdatePlacementsAsync()
        {
            // Snippet: BatchUpdatePlacementsAsync(string, IEnumerable<UpdatePlacementRequest>, CallSettings)
            // Additional: BatchUpdatePlacementsAsync(string, IEnumerable<UpdatePlacementRequest>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdatePlacementRequest> requests = new UpdatePlacementRequest[]
            {
                new UpdatePlacementRequest(),
            };
            // Make the request
            BatchUpdatePlacementsResponse response = await placementServiceClient.BatchUpdatePlacementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacements</summary>
        public void BatchUpdatePlacementsResourceNames()
        {
            // Snippet: BatchUpdatePlacements(NetworkName, IEnumerable<UpdatePlacementRequest>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdatePlacementRequest> requests = new UpdatePlacementRequest[]
            {
                new UpdatePlacementRequest(),
            };
            // Make the request
            BatchUpdatePlacementsResponse response = placementServiceClient.BatchUpdatePlacements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdatePlacementsAsync</summary>
        public async Task BatchUpdatePlacementsResourceNamesAsync()
        {
            // Snippet: BatchUpdatePlacementsAsync(NetworkName, IEnumerable<UpdatePlacementRequest>, CallSettings)
            // Additional: BatchUpdatePlacementsAsync(NetworkName, IEnumerable<UpdatePlacementRequest>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdatePlacementRequest> requests = new UpdatePlacementRequest[]
            {
                new UpdatePlacementRequest(),
            };
            // Make the request
            BatchUpdatePlacementsResponse response = await placementServiceClient.BatchUpdatePlacementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacements</summary>
        public void BatchActivatePlacementsRequestObject()
        {
            // Snippet: BatchActivatePlacements(BatchActivatePlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            BatchActivatePlacementsRequest request = new BatchActivatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchActivatePlacementsResponse response = placementServiceClient.BatchActivatePlacements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacementsAsync</summary>
        public async Task BatchActivatePlacementsRequestObjectAsync()
        {
            // Snippet: BatchActivatePlacementsAsync(BatchActivatePlacementsRequest, CallSettings)
            // Additional: BatchActivatePlacementsAsync(BatchActivatePlacementsRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivatePlacementsRequest request = new BatchActivatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchActivatePlacementsResponse response = await placementServiceClient.BatchActivatePlacementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacements</summary>
        public void BatchActivatePlacements()
        {
            // Snippet: BatchActivatePlacements(string, IEnumerable<string>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchActivatePlacementsResponse response = placementServiceClient.BatchActivatePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacementsAsync</summary>
        public async Task BatchActivatePlacementsAsync()
        {
            // Snippet: BatchActivatePlacementsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivatePlacementsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchActivatePlacementsResponse response = await placementServiceClient.BatchActivatePlacementsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacements</summary>
        public void BatchActivatePlacementsResourceNames()
        {
            // Snippet: BatchActivatePlacements(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchActivatePlacementsResponse response = placementServiceClient.BatchActivatePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivatePlacementsAsync</summary>
        public async Task BatchActivatePlacementsResourceNamesAsync()
        {
            // Snippet: BatchActivatePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Additional: BatchActivatePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchActivatePlacementsResponse response = await placementServiceClient.BatchActivatePlacementsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacements</summary>
        public void BatchDeactivatePlacementsRequestObject()
        {
            // Snippet: BatchDeactivatePlacements(BatchDeactivatePlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivatePlacementsRequest request = new BatchDeactivatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = placementServiceClient.BatchDeactivatePlacements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacementsAsync</summary>
        public async Task BatchDeactivatePlacementsRequestObjectAsync()
        {
            // Snippet: BatchDeactivatePlacementsAsync(BatchDeactivatePlacementsRequest, CallSettings)
            // Additional: BatchDeactivatePlacementsAsync(BatchDeactivatePlacementsRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivatePlacementsRequest request = new BatchDeactivatePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = await placementServiceClient.BatchDeactivatePlacementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacements</summary>
        public void BatchDeactivatePlacements()
        {
            // Snippet: BatchDeactivatePlacements(string, IEnumerable<string>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = placementServiceClient.BatchDeactivatePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacementsAsync</summary>
        public async Task BatchDeactivatePlacementsAsync()
        {
            // Snippet: BatchDeactivatePlacementsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivatePlacementsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = await placementServiceClient.BatchDeactivatePlacementsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacements</summary>
        public void BatchDeactivatePlacementsResourceNames()
        {
            // Snippet: BatchDeactivatePlacements(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = placementServiceClient.BatchDeactivatePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivatePlacementsAsync</summary>
        public async Task BatchDeactivatePlacementsResourceNamesAsync()
        {
            // Snippet: BatchDeactivatePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Additional: BatchDeactivatePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchDeactivatePlacementsResponse response = await placementServiceClient.BatchDeactivatePlacementsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacements</summary>
        public void BatchArchivePlacementsRequestObject()
        {
            // Snippet: BatchArchivePlacements(BatchArchivePlacementsRequest, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            BatchArchivePlacementsRequest request = new BatchArchivePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchArchivePlacementsResponse response = placementServiceClient.BatchArchivePlacements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacementsAsync</summary>
        public async Task BatchArchivePlacementsRequestObjectAsync()
        {
            // Snippet: BatchArchivePlacementsAsync(BatchArchivePlacementsRequest, CallSettings)
            // Additional: BatchArchivePlacementsAsync(BatchArchivePlacementsRequest, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchivePlacementsRequest request = new BatchArchivePlacementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PlacementNames =
                {
                    PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
                },
            };
            // Make the request
            BatchArchivePlacementsResponse response = await placementServiceClient.BatchArchivePlacementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacements</summary>
        public void BatchArchivePlacements()
        {
            // Snippet: BatchArchivePlacements(string, IEnumerable<string>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchArchivePlacementsResponse response = placementServiceClient.BatchArchivePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacementsAsync</summary>
        public async Task BatchArchivePlacementsAsync()
        {
            // Snippet: BatchArchivePlacementsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchivePlacementsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/placements/[PLACEMENT]",
            };
            // Make the request
            BatchArchivePlacementsResponse response = await placementServiceClient.BatchArchivePlacementsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacements</summary>
        public void BatchArchivePlacementsResourceNames()
        {
            // Snippet: BatchArchivePlacements(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Create client
            PlacementServiceClient placementServiceClient = PlacementServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchArchivePlacementsResponse response = placementServiceClient.BatchArchivePlacements(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchivePlacementsAsync</summary>
        public async Task BatchArchivePlacementsResourceNamesAsync()
        {
            // Snippet: BatchArchivePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CallSettings)
            // Additional: BatchArchivePlacementsAsync(NetworkName, IEnumerable<PlacementName>, CancellationToken)
            // Create client
            PlacementServiceClient placementServiceClient = await PlacementServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<PlacementName> names = new PlacementName[]
            {
                PlacementName.FromNetworkCodePlacement("[NETWORK_CODE]", "[PLACEMENT]"),
            };
            // Make the request
            BatchArchivePlacementsResponse response = await placementServiceClient.BatchArchivePlacementsAsync(parent, names);
            // End snippet
        }
    }
}
