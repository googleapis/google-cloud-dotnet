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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcnv = Google.Cloud.Notebooks.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ListInstancesRequest request = new gcnv::ListInstancesRequest { Parent = "", };
            // Make the request
            PagedEnumerable<gcnv::ListInstancesResponse, gcnv::Instance> response = notebookServiceClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Instance item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ListInstancesRequest request = new gcnv::ListInstancesRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<gcnv::ListInstancesResponse, gcnv::Instance> response = notebookServiceClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Instance item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcnv::ListInstancesResponse, gcnv::Instance> response = notebookServiceClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Instance item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcnv::ListInstancesResponse, gcnv::Instance> response = notebookServiceClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Instance item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::GetInstanceRequest request = new gcnv::GetInstanceRequest { Name = "", };
            // Make the request
            gcnv::Instance response = notebookServiceClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::GetInstanceRequest request = new gcnv::GetInstanceRequest { Name = "", };
            // Make the request
            gcnv::Instance response = await notebookServiceClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcnv::Instance response = notebookServiceClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcnv::Instance response = await notebookServiceClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::CreateInstanceRequest request = new gcnv::CreateInstanceRequest
            {
                Parent = "",
                InstanceId = "",
                Instance = new gcnv::Instance(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::CreateInstanceRequest request = new gcnv::CreateInstanceRequest
            {
                Parent = "",
                InstanceId = "",
                Instance = new gcnv::Instance(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string, Instance, string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Instance instance = new gcnv::Instance();
            string instanceId = "";
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, Instance, string, CallSettings)
            // Additional: CreateInstanceAsync(string, Instance, string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Instance instance = new gcnv::Instance();
            string instanceId = "";
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterInstance</summary>
        public void RegisterInstanceRequestObject()
        {
            // Snippet: RegisterInstance(RegisterInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::RegisterInstanceRequest request = new gcnv::RegisterInstanceRequest
            {
                Parent = "",
                InstanceId = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.RegisterInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceRegisterInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RegisterInstanceAsync</summary>
        public async Task RegisterInstanceRequestObjectAsync()
        {
            // Snippet: RegisterInstanceAsync(RegisterInstanceRequest, CallSettings)
            // Additional: RegisterInstanceAsync(RegisterInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::RegisterInstanceRequest request = new gcnv::RegisterInstanceRequest
            {
                Parent = "",
                InstanceId = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.RegisterInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceRegisterInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceAccelerator</summary>
        public void SetInstanceAcceleratorRequestObject()
        {
            // Snippet: SetInstanceAccelerator(SetInstanceAcceleratorRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::SetInstanceAcceleratorRequest request = new gcnv::SetInstanceAcceleratorRequest
            {
                Name = "",
                Type = gcnv::Instance.Types.AcceleratorType.Unspecified,
                CoreCount = 0L,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.SetInstanceAccelerator(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceAccelerator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceAcceleratorAsync</summary>
        public async Task SetInstanceAcceleratorRequestObjectAsync()
        {
            // Snippet: SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest, CallSettings)
            // Additional: SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::SetInstanceAcceleratorRequest request = new gcnv::SetInstanceAcceleratorRequest
            {
                Name = "",
                Type = gcnv::Instance.Types.AcceleratorType.Unspecified,
                CoreCount = 0L,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.SetInstanceAcceleratorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceAcceleratorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceMachineType</summary>
        public void SetInstanceMachineTypeRequestObject()
        {
            // Snippet: SetInstanceMachineType(SetInstanceMachineTypeRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::SetInstanceMachineTypeRequest request = new gcnv::SetInstanceMachineTypeRequest
            {
                Name = "",
                MachineType = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.SetInstanceMachineType(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceMachineType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceMachineTypeAsync</summary>
        public async Task SetInstanceMachineTypeRequestObjectAsync()
        {
            // Snippet: SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest, CallSettings)
            // Additional: SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::SetInstanceMachineTypeRequest request = new gcnv::SetInstanceMachineTypeRequest
            {
                Name = "",
                MachineType = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.SetInstanceMachineTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceMachineTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfig</summary>
        public void UpdateInstanceConfigRequestObject()
        {
            // Snippet: UpdateInstanceConfig(UpdateInstanceConfigRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpdateInstanceConfigRequest request = new gcnv::UpdateInstanceConfigRequest
            {
                Name = "",
                Config = new gcnv::InstanceConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpdateInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpdateInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceConfigAsync</summary>
        public async Task UpdateInstanceConfigRequestObjectAsync()
        {
            // Snippet: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CallSettings)
            // Additional: UpdateInstanceConfigAsync(UpdateInstanceConfigRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::UpdateInstanceConfigRequest request = new gcnv::UpdateInstanceConfigRequest
            {
                Name = "",
                Config = new gcnv::InstanceConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpdateInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpdateInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateShieldedInstanceConfig</summary>
        public void UpdateShieldedInstanceConfigRequestObject()
        {
            // Snippet: UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpdateShieldedInstanceConfigRequest request = new gcnv::UpdateShieldedInstanceConfigRequest
            {
                Name = "",
                ShieldedInstanceConfig = new gcnv::Instance.Types.ShieldedInstanceConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpdateShieldedInstanceConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpdateShieldedInstanceConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateShieldedInstanceConfigAsync</summary>
        public async Task UpdateShieldedInstanceConfigRequestObjectAsync()
        {
            // Snippet: UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest, CallSettings)
            // Additional: UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::UpdateShieldedInstanceConfigRequest request = new gcnv::UpdateShieldedInstanceConfigRequest
            {
                Name = "",
                ShieldedInstanceConfig = new gcnv::Instance.Types.ShieldedInstanceConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpdateShieldedInstanceConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpdateShieldedInstanceConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceLabels</summary>
        public void SetInstanceLabelsRequestObject()
        {
            // Snippet: SetInstanceLabels(SetInstanceLabelsRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::SetInstanceLabelsRequest request = new gcnv::SetInstanceLabelsRequest
            {
                Name = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.SetInstanceLabels(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceSetInstanceLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInstanceLabelsAsync</summary>
        public async Task SetInstanceLabelsRequestObjectAsync()
        {
            // Snippet: SetInstanceLabelsAsync(SetInstanceLabelsRequest, CallSettings)
            // Additional: SetInstanceLabelsAsync(SetInstanceLabelsRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::SetInstanceLabelsRequest request = new gcnv::SetInstanceLabelsRequest
            {
                Name = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.SetInstanceLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceSetInstanceLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceMetadataItems</summary>
        public void UpdateInstanceMetadataItemsRequestObject()
        {
            // Snippet: UpdateInstanceMetadataItems(UpdateInstanceMetadataItemsRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpdateInstanceMetadataItemsRequest request = new gcnv::UpdateInstanceMetadataItemsRequest
            {
                Name = "",
                Items = { { "", "" }, },
            };
            // Make the request
            gcnv::UpdateInstanceMetadataItemsResponse response = notebookServiceClient.UpdateInstanceMetadataItems(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceMetadataItemsAsync</summary>
        public async Task UpdateInstanceMetadataItemsRequestObjectAsync()
        {
            // Snippet: UpdateInstanceMetadataItemsAsync(UpdateInstanceMetadataItemsRequest, CallSettings)
            // Additional: UpdateInstanceMetadataItemsAsync(UpdateInstanceMetadataItemsRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::UpdateInstanceMetadataItemsRequest request = new gcnv::UpdateInstanceMetadataItemsRequest
            {
                Name = "",
                Items = { { "", "" }, },
            };
            // Make the request
            gcnv::UpdateInstanceMetadataItemsResponse response = await notebookServiceClient.UpdateInstanceMetadataItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::DeleteInstanceRequest request = new gcnv::DeleteInstanceRequest { Name = "", };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteInstance(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::DeleteInstanceRequest request = new gcnv::DeleteInstanceRequest { Name = "", };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteInstanceAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteInstance(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteInstanceAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::StartInstanceRequest request = new gcnv::StartInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.StartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartInstanceAsync</summary>
        public async Task StartInstanceRequestObjectAsync()
        {
            // Snippet: StartInstanceAsync(StartInstanceRequest, CallSettings)
            // Additional: StartInstanceAsync(StartInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::StartInstanceRequest request = new gcnv::StartInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.StartInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstance</summary>
        public void StopInstanceRequestObject()
        {
            // Snippet: StopInstance(StopInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::StopInstanceRequest request = new gcnv::StopInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.StopInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceStopInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopInstanceAsync</summary>
        public async Task StopInstanceRequestObjectAsync()
        {
            // Snippet: StopInstanceAsync(StopInstanceRequest, CallSettings)
            // Additional: StopInstanceAsync(StopInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::StopInstanceRequest request = new gcnv::StopInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.StopInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceStopInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstance</summary>
        public void ResetInstanceRequestObject()
        {
            // Snippet: ResetInstance(ResetInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ResetInstanceRequest request = new gcnv::ResetInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.ResetInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceResetInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetInstanceAsync</summary>
        public async Task ResetInstanceRequestObjectAsync()
        {
            // Snippet: ResetInstanceAsync(ResetInstanceRequest, CallSettings)
            // Additional: ResetInstanceAsync(ResetInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ResetInstanceRequest request = new gcnv::ResetInstanceRequest { Name = "", };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.ResetInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceResetInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportInstanceInfo</summary>
        public void ReportInstanceInfoRequestObject()
        {
            // Snippet: ReportInstanceInfo(ReportInstanceInfoRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ReportInstanceInfoRequest request = new gcnv::ReportInstanceInfoRequest
            {
                Name = "",
                VmId = "",
                Metadata = { { "", "" }, },
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.ReportInstanceInfo(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceReportInstanceInfo(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportInstanceInfoAsync</summary>
        public async Task ReportInstanceInfoRequestObjectAsync()
        {
            // Snippet: ReportInstanceInfoAsync(ReportInstanceInfoRequest, CallSettings)
            // Additional: ReportInstanceInfoAsync(ReportInstanceInfoRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ReportInstanceInfoRequest request = new gcnv::ReportInstanceInfoRequest
            {
                Name = "",
                VmId = "",
                Metadata = { { "", "" }, },
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.ReportInstanceInfoAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceReportInstanceInfoAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IsInstanceUpgradeable</summary>
        public void IsInstanceUpgradeableRequestObject()
        {
            // Snippet: IsInstanceUpgradeable(IsInstanceUpgradeableRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::IsInstanceUpgradeableRequest request = new gcnv::IsInstanceUpgradeableRequest
            {
                NotebookInstance = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            gcnv::IsInstanceUpgradeableResponse response = notebookServiceClient.IsInstanceUpgradeable(request);
            // End snippet
        }

        /// <summary>Snippet for IsInstanceUpgradeableAsync</summary>
        public async Task IsInstanceUpgradeableRequestObjectAsync()
        {
            // Snippet: IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest, CallSettings)
            // Additional: IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::IsInstanceUpgradeableRequest request = new gcnv::IsInstanceUpgradeableRequest
            {
                NotebookInstance = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            gcnv::IsInstanceUpgradeableResponse response = await notebookServiceClient.IsInstanceUpgradeableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealthRequestObject()
        {
            // Snippet: GetInstanceHealth(GetInstanceHealthRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::GetInstanceHealthRequest request = new gcnv::GetInstanceHealthRequest
            {
                InstanceName = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            gcnv::GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthRequestObjectAsync()
        {
            // Snippet: GetInstanceHealthAsync(GetInstanceHealthRequest, CallSettings)
            // Additional: GetInstanceHealthAsync(GetInstanceHealthRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::GetInstanceHealthRequest request = new gcnv::GetInstanceHealthRequest
            {
                InstanceName = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            gcnv::GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealth()
        {
            // Snippet: GetInstanceHealth(string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            gcnv::GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthAsync()
        {
            // Snippet: GetInstanceHealthAsync(string, CallSettings)
            // Additional: GetInstanceHealthAsync(string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            gcnv::GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealth</summary>
        public void GetInstanceHealthResourceNames()
        {
            // Snippet: GetInstanceHealth(InstanceName, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::InstanceName name = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            gcnv::GetInstanceHealthResponse response = notebookServiceClient.GetInstanceHealth(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceHealthAsync</summary>
        public async Task GetInstanceHealthResourceNamesAsync()
        {
            // Snippet: GetInstanceHealthAsync(InstanceName, CallSettings)
            // Additional: GetInstanceHealthAsync(InstanceName, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::InstanceName name = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            gcnv::GetInstanceHealthResponse response = await notebookServiceClient.GetInstanceHealthAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstanceRequestObject()
        {
            // Snippet: UpgradeInstance(UpgradeInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpgradeInstanceRequest request = new gcnv::UpgradeInstanceRequest
            {
                Name = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpgradeInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceAsync</summary>
        public async Task UpgradeInstanceRequestObjectAsync()
        {
            // Snippet: UpgradeInstanceAsync(UpgradeInstanceRequest, CallSettings)
            // Additional: UpgradeInstanceAsync(UpgradeInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::UpgradeInstanceRequest request = new gcnv::UpgradeInstanceRequest
            {
                Name = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpgradeInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackInstance</summary>
        public void RollbackInstanceRequestObject()
        {
            // Snippet: RollbackInstance(RollbackInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::RollbackInstanceRequest request = new gcnv::RollbackInstanceRequest
            {
                Name = "",
                TargetSnapshot = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.RollbackInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceRollbackInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackInstanceAsync</summary>
        public async Task RollbackInstanceRequestObjectAsync()
        {
            // Snippet: RollbackInstanceAsync(RollbackInstanceRequest, CallSettings)
            // Additional: RollbackInstanceAsync(RollbackInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::RollbackInstanceRequest request = new gcnv::RollbackInstanceRequest
            {
                Name = "",
                TargetSnapshot = "",
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.RollbackInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceRollbackInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstance</summary>
        public void DiagnoseInstanceRequestObject()
        {
            // Snippet: DiagnoseInstance(DiagnoseInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::DiagnoseInstanceRequest request = new gcnv::DiagnoseInstanceRequest
            {
                InstanceName = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DiagnosticConfig = new gcnv::DiagnosticConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.DiagnoseInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDiagnoseInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstanceAsync</summary>
        public async Task DiagnoseInstanceRequestObjectAsync()
        {
            // Snippet: DiagnoseInstanceAsync(DiagnoseInstanceRequest, CallSettings)
            // Additional: DiagnoseInstanceAsync(DiagnoseInstanceRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::DiagnoseInstanceRequest request = new gcnv::DiagnoseInstanceRequest
            {
                InstanceName = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DiagnosticConfig = new gcnv::DiagnosticConfig(),
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.DiagnoseInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDiagnoseInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstance</summary>
        public void DiagnoseInstance()
        {
            // Snippet: DiagnoseInstance(string, DiagnosticConfig, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            gcnv::DiagnosticConfig diagnosticConfig = new gcnv::DiagnosticConfig();
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.DiagnoseInstance(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDiagnoseInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstanceAsync</summary>
        public async Task DiagnoseInstanceAsync()
        {
            // Snippet: DiagnoseInstanceAsync(string, DiagnosticConfig, CallSettings)
            // Additional: DiagnoseInstanceAsync(string, DiagnosticConfig, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            gcnv::DiagnosticConfig diagnosticConfig = new gcnv::DiagnosticConfig();
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.DiagnoseInstanceAsync(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDiagnoseInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstance</summary>
        public void DiagnoseInstanceResourceNames()
        {
            // Snippet: DiagnoseInstance(InstanceName, DiagnosticConfig, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::InstanceName name = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            gcnv::DiagnosticConfig diagnosticConfig = new gcnv::DiagnosticConfig();
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.DiagnoseInstance(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDiagnoseInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInstanceAsync</summary>
        public async Task DiagnoseInstanceResourceNamesAsync()
        {
            // Snippet: DiagnoseInstanceAsync(InstanceName, DiagnosticConfig, CallSettings)
            // Additional: DiagnoseInstanceAsync(InstanceName, DiagnosticConfig, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::InstanceName name = gcnv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            gcnv::DiagnosticConfig diagnosticConfig = new gcnv::DiagnosticConfig();
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.DiagnoseInstanceAsync(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDiagnoseInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceInternal</summary>
        public void UpgradeInstanceInternalRequestObject()
        {
            // Snippet: UpgradeInstanceInternal(UpgradeInstanceInternalRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpgradeInstanceInternalRequest request = new gcnv::UpgradeInstanceInternalRequest
            {
                Name = "",
                VmId = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpgradeInstanceInternal(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstanceInternal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstanceInternalAsync</summary>
        public async Task UpgradeInstanceInternalRequestObjectAsync()
        {
            // Snippet: UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest, CallSettings)
            // Additional: UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::UpgradeInstanceInternalRequest request = new gcnv::UpgradeInstanceInternalRequest
            {
                Name = "",
                VmId = "",
                Type = gcnv::UpgradeType.Unspecified,
            };
            // Make the request
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpgradeInstanceInternalAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceInternalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ListEnvironmentsRequest request = new gcnv::ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<gcnv::ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListEnvironmentsResponse page in response.AsRawResponses())
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ListEnvironmentsRequest request = new gcnv::ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<gcnv::ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListEnvironmentsResponse page) =>
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcnv::ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListEnvironmentsResponse page in response.AsRawResponses())
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcnv::ListEnvironmentsResponse, gcnv::Environment> response = notebookServiceClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListEnvironmentsResponse page) =>
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::GetEnvironmentRequest request = new gcnv::GetEnvironmentRequest { Name = "", };
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::GetEnvironmentRequest request = new gcnv::GetEnvironmentRequest { Name = "", };
            // Make the request
            gcnv::Environment response = await notebookServiceClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::CreateEnvironmentRequest request = new gcnv::CreateEnvironmentRequest
            {
                Parent = "",
                EnvironmentId = "",
                Environment = new gcnv::Environment(),
            };
            // Make the request
            Operation<gcnv::Environment, gcnv::OperationMetadata> response = notebookServiceClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateEnvironment(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::CreateEnvironmentRequest request = new gcnv::CreateEnvironmentRequest
            {
                Parent = "",
                EnvironmentId = "",
                Environment = new gcnv::Environment(),
            };
            // Make the request
            Operation<gcnv::Environment, gcnv::OperationMetadata> response = await notebookServiceClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateEnvironmentAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Environment environment = new gcnv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcnv::Environment, gcnv::OperationMetadata> response = notebookServiceClient.CreateEnvironment(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateEnvironment(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcnv::Environment environment = new gcnv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcnv::Environment, gcnv::OperationMetadata> response = await notebookServiceClient.CreateEnvironmentAsync(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Environment, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Environment, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateEnvironmentAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::DeleteEnvironmentRequest request = new gcnv::DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteEnvironment(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::DeleteEnvironmentRequest request = new gcnv::DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteEnvironment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteEnvironment(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteEnvironmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ListSchedulesRequest request = new gcnv::ListSchedulesRequest
            {
                ParentAsScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ListSchedulesRequest request = new gcnv::ListSchedulesRequest
            {
                ParentAsScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            PagedEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            PagedAsyncEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ScheduleName parent = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            PagedEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Schedule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListSchedulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ScheduleName parent = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            PagedAsyncEnumerable<gcnv::ListSchedulesResponse, gcnv::Schedule> response = notebookServiceClient.ListSchedulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Schedule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListSchedulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Schedule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Schedule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Schedule item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::GetScheduleRequest request = new gcnv::GetScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            gcnv::Schedule response = notebookServiceClient.GetSchedule(request);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleRequestObjectAsync()
        {
            // Snippet: GetScheduleAsync(GetScheduleRequest, CallSettings)
            // Additional: GetScheduleAsync(GetScheduleRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::GetScheduleRequest request = new gcnv::GetScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            gcnv::Schedule response = await notebookServiceClient.GetScheduleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetSchedule()
        {
            // Snippet: GetSchedule(string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            gcnv::Schedule response = notebookServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleAsync()
        {
            // Snippet: GetScheduleAsync(string, CallSettings)
            // Additional: GetScheduleAsync(string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            gcnv::Schedule response = await notebookServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSchedule</summary>
        public void GetScheduleResourceNames()
        {
            // Snippet: GetSchedule(ScheduleName, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ScheduleName name = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            gcnv::Schedule response = notebookServiceClient.GetSchedule(name);
            // End snippet
        }

        /// <summary>Snippet for GetScheduleAsync</summary>
        public async Task GetScheduleResourceNamesAsync()
        {
            // Snippet: GetScheduleAsync(ScheduleName, CallSettings)
            // Additional: GetScheduleAsync(ScheduleName, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ScheduleName name = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            gcnv::Schedule response = await notebookServiceClient.GetScheduleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSchedule</summary>
        public void DeleteScheduleRequestObject()
        {
            // Snippet: DeleteSchedule(DeleteScheduleRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::DeleteScheduleRequest request = new gcnv::DeleteScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::DeleteScheduleRequest request = new gcnv::DeleteScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ScheduleName name = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteSchedule(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteSchedule(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ScheduleName name = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteScheduleAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteScheduleAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::CreateScheduleRequest request = new gcnv::CreateScheduleRequest
            {
                ParentAsScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                ScheduleId = "",
                Schedule = new gcnv::Schedule(),
            };
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = notebookServiceClient.CreateSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleRequestObjectAsync()
        {
            // Snippet: CreateScheduleAsync(CreateScheduleRequest, CallSettings)
            // Additional: CreateScheduleAsync(CreateScheduleRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::CreateScheduleRequest request = new gcnv::CreateScheduleRequest
            {
                ParentAsScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
                ScheduleId = "",
                Schedule = new gcnv::Schedule(),
            };
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateSchedule()
        {
            // Snippet: CreateSchedule(string, Schedule, string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            gcnv::Schedule schedule = new gcnv::Schedule();
            string scheduleId = "";
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = notebookServiceClient.CreateSchedule(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleAsync()
        {
            // Snippet: CreateScheduleAsync(string, Schedule, string, CallSettings)
            // Additional: CreateScheduleAsync(string, Schedule, string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/schedules/[SCHEDULE]";
            gcnv::Schedule schedule = new gcnv::Schedule();
            string scheduleId = "";
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSchedule</summary>
        public void CreateScheduleResourceNames()
        {
            // Snippet: CreateSchedule(ScheduleName, Schedule, string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ScheduleName parent = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            gcnv::Schedule schedule = new gcnv::Schedule();
            string scheduleId = "";
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = notebookServiceClient.CreateSchedule(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScheduleAsync</summary>
        public async Task CreateScheduleResourceNamesAsync()
        {
            // Snippet: CreateScheduleAsync(ScheduleName, Schedule, string, CallSettings)
            // Additional: CreateScheduleAsync(ScheduleName, Schedule, string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ScheduleName parent = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]");
            gcnv::Schedule schedule = new gcnv::Schedule();
            string scheduleId = "";
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = await notebookServiceClient.CreateScheduleAsync(parent, schedule, scheduleId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerSchedule</summary>
        public void TriggerScheduleRequestObject()
        {
            // Snippet: TriggerSchedule(TriggerScheduleRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::TriggerScheduleRequest request = new gcnv::TriggerScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = notebookServiceClient.TriggerSchedule(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceTriggerSchedule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerScheduleAsync</summary>
        public async Task TriggerScheduleRequestObjectAsync()
        {
            // Snippet: TriggerScheduleAsync(TriggerScheduleRequest, CallSettings)
            // Additional: TriggerScheduleAsync(TriggerScheduleRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::TriggerScheduleRequest request = new gcnv::TriggerScheduleRequest
            {
                ScheduleName = gcnv::ScheduleName.FromProjectLocationSchedule("[PROJECT]", "[LOCATION]", "[SCHEDULE]"),
            };
            // Make the request
            Operation<gcnv::Schedule, gcnv::OperationMetadata> response = await notebookServiceClient.TriggerScheduleAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Schedule, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Schedule result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Schedule, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceTriggerScheduleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Schedule retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ListExecutionsRequest request = new gcnv::ListExecutionsRequest
            {
                ParentAsExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ListExecutionsRequest request = new gcnv::ListExecutionsRequest
            {
                ParentAsExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            PagedEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            PagedAsyncEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ExecutionName parent = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            PagedEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcnv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcnv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ExecutionName parent = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            PagedAsyncEnumerable<gcnv::ListExecutionsResponse, gcnv::Execution> response = notebookServiceClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcnv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcnv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcnv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcnv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcnv::Execution item in singlePage)
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::GetExecutionRequest request = new gcnv::GetExecutionRequest
            {
                ExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            gcnv::Execution response = notebookServiceClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::GetExecutionRequest request = new gcnv::GetExecutionRequest
            {
                ExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            gcnv::Execution response = await notebookServiceClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            gcnv::Execution response = notebookServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            gcnv::Execution response = await notebookServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ExecutionName name = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            gcnv::Execution response = notebookServiceClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ExecutionName name = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            gcnv::Execution response = await notebookServiceClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionRequestObject()
        {
            // Snippet: DeleteExecution(DeleteExecutionRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::DeleteExecutionRequest request = new gcnv::DeleteExecutionRequest
            {
                ExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::DeleteExecutionRequest request = new gcnv::DeleteExecutionRequest
            {
                ExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
            };
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ExecutionName name = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = notebookServiceClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceDeleteExecution(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ExecutionName name = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            // Make the request
            Operation<Empty, gcnv::OperationMetadata> response = await notebookServiceClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceDeleteExecutionAsync(operationName);
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
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::CreateExecutionRequest request = new gcnv::CreateExecutionRequest
            {
                ParentAsExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                ExecutionId = "",
                Execution = new gcnv::Execution(),
            };
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = notebookServiceClient.CreateExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionRequestObjectAsync()
        {
            // Snippet: CreateExecutionAsync(CreateExecutionRequest, CallSettings)
            // Additional: CreateExecutionAsync(CreateExecutionRequest, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::CreateExecutionRequest request = new gcnv::CreateExecutionRequest
            {
                ParentAsExecutionName = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]"),
                ExecutionId = "",
                Execution = new gcnv::Execution(),
            };
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecution()
        {
            // Snippet: CreateExecution(string, Execution, string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            gcnv::Execution execution = new gcnv::Execution();
            string executionId = "";
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = notebookServiceClient.CreateExecution(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionAsync()
        {
            // Snippet: CreateExecutionAsync(string, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(string, Execution, string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/location/[LOCATION]/executions/[EXECUTION]";
            gcnv::Execution execution = new gcnv::Execution();
            string executionId = "";
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionResourceNames()
        {
            // Snippet: CreateExecution(ExecutionName, Execution, string, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::ExecutionName parent = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            gcnv::Execution execution = new gcnv::Execution();
            string executionId = "";
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = notebookServiceClient.CreateExecution(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceCreateExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionResourceNamesAsync()
        {
            // Snippet: CreateExecutionAsync(ExecutionName, Execution, string, CallSettings)
            // Additional: CreateExecutionAsync(ExecutionName, Execution, string, CancellationToken)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = await gcnv::NotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcnv::ExecutionName parent = gcnv::ExecutionName.FromProjectLocationExecution("[PROJECT]", "[LOCATION]", "[EXECUTION]");
            gcnv::Execution execution = new gcnv::Execution();
            string executionId = "";
            // Make the request
            Operation<gcnv::Execution, gcnv::OperationMetadata> response = await notebookServiceClient.CreateExecutionAsync(parent, execution, executionId);

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Execution, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcnv::Execution, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceCreateExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcnv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
