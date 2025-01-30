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
    using Google.Cloud.DocumentAI.V1Beta3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentServiceClientSnippets
    {
        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDatasetRequestObject()
        {
            // Snippet: UpdateDataset(UpdateDatasetRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = documentServiceClient.UpdateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = documentServiceClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetRequestObjectAsync()
        {
            // Snippet: UpdateDatasetAsync(UpdateDatasetRequest, CallSettings)
            // Additional: UpdateDatasetAsync(UpdateDatasetRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetRequest request = new UpdateDatasetRequest
            {
                Dataset = new Dataset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = await documentServiceClient.UpdateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = await documentServiceClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataset</summary>
        public void UpdateDataset()
        {
            // Snippet: UpdateDataset(Dataset, FieldMask, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = documentServiceClient.UpdateDataset(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = documentServiceClient.PollOnceUpdateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetAsync</summary>
        public async Task UpdateDatasetAsync()
        {
            // Snippet: UpdateDatasetAsync(Dataset, FieldMask, CallSettings)
            // Additional: UpdateDatasetAsync(Dataset, FieldMask, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            Dataset dataset = new Dataset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Dataset, UpdateDatasetOperationMetadata> response = await documentServiceClient.UpdateDatasetAsync(dataset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Dataset, UpdateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Dataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Dataset, UpdateDatasetOperationMetadata> retrievedResponse = await documentServiceClient.PollOnceUpdateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Dataset retrievedResult = retrievedResponse.Result;
            }
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
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                BatchDocumentsImportConfigs =
                {
                    new ImportDocumentsRequest.Types.BatchDocumentsImportConfig(),
                },
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
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                BatchDocumentsImportConfigs =
                {
                    new ImportDocumentsRequest.Types.BatchDocumentsImportConfig(),
                },
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

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocuments()
        {
            // Snippet: ImportDocuments(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = documentServiceClient.ImportDocuments(dataset);

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
        public async Task ImportDocumentsAsync()
        {
            // Snippet: ImportDocumentsAsync(string, CallSettings)
            // Additional: ImportDocumentsAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = await documentServiceClient.ImportDocumentsAsync(dataset);

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

        /// <summary>Snippet for ImportDocuments</summary>
        public void ImportDocumentsResourceNames()
        {
            // Snippet: ImportDocuments(DatasetName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = documentServiceClient.ImportDocuments(dataset);

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
        public async Task ImportDocumentsResourceNamesAsync()
        {
            // Snippet: ImportDocumentsAsync(DatasetName, CallSettings)
            // Additional: ImportDocumentsAsync(DatasetName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<ImportDocumentsResponse, ImportDocumentsMetadata> response = await documentServiceClient.ImportDocumentsAsync(dataset);

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

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentRequestObject()
        {
            // Snippet: GetDocument(GetDocumentRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DocumentId = new DocumentId(),
                ReadMask = new FieldMask(),
                PageRange = new DocumentPageRange(),
            };
            // Make the request
            GetDocumentResponse response = documentServiceClient.GetDocument(request);
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
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DocumentId = new DocumentId(),
                ReadMask = new FieldMask(),
                PageRange = new DocumentPageRange(),
            };
            // Make the request
            GetDocumentResponse response = await documentServiceClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocument()
        {
            // Snippet: GetDocument(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            GetDocumentResponse response = documentServiceClient.GetDocument(dataset);
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
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            GetDocumentResponse response = await documentServiceClient.GetDocumentAsync(dataset);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentResourceNames()
        {
            // Snippet: GetDocument(DatasetName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            GetDocumentResponse response = documentServiceClient.GetDocument(dataset);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentResourceNamesAsync()
        {
            // Snippet: GetDocumentAsync(DatasetName, CallSettings)
            // Additional: GetDocumentAsync(DatasetName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            GetDocumentResponse response = await documentServiceClient.GetDocumentAsync(dataset);
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
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Filter = "",
                ReturnTotalSize = false,
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocuments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DocumentMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
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
                DatasetAsDatasetName = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                Filter = "",
                ReturnTotalSize = false,
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocumentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DocumentMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDocumentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
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
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            PagedEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocuments(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DocumentMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
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
            string dataset = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset";
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocumentsAsync(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DocumentMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDocumentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
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
            // Snippet: ListDocuments(DatasetName, string, int?, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocuments(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DocumentMetadata item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDocumentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
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
            // Snippet: ListDocumentsAsync(DatasetName, string, int?, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetName dataset = DatasetName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedAsyncEnumerable<ListDocumentsResponse, DocumentMetadata> response = documentServiceClient.ListDocumentsAsync(dataset);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DocumentMetadata item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDocumentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentMetadata item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentMetadata> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentMetadata item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDocuments</summary>
        public void BatchDeleteDocumentsRequestObject()
        {
            // Snippet: BatchDeleteDocuments(BatchDeleteDocumentsRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteDocumentsRequest request = new BatchDeleteDocumentsRequest
            {
                Dataset = "",
                DatasetDocuments = new BatchDatasetDocuments(),
            };
            // Make the request
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> response = documentServiceClient.BatchDeleteDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> retrievedResponse = documentServiceClient.PollOnceBatchDeleteDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDocumentsAsync</summary>
        public async Task BatchDeleteDocumentsRequestObjectAsync()
        {
            // Snippet: BatchDeleteDocumentsAsync(BatchDeleteDocumentsRequest, CallSettings)
            // Additional: BatchDeleteDocumentsAsync(BatchDeleteDocumentsRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteDocumentsRequest request = new BatchDeleteDocumentsRequest
            {
                Dataset = "",
                DatasetDocuments = new BatchDatasetDocuments(),
            };
            // Make the request
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> response = await documentServiceClient.BatchDeleteDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> retrievedResponse = await documentServiceClient.PollOnceBatchDeleteDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDocuments</summary>
        public void BatchDeleteDocuments()
        {
            // Snippet: BatchDeleteDocuments(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string dataset = "";
            // Make the request
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> response = documentServiceClient.BatchDeleteDocuments(dataset);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchDeleteDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> retrievedResponse = documentServiceClient.PollOnceBatchDeleteDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteDocumentsAsync</summary>
        public async Task BatchDeleteDocumentsAsync()
        {
            // Snippet: BatchDeleteDocumentsAsync(string, CallSettings)
            // Additional: BatchDeleteDocumentsAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string dataset = "";
            // Make the request
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> response = await documentServiceClient.BatchDeleteDocumentsAsync(dataset);

            // Poll until the returned long-running operation is complete
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchDeleteDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchDeleteDocumentsResponse, BatchDeleteDocumentsMetadata> retrievedResponse = await documentServiceClient.PollOnceBatchDeleteDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchDeleteDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchemaRequestObject()
        {
            // Snippet: GetDatasetSchema(GetDatasetSchemaRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            GetDatasetSchemaRequest request = new GetDatasetSchemaRequest
            {
                DatasetSchemaName = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                VisibleFieldsOnly = false,
            };
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaRequestObjectAsync()
        {
            // Snippet: GetDatasetSchemaAsync(GetDatasetSchemaRequest, CallSettings)
            // Additional: GetDatasetSchemaAsync(GetDatasetSchemaRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDatasetSchemaRequest request = new GetDatasetSchemaRequest
            {
                DatasetSchemaName = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                VisibleFieldsOnly = false,
            };
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchema()
        {
            // Snippet: GetDatasetSchema(string, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset/datasetSchema";
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaAsync()
        {
            // Snippet: GetDatasetSchemaAsync(string, CallSettings)
            // Additional: GetDatasetSchemaAsync(string, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/dataset/datasetSchema";
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchema</summary>
        public void GetDatasetSchemaResourceNames()
        {
            // Snippet: GetDatasetSchema(DatasetSchemaName, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetSchemaName name = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            DatasetSchema response = documentServiceClient.GetDatasetSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatasetSchemaAsync</summary>
        public async Task GetDatasetSchemaResourceNamesAsync()
        {
            // Snippet: GetDatasetSchemaAsync(DatasetSchemaName, CallSettings)
            // Additional: GetDatasetSchemaAsync(DatasetSchemaName, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetSchemaName name = DatasetSchemaName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            DatasetSchema response = await documentServiceClient.GetDatasetSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchema</summary>
        public void UpdateDatasetSchemaRequestObject()
        {
            // Snippet: UpdateDatasetSchema(UpdateDatasetSchemaRequest, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDatasetSchemaRequest request = new UpdateDatasetSchemaRequest
            {
                DatasetSchema = new DatasetSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetSchema response = documentServiceClient.UpdateDatasetSchema(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchemaAsync</summary>
        public async Task UpdateDatasetSchemaRequestObjectAsync()
        {
            // Snippet: UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest, CallSettings)
            // Additional: UpdateDatasetSchemaAsync(UpdateDatasetSchemaRequest, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatasetSchemaRequest request = new UpdateDatasetSchemaRequest
            {
                DatasetSchema = new DatasetSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DatasetSchema response = await documentServiceClient.UpdateDatasetSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchema</summary>
        public void UpdateDatasetSchema()
        {
            // Snippet: UpdateDatasetSchema(DatasetSchema, FieldMask, CallSettings)
            // Create client
            DocumentServiceClient documentServiceClient = DocumentServiceClient.Create();
            // Initialize request argument(s)
            DatasetSchema datasetSchema = new DatasetSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetSchema response = documentServiceClient.UpdateDatasetSchema(datasetSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatasetSchemaAsync</summary>
        public async Task UpdateDatasetSchemaAsync()
        {
            // Snippet: UpdateDatasetSchemaAsync(DatasetSchema, FieldMask, CallSettings)
            // Additional: UpdateDatasetSchemaAsync(DatasetSchema, FieldMask, CancellationToken)
            // Create client
            DocumentServiceClient documentServiceClient = await DocumentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DatasetSchema datasetSchema = new DatasetSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DatasetSchema response = await documentServiceClient.UpdateDatasetSchemaAsync(datasetSchema, updateMask);
            // End snippet
        }
    }
}
