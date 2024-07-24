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
    public sealed class AllGeneratedGlobalOperationsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            AggregatedListGlobalOperationsRequest request = new AggregatedListGlobalOperationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<OperationAggregatedList, KeyValuePair<string, OperationsScopedList>> response = globalOperationsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, OperationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, OperationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, OperationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, OperationsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListGlobalOperationsRequest request = new AggregatedListGlobalOperationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<OperationAggregatedList, KeyValuePair<string, OperationsScopedList>> response = globalOperationsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, OperationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, OperationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, OperationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, OperationsScopedList> item in singlePage)
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
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<OperationAggregatedList, KeyValuePair<string, OperationsScopedList>> response = globalOperationsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, OperationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, OperationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, OperationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, OperationsScopedList> item in singlePage)
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
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<OperationAggregatedList, KeyValuePair<string, OperationsScopedList>> response = globalOperationsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, OperationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, OperationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, OperationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, OperationsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            DeleteGlobalOperationRequest request = new DeleteGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteGlobalOperationResponse response = globalOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalOperationRequest request = new DeleteGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            DeleteGlobalOperationResponse response = await globalOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            DeleteGlobalOperationResponse response = globalOperationsClient.Delete(project, operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            DeleteGlobalOperationResponse response = await globalOperationsClient.DeleteAsync(project, operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            GetGlobalOperationRequest request = new GetGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = globalOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalOperationRequest, CallSettings)
            // Additional: GetAsync(GetGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalOperationRequest request = new GetGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = globalOperationsClient.Get(project, operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = await globalOperationsClient.GetAsync(project, operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            ListGlobalOperationsRequest request = new ListGlobalOperationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<OperationList, Operation> response = globalOperationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            // Snippet: ListAsync(ListGlobalOperationsRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalOperationsRequest request = new ListGlobalOperationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = globalOperationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<OperationList, Operation> response = globalOperationsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (OperationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = globalOperationsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((OperationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void WaitRequestObject()
        {
            // Snippet: Wait(WaitGlobalOperationRequest, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            WaitGlobalOperationRequest request = new WaitGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = globalOperationsClient.Wait(request);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitRequestObjectAsync()
        {
            // Snippet: WaitAsync(WaitGlobalOperationRequest, CallSettings)
            // Additional: WaitAsync(WaitGlobalOperationRequest, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            WaitGlobalOperationRequest request = new WaitGlobalOperationRequest
            {
                Operation = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalOperationsClient.WaitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Wait</summary>
        public void Wait()
        {
            // Snippet: Wait(string, string, CallSettings)
            // Create client
            GlobalOperationsClient globalOperationsClient = GlobalOperationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = globalOperationsClient.Wait(project, operation);
            // End snippet
        }

        /// <summary>Snippet for WaitAsync</summary>
        public async Task WaitAsync()
        {
            // Snippet: WaitAsync(string, string, CallSettings)
            // Additional: WaitAsync(string, string, CancellationToken)
            // Create client
            GlobalOperationsClient globalOperationsClient = await GlobalOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string operation = "";
            // Make the request
            Operation response = await globalOperationsClient.WaitAsync(project, operation);
            // End snippet
        }
    }
}
