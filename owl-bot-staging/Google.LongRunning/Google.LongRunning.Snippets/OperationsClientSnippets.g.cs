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
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOperationsClientSnippets
    {
        /// <summary>Snippet for ListOperations</summary>
        public void ListOperationsRequestObject()
        {
            // Snippet: ListOperations(ListOperationsRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Filter = "", Name = "", };
            // Make the request
            PagedEnumerable<ListOperationsResponse, Operation> response = operationsClient.ListOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperationsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsRequestObjectAsync()
        {
            // Snippet: ListOperationsAsync(ListOperationsRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListOperationsRequest request = new ListOperationsRequest { Filter = "", Name = "", };
            // Make the request
            PagedAsyncEnumerable<ListOperationsResponse, Operation> response = operationsClient.ListOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperationsResponse page) =>
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

        /// <summary>Snippet for ListOperations</summary>
        public void ListOperations()
        {
            // Snippet: ListOperations(string, string, string, int?, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            string filter = "";
            // Make the request
            PagedEnumerable<ListOperationsResponse, Operation> response = operationsClient.ListOperations(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperationsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListOperationsAsync</summary>
        public async Task ListOperationsAsync()
        {
            // Snippet: ListOperationsAsync(string, string, string, int?, CallSettings)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListOperationsResponse, Operation> response = operationsClient.ListOperationsAsync(name, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperationsResponse page) =>
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

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperationRequestObject()
        {
            // Snippet: GetOperation(GetOperationRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = operationsClient.GetOperation(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationRequestObjectAsync()
        {
            // Snippet: GetOperationAsync(GetOperationRequest, CallSettings)
            // Additional: GetOperationAsync(GetOperationRequest, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationRequest request = new GetOperationRequest { Name = "", };
            // Make the request
            Operation response = await operationsClient.GetOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperation</summary>
        public void GetOperation()
        {
            // Snippet: GetOperation(string, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = operationsClient.GetOperation(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperationAsync</summary>
        public async Task GetOperationAsync()
        {
            // Snippet: GetOperationAsync(string, CallSettings)
            // Additional: GetOperationAsync(string, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation response = await operationsClient.GetOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOperation</summary>
        public void DeleteOperationRequestObject()
        {
            // Snippet: DeleteOperation(DeleteOperationRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            DeleteOperationRequest request = new DeleteOperationRequest { Name = "", };
            // Make the request
            operationsClient.DeleteOperation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOperationAsync</summary>
        public async Task DeleteOperationRequestObjectAsync()
        {
            // Snippet: DeleteOperationAsync(DeleteOperationRequest, CallSettings)
            // Additional: DeleteOperationAsync(DeleteOperationRequest, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOperationRequest request = new DeleteOperationRequest { Name = "", };
            // Make the request
            await operationsClient.DeleteOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOperation</summary>
        public void DeleteOperation()
        {
            // Snippet: DeleteOperation(string, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            operationsClient.DeleteOperation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOperationAsync</summary>
        public async Task DeleteOperationAsync()
        {
            // Snippet: DeleteOperationAsync(string, CallSettings)
            // Additional: DeleteOperationAsync(string, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await operationsClient.DeleteOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperationRequestObject()
        {
            // Snippet: CancelOperation(CancelOperationRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            operationsClient.CancelOperation(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationRequestObjectAsync()
        {
            // Snippet: CancelOperationAsync(CancelOperationRequest, CallSettings)
            // Additional: CancelOperationAsync(CancelOperationRequest, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            CancelOperationRequest request = new CancelOperationRequest { Name = "", };
            // Make the request
            await operationsClient.CancelOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelOperation</summary>
        public void CancelOperation()
        {
            // Snippet: CancelOperation(string, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            operationsClient.CancelOperation(name);
            // End snippet
        }

        /// <summary>Snippet for CancelOperationAsync</summary>
        public async Task CancelOperationAsync()
        {
            // Snippet: CancelOperationAsync(string, CallSettings)
            // Additional: CancelOperationAsync(string, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await operationsClient.CancelOperationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for WaitOperation</summary>
        public void WaitOperationRequestObject()
        {
            // Snippet: WaitOperation(WaitOperationRequest, CallSettings)
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            WaitOperationRequest request = new WaitOperationRequest
            {
                Name = "",
                Timeout = new Duration(),
            };
            // Make the request
            Operation response = operationsClient.WaitOperation(request);
            // End snippet
        }

        /// <summary>Snippet for WaitOperationAsync</summary>
        public async Task WaitOperationRequestObjectAsync()
        {
            // Snippet: WaitOperationAsync(WaitOperationRequest, CallSettings)
            // Additional: WaitOperationAsync(WaitOperationRequest, CancellationToken)
            // Create client
            OperationsClient operationsClient = await OperationsClient.CreateAsync();
            // Initialize request argument(s)
            WaitOperationRequest request = new WaitOperationRequest
            {
                Name = "",
                Timeout = new Duration(),
            };
            // Make the request
            Operation response = await operationsClient.WaitOperationAsync(request);
            // End snippet
        }
    }
}
