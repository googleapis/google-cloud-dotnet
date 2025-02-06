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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionTargetTcpProxiesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionTargetTcpProxyRequest, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            DeleteRegionTargetTcpProxyRequest request = new DeleteRegionTargetTcpProxyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetTcpProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetTcpProxiesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetTcpProxiesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionTargetTcpProxyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionTargetTcpProxyRequest, CancellationToken)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionTargetTcpProxyRequest request = new DeleteRegionTargetTcpProxyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                TargetTcpProxy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetTcpProxiesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetTcpProxiesClient.PollOnceDeleteAsync(operationName);
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
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetTcpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetTcpProxiesClient.Delete(project, region, targetTcpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetTcpProxiesClient.PollOnceDelete(operationName);
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
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetTcpProxy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetTcpProxiesClient.DeleteAsync(project, region, targetTcpProxy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetTcpProxiesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionTargetTcpProxyRequest, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            GetRegionTargetTcpProxyRequest request = new GetRegionTargetTcpProxyRequest
            {
                Region = "",
                Project = "",
                TargetTcpProxy = "",
            };
            // Make the request
            TargetTcpProxy response = regionTargetTcpProxiesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionTargetTcpProxyRequest, CallSettings)
            // Additional: GetAsync(GetRegionTargetTcpProxyRequest, CancellationToken)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionTargetTcpProxyRequest request = new GetRegionTargetTcpProxyRequest
            {
                Region = "",
                Project = "",
                TargetTcpProxy = "",
            };
            // Make the request
            TargetTcpProxy response = await regionTargetTcpProxiesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetTcpProxy = "";
            // Make the request
            TargetTcpProxy response = regionTargetTcpProxiesClient.Get(project, region, targetTcpProxy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string targetTcpProxy = "";
            // Make the request
            TargetTcpProxy response = await regionTargetTcpProxiesClient.GetAsync(project, region, targetTcpProxy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionTargetTcpProxyRequest, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            InsertRegionTargetTcpProxyRequest request = new InsertRegionTargetTcpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetTcpProxyResource = new TargetTcpProxy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetTcpProxiesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetTcpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionTargetTcpProxyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionTargetTcpProxyRequest, CancellationToken)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionTargetTcpProxyRequest request = new InsertRegionTargetTcpProxyRequest
            {
                RequestId = "",
                Region = "",
                TargetTcpProxyResource = new TargetTcpProxy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetTcpProxiesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetTcpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, TargetTcpProxy, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetTcpProxy targetTcpProxyResource = new TargetTcpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionTargetTcpProxiesClient.Insert(project, region, targetTcpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionTargetTcpProxiesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, TargetTcpProxy, CallSettings)
            // Additional: InsertAsync(string, string, TargetTcpProxy, CancellationToken)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            TargetTcpProxy targetTcpProxyResource = new TargetTcpProxy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionTargetTcpProxiesClient.InsertAsync(project, region, targetTcpProxyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionTargetTcpProxiesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionTargetTcpProxiesRequest, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            ListRegionTargetTcpProxiesRequest request = new ListRegionTargetTcpProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<TargetTcpProxyList, TargetTcpProxy> response = regionTargetTcpProxiesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetTcpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetTcpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetTcpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetTcpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetTcpProxy item in singlePage)
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
            // Snippet: ListAsync(ListRegionTargetTcpProxiesRequest, CallSettings)
            // Create client
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionTargetTcpProxiesRequest request = new ListRegionTargetTcpProxiesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<TargetTcpProxyList, TargetTcpProxy> response = regionTargetTcpProxiesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetTcpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetTcpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetTcpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetTcpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetTcpProxy item in singlePage)
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
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = RegionTargetTcpProxiesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<TargetTcpProxyList, TargetTcpProxy> response = regionTargetTcpProxiesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetTcpProxy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (TargetTcpProxyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetTcpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetTcpProxy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetTcpProxy item in singlePage)
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
            RegionTargetTcpProxiesClient regionTargetTcpProxiesClient = await RegionTargetTcpProxiesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<TargetTcpProxyList, TargetTcpProxy> response = regionTargetTcpProxiesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TargetTcpProxy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((TargetTcpProxyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetTcpProxy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetTcpProxy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetTcpProxy item in singlePage)
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
