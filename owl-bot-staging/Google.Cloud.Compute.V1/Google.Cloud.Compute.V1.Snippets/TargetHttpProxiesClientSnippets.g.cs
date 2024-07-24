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
    public sealed class AllGeneratedTargetHttpProxiesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetHttpProxiesRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetHttpProxiesRequest request = new AggregatedListTargetHttpProxiesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpProxyAggregatedList, KeyValuePair<string, TargetHttpProxiesScopedList>> response = targetHttpProxiesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpProxiesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListTargetHttpProxiesRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetHttpProxiesRequest request = new AggregatedListTargetHttpProxiesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyAggregatedList, KeyValuePair<string, TargetHttpProxiesScopedList>> response = targetHttpProxiesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetHttpProxiesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpProxiesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in singlePage)
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
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetHttpProxyAggregatedList, KeyValuePair<string, TargetHttpProxiesScopedList>> response = targetHttpProxiesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpProxiesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in singlePage)
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
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyAggregatedList, KeyValuePair<string, TargetHttpProxiesScopedList>> response = targetHttpProxiesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetHttpProxiesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpProxiesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpProxiesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteTargetHttpProxyRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            DeleteTargetHttpProxyRequest request = new DeleteTargetHttpProxyRequest
            {
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetHttpProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetHttpProxyRequest, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetHttpProxyRequest request = new DeleteTargetHttpProxyRequest
            {
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceDeleteAsync(operationName);
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
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Delete(project, targetHttpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceDelete(operationName);
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
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.DeleteAsync(project, targetHttpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetHttpProxyRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            GetTargetHttpProxyRequest request = new GetTargetHttpProxyRequest
            {
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = targetHttpProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetHttpProxyRequest, CallSettings)
            // Additional: GetAsync(GetTargetHttpProxyRequest, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetHttpProxyRequest request = new GetTargetHttpProxyRequest
            {
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpProxy response = await targetHttpProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = targetHttpProxiesClient.Get(project, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            // Make the request
            TargetHttpProxy response = await targetHttpProxiesClient.GetAsync(project, targetHttpProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetHttpProxyRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            InsertTargetHttpProxyRequest request = new InsertTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetHttpProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetHttpProxyRequest, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetHttpProxyRequest request = new InsertTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, TargetHttpProxy, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Insert(project, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, TargetHttpProxy, CallSettings)
            // Additional: InsertAsync(string, TargetHttpProxy, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.InsertAsync(project, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetHttpProxiesRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            ListTargetHttpProxiesRequest request = new ListTargetHttpProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> response = targetHttpProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            // Snippet: ListAsync(ListTargetHttpProxiesRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetHttpProxiesRequest request = new ListTargetHttpProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> response = targetHttpProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> response = targetHttpProxiesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> response = targetHttpProxiesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpProxy item in singlePage)
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
            // Snippet: Patch(PatchTargetHttpProxyRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            PatchTargetHttpProxyRequest request = new PatchTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchTargetHttpProxyRequest, CallSettings)
            // Additional: PatchAsync(PatchTargetHttpProxyRequest, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            PatchTargetHttpProxyRequest request = new PatchTargetHttpProxyRequest
            {
                TargetHttpProxyResource = new TargetHttpProxy(),
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, TargetHttpProxy, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.Patch(project, targetHttpProxy, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, TargetHttpProxy, CallSettings)
            // Additional: PatchAsync(string, string, TargetHttpProxy, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            TargetHttpProxy targetHttpProxyResource = new TargetHttpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.PatchAsync(project, targetHttpProxy, targetHttpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMapRequestObject()
        {
            // Snippet: SetUrlMap(SetUrlMapTargetHttpProxyRequest, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            SetUrlMapTargetHttpProxyRequest request = new SetUrlMapTargetHttpProxyRequest
            {
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.SetUrlMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceSetUrlMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapRequestObjectAsync()
        {
            // Snippet: SetUrlMapAsync(SetUrlMapTargetHttpProxyRequest, CallSettings)
            // Additional: SetUrlMapAsync(SetUrlMapTargetHttpProxyRequest, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetUrlMapTargetHttpProxyRequest request = new SetUrlMapTargetHttpProxyRequest
            {
                RequestId = "",
                TargetHttpProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.SetUrlMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceSetUrlMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMap</summary>
        public void SetUrlMap()
        {
            // Snippet: SetUrlMap(string, string, UrlMapReference, CallSettings)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = TargetHttpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpProxiesClient.SetUrlMap(project, targetHttpProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpProxiesClient.PollOnceSetUrlMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetUrlMapAsync</summary>
        public async Task SetUrlMapAsync()
        {
            // Snippet: SetUrlMapAsync(string, string, UrlMapReference, CallSettings)
            // Additional: SetUrlMapAsync(string, string, UrlMapReference, CancellationToken)
            // Create client
            TargetHttpProxiesClient targetHttpProxiesClient = await TargetHttpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpProxiesClient.SetUrlMapAsync(project, targetHttpProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpProxiesClient.PollOnceSetUrlMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
