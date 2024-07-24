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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionHealthCheckServicesClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionHealthCheckServiceRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionHealthCheckServiceRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionHealthCheckServiceRequest, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionHealthCheckServiceRequest request = new DeleteRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckService = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOnceDeleteAsync(operationName);
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
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Delete(project, region, healthCheckService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOnceDelete(operationName);
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
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.DeleteAsync(project, region, healthCheckService);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionHealthCheckServiceRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "",
                Project = "",
                HealthCheckService = "",
            };
            // Make the request
            HealthCheckService response = regionHealthCheckServicesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionHealthCheckServiceRequest, CallSettings)
            // Additional: GetAsync(GetRegionHealthCheckServiceRequest, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionHealthCheckServiceRequest request = new GetRegionHealthCheckServiceRequest
            {
                Region = "",
                Project = "",
                HealthCheckService = "",
            };
            // Make the request
            HealthCheckService response = await regionHealthCheckServicesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            // Make the request
            HealthCheckService response = regionHealthCheckServicesClient.Get(project, region, healthCheckService);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            // Make the request
            HealthCheckService response = await regionHealthCheckServicesClient.GetAsync(project, region, healthCheckService);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionHealthCheckServiceRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckServiceResource = new HealthCheckService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionHealthCheckServiceRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionHealthCheckServiceRequest, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionHealthCheckServiceRequest request = new InsertRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckServiceResource = new HealthCheckService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, HealthCheckService, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheckService healthCheckServiceResource = new HealthCheckService();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Insert(project, region, healthCheckServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, HealthCheckService, CallSettings)
            // Additional: InsertAsync(string, string, HealthCheckService, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheckService healthCheckServiceResource = new HealthCheckService();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.InsertAsync(project, region, healthCheckServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionHealthCheckServicesRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HealthCheckServicesList, HealthCheckService> response = regionHealthCheckServicesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthCheckService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthCheckServicesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheckService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheckService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheckService item in singlePage)
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
            // Snippet: ListAsync(ListRegionHealthCheckServicesRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionHealthCheckServicesRequest request = new ListRegionHealthCheckServicesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HealthCheckServicesList, HealthCheckService> response = regionHealthCheckServicesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HealthCheckService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HealthCheckServicesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheckService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheckService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheckService item in singlePage)
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
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<HealthCheckServicesList, HealthCheckService> response = regionHealthCheckServicesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthCheckService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthCheckServicesList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheckService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheckService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheckService item in singlePage)
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
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<HealthCheckServicesList, HealthCheckService> response = regionHealthCheckServicesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HealthCheckService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HealthCheckServicesList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheckService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheckService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheckService item in singlePage)
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
            // Snippet: Patch(PatchRegionHealthCheckServiceRequest, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckService = "",
                HealthCheckServiceResource = new HealthCheckService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionHealthCheckServiceRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionHealthCheckServiceRequest, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionHealthCheckServiceRequest request = new PatchRegionHealthCheckServiceRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheckService = "",
                HealthCheckServiceResource = new HealthCheckService(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, HealthCheckService, CallSettings)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = RegionHealthCheckServicesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            HealthCheckService healthCheckServiceResource = new HealthCheckService();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthCheckServicesClient.Patch(project, region, healthCheckService, healthCheckServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthCheckServicesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, HealthCheckService, CallSettings)
            // Additional: PatchAsync(string, string, string, HealthCheckService, CancellationToken)
            // Create client
            RegionHealthCheckServicesClient regionHealthCheckServicesClient = await RegionHealthCheckServicesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheckService = "";
            HealthCheckService healthCheckServiceResource = new HealthCheckService();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthCheckServicesClient.PatchAsync(project, region, healthCheckService, healthCheckServiceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthCheckServicesClient.PollOncePatchAsync(operationName);
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
