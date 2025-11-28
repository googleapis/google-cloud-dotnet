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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Memorystore.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMemorystoreClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(LocationName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = memorystoreClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = memorystoreClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await memorystoreClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = memorystoreClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await memorystoreClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = memorystoreClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await memorystoreClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string, Instance, string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, Instance, string, CallSettings)
            // Additional: CreateInstanceAsync(string, Instance, string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceResourceNames()
        {
            // Snippet: CreateInstance(LocationName, Instance, string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceResourceNamesAsync()
        {
            // Snippet: CreateInstanceAsync(LocationName, Instance, string, CallSettings)
            // Additional: CreateInstanceAsync(LocationName, Instance, string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstanceRequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceRequestObjectAsync()
        {
            // Snippet: UpdateInstanceAsync(UpdateInstanceRequest, CallSettings)
            // Additional: UpdateInstanceAsync(UpdateInstanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(Instance, FieldMask, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.UpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(Instance, FieldMask, CallSettings)
            // Additional: UpdateInstanceAsync(Instance, FieldMask, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.UpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceRequestObjectAsync()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest, CallSettings)
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string, CallSettings)
            // Additional: DeleteInstanceAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceResourceNames()
        {
            // Snippet: DeleteInstance(InstanceName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceResourceNamesAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName, CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthorityRequestObject()
        {
            // Snippet: GetCertificateAuthority(GetCertificateAuthorityRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            CertificateAuthority response = memorystoreClient.GetCertificateAuthority(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(GetCertificateAuthorityRequest, CallSettings)
            // Additional: GetCertificateAuthorityAsync(GetCertificateAuthorityRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            GetCertificateAuthorityRequest request = new GetCertificateAuthorityRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            CertificateAuthority response = await memorystoreClient.GetCertificateAuthorityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthority()
        {
            // Snippet: GetCertificateAuthority(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            CertificateAuthority response = memorystoreClient.GetCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(string, CallSettings)
            // Additional: GetCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            CertificateAuthority response = await memorystoreClient.GetCertificateAuthorityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthority</summary>
        public void GetCertificateAuthorityResourceNames()
        {
            // Snippet: GetCertificateAuthority(InstanceName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            CertificateAuthority response = memorystoreClient.GetCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetCertificateAuthorityAsync</summary>
        public async Task GetCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: GetCertificateAuthorityAsync(InstanceName, CallSettings)
            // Additional: GetCertificateAuthorityAsync(InstanceName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            CertificateAuthority response = await memorystoreClient.GetCertificateAuthorityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenance</summary>
        public void RescheduleMaintenanceRequestObject()
        {
            // Snippet: RescheduleMaintenance(RescheduleMaintenanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified,
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.RescheduleMaintenance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceRescheduleMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenanceAsync</summary>
        public async Task RescheduleMaintenanceRequestObjectAsync()
        {
            // Snippet: RescheduleMaintenanceAsync(RescheduleMaintenanceRequest, CallSettings)
            // Additional: RescheduleMaintenanceAsync(RescheduleMaintenanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified,
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.RescheduleMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceRescheduleMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenance</summary>
        public void RescheduleMaintenance()
        {
            // Snippet: RescheduleMaintenance(string, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.RescheduleMaintenance(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceRescheduleMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenanceAsync</summary>
        public async Task RescheduleMaintenanceAsync()
        {
            // Snippet: RescheduleMaintenanceAsync(string, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CallSettings)
            // Additional: RescheduleMaintenanceAsync(string, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceRescheduleMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenance</summary>
        public void RescheduleMaintenanceResourceNames()
        {
            // Snippet: RescheduleMaintenance(InstanceName, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.RescheduleMaintenance(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceRescheduleMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenanceAsync</summary>
        public async Task RescheduleMaintenanceResourceNamesAsync()
        {
            // Snippet: RescheduleMaintenanceAsync(InstanceName, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CallSettings)
            // Additional: RescheduleMaintenanceAsync(InstanceName, RescheduleMaintenanceRequest.Types.RescheduleType, Timestamp, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceRescheduleMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollections</summary>
        public void ListBackupCollectionsRequestObject()
        {
            // Snippet: ListBackupCollections(ListBackupCollectionsRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupCollection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollectionsAsync</summary>
        public async Task ListBackupCollectionsRequestObjectAsync()
        {
            // Snippet: ListBackupCollectionsAsync(ListBackupCollectionsRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupCollectionsRequest request = new ListBackupCollectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupCollection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollections</summary>
        public void ListBackupCollections()
        {
            // Snippet: ListBackupCollections(string, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupCollection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollectionsAsync</summary>
        public async Task ListBackupCollectionsAsync()
        {
            // Snippet: ListBackupCollectionsAsync(string, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupCollection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollections</summary>
        public void ListBackupCollectionsResourceNames()
        {
            // Snippet: ListBackupCollections(LocationName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupCollection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupCollectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupCollectionsAsync</summary>
        public async Task ListBackupCollectionsResourceNamesAsync()
        {
            // Snippet: ListBackupCollectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupCollectionsResponse, BackupCollection> response = memorystoreClient.ListBackupCollectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupCollection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupCollectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupCollection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupCollection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupCollection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollection</summary>
        public void GetBackupCollectionRequestObject()
        {
            // Snippet: GetBackupCollection(GetBackupCollectionRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            GetBackupCollectionRequest request = new GetBackupCollectionRequest
            {
                BackupCollectionName = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]"),
            };
            // Make the request
            BackupCollection response = memorystoreClient.GetBackupCollection(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollectionAsync</summary>
        public async Task GetBackupCollectionRequestObjectAsync()
        {
            // Snippet: GetBackupCollectionAsync(GetBackupCollectionRequest, CallSettings)
            // Additional: GetBackupCollectionAsync(GetBackupCollectionRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupCollectionRequest request = new GetBackupCollectionRequest
            {
                BackupCollectionName = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]"),
            };
            // Make the request
            BackupCollection response = await memorystoreClient.GetBackupCollectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollection</summary>
        public void GetBackupCollection()
        {
            // Snippet: GetBackupCollection(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]";
            // Make the request
            BackupCollection response = memorystoreClient.GetBackupCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollectionAsync</summary>
        public async Task GetBackupCollectionAsync()
        {
            // Snippet: GetBackupCollectionAsync(string, CallSettings)
            // Additional: GetBackupCollectionAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]";
            // Make the request
            BackupCollection response = await memorystoreClient.GetBackupCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollection</summary>
        public void GetBackupCollectionResourceNames()
        {
            // Snippet: GetBackupCollection(BackupCollectionName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            BackupCollectionName name = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]");
            // Make the request
            BackupCollection response = memorystoreClient.GetBackupCollection(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupCollectionAsync</summary>
        public async Task GetBackupCollectionResourceNamesAsync()
        {
            // Snippet: GetBackupCollectionAsync(BackupCollectionName, CallSettings)
            // Additional: GetBackupCollectionAsync(BackupCollectionName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            BackupCollectionName name = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]");
            // Make the request
            BackupCollection response = await memorystoreClient.GetBackupCollectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]"),
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackups(request);

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
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsBackupCollectionName = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackupsAsync(request);

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
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackups(parent);

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
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackupsAsync(parent);

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
            // Snippet: ListBackups(BackupCollectionName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            BackupCollectionName parent = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackups(parent);

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
            // Snippet: ListBackupsAsync(BackupCollectionName, string, int?, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            BackupCollectionName parent = BackupCollectionName.FromProjectLocationBackupCollection("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = memorystoreClient.ListBackupsAsync(parent);

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

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupRequestObject()
        {
            // Snippet: GetBackup(GetBackupRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = memorystoreClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await memorystoreClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]/backups/[BACKUP]";
            // Make the request
            Backup response = memorystoreClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]/backups/[BACKUP]";
            // Make the request
            Backup response = await memorystoreClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]");
            // Make the request
            Backup response = memorystoreClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]");
            // Make the request
            Backup response = await memorystoreClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteBackup(operationName);
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
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteBackupAsync(operationName);
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
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteBackup(operationName);
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
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupCollections/[BACKUP_COLLECTION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteBackupAsync(operationName);
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
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = memorystoreClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceDeleteBackup(operationName);
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
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await memorystoreClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBackup</summary>
        public void ExportBackupRequestObject()
        {
            // Snippet: ExportBackup(ExportBackupRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            ExportBackupRequest request = new ExportBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
                GcsBucket = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = memorystoreClient.ExportBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceExportBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBackupAsync</summary>
        public async Task ExportBackupRequestObjectAsync()
        {
            // Snippet: ExportBackupAsync(ExportBackupRequest, CallSettings)
            // Additional: ExportBackupAsync(ExportBackupRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            ExportBackupRequest request = new ExportBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupCollectionBackup("[PROJECT]", "[LOCATION]", "[BACKUP_COLLECTION]", "[BACKUP]"),
                GcsBucket = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await memorystoreClient.ExportBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceExportBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstance</summary>
        public void BackupInstanceRequestObject()
        {
            // Snippet: BackupInstance(BackupInstanceRequest, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            BackupInstanceRequest request = new BackupInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Ttl = new Duration(),
                BackupId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.BackupInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceBackupInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstanceAsync</summary>
        public async Task BackupInstanceRequestObjectAsync()
        {
            // Snippet: BackupInstanceAsync(BackupInstanceRequest, CallSettings)
            // Additional: BackupInstanceAsync(BackupInstanceRequest, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            BackupInstanceRequest request = new BackupInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Ttl = new Duration(),
                BackupId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.BackupInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceBackupInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstance</summary>
        public void BackupInstance()
        {
            // Snippet: BackupInstance(string, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.BackupInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceBackupInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstanceAsync</summary>
        public async Task BackupInstanceAsync()
        {
            // Snippet: BackupInstanceAsync(string, CallSettings)
            // Additional: BackupInstanceAsync(string, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.BackupInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceBackupInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstance</summary>
        public void BackupInstanceResourceNames()
        {
            // Snippet: BackupInstance(InstanceName, CallSettings)
            // Create client
            MemorystoreClient memorystoreClient = MemorystoreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = memorystoreClient.BackupInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = memorystoreClient.PollOnceBackupInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BackupInstanceAsync</summary>
        public async Task BackupInstanceResourceNamesAsync()
        {
            // Snippet: BackupInstanceAsync(InstanceName, CallSettings)
            // Additional: BackupInstanceAsync(InstanceName, CancellationToken)
            // Create client
            MemorystoreClient memorystoreClient = await MemorystoreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await memorystoreClient.BackupInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await memorystoreClient.PollOnceBackupInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
