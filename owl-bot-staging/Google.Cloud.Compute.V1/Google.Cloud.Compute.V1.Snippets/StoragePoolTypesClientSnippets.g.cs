// Copyright 2024 Google LLC
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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStoragePoolTypesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListStoragePoolTypesRequest, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            AggregatedListStoragePoolTypesRequest request = new AggregatedListStoragePoolTypesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<StoragePoolTypeAggregatedList, KeyValuePair<string, StoragePoolTypesScopedList>> response = storagePoolTypesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolTypeAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolTypesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListStoragePoolTypesRequest, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListStoragePoolTypesRequest request = new AggregatedListStoragePoolTypesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<StoragePoolTypeAggregatedList, KeyValuePair<string, StoragePoolTypesScopedList>> response = storagePoolTypesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, StoragePoolTypesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolTypeAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolTypesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<StoragePoolTypeAggregatedList, KeyValuePair<string, StoragePoolTypesScopedList>> response = storagePoolTypesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolTypeAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolTypesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<StoragePoolTypeAggregatedList, KeyValuePair<string, StoragePoolTypesScopedList>> response = storagePoolTypesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, StoragePoolTypesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolTypeAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolTypesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolTypesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetStoragePoolTypeRequest, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            GetStoragePoolTypeRequest request = new GetStoragePoolTypeRequest
            {
                Zone = "",
                Project = "",
                StoragePoolType = "",
            };
            // Make the request
            StoragePoolType response = storagePoolTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetStoragePoolTypeRequest, CallSettings)
            // Additional: GetAsync(GetStoragePoolTypeRequest, CancellationToken)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetStoragePoolTypeRequest request = new GetStoragePoolTypeRequest
            {
                Zone = "",
                Project = "",
                StoragePoolType = "",
            };
            // Make the request
            StoragePoolType response = await storagePoolTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePoolType = "";
            // Make the request
            StoragePoolType response = storagePoolTypesClient.Get(project, zone, storagePoolType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePoolType = "";
            // Make the request
            StoragePoolType response = await storagePoolTypesClient.GetAsync(project, zone, storagePoolType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListStoragePoolTypesRequest, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            ListStoragePoolTypesRequest request = new ListStoragePoolTypesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<StoragePoolTypeList, StoragePoolType> response = storagePoolTypesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePoolType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolTypeList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListStoragePoolTypesRequest, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListStoragePoolTypesRequest request = new ListStoragePoolTypesRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<StoragePoolTypeList, StoragePoolType> response = storagePoolTypesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePoolType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolTypeList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = StoragePoolTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<StoragePoolTypeList, StoragePoolType> response = storagePoolTypesClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePoolType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolTypeList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            StoragePoolTypesClient storagePoolTypesClient = await StoragePoolTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<StoragePoolTypeList, StoragePoolType> response = storagePoolTypesClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePoolType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolTypeList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolType item in singlePage)
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
