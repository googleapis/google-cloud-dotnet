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
    public sealed class AllGeneratedPrivateAuctionServiceClientSnippets
    {
        /// <summary>Snippet for GetPrivateAuction</summary>
        public void GetPrivateAuctionRequestObject()
        {
            // Snippet: GetPrivateAuction(GetPrivateAuctionRequest, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            GetPrivateAuctionRequest request = new GetPrivateAuctionRequest
            {
                PrivateAuctionName = PrivateAuctionName.FromNetworkCodePrivateAuction("[NETWORK_CODE]", "[PRIVATE_AUCTION]"),
            };
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.GetPrivateAuction(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionAsync</summary>
        public async Task GetPrivateAuctionRequestObjectAsync()
        {
            // Snippet: GetPrivateAuctionAsync(GetPrivateAuctionRequest, CallSettings)
            // Additional: GetPrivateAuctionAsync(GetPrivateAuctionRequest, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateAuctionRequest request = new GetPrivateAuctionRequest
            {
                PrivateAuctionName = PrivateAuctionName.FromNetworkCodePrivateAuction("[NETWORK_CODE]", "[PRIVATE_AUCTION]"),
            };
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.GetPrivateAuctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuction</summary>
        public void GetPrivateAuction()
        {
            // Snippet: GetPrivateAuction(string, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/privateAuctions/[PRIVATE_AUCTION]";
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.GetPrivateAuction(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionAsync</summary>
        public async Task GetPrivateAuctionAsync()
        {
            // Snippet: GetPrivateAuctionAsync(string, CallSettings)
            // Additional: GetPrivateAuctionAsync(string, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/privateAuctions/[PRIVATE_AUCTION]";
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.GetPrivateAuctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuction</summary>
        public void GetPrivateAuctionResourceNames()
        {
            // Snippet: GetPrivateAuction(PrivateAuctionName, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            PrivateAuctionName name = PrivateAuctionName.FromNetworkCodePrivateAuction("[NETWORK_CODE]", "[PRIVATE_AUCTION]");
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.GetPrivateAuction(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateAuctionAsync</summary>
        public async Task GetPrivateAuctionResourceNamesAsync()
        {
            // Snippet: GetPrivateAuctionAsync(PrivateAuctionName, CallSettings)
            // Additional: GetPrivateAuctionAsync(PrivateAuctionName, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateAuctionName name = PrivateAuctionName.FromNetworkCodePrivateAuction("[NETWORK_CODE]", "[PRIVATE_AUCTION]");
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.GetPrivateAuctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctions</summary>
        public void ListPrivateAuctionsRequestObject()
        {
            // Snippet: ListPrivateAuctions(ListPrivateAuctionsRequest, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionsAsync</summary>
        public async Task ListPrivateAuctionsRequestObjectAsync()
        {
            // Snippet: ListPrivateAuctionsAsync(ListPrivateAuctionsRequest, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateAuctionsRequest request = new ListPrivateAuctionsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctions</summary>
        public void ListPrivateAuctions()
        {
            // Snippet: ListPrivateAuctions(string, string, int?, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionsAsync</summary>
        public async Task ListPrivateAuctionsAsync()
        {
            // Snippet: ListPrivateAuctionsAsync(string, string, int?, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctions</summary>
        public void ListPrivateAuctionsResourceNames()
        {
            // Snippet: ListPrivateAuctions(NetworkName, string, int?, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateAuction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateAuctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateAuctionsAsync</summary>
        public async Task ListPrivateAuctionsResourceNamesAsync()
        {
            // Snippet: ListPrivateAuctionsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateAuctionsResponse, PrivateAuction> response = privateAuctionServiceClient.ListPrivateAuctionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateAuction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateAuctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateAuction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateAuction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateAuction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuction</summary>
        public void CreatePrivateAuctionRequestObject()
        {
            // Snippet: CreatePrivateAuction(CreatePrivateAuctionRequest, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            CreatePrivateAuctionRequest request = new CreatePrivateAuctionRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PrivateAuction = new PrivateAuction(),
            };
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.CreatePrivateAuction(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionAsync</summary>
        public async Task CreatePrivateAuctionRequestObjectAsync()
        {
            // Snippet: CreatePrivateAuctionAsync(CreatePrivateAuctionRequest, CallSettings)
            // Additional: CreatePrivateAuctionAsync(CreatePrivateAuctionRequest, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateAuctionRequest request = new CreatePrivateAuctionRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                PrivateAuction = new PrivateAuction(),
            };
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.CreatePrivateAuctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuction</summary>
        public void CreatePrivateAuction()
        {
            // Snippet: CreatePrivateAuction(string, PrivateAuction, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            PrivateAuction privateAuction = new PrivateAuction();
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.CreatePrivateAuction(parent, privateAuction);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionAsync</summary>
        public async Task CreatePrivateAuctionAsync()
        {
            // Snippet: CreatePrivateAuctionAsync(string, PrivateAuction, CallSettings)
            // Additional: CreatePrivateAuctionAsync(string, PrivateAuction, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            PrivateAuction privateAuction = new PrivateAuction();
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.CreatePrivateAuctionAsync(parent, privateAuction);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuction</summary>
        public void CreatePrivateAuctionResourceNames()
        {
            // Snippet: CreatePrivateAuction(NetworkName, PrivateAuction, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            PrivateAuction privateAuction = new PrivateAuction();
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.CreatePrivateAuction(parent, privateAuction);
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateAuctionAsync</summary>
        public async Task CreatePrivateAuctionResourceNamesAsync()
        {
            // Snippet: CreatePrivateAuctionAsync(NetworkName, PrivateAuction, CallSettings)
            // Additional: CreatePrivateAuctionAsync(NetworkName, PrivateAuction, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            PrivateAuction privateAuction = new PrivateAuction();
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.CreatePrivateAuctionAsync(parent, privateAuction);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuction</summary>
        public void UpdatePrivateAuctionRequestObject()
        {
            // Snippet: UpdatePrivateAuction(UpdatePrivateAuctionRequest, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            UpdatePrivateAuctionRequest request = new UpdatePrivateAuctionRequest
            {
                PrivateAuction = new PrivateAuction(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.UpdatePrivateAuction(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionAsync</summary>
        public async Task UpdatePrivateAuctionRequestObjectAsync()
        {
            // Snippet: UpdatePrivateAuctionAsync(UpdatePrivateAuctionRequest, CallSettings)
            // Additional: UpdatePrivateAuctionAsync(UpdatePrivateAuctionRequest, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrivateAuctionRequest request = new UpdatePrivateAuctionRequest
            {
                PrivateAuction = new PrivateAuction(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.UpdatePrivateAuctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuction</summary>
        public void UpdatePrivateAuction()
        {
            // Snippet: UpdatePrivateAuction(PrivateAuction, FieldMask, CallSettings)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = PrivateAuctionServiceClient.Create();
            // Initialize request argument(s)
            PrivateAuction privateAuction = new PrivateAuction();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateAuction response = privateAuctionServiceClient.UpdatePrivateAuction(privateAuction, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrivateAuctionAsync</summary>
        public async Task UpdatePrivateAuctionAsync()
        {
            // Snippet: UpdatePrivateAuctionAsync(PrivateAuction, FieldMask, CallSettings)
            // Additional: UpdatePrivateAuctionAsync(PrivateAuction, FieldMask, CancellationToken)
            // Create client
            PrivateAuctionServiceClient privateAuctionServiceClient = await PrivateAuctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateAuction privateAuction = new PrivateAuction();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PrivateAuction response = await privateAuctionServiceClient.UpdatePrivateAuctionAsync(privateAuction, updateMask);
            // End snippet
        }
    }
}
