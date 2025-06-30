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
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProgrammaticBuyerServiceClientSnippets
    {
        /// <summary>Snippet for GetProgrammaticBuyer</summary>
        public void GetProgrammaticBuyerRequestObject()
        {
            // Snippet: GetProgrammaticBuyer(GetProgrammaticBuyerRequest, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            GetProgrammaticBuyerRequest request = new GetProgrammaticBuyerRequest
            {
                ProgrammaticBuyerName = ProgrammaticBuyerName.FromNetworkCodeProgrammaticBuyer("[NETWORK_CODE]", "[PROGRAMMATIC_BUYER]"),
            };
            // Make the request
            ProgrammaticBuyer response = programmaticBuyerServiceClient.GetProgrammaticBuyer(request);
            // End snippet
        }

        /// <summary>Snippet for GetProgrammaticBuyerAsync</summary>
        public async Task GetProgrammaticBuyerRequestObjectAsync()
        {
            // Snippet: GetProgrammaticBuyerAsync(GetProgrammaticBuyerRequest, CallSettings)
            // Additional: GetProgrammaticBuyerAsync(GetProgrammaticBuyerRequest, CancellationToken)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProgrammaticBuyerRequest request = new GetProgrammaticBuyerRequest
            {
                ProgrammaticBuyerName = ProgrammaticBuyerName.FromNetworkCodeProgrammaticBuyer("[NETWORK_CODE]", "[PROGRAMMATIC_BUYER]"),
            };
            // Make the request
            ProgrammaticBuyer response = await programmaticBuyerServiceClient.GetProgrammaticBuyerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProgrammaticBuyer</summary>
        public void GetProgrammaticBuyer()
        {
            // Snippet: GetProgrammaticBuyer(string, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/programmaticBuyers/[PROGRAMMATIC_BUYER]";
            // Make the request
            ProgrammaticBuyer response = programmaticBuyerServiceClient.GetProgrammaticBuyer(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgrammaticBuyerAsync</summary>
        public async Task GetProgrammaticBuyerAsync()
        {
            // Snippet: GetProgrammaticBuyerAsync(string, CallSettings)
            // Additional: GetProgrammaticBuyerAsync(string, CancellationToken)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/programmaticBuyers/[PROGRAMMATIC_BUYER]";
            // Make the request
            ProgrammaticBuyer response = await programmaticBuyerServiceClient.GetProgrammaticBuyerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgrammaticBuyer</summary>
        public void GetProgrammaticBuyerResourceNames()
        {
            // Snippet: GetProgrammaticBuyer(ProgrammaticBuyerName, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            ProgrammaticBuyerName name = ProgrammaticBuyerName.FromNetworkCodeProgrammaticBuyer("[NETWORK_CODE]", "[PROGRAMMATIC_BUYER]");
            // Make the request
            ProgrammaticBuyer response = programmaticBuyerServiceClient.GetProgrammaticBuyer(name);
            // End snippet
        }

        /// <summary>Snippet for GetProgrammaticBuyerAsync</summary>
        public async Task GetProgrammaticBuyerResourceNamesAsync()
        {
            // Snippet: GetProgrammaticBuyerAsync(ProgrammaticBuyerName, CallSettings)
            // Additional: GetProgrammaticBuyerAsync(ProgrammaticBuyerName, CancellationToken)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProgrammaticBuyerName name = ProgrammaticBuyerName.FromNetworkCodeProgrammaticBuyer("[NETWORK_CODE]", "[PROGRAMMATIC_BUYER]");
            // Make the request
            ProgrammaticBuyer response = await programmaticBuyerServiceClient.GetProgrammaticBuyerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyers</summary>
        public void ListProgrammaticBuyersRequestObject()
        {
            // Snippet: ListProgrammaticBuyers(ListProgrammaticBuyersRequest, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProgrammaticBuyer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgrammaticBuyersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyersAsync</summary>
        public async Task ListProgrammaticBuyersRequestObjectAsync()
        {
            // Snippet: ListProgrammaticBuyersAsync(ListProgrammaticBuyersRequest, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProgrammaticBuyersRequest request = new ListProgrammaticBuyersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProgrammaticBuyer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgrammaticBuyersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyers</summary>
        public void ListProgrammaticBuyers()
        {
            // Snippet: ListProgrammaticBuyers(string, string, int?, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProgrammaticBuyer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgrammaticBuyersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyersAsync</summary>
        public async Task ListProgrammaticBuyersAsync()
        {
            // Snippet: ListProgrammaticBuyersAsync(string, string, int?, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProgrammaticBuyer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgrammaticBuyersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyers</summary>
        public void ListProgrammaticBuyersResourceNames()
        {
            // Snippet: ListProgrammaticBuyers(NetworkName, string, int?, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = ProgrammaticBuyerServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProgrammaticBuyer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProgrammaticBuyersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProgrammaticBuyersAsync</summary>
        public async Task ListProgrammaticBuyersResourceNamesAsync()
        {
            // Snippet: ListProgrammaticBuyersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ProgrammaticBuyerServiceClient programmaticBuyerServiceClient = await ProgrammaticBuyerServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListProgrammaticBuyersResponse, ProgrammaticBuyer> response = programmaticBuyerServiceClient.ListProgrammaticBuyersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProgrammaticBuyer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProgrammaticBuyersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProgrammaticBuyer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProgrammaticBuyer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProgrammaticBuyer item in singlePage)
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
