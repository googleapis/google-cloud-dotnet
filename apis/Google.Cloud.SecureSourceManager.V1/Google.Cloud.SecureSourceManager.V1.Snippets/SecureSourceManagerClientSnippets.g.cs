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
    using System.Collections.Generic;
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

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepositoryRequestObject()
        {
            // Snippet: UpdateRepository(UpdateRepositoryRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new Repository(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = secureSourceManagerClient.UpdateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryRequestObjectAsync()
        {
            // Snippet: UpdateRepositoryAsync(UpdateRepositoryRequest, CallSettings)
            // Additional: UpdateRepositoryAsync(UpdateRepositoryRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRepositoryRequest request = new UpdateRepositoryRequest
            {
                UpdateMask = new FieldMask(),
                Repository = new Repository(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = await secureSourceManagerClient.UpdateRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRepository</summary>
        public void UpdateRepository()
        {
            // Snippet: UpdateRepository(Repository, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Repository, OperationMetadata> response = secureSourceManagerClient.UpdateRepository(repository, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRepositoryAsync</summary>
        public async Task UpdateRepositoryAsync()
        {
            // Snippet: UpdateRepositoryAsync(Repository, FieldMask, CallSettings)
            // Additional: UpdateRepositoryAsync(Repository, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            Repository repository = new Repository();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Repository, OperationMetadata> response = await secureSourceManagerClient.UpdateRepositoryAsync(repository, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateRepositoryAsync(operationName);
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

        /// <summary>Snippet for ListHooks</summary>
        public void ListHooksRequestObject()
        {
            // Snippet: ListHooks(ListHooksRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListHooksRequest request = new ListHooksRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHooksAsync</summary>
        public async Task ListHooksRequestObjectAsync()
        {
            // Snippet: ListHooksAsync(ListHooksRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListHooksRequest request = new ListHooksRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHooks</summary>
        public void ListHooks()
        {
            // Snippet: ListHooks(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHooksAsync</summary>
        public async Task ListHooksAsync()
        {
            // Snippet: ListHooksAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHooks</summary>
        public void ListHooksResourceNames()
        {
            // Snippet: ListHooks(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hook item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHooksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHooksAsync</summary>
        public async Task ListHooksResourceNamesAsync()
        {
            // Snippet: ListHooksAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListHooksResponse, Hook> response = secureSourceManagerClient.ListHooksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hook item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHooksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hook item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hook> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hook item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHook</summary>
        public void GetHookRequestObject()
        {
            // Snippet: GetHook(GetHookRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetHookRequest request = new GetHookRequest
            {
                HookName = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]"),
            };
            // Make the request
            Hook response = secureSourceManagerClient.GetHook(request);
            // End snippet
        }

        /// <summary>Snippet for GetHookAsync</summary>
        public async Task GetHookRequestObjectAsync()
        {
            // Snippet: GetHookAsync(GetHookRequest, CallSettings)
            // Additional: GetHookAsync(GetHookRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetHookRequest request = new GetHookRequest
            {
                HookName = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]"),
            };
            // Make the request
            Hook response = await secureSourceManagerClient.GetHookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHook</summary>
        public void GetHook()
        {
            // Snippet: GetHook(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/hooks/[HOOK]";
            // Make the request
            Hook response = secureSourceManagerClient.GetHook(name);
            // End snippet
        }

        /// <summary>Snippet for GetHookAsync</summary>
        public async Task GetHookAsync()
        {
            // Snippet: GetHookAsync(string, CallSettings)
            // Additional: GetHookAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/hooks/[HOOK]";
            // Make the request
            Hook response = await secureSourceManagerClient.GetHookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHook</summary>
        public void GetHookResourceNames()
        {
            // Snippet: GetHook(HookName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            HookName name = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]");
            // Make the request
            Hook response = secureSourceManagerClient.GetHook(name);
            // End snippet
        }

        /// <summary>Snippet for GetHookAsync</summary>
        public async Task GetHookResourceNamesAsync()
        {
            // Snippet: GetHookAsync(HookName, CallSettings)
            // Additional: GetHookAsync(HookName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            HookName name = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]");
            // Make the request
            Hook response = await secureSourceManagerClient.GetHookAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHook</summary>
        public void CreateHookRequestObject()
        {
            // Snippet: CreateHook(CreateHookRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateHookRequest request = new CreateHookRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Hook = new Hook(),
                HookId = "",
            };
            // Make the request
            Operation<Hook, OperationMetadata> response = secureSourceManagerClient.CreateHook(request);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHookAsync</summary>
        public async Task CreateHookRequestObjectAsync()
        {
            // Snippet: CreateHookAsync(CreateHookRequest, CallSettings)
            // Additional: CreateHookAsync(CreateHookRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateHookRequest request = new CreateHookRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Hook = new Hook(),
                HookId = "",
            };
            // Make the request
            Operation<Hook, OperationMetadata> response = await secureSourceManagerClient.CreateHookAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHook</summary>
        public void CreateHook()
        {
            // Snippet: CreateHook(string, Hook, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Hook hook = new Hook();
            string hookId = "";
            // Make the request
            Operation<Hook, OperationMetadata> response = secureSourceManagerClient.CreateHook(parent, hook, hookId);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHookAsync</summary>
        public async Task CreateHookAsync()
        {
            // Snippet: CreateHookAsync(string, Hook, string, CallSettings)
            // Additional: CreateHookAsync(string, Hook, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Hook hook = new Hook();
            string hookId = "";
            // Make the request
            Operation<Hook, OperationMetadata> response = await secureSourceManagerClient.CreateHookAsync(parent, hook, hookId);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHook</summary>
        public void CreateHookResourceNames()
        {
            // Snippet: CreateHook(RepositoryName, Hook, string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Hook hook = new Hook();
            string hookId = "";
            // Make the request
            Operation<Hook, OperationMetadata> response = secureSourceManagerClient.CreateHook(parent, hook, hookId);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHookAsync</summary>
        public async Task CreateHookResourceNamesAsync()
        {
            // Snippet: CreateHookAsync(RepositoryName, Hook, string, CallSettings)
            // Additional: CreateHookAsync(RepositoryName, Hook, string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Hook hook = new Hook();
            string hookId = "";
            // Make the request
            Operation<Hook, OperationMetadata> response = await secureSourceManagerClient.CreateHookAsync(parent, hook, hookId);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHook</summary>
        public void UpdateHookRequestObject()
        {
            // Snippet: UpdateHook(UpdateHookRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdateHookRequest request = new UpdateHookRequest
            {
                UpdateMask = new FieldMask(),
                Hook = new Hook(),
            };
            // Make the request
            Operation<Hook, OperationMetadata> response = secureSourceManagerClient.UpdateHook(request);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHookAsync</summary>
        public async Task UpdateHookRequestObjectAsync()
        {
            // Snippet: UpdateHookAsync(UpdateHookRequest, CallSettings)
            // Additional: UpdateHookAsync(UpdateHookRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHookRequest request = new UpdateHookRequest
            {
                UpdateMask = new FieldMask(),
                Hook = new Hook(),
            };
            // Make the request
            Operation<Hook, OperationMetadata> response = await secureSourceManagerClient.UpdateHookAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHook</summary>
        public void UpdateHook()
        {
            // Snippet: UpdateHook(Hook, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            Hook hook = new Hook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hook, OperationMetadata> response = secureSourceManagerClient.UpdateHook(hook, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHookAsync</summary>
        public async Task UpdateHookAsync()
        {
            // Snippet: UpdateHookAsync(Hook, FieldMask, CallSettings)
            // Additional: UpdateHookAsync(Hook, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            Hook hook = new Hook();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hook, OperationMetadata> response = await secureSourceManagerClient.UpdateHookAsync(hook, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hook, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hook result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hook, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hook retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHook</summary>
        public void DeleteHookRequestObject()
        {
            // Snippet: DeleteHook(DeleteHookRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteHookRequest request = new DeleteHookRequest
            {
                HookName = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteHook(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHookAsync</summary>
        public async Task DeleteHookRequestObjectAsync()
        {
            // Snippet: DeleteHookAsync(DeleteHookRequest, CallSettings)
            // Additional: DeleteHookAsync(DeleteHookRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHookRequest request = new DeleteHookRequest
            {
                HookName = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteHookAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHook</summary>
        public void DeleteHook()
        {
            // Snippet: DeleteHook(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/hooks/[HOOK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteHook(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHookAsync</summary>
        public async Task DeleteHookAsync()
        {
            // Snippet: DeleteHookAsync(string, CallSettings)
            // Additional: DeleteHookAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/hooks/[HOOK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteHookAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteHookAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHook</summary>
        public void DeleteHookResourceNames()
        {
            // Snippet: DeleteHook(HookName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            HookName name = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteHook(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteHook(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHookAsync</summary>
        public async Task DeleteHookResourceNamesAsync()
        {
            // Snippet: DeleteHookAsync(HookName, CallSettings)
            // Additional: DeleteHookAsync(HookName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            HookName name = HookName.FromProjectLocationRepositoryHook("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[HOOK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteHookAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteHookAsync(operationName);
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

        /// <summary>Snippet for CreatePullRequest</summary>
        public void CreatePullRequestRequestObject()
        {
            // Snippet: CreatePullRequest(CreatePullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreatePullRequestRequest request = new CreatePullRequestRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                PullRequest = new PullRequest(),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.CreatePullRequest(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestAsync</summary>
        public async Task CreatePullRequestRequestObjectAsync()
        {
            // Snippet: CreatePullRequestAsync(CreatePullRequestRequest, CallSettings)
            // Additional: CreatePullRequestAsync(CreatePullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreatePullRequestRequest request = new CreatePullRequestRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                PullRequest = new PullRequest(),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequest</summary>
        public void CreatePullRequest()
        {
            // Snippet: CreatePullRequest(string, PullRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            PullRequest pullRequest = new PullRequest();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.CreatePullRequest(parent, pullRequest);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestAsync</summary>
        public async Task CreatePullRequestAsync()
        {
            // Snippet: CreatePullRequestAsync(string, PullRequest, CallSettings)
            // Additional: CreatePullRequestAsync(string, PullRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            PullRequest pullRequest = new PullRequest();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestAsync(parent, pullRequest);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequest</summary>
        public void CreatePullRequestResourceNames()
        {
            // Snippet: CreatePullRequest(RepositoryName, PullRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            PullRequest pullRequest = new PullRequest();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.CreatePullRequest(parent, pullRequest);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestAsync</summary>
        public async Task CreatePullRequestResourceNamesAsync()
        {
            // Snippet: CreatePullRequestAsync(RepositoryName, PullRequest, CallSettings)
            // Additional: CreatePullRequestAsync(RepositoryName, PullRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            PullRequest pullRequest = new PullRequest();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestAsync(parent, pullRequest);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPullRequest</summary>
        public void GetPullRequestRequestObject()
        {
            // Snippet: GetPullRequest(GetPullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetPullRequestRequest request = new GetPullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PullRequest response = secureSourceManagerClient.GetPullRequest(request);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestAsync</summary>
        public async Task GetPullRequestRequestObjectAsync()
        {
            // Snippet: GetPullRequestAsync(GetPullRequestRequest, CallSettings)
            // Additional: GetPullRequestAsync(GetPullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetPullRequestRequest request = new GetPullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PullRequest response = await secureSourceManagerClient.GetPullRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequest</summary>
        public void GetPullRequest()
        {
            // Snippet: GetPullRequest(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PullRequest response = secureSourceManagerClient.GetPullRequest(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestAsync</summary>
        public async Task GetPullRequestAsync()
        {
            // Snippet: GetPullRequestAsync(string, CallSettings)
            // Additional: GetPullRequestAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PullRequest response = await secureSourceManagerClient.GetPullRequestAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequest</summary>
        public void GetPullRequestResourceNames()
        {
            // Snippet: GetPullRequest(PullRequestName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PullRequest response = secureSourceManagerClient.GetPullRequest(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestAsync</summary>
        public async Task GetPullRequestResourceNamesAsync()
        {
            // Snippet: GetPullRequestAsync(PullRequestName, CallSettings)
            // Additional: GetPullRequestAsync(PullRequestName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PullRequest response = await secureSourceManagerClient.GetPullRequestAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPullRequests</summary>
        public void ListPullRequestsRequestObject()
        {
            // Snippet: ListPullRequests(ListPullRequestsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListPullRequestsRequest request = new ListPullRequestsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequests(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestsAsync</summary>
        public async Task ListPullRequestsRequestObjectAsync()
        {
            // Snippet: ListPullRequestsAsync(ListPullRequestsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListPullRequestsRequest request = new ListPullRequestsRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequestsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequests</summary>
        public void ListPullRequests()
        {
            // Snippet: ListPullRequests(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestsAsync</summary>
        public async Task ListPullRequestsAsync()
        {
            // Snippet: ListPullRequestsAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequests</summary>
        public void ListPullRequestsResourceNames()
        {
            // Snippet: ListPullRequests(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestsAsync</summary>
        public async Task ListPullRequestsResourceNamesAsync()
        {
            // Snippet: ListPullRequestsAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListPullRequestsResponse, PullRequest> response = secureSourceManagerClient.ListPullRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequest</summary>
        public void UpdatePullRequestRequestObject()
        {
            // Snippet: UpdatePullRequest(UpdatePullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdatePullRequestRequest request = new UpdatePullRequestRequest
            {
                PullRequest = new PullRequest(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.UpdatePullRequest(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdatePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestAsync</summary>
        public async Task UpdatePullRequestRequestObjectAsync()
        {
            // Snippet: UpdatePullRequestAsync(UpdatePullRequestRequest, CallSettings)
            // Additional: UpdatePullRequestAsync(UpdatePullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePullRequestRequest request = new UpdatePullRequestRequest
            {
                PullRequest = new PullRequest(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.UpdatePullRequestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdatePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequest</summary>
        public void UpdatePullRequest()
        {
            // Snippet: UpdatePullRequest(PullRequest, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequest pullRequest = new PullRequest();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.UpdatePullRequest(pullRequest, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdatePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestAsync</summary>
        public async Task UpdatePullRequestAsync()
        {
            // Snippet: UpdatePullRequestAsync(PullRequest, FieldMask, CallSettings)
            // Additional: UpdatePullRequestAsync(PullRequest, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequest pullRequest = new PullRequest();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.UpdatePullRequestAsync(pullRequest, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdatePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequest</summary>
        public void MergePullRequestRequestObject()
        {
            // Snippet: MergePullRequest(MergePullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            MergePullRequestRequest request = new MergePullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.MergePullRequest(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceMergePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequestAsync</summary>
        public async Task MergePullRequestRequestObjectAsync()
        {
            // Snippet: MergePullRequestAsync(MergePullRequestRequest, CallSettings)
            // Additional: MergePullRequestAsync(MergePullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            MergePullRequestRequest request = new MergePullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.MergePullRequestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceMergePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequest</summary>
        public void MergePullRequest()
        {
            // Snippet: MergePullRequest(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.MergePullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceMergePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequestAsync</summary>
        public async Task MergePullRequestAsync()
        {
            // Snippet: MergePullRequestAsync(string, CallSettings)
            // Additional: MergePullRequestAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.MergePullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceMergePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequest</summary>
        public void MergePullRequestResourceNames()
        {
            // Snippet: MergePullRequest(PullRequestName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.MergePullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceMergePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MergePullRequestAsync</summary>
        public async Task MergePullRequestResourceNamesAsync()
        {
            // Snippet: MergePullRequestAsync(PullRequestName, CallSettings)
            // Additional: MergePullRequestAsync(PullRequestName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.MergePullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceMergePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequest</summary>
        public void OpenPullRequestRequestObject()
        {
            // Snippet: OpenPullRequest(OpenPullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            OpenPullRequestRequest request = new OpenPullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.OpenPullRequest(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenPullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequestAsync</summary>
        public async Task OpenPullRequestRequestObjectAsync()
        {
            // Snippet: OpenPullRequestAsync(OpenPullRequestRequest, CallSettings)
            // Additional: OpenPullRequestAsync(OpenPullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            OpenPullRequestRequest request = new OpenPullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.OpenPullRequestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenPullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequest</summary>
        public void OpenPullRequest()
        {
            // Snippet: OpenPullRequest(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.OpenPullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenPullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequestAsync</summary>
        public async Task OpenPullRequestAsync()
        {
            // Snippet: OpenPullRequestAsync(string, CallSettings)
            // Additional: OpenPullRequestAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.OpenPullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenPullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequest</summary>
        public void OpenPullRequestResourceNames()
        {
            // Snippet: OpenPullRequest(PullRequestName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.OpenPullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenPullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenPullRequestAsync</summary>
        public async Task OpenPullRequestResourceNamesAsync()
        {
            // Snippet: OpenPullRequestAsync(PullRequestName, CallSettings)
            // Additional: OpenPullRequestAsync(PullRequestName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.OpenPullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenPullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequest</summary>
        public void ClosePullRequestRequestObject()
        {
            // Snippet: ClosePullRequest(ClosePullRequestRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ClosePullRequestRequest request = new ClosePullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.ClosePullRequest(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceClosePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequestAsync</summary>
        public async Task ClosePullRequestRequestObjectAsync()
        {
            // Snippet: ClosePullRequestAsync(ClosePullRequestRequest, CallSettings)
            // Additional: ClosePullRequestAsync(ClosePullRequestRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ClosePullRequestRequest request = new ClosePullRequestRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.ClosePullRequestAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceClosePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequest</summary>
        public void ClosePullRequest()
        {
            // Snippet: ClosePullRequest(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.ClosePullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceClosePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequestAsync</summary>
        public async Task ClosePullRequestAsync()
        {
            // Snippet: ClosePullRequestAsync(string, CallSettings)
            // Additional: ClosePullRequestAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.ClosePullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceClosePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequest</summary>
        public void ClosePullRequestResourceNames()
        {
            // Snippet: ClosePullRequest(PullRequestName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = secureSourceManagerClient.ClosePullRequest(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceClosePullRequest(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ClosePullRequestAsync</summary>
        public async Task ClosePullRequestResourceNamesAsync()
        {
            // Snippet: ClosePullRequestAsync(PullRequestName, CallSettings)
            // Additional: ClosePullRequestAsync(PullRequestName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            Operation<PullRequest, OperationMetadata> response = await secureSourceManagerClient.ClosePullRequestAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<PullRequest, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequest result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequest, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceClosePullRequestAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequest retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffs</summary>
        public void ListPullRequestFileDiffsRequestObject()
        {
            // Snippet: ListPullRequestFileDiffs(ListPullRequestFileDiffsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileDiff item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestFileDiffsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffsAsync</summary>
        public async Task ListPullRequestFileDiffsRequestObjectAsync()
        {
            // Snippet: ListPullRequestFileDiffsAsync(ListPullRequestFileDiffsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListPullRequestFileDiffsRequest request = new ListPullRequestFileDiffsRequest
            {
                PullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileDiff item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestFileDiffsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffs</summary>
        public void ListPullRequestFileDiffs()
        {
            // Snippet: ListPullRequestFileDiffs(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffs(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileDiff item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestFileDiffsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffsAsync</summary>
        public async Task ListPullRequestFileDiffsAsync()
        {
            // Snippet: ListPullRequestFileDiffsAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileDiff item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestFileDiffsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffs</summary>
        public void ListPullRequestFileDiffsResourceNames()
        {
            // Snippet: ListPullRequestFileDiffs(PullRequestName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PagedEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffs(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FileDiff item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestFileDiffsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestFileDiffsAsync</summary>
        public async Task ListPullRequestFileDiffsResourceNamesAsync()
        {
            // Snippet: ListPullRequestFileDiffsAsync(PullRequestName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName name = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PagedAsyncEnumerable<ListPullRequestFileDiffsResponse, FileDiff> response = secureSourceManagerClient.ListPullRequestFileDiffsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FileDiff item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestFileDiffsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FileDiff item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FileDiff> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FileDiff item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchTree</summary>
        public void FetchTreeRequestObject()
        {
            // Snippet: FetchTree(FetchTreeRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            FetchTreeRequest request = new FetchTreeRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Ref = "",
                Recursive = false,
            };
            // Make the request
            PagedEnumerable<FetchTreeResponse, TreeEntry> response = secureSourceManagerClient.FetchTree(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TreeEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchTreeResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TreeEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TreeEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TreeEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchTreeAsync</summary>
        public async Task FetchTreeRequestObjectAsync()
        {
            // Snippet: FetchTreeAsync(FetchTreeRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchTreeRequest request = new FetchTreeRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Ref = "",
                Recursive = false,
            };
            // Make the request
            PagedAsyncEnumerable<FetchTreeResponse, TreeEntry> response = secureSourceManagerClient.FetchTreeAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TreeEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchTreeResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TreeEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TreeEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TreeEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchBlob</summary>
        public void FetchBlobRequestObject()
        {
            // Snippet: FetchBlob(FetchBlobRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            FetchBlobRequest request = new FetchBlobRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Sha = "",
            };
            // Make the request
            FetchBlobResponse response = secureSourceManagerClient.FetchBlob(request);
            // End snippet
        }

        /// <summary>Snippet for FetchBlobAsync</summary>
        public async Task FetchBlobRequestObjectAsync()
        {
            // Snippet: FetchBlobAsync(FetchBlobRequest, CallSettings)
            // Additional: FetchBlobAsync(FetchBlobRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchBlobRequest request = new FetchBlobRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Sha = "",
            };
            // Make the request
            FetchBlobResponse response = await secureSourceManagerClient.FetchBlobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIssue</summary>
        public void CreateIssueRequestObject()
        {
            // Snippet: CreateIssue(CreateIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateIssueRequest request = new CreateIssueRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Issue = new Issue(),
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CreateIssue(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueAsync</summary>
        public async Task CreateIssueRequestObjectAsync()
        {
            // Snippet: CreateIssueAsync(CreateIssueRequest, CallSettings)
            // Additional: CreateIssueAsync(CreateIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateIssueRequest request = new CreateIssueRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Issue = new Issue(),
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CreateIssueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssue</summary>
        public void CreateIssue()
        {
            // Snippet: CreateIssue(string, Issue, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Issue issue = new Issue();
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CreateIssue(parent, issue);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueAsync</summary>
        public async Task CreateIssueAsync()
        {
            // Snippet: CreateIssueAsync(string, Issue, CallSettings)
            // Additional: CreateIssueAsync(string, Issue, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            Issue issue = new Issue();
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CreateIssueAsync(parent, issue);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssue</summary>
        public void CreateIssueResourceNames()
        {
            // Snippet: CreateIssue(RepositoryName, Issue, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Issue issue = new Issue();
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CreateIssue(parent, issue);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueAsync</summary>
        public async Task CreateIssueResourceNamesAsync()
        {
            // Snippet: CreateIssueAsync(RepositoryName, Issue, CallSettings)
            // Additional: CreateIssueAsync(RepositoryName, Issue, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            Issue issue = new Issue();
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CreateIssueAsync(parent, issue);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssueRequestObject()
        {
            // Snippet: GetIssue(GetIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
            };
            // Make the request
            Issue response = secureSourceManagerClient.GetIssue(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueRequestObjectAsync()
        {
            // Snippet: GetIssueAsync(GetIssueRequest, CallSettings)
            // Additional: GetIssueAsync(GetIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
            };
            // Make the request
            Issue response = await secureSourceManagerClient.GetIssueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssue()
        {
            // Snippet: GetIssue(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Issue response = secureSourceManagerClient.GetIssue(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueAsync()
        {
            // Snippet: GetIssueAsync(string, CallSettings)
            // Additional: GetIssueAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Issue response = await secureSourceManagerClient.GetIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssueResourceNames()
        {
            // Snippet: GetIssue(IssueName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Issue response = secureSourceManagerClient.GetIssue(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueResourceNamesAsync()
        {
            // Snippet: GetIssueAsync(IssueName, CallSettings)
            // Additional: GetIssueAsync(IssueName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Issue response = await secureSourceManagerClient.GetIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssuesRequestObject()
        {
            // Snippet: ListIssues(ListIssuesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Issue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesRequestObjectAsync()
        {
            // Snippet: ListIssuesAsync(ListIssuesRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsRepositoryName = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Issue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssues()
        {
            // Snippet: ListIssues(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Issue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesAsync()
        {
            // Snippet: ListIssuesAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            PagedAsyncEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Issue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssuesResourceNames()
        {
            // Snippet: ListIssues(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Issue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesResourceNamesAsync()
        {
            // Snippet: ListIssuesAsync(RepositoryName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName parent = RepositoryName.FromProjectLocationRepository("[PROJECT]", "[LOCATION]", "[REPOSITORY]");
            // Make the request
            PagedAsyncEnumerable<ListIssuesResponse, Issue> response = secureSourceManagerClient.ListIssuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Issue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Issue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Issue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Issue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIssue</summary>
        public void UpdateIssueRequestObject()
        {
            // Snippet: UpdateIssue(UpdateIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.UpdateIssue(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueAsync</summary>
        public async Task UpdateIssueRequestObjectAsync()
        {
            // Snippet: UpdateIssueAsync(UpdateIssueRequest, CallSettings)
            // Additional: UpdateIssueAsync(UpdateIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.UpdateIssueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssue</summary>
        public void UpdateIssue()
        {
            // Snippet: UpdateIssue(Issue, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            Issue issue = new Issue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.UpdateIssue(issue, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueAsync</summary>
        public async Task UpdateIssueAsync()
        {
            // Snippet: UpdateIssueAsync(Issue, FieldMask, CallSettings)
            // Additional: UpdateIssueAsync(Issue, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            Issue issue = new Issue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.UpdateIssueAsync(issue, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssueRequestObject()
        {
            // Snippet: DeleteIssue(DeleteIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteIssueRequest request = new DeleteIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssue(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueRequestObjectAsync()
        {
            // Snippet: DeleteIssueAsync(DeleteIssueRequest, CallSettings)
            // Additional: DeleteIssueAsync(DeleteIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIssueRequest request = new DeleteIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssue()
        {
            // Snippet: DeleteIssue(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueAsync()
        {
            // Snippet: DeleteIssueAsync(string, CallSettings)
            // Additional: DeleteIssueAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssueResourceNames()
        {
            // Snippet: DeleteIssue(IssueName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueResourceNamesAsync()
        {
            // Snippet: DeleteIssueAsync(IssueName, CallSettings)
            // Additional: DeleteIssueAsync(IssueName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssue</summary>
        public void OpenIssueRequestObject()
        {
            // Snippet: OpenIssue(OpenIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            OpenIssueRequest request = new OpenIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.OpenIssue(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssueAsync</summary>
        public async Task OpenIssueRequestObjectAsync()
        {
            // Snippet: OpenIssueAsync(OpenIssueRequest, CallSettings)
            // Additional: OpenIssueAsync(OpenIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            OpenIssueRequest request = new OpenIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.OpenIssueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssue</summary>
        public void OpenIssue()
        {
            // Snippet: OpenIssue(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.OpenIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssueAsync</summary>
        public async Task OpenIssueAsync()
        {
            // Snippet: OpenIssueAsync(string, CallSettings)
            // Additional: OpenIssueAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.OpenIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssue</summary>
        public void OpenIssueResourceNames()
        {
            // Snippet: OpenIssue(IssueName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.OpenIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceOpenIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for OpenIssueAsync</summary>
        public async Task OpenIssueResourceNamesAsync()
        {
            // Snippet: OpenIssueAsync(IssueName, CallSettings)
            // Additional: OpenIssueAsync(IssueName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.OpenIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceOpenIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssue</summary>
        public void CloseIssueRequestObject()
        {
            // Snippet: CloseIssue(CloseIssueRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CloseIssueRequest request = new CloseIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CloseIssue(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCloseIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssueAsync</summary>
        public async Task CloseIssueRequestObjectAsync()
        {
            // Snippet: CloseIssueAsync(CloseIssueRequest, CallSettings)
            // Additional: CloseIssueAsync(CloseIssueRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CloseIssueRequest request = new CloseIssueRequest
            {
                IssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                Etag = "",
            };
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CloseIssueAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCloseIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssue</summary>
        public void CloseIssue()
        {
            // Snippet: CloseIssue(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CloseIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCloseIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssueAsync</summary>
        public async Task CloseIssueAsync()
        {
            // Snippet: CloseIssueAsync(string, CallSettings)
            // Additional: CloseIssueAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CloseIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCloseIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssue</summary>
        public void CloseIssueResourceNames()
        {
            // Snippet: CloseIssue(IssueName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Issue, OperationMetadata> response = secureSourceManagerClient.CloseIssue(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCloseIssue(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloseIssueAsync</summary>
        public async Task CloseIssueResourceNamesAsync()
        {
            // Snippet: CloseIssueAsync(IssueName, CallSettings)
            // Additional: CloseIssueAsync(IssueName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            Operation<Issue, OperationMetadata> response = await secureSourceManagerClient.CloseIssueAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Issue, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Issue result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Issue, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCloseIssueAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Issue retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestComment</summary>
        public void GetPullRequestCommentRequestObject()
        {
            // Snippet: GetPullRequestComment(GetPullRequestCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetPullRequestCommentRequest request = new GetPullRequestCommentRequest
            {
                PullRequestCommentName = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            PullRequestComment response = secureSourceManagerClient.GetPullRequestComment(request);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestCommentAsync</summary>
        public async Task GetPullRequestCommentRequestObjectAsync()
        {
            // Snippet: GetPullRequestCommentAsync(GetPullRequestCommentRequest, CallSettings)
            // Additional: GetPullRequestCommentAsync(GetPullRequestCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetPullRequestCommentRequest request = new GetPullRequestCommentRequest
            {
                PullRequestCommentName = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            PullRequestComment response = await secureSourceManagerClient.GetPullRequestCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestComment</summary>
        public void GetPullRequestComment()
        {
            // Snippet: GetPullRequestComment(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]";
            // Make the request
            PullRequestComment response = secureSourceManagerClient.GetPullRequestComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestCommentAsync</summary>
        public async Task GetPullRequestCommentAsync()
        {
            // Snippet: GetPullRequestCommentAsync(string, CallSettings)
            // Additional: GetPullRequestCommentAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]";
            // Make the request
            PullRequestComment response = await secureSourceManagerClient.GetPullRequestCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestComment</summary>
        public void GetPullRequestCommentResourceNames()
        {
            // Snippet: GetPullRequestComment(PullRequestCommentName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestCommentName name = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]");
            // Make the request
            PullRequestComment response = secureSourceManagerClient.GetPullRequestComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetPullRequestCommentAsync</summary>
        public async Task GetPullRequestCommentResourceNamesAsync()
        {
            // Snippet: GetPullRequestCommentAsync(PullRequestCommentName, CallSettings)
            // Additional: GetPullRequestCommentAsync(PullRequestCommentName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestCommentName name = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]");
            // Make the request
            PullRequestComment response = await secureSourceManagerClient.GetPullRequestCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestComments</summary>
        public void ListPullRequestCommentsRequestObject()
        {
            // Snippet: ListPullRequestComments(ListPullRequestCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestComments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequestComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestCommentsAsync</summary>
        public async Task ListPullRequestCommentsRequestObjectAsync()
        {
            // Snippet: ListPullRequestCommentsAsync(ListPullRequestCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListPullRequestCommentsRequest request = new ListPullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestCommentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequestComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestComments</summary>
        public void ListPullRequestComments()
        {
            // Snippet: ListPullRequestComments(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequestComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestCommentsAsync</summary>
        public async Task ListPullRequestCommentsAsync()
        {
            // Snippet: ListPullRequestCommentsAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            // Make the request
            PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequestComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestComments</summary>
        public void ListPullRequestCommentsResourceNames()
        {
            // Snippet: ListPullRequestComments(PullRequestName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PagedEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequestComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPullRequestCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPullRequestCommentsAsync</summary>
        public async Task ListPullRequestCommentsResourceNamesAsync()
        {
            // Snippet: ListPullRequestCommentsAsync(PullRequestName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            // Make the request
            PagedAsyncEnumerable<ListPullRequestCommentsResponse, PullRequestComment> response = secureSourceManagerClient.ListPullRequestCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PullRequestComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPullRequestCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequestComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequestComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequestComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestComment</summary>
        public void CreatePullRequestCommentRequestObject()
        {
            // Snippet: CreatePullRequestComment(CreatePullRequestCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreatePullRequestCommentRequest request = new CreatePullRequestCommentRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestComment = new PullRequestComment(),
            };
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = secureSourceManagerClient.CreatePullRequestComment(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestCommentAsync</summary>
        public async Task CreatePullRequestCommentRequestObjectAsync()
        {
            // Snippet: CreatePullRequestCommentAsync(CreatePullRequestCommentRequest, CallSettings)
            // Additional: CreatePullRequestCommentAsync(CreatePullRequestCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreatePullRequestCommentRequest request = new CreatePullRequestCommentRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestComment = new PullRequestComment(),
            };
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestComment</summary>
        public void CreatePullRequestComment()
        {
            // Snippet: CreatePullRequestComment(string, PullRequestComment, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            PullRequestComment pullRequestComment = new PullRequestComment();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = secureSourceManagerClient.CreatePullRequestComment(parent, pullRequestComment);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestCommentAsync</summary>
        public async Task CreatePullRequestCommentAsync()
        {
            // Snippet: CreatePullRequestCommentAsync(string, PullRequestComment, CallSettings)
            // Additional: CreatePullRequestCommentAsync(string, PullRequestComment, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            PullRequestComment pullRequestComment = new PullRequestComment();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestCommentAsync(parent, pullRequestComment);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestComment</summary>
        public void CreatePullRequestCommentResourceNames()
        {
            // Snippet: CreatePullRequestComment(PullRequestName, PullRequestComment, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            PullRequestComment pullRequestComment = new PullRequestComment();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = secureSourceManagerClient.CreatePullRequestComment(parent, pullRequestComment);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreatePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePullRequestCommentAsync</summary>
        public async Task CreatePullRequestCommentResourceNamesAsync()
        {
            // Snippet: CreatePullRequestCommentAsync(PullRequestName, PullRequestComment, CallSettings)
            // Additional: CreatePullRequestCommentAsync(PullRequestName, PullRequestComment, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            PullRequestComment pullRequestComment = new PullRequestComment();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = await secureSourceManagerClient.CreatePullRequestCommentAsync(parent, pullRequestComment);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreatePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestComment</summary>
        public void UpdatePullRequestCommentRequestObject()
        {
            // Snippet: UpdatePullRequestComment(UpdatePullRequestCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdatePullRequestCommentRequest request = new UpdatePullRequestCommentRequest
            {
                PullRequestComment = new PullRequestComment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = secureSourceManagerClient.UpdatePullRequestComment(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdatePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestCommentAsync</summary>
        public async Task UpdatePullRequestCommentRequestObjectAsync()
        {
            // Snippet: UpdatePullRequestCommentAsync(UpdatePullRequestCommentRequest, CallSettings)
            // Additional: UpdatePullRequestCommentAsync(UpdatePullRequestCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePullRequestCommentRequest request = new UpdatePullRequestCommentRequest
            {
                PullRequestComment = new PullRequestComment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = await secureSourceManagerClient.UpdatePullRequestCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdatePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestComment</summary>
        public void UpdatePullRequestComment()
        {
            // Snippet: UpdatePullRequestComment(PullRequestComment, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestComment pullRequestComment = new PullRequestComment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = secureSourceManagerClient.UpdatePullRequestComment(pullRequestComment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdatePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePullRequestCommentAsync</summary>
        public async Task UpdatePullRequestCommentAsync()
        {
            // Snippet: UpdatePullRequestCommentAsync(PullRequestComment, FieldMask, CallSettings)
            // Additional: UpdatePullRequestCommentAsync(PullRequestComment, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestComment pullRequestComment = new PullRequestComment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PullRequestComment, OperationMetadata> response = await secureSourceManagerClient.UpdatePullRequestCommentAsync(pullRequestComment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PullRequestComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PullRequestComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PullRequestComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdatePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PullRequestComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestComment</summary>
        public void DeletePullRequestCommentRequestObject()
        {
            // Snippet: DeletePullRequestComment(DeletePullRequestCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeletePullRequestCommentRequest request = new DeletePullRequestCommentRequest
            {
                PullRequestCommentName = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeletePullRequestComment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeletePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestCommentAsync</summary>
        public async Task DeletePullRequestCommentRequestObjectAsync()
        {
            // Snippet: DeletePullRequestCommentAsync(DeletePullRequestCommentRequest, CallSettings)
            // Additional: DeletePullRequestCommentAsync(DeletePullRequestCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeletePullRequestCommentRequest request = new DeletePullRequestCommentRequest
            {
                PullRequestCommentName = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeletePullRequestCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeletePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestComment</summary>
        public void DeletePullRequestComment()
        {
            // Snippet: DeletePullRequestComment(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeletePullRequestComment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeletePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestCommentAsync</summary>
        public async Task DeletePullRequestCommentAsync()
        {
            // Snippet: DeletePullRequestCommentAsync(string, CallSettings)
            // Additional: DeletePullRequestCommentAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeletePullRequestCommentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeletePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestComment</summary>
        public void DeletePullRequestCommentResourceNames()
        {
            // Snippet: DeletePullRequestComment(PullRequestCommentName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestCommentName name = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeletePullRequestComment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeletePullRequestComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePullRequestCommentAsync</summary>
        public async Task DeletePullRequestCommentResourceNamesAsync()
        {
            // Snippet: DeletePullRequestCommentAsync(PullRequestCommentName, CallSettings)
            // Additional: DeletePullRequestCommentAsync(PullRequestCommentName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestCommentName name = PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeletePullRequestCommentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeletePullRequestCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestComments</summary>
        public void BatchCreatePullRequestCommentsRequestObject()
        {
            // Snippet: BatchCreatePullRequestComments(BatchCreatePullRequestCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            BatchCreatePullRequestCommentsRequest request = new BatchCreatePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                Requests =
                {
                    new CreatePullRequestCommentRequest(),
                },
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.BatchCreatePullRequestComments(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceBatchCreatePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestCommentsAsync</summary>
        public async Task BatchCreatePullRequestCommentsRequestObjectAsync()
        {
            // Snippet: BatchCreatePullRequestCommentsAsync(BatchCreatePullRequestCommentsRequest, CallSettings)
            // Additional: BatchCreatePullRequestCommentsAsync(BatchCreatePullRequestCommentsRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreatePullRequestCommentsRequest request = new BatchCreatePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                Requests =
                {
                    new CreatePullRequestCommentRequest(),
                },
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.BatchCreatePullRequestCommentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceBatchCreatePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestComments</summary>
        public void BatchCreatePullRequestComments()
        {
            // Snippet: BatchCreatePullRequestComments(string, IEnumerable<CreatePullRequestCommentRequest>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<CreatePullRequestCommentRequest> requests = new CreatePullRequestCommentRequest[]
            {
                new CreatePullRequestCommentRequest(),
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.BatchCreatePullRequestComments(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceBatchCreatePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestCommentsAsync</summary>
        public async Task BatchCreatePullRequestCommentsAsync()
        {
            // Snippet: BatchCreatePullRequestCommentsAsync(string, IEnumerable<CreatePullRequestCommentRequest>, CallSettings)
            // Additional: BatchCreatePullRequestCommentsAsync(string, IEnumerable<CreatePullRequestCommentRequest>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<CreatePullRequestCommentRequest> requests = new CreatePullRequestCommentRequest[]
            {
                new CreatePullRequestCommentRequest(),
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.BatchCreatePullRequestCommentsAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceBatchCreatePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestComments</summary>
        public void BatchCreatePullRequestCommentsResourceNames()
        {
            // Snippet: BatchCreatePullRequestComments(PullRequestName, IEnumerable<CreatePullRequestCommentRequest>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<CreatePullRequestCommentRequest> requests = new CreatePullRequestCommentRequest[]
            {
                new CreatePullRequestCommentRequest(),
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.BatchCreatePullRequestComments(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceBatchCreatePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreatePullRequestCommentsAsync</summary>
        public async Task BatchCreatePullRequestCommentsResourceNamesAsync()
        {
            // Snippet: BatchCreatePullRequestCommentsAsync(PullRequestName, IEnumerable<CreatePullRequestCommentRequest>, CallSettings)
            // Additional: BatchCreatePullRequestCommentsAsync(PullRequestName, IEnumerable<CreatePullRequestCommentRequest>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<CreatePullRequestCommentRequest> requests = new CreatePullRequestCommentRequest[]
            {
                new CreatePullRequestCommentRequest(),
            };
            // Make the request
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.BatchCreatePullRequestCommentsAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreatePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreatePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceBatchCreatePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreatePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestComments</summary>
        public void ResolvePullRequestCommentsRequestObject()
        {
            // Snippet: ResolvePullRequestComments(ResolvePullRequestCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ResolvePullRequestCommentsRequest request = new ResolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestCommentNames =
                {
                    PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
                },
                AutoFill = false,
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.ResolvePullRequestComments(request);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceResolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestCommentsAsync</summary>
        public async Task ResolvePullRequestCommentsRequestObjectAsync()
        {
            // Snippet: ResolvePullRequestCommentsAsync(ResolvePullRequestCommentsRequest, CallSettings)
            // Additional: ResolvePullRequestCommentsAsync(ResolvePullRequestCommentsRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ResolvePullRequestCommentsRequest request = new ResolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestCommentNames =
                {
                    PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
                },
                AutoFill = false,
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.ResolvePullRequestCommentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceResolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestComments</summary>
        public void ResolvePullRequestComments()
        {
            // Snippet: ResolvePullRequestComments(string, IEnumerable<string>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]",
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.ResolvePullRequestComments(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceResolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestCommentsAsync</summary>
        public async Task ResolvePullRequestCommentsAsync()
        {
            // Snippet: ResolvePullRequestCommentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: ResolvePullRequestCommentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]",
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.ResolvePullRequestCommentsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceResolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestComments</summary>
        public void ResolvePullRequestCommentsResourceNames()
        {
            // Snippet: ResolvePullRequestComments(PullRequestName, IEnumerable<PullRequestCommentName>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<PullRequestCommentName> names = new PullRequestCommentName[]
            {
                PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.ResolvePullRequestComments(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceResolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResolvePullRequestCommentsAsync</summary>
        public async Task ResolvePullRequestCommentsResourceNamesAsync()
        {
            // Snippet: ResolvePullRequestCommentsAsync(PullRequestName, IEnumerable<PullRequestCommentName>, CallSettings)
            // Additional: ResolvePullRequestCommentsAsync(PullRequestName, IEnumerable<PullRequestCommentName>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<PullRequestCommentName> names = new PullRequestCommentName[]
            {
                PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.ResolvePullRequestCommentsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceResolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestComments</summary>
        public void UnresolvePullRequestCommentsRequestObject()
        {
            // Snippet: UnresolvePullRequestComments(UnresolvePullRequestCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UnresolvePullRequestCommentsRequest request = new UnresolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestCommentNames =
                {
                    PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
                },
                AutoFill = false,
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.UnresolvePullRequestComments(request);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUnresolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestCommentsAsync</summary>
        public async Task UnresolvePullRequestCommentsRequestObjectAsync()
        {
            // Snippet: UnresolvePullRequestCommentsAsync(UnresolvePullRequestCommentsRequest, CallSettings)
            // Additional: UnresolvePullRequestCommentsAsync(UnresolvePullRequestCommentsRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UnresolvePullRequestCommentsRequest request = new UnresolvePullRequestCommentsRequest
            {
                ParentAsPullRequestName = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]"),
                PullRequestCommentNames =
                {
                    PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
                },
                AutoFill = false,
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.UnresolvePullRequestCommentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUnresolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestComments</summary>
        public void UnresolvePullRequestComments()
        {
            // Snippet: UnresolvePullRequestComments(string, IEnumerable<string>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]",
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.UnresolvePullRequestComments(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUnresolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestCommentsAsync</summary>
        public async Task UnresolvePullRequestCommentsAsync()
        {
            // Snippet: UnresolvePullRequestCommentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: UnresolvePullRequestCommentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/pullRequests/[PULL_REQUEST]/pullRequestComments/[COMMENT]",
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.UnresolvePullRequestCommentsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUnresolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestComments</summary>
        public void UnresolvePullRequestCommentsResourceNames()
        {
            // Snippet: UnresolvePullRequestComments(PullRequestName, IEnumerable<PullRequestCommentName>, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<PullRequestCommentName> names = new PullRequestCommentName[]
            {
                PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = secureSourceManagerClient.UnresolvePullRequestComments(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUnresolvePullRequestComments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UnresolvePullRequestCommentsAsync</summary>
        public async Task UnresolvePullRequestCommentsResourceNamesAsync()
        {
            // Snippet: UnresolvePullRequestCommentsAsync(PullRequestName, IEnumerable<PullRequestCommentName>, CallSettings)
            // Additional: UnresolvePullRequestCommentsAsync(PullRequestName, IEnumerable<PullRequestCommentName>, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            PullRequestName parent = PullRequestName.FromProjectLocationRepositoryPullRequest("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]");
            IEnumerable<PullRequestCommentName> names = new PullRequestCommentName[]
            {
                PullRequestCommentName.FromProjectLocationRepositoryPullRequestComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[PULL_REQUEST]", "[COMMENT]"),
            };
            // Make the request
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> response = await secureSourceManagerClient.UnresolvePullRequestCommentsAsync(parent, names);

            // Poll until the returned long-running operation is complete
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UnresolvePullRequestCommentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UnresolvePullRequestCommentsResponse, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUnresolvePullRequestCommentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UnresolvePullRequestCommentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueComment</summary>
        public void CreateIssueCommentRequestObject()
        {
            // Snippet: CreateIssueComment(CreateIssueCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            CreateIssueCommentRequest request = new CreateIssueCommentRequest
            {
                ParentAsIssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                IssueComment = new IssueComment(),
            };
            // Make the request
            Operation<IssueComment, OperationMetadata> response = secureSourceManagerClient.CreateIssueComment(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueCommentAsync</summary>
        public async Task CreateIssueCommentRequestObjectAsync()
        {
            // Snippet: CreateIssueCommentAsync(CreateIssueCommentRequest, CallSettings)
            // Additional: CreateIssueCommentAsync(CreateIssueCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateIssueCommentRequest request = new CreateIssueCommentRequest
            {
                ParentAsIssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
                IssueComment = new IssueComment(),
            };
            // Make the request
            Operation<IssueComment, OperationMetadata> response = await secureSourceManagerClient.CreateIssueCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueComment</summary>
        public void CreateIssueComment()
        {
            // Snippet: CreateIssueComment(string, IssueComment, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            IssueComment issueComment = new IssueComment();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = secureSourceManagerClient.CreateIssueComment(parent, issueComment);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueCommentAsync</summary>
        public async Task CreateIssueCommentAsync()
        {
            // Snippet: CreateIssueCommentAsync(string, IssueComment, CallSettings)
            // Additional: CreateIssueCommentAsync(string, IssueComment, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            IssueComment issueComment = new IssueComment();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = await secureSourceManagerClient.CreateIssueCommentAsync(parent, issueComment);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueComment</summary>
        public void CreateIssueCommentResourceNames()
        {
            // Snippet: CreateIssueComment(IssueName, IssueComment, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName parent = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            IssueComment issueComment = new IssueComment();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = secureSourceManagerClient.CreateIssueComment(parent, issueComment);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceCreateIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueCommentAsync</summary>
        public async Task CreateIssueCommentResourceNamesAsync()
        {
            // Snippet: CreateIssueCommentAsync(IssueName, IssueComment, CallSettings)
            // Additional: CreateIssueCommentAsync(IssueName, IssueComment, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName parent = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            IssueComment issueComment = new IssueComment();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = await secureSourceManagerClient.CreateIssueCommentAsync(parent, issueComment);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceCreateIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIssueComment</summary>
        public void GetIssueCommentRequestObject()
        {
            // Snippet: GetIssueComment(GetIssueCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            GetIssueCommentRequest request = new GetIssueCommentRequest
            {
                IssueCommentName = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]"),
            };
            // Make the request
            IssueComment response = secureSourceManagerClient.GetIssueComment(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueCommentAsync</summary>
        public async Task GetIssueCommentRequestObjectAsync()
        {
            // Snippet: GetIssueCommentAsync(GetIssueCommentRequest, CallSettings)
            // Additional: GetIssueCommentAsync(GetIssueCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetIssueCommentRequest request = new GetIssueCommentRequest
            {
                IssueCommentName = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]"),
            };
            // Make the request
            IssueComment response = await secureSourceManagerClient.GetIssueCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueComment</summary>
        public void GetIssueComment()
        {
            // Snippet: GetIssueComment(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]/issueComments/[COMMENT]";
            // Make the request
            IssueComment response = secureSourceManagerClient.GetIssueComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueCommentAsync</summary>
        public async Task GetIssueCommentAsync()
        {
            // Snippet: GetIssueCommentAsync(string, CallSettings)
            // Additional: GetIssueCommentAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]/issueComments/[COMMENT]";
            // Make the request
            IssueComment response = await secureSourceManagerClient.GetIssueCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueComment</summary>
        public void GetIssueCommentResourceNames()
        {
            // Snippet: GetIssueComment(IssueCommentName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueCommentName name = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]");
            // Make the request
            IssueComment response = secureSourceManagerClient.GetIssueComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueCommentAsync</summary>
        public async Task GetIssueCommentResourceNamesAsync()
        {
            // Snippet: GetIssueCommentAsync(IssueCommentName, CallSettings)
            // Additional: GetIssueCommentAsync(IssueCommentName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueCommentName name = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]");
            // Make the request
            IssueComment response = await secureSourceManagerClient.GetIssueCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIssueComments</summary>
        public void ListIssueCommentsRequestObject()
        {
            // Snippet: ListIssueComments(ListIssueCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
            {
                ParentAsIssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
            };
            // Make the request
            PagedEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueComments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IssueComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssueCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssueCommentsAsync</summary>
        public async Task ListIssueCommentsRequestObjectAsync()
        {
            // Snippet: ListIssueCommentsAsync(ListIssueCommentsRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListIssueCommentsRequest request = new ListIssueCommentsRequest
            {
                ParentAsIssueName = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueCommentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IssueComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssueCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssueComments</summary>
        public void ListIssueComments()
        {
            // Snippet: ListIssueComments(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            PagedEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IssueComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssueCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssueCommentsAsync</summary>
        public async Task ListIssueCommentsAsync()
        {
            // Snippet: ListIssueCommentsAsync(string, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]";
            // Make the request
            PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IssueComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssueCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssueComments</summary>
        public void ListIssueCommentsResourceNames()
        {
            // Snippet: ListIssueComments(IssueName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueName parent = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            PagedEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IssueComment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIssueCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIssueCommentsAsync</summary>
        public async Task ListIssueCommentsResourceNamesAsync()
        {
            // Snippet: ListIssueCommentsAsync(IssueName, string, int?, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueName parent = IssueName.FromProjectLocationRepositoryIssue("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]");
            // Make the request
            PagedAsyncEnumerable<ListIssueCommentsResponse, IssueComment> response = secureSourceManagerClient.ListIssueCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IssueComment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIssueCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IssueComment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IssueComment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IssueComment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueComment</summary>
        public void UpdateIssueCommentRequestObject()
        {
            // Snippet: UpdateIssueComment(UpdateIssueCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            UpdateIssueCommentRequest request = new UpdateIssueCommentRequest
            {
                IssueComment = new IssueComment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<IssueComment, OperationMetadata> response = secureSourceManagerClient.UpdateIssueComment(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueCommentAsync</summary>
        public async Task UpdateIssueCommentRequestObjectAsync()
        {
            // Snippet: UpdateIssueCommentAsync(UpdateIssueCommentRequest, CallSettings)
            // Additional: UpdateIssueCommentAsync(UpdateIssueCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIssueCommentRequest request = new UpdateIssueCommentRequest
            {
                IssueComment = new IssueComment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<IssueComment, OperationMetadata> response = await secureSourceManagerClient.UpdateIssueCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueComment</summary>
        public void UpdateIssueComment()
        {
            // Snippet: UpdateIssueComment(IssueComment, FieldMask, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueComment issueComment = new IssueComment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = secureSourceManagerClient.UpdateIssueComment(issueComment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceUpdateIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueCommentAsync</summary>
        public async Task UpdateIssueCommentAsync()
        {
            // Snippet: UpdateIssueCommentAsync(IssueComment, FieldMask, CallSettings)
            // Additional: UpdateIssueCommentAsync(IssueComment, FieldMask, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueComment issueComment = new IssueComment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<IssueComment, OperationMetadata> response = await secureSourceManagerClient.UpdateIssueCommentAsync(issueComment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<IssueComment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueComment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueComment, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceUpdateIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueComment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueComment</summary>
        public void DeleteIssueCommentRequestObject()
        {
            // Snippet: DeleteIssueComment(DeleteIssueCommentRequest, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            DeleteIssueCommentRequest request = new DeleteIssueCommentRequest
            {
                IssueCommentName = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssueComment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueCommentAsync</summary>
        public async Task DeleteIssueCommentRequestObjectAsync()
        {
            // Snippet: DeleteIssueCommentAsync(DeleteIssueCommentRequest, CallSettings)
            // Additional: DeleteIssueCommentAsync(DeleteIssueCommentRequest, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIssueCommentRequest request = new DeleteIssueCommentRequest
            {
                IssueCommentName = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueComment</summary>
        public void DeleteIssueComment()
        {
            // Snippet: DeleteIssueComment(string, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]/issueComments/[COMMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssueComment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueCommentAsync</summary>
        public async Task DeleteIssueCommentAsync()
        {
            // Snippet: DeleteIssueCommentAsync(string, CallSettings)
            // Additional: DeleteIssueCommentAsync(string, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]/issues/[ISSUE]/issueComments/[COMMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueCommentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueComment</summary>
        public void DeleteIssueCommentResourceNames()
        {
            // Snippet: DeleteIssueComment(IssueCommentName, CallSettings)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = SecureSourceManagerClient.Create();
            // Initialize request argument(s)
            IssueCommentName name = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = secureSourceManagerClient.DeleteIssueComment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = secureSourceManagerClient.PollOnceDeleteIssueComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueCommentAsync</summary>
        public async Task DeleteIssueCommentResourceNamesAsync()
        {
            // Snippet: DeleteIssueCommentAsync(IssueCommentName, CallSettings)
            // Additional: DeleteIssueCommentAsync(IssueCommentName, CancellationToken)
            // Create client
            SecureSourceManagerClient secureSourceManagerClient = await SecureSourceManagerClient.CreateAsync();
            // Initialize request argument(s)
            IssueCommentName name = IssueCommentName.FromProjectLocationRepositoryIssueComment("[PROJECT]", "[LOCATION]", "[REPOSITORY]", "[ISSUE]", "[COMMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await secureSourceManagerClient.DeleteIssueCommentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await secureSourceManagerClient.PollOnceDeleteIssueCommentAsync(operationName);
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
