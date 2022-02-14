// Copyright 2022 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcfav = Google.Cloud.Firestore.Admin.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexRequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Index = new gcfav::Index(),
            };
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexRequestObjectAsync()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest, CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Index = new gcfav::Index(),
            };
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
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
            gcfav::Index index = new gcfav::Index();
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
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
            gcfav::Index index = new gcfav::Index();
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndexResourceNames()
        {
            // Snippet: CreateIndex(CollectionGroupName, Index, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            gcfav::Index index = new gcfav::Index();
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = firestoreAdminClient.CreateIndex(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceCreateIndex(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexResourceNamesAsync()
        {
            // Snippet: CreateIndexAsync(CollectionGroupName, Index, CallSettings)
            // Additional: CreateIndexAsync(CollectionGroupName, Index, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            gcfav::Index index = new gcfav::Index();
            // Make the request
            Operation<gcfav::Index, IndexOperationMetadata> response = await firestoreAdminClient.CreateIndexAsync(parent, index);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Index, IndexOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcfav::Index result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Index, IndexOperationMetadata> retrievedResponse = await firestoreAdminClient.PollOnceCreateIndexAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Index retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexesRequestObject()
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
            PagedEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
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
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsCollectionGroupName = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
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
            PagedEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
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
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/databases/[DATABASE]/collectionGroups/[COLLECTION]";
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
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
            // Snippet: ListIndexes(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcfav::Index item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIndexesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
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
            // Snippet: ListIndexesAsync(CollectionGroupName, string, int?, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CollectionGroupName parent = CollectionGroupName.FromProjectDatabaseCollection("[PROJECT]", "[DATABASE]", "[COLLECTION]");
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, gcfav::Index> response = firestoreAdminClient.ListIndexesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcfav::Index item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIndexesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcfav::Index item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcfav::Index> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcfav::Index item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexRequestObject()
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
            gcfav::Index response = firestoreAdminClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexRequestObjectAsync()
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
            gcfav::Index response = await firestoreAdminClient.GetIndexAsync(request);
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
            gcfav::Index response = firestoreAdminClient.GetIndex(name);
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
            gcfav::Index response = await firestoreAdminClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndexResourceNames()
        {
            // Snippet: GetIndex(IndexName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            gcfav::Index response = firestoreAdminClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexResourceNamesAsync()
        {
            // Snippet: GetIndexAsync(IndexName, CallSettings)
            // Additional: GetIndexAsync(IndexName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            IndexName name = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]");
            // Make the request
            gcfav::Index response = await firestoreAdminClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndexRequestObject()
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
        public async Task DeleteIndexRequestObjectAsync()
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
        public void DeleteIndexResourceNames()
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
        public async Task DeleteIndexResourceNamesAsync()
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
        public void GetFieldRequestObject()
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
        public async Task GetFieldRequestObjectAsync()
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
        public void GetFieldResourceNames()
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
        public async Task GetFieldResourceNamesAsync()
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
        public void UpdateFieldRequestObject()
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
        public async Task UpdateFieldRequestObjectAsync()
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
        public void ListFieldsRequestObject()
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

        /// <summary>Snippet for ListFieldsAsync</summary>
        public async Task ListFieldsRequestObjectAsync()
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

        /// <summary>Snippet for ListFieldsAsync</summary>
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
        public void ListFieldsResourceNames()
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

        /// <summary>Snippet for ListFieldsAsync</summary>
        public async Task ListFieldsResourceNamesAsync()
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
        public void ExportDocumentsRequestObject()
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
        public async Task ExportDocumentsRequestObjectAsync()
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
        public void ExportDocumentsResourceNames()
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
        public async Task ExportDocumentsResourceNamesAsync()
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
        public void ImportDocumentsRequestObject()
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
        public async Task ImportDocumentsRequestObjectAsync()
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
        public void ImportDocumentsResourceNames()
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
        public async Task ImportDocumentsResourceNamesAsync()
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

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseRequestObject()
        {
            // Snippet: GetDatabase(GetDatabaseRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Database response = firestoreAdminClient.GetDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseRequestObjectAsync()
        {
            // Snippet: GetDatabaseAsync(GetDatabaseRequest, CallSettings)
            // Additional: GetDatabaseAsync(GetDatabaseRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Database response = await firestoreAdminClient.GetDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabase()
        {
            // Snippet: GetDatabase(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Database response = firestoreAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseAsync()
        {
            // Snippet: GetDatabaseAsync(string, CallSettings)
            // Additional: GetDatabaseAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Database response = await firestoreAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseResourceNames()
        {
            // Snippet: GetDatabase(DatabaseName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Database response = firestoreAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseResourceNamesAsync()
        {
            // Snippet: GetDatabaseAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]");
            // Make the request
            Database response = await firestoreAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesRequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ListDatabasesResponse response = firestoreAdminClient.ListDatabases(request);
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesRequestObjectAsync()
        {
            // Snippet: ListDatabasesAsync(ListDatabasesRequest, CallSettings)
            // Additional: ListDatabasesAsync(ListDatabasesRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ListDatabasesResponse response = await firestoreAdminClient.ListDatabasesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabases()
        {
            // Snippet: ListDatabases(string, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ListDatabasesResponse response = firestoreAdminClient.ListDatabases(parent);
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesAsync()
        {
            // Snippet: ListDatabasesAsync(string, CallSettings)
            // Additional: ListDatabasesAsync(string, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ListDatabasesResponse response = await firestoreAdminClient.ListDatabasesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesResourceNames()
        {
            // Snippet: ListDatabases(ProjectName, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ListDatabasesResponse response = firestoreAdminClient.ListDatabases(parent);
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesResourceNamesAsync()
        {
            // Snippet: ListDatabasesAsync(ProjectName, CallSettings)
            // Additional: ListDatabasesAsync(ProjectName, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ListDatabasesResponse response = await firestoreAdminClient.ListDatabasesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabase</summary>
        public void UpdateDatabaseRequestObject()
        {
            // Snippet: UpdateDatabase(UpdateDatabaseRequest, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            UpdateDatabaseRequest request = new UpdateDatabaseRequest
            {
                Database = new Database(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Database, UpdateDatabaseMetadata> response = firestoreAdminClient.UpdateDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, UpdateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, UpdateDatabaseMetadata> retrievedResponse = firestoreAdminClient.PollOnceUpdateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseAsync</summary>
        public async Task UpdateDatabaseRequestObjectAsync()
        {
            // Snippet: UpdateDatabaseAsync(UpdateDatabaseRequest, CallSettings)
            // Additional: UpdateDatabaseAsync(UpdateDatabaseRequest, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatabaseRequest request = new UpdateDatabaseRequest
            {
                Database = new Database(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Database, UpdateDatabaseMetadata> response = await firestoreAdminClient.UpdateDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, UpdateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, UpdateDatabaseMetadata> retrievedResponse = await firestoreAdminClient.PollOnceUpdateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabase</summary>
        public void UpdateDatabase()
        {
            // Snippet: UpdateDatabase(Database, FieldMask, CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            Database database = new Database();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Database, UpdateDatabaseMetadata> response = firestoreAdminClient.UpdateDatabase(database, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Database, UpdateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, UpdateDatabaseMetadata> retrievedResponse = firestoreAdminClient.PollOnceUpdateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseAsync</summary>
        public async Task UpdateDatabaseAsync()
        {
            // Snippet: UpdateDatabaseAsync(Database, FieldMask, CallSettings)
            // Additional: UpdateDatabaseAsync(Database, FieldMask, CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            Database database = new Database();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Database, UpdateDatabaseMetadata> response = await firestoreAdminClient.UpdateDatabaseAsync(database, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Database, UpdateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, UpdateDatabaseMetadata> retrievedResponse = await firestoreAdminClient.PollOnceUpdateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
