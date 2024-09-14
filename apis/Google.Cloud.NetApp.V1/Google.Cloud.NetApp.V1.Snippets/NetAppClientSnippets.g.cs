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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetApp.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetAppClientSnippets
    {
        /// <summary>Snippet for ListStoragePools</summary>
        public void ListStoragePoolsRequestObject()
        {
            // Snippet: ListStoragePools(ListStoragePoolsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStoragePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoragePoolsAsync</summary>
        public async Task ListStoragePoolsRequestObjectAsync()
        {
            // Snippet: ListStoragePoolsAsync(ListStoragePoolsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStoragePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoragePools</summary>
        public void ListStoragePools()
        {
            // Snippet: ListStoragePools(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStoragePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoragePoolsAsync</summary>
        public async Task ListStoragePoolsAsync()
        {
            // Snippet: ListStoragePoolsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStoragePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoragePools</summary>
        public void ListStoragePoolsResourceNames()
        {
            // Snippet: ListStoragePools(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStoragePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStoragePoolsAsync</summary>
        public async Task ListStoragePoolsResourceNamesAsync()
        {
            // Snippet: ListStoragePoolsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListStoragePoolsResponse, StoragePool> response = netAppClient.ListStoragePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStoragePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePool</summary>
        public void CreateStoragePoolRequestObject()
        {
            // Snippet: CreateStoragePool(CreateStoragePoolRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateStoragePoolRequest request = new CreateStoragePoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                StoragePoolId = "",
                StoragePool = new StoragePool(),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.CreateStoragePool(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePoolAsync</summary>
        public async Task CreateStoragePoolRequestObjectAsync()
        {
            // Snippet: CreateStoragePoolAsync(CreateStoragePoolRequest, CallSettings)
            // Additional: CreateStoragePoolAsync(CreateStoragePoolRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateStoragePoolRequest request = new CreateStoragePoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                StoragePoolId = "",
                StoragePool = new StoragePool(),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.CreateStoragePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePool</summary>
        public void CreateStoragePool()
        {
            // Snippet: CreateStoragePool(string, StoragePool, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            StoragePool storagePool = new StoragePool();
            string storagePoolId = "";
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.CreateStoragePool(parent, storagePool, storagePoolId);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePoolAsync</summary>
        public async Task CreateStoragePoolAsync()
        {
            // Snippet: CreateStoragePoolAsync(string, StoragePool, string, CallSettings)
            // Additional: CreateStoragePoolAsync(string, StoragePool, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            StoragePool storagePool = new StoragePool();
            string storagePoolId = "";
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.CreateStoragePoolAsync(parent, storagePool, storagePoolId);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePool</summary>
        public void CreateStoragePoolResourceNames()
        {
            // Snippet: CreateStoragePool(LocationName, StoragePool, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            StoragePool storagePool = new StoragePool();
            string storagePoolId = "";
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.CreateStoragePool(parent, storagePool, storagePoolId);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStoragePoolAsync</summary>
        public async Task CreateStoragePoolResourceNamesAsync()
        {
            // Snippet: CreateStoragePoolAsync(LocationName, StoragePool, string, CallSettings)
            // Additional: CreateStoragePoolAsync(LocationName, StoragePool, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            StoragePool storagePool = new StoragePool();
            string storagePoolId = "";
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.CreateStoragePoolAsync(parent, storagePool, storagePoolId);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStoragePool</summary>
        public void GetStoragePoolRequestObject()
        {
            // Snippet: GetStoragePool(GetStoragePoolRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetStoragePoolRequest request = new GetStoragePoolRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            StoragePool response = netAppClient.GetStoragePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoragePoolAsync</summary>
        public async Task GetStoragePoolRequestObjectAsync()
        {
            // Snippet: GetStoragePoolAsync(GetStoragePoolRequest, CallSettings)
            // Additional: GetStoragePoolAsync(GetStoragePoolRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetStoragePoolRequest request = new GetStoragePoolRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            StoragePool response = await netAppClient.GetStoragePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStoragePool</summary>
        public void GetStoragePool()
        {
            // Snippet: GetStoragePool(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/storagePools/[STORAGE_POOL]";
            // Make the request
            StoragePool response = netAppClient.GetStoragePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoragePoolAsync</summary>
        public async Task GetStoragePoolAsync()
        {
            // Snippet: GetStoragePoolAsync(string, CallSettings)
            // Additional: GetStoragePoolAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/storagePools/[STORAGE_POOL]";
            // Make the request
            StoragePool response = await netAppClient.GetStoragePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoragePool</summary>
        public void GetStoragePoolResourceNames()
        {
            // Snippet: GetStoragePool(StoragePoolName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            StoragePoolName name = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]");
            // Make the request
            StoragePool response = netAppClient.GetStoragePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetStoragePoolAsync</summary>
        public async Task GetStoragePoolResourceNamesAsync()
        {
            // Snippet: GetStoragePoolAsync(StoragePoolName, CallSettings)
            // Additional: GetStoragePoolAsync(StoragePoolName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            StoragePoolName name = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]");
            // Make the request
            StoragePool response = await netAppClient.GetStoragePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateStoragePool</summary>
        public void UpdateStoragePoolRequestObject()
        {
            // Snippet: UpdateStoragePool(UpdateStoragePoolRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateStoragePoolRequest request = new UpdateStoragePoolRequest
            {
                UpdateMask = new FieldMask(),
                StoragePool = new StoragePool(),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.UpdateStoragePool(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStoragePoolAsync</summary>
        public async Task UpdateStoragePoolRequestObjectAsync()
        {
            // Snippet: UpdateStoragePoolAsync(UpdateStoragePoolRequest, CallSettings)
            // Additional: UpdateStoragePoolAsync(UpdateStoragePoolRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStoragePoolRequest request = new UpdateStoragePoolRequest
            {
                UpdateMask = new FieldMask(),
                StoragePool = new StoragePool(),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.UpdateStoragePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStoragePool</summary>
        public void UpdateStoragePool()
        {
            // Snippet: UpdateStoragePool(StoragePool, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            StoragePool storagePool = new StoragePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.UpdateStoragePool(storagePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStoragePoolAsync</summary>
        public async Task UpdateStoragePoolAsync()
        {
            // Snippet: UpdateStoragePoolAsync(StoragePool, FieldMask, CallSettings)
            // Additional: UpdateStoragePoolAsync(StoragePool, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            StoragePool storagePool = new StoragePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.UpdateStoragePoolAsync(storagePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePool</summary>
        public void DeleteStoragePoolRequestObject()
        {
            // Snippet: DeleteStoragePool(DeleteStoragePoolRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteStoragePoolRequest request = new DeleteStoragePoolRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteStoragePool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePoolAsync</summary>
        public async Task DeleteStoragePoolRequestObjectAsync()
        {
            // Snippet: DeleteStoragePoolAsync(DeleteStoragePoolRequest, CallSettings)
            // Additional: DeleteStoragePoolAsync(DeleteStoragePoolRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStoragePoolRequest request = new DeleteStoragePoolRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteStoragePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePool</summary>
        public void DeleteStoragePool()
        {
            // Snippet: DeleteStoragePool(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/storagePools/[STORAGE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteStoragePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePoolAsync</summary>
        public async Task DeleteStoragePoolAsync()
        {
            // Snippet: DeleteStoragePoolAsync(string, CallSettings)
            // Additional: DeleteStoragePoolAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/storagePools/[STORAGE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteStoragePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePool</summary>
        public void DeleteStoragePoolResourceNames()
        {
            // Snippet: DeleteStoragePool(StoragePoolName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            StoragePoolName name = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteStoragePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteStoragePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStoragePoolAsync</summary>
        public async Task DeleteStoragePoolResourceNamesAsync()
        {
            // Snippet: DeleteStoragePoolAsync(StoragePoolName, CallSettings)
            // Additional: DeleteStoragePoolAsync(StoragePoolName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            StoragePoolName name = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteStoragePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteStoragePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchActiveReplicaZone</summary>
        public void SwitchActiveReplicaZoneRequestObject()
        {
            // Snippet: SwitchActiveReplicaZone(SwitchActiveReplicaZoneRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            SwitchActiveReplicaZoneRequest request = new SwitchActiveReplicaZoneRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = netAppClient.SwitchActiveReplicaZone(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = netAppClient.PollOnceSwitchActiveReplicaZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchActiveReplicaZoneAsync</summary>
        public async Task SwitchActiveReplicaZoneRequestObjectAsync()
        {
            // Snippet: SwitchActiveReplicaZoneAsync(SwitchActiveReplicaZoneRequest, CallSettings)
            // Additional: SwitchActiveReplicaZoneAsync(SwitchActiveReplicaZoneRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            SwitchActiveReplicaZoneRequest request = new SwitchActiveReplicaZoneRequest
            {
                StoragePoolName = StoragePoolName.FromProjectLocationStoragePool("[PROJECT]", "[LOCATION]", "[STORAGE_POOL]"),
            };
            // Make the request
            Operation<StoragePool, OperationMetadata> response = await netAppClient.SwitchActiveReplicaZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StoragePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StoragePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StoragePool, OperationMetadata> retrievedResponse = await netAppClient.PollOnceSwitchActiveReplicaZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StoragePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumesRequestObject()
        {
            // Snippet: ListVolumes(ListVolumesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesRequestObjectAsync()
        {
            // Snippet: ListVolumesAsync(ListVolumesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumes()
        {
            // Snippet: ListVolumes(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesAsync()
        {
            // Snippet: ListVolumesAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumesResourceNames()
        {
            // Snippet: ListVolumes(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Volume item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumesAsync</summary>
        public async Task ListVolumesResourceNamesAsync()
        {
            // Snippet: ListVolumesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = netAppClient.ListVolumesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Volume item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Volume item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Volume> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Volume item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolumeRequestObject()
        {
            // Snippet: GetVolume(GetVolumeRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = netAppClient.GetVolume(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeRequestObjectAsync()
        {
            // Snippet: GetVolumeAsync(GetVolumeRequest, CallSettings)
            // Additional: GetVolumeAsync(GetVolumeRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = await netAppClient.GetVolumeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolume()
        {
            // Snippet: GetVolume(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = netAppClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeAsync()
        {
            // Snippet: GetVolumeAsync(string, CallSettings)
            // Additional: GetVolumeAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = await netAppClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolumeResourceNames()
        {
            // Snippet: GetVolume(VolumeName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = netAppClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeResourceNamesAsync()
        {
            // Snippet: GetVolumeAsync(VolumeName, CallSettings)
            // Additional: GetVolumeAsync(VolumeName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = await netAppClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVolume</summary>
        public void CreateVolumeRequestObject()
        {
            // Snippet: CreateVolume(CreateVolumeRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateVolumeRequest request = new CreateVolumeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VolumeId = "",
                Volume = new Volume(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.CreateVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeAsync</summary>
        public async Task CreateVolumeRequestObjectAsync()
        {
            // Snippet: CreateVolumeAsync(CreateVolumeRequest, CallSettings)
            // Additional: CreateVolumeAsync(CreateVolumeRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateVolumeRequest request = new CreateVolumeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VolumeId = "",
                Volume = new Volume(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.CreateVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolume</summary>
        public void CreateVolume()
        {
            // Snippet: CreateVolume(string, Volume, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Volume volume = new Volume();
            string volumeId = "";
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.CreateVolume(parent, volume, volumeId);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeAsync</summary>
        public async Task CreateVolumeAsync()
        {
            // Snippet: CreateVolumeAsync(string, Volume, string, CallSettings)
            // Additional: CreateVolumeAsync(string, Volume, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Volume volume = new Volume();
            string volumeId = "";
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.CreateVolumeAsync(parent, volume, volumeId);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolume</summary>
        public void CreateVolumeResourceNames()
        {
            // Snippet: CreateVolume(LocationName, Volume, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Volume volume = new Volume();
            string volumeId = "";
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.CreateVolume(parent, volume, volumeId);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeAsync</summary>
        public async Task CreateVolumeResourceNamesAsync()
        {
            // Snippet: CreateVolumeAsync(LocationName, Volume, string, CallSettings)
            // Additional: CreateVolumeAsync(LocationName, Volume, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Volume volume = new Volume();
            string volumeId = "";
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.CreateVolumeAsync(parent, volume, volumeId);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolume</summary>
        public void UpdateVolumeRequestObject()
        {
            // Snippet: UpdateVolume(UpdateVolumeRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                UpdateMask = new FieldMask(),
                Volume = new Volume(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.UpdateVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolumeAsync</summary>
        public async Task UpdateVolumeRequestObjectAsync()
        {
            // Snippet: UpdateVolumeAsync(UpdateVolumeRequest, CallSettings)
            // Additional: UpdateVolumeAsync(UpdateVolumeRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                UpdateMask = new FieldMask(),
                Volume = new Volume(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.UpdateVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolume</summary>
        public void UpdateVolume()
        {
            // Snippet: UpdateVolume(Volume, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.UpdateVolume(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVolumeAsync</summary>
        public async Task UpdateVolumeAsync()
        {
            // Snippet: UpdateVolumeAsync(Volume, FieldMask, CallSettings)
            // Additional: UpdateVolumeAsync(Volume, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.UpdateVolumeAsync(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolume</summary>
        public void DeleteVolumeRequestObject()
        {
            // Snippet: DeleteVolume(DeleteVolumeRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteVolumeRequest request = new DeleteVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeAsync</summary>
        public async Task DeleteVolumeRequestObjectAsync()
        {
            // Snippet: DeleteVolumeAsync(DeleteVolumeRequest, CallSettings)
            // Additional: DeleteVolumeAsync(DeleteVolumeRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVolumeRequest request = new DeleteVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolume</summary>
        public void DeleteVolume()
        {
            // Snippet: DeleteVolume(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteVolume(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeAsync</summary>
        public async Task DeleteVolumeAsync()
        {
            // Snippet: DeleteVolumeAsync(string, CallSettings)
            // Additional: DeleteVolumeAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteVolumeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolume</summary>
        public void DeleteVolumeResourceNames()
        {
            // Snippet: DeleteVolume(VolumeName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteVolume(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeAsync</summary>
        public async Task DeleteVolumeResourceNamesAsync()
        {
            // Snippet: DeleteVolumeAsync(VolumeName, CallSettings)
            // Additional: DeleteVolumeAsync(VolumeName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteVolumeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevertVolume</summary>
        public void RevertVolumeRequestObject()
        {
            // Snippet: RevertVolume(RevertVolumeRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            RevertVolumeRequest request = new RevertVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                SnapshotId = "",
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = netAppClient.RevertVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = netAppClient.PollOnceRevertVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevertVolumeAsync</summary>
        public async Task RevertVolumeRequestObjectAsync()
        {
            // Snippet: RevertVolumeAsync(RevertVolumeRequest, CallSettings)
            // Additional: RevertVolumeAsync(RevertVolumeRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            RevertVolumeRequest request = new RevertVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                SnapshotId = "",
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await netAppClient.RevertVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await netAppClient.PollOnceRevertVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsRequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsRequestObjectAsync()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsResourceNames()
        {
            // Snippet: ListSnapshots(VolumeName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsResourceNamesAsync()
        {
            // Snippet: ListSnapshotsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = netAppClient.ListSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotRequestObject()
        {
            // Snippet: GetSnapshot(GetSnapshotRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = netAppClient.GetSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotRequestObjectAsync()
        {
            // Snippet: GetSnapshotAsync(GetSnapshotRequest, CallSettings)
            // Additional: GetSnapshotAsync(GetSnapshotRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = await netAppClient.GetSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshot()
        {
            // Snippet: GetSnapshot(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = netAppClient.GetSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotAsync()
        {
            // Snippet: GetSnapshotAsync(string, CallSettings)
            // Additional: GetSnapshotAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = await netAppClient.GetSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotResourceNames()
        {
            // Snippet: GetSnapshot(SnapshotName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = netAppClient.GetSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotResourceNamesAsync()
        {
            // Snippet: GetSnapshotAsync(SnapshotName, CallSettings)
            // Additional: GetSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = await netAppClient.GetSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotRequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Snapshot = new Snapshot(),
                SnapshotId = "",
            };
            // Make the request
            Operation<Snapshot, OperationMetadata> response = netAppClient.CreateSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotRequestObjectAsync()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotRequest, CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotRequest request = new CreateSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Snapshot = new Snapshot(),
                SnapshotId = "",
            };
            // Make the request
            Operation<Snapshot, OperationMetadata> response = await netAppClient.CreateSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(string, Snapshot, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            Snapshot snapshot = new Snapshot();
            string snapshotId = "";
            // Make the request
            Operation<Snapshot, OperationMetadata> response = netAppClient.CreateSnapshot(parent, snapshot, snapshotId);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(string, Snapshot, string, CallSettings)
            // Additional: CreateSnapshotAsync(string, Snapshot, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            Snapshot snapshot = new Snapshot();
            string snapshotId = "";
            // Make the request
            Operation<Snapshot, OperationMetadata> response = await netAppClient.CreateSnapshotAsync(parent, snapshot, snapshotId);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotResourceNames()
        {
            // Snippet: CreateSnapshot(VolumeName, Snapshot, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            Snapshot snapshot = new Snapshot();
            string snapshotId = "";
            // Make the request
            Operation<Snapshot, OperationMetadata> response = netAppClient.CreateSnapshot(parent, snapshot, snapshotId);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotResourceNamesAsync()
        {
            // Snippet: CreateSnapshotAsync(VolumeName, Snapshot, string, CallSettings)
            // Additional: CreateSnapshotAsync(VolumeName, Snapshot, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            Snapshot snapshot = new Snapshot();
            string snapshotId = "";
            // Make the request
            Operation<Snapshot, OperationMetadata> response = await netAppClient.CreateSnapshotAsync(parent, snapshot, snapshotId);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotRequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest, CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteSnapshot(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(string, CallSettings)
            // Additional: DeleteSnapshotAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteSnapshotAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotResourceNames()
        {
            // Snippet: DeleteSnapshot(SnapshotName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteSnapshot(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotResourceNamesAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName, CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteSnapshotAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshot</summary>
        public void UpdateSnapshotRequestObject()
        {
            // Snippet: UpdateSnapshot(UpdateSnapshotRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                UpdateMask = new FieldMask(),
                Snapshot = new Snapshot(),
            };
            // Make the request
            Operation<Snapshot, OperationMetadata> response = netAppClient.UpdateSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotAsync</summary>
        public async Task UpdateSnapshotRequestObjectAsync()
        {
            // Snippet: UpdateSnapshotAsync(UpdateSnapshotRequest, CallSettings)
            // Additional: UpdateSnapshotAsync(UpdateSnapshotRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSnapshotRequest request = new UpdateSnapshotRequest
            {
                UpdateMask = new FieldMask(),
                Snapshot = new Snapshot(),
            };
            // Make the request
            Operation<Snapshot, OperationMetadata> response = await netAppClient.UpdateSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshot</summary>
        public void UpdateSnapshot()
        {
            // Snippet: UpdateSnapshot(Snapshot, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            Snapshot snapshot = new Snapshot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Snapshot, OperationMetadata> response = netAppClient.UpdateSnapshot(snapshot, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSnapshotAsync</summary>
        public async Task UpdateSnapshotAsync()
        {
            // Snippet: UpdateSnapshotAsync(Snapshot, FieldMask, CallSettings)
            // Additional: UpdateSnapshotAsync(Snapshot, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            Snapshot snapshot = new Snapshot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Snapshot, OperationMetadata> response = await netAppClient.UpdateSnapshotAsync(snapshot, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectories</summary>
        public void ListActiveDirectoriesRequestObject()
        {
            // Snippet: ListActiveDirectories(ListActiveDirectoriesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ActiveDirectory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActiveDirectoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectoriesAsync</summary>
        public async Task ListActiveDirectoriesRequestObjectAsync()
        {
            // Snippet: ListActiveDirectoriesAsync(ListActiveDirectoriesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListActiveDirectoriesRequest request = new ListActiveDirectoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ActiveDirectory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActiveDirectoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectories</summary>
        public void ListActiveDirectories()
        {
            // Snippet: ListActiveDirectories(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ActiveDirectory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActiveDirectoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectoriesAsync</summary>
        public async Task ListActiveDirectoriesAsync()
        {
            // Snippet: ListActiveDirectoriesAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ActiveDirectory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActiveDirectoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectories</summary>
        public void ListActiveDirectoriesResourceNames()
        {
            // Snippet: ListActiveDirectories(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ActiveDirectory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActiveDirectoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListActiveDirectoriesAsync</summary>
        public async Task ListActiveDirectoriesResourceNamesAsync()
        {
            // Snippet: ListActiveDirectoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListActiveDirectoriesResponse, ActiveDirectory> response = netAppClient.ListActiveDirectoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ActiveDirectory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActiveDirectoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ActiveDirectory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ActiveDirectory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ActiveDirectory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectory</summary>
        public void GetActiveDirectoryRequestObject()
        {
            // Snippet: GetActiveDirectory(GetActiveDirectoryRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetActiveDirectoryRequest request = new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]"),
            };
            // Make the request
            ActiveDirectory response = netAppClient.GetActiveDirectory(request);
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectoryAsync</summary>
        public async Task GetActiveDirectoryRequestObjectAsync()
        {
            // Snippet: GetActiveDirectoryAsync(GetActiveDirectoryRequest, CallSettings)
            // Additional: GetActiveDirectoryAsync(GetActiveDirectoryRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetActiveDirectoryRequest request = new GetActiveDirectoryRequest
            {
                ActiveDirectoryName = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]"),
            };
            // Make the request
            ActiveDirectory response = await netAppClient.GetActiveDirectoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectory</summary>
        public void GetActiveDirectory()
        {
            // Snippet: GetActiveDirectory(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/activeDirectories/[ACTIVE_DIRECTORY]";
            // Make the request
            ActiveDirectory response = netAppClient.GetActiveDirectory(name);
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectoryAsync</summary>
        public async Task GetActiveDirectoryAsync()
        {
            // Snippet: GetActiveDirectoryAsync(string, CallSettings)
            // Additional: GetActiveDirectoryAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/activeDirectories/[ACTIVE_DIRECTORY]";
            // Make the request
            ActiveDirectory response = await netAppClient.GetActiveDirectoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectory</summary>
        public void GetActiveDirectoryResourceNames()
        {
            // Snippet: GetActiveDirectory(ActiveDirectoryName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ActiveDirectoryName name = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]");
            // Make the request
            ActiveDirectory response = netAppClient.GetActiveDirectory(name);
            // End snippet
        }

        /// <summary>Snippet for GetActiveDirectoryAsync</summary>
        public async Task GetActiveDirectoryResourceNamesAsync()
        {
            // Snippet: GetActiveDirectoryAsync(ActiveDirectoryName, CallSettings)
            // Additional: GetActiveDirectoryAsync(ActiveDirectoryName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ActiveDirectoryName name = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]");
            // Make the request
            ActiveDirectory response = await netAppClient.GetActiveDirectoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectory</summary>
        public void CreateActiveDirectoryRequestObject()
        {
            // Snippet: CreateActiveDirectory(CreateActiveDirectoryRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateActiveDirectoryRequest request = new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ActiveDirectory = new ActiveDirectory(),
                ActiveDirectoryId = "",
            };
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = netAppClient.CreateActiveDirectory(request);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectoryAsync</summary>
        public async Task CreateActiveDirectoryRequestObjectAsync()
        {
            // Snippet: CreateActiveDirectoryAsync(CreateActiveDirectoryRequest, CallSettings)
            // Additional: CreateActiveDirectoryAsync(CreateActiveDirectoryRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateActiveDirectoryRequest request = new CreateActiveDirectoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ActiveDirectory = new ActiveDirectory(),
                ActiveDirectoryId = "",
            };
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = await netAppClient.CreateActiveDirectoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectory</summary>
        public void CreateActiveDirectory()
        {
            // Snippet: CreateActiveDirectory(string, ActiveDirectory, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ActiveDirectory activeDirectory = new ActiveDirectory();
            string activeDirectoryId = "";
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = netAppClient.CreateActiveDirectory(parent, activeDirectory, activeDirectoryId);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectoryAsync</summary>
        public async Task CreateActiveDirectoryAsync()
        {
            // Snippet: CreateActiveDirectoryAsync(string, ActiveDirectory, string, CallSettings)
            // Additional: CreateActiveDirectoryAsync(string, ActiveDirectory, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ActiveDirectory activeDirectory = new ActiveDirectory();
            string activeDirectoryId = "";
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = await netAppClient.CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectory</summary>
        public void CreateActiveDirectoryResourceNames()
        {
            // Snippet: CreateActiveDirectory(LocationName, ActiveDirectory, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ActiveDirectory activeDirectory = new ActiveDirectory();
            string activeDirectoryId = "";
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = netAppClient.CreateActiveDirectory(parent, activeDirectory, activeDirectoryId);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateActiveDirectoryAsync</summary>
        public async Task CreateActiveDirectoryResourceNamesAsync()
        {
            // Snippet: CreateActiveDirectoryAsync(LocationName, ActiveDirectory, string, CallSettings)
            // Additional: CreateActiveDirectoryAsync(LocationName, ActiveDirectory, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ActiveDirectory activeDirectory = new ActiveDirectory();
            string activeDirectoryId = "";
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = await netAppClient.CreateActiveDirectoryAsync(parent, activeDirectory, activeDirectoryId);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveDirectory</summary>
        public void UpdateActiveDirectoryRequestObject()
        {
            // Snippet: UpdateActiveDirectory(UpdateActiveDirectoryRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateActiveDirectoryRequest request = new UpdateActiveDirectoryRequest
            {
                UpdateMask = new FieldMask(),
                ActiveDirectory = new ActiveDirectory(),
            };
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = netAppClient.UpdateActiveDirectory(request);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveDirectoryAsync</summary>
        public async Task UpdateActiveDirectoryRequestObjectAsync()
        {
            // Snippet: UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest, CallSettings)
            // Additional: UpdateActiveDirectoryAsync(UpdateActiveDirectoryRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateActiveDirectoryRequest request = new UpdateActiveDirectoryRequest
            {
                UpdateMask = new FieldMask(),
                ActiveDirectory = new ActiveDirectory(),
            };
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = await netAppClient.UpdateActiveDirectoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveDirectory</summary>
        public void UpdateActiveDirectory()
        {
            // Snippet: UpdateActiveDirectory(ActiveDirectory, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ActiveDirectory activeDirectory = new ActiveDirectory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = netAppClient.UpdateActiveDirectory(activeDirectory, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateActiveDirectoryAsync</summary>
        public async Task UpdateActiveDirectoryAsync()
        {
            // Snippet: UpdateActiveDirectoryAsync(ActiveDirectory, FieldMask, CallSettings)
            // Additional: UpdateActiveDirectoryAsync(ActiveDirectory, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ActiveDirectory activeDirectory = new ActiveDirectory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ActiveDirectory, OperationMetadata> response = await netAppClient.UpdateActiveDirectoryAsync(activeDirectory, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ActiveDirectory, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ActiveDirectory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ActiveDirectory, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ActiveDirectory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectory</summary>
        public void DeleteActiveDirectoryRequestObject()
        {
            // Snippet: DeleteActiveDirectory(DeleteActiveDirectoryRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteActiveDirectoryRequest request = new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteActiveDirectory(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectoryAsync</summary>
        public async Task DeleteActiveDirectoryRequestObjectAsync()
        {
            // Snippet: DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest, CallSettings)
            // Additional: DeleteActiveDirectoryAsync(DeleteActiveDirectoryRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteActiveDirectoryRequest request = new DeleteActiveDirectoryRequest
            {
                ActiveDirectoryName = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteActiveDirectoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectory</summary>
        public void DeleteActiveDirectory()
        {
            // Snippet: DeleteActiveDirectory(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/activeDirectories/[ACTIVE_DIRECTORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteActiveDirectory(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectoryAsync</summary>
        public async Task DeleteActiveDirectoryAsync()
        {
            // Snippet: DeleteActiveDirectoryAsync(string, CallSettings)
            // Additional: DeleteActiveDirectoryAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/activeDirectories/[ACTIVE_DIRECTORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteActiveDirectoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectory</summary>
        public void DeleteActiveDirectoryResourceNames()
        {
            // Snippet: DeleteActiveDirectory(ActiveDirectoryName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ActiveDirectoryName name = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteActiveDirectory(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteActiveDirectory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteActiveDirectoryAsync</summary>
        public async Task DeleteActiveDirectoryResourceNamesAsync()
        {
            // Snippet: DeleteActiveDirectoryAsync(ActiveDirectoryName, CallSettings)
            // Additional: DeleteActiveDirectoryAsync(ActiveDirectoryName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ActiveDirectoryName name = ActiveDirectoryName.FromProjectLocationActiveDirectory("[PROJECT]", "[LOCATION]", "[ACTIVE_DIRECTORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteActiveDirectoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteActiveDirectoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigs</summary>
        public void ListKmsConfigsRequestObject()
        {
            // Snippet: ListKmsConfigs(ListKmsConfigsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KmsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKmsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigsAsync</summary>
        public async Task ListKmsConfigsRequestObjectAsync()
        {
            // Snippet: ListKmsConfigsAsync(ListKmsConfigsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListKmsConfigsRequest request = new ListKmsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KmsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKmsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigs</summary>
        public void ListKmsConfigs()
        {
            // Snippet: ListKmsConfigs(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KmsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKmsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigsAsync</summary>
        public async Task ListKmsConfigsAsync()
        {
            // Snippet: ListKmsConfigsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KmsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKmsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigs</summary>
        public void ListKmsConfigsResourceNames()
        {
            // Snippet: ListKmsConfigs(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KmsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKmsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKmsConfigsAsync</summary>
        public async Task ListKmsConfigsResourceNamesAsync()
        {
            // Snippet: ListKmsConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListKmsConfigsResponse, KmsConfig> response = netAppClient.ListKmsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KmsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKmsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KmsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KmsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KmsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfig</summary>
        public void CreateKmsConfigRequestObject()
        {
            // Snippet: CreateKmsConfig(CreateKmsConfigRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateKmsConfigRequest request = new CreateKmsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsConfigId = "",
                KmsConfig = new KmsConfig(),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.CreateKmsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfigAsync</summary>
        public async Task CreateKmsConfigRequestObjectAsync()
        {
            // Snippet: CreateKmsConfigAsync(CreateKmsConfigRequest, CallSettings)
            // Additional: CreateKmsConfigAsync(CreateKmsConfigRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateKmsConfigRequest request = new CreateKmsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsConfigId = "",
                KmsConfig = new KmsConfig(),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.CreateKmsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfig</summary>
        public void CreateKmsConfig()
        {
            // Snippet: CreateKmsConfig(string, KmsConfig, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            KmsConfig kmsConfig = new KmsConfig();
            string kmsConfigId = "";
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.CreateKmsConfig(parent, kmsConfig, kmsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfigAsync</summary>
        public async Task CreateKmsConfigAsync()
        {
            // Snippet: CreateKmsConfigAsync(string, KmsConfig, string, CallSettings)
            // Additional: CreateKmsConfigAsync(string, KmsConfig, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            KmsConfig kmsConfig = new KmsConfig();
            string kmsConfigId = "";
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfig</summary>
        public void CreateKmsConfigResourceNames()
        {
            // Snippet: CreateKmsConfig(LocationName, KmsConfig, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KmsConfig kmsConfig = new KmsConfig();
            string kmsConfigId = "";
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.CreateKmsConfig(parent, kmsConfig, kmsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateKmsConfigAsync</summary>
        public async Task CreateKmsConfigResourceNamesAsync()
        {
            // Snippet: CreateKmsConfigAsync(LocationName, KmsConfig, string, CallSettings)
            // Additional: CreateKmsConfigAsync(LocationName, KmsConfig, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            KmsConfig kmsConfig = new KmsConfig();
            string kmsConfigId = "";
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.CreateKmsConfigAsync(parent, kmsConfig, kmsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfig</summary>
        public void GetKmsConfigRequestObject()
        {
            // Snippet: GetKmsConfig(GetKmsConfigRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetKmsConfigRequest request = new GetKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            KmsConfig response = netAppClient.GetKmsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfigAsync</summary>
        public async Task GetKmsConfigRequestObjectAsync()
        {
            // Snippet: GetKmsConfigAsync(GetKmsConfigRequest, CallSettings)
            // Additional: GetKmsConfigAsync(GetKmsConfigRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetKmsConfigRequest request = new GetKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            KmsConfig response = await netAppClient.GetKmsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfig</summary>
        public void GetKmsConfig()
        {
            // Snippet: GetKmsConfig(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/kmsConfigs/[KMS_CONFIG]";
            // Make the request
            KmsConfig response = netAppClient.GetKmsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfigAsync</summary>
        public async Task GetKmsConfigAsync()
        {
            // Snippet: GetKmsConfigAsync(string, CallSettings)
            // Additional: GetKmsConfigAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/kmsConfigs/[KMS_CONFIG]";
            // Make the request
            KmsConfig response = await netAppClient.GetKmsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfig</summary>
        public void GetKmsConfigResourceNames()
        {
            // Snippet: GetKmsConfig(KmsConfigName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            KmsConfigName name = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]");
            // Make the request
            KmsConfig response = netAppClient.GetKmsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetKmsConfigAsync</summary>
        public async Task GetKmsConfigResourceNamesAsync()
        {
            // Snippet: GetKmsConfigAsync(KmsConfigName, CallSettings)
            // Additional: GetKmsConfigAsync(KmsConfigName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            KmsConfigName name = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]");
            // Make the request
            KmsConfig response = await netAppClient.GetKmsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsConfig</summary>
        public void UpdateKmsConfigRequestObject()
        {
            // Snippet: UpdateKmsConfig(UpdateKmsConfigRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateKmsConfigRequest request = new UpdateKmsConfigRequest
            {
                UpdateMask = new FieldMask(),
                KmsConfig = new KmsConfig(),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.UpdateKmsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsConfigAsync</summary>
        public async Task UpdateKmsConfigRequestObjectAsync()
        {
            // Snippet: UpdateKmsConfigAsync(UpdateKmsConfigRequest, CallSettings)
            // Additional: UpdateKmsConfigAsync(UpdateKmsConfigRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKmsConfigRequest request = new UpdateKmsConfigRequest
            {
                UpdateMask = new FieldMask(),
                KmsConfig = new KmsConfig(),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.UpdateKmsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsConfig</summary>
        public void UpdateKmsConfig()
        {
            // Snippet: UpdateKmsConfig(KmsConfig, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            KmsConfig kmsConfig = new KmsConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.UpdateKmsConfig(kmsConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsConfigAsync</summary>
        public async Task UpdateKmsConfigAsync()
        {
            // Snippet: UpdateKmsConfigAsync(KmsConfig, FieldMask, CallSettings)
            // Additional: UpdateKmsConfigAsync(KmsConfig, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            KmsConfig kmsConfig = new KmsConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.UpdateKmsConfigAsync(kmsConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EncryptVolumes</summary>
        public void EncryptVolumesRequestObject()
        {
            // Snippet: EncryptVolumes(EncryptVolumesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            EncryptVolumesRequest request = new EncryptVolumesRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = netAppClient.EncryptVolumes(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = netAppClient.PollOnceEncryptVolumes(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EncryptVolumesAsync</summary>
        public async Task EncryptVolumesRequestObjectAsync()
        {
            // Snippet: EncryptVolumesAsync(EncryptVolumesRequest, CallSettings)
            // Additional: EncryptVolumesAsync(EncryptVolumesRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            EncryptVolumesRequest request = new EncryptVolumesRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            Operation<KmsConfig, OperationMetadata> response = await netAppClient.EncryptVolumesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<KmsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            KmsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<KmsConfig, OperationMetadata> retrievedResponse = await netAppClient.PollOnceEncryptVolumesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                KmsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for VerifyKmsConfig</summary>
        public void VerifyKmsConfigRequestObject()
        {
            // Snippet: VerifyKmsConfig(VerifyKmsConfigRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VerifyKmsConfigRequest request = new VerifyKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            VerifyKmsConfigResponse response = netAppClient.VerifyKmsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyKmsConfigAsync</summary>
        public async Task VerifyKmsConfigRequestObjectAsync()
        {
            // Snippet: VerifyKmsConfigAsync(VerifyKmsConfigRequest, CallSettings)
            // Additional: VerifyKmsConfigAsync(VerifyKmsConfigRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VerifyKmsConfigRequest request = new VerifyKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            VerifyKmsConfigResponse response = await netAppClient.VerifyKmsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfig</summary>
        public void DeleteKmsConfigRequestObject()
        {
            // Snippet: DeleteKmsConfig(DeleteKmsConfigRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteKmsConfigRequest request = new DeleteKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteKmsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfigAsync</summary>
        public async Task DeleteKmsConfigRequestObjectAsync()
        {
            // Snippet: DeleteKmsConfigAsync(DeleteKmsConfigRequest, CallSettings)
            // Additional: DeleteKmsConfigAsync(DeleteKmsConfigRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKmsConfigRequest request = new DeleteKmsConfigRequest
            {
                KmsConfigName = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteKmsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfig</summary>
        public void DeleteKmsConfig()
        {
            // Snippet: DeleteKmsConfig(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/kmsConfigs/[KMS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteKmsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfigAsync</summary>
        public async Task DeleteKmsConfigAsync()
        {
            // Snippet: DeleteKmsConfigAsync(string, CallSettings)
            // Additional: DeleteKmsConfigAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/kmsConfigs/[KMS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteKmsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfig</summary>
        public void DeleteKmsConfigResourceNames()
        {
            // Snippet: DeleteKmsConfig(KmsConfigName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            KmsConfigName name = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteKmsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteKmsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteKmsConfigAsync</summary>
        public async Task DeleteKmsConfigResourceNamesAsync()
        {
            // Snippet: DeleteKmsConfigAsync(KmsConfigName, CallSettings)
            // Additional: DeleteKmsConfigAsync(KmsConfigName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            KmsConfigName name = KmsConfigName.FromProjectLocationKmsConfig("[PROJECT]", "[LOCATION]", "[KMS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteKmsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteKmsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListReplications</summary>
        public void ListReplicationsRequestObject()
        {
            // Snippet: ListReplications(ListReplicationsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListReplicationsRequest request = new ListReplicationsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Replication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationsAsync</summary>
        public async Task ListReplicationsRequestObjectAsync()
        {
            // Snippet: ListReplicationsAsync(ListReplicationsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListReplicationsRequest request = new ListReplicationsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Replication item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplications</summary>
        public void ListReplications()
        {
            // Snippet: ListReplications(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Replication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationsAsync</summary>
        public async Task ListReplicationsAsync()
        {
            // Snippet: ListReplicationsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Replication item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplications</summary>
        public void ListReplicationsResourceNames()
        {
            // Snippet: ListReplications(VolumeName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Replication item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplicationsAsync</summary>
        public async Task ListReplicationsResourceNamesAsync()
        {
            // Snippet: ListReplicationsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListReplicationsResponse, Replication> response = netAppClient.ListReplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Replication item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Replication item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Replication> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Replication item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReplication</summary>
        public void GetReplicationRequestObject()
        {
            // Snippet: GetReplication(GetReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetReplicationRequest request = new GetReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Replication response = netAppClient.GetReplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationAsync</summary>
        public async Task GetReplicationRequestObjectAsync()
        {
            // Snippet: GetReplicationAsync(GetReplicationRequest, CallSettings)
            // Additional: GetReplicationAsync(GetReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetReplicationRequest request = new GetReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Replication response = await netAppClient.GetReplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplication</summary>
        public void GetReplication()
        {
            // Snippet: GetReplication(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/replications/[REPLICATION]";
            // Make the request
            Replication response = netAppClient.GetReplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationAsync</summary>
        public async Task GetReplicationAsync()
        {
            // Snippet: GetReplicationAsync(string, CallSettings)
            // Additional: GetReplicationAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/replications/[REPLICATION]";
            // Make the request
            Replication response = await netAppClient.GetReplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplication</summary>
        public void GetReplicationResourceNames()
        {
            // Snippet: GetReplication(ReplicationName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ReplicationName name = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]");
            // Make the request
            Replication response = netAppClient.GetReplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplicationAsync</summary>
        public async Task GetReplicationResourceNamesAsync()
        {
            // Snippet: GetReplicationAsync(ReplicationName, CallSettings)
            // Additional: GetReplicationAsync(ReplicationName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ReplicationName name = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]");
            // Make the request
            Replication response = await netAppClient.GetReplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReplication</summary>
        public void CreateReplicationRequestObject()
        {
            // Snippet: CreateReplication(CreateReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateReplicationRequest request = new CreateReplicationRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Replication = new Replication(),
                ReplicationId = "",
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.CreateReplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplicationAsync</summary>
        public async Task CreateReplicationRequestObjectAsync()
        {
            // Snippet: CreateReplicationAsync(CreateReplicationRequest, CallSettings)
            // Additional: CreateReplicationAsync(CreateReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateReplicationRequest request = new CreateReplicationRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                Replication = new Replication(),
                ReplicationId = "",
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.CreateReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplication</summary>
        public void CreateReplication()
        {
            // Snippet: CreateReplication(string, Replication, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            Replication replication = new Replication();
            string replicationId = "";
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.CreateReplication(parent, replication, replicationId);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplicationAsync</summary>
        public async Task CreateReplicationAsync()
        {
            // Snippet: CreateReplicationAsync(string, Replication, string, CallSettings)
            // Additional: CreateReplicationAsync(string, Replication, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            Replication replication = new Replication();
            string replicationId = "";
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.CreateReplicationAsync(parent, replication, replicationId);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplication</summary>
        public void CreateReplicationResourceNames()
        {
            // Snippet: CreateReplication(VolumeName, Replication, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            Replication replication = new Replication();
            string replicationId = "";
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.CreateReplication(parent, replication, replicationId);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplicationAsync</summary>
        public async Task CreateReplicationResourceNamesAsync()
        {
            // Snippet: CreateReplicationAsync(VolumeName, Replication, string, CallSettings)
            // Additional: CreateReplicationAsync(VolumeName, Replication, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            Replication replication = new Replication();
            string replicationId = "";
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.CreateReplicationAsync(parent, replication, replicationId);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplication</summary>
        public void DeleteReplicationRequestObject()
        {
            // Snippet: DeleteReplication(DeleteReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteReplicationRequest request = new DeleteReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteReplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplicationAsync</summary>
        public async Task DeleteReplicationRequestObjectAsync()
        {
            // Snippet: DeleteReplicationAsync(DeleteReplicationRequest, CallSettings)
            // Additional: DeleteReplicationAsync(DeleteReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReplicationRequest request = new DeleteReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplication</summary>
        public void DeleteReplication()
        {
            // Snippet: DeleteReplication(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/replications/[REPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteReplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplicationAsync</summary>
        public async Task DeleteReplicationAsync()
        {
            // Snippet: DeleteReplicationAsync(string, CallSettings)
            // Additional: DeleteReplicationAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/replications/[REPLICATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteReplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplication</summary>
        public void DeleteReplicationResourceNames()
        {
            // Snippet: DeleteReplication(ReplicationName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ReplicationName name = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteReplication(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReplicationAsync</summary>
        public async Task DeleteReplicationResourceNamesAsync()
        {
            // Snippet: DeleteReplicationAsync(ReplicationName, CallSettings)
            // Additional: DeleteReplicationAsync(ReplicationName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ReplicationName name = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteReplicationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReplication</summary>
        public void UpdateReplicationRequestObject()
        {
            // Snippet: UpdateReplication(UpdateReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateReplicationRequest request = new UpdateReplicationRequest
            {
                UpdateMask = new FieldMask(),
                Replication = new Replication(),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.UpdateReplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReplicationAsync</summary>
        public async Task UpdateReplicationRequestObjectAsync()
        {
            // Snippet: UpdateReplicationAsync(UpdateReplicationRequest, CallSettings)
            // Additional: UpdateReplicationAsync(UpdateReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReplicationRequest request = new UpdateReplicationRequest
            {
                UpdateMask = new FieldMask(),
                Replication = new Replication(),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.UpdateReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReplication</summary>
        public void UpdateReplication()
        {
            // Snippet: UpdateReplication(Replication, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            Replication replication = new Replication();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.UpdateReplication(replication, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReplicationAsync</summary>
        public async Task UpdateReplicationAsync()
        {
            // Snippet: UpdateReplicationAsync(Replication, FieldMask, CallSettings)
            // Additional: UpdateReplicationAsync(Replication, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            Replication replication = new Replication();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.UpdateReplicationAsync(replication, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopReplication</summary>
        public void StopReplicationRequestObject()
        {
            // Snippet: StopReplication(StopReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            StopReplicationRequest request = new StopReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
                Force = false,
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.StopReplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceStopReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopReplicationAsync</summary>
        public async Task StopReplicationRequestObjectAsync()
        {
            // Snippet: StopReplicationAsync(StopReplicationRequest, CallSettings)
            // Additional: StopReplicationAsync(StopReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            StopReplicationRequest request = new StopReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
                Force = false,
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.StopReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceStopReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeReplication</summary>
        public void ResumeReplicationRequestObject()
        {
            // Snippet: ResumeReplication(ResumeReplicationRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ResumeReplicationRequest request = new ResumeReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.ResumeReplication(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceResumeReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeReplicationAsync</summary>
        public async Task ResumeReplicationRequestObjectAsync()
        {
            // Snippet: ResumeReplicationAsync(ResumeReplicationRequest, CallSettings)
            // Additional: ResumeReplicationAsync(ResumeReplicationRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ResumeReplicationRequest request = new ResumeReplicationRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.ResumeReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceResumeReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReverseReplicationDirection</summary>
        public void ReverseReplicationDirectionRequestObject()
        {
            // Snippet: ReverseReplicationDirection(ReverseReplicationDirectionRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ReverseReplicationDirectionRequest request = new ReverseReplicationDirectionRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = netAppClient.ReverseReplicationDirection(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = netAppClient.PollOnceReverseReplicationDirection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReverseReplicationDirectionAsync</summary>
        public async Task ReverseReplicationDirectionRequestObjectAsync()
        {
            // Snippet: ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest, CallSettings)
            // Additional: ReverseReplicationDirectionAsync(ReverseReplicationDirectionRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ReverseReplicationDirectionRequest request = new ReverseReplicationDirectionRequest
            {
                ReplicationName = ReplicationName.FromProjectLocationVolumeReplication("[PROJECT]", "[LOCATION]", "[VOLUME]", "[REPLICATION]"),
            };
            // Make the request
            Operation<Replication, OperationMetadata> response = await netAppClient.ReverseReplicationDirectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replication, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replication result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replication, OperationMetadata> retrievedResponse = await netAppClient.PollOnceReverseReplicationDirectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replication retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVaultRequestObject()
        {
            // Snippet: CreateBackupVault(CreateBackupVaultRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateBackupVaultRequest request = new CreateBackupVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupVaultId = "",
                BackupVault = new BackupVault(),
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = netAppClient.CreateBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultRequestObjectAsync()
        {
            // Snippet: CreateBackupVaultAsync(CreateBackupVaultRequest, CallSettings)
            // Additional: CreateBackupVaultAsync(CreateBackupVaultRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupVaultRequest request = new CreateBackupVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupVaultId = "",
                BackupVault = new BackupVault(),
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await netAppClient.CreateBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVault()
        {
            // Snippet: CreateBackupVault(string, BackupVault, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = netAppClient.CreateBackupVault(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultAsync()
        {
            // Snippet: CreateBackupVaultAsync(string, BackupVault, string, CallSettings)
            // Additional: CreateBackupVaultAsync(string, BackupVault, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await netAppClient.CreateBackupVaultAsync(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVaultResourceNames()
        {
            // Snippet: CreateBackupVault(LocationName, BackupVault, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = netAppClient.CreateBackupVault(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultResourceNamesAsync()
        {
            // Snippet: CreateBackupVaultAsync(LocationName, BackupVault, string, CallSettings)
            // Additional: CreateBackupVaultAsync(LocationName, BackupVault, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await netAppClient.CreateBackupVaultAsync(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVaultRequestObject()
        {
            // Snippet: GetBackupVault(GetBackupVaultRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetBackupVaultRequest request = new GetBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
            };
            // Make the request
            BackupVault response = netAppClient.GetBackupVault(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultRequestObjectAsync()
        {
            // Snippet: GetBackupVaultAsync(GetBackupVaultRequest, CallSettings)
            // Additional: GetBackupVaultAsync(GetBackupVaultRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupVaultRequest request = new GetBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
            };
            // Make the request
            BackupVault response = await netAppClient.GetBackupVaultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVault()
        {
            // Snippet: GetBackupVault(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            BackupVault response = netAppClient.GetBackupVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultAsync()
        {
            // Snippet: GetBackupVaultAsync(string, CallSettings)
            // Additional: GetBackupVaultAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            BackupVault response = await netAppClient.GetBackupVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVaultResourceNames()
        {
            // Snippet: GetBackupVault(BackupVaultName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            BackupVault response = netAppClient.GetBackupVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultResourceNamesAsync()
        {
            // Snippet: GetBackupVaultAsync(BackupVaultName, CallSettings)
            // Additional: GetBackupVaultAsync(BackupVaultName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            BackupVault response = await netAppClient.GetBackupVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaultsRequestObject()
        {
            // Snippet: ListBackupVaults(ListBackupVaultsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsRequestObjectAsync()
        {
            // Snippet: ListBackupVaultsAsync(ListBackupVaultsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaults()
        {
            // Snippet: ListBackupVaults(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsAsync()
        {
            // Snippet: ListBackupVaultsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaultsResourceNames()
        {
            // Snippet: ListBackupVaults(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsResourceNamesAsync()
        {
            // Snippet: ListBackupVaultsAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = netAppClient.ListBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVault</summary>
        public void UpdateBackupVaultRequestObject()
        {
            // Snippet: UpdateBackupVault(UpdateBackupVaultRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateBackupVaultRequest request = new UpdateBackupVaultRequest
            {
                UpdateMask = new FieldMask(),
                BackupVault = new BackupVault(),
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = netAppClient.UpdateBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVaultAsync</summary>
        public async Task UpdateBackupVaultRequestObjectAsync()
        {
            // Snippet: UpdateBackupVaultAsync(UpdateBackupVaultRequest, CallSettings)
            // Additional: UpdateBackupVaultAsync(UpdateBackupVaultRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupVaultRequest request = new UpdateBackupVaultRequest
            {
                UpdateMask = new FieldMask(),
                BackupVault = new BackupVault(),
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await netAppClient.UpdateBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVault</summary>
        public void UpdateBackupVault()
        {
            // Snippet: UpdateBackupVault(BackupVault, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupVault backupVault = new BackupVault();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupVault, OperationMetadata> response = netAppClient.UpdateBackupVault(backupVault, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVaultAsync</summary>
        public async Task UpdateBackupVaultAsync()
        {
            // Snippet: UpdateBackupVaultAsync(BackupVault, FieldMask, CallSettings)
            // Additional: UpdateBackupVaultAsync(BackupVault, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupVault backupVault = new BackupVault();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await netAppClient.UpdateBackupVaultAsync(backupVault, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVaultRequestObject()
        {
            // Snippet: DeleteBackupVault(DeleteBackupVaultRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteBackupVaultRequest request = new DeleteBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultRequestObjectAsync()
        {
            // Snippet: DeleteBackupVaultAsync(DeleteBackupVaultRequest, CallSettings)
            // Additional: DeleteBackupVaultAsync(DeleteBackupVaultRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupVaultRequest request = new DeleteBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVault()
        {
            // Snippet: DeleteBackupVault(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultAsync()
        {
            // Snippet: DeleteBackupVaultAsync(string, CallSettings)
            // Additional: DeleteBackupVaultAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVaultResourceNames()
        {
            // Snippet: DeleteBackupVault(BackupVaultName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultResourceNamesAsync()
        {
            // Snippet: DeleteBackupVaultAsync(BackupVaultName, CallSettings)
            // Additional: DeleteBackupVaultAsync(BackupVaultName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = netAppClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupRequestObjectAsync()
        {
            // Snippet: CreateBackupAsync(CreateBackupRequest, CallSettings)
            // Additional: CreateBackupAsync(CreateBackupRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await netAppClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackup()
        {
            // Snippet: CreateBackup(string, Backup, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = netAppClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupAsync()
        {
            // Snippet: CreateBackupAsync(string, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(string, Backup, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await netAppClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupResourceNames()
        {
            // Snippet: CreateBackup(BackupVaultName, Backup, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = netAppClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupResourceNamesAsync()
        {
            // Snippet: CreateBackupAsync(BackupVaultName, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(BackupVaultName, Backup, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await netAppClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupRequestObject()
        {
            // Snippet: GetBackup(GetBackupRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]"),
            };
            // Make the request
            Backup response = netAppClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await netAppClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]/backups/[BACKUP]";
            // Make the request
            Backup response = netAppClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]/backups/[BACKUP]";
            // Make the request
            Backup response = await netAppClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]");
            // Make the request
            Backup response = netAppClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]");
            // Make the request
            Backup response = await netAppClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsRequestObjectAsync()
        {
            // Snippet: ListBackupsAsync(ListBackupsRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackups()
        {
            // Snippet: ListBackups(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsAsync()
        {
            // Snippet: ListBackupsAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsResourceNames()
        {
            // Snippet: ListBackups(BackupVaultName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsResourceNamesAsync()
        {
            // Snippet: ListBackupsAsync(BackupVaultName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupVault("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = netAppClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUP_VAULT]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupVaultBackup("[PROJECT]", "[LOCATION]", "[BACKUP_VAULT]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = netAppClient.UpdateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupRequestObjectAsync()
        {
            // Snippet: UpdateBackupAsync(UpdateBackupRequest, CallSettings)
            // Additional: UpdateBackupAsync(UpdateBackupRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await netAppClient.UpdateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackup()
        {
            // Snippet: UpdateBackup(Backup, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = netAppClient.UpdateBackup(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupAsync()
        {
            // Snippet: UpdateBackupAsync(Backup, FieldMask, CallSettings)
            // Additional: UpdateBackupAsync(Backup, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = await netAppClient.UpdateBackupAsync(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicy</summary>
        public void CreateBackupPolicyRequestObject()
        {
            // Snippet: CreateBackupPolicy(CreateBackupPolicyRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            CreateBackupPolicyRequest request = new CreateBackupPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPolicy = new BackupPolicy(),
                BackupPolicyId = "",
            };
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = netAppClient.CreateBackupPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicyAsync</summary>
        public async Task CreateBackupPolicyRequestObjectAsync()
        {
            // Snippet: CreateBackupPolicyAsync(CreateBackupPolicyRequest, CallSettings)
            // Additional: CreateBackupPolicyAsync(CreateBackupPolicyRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupPolicyRequest request = new CreateBackupPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPolicy = new BackupPolicy(),
                BackupPolicyId = "",
            };
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = await netAppClient.CreateBackupPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicy</summary>
        public void CreateBackupPolicy()
        {
            // Snippet: CreateBackupPolicy(string, BackupPolicy, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPolicy backupPolicy = new BackupPolicy();
            string backupPolicyId = "";
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = netAppClient.CreateBackupPolicy(parent, backupPolicy, backupPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicyAsync</summary>
        public async Task CreateBackupPolicyAsync()
        {
            // Snippet: CreateBackupPolicyAsync(string, BackupPolicy, string, CallSettings)
            // Additional: CreateBackupPolicyAsync(string, BackupPolicy, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPolicy backupPolicy = new BackupPolicy();
            string backupPolicyId = "";
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = await netAppClient.CreateBackupPolicyAsync(parent, backupPolicy, backupPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicy</summary>
        public void CreateBackupPolicyResourceNames()
        {
            // Snippet: CreateBackupPolicy(LocationName, BackupPolicy, string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPolicy backupPolicy = new BackupPolicy();
            string backupPolicyId = "";
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = netAppClient.CreateBackupPolicy(parent, backupPolicy, backupPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = netAppClient.PollOnceCreateBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPolicyAsync</summary>
        public async Task CreateBackupPolicyResourceNamesAsync()
        {
            // Snippet: CreateBackupPolicyAsync(LocationName, BackupPolicy, string, CallSettings)
            // Additional: CreateBackupPolicyAsync(LocationName, BackupPolicy, string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPolicy backupPolicy = new BackupPolicy();
            string backupPolicyId = "";
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = await netAppClient.CreateBackupPolicyAsync(parent, backupPolicy, backupPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = await netAppClient.PollOnceCreateBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicy</summary>
        public void GetBackupPolicyRequestObject()
        {
            // Snippet: GetBackupPolicy(GetBackupPolicyRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            GetBackupPolicyRequest request = new GetBackupPolicyRequest
            {
                BackupPolicyName = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]"),
            };
            // Make the request
            BackupPolicy response = netAppClient.GetBackupPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicyAsync</summary>
        public async Task GetBackupPolicyRequestObjectAsync()
        {
            // Snippet: GetBackupPolicyAsync(GetBackupPolicyRequest, CallSettings)
            // Additional: GetBackupPolicyAsync(GetBackupPolicyRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupPolicyRequest request = new GetBackupPolicyRequest
            {
                BackupPolicyName = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]"),
            };
            // Make the request
            BackupPolicy response = await netAppClient.GetBackupPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicy</summary>
        public void GetBackupPolicy()
        {
            // Snippet: GetBackupPolicy(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPolicies/[BACKUP_POLICY]";
            // Make the request
            BackupPolicy response = netAppClient.GetBackupPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicyAsync</summary>
        public async Task GetBackupPolicyAsync()
        {
            // Snippet: GetBackupPolicyAsync(string, CallSettings)
            // Additional: GetBackupPolicyAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPolicies/[BACKUP_POLICY]";
            // Make the request
            BackupPolicy response = await netAppClient.GetBackupPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicy</summary>
        public void GetBackupPolicyResourceNames()
        {
            // Snippet: GetBackupPolicy(BackupPolicyName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupPolicyName name = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]");
            // Make the request
            BackupPolicy response = netAppClient.GetBackupPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPolicyAsync</summary>
        public async Task GetBackupPolicyResourceNamesAsync()
        {
            // Snippet: GetBackupPolicyAsync(BackupPolicyName, CallSettings)
            // Additional: GetBackupPolicyAsync(BackupPolicyName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupPolicyName name = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]");
            // Make the request
            BackupPolicy response = await netAppClient.GetBackupPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackupPolicies</summary>
        public void ListBackupPoliciesRequestObject()
        {
            // Snippet: ListBackupPolicies(ListBackupPoliciesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPoliciesAsync</summary>
        public async Task ListBackupPoliciesRequestObjectAsync()
        {
            // Snippet: ListBackupPoliciesAsync(ListBackupPoliciesRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupPoliciesRequest request = new ListBackupPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPolicies</summary>
        public void ListBackupPolicies()
        {
            // Snippet: ListBackupPolicies(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPoliciesAsync</summary>
        public async Task ListBackupPoliciesAsync()
        {
            // Snippet: ListBackupPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPolicies</summary>
        public void ListBackupPoliciesResourceNames()
        {
            // Snippet: ListBackupPolicies(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPoliciesAsync</summary>
        public async Task ListBackupPoliciesResourceNamesAsync()
        {
            // Snippet: ListBackupPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupPoliciesResponse, BackupPolicy> response = netAppClient.ListBackupPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPolicy</summary>
        public void UpdateBackupPolicyRequestObject()
        {
            // Snippet: UpdateBackupPolicy(UpdateBackupPolicyRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            UpdateBackupPolicyRequest request = new UpdateBackupPolicyRequest
            {
                UpdateMask = new FieldMask(),
                BackupPolicy = new BackupPolicy(),
            };
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = netAppClient.UpdateBackupPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPolicyAsync</summary>
        public async Task UpdateBackupPolicyRequestObjectAsync()
        {
            // Snippet: UpdateBackupPolicyAsync(UpdateBackupPolicyRequest, CallSettings)
            // Additional: UpdateBackupPolicyAsync(UpdateBackupPolicyRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupPolicyRequest request = new UpdateBackupPolicyRequest
            {
                UpdateMask = new FieldMask(),
                BackupPolicy = new BackupPolicy(),
            };
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = await netAppClient.UpdateBackupPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPolicy</summary>
        public void UpdateBackupPolicy()
        {
            // Snippet: UpdateBackupPolicy(BackupPolicy, FieldMask, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupPolicy backupPolicy = new BackupPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = netAppClient.UpdateBackupPolicy(backupPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = netAppClient.PollOnceUpdateBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupPolicyAsync</summary>
        public async Task UpdateBackupPolicyAsync()
        {
            // Snippet: UpdateBackupPolicyAsync(BackupPolicy, FieldMask, CallSettings)
            // Additional: UpdateBackupPolicyAsync(BackupPolicy, FieldMask, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupPolicy backupPolicy = new BackupPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupPolicy, OperationMetadata> response = await netAppClient.UpdateBackupPolicyAsync(backupPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPolicy, OperationMetadata> retrievedResponse = await netAppClient.PollOnceUpdateBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicy</summary>
        public void DeleteBackupPolicyRequestObject()
        {
            // Snippet: DeleteBackupPolicy(DeleteBackupPolicyRequest, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            DeleteBackupPolicyRequest request = new DeleteBackupPolicyRequest
            {
                BackupPolicyName = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicyAsync</summary>
        public async Task DeleteBackupPolicyRequestObjectAsync()
        {
            // Snippet: DeleteBackupPolicyAsync(DeleteBackupPolicyRequest, CallSettings)
            // Additional: DeleteBackupPolicyAsync(DeleteBackupPolicyRequest, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupPolicyRequest request = new DeleteBackupPolicyRequest
            {
                BackupPolicyName = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicy</summary>
        public void DeleteBackupPolicy()
        {
            // Snippet: DeleteBackupPolicy(string, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPolicies/[BACKUP_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicyAsync</summary>
        public async Task DeleteBackupPolicyAsync()
        {
            // Snippet: DeleteBackupPolicyAsync(string, CallSettings)
            // Additional: DeleteBackupPolicyAsync(string, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPolicies/[BACKUP_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicy</summary>
        public void DeleteBackupPolicyResourceNames()
        {
            // Snippet: DeleteBackupPolicy(BackupPolicyName, CallSettings)
            // Create client
            NetAppClient netAppClient = NetAppClient.Create();
            // Initialize request argument(s)
            BackupPolicyName name = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = netAppClient.DeleteBackupPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = netAppClient.PollOnceDeleteBackupPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPolicyAsync</summary>
        public async Task DeleteBackupPolicyResourceNamesAsync()
        {
            // Snippet: DeleteBackupPolicyAsync(BackupPolicyName, CallSettings)
            // Additional: DeleteBackupPolicyAsync(BackupPolicyName, CancellationToken)
            // Create client
            NetAppClient netAppClient = await NetAppClient.CreateAsync();
            // Initialize request argument(s)
            BackupPolicyName name = BackupPolicyName.FromProjectLocationBackupPolicy("[PROJECT]", "[LOCATION]", "[BACKUP_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await netAppClient.DeleteBackupPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await netAppClient.PollOnceDeleteBackupPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
