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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUrlMapsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<UrlMapsAggregatedList, KeyValuePair<string, UrlMapsScopedList>> response = urlMapsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, UrlMapsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapsAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, UrlMapsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, UrlMapsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, UrlMapsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListUrlMapsRequest request = new AggregatedListUrlMapsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<UrlMapsAggregatedList, KeyValuePair<string, UrlMapsScopedList>> response = urlMapsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, UrlMapsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapsAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, UrlMapsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, UrlMapsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, UrlMapsScopedList> item in singlePage)
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
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<UrlMapsAggregatedList, KeyValuePair<string, UrlMapsScopedList>> response = urlMapsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, UrlMapsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapsAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, UrlMapsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, UrlMapsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, UrlMapsScopedList> item in singlePage)
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
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<UrlMapsAggregatedList, KeyValuePair<string, UrlMapsScopedList>> response = urlMapsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, UrlMapsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapsAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, UrlMapsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, UrlMapsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, UrlMapsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteUrlMapRequest, CallSettings)
            // Additional: DeleteAsync(DeleteUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUrlMapRequest request = new DeleteUrlMapRequest
            {
                RequestId = "",
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Delete(project, urlMap);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.DeleteAsync(project, urlMap);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMap response = urlMapsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetUrlMapRequest, CallSettings)
            // Additional: GetAsync(GetUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            GetUrlMapRequest request = new GetUrlMapRequest
            {
                Project = "",
                UrlMap = "",
            };
            // Make the request
            UrlMap response = await urlMapsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            UrlMap response = urlMapsClient.Get(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            // Make the request
            UrlMap response = await urlMapsClient.GetAsync(project, urlMap);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertUrlMapRequest, CallSettings)
            // Additional: InsertAsync(InsertUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            InsertUrlMapRequest request = new InsertUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Insert(project, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, UrlMap, CallSettings)
            // Additional: InsertAsync(string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.InsertAsync(project, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InvalidateCache</summary>
        public void InvalidateCacheRequestObject()
        {
            // Snippet: InvalidateCache(InvalidateCacheUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "",
                Project = "",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.InvalidateCache(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceInvalidateCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InvalidateCacheAsync</summary>
        public async Task InvalidateCacheRequestObjectAsync()
        {
            // Snippet: InvalidateCacheAsync(InvalidateCacheUrlMapRequest, CallSettings)
            // Additional: InvalidateCacheAsync(InvalidateCacheUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            InvalidateCacheUrlMapRequest request = new InvalidateCacheUrlMapRequest
            {
                RequestId = "",
                Project = "",
                CacheInvalidationRuleResource = new CacheInvalidationRule(),
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.InvalidateCacheAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceInvalidateCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InvalidateCache</summary>
        public void InvalidateCache()
        {
            // Snippet: InvalidateCache(string, string, CacheInvalidationRule, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            CacheInvalidationRule cacheInvalidationRuleResource = new CacheInvalidationRule();
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.InvalidateCache(project, urlMap, cacheInvalidationRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceInvalidateCache(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InvalidateCacheAsync</summary>
        public async Task InvalidateCacheAsync()
        {
            // Snippet: InvalidateCacheAsync(string, string, CacheInvalidationRule, CallSettings)
            // Additional: InvalidateCacheAsync(string, string, CacheInvalidationRule, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            CacheInvalidationRule cacheInvalidationRuleResource = new CacheInvalidationRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.InvalidateCacheAsync(project, urlMap, cacheInvalidationRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceInvalidateCacheAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<UrlMapList, UrlMap> response = urlMapsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
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
            // Snippet: ListAsync(ListUrlMapsRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ListUrlMapsRequest request = new ListUrlMapsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<UrlMapList, UrlMap> response = urlMapsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UrlMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
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
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<UrlMapList, UrlMap> response = urlMapsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UrlMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (UrlMapList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
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
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<UrlMapList, UrlMap> response = urlMapsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UrlMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((UrlMapList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UrlMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UrlMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UrlMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchUrlMapRequest, CallSettings)
            // Additional: PatchAsync(PatchUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            PatchUrlMapRequest request = new PatchUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Patch(project, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, UrlMap, CallSettings)
            // Additional: PatchAsync(string, string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.PatchAsync(project, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateUrlMapRequest, CallSettings)
            // Additional: UpdateAsync(UpdateUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUrlMapRequest request = new UpdateUrlMapRequest
            {
                RequestId = "",
                UrlMapResource = new UrlMap(),
                Project = "",
                UrlMap = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, UrlMap, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = urlMapsClient.Update(project, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = urlMapsClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, UrlMap, CallSettings)
            // Additional: UpdateAsync(string, string, UrlMap, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMap urlMapResource = new UrlMap();
            // Make the request
            lro::Operation<Operation, Operation> response = await urlMapsClient.UpdateAsync(project, urlMap, urlMapResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await urlMapsClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void ValidateRequestObject()
        {
            // Snippet: Validate(ValidateUrlMapRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "",
                UrlMap = "",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            // Make the request
            UrlMapsValidateResponse response = urlMapsClient.Validate(request);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateRequestObjectAsync()
        {
            // Snippet: ValidateAsync(ValidateUrlMapRequest, CallSettings)
            // Additional: ValidateAsync(ValidateUrlMapRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            ValidateUrlMapRequest request = new ValidateUrlMapRequest
            {
                Project = "",
                UrlMap = "",
                UrlMapsValidateRequestResource = new UrlMapsValidateRequest(),
            };
            // Make the request
            UrlMapsValidateResponse response = await urlMapsClient.ValidateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Validate</summary>
        public void Validate()
        {
            // Snippet: Validate(string, string, UrlMapsValidateRequest, CallSettings)
            // Create client
            UrlMapsClient urlMapsClient = UrlMapsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMapsValidateRequest urlMapsValidateRequestResource = new UrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = urlMapsClient.Validate(project, urlMap, urlMapsValidateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ValidateAsync</summary>
        public async Task ValidateAsync()
        {
            // Snippet: ValidateAsync(string, string, UrlMapsValidateRequest, CallSettings)
            // Additional: ValidateAsync(string, string, UrlMapsValidateRequest, CancellationToken)
            // Create client
            UrlMapsClient urlMapsClient = await UrlMapsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string urlMap = "";
            UrlMapsValidateRequest urlMapsValidateRequestResource = new UrlMapsValidateRequest();
            // Make the request
            UrlMapsValidateResponse response = await urlMapsClient.ValidateAsync(project, urlMap, urlMapsValidateRequestResource);
            // End snippet
        }
    }
}
