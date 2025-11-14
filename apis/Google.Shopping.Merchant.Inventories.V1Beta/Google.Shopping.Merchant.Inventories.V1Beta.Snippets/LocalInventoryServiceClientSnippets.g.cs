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
    public sealed class AllGeneratedLocalInventoryServiceClientSnippets
    {
        /// <summary>Snippet for ListLocalInventories</summary>
        public void ListLocalInventoriesRequestObject()
        {
            // Snippet: ListLocalInventories(ListLocalInventoriesRequest, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LocalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLocalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocalInventoriesAsync</summary>
        public async Task ListLocalInventoriesRequestObjectAsync()
        {
            // Snippet: ListLocalInventoriesAsync(ListLocalInventoriesRequest, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLocalInventoriesRequest request = new ListLocalInventoriesRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LocalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLocalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocalInventories</summary>
        public void ListLocalInventories()
        {
            // Snippet: ListLocalInventories(string, string, int?, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LocalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLocalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocalInventoriesAsync</summary>
        public async Task ListLocalInventoriesAsync()
        {
            // Snippet: ListLocalInventoriesAsync(string, string, int?, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LocalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLocalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocalInventories</summary>
        public void ListLocalInventoriesResourceNames()
        {
            // Snippet: ListLocalInventories(ProductName, string, int?, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            PagedEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LocalInventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLocalInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLocalInventoriesAsync</summary>
        public async Task ListLocalInventoriesResourceNamesAsync()
        {
            // Snippet: ListLocalInventoriesAsync(ProductName, string, int?, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            PagedAsyncEnumerable<ListLocalInventoriesResponse, LocalInventory> response = localInventoryServiceClient.ListLocalInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LocalInventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLocalInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LocalInventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LocalInventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LocalInventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for InsertLocalInventory</summary>
        public void InsertLocalInventoryRequestObject()
        {
            // Snippet: InsertLocalInventory(InsertLocalInventoryRequest, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            InsertLocalInventoryRequest request = new InsertLocalInventoryRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                LocalInventory = new LocalInventory(),
            };
            // Make the request
            LocalInventory response = localInventoryServiceClient.InsertLocalInventory(request);
            // End snippet
        }

        /// <summary>Snippet for InsertLocalInventoryAsync</summary>
        public async Task InsertLocalInventoryRequestObjectAsync()
        {
            // Snippet: InsertLocalInventoryAsync(InsertLocalInventoryRequest, CallSettings)
            // Additional: InsertLocalInventoryAsync(InsertLocalInventoryRequest, CancellationToken)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertLocalInventoryRequest request = new InsertLocalInventoryRequest
            {
                ParentAsProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
                LocalInventory = new LocalInventory(),
            };
            // Make the request
            LocalInventory response = await localInventoryServiceClient.InsertLocalInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventory</summary>
        public void DeleteLocalInventoryRequestObject()
        {
            // Snippet: DeleteLocalInventory(DeleteLocalInventoryRequest, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            DeleteLocalInventoryRequest request = new DeleteLocalInventoryRequest
            {
                LocalInventoryName = LocalInventoryName.FromAccountProductStoreCode("[ACCOUNT]", "[PRODUCT]", "[STORE_CODE]"),
            };
            // Make the request
            localInventoryServiceClient.DeleteLocalInventory(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventoryAsync</summary>
        public async Task DeleteLocalInventoryRequestObjectAsync()
        {
            // Snippet: DeleteLocalInventoryAsync(DeleteLocalInventoryRequest, CallSettings)
            // Additional: DeleteLocalInventoryAsync(DeleteLocalInventoryRequest, CancellationToken)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLocalInventoryRequest request = new DeleteLocalInventoryRequest
            {
                LocalInventoryName = LocalInventoryName.FromAccountProductStoreCode("[ACCOUNT]", "[PRODUCT]", "[STORE_CODE]"),
            };
            // Make the request
            await localInventoryServiceClient.DeleteLocalInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventory</summary>
        public void DeleteLocalInventory()
        {
            // Snippet: DeleteLocalInventory(string, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]/localInventories/[STORE_CODE]";
            // Make the request
            localInventoryServiceClient.DeleteLocalInventory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventoryAsync</summary>
        public async Task DeleteLocalInventoryAsync()
        {
            // Snippet: DeleteLocalInventoryAsync(string, CallSettings)
            // Additional: DeleteLocalInventoryAsync(string, CancellationToken)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]/localInventories/[STORE_CODE]";
            // Make the request
            await localInventoryServiceClient.DeleteLocalInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventory</summary>
        public void DeleteLocalInventoryResourceNames()
        {
            // Snippet: DeleteLocalInventory(LocalInventoryName, CallSettings)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = LocalInventoryServiceClient.Create();
            // Initialize request argument(s)
            LocalInventoryName name = LocalInventoryName.FromAccountProductStoreCode("[ACCOUNT]", "[PRODUCT]", "[STORE_CODE]");
            // Make the request
            localInventoryServiceClient.DeleteLocalInventory(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLocalInventoryAsync</summary>
        public async Task DeleteLocalInventoryResourceNamesAsync()
        {
            // Snippet: DeleteLocalInventoryAsync(LocalInventoryName, CallSettings)
            // Additional: DeleteLocalInventoryAsync(LocalInventoryName, CancellationToken)
            // Create client
            LocalInventoryServiceClient localInventoryServiceClient = await LocalInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocalInventoryName name = LocalInventoryName.FromAccountProductStoreCode("[ACCOUNT]", "[PRODUCT]", "[STORE_CODE]");
            // Make the request
            await localInventoryServiceClient.DeleteLocalInventoryAsync(name);
            // End snippet
        }
    }
}
