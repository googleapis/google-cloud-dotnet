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
    public sealed class AllGeneratedVpnGatewaysClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VpnGatewayAggregatedList, KeyValuePair<string, VpnGatewaysScopedList>> response = vpnGatewaysClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnGatewayAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnGatewaysScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnGatewaysScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VpnGatewayAggregatedList, KeyValuePair<string, VpnGatewaysScopedList>> response = vpnGatewaysClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, VpnGatewaysScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnGatewayAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnGatewaysScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnGatewaysScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in singlePage)
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
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<VpnGatewayAggregatedList, KeyValuePair<string, VpnGatewaysScopedList>> response = vpnGatewaysClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnGatewayAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnGatewaysScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnGatewaysScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in singlePage)
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
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<VpnGatewayAggregatedList, KeyValuePair<string, VpnGatewaysScopedList>> response = vpnGatewaysClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, VpnGatewaysScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnGatewayAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnGatewaysScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnGatewaysScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnGatewaysScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteVpnGatewayRequest, CallSettings)
            // Additional: DeleteAsync(DeleteVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.Delete(project, region, vpnGateway);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.DeleteAsync(project, region, vpnGateway);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            VpnGateway response = vpnGatewaysClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetVpnGatewayRequest, CallSettings)
            // Additional: GetAsync(GetVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            VpnGateway response = await vpnGatewaysClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGateway response = vpnGatewaysClient.Get(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGateway response = await vpnGatewaysClient.GetAsync(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatusRequestObject()
        {
            // Snippet: GetStatus(GetStatusVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            VpnGatewaysGetStatusResponse response = vpnGatewaysClient.GetStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusRequestObjectAsync()
        {
            // Snippet: GetStatusAsync(GetStatusVpnGatewayRequest, CallSettings)
            // Additional: GetStatusAsync(GetStatusVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "",
                Project = "",
                VpnGateway = "",
            };
            // Make the request
            VpnGatewaysGetStatusResponse response = await vpnGatewaysClient.GetStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStatus</summary>
        public void GetStatus()
        {
            // Snippet: GetStatus(string, string, string, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGatewaysGetStatusResponse response = vpnGatewaysClient.GetStatus(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for GetStatusAsync</summary>
        public async Task GetStatusAsync()
        {
            // Snippet: GetStatusAsync(string, string, string, CallSettings)
            // Additional: GetStatusAsync(string, string, string, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnGateway = "";
            // Make the request
            VpnGatewaysGetStatusResponse response = await vpnGatewaysClient.GetStatusAsync(project, region, vpnGateway);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                VpnGatewayResource = new VpnGateway(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertVpnGatewayRequest, CallSettings)
            // Additional: InsertAsync(InsertVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                VpnGatewayResource = new VpnGateway(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, VpnGateway, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnGateway vpnGatewayResource = new VpnGateway();
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.Insert(project, region, vpnGatewayResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, VpnGateway, CallSettings)
            // Additional: InsertAsync(string, string, VpnGateway, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnGateway vpnGatewayResource = new VpnGateway();
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.InsertAsync(project, region, vpnGatewayResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VpnGatewayList, VpnGateway> response = vpnGatewaysClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpnGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnGatewayList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnGateway item in singlePage)
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
            // Snippet: ListAsync(ListVpnGatewaysRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VpnGatewayList, VpnGateway> response = vpnGatewaysClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpnGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnGatewayList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnGateway item in singlePage)
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
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<VpnGatewayList, VpnGateway> response = vpnGatewaysClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpnGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnGatewayList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnGateway item in singlePage)
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
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<VpnGatewayList, VpnGateway> response = vpnGatewaysClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpnGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnGatewayList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsVpnGatewayRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = vpnGatewaysClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnGatewaysClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnGatewaysClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnGatewaysClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsVpnGatewayRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = vpnGatewaysClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsVpnGatewayRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsVpnGatewayRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await vpnGatewaysClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = VpnGatewaysClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = vpnGatewaysClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            VpnGatewaysClient vpnGatewaysClient = await VpnGatewaysClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await vpnGatewaysClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
