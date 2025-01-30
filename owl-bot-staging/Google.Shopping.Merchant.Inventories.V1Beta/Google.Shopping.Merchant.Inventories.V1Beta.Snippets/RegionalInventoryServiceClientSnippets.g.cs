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
    using Google.Api.Gax;
    using Google.Shopping.Merchant.Inventories.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionalInventoryServiceClientSnippets
    {
        /// <summary>Snippet for ListRegionalInventories</summary>
        public void ListRegionalInventoriesRequestObject()
        {
            // Snippet: ListRegionalInventories(ListRegionalInventoriesRequest, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegionalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionalInventoriesAsync</summary>
        public async Task ListRegionalInventoriesRequestObjectAsync()
        {
            // Snippet: ListRegionalInventoriesAsync(ListRegionalInventoriesRequest, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionalInventoriesRequest request = new ListRegionalInventoriesRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegionalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionalInventories</summary>
        public void ListRegionalInventories()
        {
            // Snippet: ListRegionalInventories(string, string, int?, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegionalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionalInventoriesAsync</summary>
        public async Task ListRegionalInventoriesAsync()
        {
            // Snippet: ListRegionalInventoriesAsync(string, string, int?, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegionalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionalInventories</summary>
        public void ListRegionalInventoriesResourceNames()
        {
            // Snippet: ListRegionalInventories(ProductName, string, int?, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            PagedEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RegionalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRegionalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRegionalInventoriesAsync</summary>
        public async Task ListRegionalInventoriesResourceNamesAsync()
        {
            // Snippet: ListRegionalInventoriesAsync(ProductName, string, int?, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            PagedAsyncEnumerable<ListRegionalInventoriesResponse, RegionalInventory> response = regionalInventoryServiceClient.ListRegionalInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RegionalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRegionalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RegionalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RegionalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RegionalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for InsertRegionalInventory</summary>
        public void InsertRegionalInventoryRequestObject()
        {
            // Snippet: InsertRegionalInventory(InsertRegionalInventoryRequest, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            InsertRegionalInventoryRequest request = new InsertRegionalInventoryRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                RegionalInventory = new RegionalInventory(),
            };
            // Make the request
            RegionalInventory response = regionalInventoryServiceClient.InsertRegionalInventory(request);
            // End snippet
        }

        /// <summary>Snippet for InsertRegionalInventoryAsync</summary>
        public async Task InsertRegionalInventoryRequestObjectAsync()
        {
            // Snippet: InsertRegionalInventoryAsync(InsertRegionalInventoryRequest, CallSettings)
            // Additional: InsertRegionalInventoryAsync(InsertRegionalInventoryRequest, CancellationToken)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionalInventoryRequest request = new InsertRegionalInventoryRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                RegionalInventory = new RegionalInventory(),
            };
            // Make the request
            RegionalInventory response = await regionalInventoryServiceClient.InsertRegionalInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventory</summary>
        public void DeleteRegionalInventoryRequestObject()
        {
            // Snippet: DeleteRegionalInventory(DeleteRegionalInventoryRequest, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            DeleteRegionalInventoryRequest request = new DeleteRegionalInventoryRequest
            {
                RegionalInventoryName = RegionalInventoryName.FromAccountProductRegion("[ACCOUNT]", "[PRODUCT]", "[REGION]"),
            };
            // Make the request
            regionalInventoryServiceClient.DeleteRegionalInventory(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventoryAsync</summary>
        public async Task DeleteRegionalInventoryRequestObjectAsync()
        {
            // Snippet: DeleteRegionalInventoryAsync(DeleteRegionalInventoryRequest, CallSettings)
            // Additional: DeleteRegionalInventoryAsync(DeleteRegionalInventoryRequest, CancellationToken)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionalInventoryRequest request = new DeleteRegionalInventoryRequest
            {
                RegionalInventoryName = RegionalInventoryName.FromAccountProductRegion("[ACCOUNT]", "[PRODUCT]", "[REGION]"),
            };
            // Make the request
            await regionalInventoryServiceClient.DeleteRegionalInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventory</summary>
        public void DeleteRegionalInventory()
        {
            // Snippet: DeleteRegionalInventory(string, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]/regionalInventories/[REGION]";
            // Make the request
            regionalInventoryServiceClient.DeleteRegionalInventory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventoryAsync</summary>
        public async Task DeleteRegionalInventoryAsync()
        {
            // Snippet: DeleteRegionalInventoryAsync(string, CallSettings)
            // Additional: DeleteRegionalInventoryAsync(string, CancellationToken)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]/regionalInventories/[REGION]";
            // Make the request
            await regionalInventoryServiceClient.DeleteRegionalInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventory</summary>
        public void DeleteRegionalInventoryResourceNames()
        {
            // Snippet: DeleteRegionalInventory(RegionalInventoryName, CallSettings)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = RegionalInventoryServiceClient.Create();
            // Initialize request argument(s)
            RegionalInventoryName name = RegionalInventoryName.FromAccountProductRegion("[ACCOUNT]", "[PRODUCT]", "[REGION]");
            // Make the request
            regionalInventoryServiceClient.DeleteRegionalInventory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRegionalInventoryAsync</summary>
        public async Task DeleteRegionalInventoryResourceNamesAsync()
        {
            // Snippet: DeleteRegionalInventoryAsync(RegionalInventoryName, CallSettings)
            // Additional: DeleteRegionalInventoryAsync(RegionalInventoryName, CancellationToken)
            // Create client
            RegionalInventoryServiceClient regionalInventoryServiceClient = await RegionalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegionalInventoryName name = RegionalInventoryName.FromAccountProductRegion("[ACCOUNT]", "[PRODUCT]", "[REGION]");
            // Make the request
            await regionalInventoryServiceClient.DeleteRegionalInventoryAsync(name);
            // End snippet
        }
    }
}
