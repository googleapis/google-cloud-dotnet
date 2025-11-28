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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWorkerPoolsClientSnippets
    {
        /// <summary>Snippet for CreateWorkerPool</summary>
        public void CreateWorkerPoolRequestObject()
        {
            // Snippet: CreateWorkerPool(CreateWorkerPoolRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::CreateWorkerPoolRequest request = new gcrv::CreateWorkerPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WorkerPool = new gcrv::WorkerPool(),
                WorkerPoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.CreateWorkerPool(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceCreateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPoolAsync</summary>
        public async Task CreateWorkerPoolRequestObjectAsync()
        {
            // Snippet: CreateWorkerPoolAsync(CreateWorkerPoolRequest, CallSettings)
            // Additional: CreateWorkerPoolAsync(CreateWorkerPoolRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::CreateWorkerPoolRequest request = new gcrv::CreateWorkerPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WorkerPool = new gcrv::WorkerPool(),
                WorkerPoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.CreateWorkerPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceCreateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPool</summary>
        public void CreateWorkerPool()
        {
            // Snippet: CreateWorkerPool(string, WorkerPool, string, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            string workerPoolId = "";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.CreateWorkerPool(parent, workerPool, workerPoolId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceCreateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPoolAsync</summary>
        public async Task CreateWorkerPoolAsync()
        {
            // Snippet: CreateWorkerPoolAsync(string, WorkerPool, string, CallSettings)
            // Additional: CreateWorkerPoolAsync(string, WorkerPool, string, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            string workerPoolId = "";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.CreateWorkerPoolAsync(parent, workerPool, workerPoolId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceCreateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPool</summary>
        public void CreateWorkerPoolResourceNames()
        {
            // Snippet: CreateWorkerPool(LocationName, WorkerPool, string, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            string workerPoolId = "";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.CreateWorkerPool(parent, workerPool, workerPoolId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceCreateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkerPoolAsync</summary>
        public async Task CreateWorkerPoolResourceNamesAsync()
        {
            // Snippet: CreateWorkerPoolAsync(LocationName, WorkerPool, string, CallSettings)
            // Additional: CreateWorkerPoolAsync(LocationName, WorkerPool, string, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            string workerPoolId = "";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.CreateWorkerPoolAsync(parent, workerPool, workerPoolId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceCreateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPool</summary>
        public void GetWorkerPoolRequestObject()
        {
            // Snippet: GetWorkerPool(GetWorkerPoolRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::GetWorkerPoolRequest request = new gcrv::GetWorkerPoolRequest
            {
                WorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
            };
            // Make the request
            gcrv::WorkerPool response = workerPoolsClient.GetWorkerPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPoolAsync</summary>
        public async Task GetWorkerPoolRequestObjectAsync()
        {
            // Snippet: GetWorkerPoolAsync(GetWorkerPoolRequest, CallSettings)
            // Additional: GetWorkerPoolAsync(GetWorkerPoolRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::GetWorkerPoolRequest request = new gcrv::GetWorkerPoolRequest
            {
                WorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
            };
            // Make the request
            gcrv::WorkerPool response = await workerPoolsClient.GetWorkerPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPool</summary>
        public void GetWorkerPool()
        {
            // Snippet: GetWorkerPool(string, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workerPools/[WORKER_POOL]";
            // Make the request
            gcrv::WorkerPool response = workerPoolsClient.GetWorkerPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPoolAsync</summary>
        public async Task GetWorkerPoolAsync()
        {
            // Snippet: GetWorkerPoolAsync(string, CallSettings)
            // Additional: GetWorkerPoolAsync(string, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workerPools/[WORKER_POOL]";
            // Make the request
            gcrv::WorkerPool response = await workerPoolsClient.GetWorkerPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPool</summary>
        public void GetWorkerPoolResourceNames()
        {
            // Snippet: GetWorkerPool(WorkerPoolName, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::WorkerPoolName name = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]");
            // Make the request
            gcrv::WorkerPool response = workerPoolsClient.GetWorkerPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkerPoolAsync</summary>
        public async Task GetWorkerPoolResourceNamesAsync()
        {
            // Snippet: GetWorkerPoolAsync(WorkerPoolName, CallSettings)
            // Additional: GetWorkerPoolAsync(WorkerPoolName, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::WorkerPoolName name = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]");
            // Make the request
            gcrv::WorkerPool response = await workerPoolsClient.GetWorkerPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPools</summary>
        public void ListWorkerPoolsRequestObject()
        {
            // Snippet: ListWorkerPools(ListWorkerPoolsRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::ListWorkerPoolsRequest request = new gcrv::ListWorkerPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::WorkerPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListWorkerPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPoolsAsync</summary>
        public async Task ListWorkerPoolsRequestObjectAsync()
        {
            // Snippet: ListWorkerPoolsAsync(ListWorkerPoolsRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ListWorkerPoolsRequest request = new gcrv::ListWorkerPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::WorkerPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListWorkerPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPools</summary>
        public void ListWorkerPools()
        {
            // Snippet: ListWorkerPools(string, string, int?, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::WorkerPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListWorkerPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPoolsAsync</summary>
        public async Task ListWorkerPoolsAsync()
        {
            // Snippet: ListWorkerPoolsAsync(string, string, int?, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::WorkerPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListWorkerPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPools</summary>
        public void ListWorkerPoolsResourceNames()
        {
            // Snippet: ListWorkerPools(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::WorkerPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListWorkerPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkerPoolsAsync</summary>
        public async Task ListWorkerPoolsResourceNamesAsync()
        {
            // Snippet: ListWorkerPoolsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcrv::ListWorkerPoolsResponse, gcrv::WorkerPool> response = workerPoolsClient.ListWorkerPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::WorkerPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListWorkerPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::WorkerPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::WorkerPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::WorkerPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPool</summary>
        public void UpdateWorkerPoolRequestObject()
        {
            // Snippet: UpdateWorkerPool(UpdateWorkerPoolRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::UpdateWorkerPoolRequest request = new gcrv::UpdateWorkerPoolRequest
            {
                WorkerPool = new gcrv::WorkerPool(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
                ForceNewRevision = false,
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.UpdateWorkerPool(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceUpdateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPoolAsync</summary>
        public async Task UpdateWorkerPoolRequestObjectAsync()
        {
            // Snippet: UpdateWorkerPoolAsync(UpdateWorkerPoolRequest, CallSettings)
            // Additional: UpdateWorkerPoolAsync(UpdateWorkerPoolRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::UpdateWorkerPoolRequest request = new gcrv::UpdateWorkerPoolRequest
            {
                WorkerPool = new gcrv::WorkerPool(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
                ForceNewRevision = false,
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.UpdateWorkerPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceUpdateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPool</summary>
        public void UpdateWorkerPool1()
        {
            // Snippet: UpdateWorkerPool(WorkerPool, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.UpdateWorkerPool(workerPool);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceUpdateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPoolAsync</summary>
        public async Task UpdateWorkerPool1Async()
        {
            // Snippet: UpdateWorkerPoolAsync(WorkerPool, CallSettings)
            // Additional: UpdateWorkerPoolAsync(WorkerPool, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.UpdateWorkerPoolAsync(workerPool);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceUpdateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPool</summary>
        public void UpdateWorkerPool2()
        {
            // Snippet: UpdateWorkerPool(WorkerPool, FieldMask, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.UpdateWorkerPool(workerPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceUpdateWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkerPoolAsync</summary>
        public async Task UpdateWorkerPool2Async()
        {
            // Snippet: UpdateWorkerPoolAsync(WorkerPool, FieldMask, CallSettings)
            // Additional: UpdateWorkerPoolAsync(WorkerPool, FieldMask, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::WorkerPool workerPool = new gcrv::WorkerPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.UpdateWorkerPoolAsync(workerPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceUpdateWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPool</summary>
        public void DeleteWorkerPoolRequestObject()
        {
            // Snippet: DeleteWorkerPool(DeleteWorkerPoolRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::DeleteWorkerPoolRequest request = new gcrv::DeleteWorkerPoolRequest
            {
                WorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.DeleteWorkerPool(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceDeleteWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPoolAsync</summary>
        public async Task DeleteWorkerPoolRequestObjectAsync()
        {
            // Snippet: DeleteWorkerPoolAsync(DeleteWorkerPoolRequest, CallSettings)
            // Additional: DeleteWorkerPoolAsync(DeleteWorkerPoolRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::DeleteWorkerPoolRequest request = new gcrv::DeleteWorkerPoolRequest
            {
                WorkerPoolName = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.DeleteWorkerPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceDeleteWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPool</summary>
        public void DeleteWorkerPool()
        {
            // Snippet: DeleteWorkerPool(string, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workerPools/[WORKER_POOL]";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.DeleteWorkerPool(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceDeleteWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPoolAsync</summary>
        public async Task DeleteWorkerPoolAsync()
        {
            // Snippet: DeleteWorkerPoolAsync(string, CallSettings)
            // Additional: DeleteWorkerPoolAsync(string, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workerPools/[WORKER_POOL]";
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.DeleteWorkerPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceDeleteWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPool</summary>
        public void DeleteWorkerPoolResourceNames()
        {
            // Snippet: DeleteWorkerPool(WorkerPoolName, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            gcrv::WorkerPoolName name = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]");
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = workerPoolsClient.DeleteWorkerPool(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = workerPoolsClient.PollOnceDeleteWorkerPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkerPoolAsync</summary>
        public async Task DeleteWorkerPoolResourceNamesAsync()
        {
            // Snippet: DeleteWorkerPoolAsync(WorkerPoolName, CallSettings)
            // Additional: DeleteWorkerPoolAsync(WorkerPoolName, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::WorkerPoolName name = gcrv::WorkerPoolName.FromProjectLocationWorkerPool("[PROJECT]", "[LOCATION]", "[WORKER_POOL]");
            // Make the request
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> response = await workerPoolsClient.DeleteWorkerPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::WorkerPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::WorkerPool, gcrv::WorkerPool> retrievedResponse = await workerPoolsClient.PollOnceDeleteWorkerPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::WorkerPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = workerPoolsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await workerPoolsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = workerPoolsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await workerPoolsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = gcrv::WorkerPoolsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = workerPoolsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcrv::WorkerPoolsClient workerPoolsClient = await gcrv::WorkerPoolsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await workerPoolsClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
