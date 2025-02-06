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
    public sealed class AllGeneratedTargetHttpsProxiesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListTargetHttpsProxiesRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpsProxyAggregatedList, KeyValuePair<string, TargetHttpsProxiesScopedList>> response = targetHttpsProxiesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpsProxiesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyAggregatedList, KeyValuePair<string, TargetHttpsProxiesScopedList>> response = targetHttpsProxiesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetHttpsProxiesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpsProxiesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in singlePage)
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetHttpsProxyAggregatedList, KeyValuePair<string, TargetHttpsProxiesScopedList>> response = targetHttpsProxiesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpsProxiesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in singlePage)
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyAggregatedList, KeyValuePair<string, TargetHttpsProxiesScopedList>> response = targetHttpsProxiesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, TargetHttpsProxiesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, TargetHttpsProxiesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, TargetHttpsProxiesScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteTargetHttpsProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetHttpsProxyRequest request = new DeleteTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceDeleteAsync(operationName);
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Delete(project, targetHttpsProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceDelete(operationName);
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.DeleteAsync(project, targetHttpsProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpsProxy response = targetHttpsProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetTargetHttpsProxyRequest, CallSettings)
            // Additional: GetAsync(GetTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetHttpsProxyRequest request = new GetTargetHttpsProxyRequest
            {
                TargetHttpsProxy = "",
                Project = "",
            };
            // Make the request
            TargetHttpsProxy response = await targetHttpsProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            // Make the request
            TargetHttpsProxy response = targetHttpsProxiesClient.Get(project, targetHttpsProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            // Make the request
            TargetHttpsProxy response = await targetHttpsProxiesClient.GetAsync(project, targetHttpsProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertTargetHttpsProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertTargetHttpsProxyRequest request = new InsertTargetHttpsProxyRequest
            {
                RequestId = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, TargetHttpsProxy, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Insert(project, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, TargetHttpsProxy, CallSettings)
            // Additional: InsertAsync(string, TargetHttpsProxy, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.InsertAsync(project, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListTargetHttpsProxiesRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = targetHttpsProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpsProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            // Snippet: ListAsync(ListTargetHttpsProxiesRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = targetHttpsProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpsProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = targetHttpsProxiesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetHttpsProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetHttpsProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> response = targetHttpsProxiesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetHttpsProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetHttpsProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetHttpsProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetHttpsProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetHttpsProxy item in singlePage)
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
            // Snippet: Patch(PatchTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchTargetHttpsProxyRequest, CallSettings)
            // Additional: PatchAsync(PatchTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            PatchTargetHttpsProxyRequest request = new PatchTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                TargetHttpsProxyResource = new TargetHttpsProxy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, TargetHttpsProxy, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.Patch(project, targetHttpsProxy, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, TargetHttpsProxy, CallSettings)
            // Additional: PatchAsync(string, string, TargetHttpsProxy, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxy targetHttpsProxyResource = new TargetHttpsProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.PatchAsync(project, targetHttpsProxy, targetHttpsProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMap</summary>
        public void SetCertificateMapRequestObject()
        {
            // Snippet: SetCertificateMap(SetCertificateMapTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetCertificateMapTargetHttpsProxyRequest request = new SetCertificateMapTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                TargetHttpsProxiesSetCertificateMapRequestResource = new TargetHttpsProxiesSetCertificateMapRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetCertificateMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMapAsync</summary>
        public async Task SetCertificateMapRequestObjectAsync()
        {
            // Snippet: SetCertificateMapAsync(SetCertificateMapTargetHttpsProxyRequest, CallSettings)
            // Additional: SetCertificateMapAsync(SetCertificateMapTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetCertificateMapTargetHttpsProxyRequest request = new SetCertificateMapTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                TargetHttpsProxiesSetCertificateMapRequestResource = new TargetHttpsProxiesSetCertificateMapRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetCertificateMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMap</summary>
        public void SetCertificateMap()
        {
            // Snippet: SetCertificateMap(string, string, TargetHttpsProxiesSetCertificateMapRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetCertificateMapRequest targetHttpsProxiesSetCertificateMapRequestResource = new TargetHttpsProxiesSetCertificateMapRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetCertificateMap(project, targetHttpsProxy, targetHttpsProxiesSetCertificateMapRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetCertificateMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetCertificateMapAsync</summary>
        public async Task SetCertificateMapAsync()
        {
            // Snippet: SetCertificateMapAsync(string, string, TargetHttpsProxiesSetCertificateMapRequest, CallSettings)
            // Additional: SetCertificateMapAsync(string, string, TargetHttpsProxiesSetCertificateMapRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetCertificateMapRequest targetHttpsProxiesSetCertificateMapRequestResource = new TargetHttpsProxiesSetCertificateMapRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetCertificateMapAsync(project, targetHttpsProxy, targetHttpsProxiesSetCertificateMapRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetCertificateMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetQuicOverride</summary>
        public void SetQuicOverrideRequestObject()
        {
            // Snippet: SetQuicOverride(SetQuicOverrideTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetQuicOverride(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetQuicOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetQuicOverrideAsync</summary>
        public async Task SetQuicOverrideRequestObjectAsync()
        {
            // Snippet: SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest, CallSettings)
            // Additional: SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetQuicOverrideTargetHttpsProxyRequest request = new SetQuicOverrideTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                TargetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetQuicOverrideAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetQuicOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetQuicOverride</summary>
        public void SetQuicOverride()
        {
            // Snippet: SetQuicOverride(string, string, TargetHttpsProxiesSetQuicOverrideRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetQuicOverride(project, targetHttpsProxy, targetHttpsProxiesSetQuicOverrideRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetQuicOverride(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetQuicOverrideAsync</summary>
        public async Task SetQuicOverrideAsync()
        {
            // Snippet: SetQuicOverrideAsync(string, string, TargetHttpsProxiesSetQuicOverrideRequest, CallSettings)
            // Additional: SetQuicOverrideAsync(string, string, TargetHttpsProxiesSetQuicOverrideRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource = new TargetHttpsProxiesSetQuicOverrideRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetQuicOverrideAsync(project, targetHttpsProxy, targetHttpsProxiesSetQuicOverrideRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetQuicOverrideAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificatesRequestObject()
        {
            // Snippet: SetSslCertificates(SetSslCertificatesTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetSslCertificates(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesRequestObjectAsync()
        {
            // Snippet: SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetSslCertificatesTargetHttpsProxyRequest request = new SetSslCertificatesTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                TargetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetSslCertificatesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificates</summary>
        public void SetSslCertificates()
        {
            // Snippet: SetSslCertificates(string, string, TargetHttpsProxiesSetSslCertificatesRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetSslCertificates(project, targetHttpsProxy, targetHttpsProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetSslCertificates(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslCertificatesAsync</summary>
        public async Task SetSslCertificatesAsync()
        {
            // Snippet: SetSslCertificatesAsync(string, string, TargetHttpsProxiesSetSslCertificatesRequest, CallSettings)
            // Additional: SetSslCertificatesAsync(string, string, TargetHttpsProxiesSetSslCertificatesRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource = new TargetHttpsProxiesSetSslCertificatesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetSslCertificatesAsync(project, targetHttpsProxy, targetHttpsProxiesSetSslCertificatesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetSslCertificatesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicy</summary>
        public void SetSslPolicyRequestObject()
        {
            // Snippet: SetSslPolicy(SetSslPolicyTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetSslPolicy(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetSslPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicyAsync</summary>
        public async Task SetSslPolicyRequestObjectAsync()
        {
            // Snippet: SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest, CallSettings)
            // Additional: SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetSslPolicyTargetHttpsProxyRequest request = new SetSslPolicyTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                SslPolicyReferenceResource = new SslPolicyReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetSslPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetSslPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicy</summary>
        public void SetSslPolicy()
        {
            // Snippet: SetSslPolicy(string, string, SslPolicyReference, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            SslPolicyReference sslPolicyReferenceResource = new SslPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetSslPolicy(project, targetHttpsProxy, sslPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetSslPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetSslPolicyAsync</summary>
        public async Task SetSslPolicyAsync()
        {
            // Snippet: SetSslPolicyAsync(string, string, SslPolicyReference, CallSettings)
            // Additional: SetSslPolicyAsync(string, string, SslPolicyReference, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            SslPolicyReference sslPolicyReferenceResource = new SslPolicyReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetSslPolicyAsync(project, targetHttpsProxy, sslPolicyReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetSslPolicyAsync(operationName);
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
            // Snippet: SetUrlMap(SetUrlMapTargetHttpsProxyRequest, CallSettings)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetUrlMap(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetUrlMap(operationName);
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
            // Snippet: SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest, CallSettings)
            // Additional: SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest, CancellationToken)
            // Create client
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            SetUrlMapTargetHttpsProxyRequest request = new SetUrlMapTargetHttpsProxyRequest
            {
                RequestId = "",
                TargetHttpsProxy = "",
                Project = "",
                UrlMapReferenceResource = new UrlMapReference(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetUrlMapAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetUrlMapAsync(operationName);
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = TargetHttpsProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = targetHttpsProxiesClient.SetUrlMap(project, targetHttpsProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = targetHttpsProxiesClient.PollOnceSetUrlMap(operationName);
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
            TargetHttpsProxiesClient targetHttpsProxiesClient = await TargetHttpsProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string targetHttpsProxy = "";
            UrlMapReference urlMapReferenceResource = new UrlMapReference();
            // Make the request
            lro::Operation<Operation, Operation> response = await targetHttpsProxiesClient.SetUrlMapAsync(project, targetHttpsProxy, urlMapReferenceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await targetHttpsProxiesClient.PollOnceSetUrlMapAsync(operationName);
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
