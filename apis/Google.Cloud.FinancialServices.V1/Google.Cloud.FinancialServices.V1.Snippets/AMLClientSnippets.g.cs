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
    using Google.Cloud.FinancialServices.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAMLClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstances(request);

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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstancesAsync(request);

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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstances(parent);

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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstancesAsync(parent);

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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstances(parent);

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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = aMLClient.ListInstancesAsync(parent);

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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = aMLClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await aMLClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = aMLClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await aMLClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = aMLClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await aMLClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = aMLClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await aMLClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = aMLClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await aMLClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = aMLClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await aMLClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = aMLClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await aMLClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = aMLClient.UpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = await aMLClient.UpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteInstanceAsync(operationName);
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
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteInstance(operationName);
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
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredParties</summary>
        public void ImportRegisteredPartiesRequestObject()
        {
            // Snippet: ImportRegisteredParties(ImportRegisteredPartiesRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ImportRegisteredPartiesRequest request = new ImportRegisteredPartiesRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                PartyTables = { "", },
                Mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified,
                ValidateOnly = false,
                LineOfBusiness = LineOfBusiness.Unspecified,
            };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ImportRegisteredParties(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceImportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredPartiesAsync</summary>
        public async Task ImportRegisteredPartiesRequestObjectAsync()
        {
            // Snippet: ImportRegisteredPartiesAsync(ImportRegisteredPartiesRequest, CallSettings)
            // Additional: ImportRegisteredPartiesAsync(ImportRegisteredPartiesRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ImportRegisteredPartiesRequest request = new ImportRegisteredPartiesRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                PartyTables = { "", },
                Mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified,
                ValidateOnly = false,
                LineOfBusiness = LineOfBusiness.Unspecified,
            };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ImportRegisteredPartiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceImportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredParties</summary>
        public void ImportRegisteredParties()
        {
            // Snippet: ImportRegisteredParties(string, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ImportRegisteredPartiesRequest.Types.UpdateMode mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified;
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            IEnumerable<string> partyTables = new string[] { "", };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ImportRegisteredParties(name, mode, lineOfBusiness, partyTables);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceImportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredPartiesAsync</summary>
        public async Task ImportRegisteredPartiesAsync()
        {
            // Snippet: ImportRegisteredPartiesAsync(string, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CallSettings)
            // Additional: ImportRegisteredPartiesAsync(string, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ImportRegisteredPartiesRequest.Types.UpdateMode mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified;
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            IEnumerable<string> partyTables = new string[] { "", };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ImportRegisteredPartiesAsync(name, mode, lineOfBusiness, partyTables);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceImportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredParties</summary>
        public void ImportRegisteredPartiesResourceNames()
        {
            // Snippet: ImportRegisteredParties(InstanceName, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ImportRegisteredPartiesRequest.Types.UpdateMode mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified;
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            IEnumerable<string> partyTables = new string[] { "", };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ImportRegisteredParties(name, mode, lineOfBusiness, partyTables);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceImportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportRegisteredPartiesAsync</summary>
        public async Task ImportRegisteredPartiesResourceNamesAsync()
        {
            // Snippet: ImportRegisteredPartiesAsync(InstanceName, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CallSettings)
            // Additional: ImportRegisteredPartiesAsync(InstanceName, ImportRegisteredPartiesRequest.Types.UpdateMode, LineOfBusiness, IEnumerable<string>, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ImportRegisteredPartiesRequest.Types.UpdateMode mode = ImportRegisteredPartiesRequest.Types.UpdateMode.Unspecified;
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            IEnumerable<string> partyTables = new string[] { "", };
            // Make the request
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ImportRegisteredPartiesAsync(name, mode, lineOfBusiness, partyTables);

            // Poll until the returned long-running operation is complete
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceImportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredParties</summary>
        public void ExportRegisteredPartiesRequestObject()
        {
            // Snippet: ExportRegisteredParties(ExportRegisteredPartiesRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ExportRegisteredPartiesRequest request = new ExportRegisteredPartiesRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Dataset = new BigQueryDestination(),
                LineOfBusiness = LineOfBusiness.Unspecified,
            };
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ExportRegisteredParties(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredPartiesAsync</summary>
        public async Task ExportRegisteredPartiesRequestObjectAsync()
        {
            // Snippet: ExportRegisteredPartiesAsync(ExportRegisteredPartiesRequest, CallSettings)
            // Additional: ExportRegisteredPartiesAsync(ExportRegisteredPartiesRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ExportRegisteredPartiesRequest request = new ExportRegisteredPartiesRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Dataset = new BigQueryDestination(),
                LineOfBusiness = LineOfBusiness.Unspecified,
            };
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ExportRegisteredPartiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredParties</summary>
        public void ExportRegisteredParties()
        {
            // Snippet: ExportRegisteredParties(string, BigQueryDestination, LineOfBusiness, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            BigQueryDestination dataset = new BigQueryDestination();
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ExportRegisteredParties(name, dataset, lineOfBusiness);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredPartiesAsync</summary>
        public async Task ExportRegisteredPartiesAsync()
        {
            // Snippet: ExportRegisteredPartiesAsync(string, BigQueryDestination, LineOfBusiness, CallSettings)
            // Additional: ExportRegisteredPartiesAsync(string, BigQueryDestination, LineOfBusiness, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            BigQueryDestination dataset = new BigQueryDestination();
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ExportRegisteredPartiesAsync(name, dataset, lineOfBusiness);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredParties</summary>
        public void ExportRegisteredPartiesResourceNames()
        {
            // Snippet: ExportRegisteredParties(InstanceName, BigQueryDestination, LineOfBusiness, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            BigQueryDestination dataset = new BigQueryDestination();
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = aMLClient.ExportRegisteredParties(name, dataset, lineOfBusiness);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportRegisteredParties(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportRegisteredPartiesAsync</summary>
        public async Task ExportRegisteredPartiesResourceNamesAsync()
        {
            // Snippet: ExportRegisteredPartiesAsync(InstanceName, BigQueryDestination, LineOfBusiness, CallSettings)
            // Additional: ExportRegisteredPartiesAsync(InstanceName, BigQueryDestination, LineOfBusiness, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            BigQueryDestination dataset = new BigQueryDestination();
            LineOfBusiness lineOfBusiness = LineOfBusiness.Unspecified;
            // Make the request
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> response = await aMLClient.ExportRegisteredPartiesAsync(name, dataset, lineOfBusiness);

            // Poll until the returned long-running operation is complete
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportRegisteredPartiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportRegisteredPartiesResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportRegisteredPartiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportRegisteredPartiesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsRequestObject()
        {
            // Snippet: ListDatasets(ListDatasetsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsRequestObjectAsync()
        {
            // Snippet: ListDatasetsAsync(ListDatasetsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasets()
        {
            // Snippet: ListDatasets(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsAsync()
        {
            // Snippet: ListDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasets</summary>
        public void ListDatasetsResourceNames()
        {
            // Snippet: ListDatasets(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Dataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatasetsAsync</summary>
        public async Task ListDatasetsResourceNamesAsync()
        {
            // Snippet: ListDatasetsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDatasetsResponse, Dataset> response = aMLClient.ListDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Dataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Dataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Dataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Dataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetRequestObject()
        {
            // Snippet: GetDataset(GetDatasetRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]"),
            };
            // Make the request
            Dataset response = aMLClient.GetDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetRequestObjectAsync()
        {
            // Snippet: GetDatasetAsync(GetDatasetRequest, CallSettings)
            // Additional: GetDatasetAsync(GetDatasetRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetRequest request = new GetDatasetRequest
            {
                DatasetName = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]"),
            };
            // Make the request
            Dataset response = await aMLClient.GetDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDataset()
        {
            // Snippet: GetDataset(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/datasets/[DATASET]";
            // Make the request
            Dataset response = aMLClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetAsync()
        {
            // Snippet: GetDatasetAsync(string, CallSettings)
            // Additional: GetDatasetAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/datasets/[DATASET]";
            // Make the request
            Dataset response = await aMLClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataset</summary>
        public void GetDatasetResourceNames()
        {
            // Snippet: GetDataset(DatasetName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]");
            // Make the request
            Dataset response = aMLClient.GetDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetAsync</summary>
        public async Task GetDatasetResourceNamesAsync()
        {
            // Snippet: GetDatasetAsync(DatasetName, CallSettings)
            // Additional: GetDatasetAsync(DatasetName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]");
            // Make the request
            Dataset response = await aMLClient.GetDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetRequestObject()
        {
            // Snippet: CreateDataset(CreateDatasetRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DatasetId = "",
                Dataset = new Dataset(),
                RequestId = "",
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response = aMLClient.CreateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetRequestObjectAsync()
        {
            // Snippet: CreateDatasetAsync(CreateDatasetRequest, CallSettings)
            // Additional: CreateDatasetAsync(CreateDatasetRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatasetRequest request = new CreateDatasetRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DatasetId = "",
                Dataset = new Dataset(),
                RequestId = "",
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response = await aMLClient.CreateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDataset()
        {
            // Snippet: CreateDataset(string, Dataset, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Dataset dataset = new Dataset();
            string datasetId = "";
            // Make the request
            Operation<Dataset, OperationMetadata> response = aMLClient.CreateDataset(parent, dataset, datasetId);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetAsync()
        {
            // Snippet: CreateDatasetAsync(string, Dataset, string, CallSettings)
            // Additional: CreateDatasetAsync(string, Dataset, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Dataset dataset = new Dataset();
            string datasetId = "";
            // Make the request
            Operation<Dataset, OperationMetadata> response = await aMLClient.CreateDatasetAsync(parent, dataset, datasetId);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataset</summary>
        public void CreateDatasetResourceNames()
        {
            // Snippet: CreateDataset(InstanceName, Dataset, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Dataset dataset = new Dataset();
            string datasetId = "";
            // Make the request
            Operation<Dataset, OperationMetadata> response = aMLClient.CreateDataset(parent, dataset, datasetId);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatasetAsync</summary>
        public async Task CreateDatasetResourceNamesAsync()
        {
            // Snippet: CreateDatasetAsync(InstanceName, Dataset, string, CallSettings)
            // Additional: CreateDatasetAsync(InstanceName, Dataset, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Dataset dataset = new Dataset();
            string datasetId = "";
            // Make the request
            Operation<Dataset, OperationMetadata> response = await aMLClient.CreateDatasetAsync(parent, dataset, datasetId);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDatasetRequestObject()
        {
            // Snippet: UpdateDataset(UpdateDatasetRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                UpdateMask = new FieldMask(),
                Dataset = new Dataset(),
                RequestId = "",
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response = aMLClient.UpdateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetRequestObjectAsync()
        {
            // Snippet: UpdateDatasetAsync(UpdateDatasetRequest, CallSettings)
            // Additional: UpdateDatasetAsync(UpdateDatasetRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                UpdateMask = new FieldMask(),
                Dataset = new Dataset(),
                RequestId = "",
            };
            // Make the request
            Operation<Dataset, OperationMetadata> response = await aMLClient.UpdateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset()
        {
            // Snippet: UpdateDataset(Dataset, FieldMask, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, OperationMetadata> response = aMLClient.UpdateDataset(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync()
        {
            // Snippet: UpdateDatasetAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, OperationMetadata> response = await aMLClient.UpdateDatasetAsync(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetRequestObject()
        {
            // Snippet: DeleteDataset(DeleteDatasetRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetRequestObjectAsync()
        {
            // Snippet: DeleteDatasetAsync(DeleteDatasetRequest, CallSettings)
            // Additional: DeleteDatasetAsync(DeleteDatasetRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDatasetRequest request = new DeleteDatasetRequest
            {
                DatasetName = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDataset()
        {
            // Snippet: DeleteDataset(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetAsync()
        {
            // Snippet: DeleteDatasetAsync(string, CallSettings)
            // Additional: DeleteDatasetAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/datasets/[DATASET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataset</summary>
        public void DeleteDatasetResourceNames()
        {
            // Snippet: DeleteDataset(DatasetName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDatasetAsync</summary>
        public async Task DeleteDatasetResourceNamesAsync()
        {
            // Snippet: DeleteDatasetAsync(DatasetName, CallSettings)
            // Additional: DeleteDatasetAsync(DatasetName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName name = DatasetName.FromProjectNumLocationInstanceDataset("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[DATASET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsRequestObject()
        {
            // Snippet: ListModels(ListModelsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = aMLClient.ListModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsRequestObjectAsync()
        {
            // Snippet: ListModelsAsync(ListModelsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = aMLClient.ListModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = aMLClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = aMLClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsResourceNames()
        {
            // Snippet: ListModels(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = aMLClient.ListModels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsResourceNamesAsync()
        {
            // Snippet: ListModelsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = aMLClient.ListModelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelRequestObject()
        {
            // Snippet: GetModel(GetModelRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
            };
            // Make the request
            Model response = aMLClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelRequestObjectAsync()
        {
            // Snippet: GetModelAsync(GetModelRequest, CallSettings)
            // Additional: GetModelAsync(GetModelRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
            };
            // Make the request
            Model response = await aMLClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            // Make the request
            Model response = aMLClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(string, CallSettings)
            // Additional: GetModelAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            // Make the request
            Model response = await aMLClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelResourceNames()
        {
            // Snippet: GetModel(ModelName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            // Make the request
            Model response = aMLClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelResourceNamesAsync()
        {
            // Snippet: GetModelAsync(ModelName, CallSettings)
            // Additional: GetModelAsync(ModelName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            // Make the request
            Model response = await aMLClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelRequestObject()
        {
            // Snippet: CreateModel(CreateModelRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ModelId = "",
                Model = new Model(),
                RequestId = "",
            };
            // Make the request
            Operation<Model, OperationMetadata> response = aMLClient.CreateModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelRequestObjectAsync()
        {
            // Snippet: CreateModelAsync(CreateModelRequest, CallSettings)
            // Additional: CreateModelAsync(CreateModelRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreateModelRequest request = new CreateModelRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ModelId = "",
                Model = new Model(),
                RequestId = "",
            };
            // Make the request
            Operation<Model, OperationMetadata> response = await aMLClient.CreateModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModel()
        {
            // Snippet: CreateModel(string, Model, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Model model = new Model();
            string modelId = "";
            // Make the request
            Operation<Model, OperationMetadata> response = aMLClient.CreateModel(parent, model, modelId);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelAsync()
        {
            // Snippet: CreateModelAsync(string, Model, string, CallSettings)
            // Additional: CreateModelAsync(string, Model, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Model model = new Model();
            string modelId = "";
            // Make the request
            Operation<Model, OperationMetadata> response = await aMLClient.CreateModelAsync(parent, model, modelId);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModel</summary>
        public void CreateModelResourceNames()
        {
            // Snippet: CreateModel(InstanceName, Model, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Model model = new Model();
            string modelId = "";
            // Make the request
            Operation<Model, OperationMetadata> response = aMLClient.CreateModel(parent, model, modelId);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateModelAsync</summary>
        public async Task CreateModelResourceNamesAsync()
        {
            // Snippet: CreateModelAsync(InstanceName, Model, string, CallSettings)
            // Additional: CreateModelAsync(InstanceName, Model, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Model model = new Model();
            string modelId = "";
            // Make the request
            Operation<Model, OperationMetadata> response = await aMLClient.CreateModelAsync(parent, model, modelId);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModelRequestObject()
        {
            // Snippet: UpdateModel(UpdateModelRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                UpdateMask = new FieldMask(),
                Model = new Model(),
                RequestId = "",
            };
            // Make the request
            Operation<Model, OperationMetadata> response = aMLClient.UpdateModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelRequestObjectAsync()
        {
            // Snippet: UpdateModelAsync(UpdateModelRequest, CallSettings)
            // Additional: UpdateModelAsync(UpdateModelRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdateModelRequest request = new UpdateModelRequest
            {
                UpdateMask = new FieldMask(),
                Model = new Model(),
                RequestId = "",
            };
            // Make the request
            Operation<Model, OperationMetadata> response = await aMLClient.UpdateModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModel</summary>
        public void UpdateModel()
        {
            // Snippet: UpdateModel(Model, FieldMask, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Model, OperationMetadata> response = aMLClient.UpdateModel(model, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateModelAsync</summary>
        public async Task UpdateModelAsync()
        {
            // Snippet: UpdateModelAsync(Model, FieldMask, CallSettings)
            // Additional: UpdateModelAsync(Model, FieldMask, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            Model model = new Model();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Model, OperationMetadata> response = await aMLClient.UpdateModelAsync(model, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Model, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Model result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Model, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Model retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadata</summary>
        public void ExportModelMetadataRequestObject()
        {
            // Snippet: ExportModelMetadata(ExportModelMetadataRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ExportModelMetadataRequest request = new ExportModelMetadataRequest
            {
                ModelAsModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = aMLClient.ExportModelMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportModelMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadataAsync</summary>
        public async Task ExportModelMetadataRequestObjectAsync()
        {
            // Snippet: ExportModelMetadataAsync(ExportModelMetadataRequest, CallSettings)
            // Additional: ExportModelMetadataAsync(ExportModelMetadataRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ExportModelMetadataRequest request = new ExportModelMetadataRequest
            {
                ModelAsModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = await aMLClient.ExportModelMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportModelMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadata</summary>
        public void ExportModelMetadata()
        {
            // Snippet: ExportModelMetadata(string, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string model = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = aMLClient.ExportModelMetadata(model, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportModelMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadataAsync</summary>
        public async Task ExportModelMetadataAsync()
        {
            // Snippet: ExportModelMetadataAsync(string, BigQueryDestination, CallSettings)
            // Additional: ExportModelMetadataAsync(string, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string model = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = await aMLClient.ExportModelMetadataAsync(model, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportModelMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadata</summary>
        public void ExportModelMetadataResourceNames()
        {
            // Snippet: ExportModelMetadata(ModelName, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ModelName model = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = aMLClient.ExportModelMetadata(model, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportModelMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportModelMetadataAsync</summary>
        public async Task ExportModelMetadataResourceNamesAsync()
        {
            // Snippet: ExportModelMetadataAsync(ModelName, BigQueryDestination, CallSettings)
            // Additional: ExportModelMetadataAsync(ModelName, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ModelName model = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportModelMetadataResponse, OperationMetadata> response = await aMLClient.ExportModelMetadataAsync(model, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportModelMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportModelMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportModelMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportModelMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportModelMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelRequestObject()
        {
            // Snippet: DeleteModel(DeleteModelRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelRequestObjectAsync()
        {
            // Snippet: DeleteModelAsync(DeleteModelRequest, CallSettings)
            // Additional: DeleteModelAsync(DeleteModelRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeleteModelRequest request = new DeleteModelRequest
            {
                ModelName = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModel()
        {
            // Snippet: DeleteModel(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelAsync()
        {
            // Snippet: DeleteModelAsync(string, CallSettings)
            // Additional: DeleteModelAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/models/[MODEL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModel</summary>
        public void DeleteModelResourceNames()
        {
            // Snippet: DeleteModel(ModelName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteModelAsync</summary>
        public async Task DeleteModelResourceNamesAsync()
        {
            // Snippet: DeleteModelAsync(ModelName, CallSettings)
            // Additional: DeleteModelAsync(ModelName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectNumLocationInstanceModel("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[MODEL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigs</summary>
        public void ListEngineConfigsRequestObject()
        {
            // Snippet: ListEngineConfigs(ListEngineConfigsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigsAsync</summary>
        public async Task ListEngineConfigsRequestObjectAsync()
        {
            // Snippet: ListEngineConfigsAsync(ListEngineConfigsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListEngineConfigsRequest request = new ListEngineConfigsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigs</summary>
        public void ListEngineConfigs()
        {
            // Snippet: ListEngineConfigs(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigsAsync</summary>
        public async Task ListEngineConfigsAsync()
        {
            // Snippet: ListEngineConfigsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigs</summary>
        public void ListEngineConfigsResourceNames()
        {
            // Snippet: ListEngineConfigs(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineConfigsAsync</summary>
        public async Task ListEngineConfigsResourceNamesAsync()
        {
            // Snippet: ListEngineConfigsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListEngineConfigsResponse, EngineConfig> response = aMLClient.ListEngineConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfig</summary>
        public void GetEngineConfigRequestObject()
        {
            // Snippet: GetEngineConfig(GetEngineConfigRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetEngineConfigRequest request = new GetEngineConfigRequest
            {
                EngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
            };
            // Make the request
            EngineConfig response = aMLClient.GetEngineConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfigAsync</summary>
        public async Task GetEngineConfigRequestObjectAsync()
        {
            // Snippet: GetEngineConfigAsync(GetEngineConfigRequest, CallSettings)
            // Additional: GetEngineConfigAsync(GetEngineConfigRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetEngineConfigRequest request = new GetEngineConfigRequest
            {
                EngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
            };
            // Make the request
            EngineConfig response = await aMLClient.GetEngineConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfig</summary>
        public void GetEngineConfig()
        {
            // Snippet: GetEngineConfig(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            // Make the request
            EngineConfig response = aMLClient.GetEngineConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfigAsync</summary>
        public async Task GetEngineConfigAsync()
        {
            // Snippet: GetEngineConfigAsync(string, CallSettings)
            // Additional: GetEngineConfigAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            // Make the request
            EngineConfig response = await aMLClient.GetEngineConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfig</summary>
        public void GetEngineConfigResourceNames()
        {
            // Snippet: GetEngineConfig(EngineConfigName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            EngineConfigName name = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            // Make the request
            EngineConfig response = aMLClient.GetEngineConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineConfigAsync</summary>
        public async Task GetEngineConfigResourceNamesAsync()
        {
            // Snippet: GetEngineConfigAsync(EngineConfigName, CallSettings)
            // Additional: GetEngineConfigAsync(EngineConfigName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            EngineConfigName name = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            // Make the request
            EngineConfig response = await aMLClient.GetEngineConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfig</summary>
        public void CreateEngineConfigRequestObject()
        {
            // Snippet: CreateEngineConfig(CreateEngineConfigRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreateEngineConfigRequest request = new CreateEngineConfigRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                EngineConfigId = "",
                EngineConfig = new EngineConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = aMLClient.CreateEngineConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfigAsync</summary>
        public async Task CreateEngineConfigRequestObjectAsync()
        {
            // Snippet: CreateEngineConfigAsync(CreateEngineConfigRequest, CallSettings)
            // Additional: CreateEngineConfigAsync(CreateEngineConfigRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreateEngineConfigRequest request = new CreateEngineConfigRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                EngineConfigId = "",
                EngineConfig = new EngineConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = await aMLClient.CreateEngineConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfig</summary>
        public void CreateEngineConfig()
        {
            // Snippet: CreateEngineConfig(string, EngineConfig, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            EngineConfig engineConfig = new EngineConfig();
            string engineConfigId = "";
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = aMLClient.CreateEngineConfig(parent, engineConfig, engineConfigId);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfigAsync</summary>
        public async Task CreateEngineConfigAsync()
        {
            // Snippet: CreateEngineConfigAsync(string, EngineConfig, string, CallSettings)
            // Additional: CreateEngineConfigAsync(string, EngineConfig, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            EngineConfig engineConfig = new EngineConfig();
            string engineConfigId = "";
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = await aMLClient.CreateEngineConfigAsync(parent, engineConfig, engineConfigId);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfig</summary>
        public void CreateEngineConfigResourceNames()
        {
            // Snippet: CreateEngineConfig(InstanceName, EngineConfig, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            EngineConfig engineConfig = new EngineConfig();
            string engineConfigId = "";
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = aMLClient.CreateEngineConfig(parent, engineConfig, engineConfigId);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineConfigAsync</summary>
        public async Task CreateEngineConfigResourceNamesAsync()
        {
            // Snippet: CreateEngineConfigAsync(InstanceName, EngineConfig, string, CallSettings)
            // Additional: CreateEngineConfigAsync(InstanceName, EngineConfig, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            EngineConfig engineConfig = new EngineConfig();
            string engineConfigId = "";
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = await aMLClient.CreateEngineConfigAsync(parent, engineConfig, engineConfigId);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineConfig</summary>
        public void UpdateEngineConfigRequestObject()
        {
            // Snippet: UpdateEngineConfig(UpdateEngineConfigRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdateEngineConfigRequest request = new UpdateEngineConfigRequest
            {
                UpdateMask = new FieldMask(),
                EngineConfig = new EngineConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = aMLClient.UpdateEngineConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineConfigAsync</summary>
        public async Task UpdateEngineConfigRequestObjectAsync()
        {
            // Snippet: UpdateEngineConfigAsync(UpdateEngineConfigRequest, CallSettings)
            // Additional: UpdateEngineConfigAsync(UpdateEngineConfigRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEngineConfigRequest request = new UpdateEngineConfigRequest
            {
                UpdateMask = new FieldMask(),
                EngineConfig = new EngineConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = await aMLClient.UpdateEngineConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineConfig</summary>
        public void UpdateEngineConfig()
        {
            // Snippet: UpdateEngineConfig(EngineConfig, FieldMask, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            EngineConfig engineConfig = new EngineConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = aMLClient.UpdateEngineConfig(engineConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineConfigAsync</summary>
        public async Task UpdateEngineConfigAsync()
        {
            // Snippet: UpdateEngineConfigAsync(EngineConfig, FieldMask, CallSettings)
            // Additional: UpdateEngineConfigAsync(EngineConfig, FieldMask, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            EngineConfig engineConfig = new EngineConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<EngineConfig, OperationMetadata> response = await aMLClient.UpdateEngineConfigAsync(engineConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<EngineConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EngineConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EngineConfig, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EngineConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadata</summary>
        public void ExportEngineConfigMetadataRequestObject()
        {
            // Snippet: ExportEngineConfigMetadata(ExportEngineConfigMetadataRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ExportEngineConfigMetadataRequest request = new ExportEngineConfigMetadataRequest
            {
                EngineConfigAsEngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = aMLClient.ExportEngineConfigMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportEngineConfigMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadataAsync</summary>
        public async Task ExportEngineConfigMetadataRequestObjectAsync()
        {
            // Snippet: ExportEngineConfigMetadataAsync(ExportEngineConfigMetadataRequest, CallSettings)
            // Additional: ExportEngineConfigMetadataAsync(ExportEngineConfigMetadataRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ExportEngineConfigMetadataRequest request = new ExportEngineConfigMetadataRequest
            {
                EngineConfigAsEngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = await aMLClient.ExportEngineConfigMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportEngineConfigMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadata</summary>
        public void ExportEngineConfigMetadata()
        {
            // Snippet: ExportEngineConfigMetadata(string, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string engineConfig = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = aMLClient.ExportEngineConfigMetadata(engineConfig, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportEngineConfigMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadataAsync</summary>
        public async Task ExportEngineConfigMetadataAsync()
        {
            // Snippet: ExportEngineConfigMetadataAsync(string, BigQueryDestination, CallSettings)
            // Additional: ExportEngineConfigMetadataAsync(string, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string engineConfig = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = await aMLClient.ExportEngineConfigMetadataAsync(engineConfig, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportEngineConfigMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadata</summary>
        public void ExportEngineConfigMetadataResourceNames()
        {
            // Snippet: ExportEngineConfigMetadata(EngineConfigName, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            EngineConfigName engineConfig = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = aMLClient.ExportEngineConfigMetadata(engineConfig, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportEngineConfigMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportEngineConfigMetadataAsync</summary>
        public async Task ExportEngineConfigMetadataResourceNamesAsync()
        {
            // Snippet: ExportEngineConfigMetadataAsync(EngineConfigName, BigQueryDestination, CallSettings)
            // Additional: ExportEngineConfigMetadataAsync(EngineConfigName, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            EngineConfigName engineConfig = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> response = await aMLClient.ExportEngineConfigMetadataAsync(engineConfig, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEngineConfigMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEngineConfigMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportEngineConfigMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEngineConfigMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfig</summary>
        public void DeleteEngineConfigRequestObject()
        {
            // Snippet: DeleteEngineConfig(DeleteEngineConfigRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeleteEngineConfigRequest request = new DeleteEngineConfigRequest
            {
                EngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteEngineConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfigAsync</summary>
        public async Task DeleteEngineConfigRequestObjectAsync()
        {
            // Snippet: DeleteEngineConfigAsync(DeleteEngineConfigRequest, CallSettings)
            // Additional: DeleteEngineConfigAsync(DeleteEngineConfigRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEngineConfigRequest request = new DeleteEngineConfigRequest
            {
                EngineConfigName = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteEngineConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfig</summary>
        public void DeleteEngineConfig()
        {
            // Snippet: DeleteEngineConfig(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteEngineConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfigAsync</summary>
        public async Task DeleteEngineConfigAsync()
        {
            // Snippet: DeleteEngineConfigAsync(string, CallSettings)
            // Additional: DeleteEngineConfigAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineConfigs/[ENGINE_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteEngineConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfig</summary>
        public void DeleteEngineConfigResourceNames()
        {
            // Snippet: DeleteEngineConfig(EngineConfigName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            EngineConfigName name = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteEngineConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteEngineConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineConfigAsync</summary>
        public async Task DeleteEngineConfigResourceNamesAsync()
        {
            // Snippet: DeleteEngineConfigAsync(EngineConfigName, CallSettings)
            // Additional: DeleteEngineConfigAsync(EngineConfigName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            EngineConfigName name = EngineConfigName.FromProjectNumLocationInstanceEngineConfig("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteEngineConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteEngineConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersion</summary>
        public void GetEngineVersionRequestObject()
        {
            // Snippet: GetEngineVersion(GetEngineVersionRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetEngineVersionRequest request = new GetEngineVersionRequest
            {
                EngineVersionName = EngineVersionName.FromProjectNumLocationInstanceEngineVersion("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_VERSION]"),
            };
            // Make the request
            EngineVersion response = aMLClient.GetEngineVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersionAsync</summary>
        public async Task GetEngineVersionRequestObjectAsync()
        {
            // Snippet: GetEngineVersionAsync(GetEngineVersionRequest, CallSettings)
            // Additional: GetEngineVersionAsync(GetEngineVersionRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetEngineVersionRequest request = new GetEngineVersionRequest
            {
                EngineVersionName = EngineVersionName.FromProjectNumLocationInstanceEngineVersion("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_VERSION]"),
            };
            // Make the request
            EngineVersion response = await aMLClient.GetEngineVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersion</summary>
        public void GetEngineVersion()
        {
            // Snippet: GetEngineVersion(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineVersions/[ENGINE_VERSION]";
            // Make the request
            EngineVersion response = aMLClient.GetEngineVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersionAsync</summary>
        public async Task GetEngineVersionAsync()
        {
            // Snippet: GetEngineVersionAsync(string, CallSettings)
            // Additional: GetEngineVersionAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/engineVersions/[ENGINE_VERSION]";
            // Make the request
            EngineVersion response = await aMLClient.GetEngineVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersion</summary>
        public void GetEngineVersionResourceNames()
        {
            // Snippet: GetEngineVersion(EngineVersionName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            EngineVersionName name = EngineVersionName.FromProjectNumLocationInstanceEngineVersion("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_VERSION]");
            // Make the request
            EngineVersion response = aMLClient.GetEngineVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineVersionAsync</summary>
        public async Task GetEngineVersionResourceNamesAsync()
        {
            // Snippet: GetEngineVersionAsync(EngineVersionName, CallSettings)
            // Additional: GetEngineVersionAsync(EngineVersionName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            EngineVersionName name = EngineVersionName.FromProjectNumLocationInstanceEngineVersion("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[ENGINE_VERSION]");
            // Make the request
            EngineVersion response = await aMLClient.GetEngineVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersions</summary>
        public void ListEngineVersionsRequestObject()
        {
            // Snippet: ListEngineVersions(ListEngineVersionsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersionsAsync</summary>
        public async Task ListEngineVersionsRequestObjectAsync()
        {
            // Snippet: ListEngineVersionsAsync(ListEngineVersionsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListEngineVersionsRequest request = new ListEngineVersionsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersions</summary>
        public void ListEngineVersions()
        {
            // Snippet: ListEngineVersions(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersionsAsync</summary>
        public async Task ListEngineVersionsAsync()
        {
            // Snippet: ListEngineVersionsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersions</summary>
        public void ListEngineVersionsResourceNames()
        {
            // Snippet: ListEngineVersions(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EngineVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEngineVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngineVersionsAsync</summary>
        public async Task ListEngineVersionsResourceNamesAsync()
        {
            // Snippet: ListEngineVersionsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListEngineVersionsResponse, EngineVersion> response = aMLClient.ListEngineVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EngineVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEngineVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EngineVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EngineVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EngineVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResults</summary>
        public void ListPredictionResultsRequestObject()
        {
            // Snippet: ListPredictionResults(ListPredictionResultsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResultsAsync</summary>
        public async Task ListPredictionResultsRequestObjectAsync()
        {
            // Snippet: ListPredictionResultsAsync(ListPredictionResultsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListPredictionResultsRequest request = new ListPredictionResultsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResults</summary>
        public void ListPredictionResults()
        {
            // Snippet: ListPredictionResults(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResultsAsync</summary>
        public async Task ListPredictionResultsAsync()
        {
            // Snippet: ListPredictionResultsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResults</summary>
        public void ListPredictionResultsResourceNames()
        {
            // Snippet: ListPredictionResults(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PredictionResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPredictionResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPredictionResultsAsync</summary>
        public async Task ListPredictionResultsResourceNamesAsync()
        {
            // Snippet: ListPredictionResultsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListPredictionResultsResponse, PredictionResult> response = aMLClient.ListPredictionResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PredictionResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPredictionResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PredictionResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PredictionResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PredictionResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResult</summary>
        public void GetPredictionResultRequestObject()
        {
            // Snippet: GetPredictionResult(GetPredictionResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetPredictionResultRequest request = new GetPredictionResultRequest
            {
                PredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
            };
            // Make the request
            PredictionResult response = aMLClient.GetPredictionResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResultAsync</summary>
        public async Task GetPredictionResultRequestObjectAsync()
        {
            // Snippet: GetPredictionResultAsync(GetPredictionResultRequest, CallSettings)
            // Additional: GetPredictionResultAsync(GetPredictionResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetPredictionResultRequest request = new GetPredictionResultRequest
            {
                PredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
            };
            // Make the request
            PredictionResult response = await aMLClient.GetPredictionResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResult</summary>
        public void GetPredictionResult()
        {
            // Snippet: GetPredictionResult(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            // Make the request
            PredictionResult response = aMLClient.GetPredictionResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResultAsync</summary>
        public async Task GetPredictionResultAsync()
        {
            // Snippet: GetPredictionResultAsync(string, CallSettings)
            // Additional: GetPredictionResultAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            // Make the request
            PredictionResult response = await aMLClient.GetPredictionResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResult</summary>
        public void GetPredictionResultResourceNames()
        {
            // Snippet: GetPredictionResult(PredictionResultName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            PredictionResultName name = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            // Make the request
            PredictionResult response = aMLClient.GetPredictionResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetPredictionResultAsync</summary>
        public async Task GetPredictionResultResourceNamesAsync()
        {
            // Snippet: GetPredictionResultAsync(PredictionResultName, CallSettings)
            // Additional: GetPredictionResultAsync(PredictionResultName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            PredictionResultName name = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            // Make the request
            PredictionResult response = await aMLClient.GetPredictionResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResult</summary>
        public void CreatePredictionResultRequestObject()
        {
            // Snippet: CreatePredictionResult(CreatePredictionResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreatePredictionResultRequest request = new CreatePredictionResultRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                PredictionResultId = "",
                PredictionResult = new PredictionResult(),
                RequestId = "",
            };
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = aMLClient.CreatePredictionResult(request);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreatePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResultAsync</summary>
        public async Task CreatePredictionResultRequestObjectAsync()
        {
            // Snippet: CreatePredictionResultAsync(CreatePredictionResultRequest, CallSettings)
            // Additional: CreatePredictionResultAsync(CreatePredictionResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreatePredictionResultRequest request = new CreatePredictionResultRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                PredictionResultId = "",
                PredictionResult = new PredictionResult(),
                RequestId = "",
            };
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = await aMLClient.CreatePredictionResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreatePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResult</summary>
        public void CreatePredictionResult()
        {
            // Snippet: CreatePredictionResult(string, PredictionResult, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            PredictionResult predictionResult = new PredictionResult();
            string predictionResultId = "";
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = aMLClient.CreatePredictionResult(parent, predictionResult, predictionResultId);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreatePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResultAsync</summary>
        public async Task CreatePredictionResultAsync()
        {
            // Snippet: CreatePredictionResultAsync(string, PredictionResult, string, CallSettings)
            // Additional: CreatePredictionResultAsync(string, PredictionResult, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            PredictionResult predictionResult = new PredictionResult();
            string predictionResultId = "";
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = await aMLClient.CreatePredictionResultAsync(parent, predictionResult, predictionResultId);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreatePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResult</summary>
        public void CreatePredictionResultResourceNames()
        {
            // Snippet: CreatePredictionResult(InstanceName, PredictionResult, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            PredictionResult predictionResult = new PredictionResult();
            string predictionResultId = "";
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = aMLClient.CreatePredictionResult(parent, predictionResult, predictionResultId);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreatePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePredictionResultAsync</summary>
        public async Task CreatePredictionResultResourceNamesAsync()
        {
            // Snippet: CreatePredictionResultAsync(InstanceName, PredictionResult, string, CallSettings)
            // Additional: CreatePredictionResultAsync(InstanceName, PredictionResult, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            PredictionResult predictionResult = new PredictionResult();
            string predictionResultId = "";
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = await aMLClient.CreatePredictionResultAsync(parent, predictionResult, predictionResultId);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreatePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePredictionResult</summary>
        public void UpdatePredictionResultRequestObject()
        {
            // Snippet: UpdatePredictionResult(UpdatePredictionResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdatePredictionResultRequest request = new UpdatePredictionResultRequest
            {
                UpdateMask = new FieldMask(),
                PredictionResult = new PredictionResult(),
                RequestId = "",
            };
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = aMLClient.UpdatePredictionResult(request);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdatePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePredictionResultAsync</summary>
        public async Task UpdatePredictionResultRequestObjectAsync()
        {
            // Snippet: UpdatePredictionResultAsync(UpdatePredictionResultRequest, CallSettings)
            // Additional: UpdatePredictionResultAsync(UpdatePredictionResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePredictionResultRequest request = new UpdatePredictionResultRequest
            {
                UpdateMask = new FieldMask(),
                PredictionResult = new PredictionResult(),
                RequestId = "",
            };
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = await aMLClient.UpdatePredictionResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdatePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePredictionResult</summary>
        public void UpdatePredictionResult()
        {
            // Snippet: UpdatePredictionResult(PredictionResult, FieldMask, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            PredictionResult predictionResult = new PredictionResult();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = aMLClient.UpdatePredictionResult(predictionResult, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdatePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePredictionResultAsync</summary>
        public async Task UpdatePredictionResultAsync()
        {
            // Snippet: UpdatePredictionResultAsync(PredictionResult, FieldMask, CallSettings)
            // Additional: UpdatePredictionResultAsync(PredictionResult, FieldMask, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            PredictionResult predictionResult = new PredictionResult();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PredictionResult, OperationMetadata> response = await aMLClient.UpdatePredictionResultAsync(predictionResult, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PredictionResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PredictionResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PredictionResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdatePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PredictionResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadata</summary>
        public void ExportPredictionResultMetadataRequestObject()
        {
            // Snippet: ExportPredictionResultMetadata(ExportPredictionResultMetadataRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ExportPredictionResultMetadataRequest request = new ExportPredictionResultMetadataRequest
            {
                PredictionResultAsPredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = aMLClient.ExportPredictionResultMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportPredictionResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadataAsync</summary>
        public async Task ExportPredictionResultMetadataRequestObjectAsync()
        {
            // Snippet: ExportPredictionResultMetadataAsync(ExportPredictionResultMetadataRequest, CallSettings)
            // Additional: ExportPredictionResultMetadataAsync(ExportPredictionResultMetadataRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ExportPredictionResultMetadataRequest request = new ExportPredictionResultMetadataRequest
            {
                PredictionResultAsPredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportPredictionResultMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportPredictionResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadata</summary>
        public void ExportPredictionResultMetadata()
        {
            // Snippet: ExportPredictionResultMetadata(string, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string predictionResult = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = aMLClient.ExportPredictionResultMetadata(predictionResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportPredictionResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadataAsync</summary>
        public async Task ExportPredictionResultMetadataAsync()
        {
            // Snippet: ExportPredictionResultMetadataAsync(string, BigQueryDestination, CallSettings)
            // Additional: ExportPredictionResultMetadataAsync(string, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string predictionResult = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportPredictionResultMetadataAsync(predictionResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportPredictionResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadata</summary>
        public void ExportPredictionResultMetadataResourceNames()
        {
            // Snippet: ExportPredictionResultMetadata(PredictionResultName, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            PredictionResultName predictionResult = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = aMLClient.ExportPredictionResultMetadata(predictionResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportPredictionResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportPredictionResultMetadataAsync</summary>
        public async Task ExportPredictionResultMetadataResourceNamesAsync()
        {
            // Snippet: ExportPredictionResultMetadataAsync(PredictionResultName, BigQueryDestination, CallSettings)
            // Additional: ExportPredictionResultMetadataAsync(PredictionResultName, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            PredictionResultName predictionResult = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportPredictionResultMetadataAsync(predictionResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportPredictionResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportPredictionResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportPredictionResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportPredictionResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResult</summary>
        public void DeletePredictionResultRequestObject()
        {
            // Snippet: DeletePredictionResult(DeletePredictionResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeletePredictionResultRequest request = new DeletePredictionResultRequest
            {
                PredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeletePredictionResult(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeletePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResultAsync</summary>
        public async Task DeletePredictionResultRequestObjectAsync()
        {
            // Snippet: DeletePredictionResultAsync(DeletePredictionResultRequest, CallSettings)
            // Additional: DeletePredictionResultAsync(DeletePredictionResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeletePredictionResultRequest request = new DeletePredictionResultRequest
            {
                PredictionResultName = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeletePredictionResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeletePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResult</summary>
        public void DeletePredictionResult()
        {
            // Snippet: DeletePredictionResult(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeletePredictionResult(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeletePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResultAsync</summary>
        public async Task DeletePredictionResultAsync()
        {
            // Snippet: DeletePredictionResultAsync(string, CallSettings)
            // Additional: DeletePredictionResultAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/predictionResults/[PREDICTION_RESULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeletePredictionResultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeletePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResult</summary>
        public void DeletePredictionResultResourceNames()
        {
            // Snippet: DeletePredictionResult(PredictionResultName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            PredictionResultName name = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeletePredictionResult(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeletePredictionResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePredictionResultAsync</summary>
        public async Task DeletePredictionResultResourceNamesAsync()
        {
            // Snippet: DeletePredictionResultAsync(PredictionResultName, CallSettings)
            // Additional: DeletePredictionResultAsync(PredictionResultName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            PredictionResultName name = PredictionResultName.FromProjectNumLocationInstancePredictionResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[PREDICTION_RESULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeletePredictionResultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeletePredictionResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResults</summary>
        public void ListBacktestResultsRequestObject()
        {
            // Snippet: ListBacktestResults(ListBacktestResultsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BacktestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBacktestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResultsAsync</summary>
        public async Task ListBacktestResultsRequestObjectAsync()
        {
            // Snippet: ListBacktestResultsAsync(ListBacktestResultsRequest, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ListBacktestResultsRequest request = new ListBacktestResultsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BacktestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBacktestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResults</summary>
        public void ListBacktestResults()
        {
            // Snippet: ListBacktestResults(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BacktestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBacktestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResultsAsync</summary>
        public async Task ListBacktestResultsAsync()
        {
            // Snippet: ListBacktestResultsAsync(string, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BacktestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBacktestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResults</summary>
        public void ListBacktestResultsResourceNames()
        {
            // Snippet: ListBacktestResults(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BacktestResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBacktestResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBacktestResultsAsync</summary>
        public async Task ListBacktestResultsResourceNamesAsync()
        {
            // Snippet: ListBacktestResultsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListBacktestResultsResponse, BacktestResult> response = aMLClient.ListBacktestResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BacktestResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBacktestResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BacktestResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BacktestResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BacktestResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResult</summary>
        public void GetBacktestResultRequestObject()
        {
            // Snippet: GetBacktestResult(GetBacktestResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            GetBacktestResultRequest request = new GetBacktestResultRequest
            {
                BacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
            };
            // Make the request
            BacktestResult response = aMLClient.GetBacktestResult(request);
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResultAsync</summary>
        public async Task GetBacktestResultRequestObjectAsync()
        {
            // Snippet: GetBacktestResultAsync(GetBacktestResultRequest, CallSettings)
            // Additional: GetBacktestResultAsync(GetBacktestResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            GetBacktestResultRequest request = new GetBacktestResultRequest
            {
                BacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
            };
            // Make the request
            BacktestResult response = await aMLClient.GetBacktestResultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResult</summary>
        public void GetBacktestResult()
        {
            // Snippet: GetBacktestResult(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            // Make the request
            BacktestResult response = aMLClient.GetBacktestResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResultAsync</summary>
        public async Task GetBacktestResultAsync()
        {
            // Snippet: GetBacktestResultAsync(string, CallSettings)
            // Additional: GetBacktestResultAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            // Make the request
            BacktestResult response = await aMLClient.GetBacktestResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResult</summary>
        public void GetBacktestResultResourceNames()
        {
            // Snippet: GetBacktestResult(BacktestResultName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            BacktestResultName name = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            // Make the request
            BacktestResult response = aMLClient.GetBacktestResult(name);
            // End snippet
        }

        /// <summary>Snippet for GetBacktestResultAsync</summary>
        public async Task GetBacktestResultResourceNamesAsync()
        {
            // Snippet: GetBacktestResultAsync(BacktestResultName, CallSettings)
            // Additional: GetBacktestResultAsync(BacktestResultName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            BacktestResultName name = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            // Make the request
            BacktestResult response = await aMLClient.GetBacktestResultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResult</summary>
        public void CreateBacktestResultRequestObject()
        {
            // Snippet: CreateBacktestResult(CreateBacktestResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            CreateBacktestResultRequest request = new CreateBacktestResultRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                BacktestResultId = "",
                BacktestResult = new BacktestResult(),
                RequestId = "",
            };
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = aMLClient.CreateBacktestResult(request);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResultAsync</summary>
        public async Task CreateBacktestResultRequestObjectAsync()
        {
            // Snippet: CreateBacktestResultAsync(CreateBacktestResultRequest, CallSettings)
            // Additional: CreateBacktestResultAsync(CreateBacktestResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            CreateBacktestResultRequest request = new CreateBacktestResultRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                BacktestResultId = "",
                BacktestResult = new BacktestResult(),
                RequestId = "",
            };
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = await aMLClient.CreateBacktestResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResult</summary>
        public void CreateBacktestResult()
        {
            // Snippet: CreateBacktestResult(string, BacktestResult, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            BacktestResult backtestResult = new BacktestResult();
            string backtestResultId = "";
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = aMLClient.CreateBacktestResult(parent, backtestResult, backtestResultId);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResultAsync</summary>
        public async Task CreateBacktestResultAsync()
        {
            // Snippet: CreateBacktestResultAsync(string, BacktestResult, string, CallSettings)
            // Additional: CreateBacktestResultAsync(string, BacktestResult, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            BacktestResult backtestResult = new BacktestResult();
            string backtestResultId = "";
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = await aMLClient.CreateBacktestResultAsync(parent, backtestResult, backtestResultId);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResult</summary>
        public void CreateBacktestResultResourceNames()
        {
            // Snippet: CreateBacktestResult(InstanceName, BacktestResult, string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            BacktestResult backtestResult = new BacktestResult();
            string backtestResultId = "";
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = aMLClient.CreateBacktestResult(parent, backtestResult, backtestResultId);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceCreateBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBacktestResultAsync</summary>
        public async Task CreateBacktestResultResourceNamesAsync()
        {
            // Snippet: CreateBacktestResultAsync(InstanceName, BacktestResult, string, CallSettings)
            // Additional: CreateBacktestResultAsync(InstanceName, BacktestResult, string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            BacktestResult backtestResult = new BacktestResult();
            string backtestResultId = "";
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = await aMLClient.CreateBacktestResultAsync(parent, backtestResult, backtestResultId);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceCreateBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBacktestResult</summary>
        public void UpdateBacktestResultRequestObject()
        {
            // Snippet: UpdateBacktestResult(UpdateBacktestResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            UpdateBacktestResultRequest request = new UpdateBacktestResultRequest
            {
                UpdateMask = new FieldMask(),
                BacktestResult = new BacktestResult(),
                RequestId = "",
            };
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = aMLClient.UpdateBacktestResult(request);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBacktestResultAsync</summary>
        public async Task UpdateBacktestResultRequestObjectAsync()
        {
            // Snippet: UpdateBacktestResultAsync(UpdateBacktestResultRequest, CallSettings)
            // Additional: UpdateBacktestResultAsync(UpdateBacktestResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBacktestResultRequest request = new UpdateBacktestResultRequest
            {
                UpdateMask = new FieldMask(),
                BacktestResult = new BacktestResult(),
                RequestId = "",
            };
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = await aMLClient.UpdateBacktestResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBacktestResult</summary>
        public void UpdateBacktestResult()
        {
            // Snippet: UpdateBacktestResult(BacktestResult, FieldMask, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            BacktestResult backtestResult = new BacktestResult();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = aMLClient.UpdateBacktestResult(backtestResult, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = aMLClient.PollOnceUpdateBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBacktestResultAsync</summary>
        public async Task UpdateBacktestResultAsync()
        {
            // Snippet: UpdateBacktestResultAsync(BacktestResult, FieldMask, CallSettings)
            // Additional: UpdateBacktestResultAsync(BacktestResult, FieldMask, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            BacktestResult backtestResult = new BacktestResult();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BacktestResult, OperationMetadata> response = await aMLClient.UpdateBacktestResultAsync(backtestResult, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BacktestResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BacktestResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BacktestResult, OperationMetadata> retrievedResponse = await aMLClient.PollOnceUpdateBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BacktestResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadata</summary>
        public void ExportBacktestResultMetadataRequestObject()
        {
            // Snippet: ExportBacktestResultMetadata(ExportBacktestResultMetadataRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            ExportBacktestResultMetadataRequest request = new ExportBacktestResultMetadataRequest
            {
                BacktestResultAsBacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = aMLClient.ExportBacktestResultMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportBacktestResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadataAsync</summary>
        public async Task ExportBacktestResultMetadataRequestObjectAsync()
        {
            // Snippet: ExportBacktestResultMetadataAsync(ExportBacktestResultMetadataRequest, CallSettings)
            // Additional: ExportBacktestResultMetadataAsync(ExportBacktestResultMetadataRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            ExportBacktestResultMetadataRequest request = new ExportBacktestResultMetadataRequest
            {
                BacktestResultAsBacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
                StructuredMetadataDestination = new BigQueryDestination(),
            };
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportBacktestResultMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportBacktestResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadata</summary>
        public void ExportBacktestResultMetadata()
        {
            // Snippet: ExportBacktestResultMetadata(string, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string backtestResult = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = aMLClient.ExportBacktestResultMetadata(backtestResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportBacktestResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadataAsync</summary>
        public async Task ExportBacktestResultMetadataAsync()
        {
            // Snippet: ExportBacktestResultMetadataAsync(string, BigQueryDestination, CallSettings)
            // Additional: ExportBacktestResultMetadataAsync(string, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string backtestResult = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportBacktestResultMetadataAsync(backtestResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportBacktestResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadata</summary>
        public void ExportBacktestResultMetadataResourceNames()
        {
            // Snippet: ExportBacktestResultMetadata(BacktestResultName, BigQueryDestination, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            BacktestResultName backtestResult = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = aMLClient.ExportBacktestResultMetadata(backtestResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = aMLClient.PollOnceExportBacktestResultMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportBacktestResultMetadataAsync</summary>
        public async Task ExportBacktestResultMetadataResourceNamesAsync()
        {
            // Snippet: ExportBacktestResultMetadataAsync(BacktestResultName, BigQueryDestination, CallSettings)
            // Additional: ExportBacktestResultMetadataAsync(BacktestResultName, BigQueryDestination, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            BacktestResultName backtestResult = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            BigQueryDestination structuredMetadataDestination = new BigQueryDestination();
            // Make the request
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> response = await aMLClient.ExportBacktestResultMetadataAsync(backtestResult, structuredMetadataDestination);

            // Poll until the returned long-running operation is complete
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportBacktestResultMetadataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportBacktestResultMetadataResponse, OperationMetadata> retrievedResponse = await aMLClient.PollOnceExportBacktestResultMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportBacktestResultMetadataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResult</summary>
        public void DeleteBacktestResultRequestObject()
        {
            // Snippet: DeleteBacktestResult(DeleteBacktestResultRequest, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            DeleteBacktestResultRequest request = new DeleteBacktestResultRequest
            {
                BacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteBacktestResult(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResultAsync</summary>
        public async Task DeleteBacktestResultRequestObjectAsync()
        {
            // Snippet: DeleteBacktestResultAsync(DeleteBacktestResultRequest, CallSettings)
            // Additional: DeleteBacktestResultAsync(DeleteBacktestResultRequest, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBacktestResultRequest request = new DeleteBacktestResultRequest
            {
                BacktestResultName = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteBacktestResultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResult</summary>
        public void DeleteBacktestResult()
        {
            // Snippet: DeleteBacktestResult(string, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteBacktestResult(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResultAsync</summary>
        public async Task DeleteBacktestResultAsync()
        {
            // Snippet: DeleteBacktestResultAsync(string, CallSettings)
            // Additional: DeleteBacktestResultAsync(string, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT_NUM]/locations/[LOCATION]/instances/[INSTANCE]/backtestResults/[BACKTEST_RESULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteBacktestResultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteBacktestResultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResult</summary>
        public void DeleteBacktestResultResourceNames()
        {
            // Snippet: DeleteBacktestResult(BacktestResultName, CallSettings)
            // Create client
            AMLClient aMLClient = AMLClient.Create();
            // Initialize request argument(s)
            BacktestResultName name = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = aMLClient.DeleteBacktestResult(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = aMLClient.PollOnceDeleteBacktestResult(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBacktestResultAsync</summary>
        public async Task DeleteBacktestResultResourceNamesAsync()
        {
            // Snippet: DeleteBacktestResultAsync(BacktestResultName, CallSettings)
            // Additional: DeleteBacktestResultAsync(BacktestResultName, CancellationToken)
            // Create client
            AMLClient aMLClient = await AMLClient.CreateAsync();
            // Initialize request argument(s)
            BacktestResultName name = BacktestResultName.FromProjectNumLocationInstanceBacktestResult("[PROJECT_NUM]", "[LOCATION]", "[INSTANCE]", "[BACKTEST_RESULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await aMLClient.DeleteBacktestResultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await aMLClient.PollOnceDeleteBacktestResultAsync(operationName);
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
