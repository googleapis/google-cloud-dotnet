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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExampleStoreServiceClientSnippets
    {
        /// <summary>Snippet for CreateExampleStore</summary>
        public void CreateExampleStoreRequestObject()
        {
            // Snippet: CreateExampleStore(CreateExampleStoreRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            CreateExampleStoreRequest request = new CreateExampleStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExampleStore = new ExampleStore(),
            };
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = exampleStoreServiceClient.CreateExampleStore(request);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceCreateExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExampleStoreAsync</summary>
        public async Task CreateExampleStoreRequestObjectAsync()
        {
            // Snippet: CreateExampleStoreAsync(CreateExampleStoreRequest, CallSettings)
            // Additional: CreateExampleStoreAsync(CreateExampleStoreRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExampleStoreRequest request = new CreateExampleStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExampleStore = new ExampleStore(),
            };
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = await exampleStoreServiceClient.CreateExampleStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceCreateExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExampleStore</summary>
        public void CreateExampleStore()
        {
            // Snippet: CreateExampleStore(string, ExampleStore, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExampleStore exampleStore = new ExampleStore();
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = exampleStoreServiceClient.CreateExampleStore(parent, exampleStore);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceCreateExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExampleStoreAsync</summary>
        public async Task CreateExampleStoreAsync()
        {
            // Snippet: CreateExampleStoreAsync(string, ExampleStore, CallSettings)
            // Additional: CreateExampleStoreAsync(string, ExampleStore, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExampleStore exampleStore = new ExampleStore();
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = await exampleStoreServiceClient.CreateExampleStoreAsync(parent, exampleStore);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceCreateExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExampleStore</summary>
        public void CreateExampleStoreResourceNames()
        {
            // Snippet: CreateExampleStore(LocationName, ExampleStore, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExampleStore exampleStore = new ExampleStore();
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = exampleStoreServiceClient.CreateExampleStore(parent, exampleStore);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceCreateExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExampleStoreAsync</summary>
        public async Task CreateExampleStoreResourceNamesAsync()
        {
            // Snippet: CreateExampleStoreAsync(LocationName, ExampleStore, CallSettings)
            // Additional: CreateExampleStoreAsync(LocationName, ExampleStore, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExampleStore exampleStore = new ExampleStore();
            // Make the request
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> response = await exampleStoreServiceClient.CreateExampleStoreAsync(parent, exampleStore);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, CreateExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceCreateExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetExampleStore</summary>
        public void GetExampleStoreRequestObject()
        {
            // Snippet: GetExampleStore(GetExampleStoreRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            GetExampleStoreRequest request = new GetExampleStoreRequest
            {
                ExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
            };
            // Make the request
            ExampleStore response = exampleStoreServiceClient.GetExampleStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetExampleStoreAsync</summary>
        public async Task GetExampleStoreRequestObjectAsync()
        {
            // Snippet: GetExampleStoreAsync(GetExampleStoreRequest, CallSettings)
            // Additional: GetExampleStoreAsync(GetExampleStoreRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExampleStoreRequest request = new GetExampleStoreRequest
            {
                ExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
            };
            // Make the request
            ExampleStore response = await exampleStoreServiceClient.GetExampleStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExampleStore</summary>
        public void GetExampleStore()
        {
            // Snippet: GetExampleStore(string, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exampleStores/[EXAMPLE_STORE]";
            // Make the request
            ExampleStore response = exampleStoreServiceClient.GetExampleStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleStoreAsync</summary>
        public async Task GetExampleStoreAsync()
        {
            // Snippet: GetExampleStoreAsync(string, CallSettings)
            // Additional: GetExampleStoreAsync(string, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exampleStores/[EXAMPLE_STORE]";
            // Make the request
            ExampleStore response = await exampleStoreServiceClient.GetExampleStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleStore</summary>
        public void GetExampleStoreResourceNames()
        {
            // Snippet: GetExampleStore(ExampleStoreName, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            ExampleStoreName name = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]");
            // Make the request
            ExampleStore response = exampleStoreServiceClient.GetExampleStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetExampleStoreAsync</summary>
        public async Task GetExampleStoreResourceNamesAsync()
        {
            // Snippet: GetExampleStoreAsync(ExampleStoreName, CallSettings)
            // Additional: GetExampleStoreAsync(ExampleStoreName, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleStoreName name = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]");
            // Make the request
            ExampleStore response = await exampleStoreServiceClient.GetExampleStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleStore</summary>
        public void UpdateExampleStoreRequestObject()
        {
            // Snippet: UpdateExampleStore(UpdateExampleStoreRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            UpdateExampleStoreRequest request = new UpdateExampleStoreRequest
            {
                ExampleStore = new ExampleStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> response = exampleStoreServiceClient.UpdateExampleStore(request);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceUpdateExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleStoreAsync</summary>
        public async Task UpdateExampleStoreRequestObjectAsync()
        {
            // Snippet: UpdateExampleStoreAsync(UpdateExampleStoreRequest, CallSettings)
            // Additional: UpdateExampleStoreAsync(UpdateExampleStoreRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExampleStoreRequest request = new UpdateExampleStoreRequest
            {
                ExampleStore = new ExampleStore(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> response = await exampleStoreServiceClient.UpdateExampleStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceUpdateExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleStore</summary>
        public void UpdateExampleStore()
        {
            // Snippet: UpdateExampleStore(ExampleStore, FieldMask, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            ExampleStore exampleStore = new ExampleStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> response = exampleStoreServiceClient.UpdateExampleStore(exampleStore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceUpdateExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExampleStoreAsync</summary>
        public async Task UpdateExampleStoreAsync()
        {
            // Snippet: UpdateExampleStoreAsync(ExampleStore, FieldMask, CallSettings)
            // Additional: UpdateExampleStoreAsync(ExampleStore, FieldMask, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleStore exampleStore = new ExampleStore();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> response = await exampleStoreServiceClient.UpdateExampleStoreAsync(exampleStore, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExampleStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExampleStore, UpdateExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceUpdateExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExampleStore retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStore</summary>
        public void DeleteExampleStoreRequestObject()
        {
            // Snippet: DeleteExampleStore(DeleteExampleStoreRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteExampleStoreRequest request = new DeleteExampleStoreRequest
            {
                ExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = exampleStoreServiceClient.DeleteExampleStore(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceDeleteExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStoreAsync</summary>
        public async Task DeleteExampleStoreRequestObjectAsync()
        {
            // Snippet: DeleteExampleStoreAsync(DeleteExampleStoreRequest, CallSettings)
            // Additional: DeleteExampleStoreAsync(DeleteExampleStoreRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExampleStoreRequest request = new DeleteExampleStoreRequest
            {
                ExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
            };
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = await exampleStoreServiceClient.DeleteExampleStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceDeleteExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStore</summary>
        public void DeleteExampleStore()
        {
            // Snippet: DeleteExampleStore(string, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exampleStores/[EXAMPLE_STORE]";
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = exampleStoreServiceClient.DeleteExampleStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceDeleteExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStoreAsync</summary>
        public async Task DeleteExampleStoreAsync()
        {
            // Snippet: DeleteExampleStoreAsync(string, CallSettings)
            // Additional: DeleteExampleStoreAsync(string, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exampleStores/[EXAMPLE_STORE]";
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = await exampleStoreServiceClient.DeleteExampleStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceDeleteExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStore</summary>
        public void DeleteExampleStoreResourceNames()
        {
            // Snippet: DeleteExampleStore(ExampleStoreName, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            ExampleStoreName name = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]");
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = exampleStoreServiceClient.DeleteExampleStore(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = exampleStoreServiceClient.PollOnceDeleteExampleStore(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExampleStoreAsync</summary>
        public async Task DeleteExampleStoreResourceNamesAsync()
        {
            // Snippet: DeleteExampleStoreAsync(ExampleStoreName, CallSettings)
            // Additional: DeleteExampleStoreAsync(ExampleStoreName, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExampleStoreName name = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]");
            // Make the request
            Operation<Empty, DeleteExampleStoreOperationMetadata> response = await exampleStoreServiceClient.DeleteExampleStoreAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteExampleStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteExampleStoreOperationMetadata> retrievedResponse = await exampleStoreServiceClient.PollOnceDeleteExampleStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExampleStores</summary>
        public void ListExampleStoresRequestObject()
        {
            // Snippet: ListExampleStores(ListExampleStoresRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            ListExampleStoresRequest request = new ListExampleStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExampleStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExampleStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExampleStoresAsync</summary>
        public async Task ListExampleStoresRequestObjectAsync()
        {
            // Snippet: ListExampleStoresAsync(ListExampleStoresRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExampleStoresRequest request = new ListExampleStoresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExampleStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExampleStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExampleStores</summary>
        public void ListExampleStores()
        {
            // Snippet: ListExampleStores(string, string, int?, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExampleStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExampleStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExampleStoresAsync</summary>
        public async Task ListExampleStoresAsync()
        {
            // Snippet: ListExampleStoresAsync(string, string, int?, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExampleStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExampleStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExampleStores</summary>
        public void ListExampleStoresResourceNames()
        {
            // Snippet: ListExampleStores(LocationName, string, int?, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExampleStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExampleStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExampleStoresAsync</summary>
        public async Task ListExampleStoresResourceNamesAsync()
        {
            // Snippet: ListExampleStoresAsync(LocationName, string, int?, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListExampleStoresResponse, ExampleStore> response = exampleStoreServiceClient.ListExampleStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExampleStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExampleStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExampleStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExampleStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExampleStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpsertExamples</summary>
        public void UpsertExamplesRequestObject()
        {
            // Snippet: UpsertExamples(UpsertExamplesRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            UpsertExamplesRequest request = new UpsertExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                Examples = { new Example(), },
                Overwrite = false,
            };
            // Make the request
            UpsertExamplesResponse response = exampleStoreServiceClient.UpsertExamples(request);
            // End snippet
        }

        /// <summary>Snippet for UpsertExamplesAsync</summary>
        public async Task UpsertExamplesRequestObjectAsync()
        {
            // Snippet: UpsertExamplesAsync(UpsertExamplesRequest, CallSettings)
            // Additional: UpsertExamplesAsync(UpsertExamplesRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpsertExamplesRequest request = new UpsertExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                Examples = { new Example(), },
                Overwrite = false,
            };
            // Make the request
            UpsertExamplesResponse response = await exampleStoreServiceClient.UpsertExamplesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveExamples</summary>
        public void RemoveExamplesRequestObject()
        {
            // Snippet: RemoveExamples(RemoveExamplesRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            RemoveExamplesRequest request = new RemoveExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                ExampleIds = { "", },
                StoredContentsExampleFilter = new StoredContentsExampleFilter(),
            };
            // Make the request
            RemoveExamplesResponse response = exampleStoreServiceClient.RemoveExamples(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveExamplesAsync</summary>
        public async Task RemoveExamplesRequestObjectAsync()
        {
            // Snippet: RemoveExamplesAsync(RemoveExamplesRequest, CallSettings)
            // Additional: RemoveExamplesAsync(RemoveExamplesRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveExamplesRequest request = new RemoveExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                ExampleIds = { "", },
                StoredContentsExampleFilter = new StoredContentsExampleFilter(),
            };
            // Make the request
            RemoveExamplesResponse response = await exampleStoreServiceClient.RemoveExamplesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchExamples</summary>
        public void SearchExamplesRequestObject()
        {
            // Snippet: SearchExamples(SearchExamplesRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            SearchExamplesRequest request = new SearchExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                TopK = 0L,
                StoredContentsExampleParameters = new StoredContentsExampleParameters(),
            };
            // Make the request
            SearchExamplesResponse response = exampleStoreServiceClient.SearchExamples(request);
            // End snippet
        }

        /// <summary>Snippet for SearchExamplesAsync</summary>
        public async Task SearchExamplesRequestObjectAsync()
        {
            // Snippet: SearchExamplesAsync(SearchExamplesRequest, CallSettings)
            // Additional: SearchExamplesAsync(SearchExamplesRequest, CancellationToken)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchExamplesRequest request = new SearchExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                TopK = 0L,
                StoredContentsExampleParameters = new StoredContentsExampleParameters(),
            };
            // Make the request
            SearchExamplesResponse response = await exampleStoreServiceClient.SearchExamplesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchExamples</summary>
        public void FetchExamplesRequestObject()
        {
            // Snippet: FetchExamples(FetchExamplesRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = ExampleStoreServiceClient.Create();
            // Initialize request argument(s)
            FetchExamplesRequest request = new FetchExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                ExampleIds = { "", },
                StoredContentsExampleFilter = new StoredContentsExampleFilter(),
            };
            // Make the request
            PagedEnumerable<FetchExamplesResponse, Example> response = exampleStoreServiceClient.FetchExamples(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Example item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchExamplesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchExamplesAsync</summary>
        public async Task FetchExamplesRequestObjectAsync()
        {
            // Snippet: FetchExamplesAsync(FetchExamplesRequest, CallSettings)
            // Create client
            ExampleStoreServiceClient exampleStoreServiceClient = await ExampleStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchExamplesRequest request = new FetchExamplesRequest
            {
                ExampleStoreAsExampleStoreName = ExampleStoreName.FromProjectLocationExampleStore("[PROJECT]", "[LOCATION]", "[EXAMPLE_STORE]"),
                ExampleIds = { "", },
                StoredContentsExampleFilter = new StoredContentsExampleFilter(),
            };
            // Make the request
            PagedAsyncEnumerable<FetchExamplesResponse, Example> response = exampleStoreServiceClient.FetchExamplesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Example item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchExamplesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Example item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Example> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Example item in singlePage)
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
