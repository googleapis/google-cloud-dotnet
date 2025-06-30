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
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPrivateAuctionDealServiceClientSnippets
    {
        /// <summary>Snippet for GetPrivateAuctionDeal</summary>
        public void GetPrivateAuctionDealRequestObject()
        {
            // Snippet: GetPrivateAuctionDeal(GetPrivateAuctionDealRequest, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            GetPrivateAuctionDealRequest request = new GetPrivateAuctionDealRequest
            {
                PrivateAuctionDealName = PrivateAuctionDealName.FromNetworkCodePrivateAuctionDeal("[NETWORK_CODE]", "[PRIVATE_AUCTION_DEAL]"),
            };
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.GetPrivateAuctionDeal(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionDealAsync</summary>
        public async Task GetPrivateAuctionDealRequestObjectAsync()
        {
            // Snippet: GetPrivateAuctionDealAsync(GetPrivateAuctionDealRequest, CallSettings)
            // Additional: GetPrivateAuctionDealAsync(GetPrivateAuctionDealRequest, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateAuctionDealRequest request = new GetPrivateAuctionDealRequest
            {
                PrivateAuctionDealName = PrivateAuctionDealName.FromNetworkCodePrivateAuctionDeal("[NETWORK_CODE]", "[PRIVATE_AUCTION_DEAL]"),
            };
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.GetPrivateAuctionDealAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionDeal</summary>
        public void GetPrivateAuctionDeal()
        {
            // Snippet: GetPrivateAuctionDeal(string, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/privateAuctionDeals/[PRIVATE_AUCTION_DEAL]";
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.GetPrivateAuctionDeal(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionDealAsync</summary>
        public async Task GetPrivateAuctionDealAsync()
        {
            // Snippet: GetPrivateAuctionDealAsync(string, CallSettings)
            // Additional: GetPrivateAuctionDealAsync(string, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/privateAuctionDeals/[PRIVATE_AUCTION_DEAL]";
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.GetPrivateAuctionDealAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionDeal</summary>
        public void GetPrivateAuctionDealResourceNames()
        {
            // Snippet: GetPrivateAuctionDeal(PrivateAuctionDealName, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            PrivateAuctionDealName name = PrivateAuctionDealName.FromNetworkCodePrivateAuctionDeal("[NETWORK_CODE]", "[PRIVATE_AUCTION_DEAL]");
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.GetPrivateAuctionDeal(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionDealAsync</summary>
        public async Task GetPrivateAuctionDealResourceNamesAsync()
        {
            // Snippet: GetPrivateAuctionDealAsync(PrivateAuctionDealName, CallSettings)
            // Additional: GetPrivateAuctionDealAsync(PrivateAuctionDealName, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateAuctionDealName name = PrivateAuctionDealName.FromNetworkCodePrivateAuctionDeal("[NETWORK_CODE]", "[PRIVATE_AUCTION_DEAL]");
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.GetPrivateAuctionDealAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDeals</summary>
        public void ListPrivateAuctionDealsRequestObject()
        {
            // Snippet: ListPrivateAuctionDeals(ListPrivateAuctionDealsRequest, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDeals(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuctionDeal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionDealsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDealsAsync</summary>
        public async Task ListPrivateAuctionDealsRequestObjectAsync()
        {
            // Snippet: ListPrivateAuctionDealsAsync(ListPrivateAuctionDealsRequest, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateAuctionDealsRequest request = new ListPrivateAuctionDealsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDealsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuctionDeal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionDealsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDeals</summary>
        public void ListPrivateAuctionDeals()
        {
            // Snippet: ListPrivateAuctionDeals(string, string, int?, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDeals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuctionDeal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionDealsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDealsAsync</summary>
        public async Task ListPrivateAuctionDealsAsync()
        {
            // Snippet: ListPrivateAuctionDealsAsync(string, string, int?, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDealsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuctionDeal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionDealsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDeals</summary>
        public void ListPrivateAuctionDealsResourceNames()
        {
            // Snippet: ListPrivateAuctionDeals(NetworkName, string, int?, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDeals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuctionDeal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionDealsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionDealsAsync</summary>
        public async Task ListPrivateAuctionDealsResourceNamesAsync()
        {
            // Snippet: ListPrivateAuctionDealsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionDealsResponse, PrivateAuctionDeal> response = privateAuctionDealServiceClient.ListPrivateAuctionDealsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuctionDeal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionDealsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuctionDeal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuctionDeal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuctionDeal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDeal</summary>
        public void CreatePrivateAuctionDealRequestObject()
        {
            // Snippet: CreatePrivateAuctionDeal(CreatePrivateAuctionDealRequest, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            CreatePrivateAuctionDealRequest request = new CreatePrivateAuctionDealRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PrivateAuctionDeal = new PrivateAuctionDeal(),
            };
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.CreatePrivateAuctionDeal(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDealAsync</summary>
        public async Task CreatePrivateAuctionDealRequestObjectAsync()
        {
            // Snippet: CreatePrivateAuctionDealAsync(CreatePrivateAuctionDealRequest, CallSettings)
            // Additional: CreatePrivateAuctionDealAsync(CreatePrivateAuctionDealRequest, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateAuctionDealRequest request = new CreatePrivateAuctionDealRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PrivateAuctionDeal = new PrivateAuctionDeal(),
            };
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.CreatePrivateAuctionDealAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDeal</summary>
        public void CreatePrivateAuctionDeal()
        {
            // Snippet: CreatePrivateAuctionDeal(string, PrivateAuctionDeal, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.CreatePrivateAuctionDeal(parent, privateAuctionDeal);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDealAsync</summary>
        public async Task CreatePrivateAuctionDealAsync()
        {
            // Snippet: CreatePrivateAuctionDealAsync(string, PrivateAuctionDeal, CallSettings)
            // Additional: CreatePrivateAuctionDealAsync(string, PrivateAuctionDeal, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.CreatePrivateAuctionDealAsync(parent, privateAuctionDeal);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDeal</summary>
        public void CreatePrivateAuctionDealResourceNames()
        {
            // Snippet: CreatePrivateAuctionDeal(NetworkName, PrivateAuctionDeal, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.CreatePrivateAuctionDeal(parent, privateAuctionDeal);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionDealAsync</summary>
        public async Task CreatePrivateAuctionDealResourceNamesAsync()
        {
            // Snippet: CreatePrivateAuctionDealAsync(NetworkName, PrivateAuctionDeal, CallSettings)
            // Additional: CreatePrivateAuctionDealAsync(NetworkName, PrivateAuctionDeal, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.CreatePrivateAuctionDealAsync(parent, privateAuctionDeal);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionDeal</summary>
        public void UpdatePrivateAuctionDealRequestObject()
        {
            // Snippet: UpdatePrivateAuctionDeal(UpdatePrivateAuctionDealRequest, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            UpdatePrivateAuctionDealRequest request = new UpdatePrivateAuctionDealRequest
            {
                PrivateAuctionDeal = new PrivateAuctionDeal(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.UpdatePrivateAuctionDeal(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionDealAsync</summary>
        public async Task UpdatePrivateAuctionDealRequestObjectAsync()
        {
            // Snippet: UpdatePrivateAuctionDealAsync(UpdatePrivateAuctionDealRequest, CallSettings)
            // Additional: UpdatePrivateAuctionDealAsync(UpdatePrivateAuctionDealRequest, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateAuctionDealRequest request = new UpdatePrivateAuctionDealRequest
            {
                PrivateAuctionDeal = new PrivateAuctionDeal(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.UpdatePrivateAuctionDealAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionDeal</summary>
        public void UpdatePrivateAuctionDeal()
        {
            // Snippet: UpdatePrivateAuctionDeal(PrivateAuctionDeal, FieldMask, CallSettings)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = PrivateAuctionDealServiceClient.Create();
            // Initialize request argument(s)
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateAuctionDeal response = privateAuctionDealServiceClient.UpdatePrivateAuctionDeal(privateAuctionDeal, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionDealAsync</summary>
        public async Task UpdatePrivateAuctionDealAsync()
        {
            // Snippet: UpdatePrivateAuctionDealAsync(PrivateAuctionDeal, FieldMask, CallSettings)
            // Additional: UpdatePrivateAuctionDealAsync(PrivateAuctionDeal, FieldMask, CancellationToken)
            // Create client
            PrivateAuctionDealServiceClient privateAuctionDealServiceClient = await PrivateAuctionDealServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateAuctionDeal privateAuctionDeal = new PrivateAuctionDeal();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateAuctionDeal response = await privateAuctionDealServiceClient.UpdatePrivateAuctionDealAsync(privateAuctionDeal, updateMask);
            // End snippet
        }
    }
}
