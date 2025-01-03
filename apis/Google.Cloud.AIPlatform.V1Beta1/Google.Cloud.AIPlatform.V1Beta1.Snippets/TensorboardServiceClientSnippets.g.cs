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
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTensorboardServiceClientSnippets
    {
        /// <summary>Snippet for CreateTensorboard</summary>
        public void CreateTensorboardRequestObject()
        {
            // Snippet: CreateTensorboard(CreateTensorboardRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            CreateTensorboardRequest request = new CreateTensorboardRequest
            {
                ParentAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                Tensorboard = new Tensorboard(),
            };
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = tensorboardServiceClient.CreateTensorboard(request);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceCreateTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardAsync</summary>
        public async Task CreateTensorboardRequestObjectAsync()
        {
            // Snippet: CreateTensorboardAsync(CreateTensorboardRequest, CallSettings)
            // Additional: CreateTensorboardAsync(CreateTensorboardRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTensorboardRequest request = new CreateTensorboardRequest
            {
                ParentAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                Tensorboard = new Tensorboard(),
            };
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = await tensorboardServiceClient.CreateTensorboardAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceCreateTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboard</summary>
        public void CreateTensorboard()
        {
            // Snippet: CreateTensorboard(string, Tensorboard, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            Tensorboard tensorboard = new Tensorboard();
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = tensorboardServiceClient.CreateTensorboard(parent, tensorboard);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceCreateTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardAsync</summary>
        public async Task CreateTensorboardAsync()
        {
            // Snippet: CreateTensorboardAsync(string, Tensorboard, CallSettings)
            // Additional: CreateTensorboardAsync(string, Tensorboard, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            Tensorboard tensorboard = new Tensorboard();
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = await tensorboardServiceClient.CreateTensorboardAsync(parent, tensorboard);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceCreateTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboard</summary>
        public void CreateTensorboardResourceNames()
        {
            // Snippet: CreateTensorboard(TensorboardName, Tensorboard, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName parent = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            Tensorboard tensorboard = new Tensorboard();
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = tensorboardServiceClient.CreateTensorboard(parent, tensorboard);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceCreateTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardAsync</summary>
        public async Task CreateTensorboardResourceNamesAsync()
        {
            // Snippet: CreateTensorboardAsync(TensorboardName, Tensorboard, CallSettings)
            // Additional: CreateTensorboardAsync(TensorboardName, Tensorboard, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName parent = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            Tensorboard tensorboard = new Tensorboard();
            // Make the request
            Operation<Tensorboard, CreateTensorboardOperationMetadata> response = await tensorboardServiceClient.CreateTensorboardAsync(parent, tensorboard);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, CreateTensorboardOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, CreateTensorboardOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceCreateTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetTensorboard</summary>
        public void GetTensorboardRequestObject()
        {
            // Snippet: GetTensorboard(GetTensorboardRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            Tensorboard response = tensorboardServiceClient.GetTensorboard(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardAsync</summary>
        public async Task GetTensorboardRequestObjectAsync()
        {
            // Snippet: GetTensorboardAsync(GetTensorboardRequest, CallSettings)
            // Additional: GetTensorboardAsync(GetTensorboardRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTensorboardRequest request = new GetTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            Tensorboard response = await tensorboardServiceClient.GetTensorboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboard</summary>
        public void GetTensorboard()
        {
            // Snippet: GetTensorboard(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            Tensorboard response = tensorboardServiceClient.GetTensorboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardAsync</summary>
        public async Task GetTensorboardAsync()
        {
            // Snippet: GetTensorboardAsync(string, CallSettings)
            // Additional: GetTensorboardAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            Tensorboard response = await tensorboardServiceClient.GetTensorboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboard</summary>
        public void GetTensorboardResourceNames()
        {
            // Snippet: GetTensorboard(TensorboardName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName name = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            Tensorboard response = tensorboardServiceClient.GetTensorboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardAsync</summary>
        public async Task GetTensorboardResourceNamesAsync()
        {
            // Snippet: GetTensorboardAsync(TensorboardName, CallSettings)
            // Additional: GetTensorboardAsync(TensorboardName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName name = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            Tensorboard response = await tensorboardServiceClient.GetTensorboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboard</summary>
        public void UpdateTensorboardRequestObject()
        {
            // Snippet: UpdateTensorboard(UpdateTensorboardRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            UpdateTensorboardRequest request = new UpdateTensorboardRequest
            {
                UpdateMask = new FieldMask(),
                Tensorboard = new Tensorboard(),
            };
            // Make the request
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> response = tensorboardServiceClient.UpdateTensorboard(request);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceUpdateTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardAsync</summary>
        public async Task UpdateTensorboardRequestObjectAsync()
        {
            // Snippet: UpdateTensorboardAsync(UpdateTensorboardRequest, CallSettings)
            // Additional: UpdateTensorboardAsync(UpdateTensorboardRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTensorboardRequest request = new UpdateTensorboardRequest
            {
                UpdateMask = new FieldMask(),
                Tensorboard = new Tensorboard(),
            };
            // Make the request
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> response = await tensorboardServiceClient.UpdateTensorboardAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceUpdateTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboard</summary>
        public void UpdateTensorboard()
        {
            // Snippet: UpdateTensorboard(Tensorboard, FieldMask, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            Tensorboard tensorboard = new Tensorboard();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> response = tensorboardServiceClient.UpdateTensorboard(tensorboard, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceUpdateTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardAsync</summary>
        public async Task UpdateTensorboardAsync()
        {
            // Snippet: UpdateTensorboardAsync(Tensorboard, FieldMask, CallSettings)
            // Additional: UpdateTensorboardAsync(Tensorboard, FieldMask, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            Tensorboard tensorboard = new Tensorboard();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> response = await tensorboardServiceClient.UpdateTensorboardAsync(tensorboard, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Tensorboard result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Tensorboard, UpdateTensorboardOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceUpdateTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Tensorboard retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTensorboards</summary>
        public void ListTensorboardsRequestObject()
        {
            // Snippet: ListTensorboards(ListTensorboardsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ListTensorboardsRequest request = new ListTensorboardsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboards(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tensorboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardsAsync</summary>
        public async Task ListTensorboardsRequestObjectAsync()
        {
            // Snippet: ListTensorboardsAsync(ListTensorboardsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTensorboardsRequest request = new ListTensorboardsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboardsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tensorboard item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboards</summary>
        public void ListTensorboards()
        {
            // Snippet: ListTensorboards(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tensorboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardsAsync</summary>
        public async Task ListTensorboardsAsync()
        {
            // Snippet: ListTensorboardsAsync(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tensorboard item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboards</summary>
        public void ListTensorboardsResourceNames()
        {
            // Snippet: ListTensorboards(LocationName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tensorboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardsAsync</summary>
        public async Task ListTensorboardsResourceNamesAsync()
        {
            // Snippet: ListTensorboardsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTensorboardsResponse, Tensorboard> response = tensorboardServiceClient.ListTensorboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tensorboard item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tensorboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tensorboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tensorboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboard</summary>
        public void DeleteTensorboardRequestObject()
        {
            // Snippet: DeleteTensorboard(DeleteTensorboardRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            DeleteTensorboardRequest request = new DeleteTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboard(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardAsync</summary>
        public async Task DeleteTensorboardRequestObjectAsync()
        {
            // Snippet: DeleteTensorboardAsync(DeleteTensorboardRequest, CallSettings)
            // Additional: DeleteTensorboardAsync(DeleteTensorboardRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTensorboardRequest request = new DeleteTensorboardRequest
            {
                TensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboard</summary>
        public void DeleteTensorboard()
        {
            // Snippet: DeleteTensorboard(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboard(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardAsync</summary>
        public async Task DeleteTensorboardAsync()
        {
            // Snippet: DeleteTensorboardAsync(string, CallSettings)
            // Additional: DeleteTensorboardAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboard</summary>
        public void DeleteTensorboardResourceNames()
        {
            // Snippet: DeleteTensorboard(TensorboardName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName name = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboard(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboard(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardAsync</summary>
        public async Task DeleteTensorboardResourceNamesAsync()
        {
            // Snippet: DeleteTensorboardAsync(TensorboardName, CallSettings)
            // Additional: DeleteTensorboardAsync(TensorboardName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName name = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsage</summary>
        public void ReadTensorboardUsageRequestObject()
        {
            // Snippet: ReadTensorboardUsage(ReadTensorboardUsageRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ReadTensorboardUsageRequest request = new ReadTensorboardUsageRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            ReadTensorboardUsageResponse response = tensorboardServiceClient.ReadTensorboardUsage(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsageAsync</summary>
        public async Task ReadTensorboardUsageRequestObjectAsync()
        {
            // Snippet: ReadTensorboardUsageAsync(ReadTensorboardUsageRequest, CallSettings)
            // Additional: ReadTensorboardUsageAsync(ReadTensorboardUsageRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReadTensorboardUsageRequest request = new ReadTensorboardUsageRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            ReadTensorboardUsageResponse response = await tensorboardServiceClient.ReadTensorboardUsageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsage</summary>
        public void ReadTensorboardUsage()
        {
            // Snippet: ReadTensorboardUsage(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            ReadTensorboardUsageResponse response = tensorboardServiceClient.ReadTensorboardUsage(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsageAsync</summary>
        public async Task ReadTensorboardUsageAsync()
        {
            // Snippet: ReadTensorboardUsageAsync(string, CallSettings)
            // Additional: ReadTensorboardUsageAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            ReadTensorboardUsageResponse response = await tensorboardServiceClient.ReadTensorboardUsageAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsage</summary>
        public void ReadTensorboardUsageResourceNames()
        {
            // Snippet: ReadTensorboardUsage(TensorboardName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            ReadTensorboardUsageResponse response = tensorboardServiceClient.ReadTensorboardUsage(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardUsageAsync</summary>
        public async Task ReadTensorboardUsageResourceNamesAsync()
        {
            // Snippet: ReadTensorboardUsageAsync(TensorboardName, CallSettings)
            // Additional: ReadTensorboardUsageAsync(TensorboardName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            ReadTensorboardUsageResponse response = await tensorboardServiceClient.ReadTensorboardUsageAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSize</summary>
        public void ReadTensorboardSizeRequestObject()
        {
            // Snippet: ReadTensorboardSize(ReadTensorboardSizeRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ReadTensorboardSizeRequest request = new ReadTensorboardSizeRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            ReadTensorboardSizeResponse response = tensorboardServiceClient.ReadTensorboardSize(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSizeAsync</summary>
        public async Task ReadTensorboardSizeRequestObjectAsync()
        {
            // Snippet: ReadTensorboardSizeAsync(ReadTensorboardSizeRequest, CallSettings)
            // Additional: ReadTensorboardSizeAsync(ReadTensorboardSizeRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReadTensorboardSizeRequest request = new ReadTensorboardSizeRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
            };
            // Make the request
            ReadTensorboardSizeResponse response = await tensorboardServiceClient.ReadTensorboardSizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSize</summary>
        public void ReadTensorboardSize()
        {
            // Snippet: ReadTensorboardSize(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            ReadTensorboardSizeResponse response = tensorboardServiceClient.ReadTensorboardSize(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSizeAsync</summary>
        public async Task ReadTensorboardSizeAsync()
        {
            // Snippet: ReadTensorboardSizeAsync(string, CallSettings)
            // Additional: ReadTensorboardSizeAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            ReadTensorboardSizeResponse response = await tensorboardServiceClient.ReadTensorboardSizeAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSize</summary>
        public void ReadTensorboardSizeResourceNames()
        {
            // Snippet: ReadTensorboardSize(TensorboardName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            ReadTensorboardSizeResponse response = tensorboardServiceClient.ReadTensorboardSize(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardSizeAsync</summary>
        public async Task ReadTensorboardSizeResourceNamesAsync()
        {
            // Snippet: ReadTensorboardSizeAsync(TensorboardName, CallSettings)
            // Additional: ReadTensorboardSizeAsync(TensorboardName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            ReadTensorboardSizeResponse response = await tensorboardServiceClient.ReadTensorboardSizeAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperiment</summary>
        public void CreateTensorboardExperimentRequestObject()
        {
            // Snippet: CreateTensorboardExperiment(CreateTensorboardExperimentRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "",
            };
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.CreateTensorboardExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperimentAsync</summary>
        public async Task CreateTensorboardExperimentRequestObjectAsync()
        {
            // Snippet: CreateTensorboardExperimentAsync(CreateTensorboardExperimentRequest, CallSettings)
            // Additional: CreateTensorboardExperimentAsync(CreateTensorboardExperimentRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTensorboardExperimentRequest request = new CreateTensorboardExperimentRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                TensorboardExperiment = new TensorboardExperiment(),
                TensorboardExperimentId = "",
            };
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.CreateTensorboardExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperiment</summary>
        public void CreateTensorboardExperiment()
        {
            // Snippet: CreateTensorboardExperiment(string, TensorboardExperiment, string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            string tensorboardExperimentId = "";
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.CreateTensorboardExperiment(parent, tensorboardExperiment, tensorboardExperimentId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperimentAsync</summary>
        public async Task CreateTensorboardExperimentAsync()
        {
            // Snippet: CreateTensorboardExperimentAsync(string, TensorboardExperiment, string, CallSettings)
            // Additional: CreateTensorboardExperimentAsync(string, TensorboardExperiment, string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            string tensorboardExperimentId = "";
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.CreateTensorboardExperimentAsync(parent, tensorboardExperiment, tensorboardExperimentId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperiment</summary>
        public void CreateTensorboardExperimentResourceNames()
        {
            // Snippet: CreateTensorboardExperiment(TensorboardExperimentName, TensorboardExperiment, string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            string tensorboardExperimentId = "";
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.CreateTensorboardExperiment(parent, tensorboardExperiment, tensorboardExperimentId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardExperimentAsync</summary>
        public async Task CreateTensorboardExperimentResourceNamesAsync()
        {
            // Snippet: CreateTensorboardExperimentAsync(TensorboardExperimentName, TensorboardExperiment, string, CallSettings)
            // Additional: CreateTensorboardExperimentAsync(TensorboardExperimentName, TensorboardExperiment, string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            string tensorboardExperimentId = "";
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.CreateTensorboardExperimentAsync(parent, tensorboardExperiment, tensorboardExperimentId);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperiment</summary>
        public void GetTensorboardExperimentRequestObject()
        {
            // Snippet: GetTensorboardExperiment(GetTensorboardExperimentRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.GetTensorboardExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperimentAsync</summary>
        public async Task GetTensorboardExperimentRequestObjectAsync()
        {
            // Snippet: GetTensorboardExperimentAsync(GetTensorboardExperimentRequest, CallSettings)
            // Additional: GetTensorboardExperimentAsync(GetTensorboardExperimentRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTensorboardExperimentRequest request = new GetTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.GetTensorboardExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperiment</summary>
        public void GetTensorboardExperiment()
        {
            // Snippet: GetTensorboardExperiment(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.GetTensorboardExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperimentAsync</summary>
        public async Task GetTensorboardExperimentAsync()
        {
            // Snippet: GetTensorboardExperimentAsync(string, CallSettings)
            // Additional: GetTensorboardExperimentAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.GetTensorboardExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperiment</summary>
        public void GetTensorboardExperimentResourceNames()
        {
            // Snippet: GetTensorboardExperiment(TensorboardExperimentName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName name = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.GetTensorboardExperiment(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardExperimentAsync</summary>
        public async Task GetTensorboardExperimentResourceNamesAsync()
        {
            // Snippet: GetTensorboardExperimentAsync(TensorboardExperimentName, CallSettings)
            // Additional: GetTensorboardExperimentAsync(TensorboardExperimentName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName name = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.GetTensorboardExperimentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardExperiment</summary>
        public void UpdateTensorboardExperimentRequestObject()
        {
            // Snippet: UpdateTensorboardExperiment(UpdateTensorboardExperimentRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.UpdateTensorboardExperiment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardExperimentAsync</summary>
        public async Task UpdateTensorboardExperimentRequestObjectAsync()
        {
            // Snippet: UpdateTensorboardExperimentAsync(UpdateTensorboardExperimentRequest, CallSettings)
            // Additional: UpdateTensorboardExperimentAsync(UpdateTensorboardExperimentRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTensorboardExperimentRequest request = new UpdateTensorboardExperimentRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardExperiment = new TensorboardExperiment(),
            };
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.UpdateTensorboardExperimentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardExperiment</summary>
        public void UpdateTensorboardExperiment()
        {
            // Snippet: UpdateTensorboardExperiment(TensorboardExperiment, FieldMask, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardExperiment response = tensorboardServiceClient.UpdateTensorboardExperiment(tensorboardExperiment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardExperimentAsync</summary>
        public async Task UpdateTensorboardExperimentAsync()
        {
            // Snippet: UpdateTensorboardExperimentAsync(TensorboardExperiment, FieldMask, CallSettings)
            // Additional: UpdateTensorboardExperimentAsync(TensorboardExperiment, FieldMask, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperiment tensorboardExperiment = new TensorboardExperiment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardExperiment response = await tensorboardServiceClient.UpdateTensorboardExperimentAsync(tensorboardExperiment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperiments</summary>
        public void ListTensorboardExperimentsRequestObject()
        {
            // Snippet: ListTensorboardExperiments(ListTensorboardExperimentsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
            {
                ParentAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperiments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardExperiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperimentsAsync</summary>
        public async Task ListTensorboardExperimentsRequestObjectAsync()
        {
            // Snippet: ListTensorboardExperimentsAsync(ListTensorboardExperimentsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTensorboardExperimentsRequest request = new ListTensorboardExperimentsRequest
            {
                ParentAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperimentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardExperiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperiments</summary>
        public void ListTensorboardExperiments()
        {
            // Snippet: ListTensorboardExperiments(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperiments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardExperiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperimentsAsync</summary>
        public async Task ListTensorboardExperimentsAsync()
        {
            // Snippet: ListTensorboardExperimentsAsync(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperimentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardExperiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperiments</summary>
        public void ListTensorboardExperimentsResourceNames()
        {
            // Snippet: ListTensorboardExperiments(TensorboardName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName parent = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            PagedEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperiments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardExperiment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardExperimentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardExperimentsAsync</summary>
        public async Task ListTensorboardExperimentsResourceNamesAsync()
        {
            // Snippet: ListTensorboardExperimentsAsync(TensorboardName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName parent = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            PagedAsyncEnumerable<ListTensorboardExperimentsResponse, TensorboardExperiment> response = tensorboardServiceClient.ListTensorboardExperimentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardExperiment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardExperimentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardExperiment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardExperiment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardExperiment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperiment</summary>
        public void DeleteTensorboardExperimentRequestObject()
        {
            // Snippet: DeleteTensorboardExperiment(DeleteTensorboardExperimentRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            DeleteTensorboardExperimentRequest request = new DeleteTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardExperiment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperimentAsync</summary>
        public async Task DeleteTensorboardExperimentRequestObjectAsync()
        {
            // Snippet: DeleteTensorboardExperimentAsync(DeleteTensorboardExperimentRequest, CallSettings)
            // Additional: DeleteTensorboardExperimentAsync(DeleteTensorboardExperimentRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTensorboardExperimentRequest request = new DeleteTensorboardExperimentRequest
            {
                TensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardExperimentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperiment</summary>
        public void DeleteTensorboardExperiment()
        {
            // Snippet: DeleteTensorboardExperiment(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardExperiment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperimentAsync</summary>
        public async Task DeleteTensorboardExperimentAsync()
        {
            // Snippet: DeleteTensorboardExperimentAsync(string, CallSettings)
            // Additional: DeleteTensorboardExperimentAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardExperimentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperiment</summary>
        public void DeleteTensorboardExperimentResourceNames()
        {
            // Snippet: DeleteTensorboardExperiment(TensorboardExperimentName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName name = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardExperiment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardExperiment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardExperimentAsync</summary>
        public async Task DeleteTensorboardExperimentResourceNamesAsync()
        {
            // Snippet: DeleteTensorboardExperimentAsync(TensorboardExperimentName, CallSettings)
            // Additional: DeleteTensorboardExperimentAsync(TensorboardExperimentName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName name = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardExperimentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardExperimentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRun</summary>
        public void CreateTensorboardRunRequestObject()
        {
            // Snippet: CreateTensorboardRun(CreateTensorboardRunRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "",
            };
            // Make the request
            TensorboardRun response = tensorboardServiceClient.CreateTensorboardRun(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRunAsync</summary>
        public async Task CreateTensorboardRunRequestObjectAsync()
        {
            // Snippet: CreateTensorboardRunAsync(CreateTensorboardRunRequest, CallSettings)
            // Additional: CreateTensorboardRunAsync(CreateTensorboardRunRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTensorboardRunRequest request = new CreateTensorboardRunRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TensorboardRun = new TensorboardRun(),
                TensorboardRunId = "",
            };
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.CreateTensorboardRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRun</summary>
        public void CreateTensorboardRun()
        {
            // Snippet: CreateTensorboardRun(string, TensorboardRun, string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            TensorboardRun tensorboardRun = new TensorboardRun();
            string tensorboardRunId = "";
            // Make the request
            TensorboardRun response = tensorboardServiceClient.CreateTensorboardRun(parent, tensorboardRun, tensorboardRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRunAsync</summary>
        public async Task CreateTensorboardRunAsync()
        {
            // Snippet: CreateTensorboardRunAsync(string, TensorboardRun, string, CallSettings)
            // Additional: CreateTensorboardRunAsync(string, TensorboardRun, string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            TensorboardRun tensorboardRun = new TensorboardRun();
            string tensorboardRunId = "";
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.CreateTensorboardRunAsync(parent, tensorboardRun, tensorboardRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRun</summary>
        public void CreateTensorboardRunResourceNames()
        {
            // Snippet: CreateTensorboardRun(TensorboardRunName, TensorboardRun, string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName parent = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            TensorboardRun tensorboardRun = new TensorboardRun();
            string tensorboardRunId = "";
            // Make the request
            TensorboardRun response = tensorboardServiceClient.CreateTensorboardRun(parent, tensorboardRun, tensorboardRunId);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardRunAsync</summary>
        public async Task CreateTensorboardRunResourceNamesAsync()
        {
            // Snippet: CreateTensorboardRunAsync(TensorboardRunName, TensorboardRun, string, CallSettings)
            // Additional: CreateTensorboardRunAsync(TensorboardRunName, TensorboardRun, string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRunName parent = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            TensorboardRun tensorboardRun = new TensorboardRun();
            string tensorboardRunId = "";
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.CreateTensorboardRunAsync(parent, tensorboardRun, tensorboardRunId);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRuns</summary>
        public void BatchCreateTensorboardRunsRequestObject()
        {
            // Snippet: BatchCreateTensorboardRuns(BatchCreateTensorboardRunsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = tensorboardServiceClient.BatchCreateTensorboardRuns(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRunsAsync</summary>
        public async Task BatchCreateTensorboardRunsRequestObjectAsync()
        {
            // Snippet: BatchCreateTensorboardRunsAsync(BatchCreateTensorboardRunsRequest, CallSettings)
            // Additional: BatchCreateTensorboardRunsAsync(BatchCreateTensorboardRunsRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTensorboardRunsRequest request = new BatchCreateTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardRunRequest(),
                },
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = await tensorboardServiceClient.BatchCreateTensorboardRunsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRuns</summary>
        public void BatchCreateTensorboardRuns()
        {
            // Snippet: BatchCreateTensorboardRuns(string, IEnumerable<CreateTensorboardRunRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<CreateTensorboardRunRequest> requests = new CreateTensorboardRunRequest[]
            {
                new CreateTensorboardRunRequest(),
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = tensorboardServiceClient.BatchCreateTensorboardRuns(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRunsAsync</summary>
        public async Task BatchCreateTensorboardRunsAsync()
        {
            // Snippet: BatchCreateTensorboardRunsAsync(string, IEnumerable<CreateTensorboardRunRequest>, CallSettings)
            // Additional: BatchCreateTensorboardRunsAsync(string, IEnumerable<CreateTensorboardRunRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<CreateTensorboardRunRequest> requests = new CreateTensorboardRunRequest[]
            {
                new CreateTensorboardRunRequest(),
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = await tensorboardServiceClient.BatchCreateTensorboardRunsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRuns</summary>
        public void BatchCreateTensorboardRunsResourceNames()
        {
            // Snippet: BatchCreateTensorboardRuns(TensorboardExperimentName, IEnumerable<CreateTensorboardRunRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<CreateTensorboardRunRequest> requests = new CreateTensorboardRunRequest[]
            {
                new CreateTensorboardRunRequest(),
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = tensorboardServiceClient.BatchCreateTensorboardRuns(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardRunsAsync</summary>
        public async Task BatchCreateTensorboardRunsResourceNamesAsync()
        {
            // Snippet: BatchCreateTensorboardRunsAsync(TensorboardExperimentName, IEnumerable<CreateTensorboardRunRequest>, CallSettings)
            // Additional: BatchCreateTensorboardRunsAsync(TensorboardExperimentName, IEnumerable<CreateTensorboardRunRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<CreateTensorboardRunRequest> requests = new CreateTensorboardRunRequest[]
            {
                new CreateTensorboardRunRequest(),
            };
            // Make the request
            BatchCreateTensorboardRunsResponse response = await tensorboardServiceClient.BatchCreateTensorboardRunsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRun</summary>
        public void GetTensorboardRunRequestObject()
        {
            // Snippet: GetTensorboardRun(GetTensorboardRunRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            // Make the request
            TensorboardRun response = tensorboardServiceClient.GetTensorboardRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRunAsync</summary>
        public async Task GetTensorboardRunRequestObjectAsync()
        {
            // Snippet: GetTensorboardRunAsync(GetTensorboardRunRequest, CallSettings)
            // Additional: GetTensorboardRunAsync(GetTensorboardRunRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTensorboardRunRequest request = new GetTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.GetTensorboardRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRun</summary>
        public void GetTensorboardRun()
        {
            // Snippet: GetTensorboardRun(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            TensorboardRun response = tensorboardServiceClient.GetTensorboardRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRunAsync</summary>
        public async Task GetTensorboardRunAsync()
        {
            // Snippet: GetTensorboardRunAsync(string, CallSettings)
            // Additional: GetTensorboardRunAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.GetTensorboardRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRun</summary>
        public void GetTensorboardRunResourceNames()
        {
            // Snippet: GetTensorboardRun(TensorboardRunName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName name = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            TensorboardRun response = tensorboardServiceClient.GetTensorboardRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardRunAsync</summary>
        public async Task GetTensorboardRunResourceNamesAsync()
        {
            // Snippet: GetTensorboardRunAsync(TensorboardRunName, CallSettings)
            // Additional: GetTensorboardRunAsync(TensorboardRunName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRunName name = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.GetTensorboardRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardRun</summary>
        public void UpdateTensorboardRunRequestObject()
        {
            // Snippet: UpdateTensorboardRun(UpdateTensorboardRunRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            // Make the request
            TensorboardRun response = tensorboardServiceClient.UpdateTensorboardRun(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardRunAsync</summary>
        public async Task UpdateTensorboardRunRequestObjectAsync()
        {
            // Snippet: UpdateTensorboardRunAsync(UpdateTensorboardRunRequest, CallSettings)
            // Additional: UpdateTensorboardRunAsync(UpdateTensorboardRunRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTensorboardRunRequest request = new UpdateTensorboardRunRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardRun = new TensorboardRun(),
            };
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.UpdateTensorboardRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardRun</summary>
        public void UpdateTensorboardRun()
        {
            // Snippet: UpdateTensorboardRun(TensorboardRun, FieldMask, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRun tensorboardRun = new TensorboardRun();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardRun response = tensorboardServiceClient.UpdateTensorboardRun(tensorboardRun, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardRunAsync</summary>
        public async Task UpdateTensorboardRunAsync()
        {
            // Snippet: UpdateTensorboardRunAsync(TensorboardRun, FieldMask, CallSettings)
            // Additional: UpdateTensorboardRunAsync(TensorboardRun, FieldMask, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRun tensorboardRun = new TensorboardRun();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardRun response = await tensorboardServiceClient.UpdateTensorboardRunAsync(tensorboardRun, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRuns</summary>
        public void ListTensorboardRunsRequestObject()
        {
            // Snippet: ListTensorboardRuns(ListTensorboardRunsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRunsAsync</summary>
        public async Task ListTensorboardRunsRequestObjectAsync()
        {
            // Snippet: ListTensorboardRunsAsync(ListTensorboardRunsRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTensorboardRunsRequest request = new ListTensorboardRunsRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRuns</summary>
        public void ListTensorboardRuns()
        {
            // Snippet: ListTensorboardRuns(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRunsAsync</summary>
        public async Task ListTensorboardRunsAsync()
        {
            // Snippet: ListTensorboardRunsAsync(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            // Make the request
            PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRuns</summary>
        public void ListTensorboardRunsResourceNames()
        {
            // Snippet: ListTensorboardRuns(TensorboardExperimentName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            PagedEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardRunsAsync</summary>
        public async Task ListTensorboardRunsResourceNamesAsync()
        {
            // Snippet: ListTensorboardRunsAsync(TensorboardExperimentName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            // Make the request
            PagedAsyncEnumerable<ListTensorboardRunsResponse, TensorboardRun> response = tensorboardServiceClient.ListTensorboardRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRun</summary>
        public void DeleteTensorboardRunRequestObject()
        {
            // Snippet: DeleteTensorboardRun(DeleteTensorboardRunRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            DeleteTensorboardRunRequest request = new DeleteTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardRun(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRunAsync</summary>
        public async Task DeleteTensorboardRunRequestObjectAsync()
        {
            // Snippet: DeleteTensorboardRunAsync(DeleteTensorboardRunRequest, CallSettings)
            // Additional: DeleteTensorboardRunAsync(DeleteTensorboardRunRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTensorboardRunRequest request = new DeleteTensorboardRunRequest
            {
                TensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardRunAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRun</summary>
        public void DeleteTensorboardRun()
        {
            // Snippet: DeleteTensorboardRun(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRunAsync</summary>
        public async Task DeleteTensorboardRunAsync()
        {
            // Snippet: DeleteTensorboardRunAsync(string, CallSettings)
            // Additional: DeleteTensorboardRunAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRun</summary>
        public void DeleteTensorboardRunResourceNames()
        {
            // Snippet: DeleteTensorboardRun(TensorboardRunName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName name = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardRunAsync</summary>
        public async Task DeleteTensorboardRunResourceNamesAsync()
        {
            // Snippet: DeleteTensorboardRunAsync(TensorboardRunName, CallSettings)
            // Additional: DeleteTensorboardRunAsync(TensorboardRunName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRunName name = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardRunAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardRunAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeries</summary>
        public void BatchCreateTensorboardTimeSeriesRequestObject()
        {
            // Snippet: BatchCreateTensorboardTimeSeries(BatchCreateTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = tensorboardServiceClient.BatchCreateTensorboardTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeriesAsync</summary>
        public async Task BatchCreateTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: BatchCreateTensorboardTimeSeriesAsync(BatchCreateTensorboardTimeSeriesRequest, CallSettings)
            // Additional: BatchCreateTensorboardTimeSeriesAsync(BatchCreateTensorboardTimeSeriesRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTensorboardTimeSeriesRequest request = new BatchCreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                Requests =
                {
                    new CreateTensorboardTimeSeriesRequest(),
                },
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = await tensorboardServiceClient.BatchCreateTensorboardTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeries</summary>
        public void BatchCreateTensorboardTimeSeries()
        {
            // Snippet: BatchCreateTensorboardTimeSeries(string, IEnumerable<CreateTensorboardTimeSeriesRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<CreateTensorboardTimeSeriesRequest> requests = new CreateTensorboardTimeSeriesRequest[]
            {
                new CreateTensorboardTimeSeriesRequest(),
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = tensorboardServiceClient.BatchCreateTensorboardTimeSeries(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeriesAsync</summary>
        public async Task BatchCreateTensorboardTimeSeriesAsync()
        {
            // Snippet: BatchCreateTensorboardTimeSeriesAsync(string, IEnumerable<CreateTensorboardTimeSeriesRequest>, CallSettings)
            // Additional: BatchCreateTensorboardTimeSeriesAsync(string, IEnumerable<CreateTensorboardTimeSeriesRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<CreateTensorboardTimeSeriesRequest> requests = new CreateTensorboardTimeSeriesRequest[]
            {
                new CreateTensorboardTimeSeriesRequest(),
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = await tensorboardServiceClient.BatchCreateTensorboardTimeSeriesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeries</summary>
        public void BatchCreateTensorboardTimeSeriesResourceNames()
        {
            // Snippet: BatchCreateTensorboardTimeSeries(TensorboardExperimentName, IEnumerable<CreateTensorboardTimeSeriesRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<CreateTensorboardTimeSeriesRequest> requests = new CreateTensorboardTimeSeriesRequest[]
            {
                new CreateTensorboardTimeSeriesRequest(),
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = tensorboardServiceClient.BatchCreateTensorboardTimeSeries(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTensorboardTimeSeriesAsync</summary>
        public async Task BatchCreateTensorboardTimeSeriesResourceNamesAsync()
        {
            // Snippet: BatchCreateTensorboardTimeSeriesAsync(TensorboardExperimentName, IEnumerable<CreateTensorboardTimeSeriesRequest>, CallSettings)
            // Additional: BatchCreateTensorboardTimeSeriesAsync(TensorboardExperimentName, IEnumerable<CreateTensorboardTimeSeriesRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName parent = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<CreateTensorboardTimeSeriesRequest> requests = new CreateTensorboardTimeSeriesRequest[]
            {
                new CreateTensorboardTimeSeriesRequest(),
            };
            // Make the request
            BatchCreateTensorboardTimeSeriesResponse response = await tensorboardServiceClient.BatchCreateTensorboardTimeSeriesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeries</summary>
        public void CreateTensorboardTimeSeriesRequestObject()
        {
            // Snippet: CreateTensorboardTimeSeries(CreateTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
                TensorboardTimeSeriesId = "",
            };
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.CreateTensorboardTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeriesAsync</summary>
        public async Task CreateTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: CreateTensorboardTimeSeriesAsync(CreateTensorboardTimeSeriesRequest, CallSettings)
            // Additional: CreateTensorboardTimeSeriesAsync(CreateTensorboardTimeSeriesRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTensorboardTimeSeriesRequest request = new CreateTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
                TensorboardTimeSeriesId = "",
            };
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.CreateTensorboardTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeries</summary>
        public void CreateTensorboardTimeSeries()
        {
            // Snippet: CreateTensorboardTimeSeries(string, TensorboardTimeSeries, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.CreateTensorboardTimeSeries(parent, tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeriesAsync</summary>
        public async Task CreateTensorboardTimeSeriesAsync()
        {
            // Snippet: CreateTensorboardTimeSeriesAsync(string, TensorboardTimeSeries, CallSettings)
            // Additional: CreateTensorboardTimeSeriesAsync(string, TensorboardTimeSeries, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.CreateTensorboardTimeSeriesAsync(parent, tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeries</summary>
        public void CreateTensorboardTimeSeriesResourceNames()
        {
            // Snippet: CreateTensorboardTimeSeries(TensorboardTimeSeriesName, TensorboardTimeSeries, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName parent = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.CreateTensorboardTimeSeries(parent, tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTensorboardTimeSeriesAsync</summary>
        public async Task CreateTensorboardTimeSeriesResourceNamesAsync()
        {
            // Snippet: CreateTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, TensorboardTimeSeries, CallSettings)
            // Additional: CreateTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, TensorboardTimeSeries, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeriesName parent = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.CreateTensorboardTimeSeriesAsync(parent, tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeries</summary>
        public void GetTensorboardTimeSeriesRequestObject()
        {
            // Snippet: GetTensorboardTimeSeries(GetTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.GetTensorboardTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeriesAsync</summary>
        public async Task GetTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: GetTensorboardTimeSeriesAsync(GetTensorboardTimeSeriesRequest, CallSettings)
            // Additional: GetTensorboardTimeSeriesAsync(GetTensorboardTimeSeriesRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTensorboardTimeSeriesRequest request = new GetTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.GetTensorboardTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeries</summary>
        public void GetTensorboardTimeSeries()
        {
            // Snippet: GetTensorboardTimeSeries(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.GetTensorboardTimeSeries(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeriesAsync</summary>
        public async Task GetTensorboardTimeSeriesAsync()
        {
            // Snippet: GetTensorboardTimeSeriesAsync(string, CallSettings)
            // Additional: GetTensorboardTimeSeriesAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.GetTensorboardTimeSeriesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeries</summary>
        public void GetTensorboardTimeSeriesResourceNames()
        {
            // Snippet: GetTensorboardTimeSeries(TensorboardTimeSeriesName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName name = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.GetTensorboardTimeSeries(name);
            // End snippet
        }

        /// <summary>Snippet for GetTensorboardTimeSeriesAsync</summary>
        public async Task GetTensorboardTimeSeriesResourceNamesAsync()
        {
            // Snippet: GetTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, CallSettings)
            // Additional: GetTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeriesName name = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.GetTensorboardTimeSeriesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardTimeSeries</summary>
        public void UpdateTensorboardTimeSeriesRequestObject()
        {
            // Snippet: UpdateTensorboardTimeSeries(UpdateTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.UpdateTensorboardTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardTimeSeriesAsync</summary>
        public async Task UpdateTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: UpdateTensorboardTimeSeriesAsync(UpdateTensorboardTimeSeriesRequest, CallSettings)
            // Additional: UpdateTensorboardTimeSeriesAsync(UpdateTensorboardTimeSeriesRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTensorboardTimeSeriesRequest request = new UpdateTensorboardTimeSeriesRequest
            {
                UpdateMask = new FieldMask(),
                TensorboardTimeSeries = new TensorboardTimeSeries(),
            };
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.UpdateTensorboardTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardTimeSeries</summary>
        public void UpdateTensorboardTimeSeries()
        {
            // Snippet: UpdateTensorboardTimeSeries(TensorboardTimeSeries, FieldMask, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardTimeSeries response = tensorboardServiceClient.UpdateTensorboardTimeSeries(tensorboardTimeSeries, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTensorboardTimeSeriesAsync</summary>
        public async Task UpdateTensorboardTimeSeriesAsync()
        {
            // Snippet: UpdateTensorboardTimeSeriesAsync(TensorboardTimeSeries, FieldMask, CallSettings)
            // Additional: UpdateTensorboardTimeSeriesAsync(TensorboardTimeSeries, FieldMask, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeries tensorboardTimeSeries = new TensorboardTimeSeries();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TensorboardTimeSeries response = await tensorboardServiceClient.UpdateTensorboardTimeSeriesAsync(tensorboardTimeSeries, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeries</summary>
        public void ListTensorboardTimeSeriesRequestObject()
        {
            // Snippet: ListTensorboardTimeSeries(ListTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardTimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeriesAsync</summary>
        public async Task ListTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: ListTensorboardTimeSeriesAsync(ListTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTensorboardTimeSeriesRequest request = new ListTensorboardTimeSeriesRequest
            {
                ParentAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                Filter = "",
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardTimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeries</summary>
        public void ListTensorboardTimeSeries()
        {
            // Snippet: ListTensorboardTimeSeries(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardTimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeriesAsync</summary>
        public async Task ListTensorboardTimeSeriesAsync()
        {
            // Snippet: ListTensorboardTimeSeriesAsync(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            // Make the request
            PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardTimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeries</summary>
        public void ListTensorboardTimeSeriesResourceNames()
        {
            // Snippet: ListTensorboardTimeSeries(TensorboardRunName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName parent = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            PagedEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TensorboardTimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTensorboardTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTensorboardTimeSeriesAsync</summary>
        public async Task ListTensorboardTimeSeriesResourceNamesAsync()
        {
            // Snippet: ListTensorboardTimeSeriesAsync(TensorboardRunName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRunName parent = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            // Make the request
            PagedAsyncEnumerable<ListTensorboardTimeSeriesResponse, TensorboardTimeSeries> response = tensorboardServiceClient.ListTensorboardTimeSeriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TensorboardTimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTensorboardTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TensorboardTimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TensorboardTimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TensorboardTimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeries</summary>
        public void DeleteTensorboardTimeSeriesRequestObject()
        {
            // Snippet: DeleteTensorboardTimeSeries(DeleteTensorboardTimeSeriesRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            DeleteTensorboardTimeSeriesRequest request = new DeleteTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardTimeSeries(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeriesAsync</summary>
        public async Task DeleteTensorboardTimeSeriesRequestObjectAsync()
        {
            // Snippet: DeleteTensorboardTimeSeriesAsync(DeleteTensorboardTimeSeriesRequest, CallSettings)
            // Additional: DeleteTensorboardTimeSeriesAsync(DeleteTensorboardTimeSeriesRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTensorboardTimeSeriesRequest request = new DeleteTensorboardTimeSeriesRequest
            {
                TensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardTimeSeriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeries</summary>
        public void DeleteTensorboardTimeSeries()
        {
            // Snippet: DeleteTensorboardTimeSeries(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardTimeSeries(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeriesAsync</summary>
        public async Task DeleteTensorboardTimeSeriesAsync()
        {
            // Snippet: DeleteTensorboardTimeSeriesAsync(string, CallSettings)
            // Additional: DeleteTensorboardTimeSeriesAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardTimeSeriesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeries</summary>
        public void DeleteTensorboardTimeSeriesResourceNames()
        {
            // Snippet: DeleteTensorboardTimeSeries(TensorboardTimeSeriesName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName name = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = tensorboardServiceClient.DeleteTensorboardTimeSeries(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTensorboardTimeSeriesAsync</summary>
        public async Task DeleteTensorboardTimeSeriesResourceNamesAsync()
        {
            // Snippet: DeleteTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, CallSettings)
            // Additional: DeleteTensorboardTimeSeriesAsync(TensorboardTimeSeriesName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeriesName name = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await tensorboardServiceClient.DeleteTensorboardTimeSeriesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await tensorboardServiceClient.PollOnceDeleteTensorboardTimeSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesData</summary>
        public void BatchReadTensorboardTimeSeriesDataRequestObject()
        {
            // Snippet: BatchReadTensorboardTimeSeriesData(BatchReadTensorboardTimeSeriesDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                TimeSeriesAsTensorboardTimeSeriesNames =
                {
                    TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                },
            };
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.BatchReadTensorboardTimeSeriesData(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesDataAsync</summary>
        public async Task BatchReadTensorboardTimeSeriesDataRequestObjectAsync()
        {
            // Snippet: BatchReadTensorboardTimeSeriesDataAsync(BatchReadTensorboardTimeSeriesDataRequest, CallSettings)
            // Additional: BatchReadTensorboardTimeSeriesDataAsync(BatchReadTensorboardTimeSeriesDataRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReadTensorboardTimeSeriesDataRequest request = new BatchReadTensorboardTimeSeriesDataRequest
            {
                TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                TimeSeriesAsTensorboardTimeSeriesNames =
                {
                    TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                },
            };
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.BatchReadTensorboardTimeSeriesDataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesData</summary>
        public void BatchReadTensorboardTimeSeriesData()
        {
            // Snippet: BatchReadTensorboardTimeSeriesData(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.BatchReadTensorboardTimeSeriesData(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesDataAsync</summary>
        public async Task BatchReadTensorboardTimeSeriesDataAsync()
        {
            // Snippet: BatchReadTensorboardTimeSeriesDataAsync(string, CallSettings)
            // Additional: BatchReadTensorboardTimeSeriesDataAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboard = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]";
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.BatchReadTensorboardTimeSeriesDataAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesData</summary>
        public void BatchReadTensorboardTimeSeriesDataResourceNames()
        {
            // Snippet: BatchReadTensorboardTimeSeriesData(TensorboardName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.BatchReadTensorboardTimeSeriesData(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for BatchReadTensorboardTimeSeriesDataAsync</summary>
        public async Task BatchReadTensorboardTimeSeriesDataResourceNamesAsync()
        {
            // Snippet: BatchReadTensorboardTimeSeriesDataAsync(TensorboardName, CallSettings)
            // Additional: BatchReadTensorboardTimeSeriesDataAsync(TensorboardName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardName tensorboard = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]");
            // Make the request
            BatchReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.BatchReadTensorboardTimeSeriesDataAsync(tensorboard);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesData</summary>
        public void ReadTensorboardTimeSeriesDataRequestObject()
        {
            // Snippet: ReadTensorboardTimeSeriesData(ReadTensorboardTimeSeriesDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                MaxDataPoints = 0,
                Filter = "",
            };
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.ReadTensorboardTimeSeriesData(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesDataAsync</summary>
        public async Task ReadTensorboardTimeSeriesDataRequestObjectAsync()
        {
            // Snippet: ReadTensorboardTimeSeriesDataAsync(ReadTensorboardTimeSeriesDataRequest, CallSettings)
            // Additional: ReadTensorboardTimeSeriesDataAsync(ReadTensorboardTimeSeriesDataRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReadTensorboardTimeSeriesDataRequest request = new ReadTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                MaxDataPoints = 0,
                Filter = "",
            };
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.ReadTensorboardTimeSeriesDataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesData</summary>
        public void ReadTensorboardTimeSeriesData()
        {
            // Snippet: ReadTensorboardTimeSeriesData(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboardTimeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.ReadTensorboardTimeSeriesData(tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesDataAsync</summary>
        public async Task ReadTensorboardTimeSeriesDataAsync()
        {
            // Snippet: ReadTensorboardTimeSeriesDataAsync(string, CallSettings)
            // Additional: ReadTensorboardTimeSeriesDataAsync(string, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboardTimeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.ReadTensorboardTimeSeriesDataAsync(tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesData</summary>
        public void ReadTensorboardTimeSeriesDataResourceNames()
        {
            // Snippet: ReadTensorboardTimeSeriesData(TensorboardTimeSeriesName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName tensorboardTimeSeries = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = tensorboardServiceClient.ReadTensorboardTimeSeriesData(tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardTimeSeriesDataAsync</summary>
        public async Task ReadTensorboardTimeSeriesDataResourceNamesAsync()
        {
            // Snippet: ReadTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName, CallSettings)
            // Additional: ReadTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeriesName tensorboardTimeSeries = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            ReadTensorboardTimeSeriesDataResponse response = await tensorboardServiceClient.ReadTensorboardTimeSeriesDataAsync(tensorboardTimeSeries);
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardBlobData</summary>
        public async Task ReadTensorboardBlobDataRequestObject()
        {
            // Snippet: ReadTensorboardBlobData(ReadTensorboardBlobDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ReadTensorboardBlobDataRequest request = new ReadTensorboardBlobDataRequest
            {
                TimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                BlobIds = { "", },
            };
            // Make the request, returning a streaming response
            using TensorboardServiceClient.ReadTensorboardBlobDataStream response = tensorboardServiceClient.ReadTensorboardBlobData(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadTensorboardBlobDataResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadTensorboardBlobDataResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardBlobData</summary>
        public async Task ReadTensorboardBlobData()
        {
            // Snippet: ReadTensorboardBlobData(string, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string timeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request, returning a streaming response
            using TensorboardServiceClient.ReadTensorboardBlobDataStream response = tensorboardServiceClient.ReadTensorboardBlobData(timeSeries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadTensorboardBlobDataResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadTensorboardBlobDataResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ReadTensorboardBlobData</summary>
        public async Task ReadTensorboardBlobDataResourceNames()
        {
            // Snippet: ReadTensorboardBlobData(TensorboardTimeSeriesName, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName timeSeries = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request, returning a streaming response
            using TensorboardServiceClient.ReadTensorboardBlobDataStream response = tensorboardServiceClient.ReadTensorboardBlobData(timeSeries);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadTensorboardBlobDataResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadTensorboardBlobDataResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentData</summary>
        public void WriteTensorboardExperimentDataRequestObject()
        {
            // Snippet: WriteTensorboardExperimentData(WriteTensorboardExperimentDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = tensorboardServiceClient.WriteTensorboardExperimentData(request);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentDataAsync</summary>
        public async Task WriteTensorboardExperimentDataRequestObjectAsync()
        {
            // Snippet: WriteTensorboardExperimentDataAsync(WriteTensorboardExperimentDataRequest, CallSettings)
            // Additional: WriteTensorboardExperimentDataAsync(WriteTensorboardExperimentDataRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            WriteTensorboardExperimentDataRequest request = new WriteTensorboardExperimentDataRequest
            {
                TensorboardExperimentAsTensorboardExperimentName = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]"),
                WriteRunDataRequests =
                {
                    new WriteTensorboardRunDataRequest(),
                },
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = await tensorboardServiceClient.WriteTensorboardExperimentDataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentData</summary>
        public void WriteTensorboardExperimentData()
        {
            // Snippet: WriteTensorboardExperimentData(string, IEnumerable<WriteTensorboardRunDataRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboardExperiment = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests = new WriteTensorboardRunDataRequest[]
            {
                new WriteTensorboardRunDataRequest(),
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = tensorboardServiceClient.WriteTensorboardExperimentData(tensorboardExperiment, writeRunDataRequests);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentDataAsync</summary>
        public async Task WriteTensorboardExperimentDataAsync()
        {
            // Snippet: WriteTensorboardExperimentDataAsync(string, IEnumerable<WriteTensorboardRunDataRequest>, CallSettings)
            // Additional: WriteTensorboardExperimentDataAsync(string, IEnumerable<WriteTensorboardRunDataRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboardExperiment = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]";
            IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests = new WriteTensorboardRunDataRequest[]
            {
                new WriteTensorboardRunDataRequest(),
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = await tensorboardServiceClient.WriteTensorboardExperimentDataAsync(tensorboardExperiment, writeRunDataRequests);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentData</summary>
        public void WriteTensorboardExperimentDataResourceNames()
        {
            // Snippet: WriteTensorboardExperimentData(TensorboardExperimentName, IEnumerable<WriteTensorboardRunDataRequest>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardExperimentName tensorboardExperiment = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests = new WriteTensorboardRunDataRequest[]
            {
                new WriteTensorboardRunDataRequest(),
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = tensorboardServiceClient.WriteTensorboardExperimentData(tensorboardExperiment, writeRunDataRequests);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardExperimentDataAsync</summary>
        public async Task WriteTensorboardExperimentDataResourceNamesAsync()
        {
            // Snippet: WriteTensorboardExperimentDataAsync(TensorboardExperimentName, IEnumerable<WriteTensorboardRunDataRequest>, CallSettings)
            // Additional: WriteTensorboardExperimentDataAsync(TensorboardExperimentName, IEnumerable<WriteTensorboardRunDataRequest>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardExperimentName tensorboardExperiment = TensorboardExperimentName.FromProjectLocationTensorboardExperiment("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]");
            IEnumerable<WriteTensorboardRunDataRequest> writeRunDataRequests = new WriteTensorboardRunDataRequest[]
            {
                new WriteTensorboardRunDataRequest(),
            };
            // Make the request
            WriteTensorboardExperimentDataResponse response = await tensorboardServiceClient.WriteTensorboardExperimentDataAsync(tensorboardExperiment, writeRunDataRequests);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunData</summary>
        public void WriteTensorboardRunDataRequestObject()
        {
            // Snippet: WriteTensorboardRunData(WriteTensorboardRunDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            // Make the request
            WriteTensorboardRunDataResponse response = tensorboardServiceClient.WriteTensorboardRunData(request);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunDataAsync</summary>
        public async Task WriteTensorboardRunDataRequestObjectAsync()
        {
            // Snippet: WriteTensorboardRunDataAsync(WriteTensorboardRunDataRequest, CallSettings)
            // Additional: WriteTensorboardRunDataAsync(WriteTensorboardRunDataRequest, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            WriteTensorboardRunDataRequest request = new WriteTensorboardRunDataRequest
            {
                TensorboardRunAsTensorboardRunName = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]"),
                TimeSeriesData =
                {
                    new TimeSeriesData(),
                },
            };
            // Make the request
            WriteTensorboardRunDataResponse response = await tensorboardServiceClient.WriteTensorboardRunDataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunData</summary>
        public void WriteTensorboardRunData()
        {
            // Snippet: WriteTensorboardRunData(string, IEnumerable<TimeSeriesData>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboardRun = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            IEnumerable<TimeSeriesData> timeSeriesData = new TimeSeriesData[]
            {
                new TimeSeriesData(),
            };
            // Make the request
            WriteTensorboardRunDataResponse response = tensorboardServiceClient.WriteTensorboardRunData(tensorboardRun, timeSeriesData);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunDataAsync</summary>
        public async Task WriteTensorboardRunDataAsync()
        {
            // Snippet: WriteTensorboardRunDataAsync(string, IEnumerable<TimeSeriesData>, CallSettings)
            // Additional: WriteTensorboardRunDataAsync(string, IEnumerable<TimeSeriesData>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboardRun = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]";
            IEnumerable<TimeSeriesData> timeSeriesData = new TimeSeriesData[]
            {
                new TimeSeriesData(),
            };
            // Make the request
            WriteTensorboardRunDataResponse response = await tensorboardServiceClient.WriteTensorboardRunDataAsync(tensorboardRun, timeSeriesData);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunData</summary>
        public void WriteTensorboardRunDataResourceNames()
        {
            // Snippet: WriteTensorboardRunData(TensorboardRunName, IEnumerable<TimeSeriesData>, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardRunName tensorboardRun = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            IEnumerable<TimeSeriesData> timeSeriesData = new TimeSeriesData[]
            {
                new TimeSeriesData(),
            };
            // Make the request
            WriteTensorboardRunDataResponse response = tensorboardServiceClient.WriteTensorboardRunData(tensorboardRun, timeSeriesData);
            // End snippet
        }

        /// <summary>Snippet for WriteTensorboardRunDataAsync</summary>
        public async Task WriteTensorboardRunDataResourceNamesAsync()
        {
            // Snippet: WriteTensorboardRunDataAsync(TensorboardRunName, IEnumerable<TimeSeriesData>, CallSettings)
            // Additional: WriteTensorboardRunDataAsync(TensorboardRunName, IEnumerable<TimeSeriesData>, CancellationToken)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardRunName tensorboardRun = TensorboardRunName.FromProjectLocationTensorboardExperimentRun("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]");
            IEnumerable<TimeSeriesData> timeSeriesData = new TimeSeriesData[]
            {
                new TimeSeriesData(),
            };
            // Make the request
            WriteTensorboardRunDataResponse response = await tensorboardServiceClient.WriteTensorboardRunDataAsync(tensorboardRun, timeSeriesData);
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesData</summary>
        public void ExportTensorboardTimeSeriesDataRequestObject()
        {
            // Snippet: ExportTensorboardTimeSeriesData(ExportTensorboardTimeSeriesDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesData(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeriesDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ExportTensorboardTimeSeriesDataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesDataAsync</summary>
        public async Task ExportTensorboardTimeSeriesDataRequestObjectAsync()
        {
            // Snippet: ExportTensorboardTimeSeriesDataAsync(ExportTensorboardTimeSeriesDataRequest, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportTensorboardTimeSeriesDataRequest request = new ExportTensorboardTimeSeriesDataRequest
            {
                TensorboardTimeSeriesAsTensorboardTimeSeriesName = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesDataAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeriesDataPoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ExportTensorboardTimeSeriesDataResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesData</summary>
        public void ExportTensorboardTimeSeriesData()
        {
            // Snippet: ExportTensorboardTimeSeriesData(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            string tensorboardTimeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesData(tensorboardTimeSeries);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeriesDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ExportTensorboardTimeSeriesDataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesDataAsync</summary>
        public async Task ExportTensorboardTimeSeriesDataAsync()
        {
            // Snippet: ExportTensorboardTimeSeriesDataAsync(string, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string tensorboardTimeSeries = "projects/[PROJECT]/locations/[LOCATION]/tensorboards/[TENSORBOARD]/experiments/[EXPERIMENT]/runs/[RUN]/timeSeries/[TIME_SERIES]";
            // Make the request
            PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesDataAsync(tensorboardTimeSeries);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeriesDataPoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ExportTensorboardTimeSeriesDataResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesData</summary>
        public void ExportTensorboardTimeSeriesDataResourceNames()
        {
            // Snippet: ExportTensorboardTimeSeriesData(TensorboardTimeSeriesName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = TensorboardServiceClient.Create();
            // Initialize request argument(s)
            TensorboardTimeSeriesName tensorboardTimeSeries = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            PagedEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesData(tensorboardTimeSeries);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeriesDataPoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ExportTensorboardTimeSeriesDataResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportTensorboardTimeSeriesDataAsync</summary>
        public async Task ExportTensorboardTimeSeriesDataResourceNamesAsync()
        {
            // Snippet: ExportTensorboardTimeSeriesDataAsync(TensorboardTimeSeriesName, string, int?, CallSettings)
            // Create client
            TensorboardServiceClient tensorboardServiceClient = await TensorboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            TensorboardTimeSeriesName tensorboardTimeSeries = TensorboardTimeSeriesName.FromProjectLocationTensorboardExperimentRunTimeSeries("[PROJECT]", "[LOCATION]", "[TENSORBOARD]", "[EXPERIMENT]", "[RUN]", "[TIME_SERIES]");
            // Make the request
            PagedAsyncEnumerable<ExportTensorboardTimeSeriesDataResponse, TimeSeriesDataPoint> response = tensorboardServiceClient.ExportTensorboardTimeSeriesDataAsync(tensorboardTimeSeries);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeriesDataPoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ExportTensorboardTimeSeriesDataResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeriesDataPoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeriesDataPoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeriesDataPoint item in singlePage)
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
