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
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGlobalOrganizationOperationsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalOrganizationOperationRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = globalOrganizationOperationsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteGlobalOrganizationOperationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalOrganizationOperationRequest, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalOrganizationOperationRequest request = new DeleteGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = await globalOrganizationOperationsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = globalOrganizationOperationsClient.Delete(operation);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, CallSettings)
            // Additional: DeleteAsync(string, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            DeleteGlobalOrganizationOperationResponse response = await globalOrganizationOperationsClient.DeleteAsync(operation);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetGlobalOrganizationOperationRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            Operation response = globalOrganizationOperationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalOrganizationOperationRequest, CallSettings)
            // Additional: GetAsync(GetGlobalOrganizationOperationRequest, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalOrganizationOperationRequest request = new GetGlobalOrganizationOperationRequest
            {
                Operation = "",
                ParentId = "",
            };
            // Make the request
            Operation response = await globalOrganizationOperationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            Operation response = globalOrganizationOperationsClient.Get(operation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string operation = "";
            // Make the request
            Operation response = await globalOrganizationOperationsClient.GetAsync(operation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListGlobalOrganizationOperationsRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Initialize request argument(s)
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<OperationList, Operation> response = globalOrganizationOperationsClient.List(request);

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
            // Snippet: ListAsync(ListGlobalOrganizationOperationsRequest, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalOrganizationOperationsRequest request = new ListGlobalOrganizationOperationsRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = globalOrganizationOperationsClient.ListAsync(request);

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
            // Snippet: List(string, int?, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = GlobalOrganizationOperationsClient.Create();
            // Make the request
            PagedEnumerable<OperationList, Operation> response = globalOrganizationOperationsClient.List();

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
            // Snippet: ListAsync(string, int?, CallSettings)
            // Create client
            GlobalOrganizationOperationsClient globalOrganizationOperationsClient = await GlobalOrganizationOperationsClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<OperationList, Operation> response = globalOrganizationOperationsClient.ListAsync();

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
    }
}
