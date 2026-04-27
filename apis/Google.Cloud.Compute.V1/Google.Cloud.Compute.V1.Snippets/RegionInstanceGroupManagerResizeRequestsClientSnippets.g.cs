// Copyright 2026 Google LLC
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
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstanceGroupManagerResizeRequestsClientSnippets
    {
        /// <summary>Snippet for Cancel</summary>
        public void CancelRequestObject()
        {
            // Snippet: Cancel(CancelRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            CancelRegionInstanceGroupManagerResizeRequestRequest request = new CancelRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Cancel(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelRequestObjectAsync()
        {
            // Snippet: CancelAsync(CancelRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Additional: CancelAsync(CancelRegionInstanceGroupManagerResizeRequestRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            CancelRegionInstanceGroupManagerResizeRequestRequest request = new CancelRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.CancelAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceCancelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Cancel</summary>
        public void Cancel()
        {
            // Snippet: Cancel(string, string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Cancel(project, region, instanceGroupManager, resizeRequest);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelAsync()
        {
            // Snippet: CancelAsync(string, string, string, string, CallSettings)
            // Additional: CancelAsync(string, string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.CancelAsync(project, region, instanceGroupManager, resizeRequest);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceCancelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerResizeRequestRequest request = new DeleteRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstanceGroupManagerResizeRequestRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstanceGroupManagerResizeRequestRequest request = new DeleteRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Delete(project, region, instanceGroupManager, resizeRequest);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.DeleteAsync(project, region, instanceGroupManager, resizeRequest);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerResizeRequestRequest request = new GetRegionInstanceGroupManagerResizeRequestRequest
            {
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagerResizeRequest response = regionInstanceGroupManagerResizeRequestsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceGroupManagerResizeRequestRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceGroupManagerResizeRequestRequest request = new GetRegionInstanceGroupManagerResizeRequestRequest
            {
                Region = "",
                ResizeRequest = "",
                Project = "",
                InstanceGroupManager = "",
            };
            // Make the request
            InstanceGroupManagerResizeRequest response = await regionInstanceGroupManagerResizeRequestsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            InstanceGroupManagerResizeRequest response = regionInstanceGroupManagerResizeRequestsClient.Get(project, region, instanceGroupManager, resizeRequest);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            string resizeRequest = "";
            // Make the request
            InstanceGroupManagerResizeRequest response = await regionInstanceGroupManagerResizeRequestsClient.GetAsync(project, region, instanceGroupManager, resizeRequest);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerResizeRequestRequest request = new InsertRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResizeRequestResource = new InstanceGroupManagerResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionInstanceGroupManagerResizeRequestRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstanceGroupManagerResizeRequestRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstanceGroupManagerResizeRequestRequest request = new InsertRegionInstanceGroupManagerResizeRequestRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstanceGroupManager = "",
                InstanceGroupManagerResizeRequestResource = new InstanceGroupManagerResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, string, InstanceGroupManagerResizeRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource = new InstanceGroupManagerResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstanceGroupManagerResizeRequestsClient.Insert(project, region, instanceGroupManager, instanceGroupManagerResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstanceGroupManagerResizeRequestsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, string, InstanceGroupManagerResizeRequest, CallSettings)
            // Additional: InsertAsync(string, string, string, InstanceGroupManagerResizeRequest, CancellationToken)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            InstanceGroupManagerResizeRequest instanceGroupManagerResizeRequestResource = new InstanceGroupManagerResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstanceGroupManagerResizeRequestsClient.InsertAsync(project, region, instanceGroupManager, instanceGroupManagerResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstanceGroupManagerResizeRequestsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionInstanceGroupManagerResizeRequestsRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagerResizeRequestsRequest request = new ListRegionInstanceGroupManagerResizeRequestsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> response = regionInstanceGroupManagerResizeRequestsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManagerResizeRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagerResizeRequestsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManagerResizeRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManagerResizeRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManagerResizeRequest item in singlePage)
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
            // Snippet: ListAsync(ListRegionInstanceGroupManagerResizeRequestsRequest, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceGroupManagerResizeRequestsRequest request = new ListRegionInstanceGroupManagerResizeRequestsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                InstanceGroupManager = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> response = regionInstanceGroupManagerResizeRequestsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InstanceGroupManagerResizeRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RegionInstanceGroupManagerResizeRequestsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManagerResizeRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManagerResizeRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManagerResizeRequest item in singlePage)
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
            // Snippet: List(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = RegionInstanceGroupManagerResizeRequestsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> response = regionInstanceGroupManagerResizeRequestsClient.List(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroupManagerResizeRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionInstanceGroupManagerResizeRequestsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManagerResizeRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManagerResizeRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManagerResizeRequest item in singlePage)
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
            // Snippet: ListAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RegionInstanceGroupManagerResizeRequestsClient regionInstanceGroupManagerResizeRequestsClient = await RegionInstanceGroupManagerResizeRequestsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroupManager = "";
            // Make the request
            PagedAsyncEnumerable<RegionInstanceGroupManagerResizeRequestsListResponse, InstanceGroupManagerResizeRequest> response = regionInstanceGroupManagerResizeRequestsClient.ListAsync(project, region, instanceGroupManager);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InstanceGroupManagerResizeRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (RegionInstanceGroupManagerResizeRequestsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroupManagerResizeRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroupManagerResizeRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroupManagerResizeRequest item in singlePage)
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
