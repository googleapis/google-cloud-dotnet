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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentsClientSnippets
    {
        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocumentsRequestObject()
        {
            // Snippet: ListDocuments(ListDocumentsRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocuments(request);

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
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocumentsAsync(request);

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

        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocuments()
        {
            // Snippet: ListDocuments(string, string, int?, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocuments(parent);

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
        public async Task ListDocumentsAsync()
        {
            // Snippet: ListDocumentsAsync(string, string, int?, CallSettings)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocumentsAsync(parent);

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

        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocumentsResourceNames()
        {
            // Snippet: ListDocuments(KnowledgeBaseName, string, int?, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            KnowledgeBaseName parent = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocuments(parent);

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
        public async Task ListDocumentsResourceNamesAsync()
        {
            // Snippet: ListDocumentsAsync(KnowledgeBaseName, string, int?, CallSettings)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBaseName parent = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentsClient.ListDocumentsAsync(parent);

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

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentRequestObject()
        {
            // Snippet: GetDocument(GetDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            // Make the request
            Document response = documentsClient.GetDocument(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentRequestObjectAsync()
        {
            // Snippet: GetDocumentAsync(GetDocumentRequest, CallSettings)
            // Additional: GetDocumentAsync(GetDocumentRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            // Make the request
            Document response = await documentsClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocument()
        {
            // Snippet: GetDocument(string, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            // Make the request
            Document response = documentsClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentAsync()
        {
            // Snippet: GetDocumentAsync(string, CallSettings)
            // Additional: GetDocumentAsync(string, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            // Make the request
            Document response = await documentsClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentResourceNames()
        {
            // Snippet: GetDocument(DocumentName, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            // Make the request
            Document response = documentsClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentResourceNamesAsync()
        {
            // Snippet: GetDocumentAsync(DocumentName, CallSettings)
            // Additional: GetDocumentAsync(DocumentName, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            // Make the request
            Document response = await documentsClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentRequestObject()
        {
            // Snippet: CreateDocument(CreateDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Document = new Document(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.CreateDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceCreateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentRequestObjectAsync()
        {
            // Snippet: CreateDocumentAsync(CreateDocumentRequest, CallSettings)
            // Additional: CreateDocumentAsync(CreateDocumentRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Document = new Document(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.CreateDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceCreateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocument()
        {
            // Snippet: CreateDocument(string, Document, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.CreateDocument(parent, document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceCreateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentAsync()
        {
            // Snippet: CreateDocumentAsync(string, Document, CallSettings)
            // Additional: CreateDocumentAsync(string, Document, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]";
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.CreateDocumentAsync(parent, document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceCreateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentResourceNames()
        {
            // Snippet: CreateDocument(KnowledgeBaseName, Document, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            KnowledgeBaseName parent = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.CreateDocument(parent, document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceCreateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentResourceNamesAsync()
        {
            // Snippet: CreateDocumentAsync(KnowledgeBaseName, Document, CallSettings)
            // Additional: CreateDocumentAsync(KnowledgeBaseName, Document, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            KnowledgeBaseName parent = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]");
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.CreateDocumentAsync(parent, document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceCreateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocumentsRequestObject()
        {
            // Snippet: ImportDocuments(ImportDocumentsRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                GcsSource = new GcsSources(),
                DocumentTemplate = new ImportDocumentTemplate(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> response = documentsClient.ImportDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceImportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportDocumentsAsync</summary>
        public async Task ImportDocumentsRequestObjectAsync()
        {
            // Snippet: ImportDocumentsAsync(ImportDocumentsRequest, CallSettings)
            // Additional: ImportDocumentsAsync(ImportDocumentsRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                ParentAsKnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                GcsSource = new GcsSources(),
                DocumentTemplate = new ImportDocumentTemplate(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> response = await documentsClient.ImportDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDocumentsResponse, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceImportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocumentRequestObject()
        {
            // Snippet: DeleteDocument(DeleteDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = documentsClient.DeleteDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceDeleteDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentRequestObjectAsync()
        {
            // Snippet: DeleteDocumentAsync(DeleteDocumentRequest, CallSettings)
            // Additional: DeleteDocumentAsync(DeleteDocumentRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = await documentsClient.DeleteDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceDeleteDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocument()
        {
            // Snippet: DeleteDocument(string, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = documentsClient.DeleteDocument(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceDeleteDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentAsync()
        {
            // Snippet: DeleteDocumentAsync(string, CallSettings)
            // Additional: DeleteDocumentAsync(string, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = await documentsClient.DeleteDocumentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceDeleteDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocumentResourceNames()
        {
            // Snippet: DeleteDocument(DocumentName, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = documentsClient.DeleteDocument(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceDeleteDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentResourceNamesAsync()
        {
            // Snippet: DeleteDocumentAsync(DocumentName, CallSettings)
            // Additional: DeleteDocumentAsync(DocumentName, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            // Make the request
            Operation<Empty, KnowledgeOperationMetadata> response = await documentsClient.DeleteDocumentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceDeleteDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocumentRequestObject()
        {
            // Snippet: UpdateDocument(UpdateDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.UpdateDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceUpdateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentRequestObjectAsync()
        {
            // Snippet: UpdateDocumentAsync(UpdateDocumentRequest, CallSettings)
            // Additional: UpdateDocumentAsync(UpdateDocumentRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.UpdateDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceUpdateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument1()
        {
            // Snippet: UpdateDocument(Document, FieldMask, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.UpdateDocument(document, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceUpdateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocument1Async()
        {
            // Snippet: UpdateDocumentAsync(Document, FieldMask, CallSettings)
            // Additional: UpdateDocumentAsync(Document, FieldMask, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.UpdateDocumentAsync(document, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceUpdateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument2()
        {
            // Snippet: UpdateDocument(Document, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.UpdateDocument(document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceUpdateDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocument2Async()
        {
            // Snippet: UpdateDocumentAsync(Document, CallSettings)
            // Additional: UpdateDocumentAsync(Document, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.UpdateDocumentAsync(document);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceUpdateDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocument</summary>
        public void ReloadDocumentRequestObject()
        {
            // Snippet: ReloadDocument(ReloadDocumentRequest, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            ReloadDocumentRequest request = new ReloadDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                GcsSource = new GcsSource(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.ReloadDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceReloadDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocumentAsync</summary>
        public async Task ReloadDocumentRequestObjectAsync()
        {
            // Snippet: ReloadDocumentAsync(ReloadDocumentRequest, CallSettings)
            // Additional: ReloadDocumentAsync(ReloadDocumentRequest, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            ReloadDocumentRequest request = new ReloadDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                GcsSource = new GcsSource(),
                ImportGcsCustomMetadata = false,
            };
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.ReloadDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceReloadDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocument</summary>
        public void ReloadDocument()
        {
            // Snippet: ReloadDocument(string, GcsSource, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.ReloadDocument(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceReloadDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocumentAsync</summary>
        public async Task ReloadDocumentAsync()
        {
            // Snippet: ReloadDocumentAsync(string, GcsSource, CallSettings)
            // Additional: ReloadDocumentAsync(string, GcsSource, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/knowledgeBases/[KNOWLEDGE_BASE]/documents/[DOCUMENT]";
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.ReloadDocumentAsync(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceReloadDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocument</summary>
        public void ReloadDocumentResourceNames()
        {
            // Snippet: ReloadDocument(DocumentName, GcsSource, CallSettings)
            // Create client
            DocumentsClient documentsClient = DocumentsClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = documentsClient.ReloadDocument(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = documentsClient.PollOnceReloadDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReloadDocumentAsync</summary>
        public async Task ReloadDocumentResourceNamesAsync()
        {
            // Snippet: ReloadDocumentAsync(DocumentName, GcsSource, CallSettings)
            // Additional: ReloadDocumentAsync(DocumentName, GcsSource, CancellationToken)
            // Create client
            DocumentsClient documentsClient = await DocumentsClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]");
            GcsSource gcsSource = new GcsSource();
            // Make the request
            Operation<Document, KnowledgeOperationMetadata> response = await documentsClient.ReloadDocumentAsync(name, gcsSource);

            // Poll until the returned long-running operation is complete
            Operation<Document, KnowledgeOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Document result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Document, KnowledgeOperationMetadata> retrievedResponse = await documentsClient.PollOnceReloadDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Document retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
