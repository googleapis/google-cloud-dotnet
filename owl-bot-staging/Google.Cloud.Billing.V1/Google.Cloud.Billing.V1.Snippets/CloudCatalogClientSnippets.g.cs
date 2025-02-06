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
    using Google.Cloud.Billing.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudCatalogClientSnippets
    {
        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = CloudCatalogClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest { };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = cloudCatalogClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = await CloudCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = cloudCatalogClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = CloudCatalogClient.Create();
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = cloudCatalogClient.ListServices();

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = await CloudCatalogClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = cloudCatalogClient.ListServicesAsync();

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusRequestObject()
        {
            // Snippet: ListSkus(ListSkusRequest, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = CloudCatalogClient.Create();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = ServiceName.FromService("[SERVICE]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                CurrencyCode = "",
            };
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusRequestObjectAsync()
        {
            // Snippet: ListSkusAsync(ListSkusRequest, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = await CloudCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = ServiceName.FromService("[SERVICE]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                CurrencyCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkus()
        {
            // Snippet: ListSkus(string, string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = CloudCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusAsync()
        {
            // Snippet: ListSkusAsync(string, string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = await CloudCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusResourceNames()
        {
            // Snippet: ListSkus(ServiceName, string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = CloudCatalogClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromService("[SERVICE]");
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusResourceNamesAsync()
        {
            // Snippet: ListSkusAsync(ServiceName, string, int?, CallSettings)
            // Create client
            CloudCatalogClient cloudCatalogClient = await CloudCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromService("[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = cloudCatalogClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
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
