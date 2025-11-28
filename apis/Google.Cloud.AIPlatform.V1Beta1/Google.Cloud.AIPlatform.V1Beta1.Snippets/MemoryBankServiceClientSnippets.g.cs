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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMemoryBankServiceClientSnippets
    {
        /// <summary>Snippet for CreateMemory</summary>
        public void CreateMemoryRequestObject()
        {
            // Snippet: CreateMemory(CreateMemoryRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            CreateMemoryRequest request = new CreateMemoryRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Memory = new Memory(),
            };
            // Make the request
            Operation<Memory, CreateMemoryOperationMetadata> response = memoryBankServiceClient.CreateMemory(request);

            // Poll until the returned long-running operation is complete
            Operation<Memory, CreateMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, CreateMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceCreateMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMemoryAsync</summary>
        public async Task CreateMemoryRequestObjectAsync()
        {
            // Snippet: CreateMemoryAsync(CreateMemoryRequest, CallSettings)
            // Additional: CreateMemoryAsync(CreateMemoryRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMemoryRequest request = new CreateMemoryRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Memory = new Memory(),
            };
            // Make the request
            Operation<Memory, CreateMemoryOperationMetadata> response = await memoryBankServiceClient.CreateMemoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Memory, CreateMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, CreateMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceCreateMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetMemory</summary>
        public void GetMemoryRequestObject()
        {
            // Snippet: GetMemory(GetMemoryRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            GetMemoryRequest request = new GetMemoryRequest
            {
                MemoryName = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]"),
            };
            // Make the request
            Memory response = memoryBankServiceClient.GetMemory(request);
            // End snippet
        }

        /// <summary>Snippet for GetMemoryAsync</summary>
        public async Task GetMemoryRequestObjectAsync()
        {
            // Snippet: GetMemoryAsync(GetMemoryRequest, CallSettings)
            // Additional: GetMemoryAsync(GetMemoryRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMemoryRequest request = new GetMemoryRequest
            {
                MemoryName = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]"),
            };
            // Make the request
            Memory response = await memoryBankServiceClient.GetMemoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMemory</summary>
        public void GetMemory()
        {
            // Snippet: GetMemory(string, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/memories/[MEMORY]";
            // Make the request
            Memory response = memoryBankServiceClient.GetMemory(name);
            // End snippet
        }

        /// <summary>Snippet for GetMemoryAsync</summary>
        public async Task GetMemoryAsync()
        {
            // Snippet: GetMemoryAsync(string, CallSettings)
            // Additional: GetMemoryAsync(string, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/memories/[MEMORY]";
            // Make the request
            Memory response = await memoryBankServiceClient.GetMemoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMemory</summary>
        public void GetMemoryResourceNames()
        {
            // Snippet: GetMemory(MemoryName, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            MemoryName name = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]");
            // Make the request
            Memory response = memoryBankServiceClient.GetMemory(name);
            // End snippet
        }

        /// <summary>Snippet for GetMemoryAsync</summary>
        public async Task GetMemoryResourceNamesAsync()
        {
            // Snippet: GetMemoryAsync(MemoryName, CallSettings)
            // Additional: GetMemoryAsync(MemoryName, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            MemoryName name = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]");
            // Make the request
            Memory response = await memoryBankServiceClient.GetMemoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateMemory</summary>
        public void UpdateMemoryRequestObject()
        {
            // Snippet: UpdateMemory(UpdateMemoryRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            UpdateMemoryRequest request = new UpdateMemoryRequest
            {
                Memory = new Memory(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Memory, UpdateMemoryOperationMetadata> response = memoryBankServiceClient.UpdateMemory(request);

            // Poll until the returned long-running operation is complete
            Operation<Memory, UpdateMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, UpdateMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceUpdateMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMemoryAsync</summary>
        public async Task UpdateMemoryRequestObjectAsync()
        {
            // Snippet: UpdateMemoryAsync(UpdateMemoryRequest, CallSettings)
            // Additional: UpdateMemoryAsync(UpdateMemoryRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMemoryRequest request = new UpdateMemoryRequest
            {
                Memory = new Memory(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Memory, UpdateMemoryOperationMetadata> response = await memoryBankServiceClient.UpdateMemoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Memory, UpdateMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, UpdateMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceUpdateMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMemory</summary>
        public void UpdateMemory()
        {
            // Snippet: UpdateMemory(Memory, FieldMask, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            Memory memory = new Memory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Memory, UpdateMemoryOperationMetadata> response = memoryBankServiceClient.UpdateMemory(memory, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Memory, UpdateMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, UpdateMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceUpdateMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMemoryAsync</summary>
        public async Task UpdateMemoryAsync()
        {
            // Snippet: UpdateMemoryAsync(Memory, FieldMask, CallSettings)
            // Additional: UpdateMemoryAsync(Memory, FieldMask, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            Memory memory = new Memory();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Memory, UpdateMemoryOperationMetadata> response = await memoryBankServiceClient.UpdateMemoryAsync(memory, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Memory, UpdateMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Memory result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Memory, UpdateMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceUpdateMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Memory retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMemories</summary>
        public void ListMemoriesRequestObject()
        {
            // Snippet: ListMemories(ListMemoriesRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            ListMemoriesRequest request = new ListMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Memory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMemoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemoriesAsync</summary>
        public async Task ListMemoriesRequestObjectAsync()
        {
            // Snippet: ListMemoriesAsync(ListMemoriesRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMemoriesRequest request = new ListMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Memory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMemoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemories</summary>
        public void ListMemories()
        {
            // Snippet: ListMemories(string, string, int?, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            PagedEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Memory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMemoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemoriesAsync</summary>
        public async Task ListMemoriesAsync()
        {
            // Snippet: ListMemoriesAsync(string, string, int?, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            PagedAsyncEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Memory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMemoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemories</summary>
        public void ListMemoriesResourceNames()
        {
            // Snippet: ListMemories(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            PagedEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Memory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMemoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemoriesAsync</summary>
        public async Task ListMemoriesResourceNamesAsync()
        {
            // Snippet: ListMemoriesAsync(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            PagedAsyncEnumerable<ListMemoriesResponse, Memory> response = memoryBankServiceClient.ListMemoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Memory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMemoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Memory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Memory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Memory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteMemory</summary>
        public void DeleteMemoryRequestObject()
        {
            // Snippet: DeleteMemory(DeleteMemoryRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            DeleteMemoryRequest request = new DeleteMemoryRequest
            {
                MemoryName = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]"),
            };
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = memoryBankServiceClient.DeleteMemory(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceDeleteMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMemoryAsync</summary>
        public async Task DeleteMemoryRequestObjectAsync()
        {
            // Snippet: DeleteMemoryAsync(DeleteMemoryRequest, CallSettings)
            // Additional: DeleteMemoryAsync(DeleteMemoryRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMemoryRequest request = new DeleteMemoryRequest
            {
                MemoryName = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]"),
            };
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = await memoryBankServiceClient.DeleteMemoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceDeleteMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMemory</summary>
        public void DeleteMemory()
        {
            // Snippet: DeleteMemory(string, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/memories/[MEMORY]";
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = memoryBankServiceClient.DeleteMemory(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceDeleteMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMemoryAsync</summary>
        public async Task DeleteMemoryAsync()
        {
            // Snippet: DeleteMemoryAsync(string, CallSettings)
            // Additional: DeleteMemoryAsync(string, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/memories/[MEMORY]";
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = await memoryBankServiceClient.DeleteMemoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceDeleteMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMemory</summary>
        public void DeleteMemoryResourceNames()
        {
            // Snippet: DeleteMemory(MemoryName, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            MemoryName name = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]");
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = memoryBankServiceClient.DeleteMemory(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceDeleteMemory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMemoryAsync</summary>
        public async Task DeleteMemoryResourceNamesAsync()
        {
            // Snippet: DeleteMemoryAsync(MemoryName, CallSettings)
            // Additional: DeleteMemoryAsync(MemoryName, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            MemoryName name = MemoryName.FromProjectLocationReasoningEngineMemory("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[MEMORY]");
            // Make the request
            Operation<Empty, DeleteMemoryOperationMetadata> response = await memoryBankServiceClient.DeleteMemoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteMemoryOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteMemoryOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceDeleteMemoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemories</summary>
        public void GenerateMemoriesRequestObject()
        {
            // Snippet: GenerateMemories(GenerateMemoriesRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            GenerateMemoriesRequest request = new GenerateMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                VertexSessionSource = new GenerateMemoriesRequest.Types.VertexSessionSource(),
                DisableConsolidation = false,
                Scope = { { "", "" }, },
            };
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = memoryBankServiceClient.GenerateMemories(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceGenerateMemories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemoriesAsync</summary>
        public async Task GenerateMemoriesRequestObjectAsync()
        {
            // Snippet: GenerateMemoriesAsync(GenerateMemoriesRequest, CallSettings)
            // Additional: GenerateMemoriesAsync(GenerateMemoriesRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateMemoriesRequest request = new GenerateMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                VertexSessionSource = new GenerateMemoriesRequest.Types.VertexSessionSource(),
                DisableConsolidation = false,
                Scope = { { "", "" }, },
            };
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = await memoryBankServiceClient.GenerateMemoriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceGenerateMemoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemories</summary>
        public void GenerateMemories()
        {
            // Snippet: GenerateMemories(string, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = memoryBankServiceClient.GenerateMemories(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceGenerateMemories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemoriesAsync</summary>
        public async Task GenerateMemoriesAsync()
        {
            // Snippet: GenerateMemoriesAsync(string, CallSettings)
            // Additional: GenerateMemoriesAsync(string, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = await memoryBankServiceClient.GenerateMemoriesAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceGenerateMemoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemories</summary>
        public void GenerateMemoriesResourceNames()
        {
            // Snippet: GenerateMemories(ReasoningEngineName, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = memoryBankServiceClient.GenerateMemories(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = memoryBankServiceClient.PollOnceGenerateMemories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateMemoriesAsync</summary>
        public async Task GenerateMemoriesResourceNamesAsync()
        {
            // Snippet: GenerateMemoriesAsync(ReasoningEngineName, CallSettings)
            // Additional: GenerateMemoriesAsync(ReasoningEngineName, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> response = await memoryBankServiceClient.GenerateMemoriesAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GenerateMemoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GenerateMemoriesResponse, GenerateMemoriesOperationMetadata> retrievedResponse = await memoryBankServiceClient.PollOnceGenerateMemoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GenerateMemoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemories</summary>
        public void RetrieveMemoriesRequestObject()
        {
            // Snippet: RetrieveMemories(RetrieveMemoriesRequest, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            RetrieveMemoriesRequest request = new RetrieveMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                SimilaritySearchParams = new RetrieveMemoriesRequest.Types.SimilaritySearchParams(),
                Scope = { { "", "" }, },
            };
            // Make the request
            RetrieveMemoriesResponse response = memoryBankServiceClient.RetrieveMemories(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemoriesAsync</summary>
        public async Task RetrieveMemoriesRequestObjectAsync()
        {
            // Snippet: RetrieveMemoriesAsync(RetrieveMemoriesRequest, CallSettings)
            // Additional: RetrieveMemoriesAsync(RetrieveMemoriesRequest, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveMemoriesRequest request = new RetrieveMemoriesRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                SimilaritySearchParams = new RetrieveMemoriesRequest.Types.SimilaritySearchParams(),
                Scope = { { "", "" }, },
            };
            // Make the request
            RetrieveMemoriesResponse response = await memoryBankServiceClient.RetrieveMemoriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemories</summary>
        public void RetrieveMemories()
        {
            // Snippet: RetrieveMemories(string, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            RetrieveMemoriesResponse response = memoryBankServiceClient.RetrieveMemories(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemoriesAsync</summary>
        public async Task RetrieveMemoriesAsync()
        {
            // Snippet: RetrieveMemoriesAsync(string, CallSettings)
            // Additional: RetrieveMemoriesAsync(string, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            RetrieveMemoriesResponse response = await memoryBankServiceClient.RetrieveMemoriesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemories</summary>
        public void RetrieveMemoriesResourceNames()
        {
            // Snippet: RetrieveMemories(ReasoningEngineName, CallSettings)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = MemoryBankServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            RetrieveMemoriesResponse response = memoryBankServiceClient.RetrieveMemories(parent);
            // End snippet
        }

        /// <summary>Snippet for RetrieveMemoriesAsync</summary>
        public async Task RetrieveMemoriesResourceNamesAsync()
        {
            // Snippet: RetrieveMemoriesAsync(ReasoningEngineName, CallSettings)
            // Additional: RetrieveMemoriesAsync(ReasoningEngineName, CancellationToken)
            // Create client
            MemoryBankServiceClient memoryBankServiceClient = await MemoryBankServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            RetrieveMemoriesResponse response = await memoryBankServiceClient.RetrieveMemoriesAsync(parent);
            // End snippet
        }
    }
}
