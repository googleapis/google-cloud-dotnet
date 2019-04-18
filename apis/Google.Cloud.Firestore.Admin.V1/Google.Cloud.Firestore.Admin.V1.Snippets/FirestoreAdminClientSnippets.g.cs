// Copyright 2019 Google LLC
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
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Firestore.Admin.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync()
        {
            // Snippet: CreateIndexAsync(ParentName,Index,CallSettings)
            // Additional: CreateIndexAsync(ParentName,Index,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            Index index = new Index();
            // Make the request
            Operation response = await firestoreAdminClient.CreateIndexAsync(parent, index);
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex()
        {
            // Snippet: CreateIndex(ParentName,Index,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            Index index = new Index();
            // Make the request
            Operation response = firestoreAdminClient.CreateIndex(parent, index);
            // End snippet
        }

        /// <summary>Snippet for CreateIndexAsync</summary>
        public async Task CreateIndexAsync_RequestObject()
        {
            // Snippet: CreateIndexAsync(CreateIndexRequest,CallSettings)
            // Additional: CreateIndexAsync(CreateIndexRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            // Make the request
            Operation response = await firestoreAdminClient.CreateIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIndex</summary>
        public void CreateIndex_RequestObject()
        {
            // Snippet: CreateIndex(CreateIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            CreateIndexRequest request = new CreateIndexRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
                Index = new Index(),
            };
            // Make the request
            Operation response = firestoreAdminClient.CreateIndex(request);
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesAsync()
        {
            // Snippet: ListIndexesAsync(ParentName,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexesAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes()
        {
            // Snippet: ListIndexes(ParentName,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexes(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexesAsync</summary>
        public async Task ListIndexesAsync_RequestObject()
        {
            // Snippet: ListIndexesAsync(ListIndexesRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIndexes</summary>
        public void ListIndexes_RequestObject()
        {
            // Snippet: ListIndexes(ListIndexesRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListIndexesRequest request = new ListIndexesRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
            };
            // Make the request
            PagedEnumerable<ListIndexesResponse, Index> response =
                firestoreAdminClient.ListIndexes(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync()
        {
            // Snippet: GetIndexAsync(IndexName,CallSettings)
            // Additional: GetIndexAsync(IndexName,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex()
        {
            // Snippet: GetIndex(IndexName,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            // Make the request
            Index response = firestoreAdminClient.GetIndex(name);
            // End snippet
        }

        /// <summary>Snippet for GetIndexAsync</summary>
        public async Task GetIndexAsync_RequestObject()
        {
            // Snippet: GetIndexAsync(GetIndexRequest,CallSettings)
            // Additional: GetIndexAsync(GetIndexRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            // Make the request
            Index response = await firestoreAdminClient.GetIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIndex</summary>
        public void GetIndex_RequestObject()
        {
            // Snippet: GetIndex(GetIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            // Make the request
            Index response = firestoreAdminClient.GetIndex(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync()
        {
            // Snippet: DeleteIndexAsync(IndexName,CallSettings)
            // Additional: DeleteIndexAsync(IndexName,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex()
        {
            // Snippet: DeleteIndex(IndexName,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            IndexName name = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]");
            // Make the request
            firestoreAdminClient.DeleteIndex(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndexAsync</summary>
        public async Task DeleteIndexAsync_RequestObject()
        {
            // Snippet: DeleteIndexAsync(DeleteIndexRequest,CallSettings)
            // Additional: DeleteIndexAsync(DeleteIndexRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            // Make the request
            await firestoreAdminClient.DeleteIndexAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIndex</summary>
        public void DeleteIndex_RequestObject()
        {
            // Snippet: DeleteIndex(DeleteIndexRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = new IndexName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[INDEX_ID]"),
            };
            // Make the request
            firestoreAdminClient.DeleteIndex(request);
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsAsync()
        {
            // Snippet: ImportDocumentsAsync(DatabaseName,CallSettings)
            // Additional: ImportDocumentsAsync(DatabaseName,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation response = await firestoreAdminClient.ImportDocumentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments()
        {
            // Snippet: ImportDocuments(DatabaseName,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation response = firestoreAdminClient.ImportDocuments(name);
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsAsync_RequestObject()
        {
            // Snippet: ImportDocumentsAsync(ImportDocumentsRequest,CallSettings)
            // Additional: ImportDocumentsAsync(ImportDocumentsRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Operation response = await firestoreAdminClient.ImportDocumentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments_RequestObject()
        {
            // Snippet: ImportDocuments(ImportDocumentsRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Operation response = firestoreAdminClient.ImportDocuments(request);
            // End snippet
        }

        /// <summary>Snippet for ExportDocumentsAsync</summary>
        public async Task ExportDocumentsAsync()
        {
            // Snippet: ExportDocumentsAsync(DatabaseName,CallSettings)
            // Additional: ExportDocumentsAsync(DatabaseName,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation response = await firestoreAdminClient.ExportDocumentsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportDocuments</summary>
        public void ExportDocuments()
        {
            // Snippet: ExportDocuments(DatabaseName,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = new DatabaseName("[PROJECT]", "[DATABASE]");
            // Make the request
            Operation response = firestoreAdminClient.ExportDocuments(name);
            // End snippet
        }

        /// <summary>Snippet for ExportDocumentsAsync</summary>
        public async Task ExportDocumentsAsync_RequestObject()
        {
            // Snippet: ExportDocumentsAsync(ExportDocumentsRequest,CallSettings)
            // Additional: ExportDocumentsAsync(ExportDocumentsRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Operation response = await firestoreAdminClient.ExportDocumentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportDocuments</summary>
        public void ExportDocuments_RequestObject()
        {
            // Snippet: ExportDocuments(ExportDocumentsRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ExportDocumentsRequest request = new ExportDocumentsRequest
            {
                DatabaseName = new DatabaseName("[PROJECT]", "[DATABASE]"),
            };
            // Make the request
            Operation response = firestoreAdminClient.ExportDocuments(request);
            // End snippet
        }

        /// <summary>Snippet for GetFieldAsync</summary>
        public async Task GetFieldAsync()
        {
            // Snippet: GetFieldAsync(FieldName,CallSettings)
            // Additional: GetFieldAsync(FieldName,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            FieldName name = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]");
            // Make the request
            apis::Field response = await firestoreAdminClient.GetFieldAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetField</summary>
        public void GetField()
        {
            // Snippet: GetField(FieldName,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            FieldName name = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]");
            // Make the request
            apis::Field response = firestoreAdminClient.GetField(name);
            // End snippet
        }

        /// <summary>Snippet for GetFieldAsync</summary>
        public async Task GetFieldAsync_RequestObject()
        {
            // Snippet: GetFieldAsync(GetFieldRequest,CallSettings)
            // Additional: GetFieldAsync(GetFieldRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            // Make the request
            apis::Field response = await firestoreAdminClient.GetFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetField</summary>
        public void GetField_RequestObject()
        {
            // Snippet: GetField(GetFieldRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = new FieldName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]", "[FIELD_ID]"),
            };
            // Make the request
            apis::Field response = firestoreAdminClient.GetField(request);
            // End snippet
        }

        /// <summary>Snippet for ListFieldsAsync</summary>
        public async Task ListFieldsAsync()
        {
            // Snippet: ListFieldsAsync(ParentName,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            // Make the request
            PagedAsyncEnumerable<ListFieldsResponse, apis::Field> response =
                firestoreAdminClient.ListFieldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Field item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Field item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Field> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Field item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public void ListFields()
        {
            // Snippet: ListFields(ParentName,string,int?,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ParentName parent = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]");
            // Make the request
            PagedEnumerable<ListFieldsResponse, apis::Field> response =
                firestoreAdminClient.ListFields(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Field item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Field item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Field> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Field item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFieldsAsync</summary>
        public async Task ListFieldsAsync_RequestObject()
        {
            // Snippet: ListFieldsAsync(ListFieldsRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListFieldsRequest request = new ListFieldsRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFieldsResponse, apis::Field> response =
                firestoreAdminClient.ListFieldsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((apis::Field item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Field item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Field> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Field item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFields</summary>
        public void ListFields_RequestObject()
        {
            // Snippet: ListFields(ListFieldsRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            ListFieldsRequest request = new ListFieldsRequest
            {
                ParentAsParentName = new ParentName("[PROJECT]", "[DATABASE]", "[COLLECTION_ID]"),
            };
            // Make the request
            PagedEnumerable<ListFieldsResponse, apis::Field> response =
                firestoreAdminClient.ListFields(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (apis::Field item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (apis::Field item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<apis::Field> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (apis::Field item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateFieldAsync</summary>
        public async Task UpdateFieldAsync()
        {
            // Snippet: UpdateFieldAsync(apis::Field,CallSettings)
            // Additional: UpdateFieldAsync(apis::Field,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            apis::Field field = new apis::Field();
            // Make the request
            Operation response = await firestoreAdminClient.UpdateFieldAsync(field);
            // End snippet
        }

        /// <summary>Snippet for UpdateField</summary>
        public void UpdateField()
        {
            // Snippet: UpdateField(apis::Field,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            apis::Field field = new apis::Field();
            // Make the request
            Operation response = firestoreAdminClient.UpdateField(field);
            // End snippet
        }

        /// <summary>Snippet for UpdateFieldAsync</summary>
        public async Task UpdateFieldAsync_RequestObject()
        {
            // Snippet: UpdateFieldAsync(UpdateFieldRequest,CallSettings)
            // Additional: UpdateFieldAsync(UpdateFieldRequest,CancellationToken)
            // Create client
            FirestoreAdminClient firestoreAdminClient = await FirestoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            // Make the request
            Operation response = await firestoreAdminClient.UpdateFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateField</summary>
        public void UpdateField_RequestObject()
        {
            // Snippet: UpdateField(UpdateFieldRequest,CallSettings)
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            UpdateFieldRequest request = new UpdateFieldRequest
            {
                Field = new apis::Field(),
            };
            // Make the request
            Operation response = firestoreAdminClient.UpdateField(request);
            // End snippet
        }

    }
}
