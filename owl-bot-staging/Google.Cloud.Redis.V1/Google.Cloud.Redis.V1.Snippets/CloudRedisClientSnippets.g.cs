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
    using Google.Cloud.Redis.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudRedisClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstances(request);

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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstancesAsync(request);

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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstances(parent);

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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstancesAsync(parent);

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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstances(parent);

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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = cloudRedisClient.ListInstancesAsync(parent);

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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = cloudRedisClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = cloudRedisClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = cloudRedisClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthString</summary>
        public void GetInstanceAuthStringRequestObject()
        {
            // Snippet: GetInstanceAuthString(GetInstanceAuthStringRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            InstanceAuthString response = cloudRedisClient.GetInstanceAuthString(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthStringAsync</summary>
        public async Task GetInstanceAuthStringRequestObjectAsync()
        {
            // Snippet: GetInstanceAuthStringAsync(GetInstanceAuthStringRequest, CallSettings)
            // Additional: GetInstanceAuthStringAsync(GetInstanceAuthStringRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceAuthStringRequest request = new GetInstanceAuthStringRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            InstanceAuthString response = await cloudRedisClient.GetInstanceAuthStringAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthString</summary>
        public void GetInstanceAuthString()
        {
            // Snippet: GetInstanceAuthString(string, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            InstanceAuthString response = cloudRedisClient.GetInstanceAuthString(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthStringAsync</summary>
        public async Task GetInstanceAuthStringAsync()
        {
            // Snippet: GetInstanceAuthStringAsync(string, CallSettings)
            // Additional: GetInstanceAuthStringAsync(string, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            InstanceAuthString response = await cloudRedisClient.GetInstanceAuthStringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthString</summary>
        public void GetInstanceAuthStringResourceNames()
        {
            // Snippet: GetInstanceAuthString(InstanceName, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            InstanceAuthString response = cloudRedisClient.GetInstanceAuthString(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAuthStringAsync</summary>
        public async Task GetInstanceAuthStringResourceNamesAsync()
        {
            // Snippet: GetInstanceAuthStringAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAuthStringAsync(InstanceName, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            InstanceAuthString response = await cloudRedisClient.GetInstanceAuthStringAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceCreateInstance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceCreateInstanceAsync(operationName);
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
            // Snippet: CreateInstance(string, string, Instance, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.CreateInstance(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceCreateInstance(operationName);
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
            // Snippet: CreateInstanceAsync(string, string, Instance, CallSettings)
            // Additional: CreateInstanceAsync(string, string, Instance, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.CreateInstanceAsync(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceCreateInstanceAsync(operationName);
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
            // Snippet: CreateInstance(LocationName, string, Instance, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.CreateInstance(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceCreateInstance(operationName);
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
            // Snippet: CreateInstanceAsync(LocationName, string, Instance, CallSettings)
            // Additional: CreateInstanceAsync(LocationName, string, Instance, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string instanceId = "";
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.CreateInstanceAsync(parent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceCreateInstanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceUpdateInstance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceUpdateInstanceAsync(operationName);
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
            // Snippet: UpdateInstance(FieldMask, Instance, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.UpdateInstance(updateMask, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceUpdateInstance(operationName);
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
            // Snippet: UpdateInstanceAsync(FieldMask, Instance, CallSettings)
            // Additional: UpdateInstanceAsync(FieldMask, Instance, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            Instance instance = new Instance();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.UpdateInstanceAsync(updateMask, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstanceRequestObject()
        {
            // Snippet: UpgradeInstance(UpgradeInstanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            UpgradeInstanceRequest request = new UpgradeInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RedisVersion = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.UpgradeInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceUpgradeInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceAsync</summary>
        public async Task UpgradeInstanceRequestObjectAsync()
        {
            // Snippet: UpgradeInstanceAsync(UpgradeInstanceRequest, CallSettings)
            // Additional: UpgradeInstanceAsync(UpgradeInstanceRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeInstanceRequest request = new UpgradeInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RedisVersion = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.UpgradeInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceUpgradeInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstance()
        {
            // Snippet: UpgradeInstance(string, string, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string redisVersion = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.UpgradeInstance(name, redisVersion);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceUpgradeInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceAsync</summary>
        public async Task UpgradeInstanceAsync()
        {
            // Snippet: UpgradeInstanceAsync(string, string, CallSettings)
            // Additional: UpgradeInstanceAsync(string, string, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string redisVersion = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.UpgradeInstanceAsync(name, redisVersion);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceUpgradeInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstanceResourceNames()
        {
            // Snippet: UpgradeInstance(InstanceName, string, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            string redisVersion = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.UpgradeInstance(name, redisVersion);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceUpgradeInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceAsync</summary>
        public async Task UpgradeInstanceResourceNamesAsync()
        {
            // Snippet: UpgradeInstanceAsync(InstanceName, string, CallSettings)
            // Additional: UpgradeInstanceAsync(InstanceName, string, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            string redisVersion = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.UpgradeInstanceAsync(name, redisVersion);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceUpgradeInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportInstance</summary>
        public void ImportInstanceRequestObject()
        {
            // Snippet: ImportInstance(ImportInstanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            ImportInstanceRequest request = new ImportInstanceRequest
            {
                Name = "",
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.ImportInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceImportInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportInstanceAsync</summary>
        public async Task ImportInstanceRequestObjectAsync()
        {
            // Snippet: ImportInstanceAsync(ImportInstanceRequest, CallSettings)
            // Additional: ImportInstanceAsync(ImportInstanceRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            ImportInstanceRequest request = new ImportInstanceRequest
            {
                Name = "",
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.ImportInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceImportInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportInstance</summary>
        public void ImportInstance()
        {
            // Snippet: ImportInstance(string, InputConfig, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "";
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.ImportInstance(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceImportInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportInstanceAsync</summary>
        public async Task ImportInstanceAsync()
        {
            // Snippet: ImportInstanceAsync(string, InputConfig, CallSettings)
            // Additional: ImportInstanceAsync(string, InputConfig, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            InputConfig inputConfig = new InputConfig();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.ImportInstanceAsync(name, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceImportInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInstance</summary>
        public void ExportInstanceRequestObject()
        {
            // Snippet: ExportInstance(ExportInstanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            ExportInstanceRequest request = new ExportInstanceRequest
            {
                Name = "",
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.ExportInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceExportInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInstanceAsync</summary>
        public async Task ExportInstanceRequestObjectAsync()
        {
            // Snippet: ExportInstanceAsync(ExportInstanceRequest, CallSettings)
            // Additional: ExportInstanceAsync(ExportInstanceRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            ExportInstanceRequest request = new ExportInstanceRequest
            {
                Name = "",
                OutputConfig = new OutputConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.ExportInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceExportInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInstance</summary>
        public void ExportInstance()
        {
            // Snippet: ExportInstance(string, OutputConfig, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.ExportInstance(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceExportInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInstanceAsync</summary>
        public async Task ExportInstanceAsync()
        {
            // Snippet: ExportInstanceAsync(string, OutputConfig, CallSettings)
            // Additional: ExportInstanceAsync(string, OutputConfig, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.ExportInstanceAsync(name, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceExportInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstanceRequestObject()
        {
            // Snippet: FailoverInstance(FailoverInstanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            FailoverInstanceRequest request = new FailoverInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.FailoverInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceRequestObjectAsync()
        {
            // Snippet: FailoverInstanceAsync(FailoverInstanceRequest, CallSettings)
            // Additional: FailoverInstanceAsync(FailoverInstanceRequest, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            FailoverInstanceRequest request = new FailoverInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.FailoverInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstance()
        {
            // Snippet: FailoverInstance(string, FailoverInstanceRequest.Types.DataProtectionMode, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.FailoverInstance(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceAsync()
        {
            // Snippet: FailoverInstanceAsync(string, FailoverInstanceRequest.Types.DataProtectionMode, CallSettings)
            // Additional: FailoverInstanceAsync(string, FailoverInstanceRequest.Types.DataProtectionMode, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.FailoverInstanceAsync(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstanceResourceNames()
        {
            // Snippet: FailoverInstance(InstanceName, FailoverInstanceRequest.Types.DataProtectionMode, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.FailoverInstance(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceResourceNamesAsync()
        {
            // Snippet: FailoverInstanceAsync(InstanceName, FailoverInstanceRequest.Types.DataProtectionMode, CallSettings)
            // Additional: FailoverInstanceAsync(InstanceName, FailoverInstanceRequest.Types.DataProtectionMode, CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FailoverInstanceRequest.Types.DataProtectionMode dataProtectionMode = FailoverInstanceRequest.Types.DataProtectionMode.Unspecified;
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.FailoverInstanceAsync(name, dataProtectionMode);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceFailoverInstanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudRedisClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceDeleteInstance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudRedisClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceDeleteInstanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudRedisClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceDeleteInstance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudRedisClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceDeleteInstanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudRedisClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceDeleteInstance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudRedisClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenance</summary>
        public void RescheduleMaintenanceRequestObject()
        {
            // Snippet: RescheduleMaintenance(RescheduleMaintenanceRequest, CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified,
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.RescheduleMaintenance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceRescheduleMaintenance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified,
                ScheduleTime = new Timestamp(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.RescheduleMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceRescheduleMaintenanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.RescheduleMaintenance(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceRescheduleMaintenance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceRescheduleMaintenanceAsync(operationName);
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
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = cloudRedisClient.RescheduleMaintenance(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = cloudRedisClient.PollOnceRescheduleMaintenance(operationName);
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
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.RescheduleType rescheduleType = RescheduleMaintenanceRequest.Types.RescheduleType.Unspecified;
            Timestamp scheduleTime = new Timestamp();
            // Make the request
            Operation<Instance, OperationMetadata> response = await cloudRedisClient.RescheduleMaintenanceAsync(name, rescheduleType, scheduleTime);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await cloudRedisClient.PollOnceRescheduleMaintenanceAsync(operationName);
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
