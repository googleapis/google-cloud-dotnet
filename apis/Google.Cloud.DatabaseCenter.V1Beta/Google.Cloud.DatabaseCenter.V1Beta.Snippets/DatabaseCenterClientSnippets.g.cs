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
    using Google.Api.Gax;
    using Google.Cloud.DatabaseCenter.V1Beta;
    using Google.Type;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDatabaseCenterClientSnippets
    {
        /// <summary>Snippet for QueryProducts</summary>
        public void QueryProductsRequestObject()
        {
            // Snippet: QueryProducts(QueryProductsRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = DatabaseCenterClient.Create();
            // Initialize request argument(s)
            QueryProductsRequest request = new QueryProductsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<QueryProductsResponse, Product> response = databaseCenterClient.QueryProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryProductsAsync</summary>
        public async Task QueryProductsRequestObjectAsync()
        {
            // Snippet: QueryProductsAsync(QueryProductsRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = await DatabaseCenterClient.CreateAsync();
            // Initialize request argument(s)
            QueryProductsRequest request = new QueryProductsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<QueryProductsResponse, Product> response = databaseCenterClient.QueryProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (QueryProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateFleet</summary>
        public void AggregateFleetRequestObject()
        {
            // Snippet: AggregateFleet(AggregateFleetRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = DatabaseCenterClient.Create();
            // Initialize request argument(s)
            AggregateFleetRequest request = new AggregateFleetRequest
            {
                Parent = "",
                Filter = "",
                GroupBy = "",
                OrderBy = "",
                BaselineDate = new Date(),
            };
            // Make the request
            PagedEnumerable<AggregateFleetResponse, AggregateFleetRow> response = databaseCenterClient.AggregateFleet(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateFleetRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AggregateFleetResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateFleetRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateFleetRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateFleetRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateFleetAsync</summary>
        public async Task AggregateFleetRequestObjectAsync()
        {
            // Snippet: AggregateFleetAsync(AggregateFleetRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = await DatabaseCenterClient.CreateAsync();
            // Initialize request argument(s)
            AggregateFleetRequest request = new AggregateFleetRequest
            {
                Parent = "",
                Filter = "",
                GroupBy = "",
                OrderBy = "",
                BaselineDate = new Date(),
            };
            // Make the request
            PagedAsyncEnumerable<AggregateFleetResponse, AggregateFleetRow> response = databaseCenterClient.AggregateFleetAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AggregateFleetRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (AggregateFleetResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateFleetRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateFleetRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateFleetRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDatabaseResourceGroups</summary>
        public void QueryDatabaseResourceGroupsRequestObject()
        {
            // Snippet: QueryDatabaseResourceGroups(QueryDatabaseResourceGroupsRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = DatabaseCenterClient.Create();
            // Initialize request argument(s)
            QueryDatabaseResourceGroupsRequest request = new QueryDatabaseResourceGroupsRequest
            {
                Parent = "",
                Filter = "",
                SignalTypeGroups =
                {
                    new SignalTypeGroup(),
                },
                SignalFilters = { new SignalFilter(), },
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<QueryDatabaseResourceGroupsResponse, DatabaseResourceGroup> response = databaseCenterClient.QueryDatabaseResourceGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatabaseResourceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDatabaseResourceGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseResourceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseResourceGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseResourceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDatabaseResourceGroupsAsync</summary>
        public async Task QueryDatabaseResourceGroupsRequestObjectAsync()
        {
            // Snippet: QueryDatabaseResourceGroupsAsync(QueryDatabaseResourceGroupsRequest, CallSettings)
            // Create client
            DatabaseCenterClient databaseCenterClient = await DatabaseCenterClient.CreateAsync();
            // Initialize request argument(s)
            QueryDatabaseResourceGroupsRequest request = new QueryDatabaseResourceGroupsRequest
            {
                Parent = "",
                Filter = "",
                SignalTypeGroups =
                {
                    new SignalTypeGroup(),
                },
                SignalFilters = { new SignalFilter(), },
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryDatabaseResourceGroupsResponse, DatabaseResourceGroup> response = databaseCenterClient.QueryDatabaseResourceGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DatabaseResourceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (QueryDatabaseResourceGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseResourceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseResourceGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseResourceGroup item in singlePage)
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
