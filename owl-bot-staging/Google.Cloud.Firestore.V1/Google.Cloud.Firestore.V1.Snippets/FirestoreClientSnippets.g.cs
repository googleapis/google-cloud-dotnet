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
    using Google.Cloud.Firestore.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFirestoreClientSnippets
    {
        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentRequestObject()
        {
            // Snippet: GetDocument(GetDocumentRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                Name = "",
                Mask = new DocumentMask(),
                Transaction = ByteString.Empty,
            };
            // Make the request
            Document response = firestoreClient.GetDocument(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentRequestObjectAsync()
        {
            // Snippet: GetDocumentAsync(GetDocumentRequest, CallSettings)
            // Additional: GetDocumentAsync(GetDocumentRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                Name = "",
                Mask = new DocumentMask(),
                Transaction = ByteString.Empty,
            };
            // Make the request
            Document response = await firestoreClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocumentsRequestObject()
        {
            // Snippet: ListDocuments(ListDocumentsRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = "",
                CollectionId = "",
                OrderBy = "",
                Mask = new DocumentMask(),
                Transaction = ByteString.Empty,
                ShowMissing = false,
            };
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = firestoreClient.ListDocuments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Document item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Document item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Document> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Document item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDocumentsAsync</summary>
        public async Task ListDocumentsRequestObjectAsync()
        {
            // Snippet: ListDocumentsAsync(ListDocumentsRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = "",
                CollectionId = "",
                OrderBy = "",
                Mask = new DocumentMask(),
                Transaction = ByteString.Empty,
                ShowMissing = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = firestoreClient.ListDocumentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Document item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDocumentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Document item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Document> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Document item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocumentRequestObject()
        {
            // Snippet: UpdateDocument(UpdateDocumentRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
                Mask = new DocumentMask(),
                CurrentDocument = new Precondition(),
            };
            // Make the request
            Document response = firestoreClient.UpdateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentRequestObjectAsync()
        {
            // Snippet: UpdateDocumentAsync(UpdateDocumentRequest, CallSettings)
            // Additional: UpdateDocumentAsync(UpdateDocumentRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
                Mask = new DocumentMask(),
                CurrentDocument = new Precondition(),
            };
            // Make the request
            Document response = await firestoreClient.UpdateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument()
        {
            // Snippet: UpdateDocument(Document, DocumentMask, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            // Make the request
            Document response = firestoreClient.UpdateDocument(document, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentAsync()
        {
            // Snippet: UpdateDocumentAsync(Document, DocumentMask, CallSettings)
            // Additional: UpdateDocumentAsync(Document, DocumentMask, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            // Make the request
            Document response = await firestoreClient.UpdateDocumentAsync(document, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocumentRequestObject()
        {
            // Snippet: DeleteDocument(DeleteDocumentRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "",
                CurrentDocument = new Precondition(),
            };
            // Make the request
            firestoreClient.DeleteDocument(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentRequestObjectAsync()
        {
            // Snippet: DeleteDocumentAsync(DeleteDocumentRequest, CallSettings)
            // Additional: DeleteDocumentAsync(DeleteDocumentRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "",
                CurrentDocument = new Precondition(),
            };
            // Make the request
            await firestoreClient.DeleteDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocument()
        {
            // Snippet: DeleteDocument(string, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            firestoreClient.DeleteDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentAsync()
        {
            // Snippet: DeleteDocumentAsync(string, CallSettings)
            // Additional: DeleteDocumentAsync(string, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await firestoreClient.DeleteDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocuments</summary>
        public async Task BatchGetDocumentsRequestObject()
        {
            // Snippet: BatchGetDocuments(BatchGetDocumentsRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            BatchGetDocumentsRequest request = new BatchGetDocumentsRequest
            {
                Database = "",
                Documents = { "", },
                Mask = new DocumentMask(),
                Transaction = ByteString.Empty,
            };
            // Make the request, returning a streaming response
            using FirestoreClient.BatchGetDocumentsStream response = firestoreClient.BatchGetDocuments(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<BatchGetDocumentsResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                BatchGetDocumentsResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransactionRequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "",
                Options = new TransactionOptions(),
            };
            // Make the request
            BeginTransactionResponse response = firestoreClient.BeginTransaction(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionRequestObjectAsync()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest, CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "",
                Options = new TransactionOptions(),
            };
            // Make the request
            BeginTransactionResponse response = await firestoreClient.BeginTransactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string database = "";
            // Make the request
            BeginTransactionResponse response = firestoreClient.BeginTransaction(database);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string, CallSettings)
            // Additional: BeginTransactionAsync(string, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string database = "";
            // Make the request
            BeginTransactionResponse response = await firestoreClient.BeginTransactionAsync(database);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void CommitRequestObject()
        {
            // Snippet: Commit(CommitRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Database = "",
                Writes = { new Write(), },
                Transaction = ByteString.Empty,
            };
            // Make the request
            CommitResponse response = firestoreClient.Commit(request);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitRequestObjectAsync()
        {
            // Snippet: CommitAsync(CommitRequest, CallSettings)
            // Additional: CommitAsync(CommitRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Database = "",
                Writes = { new Write(), },
                Transaction = ByteString.Empty,
            };
            // Make the request
            CommitResponse response = await firestoreClient.CommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit()
        {
            // Snippet: Commit(string, IEnumerable<Write>, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string database = "";
            IEnumerable<Write> writes = new Write[] { new Write(), };
            // Make the request
            CommitResponse response = firestoreClient.Commit(database, writes);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitAsync()
        {
            // Snippet: CommitAsync(string, IEnumerable<Write>, CallSettings)
            // Additional: CommitAsync(string, IEnumerable<Write>, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string database = "";
            IEnumerable<Write> writes = new Write[] { new Write(), };
            // Make the request
            CommitResponse response = await firestoreClient.CommitAsync(database, writes);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void RollbackRequestObject()
        {
            // Snippet: Rollback(RollbackRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Database = "",
                Transaction = ByteString.Empty,
            };
            // Make the request
            firestoreClient.Rollback(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackRequestObjectAsync()
        {
            // Snippet: RollbackAsync(RollbackRequest, CallSettings)
            // Additional: RollbackAsync(RollbackRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Database = "",
                Transaction = ByteString.Empty,
            };
            // Make the request
            await firestoreClient.RollbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback()
        {
            // Snippet: Rollback(string, ByteString, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string database = "";
            ByteString transaction = ByteString.Empty;
            // Make the request
            firestoreClient.Rollback(database, transaction);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(string, ByteString, CallSettings)
            // Additional: RollbackAsync(string, ByteString, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string database = "";
            ByteString transaction = ByteString.Empty;
            // Make the request
            await firestoreClient.RollbackAsync(database, transaction);
            // End snippet
        }

        /// <summary>Snippet for RunQuery</summary>
        public async Task RunQueryRequestObject()
        {
            // Snippet: RunQuery(RunQueryRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            RunQueryRequest request = new RunQueryRequest
            {
                Parent = "",
                StructuredQuery = new StructuredQuery(),
                Transaction = ByteString.Empty,
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request, returning a streaming response
            using FirestoreClient.RunQueryStream response = firestoreClient.RunQuery(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<RunQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                RunQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for RunAggregationQuery</summary>
        public async Task RunAggregationQueryRequestObject()
        {
            // Snippet: RunAggregationQuery(RunAggregationQueryRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            RunAggregationQueryRequest request = new RunAggregationQueryRequest
            {
                Parent = "",
                StructuredAggregationQuery = new StructuredAggregationQuery(),
                Transaction = ByteString.Empty,
                ExplainOptions = new ExplainOptions(),
            };
            // Make the request, returning a streaming response
            using FirestoreClient.RunAggregationQueryStream response = firestoreClient.RunAggregationQuery(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<RunAggregationQueryResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                RunAggregationQueryResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for PartitionQuery</summary>
        public void PartitionQueryRequestObject()
        {
            // Snippet: PartitionQuery(PartitionQueryRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                Parent = "",
                StructuredQuery = new StructuredQuery(),
                PartitionCount = 0L,
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<PartitionQueryResponse, Cursor> response = firestoreClient.PartitionQuery(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cursor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (PartitionQueryResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cursor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cursor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cursor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PartitionQueryAsync</summary>
        public async Task PartitionQueryRequestObjectAsync()
        {
            // Snippet: PartitionQueryAsync(PartitionQueryRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                Parent = "",
                StructuredQuery = new StructuredQuery(),
                PartitionCount = 0L,
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<PartitionQueryResponse, Cursor> response = firestoreClient.PartitionQueryAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cursor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((PartitionQueryResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cursor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cursor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cursor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Write</summary>
        public async Task Write()
        {
            // Snippet: Write(CallSettings, BidirectionalStreamingSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize streaming call, retrieving the stream object
            using FirestoreClient.WriteStream response = firestoreClient.Write();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<WriteResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    WriteResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                WriteRequest request = new WriteRequest
                {
                    Database = "",
                    StreamId = "",
                    Writes = { new Write(), },
                    StreamToken = ByteString.Empty,
                    Labels = { { "", "" }, },
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for Listen</summary>
        public async Task Listen()
        {
            // Snippet: Listen(CallSettings, BidirectionalStreamingSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize streaming call, retrieving the stream object
            using FirestoreClient.ListenStream response = firestoreClient.Listen();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<ListenResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    ListenResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                ListenRequest request = new ListenRequest
                {
                    Database = "",
                    AddTarget = new Target(),
                    Labels = { { "", "" }, },
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIds</summary>
        public void ListCollectionIdsRequestObject()
        {
            // Snippet: ListCollectionIds(ListCollectionIdsRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
            {
                Parent = "",
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListCollectionIdsResponse, string> response = firestoreClient.ListCollectionIds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCollectionIdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIdsAsync</summary>
        public async Task ListCollectionIdsRequestObjectAsync()
        {
            // Snippet: ListCollectionIdsAsync(ListCollectionIdsRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
            {
                Parent = "",
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListCollectionIdsResponse, string> response = firestoreClient.ListCollectionIdsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCollectionIdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIds</summary>
        public void ListCollectionIds()
        {
            // Snippet: ListCollectionIds(string, string, int?, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListCollectionIdsResponse, string> response = firestoreClient.ListCollectionIds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCollectionIdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIdsAsync</summary>
        public async Task ListCollectionIdsAsync()
        {
            // Snippet: ListCollectionIdsAsync(string, string, int?, CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListCollectionIdsResponse, string> response = firestoreClient.ListCollectionIdsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCollectionIdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchWrite</summary>
        public void BatchWriteRequestObject()
        {
            // Snippet: BatchWrite(BatchWriteRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            BatchWriteRequest request = new BatchWriteRequest
            {
                Database = "",
                Writes = { new Write(), },
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchWriteResponse response = firestoreClient.BatchWrite(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteAsync</summary>
        public async Task BatchWriteRequestObjectAsync()
        {
            // Snippet: BatchWriteAsync(BatchWriteRequest, CallSettings)
            // Additional: BatchWriteAsync(BatchWriteRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            BatchWriteRequest request = new BatchWriteRequest
            {
                Database = "",
                Writes = { new Write(), },
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchWriteResponse response = await firestoreClient.BatchWriteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentRequestObject()
        {
            // Snippet: CreateDocument(CreateDocumentRequest, CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = "",
                CollectionId = "",
                DocumentId = "",
                Document = new Document(),
                Mask = new DocumentMask(),
            };
            // Make the request
            Document response = firestoreClient.CreateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentRequestObjectAsync()
        {
            // Snippet: CreateDocumentAsync(CreateDocumentRequest, CallSettings)
            // Additional: CreateDocumentAsync(CreateDocumentRequest, CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = "",
                CollectionId = "",
                DocumentId = "",
                Document = new Document(),
                Mask = new DocumentMask(),
            };
            // Make the request
            Document response = await firestoreClient.CreateDocumentAsync(request);
            // End snippet
        }
    }
}
