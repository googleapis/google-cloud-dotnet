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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Lustre.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLustreClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstances(request);

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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInstancesResponse page in response.AsRawResponses())
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstances(parent);

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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInstancesResponse page in response.AsRawResponses())
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstances(parent);

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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = lustreClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInstancesResponse page in response.AsRawResponses())
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = lustreClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await lustreClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = lustreClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await lustreClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = lustreClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await lustreClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceUpdateInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceUpdateInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.UpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceUpdateInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.UpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceUpdateInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteInstance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteInstanceAsync(operationName);
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
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Reschedule = new RescheduleMaintenanceRequest.Types.Reschedule(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.RescheduleMaintenance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceRescheduleMaintenance(operationName);
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
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            RescheduleMaintenanceRequest request = new RescheduleMaintenanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Reschedule = new RescheduleMaintenanceRequest.Types.Reschedule(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.RescheduleMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceRescheduleMaintenanceAsync(operationName);
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
            // Snippet: RescheduleMaintenance(string, RescheduleMaintenanceRequest.Types.Reschedule, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.Reschedule reschedule = new RescheduleMaintenanceRequest.Types.Reschedule();
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.RescheduleMaintenance(name, reschedule);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceRescheduleMaintenance(operationName);
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
            // Snippet: RescheduleMaintenanceAsync(string, RescheduleMaintenanceRequest.Types.Reschedule, CallSettings)
            // Additional: RescheduleMaintenanceAsync(string, RescheduleMaintenanceRequest.Types.Reschedule, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            RescheduleMaintenanceRequest.Types.Reschedule reschedule = new RescheduleMaintenanceRequest.Types.Reschedule();
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.RescheduleMaintenanceAsync(name, reschedule);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceRescheduleMaintenanceAsync(operationName);
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
            // Snippet: RescheduleMaintenance(InstanceName, RescheduleMaintenanceRequest.Types.Reschedule, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.Reschedule reschedule = new RescheduleMaintenanceRequest.Types.Reschedule();
            // Make the request
            Operation<Instance, OperationMetadata> response = lustreClient.RescheduleMaintenance(name, reschedule);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = lustreClient.PollOnceRescheduleMaintenance(operationName);
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
            // Snippet: RescheduleMaintenanceAsync(InstanceName, RescheduleMaintenanceRequest.Types.Reschedule, CallSettings)
            // Additional: RescheduleMaintenanceAsync(InstanceName, RescheduleMaintenanceRequest.Types.Reschedule, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            RescheduleMaintenanceRequest.Types.Reschedule reschedule = new RescheduleMaintenanceRequest.Types.Reschedule();
            // Make the request
            Operation<Instance, OperationMetadata> response = await lustreClient.RescheduleMaintenanceAsync(name, reschedule);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await lustreClient.PollOnceRescheduleMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataRequestObject()
        {
            // Snippet: ImportData(ImportDataRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                GcsPath = new GcsPath(),
                LustrePath = new LustrePath(),
                RequestId = "",
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = lustreClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = lustreClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataRequestObjectAsync()
        {
            // Snippet: ImportDataAsync(ImportDataRequest, CallSettings)
            // Additional: ImportDataAsync(ImportDataRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                GcsPath = new GcsPath(),
                LustrePath = new LustrePath(),
                RequestId = "",
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = await lustreClient.ImportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = await lustreClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportData()
        {
            // Snippet: ImportData(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = lustreClient.ImportData(name);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = lustreClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataAsync()
        {
            // Snippet: ImportDataAsync(string, CallSettings)
            // Additional: ImportDataAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = await lustreClient.ImportDataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = await lustreClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportData</summary>
        public void ImportDataResourceNames()
        {
            // Snippet: ImportData(InstanceName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = lustreClient.ImportData(name);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = lustreClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDataAsync</summary>
        public async Task ImportDataResourceNamesAsync()
        {
            // Snippet: ImportDataAsync(InstanceName, CallSettings)
            // Additional: ImportDataAsync(InstanceName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = await lustreClient.ImportDataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = await lustreClient.PollOnceImportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportData</summary>
        public void ExportDataRequestObject()
        {
            // Snippet: ExportData(ExportDataRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                LustrePath = new LustrePath(),
                GcsPath = new GcsPath(),
                RequestId = "",
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            Operation<ExportDataResponse, ExportDataMetadata> response = lustreClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataMetadata> retrievedResponse = lustreClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDataAsync</summary>
        public async Task ExportDataRequestObjectAsync()
        {
            // Snippet: ExportDataAsync(ExportDataRequest, CallSettings)
            // Additional: ExportDataAsync(ExportDataRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                LustrePath = new LustrePath(),
                GcsPath = new GcsPath(),
                RequestId = "",
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            Operation<ExportDataResponse, ExportDataMetadata> response = await lustreClient.ExportDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataResponse, ExportDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataResponse, ExportDataMetadata> retrievedResponse = await lustreClient.PollOnceExportDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirror</summary>
        public void CreateMirrorRequestObject()
        {
            // Snippet: CreateMirror(CreateMirrorRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            CreateMirrorRequest request = new CreateMirrorRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                MirrorId = "",
                Mirror = new Mirror(),
                RequestId = "",
            };
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = lustreClient.CreateMirror(request);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = lustreClient.PollOnceCreateMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirrorAsync</summary>
        public async Task CreateMirrorRequestObjectAsync()
        {
            // Snippet: CreateMirrorAsync(CreateMirrorRequest, CallSettings)
            // Additional: CreateMirrorAsync(CreateMirrorRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            CreateMirrorRequest request = new CreateMirrorRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                MirrorId = "",
                Mirror = new Mirror(),
                RequestId = "",
            };
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = await lustreClient.CreateMirrorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = await lustreClient.PollOnceCreateMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirror</summary>
        public void CreateMirror()
        {
            // Snippet: CreateMirror(string, Mirror, string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Mirror mirror = new Mirror();
            string mirrorId = "";
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = lustreClient.CreateMirror(parent, mirror, mirrorId);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = lustreClient.PollOnceCreateMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirrorAsync</summary>
        public async Task CreateMirrorAsync()
        {
            // Snippet: CreateMirrorAsync(string, Mirror, string, CallSettings)
            // Additional: CreateMirrorAsync(string, Mirror, string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Mirror mirror = new Mirror();
            string mirrorId = "";
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = await lustreClient.CreateMirrorAsync(parent, mirror, mirrorId);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = await lustreClient.PollOnceCreateMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirror</summary>
        public void CreateMirrorResourceNames()
        {
            // Snippet: CreateMirror(InstanceName, Mirror, string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Mirror mirror = new Mirror();
            string mirrorId = "";
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = lustreClient.CreateMirror(parent, mirror, mirrorId);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = lustreClient.PollOnceCreateMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirrorAsync</summary>
        public async Task CreateMirrorResourceNamesAsync()
        {
            // Snippet: CreateMirrorAsync(InstanceName, Mirror, string, CallSettings)
            // Additional: CreateMirrorAsync(InstanceName, Mirror, string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Mirror mirror = new Mirror();
            string mirrorId = "";
            // Make the request
            Operation<Mirror, CreateMirrorMetadata> response = await lustreClient.CreateMirrorAsync(parent, mirror, mirrorId);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, CreateMirrorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, CreateMirrorMetadata> retrievedResponse = await lustreClient.PollOnceCreateMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirror</summary>
        public void UpdateMirrorRequestObject()
        {
            // Snippet: UpdateMirror(UpdateMirrorRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            UpdateMirrorRequest request = new UpdateMirrorRequest
            {
                Mirror = new Mirror(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Mirror, OperationMetadata> response = lustreClient.UpdateMirror(request);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, OperationMetadata> retrievedResponse = lustreClient.PollOnceUpdateMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirrorAsync</summary>
        public async Task UpdateMirrorRequestObjectAsync()
        {
            // Snippet: UpdateMirrorAsync(UpdateMirrorRequest, CallSettings)
            // Additional: UpdateMirrorAsync(UpdateMirrorRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMirrorRequest request = new UpdateMirrorRequest
            {
                Mirror = new Mirror(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Mirror, OperationMetadata> response = await lustreClient.UpdateMirrorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, OperationMetadata> retrievedResponse = await lustreClient.PollOnceUpdateMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirror</summary>
        public void UpdateMirror()
        {
            // Snippet: UpdateMirror(Mirror, FieldMask, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            Mirror mirror = new Mirror();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Mirror, OperationMetadata> response = lustreClient.UpdateMirror(mirror, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, OperationMetadata> retrievedResponse = lustreClient.PollOnceUpdateMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirrorAsync</summary>
        public async Task UpdateMirrorAsync()
        {
            // Snippet: UpdateMirrorAsync(Mirror, FieldMask, CallSettings)
            // Additional: UpdateMirrorAsync(Mirror, FieldMask, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            Mirror mirror = new Mirror();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Mirror, OperationMetadata> response = await lustreClient.UpdateMirrorAsync(mirror, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Mirror, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Mirror result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Mirror, OperationMetadata> retrievedResponse = await lustreClient.PollOnceUpdateMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Mirror retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirror</summary>
        public void DeleteMirrorRequestObject()
        {
            // Snippet: DeleteMirror(DeleteMirrorRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            DeleteMirrorRequest request = new DeleteMirrorRequest
            {
                MirrorName = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteMirror(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirrorAsync</summary>
        public async Task DeleteMirrorRequestObjectAsync()
        {
            // Snippet: DeleteMirrorAsync(DeleteMirrorRequest, CallSettings)
            // Additional: DeleteMirrorAsync(DeleteMirrorRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMirrorRequest request = new DeleteMirrorRequest
            {
                MirrorName = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteMirrorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirror</summary>
        public void DeleteMirror()
        {
            // Snippet: DeleteMirror(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/mirrors/[MIRROR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteMirror(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirrorAsync</summary>
        public async Task DeleteMirrorAsync()
        {
            // Snippet: DeleteMirrorAsync(string, CallSettings)
            // Additional: DeleteMirrorAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/mirrors/[MIRROR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteMirrorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirror</summary>
        public void DeleteMirrorResourceNames()
        {
            // Snippet: DeleteMirror(MirrorName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            MirrorName name = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteMirror(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteMirror(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirrorAsync</summary>
        public async Task DeleteMirrorResourceNamesAsync()
        {
            // Snippet: DeleteMirrorAsync(MirrorName, CallSettings)
            // Additional: DeleteMirrorAsync(MirrorName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            MirrorName name = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteMirrorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteMirrorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetMirror</summary>
        public void GetMirrorRequestObject()
        {
            // Snippet: GetMirror(GetMirrorRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            GetMirrorRequest request = new GetMirrorRequest
            {
                MirrorName = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]"),
            };
            // Make the request
            Mirror response = lustreClient.GetMirror(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirrorAsync</summary>
        public async Task GetMirrorRequestObjectAsync()
        {
            // Snippet: GetMirrorAsync(GetMirrorRequest, CallSettings)
            // Additional: GetMirrorAsync(GetMirrorRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            GetMirrorRequest request = new GetMirrorRequest
            {
                MirrorName = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]"),
            };
            // Make the request
            Mirror response = await lustreClient.GetMirrorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirror</summary>
        public void GetMirror()
        {
            // Snippet: GetMirror(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/mirrors/[MIRROR]";
            // Make the request
            Mirror response = lustreClient.GetMirror(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirrorAsync</summary>
        public async Task GetMirrorAsync()
        {
            // Snippet: GetMirrorAsync(string, CallSettings)
            // Additional: GetMirrorAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/mirrors/[MIRROR]";
            // Make the request
            Mirror response = await lustreClient.GetMirrorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirror</summary>
        public void GetMirrorResourceNames()
        {
            // Snippet: GetMirror(MirrorName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            MirrorName name = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]");
            // Make the request
            Mirror response = lustreClient.GetMirror(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirrorAsync</summary>
        public async Task GetMirrorResourceNamesAsync()
        {
            // Snippet: GetMirrorAsync(MirrorName, CallSettings)
            // Additional: GetMirrorAsync(MirrorName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            MirrorName name = MirrorName.FromProjectLocationInstanceMirror("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[MIRROR]");
            // Make the request
            Mirror response = await lustreClient.GetMirrorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMirrors</summary>
        public void ListMirrorsRequestObject()
        {
            // Snippet: ListMirrors(ListMirrorsRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            ListMirrorsRequest request = new ListMirrorsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirrorsAsync</summary>
        public async Task ListMirrorsRequestObjectAsync()
        {
            // Snippet: ListMirrorsAsync(ListMirrorsRequest, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            ListMirrorsRequest request = new ListMirrorsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirrors</summary>
        public void ListMirrors()
        {
            // Snippet: ListMirrors(string, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirrorsAsync</summary>
        public async Task ListMirrorsAsync()
        {
            // Snippet: ListMirrorsAsync(string, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirrors</summary>
        public void ListMirrorsResourceNames()
        {
            // Snippet: ListMirrors(InstanceName, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirrorsAsync</summary>
        public async Task ListMirrorsResourceNamesAsync()
        {
            // Snippet: ListMirrorsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListMirrorsResponse, Mirror> response = lustreClient.ListMirrorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Mirror item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Mirror item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Mirror> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Mirror item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicy</summary>
        public void CreateDirectoryPolicyRequestObject()
        {
            // Snippet: CreateDirectoryPolicy(CreateDirectoryPolicyRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            CreateDirectoryPolicyRequest request = new CreateDirectoryPolicyRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DirectoryPolicyId = "",
                DirectoryPolicy = new DirectoryPolicy(),
            };
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = lustreClient.CreateDirectoryPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicyAsync</summary>
        public async Task CreateDirectoryPolicyRequestObjectAsync()
        {
            // Snippet: CreateDirectoryPolicyAsync(CreateDirectoryPolicyRequest, CallSettings)
            // Additional: CreateDirectoryPolicyAsync(CreateDirectoryPolicyRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            CreateDirectoryPolicyRequest request = new CreateDirectoryPolicyRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DirectoryPolicyId = "",
                DirectoryPolicy = new DirectoryPolicy(),
            };
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = await lustreClient.CreateDirectoryPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicy</summary>
        public void CreateDirectoryPolicy()
        {
            // Snippet: CreateDirectoryPolicy(string, DirectoryPolicy, string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DirectoryPolicy directoryPolicy = new DirectoryPolicy();
            string directoryPolicyId = "";
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = lustreClient.CreateDirectoryPolicy(parent, directoryPolicy, directoryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicyAsync</summary>
        public async Task CreateDirectoryPolicyAsync()
        {
            // Snippet: CreateDirectoryPolicyAsync(string, DirectoryPolicy, string, CallSettings)
            // Additional: CreateDirectoryPolicyAsync(string, DirectoryPolicy, string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DirectoryPolicy directoryPolicy = new DirectoryPolicy();
            string directoryPolicyId = "";
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = await lustreClient.CreateDirectoryPolicyAsync(parent, directoryPolicy, directoryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicy</summary>
        public void CreateDirectoryPolicyResourceNames()
        {
            // Snippet: CreateDirectoryPolicy(InstanceName, DirectoryPolicy, string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DirectoryPolicy directoryPolicy = new DirectoryPolicy();
            string directoryPolicyId = "";
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = lustreClient.CreateDirectoryPolicy(parent, directoryPolicy, directoryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = lustreClient.PollOnceCreateDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDirectoryPolicyAsync</summary>
        public async Task CreateDirectoryPolicyResourceNamesAsync()
        {
            // Snippet: CreateDirectoryPolicyAsync(InstanceName, DirectoryPolicy, string, CallSettings)
            // Additional: CreateDirectoryPolicyAsync(InstanceName, DirectoryPolicy, string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DirectoryPolicy directoryPolicy = new DirectoryPolicy();
            string directoryPolicyId = "";
            // Make the request
            Operation<DirectoryPolicy, OperationMetadata> response = await lustreClient.CreateDirectoryPolicyAsync(parent, directoryPolicy, directoryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DirectoryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DirectoryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DirectoryPolicy, OperationMetadata> retrievedResponse = await lustreClient.PollOnceCreateDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DirectoryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicy</summary>
        public void DeleteDirectoryPolicyRequestObject()
        {
            // Snippet: DeleteDirectoryPolicy(DeleteDirectoryPolicyRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            DeleteDirectoryPolicyRequest request = new DeleteDirectoryPolicyRequest
            {
                DirectoryPolicyName = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteDirectoryPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicyAsync</summary>
        public async Task DeleteDirectoryPolicyRequestObjectAsync()
        {
            // Snippet: DeleteDirectoryPolicyAsync(DeleteDirectoryPolicyRequest, CallSettings)
            // Additional: DeleteDirectoryPolicyAsync(DeleteDirectoryPolicyRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDirectoryPolicyRequest request = new DeleteDirectoryPolicyRequest
            {
                DirectoryPolicyName = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteDirectoryPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicy</summary>
        public void DeleteDirectoryPolicy()
        {
            // Snippet: DeleteDirectoryPolicy(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/directoryPolicies/[DIRECTORY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteDirectoryPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicyAsync</summary>
        public async Task DeleteDirectoryPolicyAsync()
        {
            // Snippet: DeleteDirectoryPolicyAsync(string, CallSettings)
            // Additional: DeleteDirectoryPolicyAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/directoryPolicies/[DIRECTORY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteDirectoryPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicy</summary>
        public void DeleteDirectoryPolicyResourceNames()
        {
            // Snippet: DeleteDirectoryPolicy(DirectoryPolicyName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            DirectoryPolicyName name = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lustreClient.DeleteDirectoryPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lustreClient.PollOnceDeleteDirectoryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDirectoryPolicyAsync</summary>
        public async Task DeleteDirectoryPolicyResourceNamesAsync()
        {
            // Snippet: DeleteDirectoryPolicyAsync(DirectoryPolicyName, CallSettings)
            // Additional: DeleteDirectoryPolicyAsync(DirectoryPolicyName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            DirectoryPolicyName name = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await lustreClient.DeleteDirectoryPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await lustreClient.PollOnceDeleteDirectoryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicy</summary>
        public void GetDirectoryPolicyRequestObject()
        {
            // Snippet: GetDirectoryPolicy(GetDirectoryPolicyRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            GetDirectoryPolicyRequest request = new GetDirectoryPolicyRequest
            {
                DirectoryPolicyName = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]"),
            };
            // Make the request
            DirectoryPolicy response = lustreClient.GetDirectoryPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicyAsync</summary>
        public async Task GetDirectoryPolicyRequestObjectAsync()
        {
            // Snippet: GetDirectoryPolicyAsync(GetDirectoryPolicyRequest, CallSettings)
            // Additional: GetDirectoryPolicyAsync(GetDirectoryPolicyRequest, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            GetDirectoryPolicyRequest request = new GetDirectoryPolicyRequest
            {
                DirectoryPolicyName = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]"),
            };
            // Make the request
            DirectoryPolicy response = await lustreClient.GetDirectoryPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicy</summary>
        public void GetDirectoryPolicy()
        {
            // Snippet: GetDirectoryPolicy(string, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/directoryPolicies/[DIRECTORY_POLICY]";
            // Make the request
            DirectoryPolicy response = lustreClient.GetDirectoryPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicyAsync</summary>
        public async Task GetDirectoryPolicyAsync()
        {
            // Snippet: GetDirectoryPolicyAsync(string, CallSettings)
            // Additional: GetDirectoryPolicyAsync(string, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/directoryPolicies/[DIRECTORY_POLICY]";
            // Make the request
            DirectoryPolicy response = await lustreClient.GetDirectoryPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicy</summary>
        public void GetDirectoryPolicyResourceNames()
        {
            // Snippet: GetDirectoryPolicy(DirectoryPolicyName, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            DirectoryPolicyName name = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]");
            // Make the request
            DirectoryPolicy response = lustreClient.GetDirectoryPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDirectoryPolicyAsync</summary>
        public async Task GetDirectoryPolicyResourceNamesAsync()
        {
            // Snippet: GetDirectoryPolicyAsync(DirectoryPolicyName, CallSettings)
            // Additional: GetDirectoryPolicyAsync(DirectoryPolicyName, CancellationToken)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            DirectoryPolicyName name = DirectoryPolicyName.FromProjectLocationInstanceDirectoryPolicy("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DIRECTORY_POLICY]");
            // Make the request
            DirectoryPolicy response = await lustreClient.GetDirectoryPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPolicies</summary>
        public void ListDirectoryPoliciesRequestObject()
        {
            // Snippet: ListDirectoryPolicies(ListDirectoryPoliciesRequest, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            ListDirectoryPoliciesRequest request = new ListDirectoryPoliciesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPoliciesAsync</summary>
        public async Task ListDirectoryPoliciesRequestObjectAsync()
        {
            // Snippet: ListDirectoryPoliciesAsync(ListDirectoryPoliciesRequest, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            ListDirectoryPoliciesRequest request = new ListDirectoryPoliciesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPolicies</summary>
        public void ListDirectoryPolicies()
        {
            // Snippet: ListDirectoryPolicies(string, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPoliciesAsync</summary>
        public async Task ListDirectoryPoliciesAsync()
        {
            // Snippet: ListDirectoryPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPolicies</summary>
        public void ListDirectoryPoliciesResourceNames()
        {
            // Snippet: ListDirectoryPolicies(InstanceName, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = LustreClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDirectoryPoliciesAsync</summary>
        public async Task ListDirectoryPoliciesResourceNamesAsync()
        {
            // Snippet: ListDirectoryPoliciesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            LustreClient lustreClient = await LustreClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDirectoryPoliciesResponse, DirectoryPolicy> response = lustreClient.ListDirectoryPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DirectoryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDirectoryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DirectoryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DirectoryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DirectoryPolicy item in singlePage)
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
