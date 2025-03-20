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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcav = Google.Cloud.AIPlatform.V1Beta1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIndexServiceClientSnippets
    {
        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexRequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::CreateIndexRequest request = new gcav::CreateIndexRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Index = new gcav::Index(),
            };
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = indexServiceClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexRequestObjectAsync()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::CreateIndexRequest request = new gcav::CreateIndexRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Index = new gcav::Index(),
            };
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = await indexServiceClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex()
        {
            // Snippet: CreateIndex(string, Index, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Index index = new gcav::Index();
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = indexServiceClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(string, Index, CallSettings)
            // Additional: CreateIndexAsync(string, Index, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcav::Index index = new gcav::Index();
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = await indexServiceClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexResourceNames()
        {
            // Snippet: CreateIndex(LocationName, Index, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Index index = new gcav::Index();
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = indexServiceClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexResourceNamesAsync()
        {
            // Snippet: CreateIndexAsync(LocationName, Index, CallSettings)
            // Additional: CreateIndexAsync(LocationName, Index, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcav::Index index = new gcav::Index();
            // Make the request
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> response = await indexServiceClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::CreateIndexOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexRequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::GetIndexRequest request = new gcav::GetIndexRequest
            {
                IndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            // Make the request
            gcav::Index response = indexServiceClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexRequestObjectAsync()
        {
            // Snippet: GetIndexAsync(GetIndexRequest, CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::GetIndexRequest request = new gcav::GetIndexRequest
            {
                IndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            // Make the request
            gcav::Index response = await indexServiceClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex()
        {
            // Snippet: GetIndex(string, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexes/[INDEX]";
            // Make the request
            gcav::Index response = indexServiceClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(string, CallSettings)
            // Additional: GetIndexAsync(string, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexes/[INDEX]";
            // Make the request
            gcav::Index response = await indexServiceClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexResourceNames()
        {
            // Snippet: GetIndex(IndexName, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::IndexName name = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]");
            // Make the request
            gcav::Index response = indexServiceClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexResourceNamesAsync()
        {
            // Snippet: GetIndexAsync(IndexName, CallSettings)
            // Additional: GetIndexAsync(IndexName, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::IndexName name = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]");
            // Make the request
            gcav::Index response = await indexServiceClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesRequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::ListIndexesRequest request = new gcav::ListIndexesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesRequestObjectAsync()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::ListIndexesRequest request = new gcav::ListIndexesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes()
        {
            // Snippet: ListIndexes(string, string, int?, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(string, string, int?, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesResourceNames()
        {
            // Snippet: ListIndexes(LocationName, string, int?, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcav::ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesResourceNamesAsync()
        {
            // Snippet: ListIndexesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcav::ListIndexesResponse, gcav::Index> response = indexServiceClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcav::ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateIndex</summary>
        public void UpdateIndexRequestObject()
        {
            // Snippet: UpdateIndex(UpdateIndexRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::UpdateIndexRequest request = new gcav::UpdateIndexRequest
            {
                Index = new gcav::Index(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> response = indexServiceClient.UpdateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceUpdateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexAsync</summary>
        public async Task UpdateIndexRequestObjectAsync()
        {
            // Snippet: UpdateIndexAsync(UpdateIndexRequest, CallSettings)
            // Additional: UpdateIndexAsync(UpdateIndexRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpdateIndexRequest request = new gcav::UpdateIndexRequest
            {
                Index = new gcav::Index(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> response = await indexServiceClient.UpdateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceUpdateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndex</summary>
        public void UpdateIndex()
        {
            // Snippet: UpdateIndex(Index, FieldMask, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::Index index = new gcav::Index();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> response = indexServiceClient.UpdateIndex(index, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> retrievedResponse = indexServiceClient.PollOnceUpdateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIndexAsync</summary>
        public async Task UpdateIndexAsync()
        {
            // Snippet: UpdateIndexAsync(Index, FieldMask, CallSettings)
            // Additional: UpdateIndexAsync(Index, FieldMask, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::Index index = new gcav::Index();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> response = await indexServiceClient.UpdateIndexAsync(index, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcav::Index, gcav::UpdateIndexOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceUpdateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexRequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::DeleteIndexRequest request = new gcav::DeleteIndexRequest
            {
                IndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = indexServiceClient.DeleteIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = indexServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexRequestObjectAsync()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest, CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::DeleteIndexRequest request = new gcav::DeleteIndexRequest
            {
                IndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
            };
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = await indexServiceClient.DeleteIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(string, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = indexServiceClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = indexServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(string, CallSettings)
            // Additional: DeleteIndexAsync(string, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/indexes/[INDEX]";
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = await indexServiceClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexResourceNames()
        {
            // Snippet: DeleteIndex(IndexName, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::IndexName name = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]");
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = indexServiceClient.DeleteIndex(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = indexServiceClient.PollOnceDeleteIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexResourceNamesAsync()
        {
            // Snippet: DeleteIndexAsync(IndexName, CallSettings)
            // Additional: DeleteIndexAsync(IndexName, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::IndexName name = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]");
            // Make the request
            Operation<Empty, gcav::DeleteOperationMetadata> response = await indexServiceClient.DeleteIndexAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcav::DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcav::DeleteOperationMetadata> retrievedResponse = await indexServiceClient.PollOnceDeleteIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpsertDatapoints</summary>
        public void UpsertDatapointsRequestObject()
        {
            // Snippet: UpsertDatapoints(UpsertDatapointsRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::UpsertDatapointsRequest request = new gcav::UpsertDatapointsRequest
            {
                IndexAsIndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                Datapoints =
                {
                    new gcav::IndexDatapoint(),
                },
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::UpsertDatapointsResponse response = indexServiceClient.UpsertDatapoints(request);
            // End snippet
        }

        /// <summary>Snippet for UpsertDatapointsAsync</summary>
        public async Task UpsertDatapointsRequestObjectAsync()
        {
            // Snippet: UpsertDatapointsAsync(UpsertDatapointsRequest, CallSettings)
            // Additional: UpsertDatapointsAsync(UpsertDatapointsRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::UpsertDatapointsRequest request = new gcav::UpsertDatapointsRequest
            {
                IndexAsIndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                Datapoints =
                {
                    new gcav::IndexDatapoint(),
                },
                UpdateMask = new FieldMask(),
            };
            // Make the request
            gcav::UpsertDatapointsResponse response = await indexServiceClient.UpsertDatapointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDatapoints</summary>
        public void RemoveDatapointsRequestObject()
        {
            // Snippet: RemoveDatapoints(RemoveDatapointsRequest, CallSettings)
            // Create client
            gcav::IndexServiceClient indexServiceClient = gcav::IndexServiceClient.Create();
            // Initialize request argument(s)
            gcav::RemoveDatapointsRequest request = new gcav::RemoveDatapointsRequest
            {
                IndexAsIndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DatapointIds = { "", },
            };
            // Make the request
            gcav::RemoveDatapointsResponse response = indexServiceClient.RemoveDatapoints(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDatapointsAsync</summary>
        public async Task RemoveDatapointsRequestObjectAsync()
        {
            // Snippet: RemoveDatapointsAsync(RemoveDatapointsRequest, CallSettings)
            // Additional: RemoveDatapointsAsync(RemoveDatapointsRequest, CancellationToken)
            // Create client
            gcav::IndexServiceClient indexServiceClient = await gcav::IndexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcav::RemoveDatapointsRequest request = new gcav::RemoveDatapointsRequest
            {
                IndexAsIndexName = gcav::IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                DatapointIds = { "", },
            };
            // Make the request
            gcav::RemoveDatapointsResponse response = await indexServiceClient.RemoveDatapointsAsync(request);
            // End snippet
        }
    }
}
