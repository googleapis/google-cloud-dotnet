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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcnv = Google.Cloud.Notebooks.V1Beta1;

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
            };
            // Make the request
#pragma warning disable CS0612
            gcnv::IsInstanceUpgradeableResponse response = notebookServiceClient.IsInstanceUpgradeable(request);
#pragma warning restore CS0612
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
            };
            // Make the request
#pragma warning disable CS0612
            gcnv::IsInstanceUpgradeableResponse response = await notebookServiceClient.IsInstanceUpgradeableAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpgradeInstance</summary>
        public void UpgradeInstanceRequestObject()
        {
            // Snippet: UpgradeInstance(UpgradeInstanceRequest, CallSettings)
            // Create client
            gcnv::NotebookServiceClient notebookServiceClient = gcnv::NotebookServiceClient.Create();
            // Initialize request argument(s)
            gcnv::UpgradeInstanceRequest request = new gcnv::UpgradeInstanceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpgradeInstance(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstance(operationName);
#pragma warning restore CS0612
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
            gcnv::UpgradeInstanceRequest request = new gcnv::UpgradeInstanceRequest { Name = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpgradeInstanceAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceAsync(operationName);
#pragma warning restore CS0612
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
            gcnv::UpgradeInstanceInternalRequest request = new gcnv::UpgradeInstanceInternalRequest { Name = "", VmId = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = notebookServiceClient.UpgradeInstanceInternal(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = notebookServiceClient.PollOnceUpgradeInstanceInternal(operationName);
#pragma warning restore CS0612
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
            gcnv::UpgradeInstanceInternalRequest request = new gcnv::UpgradeInstanceInternalRequest { Name = "", VmId = "", };
            // Make the request
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> response = await notebookServiceClient.UpgradeInstanceInternalAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<gcnv::Instance, gcnv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcnv::Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<gcnv::Instance, gcnv::OperationMetadata> retrievedResponse = await notebookServiceClient.PollOnceUpgradeInstanceInternalAsync(operationName);
#pragma warning restore CS0612
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
    }
}
