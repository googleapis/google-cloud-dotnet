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
    public sealed class AllGeneratedRegionHealthChecksClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            DeleteRegionHealthCheckRequest request = new DeleteRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionHealthCheckRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionHealthCheckRequest request = new DeleteRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Delete(project, region, healthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceDelete(operationName);
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
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.DeleteAsync(project, region, healthCheck);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "",
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            HealthCheck response = regionHealthChecksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionHealthCheckRequest, CallSettings)
            // Additional: GetAsync(GetRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "",
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            HealthCheck response = await regionHealthChecksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = regionHealthChecksClient.Get(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            // Make the request
            HealthCheck response = await regionHealthChecksClient.GetAsync(project, region, healthCheck);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            InsertRegionHealthCheckRequest request = new InsertRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionHealthCheckRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionHealthCheckRequest request = new InsertRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Insert(project, region, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, HealthCheck, CallSettings)
            // Additional: InsertAsync(string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.InsertAsync(project, region, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionHealthChecksRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            ListRegionHealthChecksRequest request = new ListRegionHealthChecksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<HealthCheckList, HealthCheck> response = regionHealthChecksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheck item in singlePage)
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
            // Snippet: ListAsync(ListRegionHealthChecksRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionHealthChecksRequest request = new ListRegionHealthChecksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<HealthCheckList, HealthCheck> response = regionHealthChecksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheck item in singlePage)
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
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<HealthCheckList, HealthCheck> response = regionHealthChecksClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HealthCheck item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (HealthCheckList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheck> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheck item in singlePage)
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
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<HealthCheckList, HealthCheck> response = regionHealthChecksClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HealthCheck item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((HealthCheckList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HealthCheck item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HealthCheck> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HealthCheck item in singlePage)
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
            // Snippet: Patch(PatchRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            PatchRegionHealthCheckRequest request = new PatchRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionHealthCheckRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionHealthCheckRequest request = new PatchRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Patch(project, region, healthCheck, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, HealthCheck, CallSettings)
            // Additional: PatchAsync(string, string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.PatchAsync(project, region, healthCheck, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOncePatchAsync(operationName);
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
            // Snippet: Update(UpdateRegionHealthCheckRequest, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            UpdateRegionHealthCheckRequest request = new UpdateRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateRegionHealthCheckRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionHealthCheckRequest, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionHealthCheckRequest request = new UpdateRegionHealthCheckRequest
            {
                RequestId = "",
                Region = "",
                HealthCheckResource = new HealthCheck(),
                Project = "",
                HealthCheck = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, HealthCheck, CallSettings)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = RegionHealthChecksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = regionHealthChecksClient.Update(project, region, healthCheck, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionHealthChecksClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, HealthCheck, CallSettings)
            // Additional: UpdateAsync(string, string, string, HealthCheck, CancellationToken)
            // Create client
            RegionHealthChecksClient regionHealthChecksClient = await RegionHealthChecksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string healthCheck = "";
            HealthCheck healthCheckResource = new HealthCheck();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionHealthChecksClient.UpdateAsync(project, region, healthCheck, healthCheckResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionHealthChecksClient.PollOnceUpdateAsync(operationName);
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
