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

namespace Google.Cloud.Firestore.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Firestore.V1;
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
    public class GeneratedFirestoreClientSnippets
    {
        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentAsync_RequestObject()
        {
            // Snippet: GetDocumentAsync(GetDocumentRequest,CallSettings)
            // Additional: GetDocumentAsync(GetDocumentRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            // Make the request
            Document response = await firestoreClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocument_RequestObject()
        {
            // Snippet: GetDocument(GetDocumentRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            // Make the request
            Document response = firestoreClient.GetDocument(request);
            // End snippet
        }

        /// <summary>Snippet for ListDocumentsAsync</summary>
        public async Task ListDocumentsAsync_RequestObject()
        {
            // Snippet: ListDocumentsAsync(ListDocumentsRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response =
                firestoreClient.ListDocumentsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocuments_RequestObject()
        {
            // Snippet: ListDocuments(ListDocumentsRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "",
            };
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response =
                firestoreClient.ListDocuments(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentAsync_RequestObject()
        {
            // Snippet: CreateDocumentAsync(CreateDocumentRequest,CallSettings)
            // Additional: CreateDocumentAsync(CreateDocumentRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "",
                DocumentId = "",
                Document = new Document(),
            };
            // Make the request
            Document response = await firestoreClient.CreateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocument_RequestObject()
        {
            // Snippet: CreateDocument(CreateDocumentRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "",
                DocumentId = "",
                Document = new Document(),
            };
            // Make the request
            Document response = firestoreClient.CreateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentAsync()
        {
            // Snippet: UpdateDocumentAsync(Document,DocumentMask,CallSettings)
            // Additional: UpdateDocumentAsync(Document,DocumentMask,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            // Make the request
            Document response = await firestoreClient.UpdateDocumentAsync(document, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument()
        {
            // Snippet: UpdateDocument(Document,DocumentMask,CallSettings)
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
        public async Task UpdateDocumentAsync_RequestObject()
        {
            // Snippet: UpdateDocumentAsync(UpdateDocumentRequest,CallSettings)
            // Additional: UpdateDocumentAsync(UpdateDocumentRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            // Make the request
            Document response = await firestoreClient.UpdateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument_RequestObject()
        {
            // Snippet: UpdateDocument(UpdateDocumentRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            // Make the request
            Document response = firestoreClient.UpdateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentAsync()
        {
            // Snippet: DeleteDocumentAsync(AnyPathName,CallSettings)
            // Additional: DeleteDocumentAsync(AnyPathName,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            AnyPathName name = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]");
            // Make the request
            await firestoreClient.DeleteDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocument()
        {
            // Snippet: DeleteDocument(AnyPathName,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            AnyPathName name = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]");
            // Make the request
            firestoreClient.DeleteDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentAsync_RequestObject()
        {
            // Snippet: DeleteDocumentAsync(DeleteDocumentRequest,CallSettings)
            // Additional: DeleteDocumentAsync(DeleteDocumentRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            // Make the request
            await firestoreClient.DeleteDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocument_RequestObject()
        {
            // Snippet: DeleteDocument(DeleteDocumentRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            // Make the request
            firestoreClient.DeleteDocument(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocuments</summary>
        public async Task BatchGetDocuments()
        {
            // Snippet: BatchGetDocuments(BatchGetDocumentsRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument
            BatchGetDocumentsRequest request = new BatchGetDocumentsRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Documents = { },
            };
            // Make the request, returning a streaming response
            FirestoreClient.BatchGetDocumentsStream streamingResponse = firestoreClient.BatchGetDocuments(request);

            // Read streaming responses from server until complete
            var responseStream = streamingResponse.GrpcCall.ResponseStream;
            while (await responseStream.MoveNext())
            {
                BatchGetDocumentsResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string,CallSettings)
            // Additional: BeginTransactionAsync(string,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            // Make the request
            BeginTransactionResponse response = await firestoreClient.BeginTransactionAsync(formattedDatabase);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            // Make the request
            BeginTransactionResponse response = firestoreClient.BeginTransaction(formattedDatabase);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync_RequestObject()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest,CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            // Make the request
            BeginTransactionResponse response = await firestoreClient.BeginTransactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction_RequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            // Make the request
            BeginTransactionResponse response = firestoreClient.BeginTransaction(request);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitAsync()
        {
            // Snippet: CommitAsync(string,IEnumerable<Write>,CallSettings)
            // Additional: CommitAsync(string,IEnumerable<Write>,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            IEnumerable<Write> writes = new List<Write>();
            // Make the request
            CommitResponse response = await firestoreClient.CommitAsync(formattedDatabase, writes);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit()
        {
            // Snippet: Commit(string,IEnumerable<Write>,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            IEnumerable<Write> writes = new List<Write>();
            // Make the request
            CommitResponse response = firestoreClient.Commit(formattedDatabase, writes);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitAsync_RequestObject()
        {
            // Snippet: CommitAsync(CommitRequest,CallSettings)
            // Additional: CommitAsync(CommitRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            // Make the request
            CommitResponse response = await firestoreClient.CommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit_RequestObject()
        {
            // Snippet: Commit(CommitRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            // Make the request
            CommitResponse response = firestoreClient.Commit(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(string,ByteString,CallSettings)
            // Additional: RollbackAsync(string,ByteString,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            ByteString transaction = ByteString.Empty;
            // Make the request
            await firestoreClient.RollbackAsync(formattedDatabase, transaction);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback()
        {
            // Snippet: Rollback(string,ByteString,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            ByteString transaction = ByteString.Empty;
            // Make the request
            firestoreClient.Rollback(formattedDatabase, transaction);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync_RequestObject()
        {
            // Snippet: RollbackAsync(RollbackRequest,CallSettings)
            // Additional: RollbackAsync(RollbackRequest,CancellationToken)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.Empty,
            };
            // Make the request
            await firestoreClient.RollbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback_RequestObject()
        {
            // Snippet: Rollback(RollbackRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.Empty,
            };
            // Make the request
            firestoreClient.Rollback(request);
            // End snippet
        }

        /// <summary>Snippet for RunQuery</summary>
        public async Task RunQuery()
        {
            // Snippet: RunQuery(RunQueryRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument
            RunQueryRequest request = new RunQueryRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
            };
            // Make the request, returning a streaming response
            FirestoreClient.RunQueryStream streamingResponse = firestoreClient.RunQuery(request);

            // Read streaming responses from server until complete
            var responseStream = streamingResponse.GrpcCall.ResponseStream;
            while (await responseStream.MoveNext())
            {
                RunQueryResponse response = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for Write</summary>
        public async Task Write()
        {
            // Snippet: Write(CallSettings,BidirectionalStreamingSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize streaming call, retrieving the stream object
            FirestoreClient.WriteStream duplexStream = firestoreClient.Write();

            // Sending requests and retrieving responses can be arbitrarily interleaved.
            // Exact sequence will depend on client/server behavior.

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                var responseStream = duplexStream.GrpcCall.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    WriteResponse response = responseStream.Current;
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
                    Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                };
                // Stream a request to the server
                await duplexStream.WriteAsync(request);

                // Set "done" to true when sending requests is complete
            }
            // Complete writing requests to the stream
            await duplexStream.WriteCompleteAsync();
            // Await the response handler.
            // This will complete once all server responses have been processed.
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for Listen</summary>
        public async Task Listen()
        {
            // Snippet: Listen(CallSettings,BidirectionalStreamingSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize streaming call, retrieving the stream object
            FirestoreClient.ListenStream duplexStream = firestoreClient.Listen();

            // Sending requests and retrieving responses can be arbitrarily interleaved.
            // Exact sequence will depend on client/server behavior.

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                var responseStream = duplexStream.GrpcCall.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    ListenResponse response = responseStream.Current;
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
                    Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                };
                // Stream a request to the server
                await duplexStream.WriteAsync(request);

                // Set "done" to true when sending requests is complete
            }
            // Complete writing requests to the stream
            await duplexStream.WriteCompleteAsync();
            // Await the response handler.
            // This will complete once all server responses have been processed.
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIdsAsync</summary>
        public async Task ListCollectionIdsAsync()
        {
            // Snippet: ListCollectionIdsAsync(string,string,int?,CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListCollectionIdsResponse, string> response =
                firestoreClient.ListCollectionIdsAsync(formattedParent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIds</summary>
        public void ListCollectionIds()
        {
            // Snippet: ListCollectionIds(string,string,int?,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            string formattedParent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString();
            // Make the request
            PagedEnumerable<ListCollectionIdsResponse, string> response =
                firestoreClient.ListCollectionIds(formattedParent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIdsAsync</summary>
        public async Task ListCollectionIdsAsync_RequestObject()
        {
            // Snippet: ListCollectionIdsAsync(ListCollectionIdsRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = await FirestoreClient.CreateAsync();
            // Initialize request argument(s)
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListCollectionIdsResponse, string> response =
                firestoreClient.ListCollectionIdsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCollectionIds</summary>
        public void ListCollectionIds_RequestObject()
        {
            // Snippet: ListCollectionIds(ListCollectionIdsRequest,CallSettings)
            // Create client
            FirestoreClient firestoreClient = FirestoreClient.Create();
            // Initialize request argument(s)
            ListCollectionIdsRequest request = new ListCollectionIdsRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListCollectionIdsResponse, string> response =
                firestoreClient.ListCollectionIds(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
