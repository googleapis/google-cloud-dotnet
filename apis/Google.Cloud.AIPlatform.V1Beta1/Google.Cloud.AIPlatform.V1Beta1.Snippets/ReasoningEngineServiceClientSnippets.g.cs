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
    public sealed class AllGeneratedReasoningEngineServiceClientSnippets
    {
        /// <summary>Snippet for CreateReasoningEngine</summary>
        public void CreateReasoningEngineRequestObject()
        {
            // Snippet: CreateReasoningEngine(CreateReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            CreateReasoningEngineRequest request = new CreateReasoningEngineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReasoningEngine = new ReasoningEngine(),
            };
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = reasoningEngineServiceClient.CreateReasoningEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceCreateReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReasoningEngineAsync</summary>
        public async Task CreateReasoningEngineRequestObjectAsync()
        {
            // Snippet: CreateReasoningEngineAsync(CreateReasoningEngineRequest, CallSettings)
            // Additional: CreateReasoningEngineAsync(CreateReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReasoningEngineRequest request = new CreateReasoningEngineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReasoningEngine = new ReasoningEngine(),
            };
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = await reasoningEngineServiceClient.CreateReasoningEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceCreateReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReasoningEngine</summary>
        public void CreateReasoningEngine()
        {
            // Snippet: CreateReasoningEngine(string, ReasoningEngine, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = reasoningEngineServiceClient.CreateReasoningEngine(parent, reasoningEngine);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceCreateReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReasoningEngineAsync</summary>
        public async Task CreateReasoningEngineAsync()
        {
            // Snippet: CreateReasoningEngineAsync(string, ReasoningEngine, CallSettings)
            // Additional: CreateReasoningEngineAsync(string, ReasoningEngine, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = await reasoningEngineServiceClient.CreateReasoningEngineAsync(parent, reasoningEngine);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceCreateReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReasoningEngine</summary>
        public void CreateReasoningEngineResourceNames()
        {
            // Snippet: CreateReasoningEngine(LocationName, ReasoningEngine, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = reasoningEngineServiceClient.CreateReasoningEngine(parent, reasoningEngine);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceCreateReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReasoningEngineAsync</summary>
        public async Task CreateReasoningEngineResourceNamesAsync()
        {
            // Snippet: CreateReasoningEngineAsync(LocationName, ReasoningEngine, CallSettings)
            // Additional: CreateReasoningEngineAsync(LocationName, ReasoningEngine, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            // Make the request
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> response = await reasoningEngineServiceClient.CreateReasoningEngineAsync(parent, reasoningEngine);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, CreateReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceCreateReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngine</summary>
        public void GetReasoningEngineRequestObject()
        {
            // Snippet: GetReasoningEngine(GetReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            GetReasoningEngineRequest request = new GetReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
            };
            // Make the request
            ReasoningEngine response = reasoningEngineServiceClient.GetReasoningEngine(request);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineAsync</summary>
        public async Task GetReasoningEngineRequestObjectAsync()
        {
            // Snippet: GetReasoningEngineAsync(GetReasoningEngineRequest, CallSettings)
            // Additional: GetReasoningEngineAsync(GetReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReasoningEngineRequest request = new GetReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
            };
            // Make the request
            ReasoningEngine response = await reasoningEngineServiceClient.GetReasoningEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngine</summary>
        public void GetReasoningEngine()
        {
            // Snippet: GetReasoningEngine(string, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            ReasoningEngine response = reasoningEngineServiceClient.GetReasoningEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineAsync</summary>
        public async Task GetReasoningEngineAsync()
        {
            // Snippet: GetReasoningEngineAsync(string, CallSettings)
            // Additional: GetReasoningEngineAsync(string, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            ReasoningEngine response = await reasoningEngineServiceClient.GetReasoningEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngine</summary>
        public void GetReasoningEngineResourceNames()
        {
            // Snippet: GetReasoningEngine(ReasoningEngineName, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName name = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            ReasoningEngine response = reasoningEngineServiceClient.GetReasoningEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineAsync</summary>
        public async Task GetReasoningEngineResourceNamesAsync()
        {
            // Snippet: GetReasoningEngineAsync(ReasoningEngineName, CallSettings)
            // Additional: GetReasoningEngineAsync(ReasoningEngineName, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName name = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            ReasoningEngine response = await reasoningEngineServiceClient.GetReasoningEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngines</summary>
        public void ListReasoningEnginesRequestObject()
        {
            // Snippet: ListReasoningEngines(ListReasoningEnginesRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEngines(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEnginesAsync</summary>
        public async Task ListReasoningEnginesRequestObjectAsync()
        {
            // Snippet: ListReasoningEnginesAsync(ListReasoningEnginesRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReasoningEnginesRequest request = new ListReasoningEnginesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEnginesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReasoningEngine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReasoningEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngines</summary>
        public void ListReasoningEngines()
        {
            // Snippet: ListReasoningEngines(string, string, int?, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEngines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEnginesAsync</summary>
        public async Task ListReasoningEnginesAsync()
        {
            // Snippet: ListReasoningEnginesAsync(string, string, int?, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEnginesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReasoningEngine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReasoningEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngines</summary>
        public void ListReasoningEnginesResourceNames()
        {
            // Snippet: ListReasoningEngines(LocationName, string, int?, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEngines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEnginesAsync</summary>
        public async Task ListReasoningEnginesResourceNamesAsync()
        {
            // Snippet: ListReasoningEnginesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReasoningEnginesResponse, ReasoningEngine> response = reasoningEngineServiceClient.ListReasoningEnginesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReasoningEngine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReasoningEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateReasoningEngine</summary>
        public void UpdateReasoningEngineRequestObject()
        {
            // Snippet: UpdateReasoningEngine(UpdateReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            UpdateReasoningEngineRequest request = new UpdateReasoningEngineRequest
            {
                ReasoningEngine = new ReasoningEngine(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> response = reasoningEngineServiceClient.UpdateReasoningEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceUpdateReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReasoningEngineAsync</summary>
        public async Task UpdateReasoningEngineRequestObjectAsync()
        {
            // Snippet: UpdateReasoningEngineAsync(UpdateReasoningEngineRequest, CallSettings)
            // Additional: UpdateReasoningEngineAsync(UpdateReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReasoningEngineRequest request = new UpdateReasoningEngineRequest
            {
                ReasoningEngine = new ReasoningEngine(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> response = await reasoningEngineServiceClient.UpdateReasoningEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceUpdateReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReasoningEngine</summary>
        public void UpdateReasoningEngine()
        {
            // Snippet: UpdateReasoningEngine(ReasoningEngine, FieldMask, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> response = reasoningEngineServiceClient.UpdateReasoningEngine(reasoningEngine, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceUpdateReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateReasoningEngineAsync</summary>
        public async Task UpdateReasoningEngineAsync()
        {
            // Snippet: UpdateReasoningEngineAsync(ReasoningEngine, FieldMask, CallSettings)
            // Additional: UpdateReasoningEngineAsync(ReasoningEngine, FieldMask, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngine reasoningEngine = new ReasoningEngine();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> response = await reasoningEngineServiceClient.UpdateReasoningEngineAsync(reasoningEngine, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReasoningEngine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReasoningEngine, UpdateReasoningEngineOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceUpdateReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReasoningEngine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngine</summary>
        public void DeleteReasoningEngineRequestObject()
        {
            // Snippet: DeleteReasoningEngine(DeleteReasoningEngineRequest, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            DeleteReasoningEngineRequest request = new DeleteReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = reasoningEngineServiceClient.DeleteReasoningEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceDeleteReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineAsync</summary>
        public async Task DeleteReasoningEngineRequestObjectAsync()
        {
            // Snippet: DeleteReasoningEngineAsync(DeleteReasoningEngineRequest, CallSettings)
            // Additional: DeleteReasoningEngineAsync(DeleteReasoningEngineRequest, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReasoningEngineRequest request = new DeleteReasoningEngineRequest
            {
                ReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await reasoningEngineServiceClient.DeleteReasoningEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceDeleteReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngine</summary>
        public void DeleteReasoningEngine()
        {
            // Snippet: DeleteReasoningEngine(string, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = reasoningEngineServiceClient.DeleteReasoningEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceDeleteReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineAsync</summary>
        public async Task DeleteReasoningEngineAsync()
        {
            // Snippet: DeleteReasoningEngineAsync(string, CallSettings)
            // Additional: DeleteReasoningEngineAsync(string, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await reasoningEngineServiceClient.DeleteReasoningEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceDeleteReasoningEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngine</summary>
        public void DeleteReasoningEngineResourceNames()
        {
            // Snippet: DeleteReasoningEngine(ReasoningEngineName, CallSettings)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = ReasoningEngineServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName name = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = reasoningEngineServiceClient.DeleteReasoningEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = reasoningEngineServiceClient.PollOnceDeleteReasoningEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineAsync</summary>
        public async Task DeleteReasoningEngineResourceNamesAsync()
        {
            // Snippet: DeleteReasoningEngineAsync(ReasoningEngineName, CallSettings)
            // Additional: DeleteReasoningEngineAsync(ReasoningEngineName, CancellationToken)
            // Create client
            ReasoningEngineServiceClient reasoningEngineServiceClient = await ReasoningEngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName name = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await reasoningEngineServiceClient.DeleteReasoningEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await reasoningEngineServiceClient.PollOnceDeleteReasoningEngineAsync(operationName);
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
