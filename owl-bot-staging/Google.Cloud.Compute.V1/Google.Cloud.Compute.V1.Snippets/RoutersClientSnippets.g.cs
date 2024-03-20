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
    public sealed class AllGeneratedRoutersClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            AggregatedListRoutersRequest request = new AggregatedListRoutersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RouterAggregatedList, KeyValuePair<string, RoutersScopedList>> response = routersClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, RoutersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RouterAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, RoutersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, RoutersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, RoutersScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListRoutersRequest request = new AggregatedListRoutersRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RouterAggregatedList, KeyValuePair<string, RoutersScopedList>> response = routersClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, RoutersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RouterAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, RoutersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, RoutersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, RoutersScopedList> item in singlePage)
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
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<RouterAggregatedList, KeyValuePair<string, RoutersScopedList>> response = routersClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, RoutersScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RouterAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, RoutersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, RoutersScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, RoutersScopedList> item in singlePage)
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
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<RouterAggregatedList, KeyValuePair<string, RoutersScopedList>> response = routersClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, RoutersScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RouterAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, RoutersScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, RoutersScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, RoutersScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRouterRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceDeleteAsync(operationName);
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
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Delete(project, region, router);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceDelete(operationName);
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
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.DeleteAsync(project, region, router);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Router response = routersClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRouterRequest, CallSettings)
            // Additional: GetAsync(GetRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            Router response = await routersClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Router response = routersClient.Get(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            Router response = await routersClient.GetAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetNatIpInfo</summary>
        public void GetNatIpInfoRequestObject()
        {
            // Snippet: GetNatIpInfo(GetNatIpInfoRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetNatIpInfoRouterRequest request = new GetNatIpInfoRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
                NatName = "",
            };
            // Make the request
            NatIpInfoResponse response = routersClient.GetNatIpInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetNatIpInfoAsync</summary>
        public async Task GetNatIpInfoRequestObjectAsync()
        {
            // Snippet: GetNatIpInfoAsync(GetNatIpInfoRouterRequest, CallSettings)
            // Additional: GetNatIpInfoAsync(GetNatIpInfoRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetNatIpInfoRouterRequest request = new GetNatIpInfoRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
                NatName = "",
            };
            // Make the request
            NatIpInfoResponse response = await routersClient.GetNatIpInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNatIpInfo</summary>
        public void GetNatIpInfo()
        {
            // Snippet: GetNatIpInfo(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            NatIpInfoResponse response = routersClient.GetNatIpInfo(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetNatIpInfoAsync</summary>
        public async Task GetNatIpInfoAsync()
        {
            // Snippet: GetNatIpInfoAsync(string, string, string, CallSettings)
            // Additional: GetNatIpInfoAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            NatIpInfoResponse response = await routersClient.GetNatIpInfoAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfo</summary>
        public void GetNatMappingInfoRequestObject()
        {
            // Snippet: GetNatMappingInfo(GetNatMappingInfoRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetNatMappingInfoRoutersRequest request = new GetNatMappingInfoRoutersRequest
            {
                Region = "",
                Router = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NatName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> response = routersClient.GetNatMappingInfo(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmEndpointNatMappings item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmEndpointNatMappingsList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmEndpointNatMappings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmEndpointNatMappings> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmEndpointNatMappings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfoAsync</summary>
        public async Task GetNatMappingInfoRequestObjectAsync()
        {
            // Snippet: GetNatMappingInfoAsync(GetNatMappingInfoRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetNatMappingInfoRoutersRequest request = new GetNatMappingInfoRoutersRequest
            {
                Region = "",
                Router = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NatName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> response = routersClient.GetNatMappingInfoAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VmEndpointNatMappings item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VmEndpointNatMappingsList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmEndpointNatMappings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmEndpointNatMappings> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmEndpointNatMappings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfo</summary>
        public void GetNatMappingInfo()
        {
            // Snippet: GetNatMappingInfo(string, string, string, string, int?, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            PagedEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> response = routersClient.GetNatMappingInfo(project, region, router);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VmEndpointNatMappings item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmEndpointNatMappingsList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmEndpointNatMappings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmEndpointNatMappings> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmEndpointNatMappings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNatMappingInfoAsync</summary>
        public async Task GetNatMappingInfoAsync()
        {
            // Snippet: GetNatMappingInfoAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            PagedAsyncEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> response = routersClient.GetNatMappingInfoAsync(project, region, router);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VmEndpointNatMappings item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((VmEndpointNatMappingsList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VmEndpointNatMappings item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VmEndpointNatMappings> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VmEndpointNatMappings item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatus</summary>
        public void GetRouterStatusRequestObject()
        {
            // Snippet: GetRouterStatus(GetRouterStatusRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            RouterStatusResponse response = routersClient.GetRouterStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatusAsync</summary>
        public async Task GetRouterStatusRequestObjectAsync()
        {
            // Snippet: GetRouterStatusAsync(GetRouterStatusRouterRequest, CallSettings)
            // Additional: GetRouterStatusAsync(GetRouterStatusRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            GetRouterStatusRouterRequest request = new GetRouterStatusRouterRequest
            {
                Region = "",
                Router = "",
                Project = "",
            };
            // Make the request
            RouterStatusResponse response = await routersClient.GetRouterStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatus</summary>
        public void GetRouterStatus()
        {
            // Snippet: GetRouterStatus(string, string, string, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            RouterStatusResponse response = routersClient.GetRouterStatus(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for GetRouterStatusAsync</summary>
        public async Task GetRouterStatusAsync()
        {
            // Snippet: GetRouterStatusAsync(string, string, string, CallSettings)
            // Additional: GetRouterStatusAsync(string, string, string, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            // Make the request
            RouterStatusResponse response = await routersClient.GetRouterStatusAsync(project, region, router);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "",
                Region = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRouterRequest, CallSettings)
            // Additional: InsertAsync(InsertRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            InsertRouterRequest request = new InsertRouterRequest
            {
                RequestId = "",
                Region = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Insert(project, region, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Router, CallSettings)
            // Additional: InsertAsync(string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.InsertAsync(project, region, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RouterList, Router> response = routersClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Router item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RouterList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
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
            // Snippet: ListAsync(ListRoutersRequest, CallSettings)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RouterList, Router> response = routersClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Router item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RouterList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
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
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<RouterList, Router> response = routersClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Router item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RouterList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
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
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<RouterList, Router> response = routersClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Router item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RouterList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
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
            // Snippet: Patch(PatchRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRouterRequest, CallSettings)
            // Additional: PatchAsync(PatchRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            PatchRouterRequest request = new PatchRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Patch(project, region, router, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, Router, CallSettings)
            // Additional: PatchAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.PatchAsync(project, region, router, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Preview</summary>
        public void PreviewRequestObject()
        {
            // Snippet: Preview(PreviewRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            RoutersPreviewResponse response = routersClient.Preview(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewAsync</summary>
        public async Task PreviewRequestObjectAsync()
        {
            // Snippet: PreviewAsync(PreviewRouterRequest, CallSettings)
            // Additional: PreviewAsync(PreviewRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            PreviewRouterRequest request = new PreviewRouterRequest
            {
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            RoutersPreviewResponse response = await routersClient.PreviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Preview</summary>
        public void Preview()
        {
            // Snippet: Preview(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            RoutersPreviewResponse response = routersClient.Preview(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for PreviewAsync</summary>
        public async Task PreviewAsync()
        {
            // Snippet: PreviewAsync(string, string, string, Router, CallSettings)
            // Additional: PreviewAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            RoutersPreviewResponse response = await routersClient.PreviewAsync(project, region, router, routerResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRouterRequest, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateRouterRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRouterRequest, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                RequestId = "",
                Region = "",
                Router = "",
                RouterResource = new Router(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, Router, CallSettings)
            // Create client
            RoutersClient routersClient = RoutersClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = routersClient.Update(project, region, router, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = routersClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, Router, CallSettings)
            // Additional: UpdateAsync(string, string, string, Router, CancellationToken)
            // Create client
            RoutersClient routersClient = await RoutersClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string router = "";
            Router routerResource = new Router();
            // Make the request
            lro::Operation<Operation, Operation> response = await routersClient.UpdateAsync(project, region, router, routerResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await routersClient.PollOnceUpdateAsync(operationName);
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
