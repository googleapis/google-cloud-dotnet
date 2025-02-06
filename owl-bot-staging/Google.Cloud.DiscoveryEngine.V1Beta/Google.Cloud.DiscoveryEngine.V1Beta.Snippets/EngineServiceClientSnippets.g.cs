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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEngineServiceClientSnippets
    {
        /// <summary>Snippet for CreateEngine</summary>
        public void CreateEngineRequestObject()
        {
            // Snippet: CreateEngine(CreateEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            CreateEngineRequest request = new CreateEngineRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Engine = new Engine(),
                EngineId = "",
            };
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = engineServiceClient.CreateEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = engineServiceClient.PollOnceCreateEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineAsync</summary>
        public async Task CreateEngineRequestObjectAsync()
        {
            // Snippet: CreateEngineAsync(CreateEngineRequest, CallSettings)
            // Additional: CreateEngineAsync(CreateEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEngineRequest request = new CreateEngineRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Engine = new Engine(),
                EngineId = "",
            };
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = await engineServiceClient.CreateEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceCreateEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngine</summary>
        public void CreateEngine()
        {
            // Snippet: CreateEngine(string, Engine, string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            Engine engine = new Engine();
            string engineId = "";
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = engineServiceClient.CreateEngine(parent, engine, engineId);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = engineServiceClient.PollOnceCreateEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineAsync</summary>
        public async Task CreateEngineAsync()
        {
            // Snippet: CreateEngineAsync(string, Engine, string, CallSettings)
            // Additional: CreateEngineAsync(string, Engine, string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            Engine engine = new Engine();
            string engineId = "";
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = await engineServiceClient.CreateEngineAsync(parent, engine, engineId);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceCreateEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngine</summary>
        public void CreateEngineResourceNames()
        {
            // Snippet: CreateEngine(CollectionName, Engine, string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            Engine engine = new Engine();
            string engineId = "";
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = engineServiceClient.CreateEngine(parent, engine, engineId);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = engineServiceClient.PollOnceCreateEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEngineAsync</summary>
        public async Task CreateEngineResourceNamesAsync()
        {
            // Snippet: CreateEngineAsync(CollectionName, Engine, string, CallSettings)
            // Additional: CreateEngineAsync(CollectionName, Engine, string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            Engine engine = new Engine();
            string engineId = "";
            // Make the request
            Operation<Engine, CreateEngineMetadata> response = await engineServiceClient.CreateEngineAsync(parent, engine, engineId);

            // Poll until the returned long-running operation is complete
            Operation<Engine, CreateEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Engine result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Engine, CreateEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceCreateEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Engine retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngine</summary>
        public void DeleteEngineRequestObject()
        {
            // Snippet: DeleteEngine(DeleteEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            DeleteEngineRequest request = new DeleteEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = engineServiceClient.DeleteEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = engineServiceClient.PollOnceDeleteEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineAsync</summary>
        public async Task DeleteEngineRequestObjectAsync()
        {
            // Snippet: DeleteEngineAsync(DeleteEngineRequest, CallSettings)
            // Additional: DeleteEngineAsync(DeleteEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEngineRequest request = new DeleteEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = await engineServiceClient.DeleteEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceDeleteEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngine</summary>
        public void DeleteEngine()
        {
            // Snippet: DeleteEngine(string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = engineServiceClient.DeleteEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = engineServiceClient.PollOnceDeleteEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineAsync</summary>
        public async Task DeleteEngineAsync()
        {
            // Snippet: DeleteEngineAsync(string, CallSettings)
            // Additional: DeleteEngineAsync(string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = await engineServiceClient.DeleteEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceDeleteEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngine</summary>
        public void DeleteEngineResourceNames()
        {
            // Snippet: DeleteEngine(EngineName, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = engineServiceClient.DeleteEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = engineServiceClient.PollOnceDeleteEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEngineAsync</summary>
        public async Task DeleteEngineResourceNamesAsync()
        {
            // Snippet: DeleteEngineAsync(EngineName, CallSettings)
            // Additional: DeleteEngineAsync(EngineName, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Operation<Empty, DeleteEngineMetadata> response = await engineServiceClient.DeleteEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceDeleteEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEngine</summary>
        public void UpdateEngineRequestObject()
        {
            // Snippet: UpdateEngine(UpdateEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            UpdateEngineRequest request = new UpdateEngineRequest
            {
                Engine = new Engine(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Engine response = engineServiceClient.UpdateEngine(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineAsync</summary>
        public async Task UpdateEngineRequestObjectAsync()
        {
            // Snippet: UpdateEngineAsync(UpdateEngineRequest, CallSettings)
            // Additional: UpdateEngineAsync(UpdateEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEngineRequest request = new UpdateEngineRequest
            {
                Engine = new Engine(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Engine response = await engineServiceClient.UpdateEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEngine</summary>
        public void UpdateEngine()
        {
            // Snippet: UpdateEngine(Engine, FieldMask, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            Engine engine = new Engine();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Engine response = engineServiceClient.UpdateEngine(engine, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEngineAsync</summary>
        public async Task UpdateEngineAsync()
        {
            // Snippet: UpdateEngineAsync(Engine, FieldMask, CallSettings)
            // Additional: UpdateEngineAsync(Engine, FieldMask, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            Engine engine = new Engine();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Engine response = await engineServiceClient.UpdateEngineAsync(engine, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetEngine</summary>
        public void GetEngineRequestObject()
        {
            // Snippet: GetEngine(GetEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            GetEngineRequest request = new GetEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = engineServiceClient.GetEngine(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngineAsync</summary>
        public async Task GetEngineRequestObjectAsync()
        {
            // Snippet: GetEngineAsync(GetEngineRequest, CallSettings)
            // Additional: GetEngineAsync(GetEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEngineRequest request = new GetEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = await engineServiceClient.GetEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEngine</summary>
        public void GetEngine()
        {
            // Snippet: GetEngine(string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = engineServiceClient.GetEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineAsync</summary>
        public async Task GetEngineAsync()
        {
            // Snippet: GetEngineAsync(string, CallSettings)
            // Additional: GetEngineAsync(string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = await engineServiceClient.GetEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngine</summary>
        public void GetEngineResourceNames()
        {
            // Snippet: GetEngine(EngineName, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = engineServiceClient.GetEngine(name);
            // End snippet
        }

        /// <summary>Snippet for GetEngineAsync</summary>
        public async Task GetEngineResourceNamesAsync()
        {
            // Snippet: GetEngineAsync(EngineName, CallSettings)
            // Additional: GetEngineAsync(EngineName, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = await engineServiceClient.GetEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEngines</summary>
        public void ListEnginesRequestObject()
        {
            // Snippet: ListEngines(ListEnginesRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            ListEnginesRequest request = new ListEnginesRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEngines(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Engine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnginesAsync</summary>
        public async Task ListEnginesRequestObjectAsync()
        {
            // Snippet: ListEnginesAsync(ListEnginesRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEnginesRequest request = new ListEnginesRequest
            {
                ParentAsCollectionName = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEnginesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Engine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngines</summary>
        public void ListEngines()
        {
            // Snippet: ListEngines(string, string, int?, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEngines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Engine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnginesAsync</summary>
        public async Task ListEnginesAsync()
        {
            // Snippet: ListEnginesAsync(string, string, int?, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEnginesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Engine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEngines</summary>
        public void ListEnginesResourceNames()
        {
            // Snippet: ListEngines(CollectionName, string, int?, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEngines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Engine item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEnginesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnginesAsync</summary>
        public async Task ListEnginesResourceNamesAsync()
        {
            // Snippet: ListEnginesAsync(CollectionName, string, int?, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            CollectionName parent = CollectionName.FromProjectLocationCollection("[PROJECT]", "[LOCATION]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListEnginesResponse, Engine> response = engineServiceClient.ListEnginesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Engine item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEnginesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Engine item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Engine> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Engine item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PauseEngine</summary>
        public void PauseEngineRequestObject()
        {
            // Snippet: PauseEngine(PauseEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            PauseEngineRequest request = new PauseEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = engineServiceClient.PauseEngine(request);
            // End snippet
        }

        /// <summary>Snippet for PauseEngineAsync</summary>
        public async Task PauseEngineRequestObjectAsync()
        {
            // Snippet: PauseEngineAsync(PauseEngineRequest, CallSettings)
            // Additional: PauseEngineAsync(PauseEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseEngineRequest request = new PauseEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = await engineServiceClient.PauseEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseEngine</summary>
        public void PauseEngine()
        {
            // Snippet: PauseEngine(string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = engineServiceClient.PauseEngine(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEngineAsync</summary>
        public async Task PauseEngineAsync()
        {
            // Snippet: PauseEngineAsync(string, CallSettings)
            // Additional: PauseEngineAsync(string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = await engineServiceClient.PauseEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEngine</summary>
        public void PauseEngineResourceNames()
        {
            // Snippet: PauseEngine(EngineName, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = engineServiceClient.PauseEngine(name);
            // End snippet
        }

        /// <summary>Snippet for PauseEngineAsync</summary>
        public async Task PauseEngineResourceNamesAsync()
        {
            // Snippet: PauseEngineAsync(EngineName, CallSettings)
            // Additional: PauseEngineAsync(EngineName, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = await engineServiceClient.PauseEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngine</summary>
        public void ResumeEngineRequestObject()
        {
            // Snippet: ResumeEngine(ResumeEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            ResumeEngineRequest request = new ResumeEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = engineServiceClient.ResumeEngine(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngineAsync</summary>
        public async Task ResumeEngineRequestObjectAsync()
        {
            // Snippet: ResumeEngineAsync(ResumeEngineRequest, CallSettings)
            // Additional: ResumeEngineAsync(ResumeEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeEngineRequest request = new ResumeEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Engine response = await engineServiceClient.ResumeEngineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngine</summary>
        public void ResumeEngine()
        {
            // Snippet: ResumeEngine(string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = engineServiceClient.ResumeEngine(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngineAsync</summary>
        public async Task ResumeEngineAsync()
        {
            // Snippet: ResumeEngineAsync(string, CallSettings)
            // Additional: ResumeEngineAsync(string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Engine response = await engineServiceClient.ResumeEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngine</summary>
        public void ResumeEngineResourceNames()
        {
            // Snippet: ResumeEngine(EngineName, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = engineServiceClient.ResumeEngine(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeEngineAsync</summary>
        public async Task ResumeEngineResourceNamesAsync()
        {
            // Snippet: ResumeEngineAsync(EngineName, CallSettings)
            // Additional: ResumeEngineAsync(EngineName, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Engine response = await engineServiceClient.ResumeEngineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TuneEngine</summary>
        public void TuneEngineRequestObject()
        {
            // Snippet: TuneEngine(TuneEngineRequest, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            TuneEngineRequest request = new TuneEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = engineServiceClient.TuneEngine(request);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = engineServiceClient.PollOnceTuneEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneEngineAsync</summary>
        public async Task TuneEngineRequestObjectAsync()
        {
            // Snippet: TuneEngineAsync(TuneEngineRequest, CallSettings)
            // Additional: TuneEngineAsync(TuneEngineRequest, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            TuneEngineRequest request = new TuneEngineRequest
            {
                EngineName = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]"),
            };
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = await engineServiceClient.TuneEngineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceTuneEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneEngine</summary>
        public void TuneEngine()
        {
            // Snippet: TuneEngine(string, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = engineServiceClient.TuneEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = engineServiceClient.PollOnceTuneEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneEngineAsync</summary>
        public async Task TuneEngineAsync()
        {
            // Snippet: TuneEngineAsync(string, CallSettings)
            // Additional: TuneEngineAsync(string, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/collections/[COLLECTION]/engines/[ENGINE]";
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = await engineServiceClient.TuneEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceTuneEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneEngine</summary>
        public void TuneEngineResourceNames()
        {
            // Snippet: TuneEngine(EngineName, CallSettings)
            // Create client
            EngineServiceClient engineServiceClient = EngineServiceClient.Create();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = engineServiceClient.TuneEngine(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = engineServiceClient.PollOnceTuneEngine(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TuneEngineAsync</summary>
        public async Task TuneEngineResourceNamesAsync()
        {
            // Snippet: TuneEngineAsync(EngineName, CallSettings)
            // Additional: TuneEngineAsync(EngineName, CancellationToken)
            // Create client
            EngineServiceClient engineServiceClient = await EngineServiceClient.CreateAsync();
            // Initialize request argument(s)
            EngineName name = EngineName.FromProjectLocationCollectionEngine("[PROJECT]", "[LOCATION]", "[COLLECTION]", "[ENGINE]");
            // Make the request
            Operation<TuneEngineResponse, TuneEngineMetadata> response = await engineServiceClient.TuneEngineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<TuneEngineResponse, TuneEngineMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TuneEngineResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TuneEngineResponse, TuneEngineMetadata> retrievedResponse = await engineServiceClient.PollOnceTuneEngineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TuneEngineResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
