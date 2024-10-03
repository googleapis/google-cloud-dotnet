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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
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
    }
}
