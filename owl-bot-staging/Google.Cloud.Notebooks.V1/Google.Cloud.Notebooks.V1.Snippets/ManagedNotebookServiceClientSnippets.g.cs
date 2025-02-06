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
    using Google.Cloud.Notebooks.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedManagedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimesRequestObject()
        {
            // Snippet: ListRuntimes(ListRuntimesRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Runtime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesRequestObjectAsync()
        {
            // Snippet: ListRuntimesAsync(ListRuntimesRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Runtime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimes()
        {
            // Snippet: ListRuntimes(string, string, int?, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Runtime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesAsync()
        {
            // Snippet: ListRuntimesAsync(string, string, int?, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Runtime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimesResourceNames()
        {
            // Snippet: ListRuntimes(LocationName, string, int?, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Runtime item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesResourceNamesAsync()
        {
            // Snippet: ListRuntimesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListRuntimesResponse, Runtime> response = managedNotebookServiceClient.ListRuntimesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Runtime item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Runtime item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Runtime> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Runtime item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRuntime</summary>
        public void GetRuntimeRequestObject()
        {
            // Snippet: GetRuntime(GetRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            // Make the request
            Runtime response = managedNotebookServiceClient.GetRuntime(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeAsync</summary>
        public async Task GetRuntimeRequestObjectAsync()
        {
            // Snippet: GetRuntimeAsync(GetRuntimeRequest, CallSettings)
            // Additional: GetRuntimeAsync(GetRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRuntimeRequest request = new GetRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
            };
            // Make the request
            Runtime response = await managedNotebookServiceClient.GetRuntimeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntime</summary>
        public void GetRuntime()
        {
            // Snippet: GetRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Runtime response = managedNotebookServiceClient.GetRuntime(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeAsync</summary>
        public async Task GetRuntimeAsync()
        {
            // Snippet: GetRuntimeAsync(string, CallSettings)
            // Additional: GetRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Runtime response = await managedNotebookServiceClient.GetRuntimeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntime</summary>
        public void GetRuntimeResourceNames()
        {
            // Snippet: GetRuntime(RuntimeName, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Runtime response = managedNotebookServiceClient.GetRuntime(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeAsync</summary>
        public async Task GetRuntimeResourceNamesAsync()
        {
            // Snippet: GetRuntimeAsync(RuntimeName, CallSettings)
            // Additional: GetRuntimeAsync(RuntimeName, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Runtime response = await managedNotebookServiceClient.GetRuntimeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRuntime</summary>
        public void CreateRuntimeRequestObject()
        {
            // Snippet: CreateRuntime(CreateRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            CreateRuntimeRequest request = new CreateRuntimeRequest
            {
                ParentAsRuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                RuntimeId = "",
                Runtime = new Runtime(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.CreateRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceCreateRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeAsync</summary>
        public async Task CreateRuntimeRequestObjectAsync()
        {
            // Snippet: CreateRuntimeAsync(CreateRuntimeRequest, CallSettings)
            // Additional: CreateRuntimeAsync(CreateRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRuntimeRequest request = new CreateRuntimeRequest
            {
                ParentAsRuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                RuntimeId = "",
                Runtime = new Runtime(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.CreateRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceCreateRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRuntime</summary>
        public void CreateRuntime()
        {
            // Snippet: CreateRuntime(string, string, Runtime, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            string runtimeId = "";
            Runtime runtime = new Runtime();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.CreateRuntime(parent, runtimeId, runtime);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceCreateRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeAsync</summary>
        public async Task CreateRuntimeAsync()
        {
            // Snippet: CreateRuntimeAsync(string, string, Runtime, CallSettings)
            // Additional: CreateRuntimeAsync(string, string, Runtime, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            string runtimeId = "";
            Runtime runtime = new Runtime();
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.CreateRuntimeAsync(parent, runtimeId, runtime);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceCreateRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRuntime</summary>
        public void CreateRuntimeResourceNames()
        {
            // Snippet: CreateRuntime(RuntimeName, string, Runtime, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName parent = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            string runtimeId = "";
            Runtime runtime = new Runtime();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.CreateRuntime(parent, runtimeId, runtime);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceCreateRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRuntimeAsync</summary>
        public async Task CreateRuntimeResourceNamesAsync()
        {
            // Snippet: CreateRuntimeAsync(RuntimeName, string, Runtime, CallSettings)
            // Additional: CreateRuntimeAsync(RuntimeName, string, Runtime, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName parent = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            string runtimeId = "";
            Runtime runtime = new Runtime();
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.CreateRuntimeAsync(parent, runtimeId, runtime);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceCreateRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRuntime</summary>
        public void UpdateRuntimeRequestObject()
        {
            // Snippet: UpdateRuntime(UpdateRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            UpdateRuntimeRequest request = new UpdateRuntimeRequest
            {
                Runtime = new Runtime(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.UpdateRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceUpdateRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRuntimeAsync</summary>
        public async Task UpdateRuntimeRequestObjectAsync()
        {
            // Snippet: UpdateRuntimeAsync(UpdateRuntimeRequest, CallSettings)
            // Additional: UpdateRuntimeAsync(UpdateRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRuntimeRequest request = new UpdateRuntimeRequest
            {
                Runtime = new Runtime(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.UpdateRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceUpdateRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRuntime</summary>
        public void UpdateRuntime()
        {
            // Snippet: UpdateRuntime(Runtime, FieldMask, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            Runtime runtime = new Runtime();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.UpdateRuntime(runtime, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceUpdateRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRuntimeAsync</summary>
        public async Task UpdateRuntimeAsync()
        {
            // Snippet: UpdateRuntimeAsync(Runtime, FieldMask, CallSettings)
            // Additional: UpdateRuntimeAsync(Runtime, FieldMask, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            Runtime runtime = new Runtime();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.UpdateRuntimeAsync(runtime, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceUpdateRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntime</summary>
        public void DeleteRuntimeRequestObject()
        {
            // Snippet: DeleteRuntime(DeleteRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            DeleteRuntimeRequest request = new DeleteRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = managedNotebookServiceClient.DeleteRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDeleteRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeAsync</summary>
        public async Task DeleteRuntimeRequestObjectAsync()
        {
            // Snippet: DeleteRuntimeAsync(DeleteRuntimeRequest, CallSettings)
            // Additional: DeleteRuntimeAsync(DeleteRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRuntimeRequest request = new DeleteRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedNotebookServiceClient.DeleteRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDeleteRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntime</summary>
        public void DeleteRuntime()
        {
            // Snippet: DeleteRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = managedNotebookServiceClient.DeleteRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDeleteRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeAsync</summary>
        public async Task DeleteRuntimeAsync()
        {
            // Snippet: DeleteRuntimeAsync(string, CallSettings)
            // Additional: DeleteRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedNotebookServiceClient.DeleteRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDeleteRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntime</summary>
        public void DeleteRuntimeResourceNames()
        {
            // Snippet: DeleteRuntime(RuntimeName, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = managedNotebookServiceClient.DeleteRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDeleteRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRuntimeAsync</summary>
        public async Task DeleteRuntimeResourceNamesAsync()
        {
            // Snippet: DeleteRuntimeAsync(RuntimeName, CallSettings)
            // Additional: DeleteRuntimeAsync(RuntimeName, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedNotebookServiceClient.DeleteRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDeleteRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartRuntime</summary>
        public void StartRuntimeRequestObject()
        {
            // Snippet: StartRuntime(StartRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            StartRuntimeRequest request = new StartRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.StartRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceStartRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartRuntimeAsync</summary>
        public async Task StartRuntimeRequestObjectAsync()
        {
            // Snippet: StartRuntimeAsync(StartRuntimeRequest, CallSettings)
            // Additional: StartRuntimeAsync(StartRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartRuntimeRequest request = new StartRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.StartRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceStartRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartRuntime</summary>
        public void StartRuntime()
        {
            // Snippet: StartRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.StartRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceStartRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartRuntimeAsync</summary>
        public async Task StartRuntimeAsync()
        {
            // Snippet: StartRuntimeAsync(string, CallSettings)
            // Additional: StartRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.StartRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceStartRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopRuntime</summary>
        public void StopRuntimeRequestObject()
        {
            // Snippet: StopRuntime(StopRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            StopRuntimeRequest request = new StopRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.StopRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceStopRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopRuntimeAsync</summary>
        public async Task StopRuntimeRequestObjectAsync()
        {
            // Snippet: StopRuntimeAsync(StopRuntimeRequest, CallSettings)
            // Additional: StopRuntimeAsync(StopRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            StopRuntimeRequest request = new StopRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.StopRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceStopRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopRuntime</summary>
        public void StopRuntime()
        {
            // Snippet: StopRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.StopRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceStopRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopRuntimeAsync</summary>
        public async Task StopRuntimeAsync()
        {
            // Snippet: StopRuntimeAsync(string, CallSettings)
            // Additional: StopRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.StopRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceStopRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchRuntime</summary>
        public void SwitchRuntimeRequestObject()
        {
            // Snippet: SwitchRuntime(SwitchRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            SwitchRuntimeRequest request = new SwitchRuntimeRequest
            {
                Name = "",
                MachineType = "",
                AcceleratorConfig = new RuntimeAcceleratorConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.SwitchRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceSwitchRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchRuntimeAsync</summary>
        public async Task SwitchRuntimeRequestObjectAsync()
        {
            // Snippet: SwitchRuntimeAsync(SwitchRuntimeRequest, CallSettings)
            // Additional: SwitchRuntimeAsync(SwitchRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            SwitchRuntimeRequest request = new SwitchRuntimeRequest
            {
                Name = "",
                MachineType = "",
                AcceleratorConfig = new RuntimeAcceleratorConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.SwitchRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceSwitchRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchRuntime</summary>
        public void SwitchRuntime()
        {
            // Snippet: SwitchRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.SwitchRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceSwitchRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchRuntimeAsync</summary>
        public async Task SwitchRuntimeAsync()
        {
            // Snippet: SwitchRuntimeAsync(string, CallSettings)
            // Additional: SwitchRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.SwitchRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceSwitchRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetRuntime</summary>
        public void ResetRuntimeRequestObject()
        {
            // Snippet: ResetRuntime(ResetRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            ResetRuntimeRequest request = new ResetRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.ResetRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceResetRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetRuntimeAsync</summary>
        public async Task ResetRuntimeRequestObjectAsync()
        {
            // Snippet: ResetRuntimeAsync(ResetRuntimeRequest, CallSettings)
            // Additional: ResetRuntimeAsync(ResetRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResetRuntimeRequest request = new ResetRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.ResetRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceResetRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetRuntime</summary>
        public void ResetRuntime()
        {
            // Snippet: ResetRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.ResetRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceResetRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResetRuntimeAsync</summary>
        public async Task ResetRuntimeAsync()
        {
            // Snippet: ResetRuntimeAsync(string, CallSettings)
            // Additional: ResetRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.ResetRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceResetRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeRuntime</summary>
        public void UpgradeRuntimeRequestObject()
        {
            // Snippet: UpgradeRuntime(UpgradeRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            UpgradeRuntimeRequest request = new UpgradeRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.UpgradeRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceUpgradeRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeRuntimeAsync</summary>
        public async Task UpgradeRuntimeRequestObjectAsync()
        {
            // Snippet: UpgradeRuntimeAsync(UpgradeRuntimeRequest, CallSettings)
            // Additional: UpgradeRuntimeAsync(UpgradeRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeRuntimeRequest request = new UpgradeRuntimeRequest
            {
                Name = "",
                RequestId = "",
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.UpgradeRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceUpgradeRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeRuntime</summary>
        public void UpgradeRuntime()
        {
            // Snippet: UpgradeRuntime(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.UpgradeRuntime(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceUpgradeRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeRuntimeAsync</summary>
        public async Task UpgradeRuntimeAsync()
        {
            // Snippet: UpgradeRuntimeAsync(string, CallSettings)
            // Additional: UpgradeRuntimeAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.UpgradeRuntimeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceUpgradeRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEvent</summary>
        public void ReportRuntimeEventRequestObject()
        {
            // Snippet: ReportRuntimeEvent(ReportRuntimeEventRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            ReportRuntimeEventRequest request = new ReportRuntimeEventRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VmId = "",
                Event = new Event(),
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.ReportRuntimeEvent(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceReportRuntimeEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEventAsync</summary>
        public async Task ReportRuntimeEventRequestObjectAsync()
        {
            // Snippet: ReportRuntimeEventAsync(ReportRuntimeEventRequest, CallSettings)
            // Additional: ReportRuntimeEventAsync(ReportRuntimeEventRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportRuntimeEventRequest request = new ReportRuntimeEventRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VmId = "",
                Event = new Event(),
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.ReportRuntimeEventAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceReportRuntimeEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEvent</summary>
        public void ReportRuntimeEvent()
        {
            // Snippet: ReportRuntimeEvent(string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.ReportRuntimeEvent(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceReportRuntimeEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEventAsync</summary>
        public async Task ReportRuntimeEventAsync()
        {
            // Snippet: ReportRuntimeEventAsync(string, CallSettings)
            // Additional: ReportRuntimeEventAsync(string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.ReportRuntimeEventAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceReportRuntimeEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEvent</summary>
        public void ReportRuntimeEventResourceNames()
        {
            // Snippet: ReportRuntimeEvent(RuntimeName, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.ReportRuntimeEvent(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceReportRuntimeEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReportRuntimeEventAsync</summary>
        public async Task ReportRuntimeEventResourceNamesAsync()
        {
            // Snippet: ReportRuntimeEventAsync(RuntimeName, CallSettings)
            // Additional: ReportRuntimeEventAsync(RuntimeName, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.ReportRuntimeEventAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceReportRuntimeEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternal</summary>
        public void RefreshRuntimeTokenInternalRequestObject()
        {
            // Snippet: RefreshRuntimeTokenInternal(RefreshRuntimeTokenInternalRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RefreshRuntimeTokenInternalRequest request = new RefreshRuntimeTokenInternalRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VmId = "",
            };
            // Make the request
            RefreshRuntimeTokenInternalResponse response = managedNotebookServiceClient.RefreshRuntimeTokenInternal(request);
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternalAsync</summary>
        public async Task RefreshRuntimeTokenInternalRequestObjectAsync()
        {
            // Snippet: RefreshRuntimeTokenInternalAsync(RefreshRuntimeTokenInternalRequest, CallSettings)
            // Additional: RefreshRuntimeTokenInternalAsync(RefreshRuntimeTokenInternalRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RefreshRuntimeTokenInternalRequest request = new RefreshRuntimeTokenInternalRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                VmId = "",
            };
            // Make the request
            RefreshRuntimeTokenInternalResponse response = await managedNotebookServiceClient.RefreshRuntimeTokenInternalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternal</summary>
        public void RefreshRuntimeTokenInternal()
        {
            // Snippet: RefreshRuntimeTokenInternal(string, string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            string vmId = "";
            // Make the request
            RefreshRuntimeTokenInternalResponse response = managedNotebookServiceClient.RefreshRuntimeTokenInternal(name, vmId);
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternalAsync</summary>
        public async Task RefreshRuntimeTokenInternalAsync()
        {
            // Snippet: RefreshRuntimeTokenInternalAsync(string, string, CallSettings)
            // Additional: RefreshRuntimeTokenInternalAsync(string, string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            string vmId = "";
            // Make the request
            RefreshRuntimeTokenInternalResponse response = await managedNotebookServiceClient.RefreshRuntimeTokenInternalAsync(name, vmId);
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternal</summary>
        public void RefreshRuntimeTokenInternalResourceNames()
        {
            // Snippet: RefreshRuntimeTokenInternal(RuntimeName, string, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            string vmId = "";
            // Make the request
            RefreshRuntimeTokenInternalResponse response = managedNotebookServiceClient.RefreshRuntimeTokenInternal(name, vmId);
            // End snippet
        }

        /// <summary>Snippet for RefreshRuntimeTokenInternalAsync</summary>
        public async Task RefreshRuntimeTokenInternalResourceNamesAsync()
        {
            // Snippet: RefreshRuntimeTokenInternalAsync(RuntimeName, string, CallSettings)
            // Additional: RefreshRuntimeTokenInternalAsync(RuntimeName, string, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            string vmId = "";
            // Make the request
            RefreshRuntimeTokenInternalResponse response = await managedNotebookServiceClient.RefreshRuntimeTokenInternalAsync(name, vmId);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntime</summary>
        public void DiagnoseRuntimeRequestObject()
        {
            // Snippet: DiagnoseRuntime(DiagnoseRuntimeRequest, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            DiagnoseRuntimeRequest request = new DiagnoseRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                DiagnosticConfig = new DiagnosticConfig(),
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.DiagnoseRuntime(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDiagnoseRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntimeAsync</summary>
        public async Task DiagnoseRuntimeRequestObjectAsync()
        {
            // Snippet: DiagnoseRuntimeAsync(DiagnoseRuntimeRequest, CallSettings)
            // Additional: DiagnoseRuntimeAsync(DiagnoseRuntimeRequest, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            DiagnoseRuntimeRequest request = new DiagnoseRuntimeRequest
            {
                RuntimeName = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]"),
                DiagnosticConfig = new DiagnosticConfig(),
            };
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.DiagnoseRuntimeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDiagnoseRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntime</summary>
        public void DiagnoseRuntime()
        {
            // Snippet: DiagnoseRuntime(string, DiagnosticConfig, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            DiagnosticConfig diagnosticConfig = new DiagnosticConfig();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.DiagnoseRuntime(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDiagnoseRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntimeAsync</summary>
        public async Task DiagnoseRuntimeAsync()
        {
            // Snippet: DiagnoseRuntimeAsync(string, DiagnosticConfig, CallSettings)
            // Additional: DiagnoseRuntimeAsync(string, DiagnosticConfig, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            DiagnosticConfig diagnosticConfig = new DiagnosticConfig();
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.DiagnoseRuntimeAsync(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDiagnoseRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntime</summary>
        public void DiagnoseRuntimeResourceNames()
        {
            // Snippet: DiagnoseRuntime(RuntimeName, DiagnosticConfig, CallSettings)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            DiagnosticConfig diagnosticConfig = new DiagnosticConfig();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.DiagnoseRuntime(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDiagnoseRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRuntimeAsync</summary>
        public async Task DiagnoseRuntimeResourceNamesAsync()
        {
            // Snippet: DiagnoseRuntimeAsync(RuntimeName, DiagnosticConfig, CallSettings)
            // Additional: DiagnoseRuntimeAsync(RuntimeName, DiagnosticConfig, CancellationToken)
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = await ManagedNotebookServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeName name = RuntimeName.FromProjectLocationRuntime("[PROJECT]", "[LOCATION]", "[RUNTIME]");
            DiagnosticConfig diagnosticConfig = new DiagnosticConfig();
            // Make the request
            Operation<Runtime, OperationMetadata> response = await managedNotebookServiceClient.DiagnoseRuntimeAsync(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = await managedNotebookServiceClient.PollOnceDiagnoseRuntimeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
