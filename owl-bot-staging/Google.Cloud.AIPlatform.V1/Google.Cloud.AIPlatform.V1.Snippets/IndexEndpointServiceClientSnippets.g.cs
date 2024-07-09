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
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIndexEndpointServiceClientSnippets
    {
        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpointRequestObject()
        {
            // Snippet: CreateIndexEndpoint(CreateIndexEndpointRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            CreateIndexEndpointRequest request = new CreateIndexEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IndexEndpoint = new IndexEndpoint(),
            };
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = indexEndpointServiceClient.CreateIndexEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointRequestObjectAsync()
        {
            // Snippet: CreateIndexEndpointAsync(CreateIndexEndpointRequest, CallSettings)
            // Additional: CreateIndexEndpointAsync(CreateIndexEndpointRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexEndpointRequest request = new CreateIndexEndpointRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IndexEndpoint = new IndexEndpoint(),
            };
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = await indexEndpointServiceClient.CreateIndexEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpoint()
        {
            // Snippet: CreateIndexEndpoint(string, IndexEndpoint, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = indexEndpointServiceClient.CreateIndexEndpoint(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointAsync()
        {
            // Snippet: CreateIndexEndpointAsync(string, IndexEndpoint, CallSettings)
            // Additional: CreateIndexEndpointAsync(string, IndexEndpoint, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = await indexEndpointServiceClient.CreateIndexEndpointAsync(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpoint</summary>
        public void CreateIndexEndpointResourceNames()
        {
            // Snippet: CreateIndexEndpoint(LocationName, IndexEndpoint, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = indexEndpointServiceClient.CreateIndexEndpoint(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexEndpointAsync</summary>
        public async Task CreateIndexEndpointResourceNamesAsync()
        {
            // Snippet: CreateIndexEndpointAsync(LocationName, IndexEndpoint, CallSettings)
            // Additional: CreateIndexEndpointAsync(LocationName, IndexEndpoint, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = await indexEndpointServiceClient.CreateIndexEndpointAsync(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceCreateIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpointRequestObject()
        {
            // Snippet: GetIndexEndpoint(GetIndexEndpointRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            IndexEndpoint response = indexEndpointServiceClient.GetIndexEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointRequestObjectAsync()
        {
            // Snippet: GetIndexEndpointAsync(GetIndexEndpointRequest, CallSettings)
            // Additional: GetIndexEndpointAsync(GetIndexEndpointRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            IndexEndpoint response = await indexEndpointServiceClient.GetIndexEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpoint()
        {
            // Snippet: GetIndexEndpoint(string, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            IndexEndpoint response = indexEndpointServiceClient.GetIndexEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointAsync()
        {
            // Snippet: GetIndexEndpointAsync(string, CallSettings)
            // Additional: GetIndexEndpointAsync(string, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            IndexEndpoint response = await indexEndpointServiceClient.GetIndexEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpoint</summary>
        public void GetIndexEndpointResourceNames()
        {
            // Snippet: GetIndexEndpoint(IndexEndpointName, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpointName name = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            IndexEndpoint response = indexEndpointServiceClient.GetIndexEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexEndpointAsync</summary>
        public async Task GetIndexEndpointResourceNamesAsync()
        {
            // Snippet: GetIndexEndpointAsync(IndexEndpointName, CallSettings)
            // Additional: GetIndexEndpointAsync(IndexEndpointName, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpointName name = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            IndexEndpoint response = await indexEndpointServiceClient.GetIndexEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpointsRequestObject()
        {
            // Snippet: ListIndexEndpoints(ListIndexEndpointsRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsRequestObjectAsync()
        {
            // Snippet: ListIndexEndpointsAsync(ListIndexEndpointsRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexEndpointsRequest request = new ListIndexEndpointsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpoints()
        {
            // Snippet: ListIndexEndpoints(string, string, int?, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsAsync()
        {
            // Snippet: ListIndexEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpoints</summary>
        public void ListIndexEndpointsResourceNames()
        {
            // Snippet: ListIndexEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IndexEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexEndpointsAsync</summary>
        public async Task ListIndexEndpointsResourceNamesAsync()
        {
            // Snippet: ListIndexEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListIndexEndpointsResponse, IndexEndpoint> response = indexEndpointServiceClient.ListIndexEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IndexEndpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IndexEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IndexEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IndexEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpoint</summary>
        public void UpdateIndexEndpointRequestObject()
        {
            // Snippet: UpdateIndexEndpoint(UpdateIndexEndpointRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IndexEndpoint response = indexEndpointServiceClient.UpdateIndexEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpointAsync</summary>
        public async Task UpdateIndexEndpointRequestObjectAsync()
        {
            // Snippet: UpdateIndexEndpointAsync(UpdateIndexEndpointRequest, CallSettings)
            // Additional: UpdateIndexEndpointAsync(UpdateIndexEndpointRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IndexEndpoint response = await indexEndpointServiceClient.UpdateIndexEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpoint</summary>
        public void UpdateIndexEndpoint()
        {
            // Snippet: UpdateIndexEndpoint(IndexEndpoint, FieldMask, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IndexEndpoint response = indexEndpointServiceClient.UpdateIndexEndpoint(indexEndpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexEndpointAsync</summary>
        public async Task UpdateIndexEndpointAsync()
        {
            // Snippet: UpdateIndexEndpointAsync(IndexEndpoint, FieldMask, CallSettings)
            // Additional: UpdateIndexEndpointAsync(IndexEndpoint, FieldMask, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpoint indexEndpoint = new IndexEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IndexEndpoint response = await indexEndpointServiceClient.UpdateIndexEndpointAsync(indexEndpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpointRequestObject()
        {
            // Snippet: DeleteIndexEndpoint(DeleteIndexEndpointRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            DeleteIndexEndpointRequest request = new DeleteIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = indexEndpointServiceClient.DeleteIndexEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointRequestObjectAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(DeleteIndexEndpointRequest, CallSettings)
            // Additional: DeleteIndexEndpointAsync(DeleteIndexEndpointRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIndexEndpointRequest request = new DeleteIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await indexEndpointServiceClient.DeleteIndexEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpoint()
        {
            // Snippet: DeleteIndexEndpoint(string, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = indexEndpointServiceClient.DeleteIndexEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(string, CallSettings)
            // Additional: DeleteIndexEndpointAsync(string, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await indexEndpointServiceClient.DeleteIndexEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpoint</summary>
        public void DeleteIndexEndpointResourceNames()
        {
            // Snippet: DeleteIndexEndpoint(IndexEndpointName, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpointName name = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = indexEndpointServiceClient.DeleteIndexEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeleteIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexEndpointAsync</summary>
        public async Task DeleteIndexEndpointResourceNamesAsync()
        {
            // Snippet: DeleteIndexEndpointAsync(IndexEndpointName, CallSettings)
            // Additional: DeleteIndexEndpointAsync(IndexEndpointName, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpointName name = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await indexEndpointServiceClient.DeleteIndexEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeleteIndexEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndex</summary>
        public void DeployIndexRequestObject()
        {
            // Snippet: DeployIndex(DeployIndexRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            DeployIndexRequest request = new DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new DeployedIndex(),
            };
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = indexEndpointServiceClient.DeployIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndexAsync</summary>
        public async Task DeployIndexRequestObjectAsync()
        {
            // Snippet: DeployIndexAsync(DeployIndexRequest, CallSettings)
            // Additional: DeployIndexAsync(DeployIndexRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployIndexRequest request = new DeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new DeployedIndex(),
            };
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = await indexEndpointServiceClient.DeployIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndex</summary>
        public void DeployIndex()
        {
            // Snippet: DeployIndex(string, DeployedIndex, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = indexEndpointServiceClient.DeployIndex(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndexAsync</summary>
        public async Task DeployIndexAsync()
        {
            // Snippet: DeployIndexAsync(string, DeployedIndex, CallSettings)
            // Additional: DeployIndexAsync(string, DeployedIndex, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = await indexEndpointServiceClient.DeployIndexAsync(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndex</summary>
        public void DeployIndexResourceNames()
        {
            // Snippet: DeployIndex(IndexEndpointName, DeployedIndex, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = indexEndpointServiceClient.DeployIndex(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceDeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIndexAsync</summary>
        public async Task DeployIndexResourceNamesAsync()
        {
            // Snippet: DeployIndexAsync(IndexEndpointName, DeployedIndex, CallSettings)
            // Additional: DeployIndexAsync(IndexEndpointName, DeployedIndex, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> response = await indexEndpointServiceClient.DeployIndexAsync(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIndexResponse, DeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceDeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndex</summary>
        public void UndeployIndexRequestObject()
        {
            // Snippet: UndeployIndex(UndeployIndexRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            UndeployIndexRequest request = new UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
            };
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = indexEndpointServiceClient.UndeployIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceUndeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndexAsync</summary>
        public async Task UndeployIndexRequestObjectAsync()
        {
            // Snippet: UndeployIndexAsync(UndeployIndexRequest, CallSettings)
            // Additional: UndeployIndexAsync(UndeployIndexRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeployIndexRequest request = new UndeployIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndexId = "",
            };
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = await indexEndpointServiceClient.UndeployIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceUndeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndex</summary>
        public void UndeployIndex()
        {
            // Snippet: UndeployIndex(string, string, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            string deployedIndexId = "";
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = indexEndpointServiceClient.UndeployIndex(indexEndpoint, deployedIndexId);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceUndeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndexAsync</summary>
        public async Task UndeployIndexAsync()
        {
            // Snippet: UndeployIndexAsync(string, string, CallSettings)
            // Additional: UndeployIndexAsync(string, string, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            string deployedIndexId = "";
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = await indexEndpointServiceClient.UndeployIndexAsync(indexEndpoint, deployedIndexId);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceUndeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndex</summary>
        public void UndeployIndexResourceNames()
        {
            // Snippet: UndeployIndex(IndexEndpointName, string, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            string deployedIndexId = "";
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = indexEndpointServiceClient.UndeployIndex(indexEndpoint, deployedIndexId);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceUndeployIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIndexAsync</summary>
        public async Task UndeployIndexResourceNamesAsync()
        {
            // Snippet: UndeployIndexAsync(IndexEndpointName, string, CallSettings)
            // Additional: UndeployIndexAsync(IndexEndpointName, string, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            string deployedIndexId = "";
            // Make the request
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> response = await indexEndpointServiceClient.UndeployIndexAsync(indexEndpoint, deployedIndexId);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIndexResponse, UndeployIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceUndeployIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndex</summary>
        public void MutateDeployedIndexRequestObject()
        {
            // Snippet: MutateDeployedIndex(MutateDeployedIndexRequest, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            MutateDeployedIndexRequest request = new MutateDeployedIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new DeployedIndex(),
            };
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = indexEndpointServiceClient.MutateDeployedIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceMutateDeployedIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndexAsync</summary>
        public async Task MutateDeployedIndexRequestObjectAsync()
        {
            // Snippet: MutateDeployedIndexAsync(MutateDeployedIndexRequest, CallSettings)
            // Additional: MutateDeployedIndexAsync(MutateDeployedIndexRequest, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            MutateDeployedIndexRequest request = new MutateDeployedIndexRequest
            {
                IndexEndpointAsIndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DeployedIndex = new DeployedIndex(),
            };
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = await indexEndpointServiceClient.MutateDeployedIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceMutateDeployedIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndex</summary>
        public void MutateDeployedIndex()
        {
            // Snippet: MutateDeployedIndex(string, DeployedIndex, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = indexEndpointServiceClient.MutateDeployedIndex(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceMutateDeployedIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndexAsync</summary>
        public async Task MutateDeployedIndexAsync()
        {
            // Snippet: MutateDeployedIndexAsync(string, DeployedIndex, CallSettings)
            // Additional: MutateDeployedIndexAsync(string, DeployedIndex, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            string indexEndpoint = "projects/[PROJECT]/locations/[LOCATION]/indexEndpoints/[INDEX_ENDPOINT]";
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = await indexEndpointServiceClient.MutateDeployedIndexAsync(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceMutateDeployedIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndex</summary>
        public void MutateDeployedIndexResourceNames()
        {
            // Snippet: MutateDeployedIndex(IndexEndpointName, DeployedIndex, CallSettings)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = indexEndpointServiceClient.MutateDeployedIndex(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceMutateDeployedIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MutateDeployedIndexAsync</summary>
        public async Task MutateDeployedIndexResourceNamesAsync()
        {
            // Snippet: MutateDeployedIndexAsync(IndexEndpointName, DeployedIndex, CallSettings)
            // Additional: MutateDeployedIndexAsync(IndexEndpointName, DeployedIndex, CancellationToken)
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = await IndexEndpointServiceClient.CreateAsync();
            // Initialize request argument(s)
            IndexEndpointName indexEndpoint = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]");
            DeployedIndex deployedIndex = new DeployedIndex();
            // Make the request
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> response = await indexEndpointServiceClient.MutateDeployedIndexAsync(indexEndpoint, deployedIndex);

            // Poll until the returned long-running operation is complete
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MutateDeployedIndexResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MutateDeployedIndexResponse, MutateDeployedIndexOperationMetadata> retrievedResponse = await indexEndpointServiceClient.PollOnceMutateDeployedIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MutateDeployedIndexResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
