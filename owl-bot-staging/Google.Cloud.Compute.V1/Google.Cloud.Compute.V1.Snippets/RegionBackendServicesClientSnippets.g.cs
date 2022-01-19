// Copyright 2022 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedRegionBackendServicesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionBackendServiceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionBackendServiceRequest request = new DeleteRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceDeleteAsync(operationName);
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
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Delete(project, region, backendService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceDelete(operationName);
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
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.DeleteAsync(project, region, backendService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendService response = regionBackendServicesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionBackendServiceRequest, CallSettings)
            // Additional: GetAsync(GetRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionBackendServiceRequest request = new GetRegionBackendServiceRequest
            {
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendService response = await regionBackendServicesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            // Make the request
            BackendService response = regionBackendServicesClient.Get(project, region, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            // Make the request
            BackendService response = await regionBackendServicesClient.GetAsync(project, region, backendService);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealthRequestObject()
        {
            // Snippet: GetHealth(GetHealthRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendServiceGroupHealth response = regionBackendServicesClient.GetHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthRequestObjectAsync()
        {
            // Snippet: GetHealthAsync(GetHealthRegionBackendServiceRequest, CallSettings)
            // Additional: GetHealthAsync(GetHealthRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetHealthRegionBackendServiceRequest request = new GetHealthRegionBackendServiceRequest
            {
                ResourceGroupReferenceResource = new ResourceGroupReference(),
                Region = "",
                Project = "",
                BackendService = "",
            };
            // Make the request
            BackendServiceGroupHealth response = await regionBackendServicesClient.GetHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHealth</summary>
        public void GetHealth()
        {
            // Snippet: GetHealth(string, string, string, ResourceGroupReference, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = regionBackendServicesClient.GetHealth(project, region, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for GetHealthAsync</summary>
        public async Task GetHealthAsync()
        {
            // Snippet: GetHealthAsync(string, string, string, ResourceGroupReference, CallSettings)
            // Additional: GetHealthAsync(string, string, string, ResourceGroupReference, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            ResourceGroupReference resourceGroupReferenceResource = new ResourceGroupReference();
            // Make the request
            BackendServiceGroupHealth response = await regionBackendServicesClient.GetHealthAsync(project, region, backendService, resourceGroupReferenceResource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionBackendServiceRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionBackendServiceRequest request = new InsertRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, BackendService, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Insert(project, region, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, BackendService, CallSettings)
            // Additional: InsertAsync(string, string, BackendService, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.InsertAsync(project, region, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionBackendServicesRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<BackendServiceList, BackendService> response = regionBackendServicesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            // Snippet: ListAsync(ListRegionBackendServicesRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionBackendServicesRequest request = new ListRegionBackendServicesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<BackendServiceList, BackendService> response = regionBackendServicesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<BackendServiceList, BackendService> response = regionBackendServicesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackendService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackendServiceList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<BackendServiceList, BackendService> response = regionBackendServicesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackendService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((BackendServiceList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackendService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackendService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackendService item in singlePage)
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
            // Snippet: Patch(PatchRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionBackendServiceRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionBackendServiceRequest request = new PatchRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, BackendService, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Patch(project, region, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, BackendService, CallSettings)
            // Additional: PatchAsync(string, string, string, BackendService, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.PatchAsync(project, region, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRegionBackendServiceRequest, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateRegionBackendServiceRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionBackendServiceRequest, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionBackendServiceRequest request = new UpdateRegionBackendServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BackendService = "",
                BackendServiceResource = new BackendService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, BackendService, CallSettings)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = RegionBackendServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = regionBackendServicesClient.Update(project, region, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionBackendServicesClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, BackendService, CallSettings)
            // Additional: UpdateAsync(string, string, string, BackendService, CancellationToken)
            // Create client
            RegionBackendServicesClient regionBackendServicesClient = await RegionBackendServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string backendService = "";
            BackendService backendServiceResource = new BackendService();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionBackendServicesClient.UpdateAsync(project, region, backendService, backendServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionBackendServicesClient.PollOnceUpdateAsync(operationName);
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
