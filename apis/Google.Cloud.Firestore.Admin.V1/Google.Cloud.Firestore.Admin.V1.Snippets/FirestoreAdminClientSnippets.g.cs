// Copyright 2020 Google LLC
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

namespace Google.Cloud.Firestore.Admin.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcfav = Google.Cloud.Firestore.Admin.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex_RequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Index = new Index(),
            };
            // Make the request
            Operation<Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync_RequestObject()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Index = new Index(),
            };
            // Make the request
            Operation<Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex()
        {
            // Snippet: CreateIndex(string, Index, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            Index index = new Index();
            // Make the request
            Operation<Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(string, Index, CallSettings)
            // Additional: CreateIndexAsync(string, Index, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            Index index = new Index();
            // Make the request
            Operation<Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex_ResourceNames()
        {
            // Snippet: CreateIndex(CollectionGroupName, Index, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            Index index = new Index();
            // Make the request
            Operation<Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync_ResourceNames()
        {
            // Snippet: CreateIndexAsync(CollectionGroupName, Index, CallSettings)
            // Additional: CreateIndexAsync(CollectionGroupName, Index, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            Index index = new Index();
            // Make the request
            Operation<Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes_RequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public async Task ListIndexesAsync_RequestObject()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
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
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(string, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes_ResourceNames()
        {
            // Snippet: ListIndexes(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public async Task ListIndexesAsync_ResourceNames()
        {
            // Snippet: ListIndexesAsync(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response = firestoreAdminClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex_RequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            Index response = firestoreAdminClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync_RequestObject()
        {
            // Snippet: GetIndexAsync(GetIndexRequest, CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex()
        {
            // Snippet: GetIndex(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            Index response = firestoreAdminClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(string, CallSettings)
            // Additional: GetIndexAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex_ResourceNames()
        {
            // Snippet: GetIndex(IndexName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            Index response = firestoreAdminClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync_ResourceNames()
        {
            // Snippet: GetIndexAsync(IndexName, CallSettings)
            // Additional: GetIndexAsync(IndexName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex_RequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            firestoreAdminClient.DeleteIndex(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync_RequestObject()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest, CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            firestoreAdminClient.DeleteIndex(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(string, CallSettings)
            // Additional: DeleteIndexAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/indexes/[INDEX]";
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex_ResourceNames()
        {
            // Snippet: DeleteIndex(IndexName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            firestoreAdminClient.DeleteIndex(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync_ResourceNames()
        {
            // Snippet: DeleteIndexAsync(IndexName, CallSettings)
            // Additional: DeleteIndexAsync(IndexName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetField</summary>
        public void GetField_RequestObject()
        {
            // Snippet: GetField(GetFieldRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            // Make the request
            gcfav::Field response = firestoreAdminClient.GetField(request);
            // End snippet
        }

        /// <summary>Snippet for GetFieldAsync</summary>
        public async Task GetFieldAsync_RequestObject()
        {
            // Snippet: GetFieldAsync(GetFieldRequest, CallSettings)
            // Additional: GetFieldAsync(GetFieldRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            // Make the request
            gcfav::Field response = await firestoreAdminClient.GetFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetField</summary>
        public void GetField()
        {
            // Snippet: GetField(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/fields/[FIELD]";
            // Make the request
            gcfav::Field response = firestoreAdminClient.GetField(name);
            // End snippet
        }

        /// <summary>Snippet for GetFieldAsync</summary>
        public async Task GetFieldAsync()
        {
            // Snippet: GetFieldAsync(string, CallSettings)
            // Additional: GetFieldAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]/fields/[FIELD]";
            // Make the request
            gcfav::Field response = await firestoreAdminClient.GetFieldAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetField</summary>
        public void GetField_ResourceNames()
        {
            // Snippet: GetField(FieldName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            FieldName name = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]");
            // Make the request
            gcfav::Field response = firestoreAdminClient.GetField(name);
            // End snippet
        }

        /// <summary>Snippet for GetFieldAsync</summary>
        public async Task GetFieldAsync_ResourceNames()
        {
            // Snippet: GetFieldAsync(FieldName, CallSettings)
            // Additional: GetFieldAsync(FieldName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            FieldName name = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]");
            // Make the request
            gcfav::Field response = await firestoreAdminClient.GetFieldAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateField</summary>
        public void UpdateField_RequestObject()
        {
            // Snippet: UpdateField(UpdateFieldRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new gcfav::Field(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcfav::Field, FieldOperationMetadata> response = firestoreAdminClient.UpdateField(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, FieldOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, FieldOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceUpdateField(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFieldAsync</summary>
        public async Task UpdateFieldAsync_RequestObject()
        {
            // Snippet: UpdateFieldAsync(UpdateFieldRequest, CallSettings)
            // Additional: UpdateFieldAsync(UpdateFieldRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new gcfav::Field(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcfav::Field, FieldOperationMetadata> response = await firestoreAdminClient.UpdateFieldAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, FieldOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, FieldOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceUpdateFieldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateField</summary>
        public void UpdateField()
        {
            // Snippet: UpdateField(Field, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            gcfav::Field field = new gcfav::Field();
            // Make the request
            Operation<gcfav::Field, FieldOperationMetadata> response = firestoreAdminClient.UpdateField(field);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, FieldOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, FieldOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceUpdateField(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFieldAsync</summary>
        public async Task UpdateFieldAsync()
        {
            // Snippet: UpdateFieldAsync(Field, CallSettings)
            // Additional: UpdateFieldAsync(Field, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            gcfav::Field field = new gcfav::Field();
            // Make the request
            Operation<gcfav::Field, FieldOperationMetadata> response = await firestoreAdminClient.UpdateFieldAsync(field);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, FieldOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, FieldOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceUpdateFieldAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public void ListFields_RequestObject()
        {
            // Snippet: ListFields(ListFieldsRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListFieldsRequest request = new ListFieldsRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFields(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Field item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public async Task ListFieldsAsync_RequestObject()
        {
            // Snippet: ListFieldsAsync(ListFieldsRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListFieldsRequest request = new ListFieldsRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFieldsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Field item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public void ListFields()
        {
            // Snippet: ListFields(string, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            // Make the request
            PagedEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFields(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Field item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public async Task ListFieldsAsync()
        {
            // Snippet: ListFieldsAsync(string, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFieldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Field item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public void ListFields_ResourceNames()
        {
            // Snippet: ListFields(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFields(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Field item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public async Task ListFieldsAsync_ResourceNames()
        {
            // Snippet: ListFieldsAsync(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListFieldsResponse, gcfav::Field> response = firestoreAdminClient.ListFieldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Field item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Field item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Field> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Field item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ExportDocuments</summary>
        public void ExportDocuments_RequestObject()
        {
            // Snippet: ExportDocuments(ExportDocumentsRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                CollectionIds = { "", },
                OutputUriPrefix = "",
            };
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = firestoreAdminClient.ExportDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceExportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDocumentsAsync</summary>
        public async Task ExportDocumentsAsync_RequestObject()
        {
            // Snippet: ExportDocumentsAsync(ExportDocumentsRequest, CallSettings)
            // Additional: ExportDocumentsAsync(ExportDocumentsRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                CollectionIds = { "", },
                OutputUriPrefix = "",
            };
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = await firestoreAdminClient.ExportDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceExportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDocuments</summary>
        public void ExportDocuments()
        {
            // Snippet: ExportDocuments(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = firestoreAdminClient.ExportDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceExportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDocumentsAsync</summary>
        public async Task ExportDocumentsAsync()
        {
            // Snippet: ExportDocumentsAsync(string, CallSettings)
            // Additional: ExportDocumentsAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = await firestoreAdminClient.ExportDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceExportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDocuments</summary>
        public void ExportDocuments_ResourceNames()
        {
            // Snippet: ExportDocuments(DatabaseName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = firestoreAdminClient.ExportDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceExportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportDocumentsAsync</summary>
        public async Task ExportDocumentsAsync_ResourceNames()
        {
            // Snippet: ExportDocumentsAsync(DatabaseName, CallSettings)
            // Additional: ExportDocumentsAsync(DatabaseName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> response = await firestoreAdminClient.ExportDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDocumentsResponse, ExportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceExportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments_RequestObject()
        {
            // Snippet: ImportDocuments(ImportDocumentsRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                CollectionIds = { "", },
                InputUriPrefix = "",
            };
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = firestoreAdminClient.ImportDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceImportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsAsync_RequestObject()
        {
            // Snippet: ImportDocumentsAsync(ImportDocumentsRequest, CallSettings)
            // Additional: ImportDocumentsAsync(ImportDocumentsRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                CollectionIds = { "", },
                InputUriPrefix = "",
            };
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = await firestoreAdminClient.ImportDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceImportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments()
        {
            // Snippet: ImportDocuments(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = firestoreAdminClient.ImportDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceImportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsAsync()
        {
            // Snippet: ImportDocumentsAsync(string, CallSettings)
            // Additional: ImportDocumentsAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = await firestoreAdminClient.ImportDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceImportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments_ResourceNames()
        {
            // Snippet: ImportDocuments(DatabaseName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = firestoreAdminClient.ImportDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceImportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsAsync_ResourceNames()
        {
            // Snippet: ImportDocumentsAsync(DatabaseName, CallSettings)
            // Additional: ImportDocumentsAsync(DatabaseName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = await firestoreAdminClient.ImportDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = await firestoreAdminClient.PollOnceImportDocumentsAsync(operationName);
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
