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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentServiceClientSnippets
    {
        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentRequestObject()
        {
            // Snippet: GetDocument(GetDocumentRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            // Make the request
            Document response = documentServiceClient.GetDocument(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentRequestObjectAsync()
        {
            // Snippet: GetDocumentAsync(GetDocumentRequest, CallSettings)
            // Additional: GetDocumentAsync(GetDocumentRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            // Make the request
            Document response = await documentServiceClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocument()
        {
            // Snippet: GetDocument(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]/documents/[DOCUMENT]";
            // Make the request
            Document response = documentServiceClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentAsync()
        {
            // Snippet: GetDocumentAsync(string, CallSettings)
            // Additional: GetDocumentAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]/documents/[DOCUMENT]";
            // Make the request
            Document response = await documentServiceClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentResourceNames()
        {
            // Snippet: GetDocument(DocumentName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]");
            // Make the request
            Document response = documentServiceClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentResourceNamesAsync()
        {
            // Snippet: GetDocumentAsync(DocumentName, CallSettings)
            // Additional: GetDocumentAsync(DocumentName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]");
            // Make the request
            Document response = await documentServiceClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDocuments</summary>
        public void ListDocumentsRequestObject()
        {
            // Snippet: ListDocuments(ListDocumentsRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
            };
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocuments(request);

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
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDocumentsRequest request = new ListDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocumentsAsync(request);

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
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocuments(parent);

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
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocumentsAsync(parent);

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
            // Snippet: ListDocuments(BranchName, string, int?, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            // Make the request
            PagedEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocuments(parent);

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
            // Snippet: ListDocumentsAsync(BranchName, string, int?, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, Document> response = documentServiceClient.ListDocumentsAsync(parent);

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

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentRequestObject()
        {
            // Snippet: CreateDocument(CreateDocumentRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "",
            };
            // Make the request
            Document response = documentServiceClient.CreateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentRequestObjectAsync()
        {
            // Snippet: CreateDocumentAsync(CreateDocumentRequest, CallSettings)
            // Additional: CreateDocumentAsync(CreateDocumentRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "",
            };
            // Make the request
            Document response = await documentServiceClient.CreateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocument()
        {
            // Snippet: CreateDocument(string, Document, string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            Document document = new Document();
            string documentId = "";
            // Make the request
            Document response = documentServiceClient.CreateDocument(parent, document, documentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentAsync()
        {
            // Snippet: CreateDocumentAsync(string, Document, string, CallSettings)
            // Additional: CreateDocumentAsync(string, Document, string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            Document document = new Document();
            string documentId = "";
            // Make the request
            Document response = await documentServiceClient.CreateDocumentAsync(parent, document, documentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDocument</summary>
        public void CreateDocumentResourceNames()
        {
            // Snippet: CreateDocument(BranchName, Document, string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            Document document = new Document();
            string documentId = "";
            // Make the request
            Document response = documentServiceClient.CreateDocument(parent, document, documentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDocumentAsync</summary>
        public async Task CreateDocumentResourceNamesAsync()
        {
            // Snippet: CreateDocumentAsync(BranchName, Document, string, CallSettings)
            // Additional: CreateDocumentAsync(BranchName, Document, string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            Document document = new Document();
            string documentId = "";
            // Make the request
            Document response = await documentServiceClient.CreateDocumentAsync(parent, document, documentId);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocumentRequestObject()
        {
            // Snippet: UpdateDocument(UpdateDocumentRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                AllowMissing = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Document response = documentServiceClient.UpdateDocument(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentRequestObjectAsync()
        {
            // Snippet: UpdateDocumentAsync(UpdateDocumentRequest, CallSettings)
            // Additional: UpdateDocumentAsync(UpdateDocumentRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                AllowMissing = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Document response = await documentServiceClient.UpdateDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocument</summary>
        public void UpdateDocument()
        {
            // Snippet: UpdateDocument(Document, FieldMask, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Document response = documentServiceClient.UpdateDocument(document, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDocumentAsync</summary>
        public async Task UpdateDocumentAsync()
        {
            // Snippet: UpdateDocumentAsync(Document, FieldMask, CallSettings)
            // Additional: UpdateDocumentAsync(Document, FieldMask, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Document document = new Document();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Document response = await documentServiceClient.UpdateDocumentAsync(document, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocumentRequestObject()
        {
            // Snippet: DeleteDocument(DeleteDocumentRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            // Make the request
            documentServiceClient.DeleteDocument(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentRequestObjectAsync()
        {
            // Snippet: DeleteDocumentAsync(DeleteDocumentRequest, CallSettings)
            // Additional: DeleteDocumentAsync(DeleteDocumentRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            // Make the request
            await documentServiceClient.DeleteDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocument()
        {
            // Snippet: DeleteDocument(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]/documents/[DOCUMENT]";
            // Make the request
            documentServiceClient.DeleteDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentAsync()
        {
            // Snippet: DeleteDocumentAsync(string, CallSettings)
            // Additional: DeleteDocumentAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]/documents/[DOCUMENT]";
            // Make the request
            await documentServiceClient.DeleteDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocument</summary>
        public void DeleteDocumentResourceNames()
        {
            // Snippet: DeleteDocument(DocumentName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]");
            // Make the request
            documentServiceClient.DeleteDocument(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDocumentAsync</summary>
        public async Task DeleteDocumentResourceNamesAsync()
        {
            // Snippet: DeleteDocumentAsync(DocumentName, CallSettings)
            // Additional: DeleteDocumentAsync(DocumentName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]");
            // Make the request
            await documentServiceClient.DeleteDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocumentsRequestObject()
        {
            // Snippet: ImportDocuments(ImportDocumentsRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                InlineSource = new ImportDocumentsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
                ReconciliationMode = ImportDocumentsRequest.Types.ReconciliationMode.Unspecified,
                UpdateMask = new FieldMask(),
                AutoGenerateIds = false,
                IdField = "",
            };
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = documentServiceClient.ImportDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> retrievedResponse = documentServiceClient.PollOnceImportDocuments(operationName);
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
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportDocumentsRequest request = new ImportDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                InlineSource = new ImportDocumentsRequest.Types.InlineSource(),
                ErrorConfig = new ImportErrorConfig(),
                ReconciliationMode = ImportDocumentsRequest.Types.ReconciliationMode.Unspecified,
                UpdateMask = new FieldMask(),
                AutoGenerateIds = false,
                IdField = "",
            };
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = await documentServiceClient.ImportDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> retrievedResponse = await documentServiceClient.PollOnceImportDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeDocuments</summary>
        public void PurgeDocumentsRequestObject()
        {
            // Snippet: PurgeDocuments(PurgeDocumentsRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            PurgeDocumentsRequest request = new PurgeDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Filter = "",
                Force = false,
                GcsSource = new GcsSource(),
                ErrorConfig = new PurgeErrorConfig(),
            };
            // Make the request
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> response = documentServiceClient.PurgeDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> retrievedResponse = documentServiceClient.PollOncePurgeDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeDocumentsAsync</summary>
        public async Task PurgeDocumentsRequestObjectAsync()
        {
            // Snippet: PurgeDocumentsAsync(PurgeDocumentsRequest, CallSettings)
            // Additional: PurgeDocumentsAsync(PurgeDocumentsRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeDocumentsRequest request = new PurgeDocumentsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Filter = "",
                Force = false,
                GcsSource = new GcsSource(),
                ErrorConfig = new PurgeErrorConfig(),
            };
            // Make the request
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> response = await documentServiceClient.PurgeDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeDocumentsResponse, PurgeDocumentsMetadata> retrievedResponse = await documentServiceClient.PollOncePurgeDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadata</summary>
        public void BatchGetDocumentsMetadataRequestObject()
        {
            // Snippet: BatchGetDocumentsMetadata(BatchGetDocumentsMetadataRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BatchGetDocumentsMetadataRequest request = new BatchGetDocumentsMetadataRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Matcher = new BatchGetDocumentsMetadataRequest.Types.Matcher(),
            };
            // Make the request
            BatchGetDocumentsMetadataResponse response = documentServiceClient.BatchGetDocumentsMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadataAsync</summary>
        public async Task BatchGetDocumentsMetadataRequestObjectAsync()
        {
            // Snippet: BatchGetDocumentsMetadataAsync(BatchGetDocumentsMetadataRequest, CallSettings)
            // Additional: BatchGetDocumentsMetadataAsync(BatchGetDocumentsMetadataRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetDocumentsMetadataRequest request = new BatchGetDocumentsMetadataRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Matcher = new BatchGetDocumentsMetadataRequest.Types.Matcher(),
            };
            // Make the request
            BatchGetDocumentsMetadataResponse response = await documentServiceClient.BatchGetDocumentsMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadata</summary>
        public void BatchGetDocumentsMetadata()
        {
            // Snippet: BatchGetDocumentsMetadata(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            // Make the request
            BatchGetDocumentsMetadataResponse response = documentServiceClient.BatchGetDocumentsMetadata(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadataAsync</summary>
        public async Task BatchGetDocumentsMetadataAsync()
        {
            // Snippet: BatchGetDocumentsMetadataAsync(string, CallSettings)
            // Additional: BatchGetDocumentsMetadataAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/branches/[BRANCH]";
            // Make the request
            BatchGetDocumentsMetadataResponse response = await documentServiceClient.BatchGetDocumentsMetadataAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadata</summary>
        public void BatchGetDocumentsMetadataResourceNames()
        {
            // Snippet: BatchGetDocumentsMetadata(BranchName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            // Make the request
            BatchGetDocumentsMetadataResponse response = documentServiceClient.BatchGetDocumentsMetadata(parent);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsMetadataAsync</summary>
        public async Task BatchGetDocumentsMetadataResourceNamesAsync()
        {
            // Snippet: BatchGetDocumentsMetadataAsync(BranchName, CallSettings)
            // Additional: BatchGetDocumentsMetadataAsync(BranchName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]");
            // Make the request
            BatchGetDocumentsMetadataResponse response = await documentServiceClient.BatchGetDocumentsMetadataAsync(parent);
            // End snippet
        }
    }
}
