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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ApiHub.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApiHubDiscoveryClientSnippets
    {
        /// <summary>Snippet for ListDiscoveredApiObservations</summary>
        public void ListDiscoveredApiObservationsRequestObject()
        {
            // Snippet: ListDiscoveredApiObservations(ListDiscoveredApiObservationsRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiObservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiObservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiObservationsAsync</summary>
        public async Task ListDiscoveredApiObservationsRequestObjectAsync()
        {
            // Snippet: ListDiscoveredApiObservationsAsync(ListDiscoveredApiObservationsRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            ListDiscoveredApiObservationsRequest request = new ListDiscoveredApiObservationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiObservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiObservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiObservations</summary>
        public void ListDiscoveredApiObservations()
        {
            // Snippet: ListDiscoveredApiObservations(string, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiObservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiObservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiObservationsAsync</summary>
        public async Task ListDiscoveredApiObservationsAsync()
        {
            // Snippet: ListDiscoveredApiObservationsAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiObservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiObservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiObservations</summary>
        public void ListDiscoveredApiObservationsResourceNames()
        {
            // Snippet: ListDiscoveredApiObservations(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiObservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiObservationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiObservationsAsync</summary>
        public async Task ListDiscoveredApiObservationsResourceNamesAsync()
        {
            // Snippet: ListDiscoveredApiObservationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiObservationsResponse, DiscoveredApiObservation> response = apiHubDiscoveryClient.ListDiscoveredApiObservationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiObservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiObservationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiObservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiObservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiObservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservation</summary>
        public void GetDiscoveredApiObservationRequestObject()
        {
            // Snippet: GetDiscoveredApiObservation(GetDiscoveredApiObservationRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            GetDiscoveredApiObservationRequest request = new GetDiscoveredApiObservationRequest
            {
                DiscoveredApiObservationName = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]"),
            };
            // Make the request
            DiscoveredApiObservation response = apiHubDiscoveryClient.GetDiscoveredApiObservation(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservationAsync</summary>
        public async Task GetDiscoveredApiObservationRequestObjectAsync()
        {
            // Snippet: GetDiscoveredApiObservationAsync(GetDiscoveredApiObservationRequest, CallSettings)
            // Additional: GetDiscoveredApiObservationAsync(GetDiscoveredApiObservationRequest, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            GetDiscoveredApiObservationRequest request = new GetDiscoveredApiObservationRequest
            {
                DiscoveredApiObservationName = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]"),
            };
            // Make the request
            DiscoveredApiObservation response = await apiHubDiscoveryClient.GetDiscoveredApiObservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservation</summary>
        public void GetDiscoveredApiObservation()
        {
            // Snippet: GetDiscoveredApiObservation(string, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]";
            // Make the request
            DiscoveredApiObservation response = apiHubDiscoveryClient.GetDiscoveredApiObservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservationAsync</summary>
        public async Task GetDiscoveredApiObservationAsync()
        {
            // Snippet: GetDiscoveredApiObservationAsync(string, CallSettings)
            // Additional: GetDiscoveredApiObservationAsync(string, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]";
            // Make the request
            DiscoveredApiObservation response = await apiHubDiscoveryClient.GetDiscoveredApiObservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservation</summary>
        public void GetDiscoveredApiObservationResourceNames()
        {
            // Snippet: GetDiscoveredApiObservation(DiscoveredApiObservationName, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            DiscoveredApiObservationName name = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]");
            // Make the request
            DiscoveredApiObservation response = apiHubDiscoveryClient.GetDiscoveredApiObservation(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiObservationAsync</summary>
        public async Task GetDiscoveredApiObservationResourceNamesAsync()
        {
            // Snippet: GetDiscoveredApiObservationAsync(DiscoveredApiObservationName, CallSettings)
            // Additional: GetDiscoveredApiObservationAsync(DiscoveredApiObservationName, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredApiObservationName name = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]");
            // Make the request
            DiscoveredApiObservation response = await apiHubDiscoveryClient.GetDiscoveredApiObservationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperations</summary>
        public void ListDiscoveredApiOperationsRequestObject()
        {
            // Snippet: ListDiscoveredApiOperations(ListDiscoveredApiOperationsRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
            {
                ParentAsDiscoveredApiObservationName = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]"),
            };
            // Make the request
            PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperationsAsync</summary>
        public async Task ListDiscoveredApiOperationsRequestObjectAsync()
        {
            // Snippet: ListDiscoveredApiOperationsAsync(ListDiscoveredApiOperationsRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            ListDiscoveredApiOperationsRequest request = new ListDiscoveredApiOperationsRequest
            {
                ParentAsDiscoveredApiObservationName = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperations</summary>
        public void ListDiscoveredApiOperations()
        {
            // Snippet: ListDiscoveredApiOperations(string, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]";
            // Make the request
            PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperationsAsync</summary>
        public async Task ListDiscoveredApiOperationsAsync()
        {
            // Snippet: ListDiscoveredApiOperationsAsync(string, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]";
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperations</summary>
        public void ListDiscoveredApiOperationsResourceNames()
        {
            // Snippet: ListDiscoveredApiOperations(DiscoveredApiObservationName, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            DiscoveredApiObservationName parent = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]");
            // Make the request
            PagedEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiscoveredApiOperation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDiscoveredApiOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDiscoveredApiOperationsAsync</summary>
        public async Task ListDiscoveredApiOperationsResourceNamesAsync()
        {
            // Snippet: ListDiscoveredApiOperationsAsync(DiscoveredApiObservationName, string, int?, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredApiObservationName parent = DiscoveredApiObservationName.FromProjectLocationDiscoveredApiObservation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]");
            // Make the request
            PagedAsyncEnumerable<ListDiscoveredApiOperationsResponse, DiscoveredApiOperation> response = apiHubDiscoveryClient.ListDiscoveredApiOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiscoveredApiOperation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDiscoveredApiOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiscoveredApiOperation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiscoveredApiOperation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiscoveredApiOperation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperation</summary>
        public void GetDiscoveredApiOperationRequestObject()
        {
            // Snippet: GetDiscoveredApiOperation(GetDiscoveredApiOperationRequest, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            GetDiscoveredApiOperationRequest request = new GetDiscoveredApiOperationRequest
            {
                DiscoveredApiOperationName = DiscoveredApiOperationName.FromProjectLocationDiscoveredApiObservationDiscoveredApiOperation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]", "[DISCOVERED_API_OPERATION]"),
            };
            // Make the request
            DiscoveredApiOperation response = apiHubDiscoveryClient.GetDiscoveredApiOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperationAsync</summary>
        public async Task GetDiscoveredApiOperationRequestObjectAsync()
        {
            // Snippet: GetDiscoveredApiOperationAsync(GetDiscoveredApiOperationRequest, CallSettings)
            // Additional: GetDiscoveredApiOperationAsync(GetDiscoveredApiOperationRequest, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            GetDiscoveredApiOperationRequest request = new GetDiscoveredApiOperationRequest
            {
                DiscoveredApiOperationName = DiscoveredApiOperationName.FromProjectLocationDiscoveredApiObservationDiscoveredApiOperation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]", "[DISCOVERED_API_OPERATION]"),
            };
            // Make the request
            DiscoveredApiOperation response = await apiHubDiscoveryClient.GetDiscoveredApiOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperation</summary>
        public void GetDiscoveredApiOperation()
        {
            // Snippet: GetDiscoveredApiOperation(string, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]/discoveredApiOperations/[DISCOVERED_API_OPERATION]";
            // Make the request
            DiscoveredApiOperation response = apiHubDiscoveryClient.GetDiscoveredApiOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperationAsync</summary>
        public async Task GetDiscoveredApiOperationAsync()
        {
            // Snippet: GetDiscoveredApiOperationAsync(string, CallSettings)
            // Additional: GetDiscoveredApiOperationAsync(string, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/discoveredApiObservations/[DISCOVERED_API_OBSERVATION]/discoveredApiOperations/[DISCOVERED_API_OPERATION]";
            // Make the request
            DiscoveredApiOperation response = await apiHubDiscoveryClient.GetDiscoveredApiOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperation</summary>
        public void GetDiscoveredApiOperationResourceNames()
        {
            // Snippet: GetDiscoveredApiOperation(DiscoveredApiOperationName, CallSettings)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = ApiHubDiscoveryClient.Create();
            // Initialize request argument(s)
            DiscoveredApiOperationName name = DiscoveredApiOperationName.FromProjectLocationDiscoveredApiObservationDiscoveredApiOperation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]", "[DISCOVERED_API_OPERATION]");
            // Make the request
            DiscoveredApiOperation response = apiHubDiscoveryClient.GetDiscoveredApiOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetDiscoveredApiOperationAsync</summary>
        public async Task GetDiscoveredApiOperationResourceNamesAsync()
        {
            // Snippet: GetDiscoveredApiOperationAsync(DiscoveredApiOperationName, CallSettings)
            // Additional: GetDiscoveredApiOperationAsync(DiscoveredApiOperationName, CancellationToken)
            // Create client
            ApiHubDiscoveryClient apiHubDiscoveryClient = await ApiHubDiscoveryClient.CreateAsync();
            // Initialize request argument(s)
            DiscoveredApiOperationName name = DiscoveredApiOperationName.FromProjectLocationDiscoveredApiObservationDiscoveredApiOperation("[PROJECT]", "[LOCATION]", "[DISCOVERED_API_OBSERVATION]", "[DISCOVERED_API_OPERATION]");
            // Make the request
            DiscoveredApiOperation response = await apiHubDiscoveryClient.GetDiscoveredApiOperationAsync(name);
            // End snippet
        }
    }
}
