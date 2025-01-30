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
    using Google.Cloud.BareMetalSolution.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBareMetalSolutionClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(request);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(request);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstances(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = bareMetalSolutionClient.ListInstancesAsync(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = bareMetalSolutionClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Instance response = await bareMetalSolutionClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstanceRequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = bareMetalSolutionClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateInstance(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await bareMetalSolutionClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateInstanceAsync(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = bareMetalSolutionClient.UpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateInstance(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = await bareMetalSolutionClient.UpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameInstance</summary>
        public void RenameInstanceRequestObject()
        {
            // Snippet: RenameInstance(RenameInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RenameInstanceRequest request = new RenameInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                NewInstanceId = "",
            };
            // Make the request
            Instance response = bareMetalSolutionClient.RenameInstance(request);
            // End snippet
        }

        /// <summary>Snippet for RenameInstanceAsync</summary>
        public async Task RenameInstanceRequestObjectAsync()
        {
            // Snippet: RenameInstanceAsync(RenameInstanceRequest, CallSettings)
            // Additional: RenameInstanceAsync(RenameInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RenameInstanceRequest request = new RenameInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                NewInstanceId = "",
            };
            // Make the request
            Instance response = await bareMetalSolutionClient.RenameInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameInstance</summary>
        public void RenameInstance()
        {
            // Snippet: RenameInstance(string, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string newInstanceId = "";
            // Make the request
            Instance response = bareMetalSolutionClient.RenameInstance(name, newInstanceId);
            // End snippet
        }

        /// <summary>Snippet for RenameInstanceAsync</summary>
        public async Task RenameInstanceAsync()
        {
            // Snippet: RenameInstanceAsync(string, string, CallSettings)
            // Additional: RenameInstanceAsync(string, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string newInstanceId = "";
            // Make the request
            Instance response = await bareMetalSolutionClient.RenameInstanceAsync(name, newInstanceId);
            // End snippet
        }

        /// <summary>Snippet for RenameInstance</summary>
        public void RenameInstanceResourceNames()
        {
            // Snippet: RenameInstance(InstanceName, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            string newInstanceId = "";
            // Make the request
            Instance response = bareMetalSolutionClient.RenameInstance(name, newInstanceId);
            // End snippet
        }

        /// <summary>Snippet for RenameInstanceAsync</summary>
        public async Task RenameInstanceResourceNamesAsync()
        {
            // Snippet: RenameInstanceAsync(InstanceName, string, CallSettings)
            // Additional: RenameInstanceAsync(InstanceName, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            string newInstanceId = "";
            // Make the request
            Instance response = await bareMetalSolutionClient.RenameInstanceAsync(name, newInstanceId);
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstanceRequestObject()
        {
            // Snippet: ResetInstance(ResetInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceRequestObjectAsync()
        {
            // Snippet: ResetInstanceAsync(ResetInstanceRequest, CallSettings)
            // Additional: ResetInstanceAsync(ResetInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstance()
        {
            // Snippet: ResetInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceAsync()
        {
            // Snippet: ResetInstanceAsync(string, CallSettings)
            // Additional: ResetInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstanceResourceNames()
        {
            // Snippet: ResetInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.ResetInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceResourceNamesAsync()
        {
            // Snippet: ResetInstanceAsync(InstanceName, CallSettings)
            // Additional: ResetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<ResetInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.ResetInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ResetInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ResetInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ResetInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ResetInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstanceRequestObject()
        {
            // Snippet: StartInstance(StartInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            StartInstanceRequest request = new StartInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceRequestObjectAsync()
        {
            // Snippet: StartInstanceAsync(StartInstanceRequest, CallSettings)
            // Additional: StartInstanceAsync(StartInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            StartInstanceRequest request = new StartInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StartInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstance()
        {
            // Snippet: StartInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceAsync()
        {
            // Snippet: StartInstanceAsync(string, CallSettings)
            // Additional: StartInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstanceResourceNames()
        {
            // Snippet: StartInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceResourceNamesAsync()
        {
            // Snippet: StartInstanceAsync(InstanceName, CallSettings)
            // Additional: StartInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<StartInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StartInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StartInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StartInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StartInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceRequestObject()
        {
            // Snippet: StopInstance(StopInstanceRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            StopInstanceRequest request = new StopInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StopInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceRequestObjectAsync()
        {
            // Snippet: StopInstanceAsync(StopInstanceRequest, CallSettings)
            // Additional: StopInstanceAsync(StopInstanceRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            StopInstanceRequest request = new StopInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StopInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstance()
        {
            // Snippet: StopInstance(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StopInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceAsync()
        {
            // Snippet: StopInstanceAsync(string, CallSettings)
            // Additional: StopInstanceAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StopInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceResourceNames()
        {
            // Snippet: StopInstance(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = bareMetalSolutionClient.StopInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceResourceNamesAsync()
        {
            // Snippet: StopInstanceAsync(InstanceName, CallSettings)
            // Additional: StopInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<StopInstanceResponse, OperationMetadata> response = await bareMetalSolutionClient.StopInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<StopInstanceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            StopInstanceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<StopInstanceResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                StopInstanceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsole</summary>
        public void EnableInteractiveSerialConsoleRequestObject()
        {
            // Snippet: EnableInteractiveSerialConsole(EnableInteractiveSerialConsoleRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            EnableInteractiveSerialConsoleRequest request = new EnableInteractiveSerialConsoleRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.EnableInteractiveSerialConsole(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsoleAsync</summary>
        public async Task EnableInteractiveSerialConsoleRequestObjectAsync()
        {
            // Snippet: EnableInteractiveSerialConsoleAsync(EnableInteractiveSerialConsoleRequest, CallSettings)
            // Additional: EnableInteractiveSerialConsoleAsync(EnableInteractiveSerialConsoleRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            EnableInteractiveSerialConsoleRequest request = new EnableInteractiveSerialConsoleRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.EnableInteractiveSerialConsoleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsole</summary>
        public void EnableInteractiveSerialConsole()
        {
            // Snippet: EnableInteractiveSerialConsole(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.EnableInteractiveSerialConsole(name);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsoleAsync</summary>
        public async Task EnableInteractiveSerialConsoleAsync()
        {
            // Snippet: EnableInteractiveSerialConsoleAsync(string, CallSettings)
            // Additional: EnableInteractiveSerialConsoleAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.EnableInteractiveSerialConsoleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsole</summary>
        public void EnableInteractiveSerialConsoleResourceNames()
        {
            // Snippet: EnableInteractiveSerialConsole(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.EnableInteractiveSerialConsole(name);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableInteractiveSerialConsoleAsync</summary>
        public async Task EnableInteractiveSerialConsoleResourceNamesAsync()
        {
            // Snippet: EnableInteractiveSerialConsoleAsync(InstanceName, CallSettings)
            // Additional: EnableInteractiveSerialConsoleAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.EnableInteractiveSerialConsoleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEnableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsole</summary>
        public void DisableInteractiveSerialConsoleRequestObject()
        {
            // Snippet: DisableInteractiveSerialConsole(DisableInteractiveSerialConsoleRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DisableInteractiveSerialConsoleRequest request = new DisableInteractiveSerialConsoleRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.DisableInteractiveSerialConsole(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsoleAsync</summary>
        public async Task DisableInteractiveSerialConsoleRequestObjectAsync()
        {
            // Snippet: DisableInteractiveSerialConsoleAsync(DisableInteractiveSerialConsoleRequest, CallSettings)
            // Additional: DisableInteractiveSerialConsoleAsync(DisableInteractiveSerialConsoleRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DisableInteractiveSerialConsoleRequest request = new DisableInteractiveSerialConsoleRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.DisableInteractiveSerialConsoleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsole</summary>
        public void DisableInteractiveSerialConsole()
        {
            // Snippet: DisableInteractiveSerialConsole(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.DisableInteractiveSerialConsole(name);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsoleAsync</summary>
        public async Task DisableInteractiveSerialConsoleAsync()
        {
            // Snippet: DisableInteractiveSerialConsoleAsync(string, CallSettings)
            // Additional: DisableInteractiveSerialConsoleAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.DisableInteractiveSerialConsoleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsole</summary>
        public void DisableInteractiveSerialConsoleResourceNames()
        {
            // Snippet: DisableInteractiveSerialConsole(InstanceName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = bareMetalSolutionClient.DisableInteractiveSerialConsole(name);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsole(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableInteractiveSerialConsoleAsync</summary>
        public async Task DisableInteractiveSerialConsoleResourceNamesAsync()
        {
            // Snippet: DisableInteractiveSerialConsoleAsync(InstanceName, CallSettings)
            // Additional: DisableInteractiveSerialConsoleAsync(InstanceName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> response = await bareMetalSolutionClient.DisableInteractiveSerialConsoleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableInteractiveSerialConsoleResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableInteractiveSerialConsoleResponse, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDisableInteractiveSerialConsoleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableInteractiveSerialConsoleResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLun</summary>
        public void DetachLunRequestObject()
        {
            // Snippet: DetachLun(DetachLunRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DetachLunRequest request = new DetachLunRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                LunAsLunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                SkipReboot = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = bareMetalSolutionClient.DetachLun(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDetachLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLunAsync</summary>
        public async Task DetachLunRequestObjectAsync()
        {
            // Snippet: DetachLunAsync(DetachLunRequest, CallSettings)
            // Additional: DetachLunAsync(DetachLunRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DetachLunRequest request = new DetachLunRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                LunAsLunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
                SkipReboot = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await bareMetalSolutionClient.DetachLunAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDetachLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLun</summary>
        public void DetachLun()
        {
            // Snippet: DetachLun(string, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string lun = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Operation<Instance, OperationMetadata> response = bareMetalSolutionClient.DetachLun(instance, lun);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDetachLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLunAsync</summary>
        public async Task DetachLunAsync()
        {
            // Snippet: DetachLunAsync(string, string, CallSettings)
            // Additional: DetachLunAsync(string, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            string lun = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await bareMetalSolutionClient.DetachLunAsync(instance, lun);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDetachLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLun</summary>
        public void DetachLunResourceNames()
        {
            // Snippet: DetachLun(InstanceName, LunName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            LunName lun = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Operation<Instance, OperationMetadata> response = bareMetalSolutionClient.DetachLun(instance, lun);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDetachLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachLunAsync</summary>
        public async Task DetachLunResourceNamesAsync()
        {
            // Snippet: DetachLunAsync(InstanceName, LunName, CallSettings)
            // Additional: DetachLunAsync(InstanceName, LunName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            LunName lun = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await bareMetalSolutionClient.DetachLunAsync(instance, lun);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDetachLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeys</summary>
        public void ListSSHKeysRequestObject()
        {
            // Snippet: ListSSHKeys(ListSSHKeysRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListSSHKeysRequest request = new ListSSHKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SSHKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSSHKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeysAsync</summary>
        public async Task ListSSHKeysRequestObjectAsync()
        {
            // Snippet: ListSSHKeysAsync(ListSSHKeysRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListSSHKeysRequest request = new ListSSHKeysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SSHKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSSHKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeys</summary>
        public void ListSSHKeys()
        {
            // Snippet: ListSSHKeys(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SSHKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSSHKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeysAsync</summary>
        public async Task ListSSHKeysAsync()
        {
            // Snippet: ListSSHKeysAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SSHKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSSHKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeys</summary>
        public void ListSSHKeysResourceNames()
        {
            // Snippet: ListSSHKeys(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SSHKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSSHKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSSHKeysAsync</summary>
        public async Task ListSSHKeysResourceNamesAsync()
        {
            // Snippet: ListSSHKeysAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSSHKeysResponse, SSHKey> response = bareMetalSolutionClient.ListSSHKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SSHKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSSHKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SSHKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SSHKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SSHKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKey</summary>
        public void CreateSSHKeyRequestObject()
        {
            // Snippet: CreateSSHKey(CreateSSHKeyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateSSHKeyRequest request = new CreateSSHKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SshKey = new SSHKey(),
                SshKeyId = "",
            };
            // Make the request
            SSHKey response = bareMetalSolutionClient.CreateSSHKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKeyAsync</summary>
        public async Task CreateSSHKeyRequestObjectAsync()
        {
            // Snippet: CreateSSHKeyAsync(CreateSSHKeyRequest, CallSettings)
            // Additional: CreateSSHKeyAsync(CreateSSHKeyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateSSHKeyRequest request = new CreateSSHKeyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SshKey = new SSHKey(),
                SshKeyId = "",
            };
            // Make the request
            SSHKey response = await bareMetalSolutionClient.CreateSSHKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKey</summary>
        public void CreateSSHKey()
        {
            // Snippet: CreateSSHKey(string, SSHKey, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SSHKey sshKey = new SSHKey();
            string sshKeyId = "";
            // Make the request
            SSHKey response = bareMetalSolutionClient.CreateSSHKey(parent, sshKey, sshKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKeyAsync</summary>
        public async Task CreateSSHKeyAsync()
        {
            // Snippet: CreateSSHKeyAsync(string, SSHKey, string, CallSettings)
            // Additional: CreateSSHKeyAsync(string, SSHKey, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SSHKey sshKey = new SSHKey();
            string sshKeyId = "";
            // Make the request
            SSHKey response = await bareMetalSolutionClient.CreateSSHKeyAsync(parent, sshKey, sshKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKey</summary>
        public void CreateSSHKeyResourceNames()
        {
            // Snippet: CreateSSHKey(LocationName, SSHKey, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SSHKey sshKey = new SSHKey();
            string sshKeyId = "";
            // Make the request
            SSHKey response = bareMetalSolutionClient.CreateSSHKey(parent, sshKey, sshKeyId);
            // End snippet
        }

        /// <summary>Snippet for CreateSSHKeyAsync</summary>
        public async Task CreateSSHKeyResourceNamesAsync()
        {
            // Snippet: CreateSSHKeyAsync(LocationName, SSHKey, string, CallSettings)
            // Additional: CreateSSHKeyAsync(LocationName, SSHKey, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SSHKey sshKey = new SSHKey();
            string sshKeyId = "";
            // Make the request
            SSHKey response = await bareMetalSolutionClient.CreateSSHKeyAsync(parent, sshKey, sshKeyId);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKey</summary>
        public void DeleteSSHKeyRequestObject()
        {
            // Snippet: DeleteSSHKey(DeleteSSHKeyRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DeleteSSHKeyRequest request = new DeleteSSHKeyRequest
            {
                SshKeyName = SshKeyName.FromProjectLocationSshKey("[PROJECT]", "[LOCATION]", "[SSH_KEY]"),
            };
            // Make the request
            bareMetalSolutionClient.DeleteSSHKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKeyAsync</summary>
        public async Task DeleteSSHKeyRequestObjectAsync()
        {
            // Snippet: DeleteSSHKeyAsync(DeleteSSHKeyRequest, CallSettings)
            // Additional: DeleteSSHKeyAsync(DeleteSSHKeyRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSSHKeyRequest request = new DeleteSSHKeyRequest
            {
                SshKeyName = SshKeyName.FromProjectLocationSshKey("[PROJECT]", "[LOCATION]", "[SSH_KEY]"),
            };
            // Make the request
            await bareMetalSolutionClient.DeleteSSHKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKey</summary>
        public void DeleteSSHKey()
        {
            // Snippet: DeleteSSHKey(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sshKeys/[SSH_KEY]";
            // Make the request
            bareMetalSolutionClient.DeleteSSHKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKeyAsync</summary>
        public async Task DeleteSSHKeyAsync()
        {
            // Snippet: DeleteSSHKeyAsync(string, CallSettings)
            // Additional: DeleteSSHKeyAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sshKeys/[SSH_KEY]";
            // Make the request
            await bareMetalSolutionClient.DeleteSSHKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKey</summary>
        public void DeleteSSHKeyResourceNames()
        {
            // Snippet: DeleteSSHKey(SshKeyName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            SshKeyName name = SshKeyName.FromProjectLocationSshKey("[PROJECT]", "[LOCATION]", "[SSH_KEY]");
            // Make the request
            bareMetalSolutionClient.DeleteSSHKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSSHKeyAsync</summary>
        public async Task DeleteSSHKeyResourceNamesAsync()
        {
            // Snippet: DeleteSSHKeyAsync(SshKeyName, CallSettings)
            // Additional: DeleteSSHKeyAsync(SshKeyName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            SshKeyName name = SshKeyName.FromProjectLocationSshKey("[PROJECT]", "[LOCATION]", "[SSH_KEY]");
            // Make the request
            await bareMetalSolutionClient.DeleteSSHKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVolumes</summary>
        public void ListVolumesRequestObject()
        {
            // Snippet: ListVolumes(ListVolumesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(request);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumesRequest request = new ListVolumesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(request);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumes(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListVolumesResponse, Volume> response = bareMetalSolutionClient.ListVolumesAsync(parent);

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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeRequestObjectAsync()
        {
            // Snippet: GetVolumeAsync(GetVolumeRequest, CallSettings)
            // Additional: GetVolumeAsync(GetVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeRequest request = new GetVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolume()
        {
            // Snippet: GetVolume(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeAsync()
        {
            // Snippet: GetVolumeAsync(string, CallSettings)
            // Additional: GetVolumeAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolume</summary>
        public void GetVolumeResourceNames()
        {
            // Snippet: GetVolume(VolumeName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = bareMetalSolutionClient.GetVolume(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeAsync</summary>
        public async Task GetVolumeResourceNamesAsync()
        {
            // Snippet: GetVolumeAsync(VolumeName, CallSettings)
            // Additional: GetVolumeAsync(VolumeName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Volume response = await bareMetalSolutionClient.GetVolumeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateVolume</summary>
        public void UpdateVolumeRequestObject()
        {
            // Snippet: UpdateVolume(UpdateVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                Volume = new Volume(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.UpdateVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateVolume(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVolumeRequest request = new UpdateVolumeRequest
            {
                Volume = new Volume(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.UpdateVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateVolumeAsync(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.UpdateVolume(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateVolume(operationName);
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
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            Volume volume = new Volume();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.UpdateVolumeAsync(volume, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameVolume</summary>
        public void RenameVolumeRequestObject()
        {
            // Snippet: RenameVolume(RenameVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RenameVolumeRequest request = new RenameVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                NewVolumeId = "",
            };
            // Make the request
            Volume response = bareMetalSolutionClient.RenameVolume(request);
            // End snippet
        }

        /// <summary>Snippet for RenameVolumeAsync</summary>
        public async Task RenameVolumeRequestObjectAsync()
        {
            // Snippet: RenameVolumeAsync(RenameVolumeRequest, CallSettings)
            // Additional: RenameVolumeAsync(RenameVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RenameVolumeRequest request = new RenameVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                NewVolumeId = "",
            };
            // Make the request
            Volume response = await bareMetalSolutionClient.RenameVolumeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameVolume</summary>
        public void RenameVolume()
        {
            // Snippet: RenameVolume(string, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            string newVolumeId = "";
            // Make the request
            Volume response = bareMetalSolutionClient.RenameVolume(name, newVolumeId);
            // End snippet
        }

        /// <summary>Snippet for RenameVolumeAsync</summary>
        public async Task RenameVolumeAsync()
        {
            // Snippet: RenameVolumeAsync(string, string, CallSettings)
            // Additional: RenameVolumeAsync(string, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            string newVolumeId = "";
            // Make the request
            Volume response = await bareMetalSolutionClient.RenameVolumeAsync(name, newVolumeId);
            // End snippet
        }

        /// <summary>Snippet for RenameVolume</summary>
        public void RenameVolumeResourceNames()
        {
            // Snippet: RenameVolume(VolumeName, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            string newVolumeId = "";
            // Make the request
            Volume response = bareMetalSolutionClient.RenameVolume(name, newVolumeId);
            // End snippet
        }

        /// <summary>Snippet for RenameVolumeAsync</summary>
        public async Task RenameVolumeResourceNamesAsync()
        {
            // Snippet: RenameVolumeAsync(VolumeName, string, CallSettings)
            // Additional: RenameVolumeAsync(VolumeName, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            string newVolumeId = "";
            // Make the request
            Volume response = await bareMetalSolutionClient.RenameVolumeAsync(name, newVolumeId);
            // End snippet
        }

        /// <summary>Snippet for EvictVolume</summary>
        public void EvictVolumeRequestObject()
        {
            // Snippet: EvictVolume(EvictVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            EvictVolumeRequest request = new EvictVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictVolumeAsync</summary>
        public async Task EvictVolumeRequestObjectAsync()
        {
            // Snippet: EvictVolumeAsync(EvictVolumeRequest, CallSettings)
            // Additional: EvictVolumeAsync(EvictVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            EvictVolumeRequest request = new EvictVolumeRequest
            {
                VolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictVolume</summary>
        public void EvictVolume()
        {
            // Snippet: EvictVolume(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictVolume(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictVolumeAsync</summary>
        public async Task EvictVolumeAsync()
        {
            // Snippet: EvictVolumeAsync(string, CallSettings)
            // Additional: EvictVolumeAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictVolumeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictVolume</summary>
        public void EvictVolumeResourceNames()
        {
            // Snippet: EvictVolume(VolumeName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictVolume(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictVolumeAsync</summary>
        public async Task EvictVolumeResourceNamesAsync()
        {
            // Snippet: EvictVolumeAsync(VolumeName, CallSettings)
            // Additional: EvictVolumeAsync(VolumeName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName name = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictVolumeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolume</summary>
        public void ResizeVolumeRequestObject()
        {
            // Snippet: ResizeVolume(ResizeVolumeRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ResizeVolumeRequest request = new ResizeVolumeRequest
            {
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                SizeGib = 0L,
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.ResizeVolume(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResizeVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolumeAsync</summary>
        public async Task ResizeVolumeRequestObjectAsync()
        {
            // Snippet: ResizeVolumeAsync(ResizeVolumeRequest, CallSettings)
            // Additional: ResizeVolumeAsync(ResizeVolumeRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ResizeVolumeRequest request = new ResizeVolumeRequest
            {
                VolumeAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                SizeGib = 0L,
            };
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.ResizeVolumeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResizeVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolume</summary>
        public void ResizeVolume()
        {
            // Snippet: ResizeVolume(string, long, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string volume = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            long sizeGib = 0L;
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.ResizeVolume(volume, sizeGib);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResizeVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolumeAsync</summary>
        public async Task ResizeVolumeAsync()
        {
            // Snippet: ResizeVolumeAsync(string, long, CallSettings)
            // Additional: ResizeVolumeAsync(string, long, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string volume = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            long sizeGib = 0L;
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.ResizeVolumeAsync(volume, sizeGib);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResizeVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolume</summary>
        public void ResizeVolumeResourceNames()
        {
            // Snippet: ResizeVolume(VolumeName, long, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName volume = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            long sizeGib = 0L;
            // Make the request
            Operation<Volume, OperationMetadata> response = bareMetalSolutionClient.ResizeVolume(volume, sizeGib);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceResizeVolume(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeVolumeAsync</summary>
        public async Task ResizeVolumeResourceNamesAsync()
        {
            // Snippet: ResizeVolumeAsync(VolumeName, long, CallSettings)
            // Additional: ResizeVolumeAsync(VolumeName, long, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName volume = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            long sizeGib = 0L;
            // Make the request
            Operation<Volume, OperationMetadata> response = await bareMetalSolutionClient.ResizeVolumeAsync(volume, sizeGib);

            // Poll until the returned long-running operation is complete
            Operation<Volume, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Volume result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Volume, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceResizeVolumeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Volume retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksRequestObject()
        {
            // Snippet: ListNetworks(ListNetworksRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksRequestObjectAsync()
        {
            // Snippet: ListNetworksAsync(ListNetworksRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworks()
        {
            // Snippet: ListNetworks(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksAsync()
        {
            // Snippet: ListNetworksAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksResourceNames()
        {
            // Snippet: ListNetworks(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksResourceNamesAsync()
        {
            // Snippet: ListNetworksAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = bareMetalSolutionClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsage</summary>
        public void ListNetworkUsageRequestObject()
        {
            // Snippet: ListNetworkUsage(ListNetworkUsageRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListNetworkUsageResponse response = bareMetalSolutionClient.ListNetworkUsage(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsageAsync</summary>
        public async Task ListNetworkUsageRequestObjectAsync()
        {
            // Snippet: ListNetworkUsageAsync(ListNetworkUsageRequest, CallSettings)
            // Additional: ListNetworkUsageAsync(ListNetworkUsageRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkUsageRequest request = new ListNetworkUsageRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListNetworkUsageResponse response = await bareMetalSolutionClient.ListNetworkUsageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsage</summary>
        public void ListNetworkUsage()
        {
            // Snippet: ListNetworkUsage(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListNetworkUsageResponse response = bareMetalSolutionClient.ListNetworkUsage(location);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsageAsync</summary>
        public async Task ListNetworkUsageAsync()
        {
            // Snippet: ListNetworkUsageAsync(string, CallSettings)
            // Additional: ListNetworkUsageAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListNetworkUsageResponse response = await bareMetalSolutionClient.ListNetworkUsageAsync(location);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsage</summary>
        public void ListNetworkUsageResourceNames()
        {
            // Snippet: ListNetworkUsage(LocationName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListNetworkUsageResponse response = bareMetalSolutionClient.ListNetworkUsage(location);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkUsageAsync</summary>
        public async Task ListNetworkUsageResourceNamesAsync()
        {
            // Snippet: ListNetworkUsageAsync(LocationName, CallSettings)
            // Additional: ListNetworkUsageAsync(LocationName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListNetworkUsageResponse response = await bareMetalSolutionClient.ListNetworkUsageAsync(location);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkRequestObject()
        {
            // Snippet: GetNetwork(GetNetworkRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkRequestObjectAsync()
        {
            // Snippet: GetNetworkAsync(GetNetworkRequest, CallSettings)
            // Additional: GetNetworkAsync(GetNetworkRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
            };
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetwork()
        {
            // Snippet: GetNetwork(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkAsync()
        {
            // Snippet: GetNetworkAsync(string, CallSettings)
            // Additional: GetNetworkAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkResourceNames()
        {
            // Snippet: GetNetwork(NetworkName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            // Make the request
            Network response = bareMetalSolutionClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkResourceNamesAsync()
        {
            // Snippet: GetNetworkAsync(NetworkName, CallSettings)
            // Additional: GetNetworkAsync(NetworkName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            // Make the request
            Network response = await bareMetalSolutionClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateNetwork</summary>
        public void UpdateNetworkRequestObject()
        {
            // Snippet: UpdateNetwork(UpdateNetworkRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateNetworkRequest request = new UpdateNetworkRequest
            {
                Network = new Network(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Network, OperationMetadata> response = bareMetalSolutionClient.UpdateNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkAsync</summary>
        public async Task UpdateNetworkRequestObjectAsync()
        {
            // Snippet: UpdateNetworkAsync(UpdateNetworkRequest, CallSettings)
            // Additional: UpdateNetworkAsync(UpdateNetworkRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNetworkRequest request = new UpdateNetworkRequest
            {
                Network = new Network(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Network, OperationMetadata> response = await bareMetalSolutionClient.UpdateNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetwork</summary>
        public void UpdateNetwork()
        {
            // Snippet: UpdateNetwork(Network, FieldMask, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            Network network = new Network();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Network, OperationMetadata> response = bareMetalSolutionClient.UpdateNetwork(network, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNetworkAsync</summary>
        public async Task UpdateNetworkAsync()
        {
            // Snippet: UpdateNetworkAsync(Network, FieldMask, CallSettings)
            // Additional: UpdateNetworkAsync(Network, FieldMask, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            Network network = new Network();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Network, OperationMetadata> response = await bareMetalSolutionClient.UpdateNetworkAsync(network, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshotRequestObject()
        {
            // Snippet: CreateVolumeSnapshot(CreateVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(CreateVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateVolumeSnapshotRequest request = new CreateVolumeSnapshotRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
                VolumeSnapshot = new VolumeSnapshot(),
            };
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshot()
        {
            // Snippet: CreateVolumeSnapshot(string, VolumeSnapshot, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(string, VolumeSnapshot, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(string, VolumeSnapshot, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshot</summary>
        public void CreateVolumeSnapshotResourceNames()
        {
            // Snippet: CreateVolumeSnapshot(VolumeName, VolumeSnapshot, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.CreateVolumeSnapshot(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for CreateVolumeSnapshotAsync</summary>
        public async Task CreateVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: CreateVolumeSnapshotAsync(VolumeName, VolumeSnapshot, CallSettings)
            // Additional: CreateVolumeSnapshotAsync(VolumeName, VolumeSnapshot, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            VolumeSnapshot volumeSnapshot = new VolumeSnapshot();
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.CreateVolumeSnapshotAsync(parent, volumeSnapshot);
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshotRequestObject()
        {
            // Snippet: RestoreVolumeSnapshot(RestoreVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RestoreVolumeSnapshotRequest request = new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(RestoreVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RestoreVolumeSnapshotRequest request = new RestoreVolumeSnapshotRequest
            {
                VolumeSnapshotAsVolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshot()
        {
            // Snippet: RestoreVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string volumeSnapshot = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(string, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string volumeSnapshot = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshot</summary>
        public void RestoreVolumeSnapshotResourceNames()
        {
            // Snippet: RestoreVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName volumeSnapshot = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = bareMetalSolutionClient.RestoreVolumeSnapshot(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceRestoreVolumeSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreVolumeSnapshotAsync</summary>
        public async Task RestoreVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: RestoreVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: RestoreVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName volumeSnapshot = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            Operation<VolumeSnapshot, OperationMetadata> response = await bareMetalSolutionClient.RestoreVolumeSnapshotAsync(volumeSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<VolumeSnapshot, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VolumeSnapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VolumeSnapshot, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceRestoreVolumeSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VolumeSnapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshotRequestObject()
        {
            // Snippet: DeleteVolumeSnapshot(DeleteVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(DeleteVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVolumeSnapshotRequest request = new DeleteVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshot()
        {
            // Snippet: DeleteVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(string, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshot</summary>
        public void DeleteVolumeSnapshotResourceNames()
        {
            // Snippet: DeleteVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            bareMetalSolutionClient.DeleteVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteVolumeSnapshotAsync</summary>
        public async Task DeleteVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: DeleteVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: DeleteVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            await bareMetalSolutionClient.DeleteVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshotRequestObject()
        {
            // Snippet: GetVolumeSnapshot(GetVolumeSnapshotRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotRequestObjectAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(GetVolumeSnapshotRequest, CallSettings)
            // Additional: GetVolumeSnapshotAsync(GetVolumeSnapshotRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetVolumeSnapshotRequest request = new GetVolumeSnapshotRequest
            {
                VolumeSnapshotName = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]"),
            };
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshot()
        {
            // Snippet: GetVolumeSnapshot(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(string, CallSettings)
            // Additional: GetVolumeSnapshotAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/snapshots/[SNAPSHOT]";
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshot</summary>
        public void GetVolumeSnapshotResourceNames()
        {
            // Snippet: GetVolumeSnapshot(VolumeSnapshotName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            VolumeSnapshot response = bareMetalSolutionClient.GetVolumeSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetVolumeSnapshotAsync</summary>
        public async Task GetVolumeSnapshotResourceNamesAsync()
        {
            // Snippet: GetVolumeSnapshotAsync(VolumeSnapshotName, CallSettings)
            // Additional: GetVolumeSnapshotAsync(VolumeSnapshotName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeSnapshotName name = VolumeSnapshotName.FromProjectLocationVolumeSnapshot("[PROJECT]", "[LOCATION]", "[VOLUME]", "[SNAPSHOT]");
            // Make the request
            VolumeSnapshot response = await bareMetalSolutionClient.GetVolumeSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshotsRequestObject()
        {
            // Snippet: ListVolumeSnapshots(ListVolumeSnapshotsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsRequestObjectAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(ListVolumeSnapshotsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListVolumeSnapshotsRequest request = new ListVolumeSnapshotsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshots()
        {
            // Snippet: ListVolumeSnapshots(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshots</summary>
        public void ListVolumeSnapshotsResourceNames()
        {
            // Snippet: ListVolumeSnapshots(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VolumeSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVolumeSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVolumeSnapshotsAsync</summary>
        public async Task ListVolumeSnapshotsResourceNamesAsync()
        {
            // Snippet: ListVolumeSnapshotsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListVolumeSnapshotsResponse, VolumeSnapshot> response = bareMetalSolutionClient.ListVolumeSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VolumeSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVolumeSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VolumeSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VolumeSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VolumeSnapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLunRequestObject()
        {
            // Snippet: GetLun(GetLunRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(request);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunRequestObjectAsync()
        {
            // Snippet: GetLunAsync(GetLunRequest, CallSettings)
            // Additional: GetLunAsync(GetLunRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetLunRequest request = new GetLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLun()
        {
            // Snippet: GetLun(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(name);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunAsync()
        {
            // Snippet: GetLunAsync(string, CallSettings)
            // Additional: GetLunAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLun</summary>
        public void GetLunResourceNames()
        {
            // Snippet: GetLun(LunName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Lun response = bareMetalSolutionClient.GetLun(name);
            // End snippet
        }

        /// <summary>Snippet for GetLunAsync</summary>
        public async Task GetLunResourceNamesAsync()
        {
            // Snippet: GetLunAsync(LunName, CallSettings)
            // Additional: GetLunAsync(LunName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Lun response = await bareMetalSolutionClient.GetLunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLunsRequestObject()
        {
            // Snippet: ListLuns(ListLunsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsRequestObjectAsync()
        {
            // Snippet: ListLunsAsync(ListLunsRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListLunsRequest request = new ListLunsRequest
            {
                ParentAsVolumeName = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLuns()
        {
            // Snippet: ListLuns(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsAsync()
        {
            // Snippet: ListLunsAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]";
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLuns</summary>
        public void ListLunsResourceNames()
        {
            // Snippet: ListLuns(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLunsAsync</summary>
        public async Task ListLunsResourceNamesAsync()
        {
            // Snippet: ListLunsAsync(VolumeName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            VolumeName parent = VolumeName.FromProjectLocationVolume("[PROJECT]", "[LOCATION]", "[VOLUME]");
            // Make the request
            PagedAsyncEnumerable<ListLunsResponse, Lun> response = bareMetalSolutionClient.ListLunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for EvictLun</summary>
        public void EvictLunRequestObject()
        {
            // Snippet: EvictLun(EvictLunRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            EvictLunRequest request = new EvictLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictLun(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictLunAsync</summary>
        public async Task EvictLunRequestObjectAsync()
        {
            // Snippet: EvictLunAsync(EvictLunRequest, CallSettings)
            // Additional: EvictLunAsync(EvictLunRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            EvictLunRequest request = new EvictLunRequest
            {
                LunName = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictLunAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictLun</summary>
        public void EvictLun()
        {
            // Snippet: EvictLun(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictLun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictLunAsync</summary>
        public async Task EvictLunAsync()
        {
            // Snippet: EvictLunAsync(string, CallSettings)
            // Additional: EvictLunAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/volumes/[VOLUME]/luns/[LUN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictLunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictLun</summary>
        public void EvictLunResourceNames()
        {
            // Snippet: EvictLun(LunName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.EvictLun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceEvictLun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvictLunAsync</summary>
        public async Task EvictLunResourceNamesAsync()
        {
            // Snippet: EvictLunAsync(LunName, CallSettings)
            // Additional: EvictLunAsync(LunName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LunName name = LunName.FromProjectLocationVolumeLun("[PROJECT]", "[LOCATION]", "[VOLUME]", "[LUN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.EvictLunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceEvictLunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNfsShare</summary>
        public void GetNfsShareRequestObject()
        {
            // Snippet: GetNfsShare(GetNfsShareRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            // Make the request
            NfsShare response = bareMetalSolutionClient.GetNfsShare(request);
            // End snippet
        }

        /// <summary>Snippet for GetNfsShareAsync</summary>
        public async Task GetNfsShareRequestObjectAsync()
        {
            // Snippet: GetNfsShareAsync(GetNfsShareRequest, CallSettings)
            // Additional: GetNfsShareAsync(GetNfsShareRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetNfsShareRequest request = new GetNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            // Make the request
            NfsShare response = await bareMetalSolutionClient.GetNfsShareAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNfsShare</summary>
        public void GetNfsShare()
        {
            // Snippet: GetNfsShare(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            // Make the request
            NfsShare response = bareMetalSolutionClient.GetNfsShare(name);
            // End snippet
        }

        /// <summary>Snippet for GetNfsShareAsync</summary>
        public async Task GetNfsShareAsync()
        {
            // Snippet: GetNfsShareAsync(string, CallSettings)
            // Additional: GetNfsShareAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            // Make the request
            NfsShare response = await bareMetalSolutionClient.GetNfsShareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNfsShare</summary>
        public void GetNfsShareResourceNames()
        {
            // Snippet: GetNfsShare(NFSShareName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            // Make the request
            NfsShare response = bareMetalSolutionClient.GetNfsShare(name);
            // End snippet
        }

        /// <summary>Snippet for GetNfsShareAsync</summary>
        public async Task GetNfsShareResourceNamesAsync()
        {
            // Snippet: GetNfsShareAsync(NFSShareName, CallSettings)
            // Additional: GetNfsShareAsync(NFSShareName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            // Make the request
            NfsShare response = await bareMetalSolutionClient.GetNfsShareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNfsShares</summary>
        public void ListNfsSharesRequestObject()
        {
            // Snippet: ListNfsShares(ListNfsSharesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListNfsSharesRequest request = new ListNfsSharesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsShares(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NfsShare item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNfsSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNfsSharesAsync</summary>
        public async Task ListNfsSharesRequestObjectAsync()
        {
            // Snippet: ListNfsSharesAsync(ListNfsSharesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListNfsSharesRequest request = new ListNfsSharesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsSharesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NfsShare item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNfsSharesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNfsShares</summary>
        public void ListNfsShares()
        {
            // Snippet: ListNfsShares(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsShares(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NfsShare item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNfsSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNfsSharesAsync</summary>
        public async Task ListNfsSharesAsync()
        {
            // Snippet: ListNfsSharesAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsSharesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NfsShare item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNfsSharesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNfsShares</summary>
        public void ListNfsSharesResourceNames()
        {
            // Snippet: ListNfsShares(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsShares(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NfsShare item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNfsSharesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNfsSharesAsync</summary>
        public async Task ListNfsSharesResourceNamesAsync()
        {
            // Snippet: ListNfsSharesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNfsSharesResponse, NfsShare> response = bareMetalSolutionClient.ListNfsSharesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NfsShare item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNfsSharesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NfsShare item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NfsShare> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NfsShare item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateNfsShare</summary>
        public void UpdateNfsShareRequestObject()
        {
            // Snippet: UpdateNfsShare(UpdateNfsShareRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateNfsShareRequest request = new UpdateNfsShareRequest
            {
                NfsShare = new NfsShare(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<NfsShare, OperationMetadata> response = bareMetalSolutionClient.UpdateNfsShare(request);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNfsShareAsync</summary>
        public async Task UpdateNfsShareRequestObjectAsync()
        {
            // Snippet: UpdateNfsShareAsync(UpdateNfsShareRequest, CallSettings)
            // Additional: UpdateNfsShareAsync(UpdateNfsShareRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNfsShareRequest request = new UpdateNfsShareRequest
            {
                NfsShare = new NfsShare(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<NfsShare, OperationMetadata> response = await bareMetalSolutionClient.UpdateNfsShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNfsShare</summary>
        public void UpdateNfsShare()
        {
            // Snippet: UpdateNfsShare(NfsShare, FieldMask, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NfsShare nfsShare = new NfsShare();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = bareMetalSolutionClient.UpdateNfsShare(nfsShare, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceUpdateNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateNfsShareAsync</summary>
        public async Task UpdateNfsShareAsync()
        {
            // Snippet: UpdateNfsShareAsync(NfsShare, FieldMask, CallSettings)
            // Additional: UpdateNfsShareAsync(NfsShare, FieldMask, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NfsShare nfsShare = new NfsShare();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = await bareMetalSolutionClient.UpdateNfsShareAsync(nfsShare, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceUpdateNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShare</summary>
        public void CreateNfsShareRequestObject()
        {
            // Snippet: CreateNfsShare(CreateNfsShareRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateNfsShareRequest request = new CreateNfsShareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NfsShare = new NfsShare(),
            };
            // Make the request
            Operation<NfsShare, OperationMetadata> response = bareMetalSolutionClient.CreateNfsShare(request);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceCreateNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShareAsync</summary>
        public async Task CreateNfsShareRequestObjectAsync()
        {
            // Snippet: CreateNfsShareAsync(CreateNfsShareRequest, CallSettings)
            // Additional: CreateNfsShareAsync(CreateNfsShareRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateNfsShareRequest request = new CreateNfsShareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NfsShare = new NfsShare(),
            };
            // Make the request
            Operation<NfsShare, OperationMetadata> response = await bareMetalSolutionClient.CreateNfsShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceCreateNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShare</summary>
        public void CreateNfsShare()
        {
            // Snippet: CreateNfsShare(string, NfsShare, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NfsShare nfsShare = new NfsShare();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = bareMetalSolutionClient.CreateNfsShare(parent, nfsShare);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceCreateNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShareAsync</summary>
        public async Task CreateNfsShareAsync()
        {
            // Snippet: CreateNfsShareAsync(string, NfsShare, CallSettings)
            // Additional: CreateNfsShareAsync(string, NfsShare, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            NfsShare nfsShare = new NfsShare();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = await bareMetalSolutionClient.CreateNfsShareAsync(parent, nfsShare);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceCreateNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShare</summary>
        public void CreateNfsShareResourceNames()
        {
            // Snippet: CreateNfsShare(LocationName, NfsShare, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NfsShare nfsShare = new NfsShare();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = bareMetalSolutionClient.CreateNfsShare(parent, nfsShare);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceCreateNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNfsShareAsync</summary>
        public async Task CreateNfsShareResourceNamesAsync()
        {
            // Snippet: CreateNfsShareAsync(LocationName, NfsShare, CallSettings)
            // Additional: CreateNfsShareAsync(LocationName, NfsShare, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            NfsShare nfsShare = new NfsShare();
            // Make the request
            Operation<NfsShare, OperationMetadata> response = await bareMetalSolutionClient.CreateNfsShareAsync(parent, nfsShare);

            // Poll until the returned long-running operation is complete
            Operation<NfsShare, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NfsShare result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NfsShare, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceCreateNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NfsShare retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShare</summary>
        public void RenameNfsShareRequestObject()
        {
            // Snippet: RenameNfsShare(RenameNfsShareRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RenameNfsShareRequest request = new RenameNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NewNfsshareId = "",
            };
            // Make the request
            NfsShare response = bareMetalSolutionClient.RenameNfsShare(request);
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShareAsync</summary>
        public async Task RenameNfsShareRequestObjectAsync()
        {
            // Snippet: RenameNfsShareAsync(RenameNfsShareRequest, CallSettings)
            // Additional: RenameNfsShareAsync(RenameNfsShareRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RenameNfsShareRequest request = new RenameNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
                NewNfsshareId = "",
            };
            // Make the request
            NfsShare response = await bareMetalSolutionClient.RenameNfsShareAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShare</summary>
        public void RenameNfsShare()
        {
            // Snippet: RenameNfsShare(string, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            string newNfsshareId = "";
            // Make the request
            NfsShare response = bareMetalSolutionClient.RenameNfsShare(name, newNfsshareId);
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShareAsync</summary>
        public async Task RenameNfsShareAsync()
        {
            // Snippet: RenameNfsShareAsync(string, string, CallSettings)
            // Additional: RenameNfsShareAsync(string, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            string newNfsshareId = "";
            // Make the request
            NfsShare response = await bareMetalSolutionClient.RenameNfsShareAsync(name, newNfsshareId);
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShare</summary>
        public void RenameNfsShareResourceNames()
        {
            // Snippet: RenameNfsShare(NFSShareName, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            string newNfsshareId = "";
            // Make the request
            NfsShare response = bareMetalSolutionClient.RenameNfsShare(name, newNfsshareId);
            // End snippet
        }

        /// <summary>Snippet for RenameNfsShareAsync</summary>
        public async Task RenameNfsShareResourceNamesAsync()
        {
            // Snippet: RenameNfsShareAsync(NFSShareName, string, CallSettings)
            // Additional: RenameNfsShareAsync(NFSShareName, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            string newNfsshareId = "";
            // Make the request
            NfsShare response = await bareMetalSolutionClient.RenameNfsShareAsync(name, newNfsshareId);
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShare</summary>
        public void DeleteNfsShareRequestObject()
        {
            // Snippet: DeleteNfsShare(DeleteNfsShareRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            DeleteNfsShareRequest request = new DeleteNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.DeleteNfsShare(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDeleteNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShareAsync</summary>
        public async Task DeleteNfsShareRequestObjectAsync()
        {
            // Snippet: DeleteNfsShareAsync(DeleteNfsShareRequest, CallSettings)
            // Additional: DeleteNfsShareAsync(DeleteNfsShareRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNfsShareRequest request = new DeleteNfsShareRequest
            {
                NFSShareName = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.DeleteNfsShareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDeleteNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShare</summary>
        public void DeleteNfsShare()
        {
            // Snippet: DeleteNfsShare(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.DeleteNfsShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDeleteNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShareAsync</summary>
        public async Task DeleteNfsShareAsync()
        {
            // Snippet: DeleteNfsShareAsync(string, CallSettings)
            // Additional: DeleteNfsShareAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/nfsShares/[NFS_SHARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.DeleteNfsShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDeleteNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShare</summary>
        public void DeleteNfsShareResourceNames()
        {
            // Snippet: DeleteNfsShare(NFSShareName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = bareMetalSolutionClient.DeleteNfsShare(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = bareMetalSolutionClient.PollOnceDeleteNfsShare(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNfsShareAsync</summary>
        public async Task DeleteNfsShareResourceNamesAsync()
        {
            // Snippet: DeleteNfsShareAsync(NFSShareName, CallSettings)
            // Additional: DeleteNfsShareAsync(NFSShareName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NFSShareName name = NFSShareName.FromProjectLocationNfsShare("[PROJECT]", "[LOCATION]", "[NFS_SHARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await bareMetalSolutionClient.DeleteNfsShareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await bareMetalSolutionClient.PollOnceDeleteNfsShareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotas</summary>
        public void ListProvisioningQuotasRequestObject()
        {
            // Snippet: ListProvisioningQuotas(ListProvisioningQuotasRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProvisioningQuota item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvisioningQuotasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotasAsync</summary>
        public async Task ListProvisioningQuotasRequestObjectAsync()
        {
            // Snippet: ListProvisioningQuotasAsync(ListProvisioningQuotasRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListProvisioningQuotasRequest request = new ListProvisioningQuotasRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProvisioningQuota item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvisioningQuotasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotas</summary>
        public void ListProvisioningQuotas()
        {
            // Snippet: ListProvisioningQuotas(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProvisioningQuota item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvisioningQuotasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotasAsync</summary>
        public async Task ListProvisioningQuotasAsync()
        {
            // Snippet: ListProvisioningQuotasAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProvisioningQuota item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvisioningQuotasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotas</summary>
        public void ListProvisioningQuotasResourceNames()
        {
            // Snippet: ListProvisioningQuotas(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProvisioningQuota item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvisioningQuotasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvisioningQuotasAsync</summary>
        public async Task ListProvisioningQuotasResourceNamesAsync()
        {
            // Snippet: ListProvisioningQuotasAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProvisioningQuotasResponse, ProvisioningQuota> response = bareMetalSolutionClient.ListProvisioningQuotasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProvisioningQuota item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvisioningQuotasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProvisioningQuota item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProvisioningQuota> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProvisioningQuota item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfig</summary>
        public void SubmitProvisioningConfigRequestObject()
        {
            // Snippet: SubmitProvisioningConfig(SubmitProvisioningConfigRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            SubmitProvisioningConfigRequest request = new SubmitProvisioningConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProvisioningConfig = new ProvisioningConfig(),
                Email = "",
            };
            // Make the request
            SubmitProvisioningConfigResponse response = bareMetalSolutionClient.SubmitProvisioningConfig(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfigAsync</summary>
        public async Task SubmitProvisioningConfigRequestObjectAsync()
        {
            // Snippet: SubmitProvisioningConfigAsync(SubmitProvisioningConfigRequest, CallSettings)
            // Additional: SubmitProvisioningConfigAsync(SubmitProvisioningConfigRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            SubmitProvisioningConfigRequest request = new SubmitProvisioningConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProvisioningConfig = new ProvisioningConfig(),
                Email = "",
            };
            // Make the request
            SubmitProvisioningConfigResponse response = await bareMetalSolutionClient.SubmitProvisioningConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfig</summary>
        public void SubmitProvisioningConfig()
        {
            // Snippet: SubmitProvisioningConfig(string, ProvisioningConfig, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            SubmitProvisioningConfigResponse response = bareMetalSolutionClient.SubmitProvisioningConfig(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfigAsync</summary>
        public async Task SubmitProvisioningConfigAsync()
        {
            // Snippet: SubmitProvisioningConfigAsync(string, ProvisioningConfig, CallSettings)
            // Additional: SubmitProvisioningConfigAsync(string, ProvisioningConfig, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            SubmitProvisioningConfigResponse response = await bareMetalSolutionClient.SubmitProvisioningConfigAsync(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfig</summary>
        public void SubmitProvisioningConfigResourceNames()
        {
            // Snippet: SubmitProvisioningConfig(LocationName, ProvisioningConfig, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            SubmitProvisioningConfigResponse response = bareMetalSolutionClient.SubmitProvisioningConfig(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for SubmitProvisioningConfigAsync</summary>
        public async Task SubmitProvisioningConfigResourceNamesAsync()
        {
            // Snippet: SubmitProvisioningConfigAsync(LocationName, ProvisioningConfig, CallSettings)
            // Additional: SubmitProvisioningConfigAsync(LocationName, ProvisioningConfig, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            SubmitProvisioningConfigResponse response = await bareMetalSolutionClient.SubmitProvisioningConfigAsync(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfig</summary>
        public void GetProvisioningConfigRequestObject()
        {
            // Snippet: GetProvisioningConfig(GetProvisioningConfigRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            GetProvisioningConfigRequest request = new GetProvisioningConfigRequest
            {
                ProvisioningConfigName = ProvisioningConfigName.FromProjectLocationProvisioningConfig("[PROJECT]", "[LOCATION]", "[PROVISIONING_CONFIG]"),
            };
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.GetProvisioningConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfigAsync</summary>
        public async Task GetProvisioningConfigRequestObjectAsync()
        {
            // Snippet: GetProvisioningConfigAsync(GetProvisioningConfigRequest, CallSettings)
            // Additional: GetProvisioningConfigAsync(GetProvisioningConfigRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            GetProvisioningConfigRequest request = new GetProvisioningConfigRequest
            {
                ProvisioningConfigName = ProvisioningConfigName.FromProjectLocationProvisioningConfig("[PROJECT]", "[LOCATION]", "[PROVISIONING_CONFIG]"),
            };
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.GetProvisioningConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfig</summary>
        public void GetProvisioningConfig()
        {
            // Snippet: GetProvisioningConfig(string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/provisioningConfigs/[PROVISIONING_CONFIG]";
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.GetProvisioningConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfigAsync</summary>
        public async Task GetProvisioningConfigAsync()
        {
            // Snippet: GetProvisioningConfigAsync(string, CallSettings)
            // Additional: GetProvisioningConfigAsync(string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/provisioningConfigs/[PROVISIONING_CONFIG]";
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.GetProvisioningConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfig</summary>
        public void GetProvisioningConfigResourceNames()
        {
            // Snippet: GetProvisioningConfig(ProvisioningConfigName, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ProvisioningConfigName name = ProvisioningConfigName.FromProjectLocationProvisioningConfig("[PROJECT]", "[LOCATION]", "[PROVISIONING_CONFIG]");
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.GetProvisioningConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetProvisioningConfigAsync</summary>
        public async Task GetProvisioningConfigResourceNamesAsync()
        {
            // Snippet: GetProvisioningConfigAsync(ProvisioningConfigName, CallSettings)
            // Additional: GetProvisioningConfigAsync(ProvisioningConfigName, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ProvisioningConfigName name = ProvisioningConfigName.FromProjectLocationProvisioningConfig("[PROJECT]", "[LOCATION]", "[PROVISIONING_CONFIG]");
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.GetProvisioningConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfig</summary>
        public void CreateProvisioningConfigRequestObject()
        {
            // Snippet: CreateProvisioningConfig(CreateProvisioningConfigRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            CreateProvisioningConfigRequest request = new CreateProvisioningConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProvisioningConfig = new ProvisioningConfig(),
                Email = "",
            };
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.CreateProvisioningConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfigAsync</summary>
        public async Task CreateProvisioningConfigRequestObjectAsync()
        {
            // Snippet: CreateProvisioningConfigAsync(CreateProvisioningConfigRequest, CallSettings)
            // Additional: CreateProvisioningConfigAsync(CreateProvisioningConfigRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            CreateProvisioningConfigRequest request = new CreateProvisioningConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProvisioningConfig = new ProvisioningConfig(),
                Email = "",
            };
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.CreateProvisioningConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfig</summary>
        public void CreateProvisioningConfig()
        {
            // Snippet: CreateProvisioningConfig(string, ProvisioningConfig, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.CreateProvisioningConfig(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfigAsync</summary>
        public async Task CreateProvisioningConfigAsync()
        {
            // Snippet: CreateProvisioningConfigAsync(string, ProvisioningConfig, CallSettings)
            // Additional: CreateProvisioningConfigAsync(string, ProvisioningConfig, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.CreateProvisioningConfigAsync(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfig</summary>
        public void CreateProvisioningConfigResourceNames()
        {
            // Snippet: CreateProvisioningConfig(LocationName, ProvisioningConfig, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.CreateProvisioningConfig(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateProvisioningConfigAsync</summary>
        public async Task CreateProvisioningConfigResourceNamesAsync()
        {
            // Snippet: CreateProvisioningConfigAsync(LocationName, ProvisioningConfig, CallSettings)
            // Additional: CreateProvisioningConfigAsync(LocationName, ProvisioningConfig, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.CreateProvisioningConfigAsync(parent, provisioningConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateProvisioningConfig</summary>
        public void UpdateProvisioningConfigRequestObject()
        {
            // Snippet: UpdateProvisioningConfig(UpdateProvisioningConfigRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            UpdateProvisioningConfigRequest request = new UpdateProvisioningConfigRequest
            {
                ProvisioningConfig = new ProvisioningConfig(),
                UpdateMask = new FieldMask(),
                Email = "",
            };
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.UpdateProvisioningConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProvisioningConfigAsync</summary>
        public async Task UpdateProvisioningConfigRequestObjectAsync()
        {
            // Snippet: UpdateProvisioningConfigAsync(UpdateProvisioningConfigRequest, CallSettings)
            // Additional: UpdateProvisioningConfigAsync(UpdateProvisioningConfigRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProvisioningConfigRequest request = new UpdateProvisioningConfigRequest
            {
                ProvisioningConfig = new ProvisioningConfig(),
                UpdateMask = new FieldMask(),
                Email = "",
            };
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.UpdateProvisioningConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProvisioningConfig</summary>
        public void UpdateProvisioningConfig()
        {
            // Snippet: UpdateProvisioningConfig(ProvisioningConfig, FieldMask, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProvisioningConfig response = bareMetalSolutionClient.UpdateProvisioningConfig(provisioningConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProvisioningConfigAsync</summary>
        public async Task UpdateProvisioningConfigAsync()
        {
            // Snippet: UpdateProvisioningConfigAsync(ProvisioningConfig, FieldMask, CallSettings)
            // Additional: UpdateProvisioningConfigAsync(ProvisioningConfig, FieldMask, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ProvisioningConfig provisioningConfig = new ProvisioningConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProvisioningConfig response = await bareMetalSolutionClient.UpdateProvisioningConfigAsync(provisioningConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RenameNetwork</summary>
        public void RenameNetworkRequestObject()
        {
            // Snippet: RenameNetwork(RenameNetworkRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            RenameNetworkRequest request = new RenameNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                NewNetworkId = "",
            };
            // Make the request
            Network response = bareMetalSolutionClient.RenameNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for RenameNetworkAsync</summary>
        public async Task RenameNetworkRequestObjectAsync()
        {
            // Snippet: RenameNetworkAsync(RenameNetworkRequest, CallSettings)
            // Additional: RenameNetworkAsync(RenameNetworkRequest, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            RenameNetworkRequest request = new RenameNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]"),
                NewNetworkId = "",
            };
            // Make the request
            Network response = await bareMetalSolutionClient.RenameNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameNetwork</summary>
        public void RenameNetwork()
        {
            // Snippet: RenameNetwork(string, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            string newNetworkId = "";
            // Make the request
            Network response = bareMetalSolutionClient.RenameNetwork(name, newNetworkId);
            // End snippet
        }

        /// <summary>Snippet for RenameNetworkAsync</summary>
        public async Task RenameNetworkAsync()
        {
            // Snippet: RenameNetworkAsync(string, string, CallSettings)
            // Additional: RenameNetworkAsync(string, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/networks/[NETWORK]";
            string newNetworkId = "";
            // Make the request
            Network response = await bareMetalSolutionClient.RenameNetworkAsync(name, newNetworkId);
            // End snippet
        }

        /// <summary>Snippet for RenameNetwork</summary>
        public void RenameNetworkResourceNames()
        {
            // Snippet: RenameNetwork(NetworkName, string, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            string newNetworkId = "";
            // Make the request
            Network response = bareMetalSolutionClient.RenameNetwork(name, newNetworkId);
            // End snippet
        }

        /// <summary>Snippet for RenameNetworkAsync</summary>
        public async Task RenameNetworkResourceNamesAsync()
        {
            // Snippet: RenameNetworkAsync(NetworkName, string, CallSettings)
            // Additional: RenameNetworkAsync(NetworkName, string, CancellationToken)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationNetwork("[PROJECT]", "[LOCATION]", "[NETWORK]");
            string newNetworkId = "";
            // Make the request
            Network response = await bareMetalSolutionClient.RenameNetworkAsync(name, newNetworkId);
            // End snippet
        }

        /// <summary>Snippet for ListOSImages</summary>
        public void ListOSImagesRequestObject()
        {
            // Snippet: ListOSImages(ListOSImagesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            ListOSImagesRequest request = new ListOSImagesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSImagesAsync</summary>
        public async Task ListOSImagesRequestObjectAsync()
        {
            // Snippet: ListOSImagesAsync(ListOSImagesRequest, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            ListOSImagesRequest request = new ListOSImagesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSImages</summary>
        public void ListOSImages()
        {
            // Snippet: ListOSImages(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSImagesAsync</summary>
        public async Task ListOSImagesAsync()
        {
            // Snippet: ListOSImagesAsync(string, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSImages</summary>
        public void ListOSImagesResourceNames()
        {
            // Snippet: ListOSImages(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = BareMetalSolutionClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OSImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOSImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOSImagesAsync</summary>
        public async Task ListOSImagesResourceNamesAsync()
        {
            // Snippet: ListOSImagesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BareMetalSolutionClient bareMetalSolutionClient = await BareMetalSolutionClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOSImagesResponse, OSImage> response = bareMetalSolutionClient.ListOSImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OSImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOSImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OSImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OSImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OSImage item in singlePage)
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
