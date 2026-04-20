// Copyright 2026 Google LLC
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
    using Google.Developers.Knowledge.V1;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeveloperKnowledgeClientSnippets
    {
        /// <summary>Snippet for SearchDocumentChunks</summary>
        public void SearchDocumentChunksRequestObject()
        {
            // Snippet: SearchDocumentChunks(SearchDocumentChunksRequest, CallSettings)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = DeveloperKnowledgeClient.Create();
            // Initialize request argument(s)
            SearchDocumentChunksRequest request = new SearchDocumentChunksRequest
            {
                Query = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchDocumentChunksResponse, DocumentChunk> response = developerKnowledgeClient.SearchDocumentChunks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DocumentChunk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDocumentChunksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentChunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentChunk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentChunk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDocumentChunksAsync</summary>
        public async Task SearchDocumentChunksRequestObjectAsync()
        {
            // Snippet: SearchDocumentChunksAsync(SearchDocumentChunksRequest, CallSettings)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = await DeveloperKnowledgeClient.CreateAsync();
            // Initialize request argument(s)
            SearchDocumentChunksRequest request = new SearchDocumentChunksRequest
            {
                Query = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchDocumentChunksResponse, DocumentChunk> response = developerKnowledgeClient.SearchDocumentChunksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DocumentChunk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchDocumentChunksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DocumentChunk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DocumentChunk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DocumentChunk item in singlePage)
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
            DeveloperKnowledgeClient developerKnowledgeClient = DeveloperKnowledgeClient.Create();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromDocument("[DOCUMENT]"),
                View = DocumentView.Unspecified,
            };
            // Make the request
            Document response = developerKnowledgeClient.GetDocument(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentRequestObjectAsync()
        {
            // Snippet: GetDocumentAsync(GetDocumentRequest, CallSettings)
            // Additional: GetDocumentAsync(GetDocumentRequest, CancellationToken)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = await DeveloperKnowledgeClient.CreateAsync();
            // Initialize request argument(s)
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromDocument("[DOCUMENT]"),
                View = DocumentView.Unspecified,
            };
            // Make the request
            Document response = await developerKnowledgeClient.GetDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocument()
        {
            // Snippet: GetDocument(string, CallSettings)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = DeveloperKnowledgeClient.Create();
            // Initialize request argument(s)
            string name = "documents/[DOCUMENT]";
            // Make the request
            Document response = developerKnowledgeClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentAsync()
        {
            // Snippet: GetDocumentAsync(string, CallSettings)
            // Additional: GetDocumentAsync(string, CancellationToken)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = await DeveloperKnowledgeClient.CreateAsync();
            // Initialize request argument(s)
            string name = "documents/[DOCUMENT]";
            // Make the request
            Document response = await developerKnowledgeClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocument</summary>
        public void GetDocumentResourceNames()
        {
            // Snippet: GetDocument(DocumentName, CallSettings)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = DeveloperKnowledgeClient.Create();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromDocument("[DOCUMENT]");
            // Make the request
            Document response = developerKnowledgeClient.GetDocument(name);
            // End snippet
        }

        /// <summary>Snippet for GetDocumentAsync</summary>
        public async Task GetDocumentResourceNamesAsync()
        {
            // Snippet: GetDocumentAsync(DocumentName, CallSettings)
            // Additional: GetDocumentAsync(DocumentName, CancellationToken)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = await DeveloperKnowledgeClient.CreateAsync();
            // Initialize request argument(s)
            DocumentName name = DocumentName.FromDocument("[DOCUMENT]");
            // Make the request
            Document response = await developerKnowledgeClient.GetDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocuments</summary>
        public void BatchGetDocumentsRequestObject()
        {
            // Snippet: BatchGetDocuments(BatchGetDocumentsRequest, CallSettings)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = DeveloperKnowledgeClient.Create();
            // Initialize request argument(s)
            BatchGetDocumentsRequest request = new BatchGetDocumentsRequest
            {
                DocumentNames =
                {
                    DocumentName.FromDocument("[DOCUMENT]"),
                },
                View = DocumentView.Unspecified,
            };
            // Make the request
            BatchGetDocumentsResponse response = developerKnowledgeClient.BatchGetDocuments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDocumentsAsync</summary>
        public async Task BatchGetDocumentsRequestObjectAsync()
        {
            // Snippet: BatchGetDocumentsAsync(BatchGetDocumentsRequest, CallSettings)
            // Additional: BatchGetDocumentsAsync(BatchGetDocumentsRequest, CancellationToken)
            // Create client
            DeveloperKnowledgeClient developerKnowledgeClient = await DeveloperKnowledgeClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetDocumentsRequest request = new BatchGetDocumentsRequest
            {
                DocumentNames =
                {
                    DocumentName.FromDocument("[DOCUMENT]"),
                },
                View = DocumentView.Unspecified,
            };
            // Make the request
            BatchGetDocumentsResponse response = await developerKnowledgeClient.BatchGetDocumentsAsync(request);
            // End snippet
        }
    }
}
