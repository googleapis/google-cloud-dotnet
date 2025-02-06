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
    using Google.Cloud.RecommendationEngine.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCatalogServiceClientSnippets
    {
        /// <summary>Snippet for CreateCatalogItem</summary>
        public void CreateCatalogItemRequestObject()
        {
            // Snippet: CreateCatalogItem(CreateCatalogItemRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            // Make the request
            CatalogItem response = catalogServiceClient.CreateCatalogItem(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogItemAsync</summary>
        public async Task CreateCatalogItemRequestObjectAsync()
        {
            // Snippet: CreateCatalogItemAsync(CreateCatalogItemRequest, CallSettings)
            // Additional: CreateCatalogItemAsync(CreateCatalogItemRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCatalogItemRequest request = new CreateCatalogItemRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                CatalogItem = new CatalogItem(),
            };
            // Make the request
            CatalogItem response = await catalogServiceClient.CreateCatalogItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogItem</summary>
        public void CreateCatalogItem()
        {
            // Snippet: CreateCatalogItem(string, CatalogItem, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            CatalogItem catalogItem = new CatalogItem();
            // Make the request
            CatalogItem response = catalogServiceClient.CreateCatalogItem(parent, catalogItem);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogItemAsync</summary>
        public async Task CreateCatalogItemAsync()
        {
            // Snippet: CreateCatalogItemAsync(string, CatalogItem, CallSettings)
            // Additional: CreateCatalogItemAsync(string, CatalogItem, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            CatalogItem catalogItem = new CatalogItem();
            // Make the request
            CatalogItem response = await catalogServiceClient.CreateCatalogItemAsync(parent, catalogItem);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogItem</summary>
        public void CreateCatalogItemResourceNames()
        {
            // Snippet: CreateCatalogItem(CatalogName, CatalogItem, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            CatalogItem catalogItem = new CatalogItem();
            // Make the request
            CatalogItem response = catalogServiceClient.CreateCatalogItem(parent, catalogItem);
            // End snippet
        }

        /// <summary>Snippet for CreateCatalogItemAsync</summary>
        public async Task CreateCatalogItemResourceNamesAsync()
        {
            // Snippet: CreateCatalogItemAsync(CatalogName, CatalogItem, CallSettings)
            // Additional: CreateCatalogItemAsync(CatalogName, CatalogItem, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            CatalogItem catalogItem = new CatalogItem();
            // Make the request
            CatalogItem response = await catalogServiceClient.CreateCatalogItemAsync(parent, catalogItem);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItem</summary>
        public void GetCatalogItemRequestObject()
        {
            // Snippet: GetCatalogItem(GetCatalogItemRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            // Make the request
            CatalogItem response = catalogServiceClient.GetCatalogItem(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItemAsync</summary>
        public async Task GetCatalogItemRequestObjectAsync()
        {
            // Snippet: GetCatalogItemAsync(GetCatalogItemRequest, CallSettings)
            // Additional: GetCatalogItemAsync(GetCatalogItemRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCatalogItemRequest request = new GetCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            // Make the request
            CatalogItem response = await catalogServiceClient.GetCatalogItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItem</summary>
        public void GetCatalogItem()
        {
            // Snippet: GetCatalogItem(string, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            // Make the request
            CatalogItem response = catalogServiceClient.GetCatalogItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItemAsync</summary>
        public async Task GetCatalogItemAsync()
        {
            // Snippet: GetCatalogItemAsync(string, CallSettings)
            // Additional: GetCatalogItemAsync(string, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            // Make the request
            CatalogItem response = await catalogServiceClient.GetCatalogItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItem</summary>
        public void GetCatalogItemResourceNames()
        {
            // Snippet: GetCatalogItem(CatalogItemPathName, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            // Make the request
            CatalogItem response = catalogServiceClient.GetCatalogItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetCatalogItemAsync</summary>
        public async Task GetCatalogItemResourceNamesAsync()
        {
            // Snippet: GetCatalogItemAsync(CatalogItemPathName, CallSettings)
            // Additional: GetCatalogItemAsync(CatalogItemPathName, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            // Make the request
            CatalogItem response = await catalogServiceClient.GetCatalogItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItems</summary>
        public void ListCatalogItemsRequestObject()
        {
            // Snippet: ListCatalogItems(ListCatalogItemsRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItemsAsync</summary>
        public async Task ListCatalogItemsRequestObjectAsync()
        {
            // Snippet: ListCatalogItemsAsync(ListCatalogItemsRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCatalogItemsRequest request = new ListCatalogItemsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CatalogItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItems</summary>
        public void ListCatalogItems()
        {
            // Snippet: ListCatalogItems(string, string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItems(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItemsAsync</summary>
        public async Task ListCatalogItemsAsync()
        {
            // Snippet: ListCatalogItemsAsync(string, string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItemsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CatalogItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItems</summary>
        public void ListCatalogItemsResourceNames()
        {
            // Snippet: ListCatalogItems(CatalogName, string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItems(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CatalogItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogItemsAsync</summary>
        public async Task ListCatalogItemsResourceNamesAsync()
        {
            // Snippet: ListCatalogItemsAsync(CatalogName, string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListCatalogItemsResponse, CatalogItem> response = catalogServiceClient.ListCatalogItemsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CatalogItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CatalogItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CatalogItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CatalogItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItem</summary>
        public void UpdateCatalogItemRequestObject()
        {
            // Snippet: UpdateCatalogItem(UpdateCatalogItemRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CatalogItem response = catalogServiceClient.UpdateCatalogItem(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItemAsync</summary>
        public async Task UpdateCatalogItemRequestObjectAsync()
        {
            // Snippet: UpdateCatalogItemAsync(UpdateCatalogItemRequest, CallSettings)
            // Additional: UpdateCatalogItemAsync(UpdateCatalogItemRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCatalogItemRequest request = new UpdateCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
                CatalogItem = new CatalogItem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CatalogItem response = await catalogServiceClient.UpdateCatalogItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItem</summary>
        public void UpdateCatalogItem()
        {
            // Snippet: UpdateCatalogItem(string, CatalogItem, FieldMask, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            CatalogItem catalogItem = new CatalogItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogItem response = catalogServiceClient.UpdateCatalogItem(name, catalogItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItemAsync</summary>
        public async Task UpdateCatalogItemAsync()
        {
            // Snippet: UpdateCatalogItemAsync(string, CatalogItem, FieldMask, CallSettings)
            // Additional: UpdateCatalogItemAsync(string, CatalogItem, FieldMask, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            CatalogItem catalogItem = new CatalogItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogItem response = await catalogServiceClient.UpdateCatalogItemAsync(name, catalogItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItem</summary>
        public void UpdateCatalogItemResourceNames()
        {
            // Snippet: UpdateCatalogItem(CatalogItemPathName, CatalogItem, FieldMask, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            CatalogItem catalogItem = new CatalogItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogItem response = catalogServiceClient.UpdateCatalogItem(name, catalogItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogItemAsync</summary>
        public async Task UpdateCatalogItemResourceNamesAsync()
        {
            // Snippet: UpdateCatalogItemAsync(CatalogItemPathName, CatalogItem, FieldMask, CallSettings)
            // Additional: UpdateCatalogItemAsync(CatalogItemPathName, CatalogItem, FieldMask, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            CatalogItem catalogItem = new CatalogItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CatalogItem response = await catalogServiceClient.UpdateCatalogItemAsync(name, catalogItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItem</summary>
        public void DeleteCatalogItemRequestObject()
        {
            // Snippet: DeleteCatalogItem(DeleteCatalogItemRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            // Make the request
            catalogServiceClient.DeleteCatalogItem(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItemAsync</summary>
        public async Task DeleteCatalogItemRequestObjectAsync()
        {
            // Snippet: DeleteCatalogItemAsync(DeleteCatalogItemRequest, CallSettings)
            // Additional: DeleteCatalogItemAsync(DeleteCatalogItemRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCatalogItemRequest request = new DeleteCatalogItemRequest
            {
                CatalogItemPathName = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]"),
            };
            // Make the request
            await catalogServiceClient.DeleteCatalogItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItem</summary>
        public void DeleteCatalogItem()
        {
            // Snippet: DeleteCatalogItem(string, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            // Make the request
            catalogServiceClient.DeleteCatalogItem(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItemAsync</summary>
        public async Task DeleteCatalogItemAsync()
        {
            // Snippet: DeleteCatalogItemAsync(string, CallSettings)
            // Additional: DeleteCatalogItemAsync(string, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/catalogItems/[CATALOG_ITEM_PATH]";
            // Make the request
            await catalogServiceClient.DeleteCatalogItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItem</summary>
        public void DeleteCatalogItemResourceNames()
        {
            // Snippet: DeleteCatalogItem(CatalogItemPathName, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            // Make the request
            catalogServiceClient.DeleteCatalogItem(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCatalogItemAsync</summary>
        public async Task DeleteCatalogItemResourceNamesAsync()
        {
            // Snippet: DeleteCatalogItemAsync(CatalogItemPathName, CallSettings)
            // Additional: DeleteCatalogItemAsync(CatalogItemPathName, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogItemPathName name = CatalogItemPathName.FromProjectLocationCatalogCatalogItemPath("[PROJECT]", "[LOCATION]", "[CATALOG]", "[CATALOG_ITEM_PATH]");
            // Make the request
            await catalogServiceClient.DeleteCatalogItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItems</summary>
        public void ImportCatalogItemsRequestObject()
        {
            // Snippet: ImportCatalogItems(ImportCatalogItemsRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            ImportCatalogItemsRequest request = new ImportCatalogItemsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                RequestId = "",
                InputConfig = new InputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = catalogServiceClient.ImportCatalogItems(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = catalogServiceClient.PollOnceImportCatalogItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItemsAsync</summary>
        public async Task ImportCatalogItemsRequestObjectAsync()
        {
            // Snippet: ImportCatalogItemsAsync(ImportCatalogItemsRequest, CallSettings)
            // Additional: ImportCatalogItemsAsync(ImportCatalogItemsRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportCatalogItemsRequest request = new ImportCatalogItemsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                RequestId = "",
                InputConfig = new InputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
            };
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = await catalogServiceClient.ImportCatalogItemsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = await catalogServiceClient.PollOnceImportCatalogItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItems</summary>
        public void ImportCatalogItems()
        {
            // Snippet: ImportCatalogItems(string, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = catalogServiceClient.ImportCatalogItems(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = catalogServiceClient.PollOnceImportCatalogItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItemsAsync</summary>
        public async Task ImportCatalogItemsAsync()
        {
            // Snippet: ImportCatalogItemsAsync(string, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Additional: ImportCatalogItemsAsync(string, string, InputConfig, ImportErrorsConfig, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = await catalogServiceClient.ImportCatalogItemsAsync(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = await catalogServiceClient.PollOnceImportCatalogItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItems</summary>
        public void ImportCatalogItemsResourceNames()
        {
            // Snippet: ImportCatalogItems(CatalogName, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = catalogServiceClient.ImportCatalogItems(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = catalogServiceClient.PollOnceImportCatalogItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportCatalogItemsAsync</summary>
        public async Task ImportCatalogItemsResourceNamesAsync()
        {
            // Snippet: ImportCatalogItemsAsync(CatalogName, string, InputConfig, ImportErrorsConfig, CallSettings)
            // Additional: ImportCatalogItemsAsync(CatalogName, string, InputConfig, ImportErrorsConfig, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName parent = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            string requestId = "";
            InputConfig inputConfig = new InputConfig();
            ImportErrorsConfig errorsConfig = new ImportErrorsConfig();
            // Make the request
            Operation<ImportCatalogItemsResponse, ImportMetadata> response = await catalogServiceClient.ImportCatalogItemsAsync(parent, requestId, inputConfig, errorsConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportCatalogItemsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportCatalogItemsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportCatalogItemsResponse, ImportMetadata> retrievedResponse = await catalogServiceClient.PollOnceImportCatalogItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportCatalogItemsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
