// Copyright 2022 Google LLC
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

namespace Google.Cloud.Retail.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCatalogServiceClientSnippets
    {
        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogsRequestObject()
        {
            // Snippet: ListCatalogs(ListCatalogsRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsRequestObjectAsync()
        {
            // Snippet: ListCatalogsAsync(ListCatalogsRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Catalog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogs()
        {
            // Snippet: ListCatalogs(string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsAsync()
        {
            // Snippet: ListCatalogsAsync(string, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Catalog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogs</summary>
        public void ListCatalogsResourceNames()
        {
            // Snippet: ListCatalogs(LocationName, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCatalogsAsync</summary>
        public async Task ListCatalogsResourceNamesAsync()
        {
            // Snippet: ListCatalogsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCatalogsResponse, Catalog> response = catalogServiceClient.ListCatalogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Catalog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCatalogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalog</summary>
        public void UpdateCatalogRequestObject()
        {
            // Snippet: UpdateCatalog(UpdateCatalogRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Catalog response = catalogServiceClient.UpdateCatalog(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogAsync</summary>
        public async Task UpdateCatalogRequestObjectAsync()
        {
            // Snippet: UpdateCatalogAsync(UpdateCatalogRequest, CallSettings)
            // Additional: UpdateCatalogAsync(UpdateCatalogRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCatalogRequest request = new UpdateCatalogRequest
            {
                Catalog = new Catalog(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Catalog response = await catalogServiceClient.UpdateCatalogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalog</summary>
        public void UpdateCatalog()
        {
            // Snippet: UpdateCatalog(Catalog, FieldMask, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            Catalog catalog = new Catalog();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Catalog response = catalogServiceClient.UpdateCatalog(catalog, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCatalogAsync</summary>
        public async Task UpdateCatalogAsync()
        {
            // Snippet: UpdateCatalogAsync(Catalog, FieldMask, CallSettings)
            // Additional: UpdateCatalogAsync(Catalog, FieldMask, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            Catalog catalog = new Catalog();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Catalog response = await catalogServiceClient.UpdateCatalogAsync(catalog, updateMask);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranch</summary>
        public void SetDefaultBranchRequestObject()
        {
            // Snippet: SetDefaultBranch(SetDefaultBranchRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                BranchIdAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Note = "",
                Force = false,
            };
            // Make the request
            catalogServiceClient.SetDefaultBranch(request);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranchAsync</summary>
        public async Task SetDefaultBranchRequestObjectAsync()
        {
            // Snippet: SetDefaultBranchAsync(SetDefaultBranchRequest, CallSettings)
            // Additional: SetDefaultBranchAsync(SetDefaultBranchRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetDefaultBranchRequest request = new SetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                BranchIdAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Note = "",
                Force = false,
            };
            // Make the request
            await catalogServiceClient.SetDefaultBranchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranch</summary>
        public void SetDefaultBranch()
        {
            // Snippet: SetDefaultBranch(string, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            catalogServiceClient.SetDefaultBranch(catalog);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranchAsync</summary>
        public async Task SetDefaultBranchAsync()
        {
            // Snippet: SetDefaultBranchAsync(string, CallSettings)
            // Additional: SetDefaultBranchAsync(string, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            await catalogServiceClient.SetDefaultBranchAsync(catalog);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranch</summary>
        public void SetDefaultBranchResourceNames()
        {
            // Snippet: SetDefaultBranch(CatalogName, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            catalogServiceClient.SetDefaultBranch(catalog);
            // End snippet
        }

        /// <summary>Snippet for SetDefaultBranchAsync</summary>
        public async Task SetDefaultBranchResourceNamesAsync()
        {
            // Snippet: SetDefaultBranchAsync(CatalogName, CallSettings)
            // Additional: SetDefaultBranchAsync(CatalogName, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            await catalogServiceClient.SetDefaultBranchAsync(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranch</summary>
        public void GetDefaultBranchRequestObject()
        {
            // Snippet: GetDefaultBranch(GetDefaultBranchRequest, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            GetDefaultBranchResponse response = catalogServiceClient.GetDefaultBranch(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranchAsync</summary>
        public async Task GetDefaultBranchRequestObjectAsync()
        {
            // Snippet: GetDefaultBranchAsync(GetDefaultBranchRequest, CallSettings)
            // Additional: GetDefaultBranchAsync(GetDefaultBranchRequest, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDefaultBranchRequest request = new GetDefaultBranchRequest
            {
                CatalogAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
            };
            // Make the request
            GetDefaultBranchResponse response = await catalogServiceClient.GetDefaultBranchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranch</summary>
        public void GetDefaultBranch()
        {
            // Snippet: GetDefaultBranch(string, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            GetDefaultBranchResponse response = catalogServiceClient.GetDefaultBranch(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranchAsync</summary>
        public async Task GetDefaultBranchAsync()
        {
            // Snippet: GetDefaultBranchAsync(string, CallSettings)
            // Additional: GetDefaultBranchAsync(string, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            string catalog = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]";
            // Make the request
            GetDefaultBranchResponse response = await catalogServiceClient.GetDefaultBranchAsync(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranch</summary>
        public void GetDefaultBranchResourceNames()
        {
            // Snippet: GetDefaultBranch(CatalogName, CallSettings)
            // Create client
            CatalogServiceClient catalogServiceClient = CatalogServiceClient.Create();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            GetDefaultBranchResponse response = catalogServiceClient.GetDefaultBranch(catalog);
            // End snippet
        }

        /// <summary>Snippet for GetDefaultBranchAsync</summary>
        public async Task GetDefaultBranchResourceNamesAsync()
        {
            // Snippet: GetDefaultBranchAsync(CatalogName, CallSettings)
            // Additional: GetDefaultBranchAsync(CatalogName, CancellationToken)
            // Create client
            CatalogServiceClient catalogServiceClient = await CatalogServiceClient.CreateAsync();
            // Initialize request argument(s)
            CatalogName catalog = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]");
            // Make the request
            GetDefaultBranchResponse response = await catalogServiceClient.GetDefaultBranchAsync(catalog);
            // End snippet
        }
    }
}
