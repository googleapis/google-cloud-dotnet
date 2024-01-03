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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Functions.V2Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFunctionServiceClientSnippets
    {
        /// <summary>Snippet for GetFunction</summary>
        public void GetFunctionRequestObject()
        {
            // Snippet: GetFunction(GetFunctionRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Function response = functionServiceClient.GetFunction(request);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionRequestObjectAsync()
        {
            // Snippet: GetFunctionAsync(GetFunctionRequest, CallSettings)
            // Additional: GetFunctionAsync(GetFunctionRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFunctionRequest request = new GetFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Function response = await functionServiceClient.GetFunctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFunction</summary>
        public void GetFunction()
        {
            // Snippet: GetFunction(string, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Function response = functionServiceClient.GetFunction(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionAsync()
        {
            // Snippet: GetFunctionAsync(string, CallSettings)
            // Additional: GetFunctionAsync(string, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Function response = await functionServiceClient.GetFunctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunction</summary>
        public void GetFunctionResourceNames()
        {
            // Snippet: GetFunction(FunctionName, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            FunctionName name = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Function response = functionServiceClient.GetFunction(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionResourceNamesAsync()
        {
            // Snippet: GetFunctionAsync(FunctionName, CallSettings)
            // Additional: GetFunctionAsync(FunctionName, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            FunctionName name = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Function response = await functionServiceClient.GetFunctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFunctions</summary>
        public void ListFunctionsRequestObject()
        {
            // Snippet: ListFunctions(ListFunctionsRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            ListFunctionsRequest request = new ListFunctionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Function item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFunctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctionsAsync</summary>
        public async Task ListFunctionsRequestObjectAsync()
        {
            // Snippet: ListFunctionsAsync(ListFunctionsRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFunctionsRequest request = new ListFunctionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Function item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFunctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctions</summary>
        public void ListFunctions()
        {
            // Snippet: ListFunctions(string, string, int?, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Function item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFunctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctionsAsync</summary>
        public async Task ListFunctionsAsync()
        {
            // Snippet: ListFunctionsAsync(string, string, int?, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Function item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFunctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctions</summary>
        public void ListFunctionsResourceNames()
        {
            // Snippet: ListFunctions(LocationName, string, int?, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Function item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFunctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctionsAsync</summary>
        public async Task ListFunctionsResourceNamesAsync()
        {
            // Snippet: ListFunctionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFunctionsResponse, Function> response = functionServiceClient.ListFunctionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Function item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFunctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Function item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Function> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Function item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunctionRequestObject()
        {
            // Snippet: CreateFunction(CreateFunctionRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            CreateFunctionRequest request = new CreateFunctionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Function = new Function(),
                FunctionId = "",
            };
            // Make the request
            Operation<Function, OperationMetadata> response = functionServiceClient.CreateFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionRequestObjectAsync()
        {
            // Snippet: CreateFunctionAsync(CreateFunctionRequest, CallSettings)
            // Additional: CreateFunctionAsync(CreateFunctionRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFunctionRequest request = new CreateFunctionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Function = new Function(),
                FunctionId = "",
            };
            // Make the request
            Operation<Function, OperationMetadata> response = await functionServiceClient.CreateFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunction()
        {
            // Snippet: CreateFunction(string, Function, string, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Function function = new Function();
            string functionId = "";
            // Make the request
            Operation<Function, OperationMetadata> response = functionServiceClient.CreateFunction(parent, function, functionId);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionAsync()
        {
            // Snippet: CreateFunctionAsync(string, Function, string, CallSettings)
            // Additional: CreateFunctionAsync(string, Function, string, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Function function = new Function();
            string functionId = "";
            // Make the request
            Operation<Function, OperationMetadata> response = await functionServiceClient.CreateFunctionAsync(parent, function, functionId);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunctionResourceNames()
        {
            // Snippet: CreateFunction(LocationName, Function, string, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Function function = new Function();
            string functionId = "";
            // Make the request
            Operation<Function, OperationMetadata> response = functionServiceClient.CreateFunction(parent, function, functionId);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionResourceNamesAsync()
        {
            // Snippet: CreateFunctionAsync(LocationName, Function, string, CallSettings)
            // Additional: CreateFunctionAsync(LocationName, Function, string, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Function function = new Function();
            string functionId = "";
            // Make the request
            Operation<Function, OperationMetadata> response = await functionServiceClient.CreateFunctionAsync(parent, function, functionId);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunction</summary>
        public void UpdateFunctionRequestObject()
        {
            // Snippet: UpdateFunction(UpdateFunctionRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            UpdateFunctionRequest request = new UpdateFunctionRequest
            {
                Function = new Function(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Function, OperationMetadata> response = functionServiceClient.UpdateFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceUpdateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunctionAsync</summary>
        public async Task UpdateFunctionRequestObjectAsync()
        {
            // Snippet: UpdateFunctionAsync(UpdateFunctionRequest, CallSettings)
            // Additional: UpdateFunctionAsync(UpdateFunctionRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFunctionRequest request = new UpdateFunctionRequest
            {
                Function = new Function(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Function, OperationMetadata> response = await functionServiceClient.UpdateFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceUpdateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunction</summary>
        public void UpdateFunction()
        {
            // Snippet: UpdateFunction(Function, FieldMask, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            Function function = new Function();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Function, OperationMetadata> response = functionServiceClient.UpdateFunction(function, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceUpdateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunctionAsync</summary>
        public async Task UpdateFunctionAsync()
        {
            // Snippet: UpdateFunctionAsync(Function, FieldMask, CallSettings)
            // Additional: UpdateFunctionAsync(Function, FieldMask, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            Function function = new Function();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Function, OperationMetadata> response = await functionServiceClient.UpdateFunctionAsync(function, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Function, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Function result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Function, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceUpdateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Function retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunctionRequestObject()
        {
            // Snippet: DeleteFunction(DeleteFunctionRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            DeleteFunctionRequest request = new DeleteFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = functionServiceClient.DeleteFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionRequestObjectAsync()
        {
            // Snippet: DeleteFunctionAsync(DeleteFunctionRequest, CallSettings)
            // Additional: DeleteFunctionAsync(DeleteFunctionRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFunctionRequest request = new DeleteFunctionRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await functionServiceClient.DeleteFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunction()
        {
            // Snippet: DeleteFunction(string, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = functionServiceClient.DeleteFunction(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionAsync()
        {
            // Snippet: DeleteFunctionAsync(string, CallSettings)
            // Additional: DeleteFunctionAsync(string, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await functionServiceClient.DeleteFunctionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunctionResourceNames()
        {
            // Snippet: DeleteFunction(FunctionName, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            FunctionName name = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = functionServiceClient.DeleteFunction(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = functionServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionResourceNamesAsync()
        {
            // Snippet: DeleteFunctionAsync(FunctionName, CallSettings)
            // Additional: DeleteFunctionAsync(FunctionName, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            FunctionName name = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await functionServiceClient.DeleteFunctionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await functionServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateUploadUrl</summary>
        public void GenerateUploadUrlRequestObject()
        {
            // Snippet: GenerateUploadUrl(GenerateUploadUrlRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            GenerateUploadUrlResponse response = functionServiceClient.GenerateUploadUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateUploadUrlAsync</summary>
        public async Task GenerateUploadUrlRequestObjectAsync()
        {
            // Snippet: GenerateUploadUrlAsync(GenerateUploadUrlRequest, CallSettings)
            // Additional: GenerateUploadUrlAsync(GenerateUploadUrlRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            GenerateUploadUrlResponse response = await functionServiceClient.GenerateUploadUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDownloadUrl</summary>
        public void GenerateDownloadUrlRequestObject()
        {
            // Snippet: GenerateDownloadUrl(GenerateDownloadUrlRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            GenerateDownloadUrlResponse response = functionServiceClient.GenerateDownloadUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDownloadUrlAsync</summary>
        public async Task GenerateDownloadUrlRequestObjectAsync()
        {
            // Snippet: GenerateDownloadUrlAsync(GenerateDownloadUrlRequest, CallSettings)
            // Additional: GenerateDownloadUrlAsync(GenerateDownloadUrlRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                FunctionName = FunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            GenerateDownloadUrlResponse response = await functionServiceClient.GenerateDownloadUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimesRequestObject()
        {
            // Snippet: ListRuntimes(ListRuntimesRequest, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            ListRuntimesResponse response = functionServiceClient.ListRuntimes(request);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesRequestObjectAsync()
        {
            // Snippet: ListRuntimesAsync(ListRuntimesRequest, CallSettings)
            // Additional: ListRuntimesAsync(ListRuntimesRequest, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuntimesRequest request = new ListRuntimesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            ListRuntimesResponse response = await functionServiceClient.ListRuntimesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimes()
        {
            // Snippet: ListRuntimes(string, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListRuntimesResponse response = functionServiceClient.ListRuntimes(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesAsync()
        {
            // Snippet: ListRuntimesAsync(string, CallSettings)
            // Additional: ListRuntimesAsync(string, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListRuntimesResponse response = await functionServiceClient.ListRuntimesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimes</summary>
        public void ListRuntimesResourceNames()
        {
            // Snippet: ListRuntimes(LocationName, CallSettings)
            // Create client
            FunctionServiceClient functionServiceClient = FunctionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListRuntimesResponse response = functionServiceClient.ListRuntimes(parent);
            // End snippet
        }

        /// <summary>Snippet for ListRuntimesAsync</summary>
        public async Task ListRuntimesResourceNamesAsync()
        {
            // Snippet: ListRuntimesAsync(LocationName, CallSettings)
            // Additional: ListRuntimesAsync(LocationName, CancellationToken)
            // Create client
            FunctionServiceClient functionServiceClient = await FunctionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListRuntimesResponse response = await functionServiceClient.ListRuntimesAsync(parent);
            // End snippet
        }
    }
}
