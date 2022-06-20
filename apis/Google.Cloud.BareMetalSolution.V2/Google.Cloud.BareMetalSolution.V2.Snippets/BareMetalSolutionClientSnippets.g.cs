// Copyright 2022 Google LLC
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

namespace Google.Cloud.BareMetalSolution.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
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
    }
}
