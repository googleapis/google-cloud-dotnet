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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.SecureSourceManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecureSourceManagerClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstances(request);

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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstancesAsync(request);

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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstances(parent);

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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstancesAsync(parent);

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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstances(parent);

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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = secureSourceManagerClient.ListInstancesAsync(parent);

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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = secureSourceManagerClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await secureSourceManagerClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = secureSourceManagerClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await secureSourceManagerClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = secureSourceManagerClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await secureSourceManagerClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = secureSourceManagerClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await secureSourceManagerClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateInstanceAsync(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = secureSourceManagerClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await secureSourceManagerClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateInstanceAsync(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = secureSourceManagerClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await secureSourceManagerClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateInstanceAsync(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteInstanceAsync(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteInstanceAsync(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteInstance(operationName);
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
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(LocationName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = secureSourceManagerClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = secureSourceManagerClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = await secureSourceManagerClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = secureSourceManagerClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = await secureSourceManagerClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = secureSourceManagerClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Repository response = await secureSourceManagerClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = secureSourceManagerClient.CreateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = await secureSourceManagerClient.CreateRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = secureSourceManagerClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await secureSourceManagerClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(LocationName, Repository, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = secureSourceManagerClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(LocationName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(LocationName, Repository, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await secureSourceManagerClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepo</summary>
        public void GetIamPolicyRepoRequestObject()
        {
            // Snippet: GetIamPolicyRepo(GetIamPolicyRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = secureSourceManagerClient.GetIamPolicyRepo(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepoAsync</summary>
        public async Task GetIamPolicyRepoRequestObjectAsync()
        {
            // Snippet: GetIamPolicyRepoAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyRepoAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await secureSourceManagerClient.GetIamPolicyRepoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepo</summary>
        public void GetIamPolicyRepo()
        {
            // Snippet: GetIamPolicyRepo(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = secureSourceManagerClient.GetIamPolicyRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepoAsync</summary>
        public async Task GetIamPolicyRepoAsync()
        {
            // Snippet: GetIamPolicyRepoAsync(string, CallSettings)
            // Additional: GetIamPolicyRepoAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await secureSourceManagerClient.GetIamPolicyRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepo</summary>
        public void GetIamPolicyRepoResourceNames()
        {
            // Snippet: GetIamPolicyRepo(IResourceName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = secureSourceManagerClient.GetIamPolicyRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyRepoAsync</summary>
        public async Task GetIamPolicyRepoResourceNamesAsync()
        {
            // Snippet: GetIamPolicyRepoAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyRepoAsync(IResourceName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await secureSourceManagerClient.GetIamPolicyRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepo</summary>
        public void SetIamPolicyRepoRequestObject()
        {
            // Snippet: SetIamPolicyRepo(SetIamPolicyRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = secureSourceManagerClient.SetIamPolicyRepo(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepoAsync</summary>
        public async Task SetIamPolicyRepoRequestObjectAsync()
        {
            // Snippet: SetIamPolicyRepoAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyRepoAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await secureSourceManagerClient.SetIamPolicyRepoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepo</summary>
        public void SetIamPolicyRepo()
        {
            // Snippet: SetIamPolicyRepo(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = secureSourceManagerClient.SetIamPolicyRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepoAsync</summary>
        public async Task SetIamPolicyRepoAsync()
        {
            // Snippet: SetIamPolicyRepoAsync(string, CallSettings)
            // Additional: SetIamPolicyRepoAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await secureSourceManagerClient.SetIamPolicyRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepo</summary>
        public void SetIamPolicyRepoResourceNames()
        {
            // Snippet: SetIamPolicyRepo(IResourceName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = secureSourceManagerClient.SetIamPolicyRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyRepoAsync</summary>
        public async Task SetIamPolicyRepoResourceNamesAsync()
        {
            // Snippet: SetIamPolicyRepoAsync(IResourceName, CallSettings)
            // Additional: SetIamPolicyRepoAsync(IResourceName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await secureSourceManagerClient.SetIamPolicyRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepo</summary>
        public void TestIamPermissionsRepoRequestObject()
        {
            // Snippet: TestIamPermissionsRepo(TestIamPermissionsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = secureSourceManagerClient.TestIamPermissionsRepo(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepoAsync</summary>
        public async Task TestIamPermissionsRepoRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsRepoAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsRepoAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await secureSourceManagerClient.TestIamPermissionsRepoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepo</summary>
        public void TestIamPermissionsRepo()
        {
            // Snippet: TestIamPermissionsRepo(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            TestIamPermissionsResponse response = secureSourceManagerClient.TestIamPermissionsRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepoAsync</summary>
        public async Task TestIamPermissionsRepoAsync()
        {
            // Snippet: TestIamPermissionsRepoAsync(string, CallSettings)
            // Additional: TestIamPermissionsRepoAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            TestIamPermissionsResponse response = await secureSourceManagerClient.TestIamPermissionsRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepo</summary>
        public void TestIamPermissionsRepoResourceNames()
        {
            // Snippet: TestIamPermissionsRepo(IResourceName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            TestIamPermissionsResponse response = secureSourceManagerClient.TestIamPermissionsRepo(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsRepoAsync</summary>
        public async Task TestIamPermissionsRepoResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsRepoAsync(IResourceName, CallSettings)
            // Additional: TestIamPermissionsRepoAsync(IResourceName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            TestIamPermissionsResponse response = await secureSourceManagerClient.TestIamPermissionsRepoAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRule</summary>
        public void CreateBranchRuleRequestObject()
        {
            // Snippet: CreateBranchRule(CreateBranchRuleRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateBranchRuleRequest request = new CreateBranchRuleRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                BranchRule = new BranchRule(),
                BranchRuleId = "",
            };
            // Make the request
            Operation<BranchRule, OperationMetadata> response = secureSourceManagerClient.CreateBranchRule(request);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRuleAsync</summary>
        public async Task CreateBranchRuleRequestObjectAsync()
        {
            // Snippet: CreateBranchRuleAsync(CreateBranchRuleRequest, CallSettings)
            // Additional: CreateBranchRuleAsync(CreateBranchRuleRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateBranchRuleRequest request = new CreateBranchRuleRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                BranchRule = new BranchRule(),
                BranchRuleId = "",
            };
            // Make the request
            Operation<BranchRule, OperationMetadata> response = await secureSourceManagerClient.CreateBranchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRule</summary>
        public void CreateBranchRule()
        {
            // Snippet: CreateBranchRule(string, BranchRule, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            BranchRule branchRule = new BranchRule();
            string branchRuleId = "";
            // Make the request
            Operation<BranchRule, OperationMetadata> response = secureSourceManagerClient.CreateBranchRule(parent, branchRule, branchRuleId);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRuleAsync</summary>
        public async Task CreateBranchRuleAsync()
        {
            // Snippet: CreateBranchRuleAsync(string, BranchRule, string, CallSettings)
            // Additional: CreateBranchRuleAsync(string, BranchRule, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            BranchRule branchRule = new BranchRule();
            string branchRuleId = "";
            // Make the request
            Operation<BranchRule, OperationMetadata> response = await secureSourceManagerClient.CreateBranchRuleAsync(parent, branchRule, branchRuleId);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRule</summary>
        public void CreateBranchRuleResourceNames()
        {
            // Snippet: CreateBranchRule(RepositoryName, BranchRule, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            BranchRule branchRule = new BranchRule();
            string branchRuleId = "";
            // Make the request
            Operation<BranchRule, OperationMetadata> response = secureSourceManagerClient.CreateBranchRule(parent, branchRule, branchRuleId);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBranchRuleAsync</summary>
        public async Task CreateBranchRuleResourceNamesAsync()
        {
            // Snippet: CreateBranchRuleAsync(RepositoryName, BranchRule, string, CallSettings)
            // Additional: CreateBranchRuleAsync(RepositoryName, BranchRule, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            BranchRule branchRule = new BranchRule();
            string branchRuleId = "";
            // Make the request
            Operation<BranchRule, OperationMetadata> response = await secureSourceManagerClient.CreateBranchRuleAsync(parent, branchRule, branchRuleId);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBranchRules</summary>
        public void ListBranchRulesRequestObject()
        {
            // Snippet: ListBranchRules(ListBranchRulesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListBranchRulesRequest request = new ListBranchRulesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BranchRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBranchRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBranchRulesAsync</summary>
        public async Task ListBranchRulesRequestObjectAsync()
        {
            // Snippet: ListBranchRulesAsync(ListBranchRulesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListBranchRulesRequest request = new ListBranchRulesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BranchRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBranchRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBranchRules</summary>
        public void ListBranchRules()
        {
            // Snippet: ListBranchRules(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BranchRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBranchRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBranchRulesAsync</summary>
        public async Task ListBranchRulesAsync()
        {
            // Snippet: ListBranchRulesAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BranchRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBranchRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBranchRules</summary>
        public void ListBranchRulesResourceNames()
        {
            // Snippet: ListBranchRules(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BranchRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBranchRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBranchRulesAsync</summary>
        public async Task ListBranchRulesResourceNamesAsync()
        {
            // Snippet: ListBranchRulesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListBranchRulesResponse, BranchRule> response = secureSourceManagerClient.ListBranchRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BranchRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBranchRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BranchRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BranchRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BranchRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBranchRule</summary>
        public void GetBranchRuleRequestObject()
        {
            // Snippet: GetBranchRule(GetBranchRuleRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetBranchRuleRequest request = new GetBranchRuleRequest
            {
                BranchRuleName = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]"),
            };
            // Make the request
            BranchRule response = secureSourceManagerClient.GetBranchRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetBranchRuleAsync</summary>
        public async Task GetBranchRuleRequestObjectAsync()
        {
            // Snippet: GetBranchRuleAsync(GetBranchRuleRequest, CallSettings)
            // Additional: GetBranchRuleAsync(GetBranchRuleRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetBranchRuleRequest request = new GetBranchRuleRequest
            {
                BranchRuleName = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]"),
            };
            // Make the request
            BranchRule response = await secureSourceManagerClient.GetBranchRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBranchRule</summary>
        public void GetBranchRule()
        {
            // Snippet: GetBranchRule(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/branchRules/[BRANCH_RULE]";
            // Make the request
            BranchRule response = secureSourceManagerClient.GetBranchRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetBranchRuleAsync</summary>
        public async Task GetBranchRuleAsync()
        {
            // Snippet: GetBranchRuleAsync(string, CallSettings)
            // Additional: GetBranchRuleAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/branchRules/[BRANCH_RULE]";
            // Make the request
            BranchRule response = await secureSourceManagerClient.GetBranchRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBranchRule</summary>
        public void GetBranchRuleResourceNames()
        {
            // Snippet: GetBranchRule(BranchRuleName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            BranchRuleName name = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]");
            // Make the request
            BranchRule response = secureSourceManagerClient.GetBranchRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetBranchRuleAsync</summary>
        public async Task GetBranchRuleResourceNamesAsync()
        {
            // Snippet: GetBranchRuleAsync(BranchRuleName, CallSettings)
            // Additional: GetBranchRuleAsync(BranchRuleName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BranchRuleName name = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]");
            // Make the request
            BranchRule response = await secureSourceManagerClient.GetBranchRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBranchRule</summary>
        public void UpdateBranchRuleRequestObject()
        {
            // Snippet: UpdateBranchRule(UpdateBranchRuleRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdateBranchRuleRequest request = new UpdateBranchRuleRequest
            {
                BranchRule = new BranchRule(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BranchRule, OperationMetadata> response = secureSourceManagerClient.UpdateBranchRule(request);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBranchRuleAsync</summary>
        public async Task UpdateBranchRuleRequestObjectAsync()
        {
            // Snippet: UpdateBranchRuleAsync(UpdateBranchRuleRequest, CallSettings)
            // Additional: UpdateBranchRuleAsync(UpdateBranchRuleRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBranchRuleRequest request = new UpdateBranchRuleRequest
            {
                BranchRule = new BranchRule(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<BranchRule, OperationMetadata> response = await secureSourceManagerClient.UpdateBranchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBranchRule</summary>
        public void UpdateBranchRule()
        {
            // Snippet: UpdateBranchRule(BranchRule, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            BranchRule branchRule = new BranchRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BranchRule, OperationMetadata> response = secureSourceManagerClient.UpdateBranchRule(branchRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBranchRuleAsync</summary>
        public async Task UpdateBranchRuleAsync()
        {
            // Snippet: UpdateBranchRuleAsync(BranchRule, FieldMask, CallSettings)
            // Additional: UpdateBranchRuleAsync(BranchRule, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BranchRule branchRule = new BranchRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BranchRule, OperationMetadata> response = await secureSourceManagerClient.UpdateBranchRuleAsync(branchRule, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BranchRule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BranchRule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BranchRule, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BranchRule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRule</summary>
        public void DeleteBranchRuleRequestObject()
        {
            // Snippet: DeleteBranchRule(DeleteBranchRuleRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteBranchRuleRequest request = new DeleteBranchRuleRequest
            {
                BranchRuleName = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteBranchRule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRuleAsync</summary>
        public async Task DeleteBranchRuleRequestObjectAsync()
        {
            // Snippet: DeleteBranchRuleAsync(DeleteBranchRuleRequest, CallSettings)
            // Additional: DeleteBranchRuleAsync(DeleteBranchRuleRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBranchRuleRequest request = new DeleteBranchRuleRequest
            {
                BranchRuleName = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]"),
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteBranchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRule</summary>
        public void DeleteBranchRule()
        {
            // Snippet: DeleteBranchRule(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/branchRules/[BRANCH_RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteBranchRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRuleAsync</summary>
        public async Task DeleteBranchRuleAsync()
        {
            // Snippet: DeleteBranchRuleAsync(string, CallSettings)
            // Additional: DeleteBranchRuleAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/branchRules/[BRANCH_RULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteBranchRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteBranchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRule</summary>
        public void DeleteBranchRuleResourceNames()
        {
            // Snippet: DeleteBranchRule(BranchRuleName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            BranchRuleName name = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteBranchRule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteBranchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBranchRuleAsync</summary>
        public async Task DeleteBranchRuleResourceNamesAsync()
        {
            // Snippet: DeleteBranchRuleAsync(BranchRuleName, CallSettings)
            // Additional: DeleteBranchRuleAsync(BranchRuleName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BranchRuleName name = BranchRuleName.FromProjectLocationRepositoryBranchRule("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[BRANCH_RULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteBranchRuleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteBranchRuleAsync(operationName);
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
