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
    public sealed class AllGeneratedVpnTunnelsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            AggregatedListVpnTunnelsRequest request = new AggregatedListVpnTunnelsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VpnTunnelAggregatedList, KeyValuePair<string, VpnTunnelsScopedList>> response = vpnTunnelsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnTunnelAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnTunnelsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnTunnelsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListVpnTunnelsRequest request = new AggregatedListVpnTunnelsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VpnTunnelAggregatedList, KeyValuePair<string, VpnTunnelsScopedList>> response = vpnTunnelsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, VpnTunnelsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnTunnelAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnTunnelsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnTunnelsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in singlePage)
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
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<VpnTunnelAggregatedList, KeyValuePair<string, VpnTunnelsScopedList>> response = vpnTunnelsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnTunnelAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnTunnelsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnTunnelsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in singlePage)
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
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<VpnTunnelAggregatedList, KeyValuePair<string, VpnTunnelsScopedList>> response = vpnTunnelsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, VpnTunnelsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnTunnelAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VpnTunnelsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VpnTunnelsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VpnTunnelsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteVpnTunnelRequest, CallSettings)
            // Additional: DeleteAsync(DeleteVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceDeleteAsync(operationName);
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
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.Delete(project, region, vpnTunnel);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceDelete(operationName);
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
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.DeleteAsync(project, region, vpnTunnel);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            VpnTunnel response = vpnTunnelsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetVpnTunnelRequest, CallSettings)
            // Additional: GetAsync(GetVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "",
                VpnTunnel = "",
                Project = "",
            };
            // Make the request
            VpnTunnel response = await vpnTunnelsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            VpnTunnel response = vpnTunnelsClient.Get(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string vpnTunnel = "";
            // Make the request
            VpnTunnel response = await vpnTunnelsClient.GetAsync(project, region, vpnTunnel);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "",
                VpnTunnelResource = new VpnTunnel(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertVpnTunnelRequest, CallSettings)
            // Additional: InsertAsync(InsertVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "",
                VpnTunnelResource = new VpnTunnel(),
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, VpnTunnel, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnTunnel vpnTunnelResource = new VpnTunnel();
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.Insert(project, region, vpnTunnelResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, VpnTunnel, CallSettings)
            // Additional: InsertAsync(string, string, VpnTunnel, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            VpnTunnel vpnTunnelResource = new VpnTunnel();
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.InsertAsync(project, region, vpnTunnelResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            ListVpnTunnelsRequest request = new ListVpnTunnelsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VpnTunnelList, VpnTunnel> response = vpnTunnelsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpnTunnel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnTunnelList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnTunnel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnTunnel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnTunnel item in singlePage)
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
            // Snippet: ListAsync(ListVpnTunnelsRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            ListVpnTunnelsRequest request = new ListVpnTunnelsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VpnTunnelList, VpnTunnel> response = vpnTunnelsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpnTunnel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnTunnelList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnTunnel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnTunnel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnTunnel item in singlePage)
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
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<VpnTunnelList, VpnTunnel> response = vpnTunnelsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpnTunnel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VpnTunnelList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnTunnel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnTunnel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnTunnel item in singlePage)
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
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<VpnTunnelList, VpnTunnel> response = vpnTunnelsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpnTunnel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VpnTunnelList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpnTunnel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpnTunnel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpnTunnel item in singlePage)
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
            // Snippet: SetLabels(SetLabelsVpnTunnelRequest, CallSettings)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            SetLabelsVpnTunnelRequest request = new SetLabelsVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsVpnTunnelRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsVpnTunnelRequest, CancellationToken)
            // Create client
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsVpnTunnelRequest request = new SetLabelsVpnTunnelRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceSetLabelsAsync(operationName);
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
            VpnTunnelsClient vpnTunnelsClient = VpnTunnelsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = vpnTunnelsClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = vpnTunnelsClient.PollOnceSetLabels(operationName);
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
            VpnTunnelsClient vpnTunnelsClient = await VpnTunnelsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await vpnTunnelsClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await vpnTunnelsClient.PollOnceSetLabelsAsync(operationName);
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
