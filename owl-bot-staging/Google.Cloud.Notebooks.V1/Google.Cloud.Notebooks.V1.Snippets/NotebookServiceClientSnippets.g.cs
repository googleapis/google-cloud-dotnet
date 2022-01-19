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

namespace Google.Cloud.Notebooks.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcnv = Google.Cloud.Notebooks.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = notebookServiceClient.ListInstances(request);

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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = notebookServiceClient.ListInstancesAsync(request);

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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = notebookServiceClient.ListInstances(parent);

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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = notebookServiceClient.ListInstancesAsync(parent);

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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest { Name = "", };
            // Make the request
            Instance response = notebookServiceClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest { Name = "", };
            // Make the request
            Instance response = await notebookServiceClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Instance response = notebookServiceClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Instance response = await notebookServiceClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                Parent = "",
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateInstance(operationName);
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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                Parent = "",
                InstanceId = "",
                Instance = new Instance(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateInstanceAsync(operationName);
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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateInstance(operationName);
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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterInstance</summary>
        public void RegisterInstanceRequestObject()
        {
            // Snippet: RegisterInstance(RegisterInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            RegisterInstanceRequest request = new RegisterInstanceRequest
            {
                Parent = "",
                InstanceId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.RegisterInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceRegisterInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterInstanceAsync</summary>
        public async Task RegisterInstanceRequestObjectAsync()
        {
            // Snippet: RegisterInstanceAsync(RegisterInstanceRequest, CallSettings)
            // Additional: RegisterInstanceAsync(RegisterInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegisterInstanceRequest request = new RegisterInstanceRequest
            {
                Parent = "",
                InstanceId = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.RegisterInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceRegisterInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceAccelerator</summary>
        public void SetInstanceAcceleratorRequestObject()
        {
            // Snippet: SetInstanceAccelerator(SetInstanceAcceleratorRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            SetInstanceAcceleratorRequest request = new SetInstanceAcceleratorRequest
            {
                Name = "",
                Type = Instance.Types.AcceleratorType.Unspecified,
                CoreCount = 0L,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.SetInstanceAccelerator(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceAccelerator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceAcceleratorAsync</summary>
        public async Task SetInstanceAcceleratorRequestObjectAsync()
        {
            // Snippet: SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest, CallSettings)
            // Additional: SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceAcceleratorRequest request = new SetInstanceAcceleratorRequest
            {
                Name = "",
                Type = Instance.Types.AcceleratorType.Unspecified,
                CoreCount = 0L,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.SetInstanceAcceleratorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceAcceleratorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceMachineType</summary>
        public void SetInstanceMachineTypeRequestObject()
        {
            // Snippet: SetInstanceMachineType(SetInstanceMachineTypeRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            SetInstanceMachineTypeRequest request = new SetInstanceMachineTypeRequest
            {
                Name = "",
                MachineType = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.SetInstanceMachineType(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceMachineType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceMachineTypeAsync</summary>
        public async Task SetInstanceMachineTypeRequestObjectAsync()
        {
            // Snippet: SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest, CallSettings)
            // Additional: SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceMachineTypeRequest request = new SetInstanceMachineTypeRequest
            {
                Name = "",
                MachineType = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.SetInstanceMachineTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceMachineTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfig</summary>
        public void UpdateInstanceConfigRequestObject()
        {
            // Snippet: UpdateInstanceConfig(UpdateInstanceConfigRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpdateInstanceConfigRequest request = new UpdateInstanceConfigRequest
            {
                Name = "",
                Config = new InstanceConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.UpdateInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpdateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfigAsync</summary>
        public async Task UpdateInstanceConfigRequestObjectAsync()
        {
            // Snippet: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CallSettings)
            // Additional: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceConfigRequest request = new UpdateInstanceConfigRequest
            {
                Name = "",
                Config = new InstanceConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.UpdateInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpdateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateShieldedInstanceConfig</summary>
        public void UpdateShieldedInstanceConfigRequestObject()
        {
            // Snippet: UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpdateShieldedInstanceConfigRequest request = new UpdateShieldedInstanceConfigRequest
            {
                Name = "",
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.UpdateShieldedInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpdateShieldedInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateShieldedInstanceConfigAsync</summary>
        public async Task UpdateShieldedInstanceConfigRequestObjectAsync()
        {
            // Snippet: UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest, CallSettings)
            // Additional: UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateShieldedInstanceConfigRequest request = new UpdateShieldedInstanceConfigRequest
            {
                Name = "",
                ShieldedInstanceConfig = new Instance.Types.ShieldedInstanceConfig(),
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.UpdateShieldedInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpdateShieldedInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceLabels</summary>
        public void SetInstanceLabelsRequestObject()
        {
            // Snippet: SetInstanceLabels(SetInstanceLabelsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            SetInstanceLabelsRequest request = new SetInstanceLabelsRequest
            {
                Name = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.SetInstanceLabels(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceLabelsAsync</summary>
        public async Task SetInstanceLabelsRequestObjectAsync()
        {
            // Snippet: SetInstanceLabelsAsync(SetInstanceLabelsRequest, CallSettings)
            // Additional: SetInstanceLabelsAsync(SetInstanceLabelsRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetInstanceLabelsRequest request = new SetInstanceLabelsRequest
            {
                Name = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.SetInstanceLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceLabelsAsync(operationName);
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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteInstance(operationName);
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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteInstanceAsync(operationName);
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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteInstance(operationName);
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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstance</summary>
        public void StartInstanceRequestObject()
        {
            // Snippet: StartInstance(StartInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            StartInstanceRequest request = new StartInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.StartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceRequestObjectAsync()
        {
            // Snippet: StartInstanceAsync(StartInstanceRequest, CallSettings)
            // Additional: StartInstanceAsync(StartInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartInstanceRequest request = new StartInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.StartInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceRequestObject()
        {
            // Snippet: StopInstance(StopInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            StopInstanceRequest request = new StopInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.StopInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceRequestObjectAsync()
        {
            // Snippet: StopInstanceAsync(StopInstanceRequest, CallSettings)
            // Additional: StopInstanceAsync(StopInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StopInstanceRequest request = new StopInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.StopInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStopInstanceAsync(operationName);
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
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.ResetInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceRequestObjectAsync()
        {
            // Snippet: ResetInstanceAsync(ResetInstanceRequest, CallSettings)
            // Additional: ResetInstanceAsync(ResetInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetInstanceRequest request = new ResetInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.ResetInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportInstanceInfo</summary>
        public void ReportInstanceInfoRequestObject()
        {
            // Snippet: ReportInstanceInfo(ReportInstanceInfoRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ReportInstanceInfoRequest request = new ReportInstanceInfoRequest
            {
                Name = "",
                VmId = "",
                Metadata = { { "", "" }, },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.ReportInstanceInfo(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceReportInstanceInfo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportInstanceInfoAsync</summary>
        public async Task ReportInstanceInfoRequestObjectAsync()
        {
            // Snippet: ReportInstanceInfoAsync(ReportInstanceInfoRequest, CallSettings)
            // Additional: ReportInstanceInfoAsync(ReportInstanceInfoRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportInstanceInfoRequest request = new ReportInstanceInfoRequest
            {
                Name = "",
                VmId = "",
                Metadata = { { "", "" }, },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.ReportInstanceInfoAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceReportInstanceInfoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IsInstanceUpgradeable</summary>
        public void IsInstanceUpgradeableRequestObject()
        {
            // Snippet: IsInstanceUpgradeable(IsInstanceUpgradeableRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            IsInstanceUpgradeableRequest request = new IsInstanceUpgradeableRequest
            {
                NotebookInstance = "",
            };
            // Make the request
            IsInstanceUpgradeableResponse response = notebookServiceClient.IsInstanceUpgradeable(request);
            // End snippet
        }

        /// <summary>Snippet for IsInstanceUpgradeableAsync</summary>
        public async Task IsInstanceUpgradeableRequestObjectAsync()
        {
            // Snippet: IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest, CallSettings)
            // Additional: IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            IsInstanceUpgradeableRequest request = new IsInstanceUpgradeableRequest
            {
                NotebookInstance = "",
            };
            // Make the request
            IsInstanceUpgradeableResponse response = await notebookServiceClient.IsInstanceUpgradeableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealthRequestObject()
        {
            // Snippet: GetInstanceHealth(GetInstanceHealthRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthRequestObjectAsync()
        {
            // Snippet: GetInstanceHealthAsync(GetInstanceHealthRequest, CallSettings)
            // Additional: GetInstanceHealthAsync(GetInstanceHealthRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceHealthRequest request = new GetInstanceHealthRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealth()
        {
            // Snippet: GetInstanceHealth(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthAsync()
        {
            // Snippet: GetInstanceHealthAsync(string, CallSettings)
            // Additional: GetInstanceHealthAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealthResourceNames()
        {
            // Snippet: GetInstanceHealth(InstanceName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthResourceNamesAsync()
        {
            // Snippet: GetInstanceHealthAsync(InstanceName, CallSettings)
            // Additional: GetInstanceHealthAsync(InstanceName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstanceRequestObject()
        {
            // Snippet: UpgradeInstance(UpgradeInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpgradeInstanceRequest request = new UpgradeInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.UpgradeInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstance(operationName);
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
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeInstanceRequest request = new UpgradeInstanceRequest { Name = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.UpgradeInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackInstance</summary>
        public void RollbackInstanceRequestObject()
        {
            // Snippet: RollbackInstance(RollbackInstanceRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            RollbackInstanceRequest request = new RollbackInstanceRequest
            {
                Name = "",
                TargetSnapshot = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.RollbackInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceRollbackInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackInstanceAsync</summary>
        public async Task RollbackInstanceRequestObjectAsync()
        {
            // Snippet: RollbackInstanceAsync(RollbackInstanceRequest, CallSettings)
            // Additional: RollbackInstanceAsync(RollbackInstanceRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollbackInstanceRequest request = new RollbackInstanceRequest
            {
                Name = "",
                TargetSnapshot = "",
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.RollbackInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceRollbackInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceInternal</summary>
        public void UpgradeInstanceInternalRequestObject()
        {
            // Snippet: UpgradeInstanceInternal(UpgradeInstanceInternalRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            UpgradeInstanceInternalRequest request = new UpgradeInstanceInternalRequest { Name = "", VmId = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = notebookServiceClient.UpgradeInstanceInternal(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstanceInternal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceInternalAsync</summary>
        public async Task UpgradeInstanceInternalRequestObjectAsync()
        {
            // Snippet: UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest, CallSettings)
            // Additional: UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeInstanceInternalRequest request = new UpgradeInstanceInternalRequest { Name = "", VmId = "", };
            // Make the request
            Operation<Instance, OperationMetadata> response = await notebookServiceClient.UpgradeInstanceInternalAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceInternalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListEnvironmentsRequest request = new ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsRequestObjectAsync()
        {
            // Snippet: ListEnvironmentsAsync(ListEnvironmentsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEnvironmentsRequest request = new ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironments()
        {
            // Snippet: ListEnvironments(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsAsync()
        {
            // Snippet: ListEnvironmentsAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest { Name = "", };
            // Make the request
            gcnv::Environment response = notebookServiceClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEnvironmentRequest request = new GetEnvironmentRequest { Name = "", };
            // Make the request
            gcnv::Environment response = await notebookServiceClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcnv::Environment response = notebookServiceClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentAsync()
        {
            // Snippet: GetEnvironmentAsync(string, CallSettings)
            // Additional: GetEnvironmentAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcnv::Environment response = await notebookServiceClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentRequestObject()
        {
            // Snippet: CreateEnvironment(CreateEnvironmentRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                Parent = "",
                EnvironmentId = "",
                Environment = new gcnv::Environment(),
            };
            // Make the request
            Operation<gcnv::Environment, OperationMetadata> response = notebookServiceClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Snippet: CreateEnvironmentAsync(CreateEnvironmentRequest, CallSettings)
            // Additional: CreateEnvironmentAsync(CreateEnvironmentRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                Parent = "",
                EnvironmentId = "",
                Environment = new gcnv::Environment(),
            };
            // Make the request
            Operation<gcnv::Environment, OperationMetadata> response = await notebookServiceClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironment()
        {
            // Snippet: CreateEnvironment(string, Environment, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Environment environment = new gcnv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcnv::Environment, OperationMetadata> response = notebookServiceClient.CreateEnvironment(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentAsync()
        {
            // Snippet: CreateEnvironmentAsync(string, Environment, string, CallSettings)
            // Additional: CreateEnvironmentAsync(string, Environment, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Environment environment = new gcnv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcnv::Environment, OperationMetadata> response = await notebookServiceClient.CreateEnvironmentAsync(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentRequestObject()
        {
            // Snippet: DeleteEnvironment(DeleteEnvironmentRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentRequestObjectAsync()
        {
            // Snippet: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CallSettings)
            // Additional: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEnvironmentRequest request = new DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironment()
        {
            // Snippet: DeleteEnvironment(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteEnvironment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentAsync()
        {
            // Snippet: DeleteEnvironmentAsync(string, CallSettings)
            // Additional: DeleteEnvironmentAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteEnvironmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedulesRequestObject()
        {
            // Snippet: ListSchedules(ListSchedulesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesRequestObjectAsync()
        {
            // Snippet: ListSchedulesAsync(ListSchedulesRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedules()
        {
            // Snippet: ListSchedules(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesAsync()
        {
            // Snippet: ListSchedulesAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedules</summary>
        public void ListSchedulesResourceNames()
        {
            // Snippet: ListSchedules(ScheduleName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName parent = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            PagedEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSchedulesAsync</summary>
        public async Task ListSchedulesResourceNamesAsync()
        {
            // Snippet: ListSchedulesAsync(ScheduleName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName parent = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            PagedAsyncEnumerable<ListSchedulesResponse, Schedule> response = notebookServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Schedule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetScheduleRequestObject()
        {
            // Snippet: GetSchedule(GetScheduleRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Schedule response = notebookServiceClient.GetSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleRequestObjectAsync()
        {
            // Snippet: GetScheduleAsync(GetScheduleRequest, CallSettings)
            // Additional: GetScheduleAsync(GetScheduleRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetScheduleRequest request = new GetScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Schedule response = await notebookServiceClient.GetScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetSchedule()
        {
            // Snippet: GetSchedule(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Schedule response = notebookServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleAsync()
        {
            // Snippet: GetScheduleAsync(string, CallSettings)
            // Additional: GetScheduleAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Schedule response = await notebookServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetScheduleResourceNames()
        {
            // Snippet: GetSchedule(ScheduleName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Schedule response = notebookServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleResourceNamesAsync()
        {
            // Snippet: GetScheduleAsync(ScheduleName, CallSettings)
            // Additional: GetScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Schedule response = await notebookServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteScheduleRequestObject()
        {
            // Snippet: DeleteSchedule(DeleteScheduleRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteScheduleRequest request = new DeleteScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleRequestObjectAsync()
        {
            // Snippet: DeleteScheduleAsync(DeleteScheduleRequest, CallSettings)
            // Additional: DeleteScheduleAsync(DeleteScheduleRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScheduleRequest request = new DeleteScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteSchedule()
        {
            // Snippet: DeleteSchedule(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleAsync()
        {
            // Snippet: DeleteScheduleAsync(string, CallSettings)
            // Additional: DeleteScheduleAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteScheduleResourceNames()
        {
            // Snippet: DeleteSchedule(ScheduleName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScheduleAsync</summary>
        public async Task DeleteScheduleResourceNamesAsync()
        {
            // Snippet: DeleteScheduleAsync(ScheduleName, CallSettings)
            // Additional: DeleteScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName name = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateScheduleRequestObject()
        {
            // Snippet: CreateSchedule(CreateScheduleRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateScheduleRequest request = new CreateScheduleRequest
            {
                ParentAsScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                ScheduleId = "",
                Schedule = new Schedule(),
            };
            // Make the request
            Operation<Schedule, OperationMetadata> response = notebookServiceClient.CreateSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleRequestObjectAsync()
        {
            // Snippet: CreateScheduleAsync(CreateScheduleRequest, CallSettings)
            // Additional: CreateScheduleAsync(CreateScheduleRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateScheduleRequest request = new CreateScheduleRequest
            {
                ParentAsScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                ScheduleId = "",
                Schedule = new Schedule(),
            };
            // Make the request
            Operation<Schedule, OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateSchedule()
        {
            // Snippet: CreateSchedule(string, Schedule, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            Schedule schedule = new Schedule();
            string scheduleId = "";
            // Make the request
            Operation<Schedule, OperationMetadata> response = notebookServiceClient.CreateSchedule(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleAsync()
        {
            // Snippet: CreateScheduleAsync(string, Schedule, string, CallSettings)
            // Additional: CreateScheduleAsync(string, Schedule, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            Schedule schedule = new Schedule();
            string scheduleId = "";
            // Make the request
            Operation<Schedule, OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateScheduleResourceNames()
        {
            // Snippet: CreateSchedule(ScheduleName, Schedule, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ScheduleName parent = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            Schedule schedule = new Schedule();
            string scheduleId = "";
            // Make the request
            Operation<Schedule, OperationMetadata> response = notebookServiceClient.CreateSchedule(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleResourceNamesAsync()
        {
            // Snippet: CreateScheduleAsync(ScheduleName, Schedule, string, CallSettings)
            // Additional: CreateScheduleAsync(ScheduleName, Schedule, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ScheduleName parent = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            Schedule schedule = new Schedule();
            string scheduleId = "";
            // Make the request
            Operation<Schedule, OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerSchedule</summary>
        public void TriggerScheduleRequestObject()
        {
            // Snippet: TriggerSchedule(TriggerScheduleRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            TriggerScheduleRequest request = new TriggerScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Schedule, OperationMetadata> response = notebookServiceClient.TriggerSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceTriggerSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerScheduleAsync</summary>
        public async Task TriggerScheduleRequestObjectAsync()
        {
            // Snippet: TriggerScheduleAsync(TriggerScheduleRequest, CallSettings)
            // Additional: TriggerScheduleAsync(TriggerScheduleRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            TriggerScheduleRequest request = new TriggerScheduleRequest
            {
                ScheduleName = ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Schedule, OperationMetadata> response = await notebookServiceClient.TriggerScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Schedule, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Schedule, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceTriggerScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsRequestObjectAsync()
        {
            // Snippet: ListExecutionsAsync(ListExecutionsRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutions()
        {
            // Snippet: ListExecutions(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsAsync()
        {
            // Snippet: ListExecutionsAsync(string, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsResourceNames()
        {
            // Snippet: ListExecutions(ExecutionName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName parent = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsResourceNamesAsync()
        {
            // Snippet: ListExecutionsAsync(ExecutionName, string, int?, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName parent = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = notebookServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionRequestObject()
        {
            // Snippet: GetExecution(GetExecutionRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = notebookServiceClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = await notebookServiceClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Execution response = notebookServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Execution response = await notebookServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Execution response = notebookServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Execution response = await notebookServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionRequestObject()
        {
            // Snippet: DeleteExecution(DeleteExecutionRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionRequestObjectAsync()
        {
            // Snippet: DeleteExecutionAsync(DeleteExecutionRequest, CallSettings)
            // Additional: DeleteExecutionAsync(DeleteExecutionRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExecutionRequest request = new DeleteExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecution()
        {
            // Snippet: DeleteExecution(string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionAsync()
        {
            // Snippet: DeleteExecutionAsync(string, CallSettings)
            // Additional: DeleteExecutionAsync(string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionResourceNames()
        {
            // Snippet: DeleteExecution(ExecutionName, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = notebookServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionResourceNamesAsync()
        {
            // Snippet: DeleteExecutionAsync(ExecutionName, CallSettings)
            // Additional: DeleteExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionRequestObject()
        {
            // Snippet: CreateExecution(CreateExecutionRequest, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                ExecutionId = "",
                Execution = new Execution(),
            };
            // Make the request
            Operation<Execution, OperationMetadata> response = notebookServiceClient.CreateExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionRequestObjectAsync()
        {
            // Snippet: CreateExecutionAsync(CreateExecutionRequest, CallSettings)
            // Additional: CreateExecutionAsync(CreateExecutionRequest, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsExecutionName = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                ExecutionId = "",
                Execution = new Execution(),
            };
            // Make the request
            Operation<Execution, OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecution()
        {
            // Snippet: CreateExecution(string, Execution, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = notebookServiceClient.CreateExecution(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionAsync()
        {
            // Snippet: CreateExecutionAsync(string, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(string, Execution, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionResourceNames()
        {
            // Snippet: CreateExecution(ExecutionName, Execution, string, CallSettings)
            // Create client
            NotebookServiceClient notebookServiceClient = NotebookServiceClient.Create();
            // Initialize request argument(s)
            ExecutionName parent = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = notebookServiceClient.CreateExecution(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionResourceNamesAsync()
        {
            // Snippet: CreateExecutionAsync(ExecutionName, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(ExecutionName, Execution, string, CancellationToken)
            // Create client
            NotebookServiceClient notebookServiceClient = await NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName parent = ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            Execution execution = new Execution();
            string executionId = "";
            // Make the request
            Operation<Execution, OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<Execution, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Execution, OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
