// Copyright 2023 Google LLC
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
    using gcdv = Google.Cloud.DocumentAI.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentProcessorServiceClientSnippets
    {
        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentRequestObject()
        {
            // Snippet: ProcessDocument(ProcessRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessRequest request = new gcdv::ProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InlineDocument = new gcdv::Document(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            gcdv::ProcessResponse response = documentProcessorServiceClient.ProcessDocument(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentRequestObjectAsync()
        {
            // Snippet: ProcessDocumentAsync(ProcessRequest, CallSettings)
            // Additional: ProcessDocumentAsync(ProcessRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessRequest request = new gcdv::ProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InlineDocument = new gcdv::Document(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            gcdv::ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocument()
        {
            // Snippet: ProcessDocument(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            gcdv::ProcessResponse response = documentProcessorServiceClient.ProcessDocument(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentAsync()
        {
            // Snippet: ProcessDocumentAsync(string, CallSettings)
            // Additional: ProcessDocumentAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            gcdv::ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentResourceNames()
        {
            // Snippet: ProcessDocument(IResourceName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            gcdv::ProcessResponse response = documentProcessorServiceClient.ProcessDocument(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentResourceNamesAsync()
        {
            // Snippet: ProcessDocumentAsync(IResourceName, CallSettings)
            // Additional: ProcessDocumentAsync(IResourceName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            gcdv::ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocumentsRequestObject()
        {
            // Snippet: BatchProcessDocuments(BatchProcessRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::BatchProcessRequest request = new gcdv::BatchProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InputDocuments = new gcdv::BatchDocumentsInputConfig(),
                DocumentOutputConfig = new gcdv::DocumentOutputConfig(),
            };
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsRequestObjectAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(BatchProcessRequest, CallSettings)
            // Additional: BatchProcessDocumentsAsync(BatchProcessRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::BatchProcessRequest request = new gcdv::BatchProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InputDocuments = new gcdv::BatchDocumentsInputConfig(),
                DocumentOutputConfig = new gcdv::DocumentOutputConfig(),
            };
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocuments()
        {
            // Snippet: BatchProcessDocuments(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(string, CallSettings)
            // Additional: BatchProcessDocumentsAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocumentsResourceNames()
        {
            // Snippet: BatchProcessDocuments(IResourceName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsResourceNamesAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(IResourceName, CallSettings)
            // Additional: BatchProcessDocumentsAsync(IResourceName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::BatchProcessResponse, gcdv::BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypesRequestObject()
        {
            // Snippet: FetchProcessorTypes(FetchProcessorTypesRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::FetchProcessorTypesRequest request = new gcdv::FetchProcessorTypesRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcdv::FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(request);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesRequestObjectAsync()
        {
            // Snippet: FetchProcessorTypesAsync(FetchProcessorTypesRequest, CallSettings)
            // Additional: FetchProcessorTypesAsync(FetchProcessorTypesRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::FetchProcessorTypesRequest request = new gcdv::FetchProcessorTypesRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            gcdv::FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypes()
        {
            // Snippet: FetchProcessorTypes(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            gcdv::FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesAsync()
        {
            // Snippet: FetchProcessorTypesAsync(string, CallSettings)
            // Additional: FetchProcessorTypesAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            gcdv::FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypesResourceNames1()
        {
            // Snippet: FetchProcessorTypes(LocationName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesResourceNames1Async()
        {
            // Snippet: FetchProcessorTypesAsync(LocationName, CallSettings)
            // Additional: FetchProcessorTypesAsync(LocationName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypesResourceNames2()
        {
            // Snippet: FetchProcessorTypes(LocationName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesResourceNames2Async()
        {
            // Snippet: FetchProcessorTypesAsync(LocationName, CallSettings)
            // Additional: FetchProcessorTypesAsync(LocationName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            gcdv::FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypesRequestObject()
        {
            // Snippet: ListProcessorTypes(ListProcessorTypesRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListProcessorTypesRequest request = new gcdv::ListProcessorTypesRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypesAsync</summary>
        public async Task ListProcessorTypesRequestObjectAsync()
        {
            // Snippet: ListProcessorTypesAsync(ListProcessorTypesRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListProcessorTypesRequest request = new gcdv::ListProcessorTypesRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypes()
        {
            // Snippet: ListProcessorTypes(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypesAsync</summary>
        public async Task ListProcessorTypesAsync()
        {
            // Snippet: ListProcessorTypesAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypesResourceNames1()
        {
            // Snippet: ListProcessorTypes(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypesAsync</summary>
        public async Task ListProcessorTypesResourceNames1Async()
        {
            // Snippet: ListProcessorTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypesResourceNames2()
        {
            // Snippet: ListProcessorTypes(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypesAsync</summary>
        public async Task ListProcessorTypesResourceNames2Async()
        {
            // Snippet: ListProcessorTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorTypesResponse, gcdv::ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProcessorType</summary>
        public void GetProcessorTypeRequestObject()
        {
            // Snippet: GetProcessorType(GetProcessorTypeRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetProcessorTypeRequest request = new gcdv::GetProcessorTypeRequest
            {
                ProcessorTypeName = gcdv::ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]"),
            };
            // Make the request
            gcdv::ProcessorType response = documentProcessorServiceClient.GetProcessorType(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeRequestObjectAsync()
        {
            // Snippet: GetProcessorTypeAsync(GetProcessorTypeRequest, CallSettings)
            // Additional: GetProcessorTypeAsync(GetProcessorTypeRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetProcessorTypeRequest request = new gcdv::GetProcessorTypeRequest
            {
                ProcessorTypeName = gcdv::ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]"),
            };
            // Make the request
            gcdv::ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorType</summary>
        public void GetProcessorType()
        {
            // Snippet: GetProcessorType(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processorTypes/[PROCESSOR_TYPE]";
            // Make the request
            gcdv::ProcessorType response = documentProcessorServiceClient.GetProcessorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeAsync()
        {
            // Snippet: GetProcessorTypeAsync(string, CallSettings)
            // Additional: GetProcessorTypeAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processorTypes/[PROCESSOR_TYPE]";
            // Make the request
            gcdv::ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorType</summary>
        public void GetProcessorTypeResourceNames()
        {
            // Snippet: GetProcessorType(ProcessorTypeName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorTypeName name = gcdv::ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]");
            // Make the request
            gcdv::ProcessorType response = documentProcessorServiceClient.GetProcessorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeResourceNamesAsync()
        {
            // Snippet: GetProcessorTypeAsync(ProcessorTypeName, CallSettings)
            // Additional: GetProcessorTypeAsync(ProcessorTypeName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorTypeName name = gcdv::ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]");
            // Make the request
            gcdv::ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsRequestObject()
        {
            // Snippet: ListProcessors(ListProcessorsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListProcessorsRequest request = new gcdv::ListProcessorsRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsRequestObjectAsync()
        {
            // Snippet: ListProcessorsAsync(ListProcessorsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListProcessorsRequest request = new gcdv::ListProcessorsRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessors()
        {
            // Snippet: ListProcessors(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsAsync()
        {
            // Snippet: ListProcessorsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsResourceNames1()
        {
            // Snippet: ListProcessors(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsResourceNames1Async()
        {
            // Snippet: ListProcessorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsResourceNames2()
        {
            // Snippet: ListProcessors(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsResourceNames2Async()
        {
            // Snippet: ListProcessorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorsResponse, gcdv::Processor> response = documentProcessorServiceClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessorRequestObject()
        {
            // Snippet: GetProcessor(GetProcessorRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetProcessorRequest request = new gcdv::GetProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.GetProcessor(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorRequestObjectAsync()
        {
            // Snippet: GetProcessorAsync(GetProcessorRequest, CallSettings)
            // Additional: GetProcessorAsync(GetProcessorRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetProcessorRequest request = new gcdv::GetProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.GetProcessorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessor()
        {
            // Snippet: GetProcessor(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorAsync()
        {
            // Snippet: GetProcessorAsync(string, CallSettings)
            // Additional: GetProcessorAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessorResourceNames()
        {
            // Snippet: GetProcessor(ProcessorName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorName name = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorResourceNamesAsync()
        {
            // Snippet: GetProcessorAsync(ProcessorName, CallSettings)
            // Additional: GetProcessorAsync(ProcessorName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorName name = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersionRequestObject()
        {
            // Snippet: TrainProcessorVersion(TrainProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::TrainProcessorVersionRequest request = new gcdv::TrainProcessorVersionRequest
            {
                ParentAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                ProcessorVersion = new gcdv::ProcessorVersion(),
                InputData = new gcdv::TrainProcessorVersionRequest.Types.InputData(),
                BaseProcessorVersion = "",
                DocumentSchema = new gcdv::DocumentSchema(),
            };
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionRequestObjectAsync()
        {
            // Snippet: TrainProcessorVersionAsync(TrainProcessorVersionRequest, CallSettings)
            // Additional: TrainProcessorVersionAsync(TrainProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TrainProcessorVersionRequest request = new gcdv::TrainProcessorVersionRequest
            {
                ParentAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                ProcessorVersion = new gcdv::ProcessorVersion(),
                InputData = new gcdv::TrainProcessorVersionRequest.Types.InputData(),
                BaseProcessorVersion = "",
                DocumentSchema = new gcdv::DocumentSchema(),
            };
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersion()
        {
            // Snippet: TrainProcessorVersion(string, ProcessorVersion, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            gcdv::ProcessorVersion processorVersion = new gcdv::ProcessorVersion();
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionAsync()
        {
            // Snippet: TrainProcessorVersionAsync(string, ProcessorVersion, CallSettings)
            // Additional: TrainProcessorVersionAsync(string, ProcessorVersion, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            gcdv::ProcessorVersion processorVersion = new gcdv::ProcessorVersion();
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersionResourceNames()
        {
            // Snippet: TrainProcessorVersion(ProcessorName, ProcessorVersion, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorName parent = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            gcdv::ProcessorVersion processorVersion = new gcdv::ProcessorVersion();
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionResourceNamesAsync()
        {
            // Snippet: TrainProcessorVersionAsync(ProcessorName, ProcessorVersion, CallSettings)
            // Additional: TrainProcessorVersionAsync(ProcessorName, ProcessorVersion, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorName parent = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            gcdv::ProcessorVersion processorVersion = new gcdv::ProcessorVersion();
            // Make the request
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::TrainProcessorVersionResponse, gcdv::TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersionRequestObject()
        {
            // Snippet: GetProcessorVersion(GetProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetProcessorVersionRequest request = new gcdv::GetProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            gcdv::ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionRequestObjectAsync()
        {
            // Snippet: GetProcessorVersionAsync(GetProcessorVersionRequest, CallSettings)
            // Additional: GetProcessorVersionAsync(GetProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetProcessorVersionRequest request = new gcdv::GetProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            gcdv::ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersion()
        {
            // Snippet: GetProcessorVersion(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            gcdv::ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionAsync()
        {
            // Snippet: GetProcessorVersionAsync(string, CallSettings)
            // Additional: GetProcessorVersionAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            gcdv::ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersionResourceNames()
        {
            // Snippet: GetProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            gcdv::ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionResourceNamesAsync()
        {
            // Snippet: GetProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: GetProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            gcdv::ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersions</summary>
        public void ListProcessorVersionsRequestObject()
        {
            // Snippet: ListProcessorVersions(ListProcessorVersionsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListProcessorVersionsRequest request = new gcdv::ListProcessorVersionsRequest
            {
                ParentAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersionsAsync</summary>
        public async Task ListProcessorVersionsRequestObjectAsync()
        {
            // Snippet: ListProcessorVersionsAsync(ListProcessorVersionsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListProcessorVersionsRequest request = new gcdv::ListProcessorVersionsRequest
            {
                ParentAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersions</summary>
        public void ListProcessorVersions()
        {
            // Snippet: ListProcessorVersions(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            PagedEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersionsAsync</summary>
        public async Task ListProcessorVersionsAsync()
        {
            // Snippet: ListProcessorVersionsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersions</summary>
        public void ListProcessorVersionsResourceNames()
        {
            // Snippet: ListProcessorVersions(ProcessorName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorName parent = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersionsAsync</summary>
        public async Task ListProcessorVersionsResourceNamesAsync()
        {
            // Snippet: ListProcessorVersionsAsync(ProcessorName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorName parent = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListProcessorVersionsResponse, gcdv::ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::ProcessorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersion</summary>
        public void DeleteProcessorVersionRequestObject()
        {
            // Snippet: DeleteProcessorVersion(DeleteProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteProcessorVersionRequest request = new gcdv::DeleteProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersionAsync</summary>
        public async Task DeleteProcessorVersionRequestObjectAsync()
        {
            // Snippet: DeleteProcessorVersionAsync(DeleteProcessorVersionRequest, CallSettings)
            // Additional: DeleteProcessorVersionAsync(DeleteProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteProcessorVersionRequest request = new gcdv::DeleteProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersion</summary>
        public void DeleteProcessorVersion()
        {
            // Snippet: DeleteProcessorVersion(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersionAsync</summary>
        public async Task DeleteProcessorVersionAsync()
        {
            // Snippet: DeleteProcessorVersionAsync(string, CallSettings)
            // Additional: DeleteProcessorVersionAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersion</summary>
        public void DeleteProcessorVersionResourceNames()
        {
            // Snippet: DeleteProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorVersionAsync</summary>
        public async Task DeleteProcessorVersionResourceNamesAsync()
        {
            // Snippet: DeleteProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: DeleteProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersion</summary>
        public void DeployProcessorVersionRequestObject()
        {
            // Snippet: DeployProcessorVersion(DeployProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeployProcessorVersionRequest request = new gcdv::DeployProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionRequestObjectAsync()
        {
            // Snippet: DeployProcessorVersionAsync(DeployProcessorVersionRequest, CallSettings)
            // Additional: DeployProcessorVersionAsync(DeployProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeployProcessorVersionRequest request = new gcdv::DeployProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersion</summary>
        public void DeployProcessorVersion()
        {
            // Snippet: DeployProcessorVersion(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionAsync()
        {
            // Snippet: DeployProcessorVersionAsync(string, CallSettings)
            // Additional: DeployProcessorVersionAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersion</summary>
        public void DeployProcessorVersionResourceNames()
        {
            // Snippet: DeployProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionResourceNamesAsync()
        {
            // Snippet: DeployProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: DeployProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DeployProcessorVersionResponse, gcdv::DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersionRequestObject()
        {
            // Snippet: UndeployProcessorVersion(UndeployProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UndeployProcessorVersionRequest request = new gcdv::UndeployProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionRequestObjectAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(UndeployProcessorVersionRequest, CallSettings)
            // Additional: UndeployProcessorVersionAsync(UndeployProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UndeployProcessorVersionRequest request = new gcdv::UndeployProcessorVersionRequest
            {
                ProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersion()
        {
            // Snippet: UndeployProcessorVersion(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(string, CallSettings)
            // Additional: UndeployProcessorVersionAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersionResourceNames()
        {
            // Snippet: UndeployProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionResourceNamesAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: UndeployProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName name = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::UndeployProcessorVersionResponse, gcdv::UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorRequestObject()
        {
            // Snippet: CreateProcessor(CreateProcessorRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateProcessorRequest request = new gcdv::CreateProcessorRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new gcdv::Processor(),
            };
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.CreateProcessor(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorRequestObjectAsync()
        {
            // Snippet: CreateProcessorAsync(CreateProcessorRequest, CallSettings)
            // Additional: CreateProcessorAsync(CreateProcessorRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateProcessorRequest request = new gcdv::CreateProcessorRequest
            {
                ParentAsLocationName = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new gcdv::Processor(),
            };
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.CreateProcessorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessor()
        {
            // Snippet: CreateProcessor(string, Processor, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.CreateProcessor(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorAsync()
        {
            // Snippet: CreateProcessorAsync(string, Processor, CallSettings)
            // Additional: CreateProcessorAsync(string, Processor, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.CreateProcessorAsync(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorResourceNames1()
        {
            // Snippet: CreateProcessor(LocationName, Processor, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.CreateProcessor(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorResourceNames1Async()
        {
            // Snippet: CreateProcessorAsync(LocationName, Processor, CallSettings)
            // Additional: CreateProcessorAsync(LocationName, Processor, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LocationName parent = gcdv::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.CreateProcessorAsync(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorResourceNames2()
        {
            // Snippet: CreateProcessor(LocationName, Processor, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = documentProcessorServiceClient.CreateProcessor(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorResourceNames2Async()
        {
            // Snippet: CreateProcessorAsync(LocationName, Processor, CallSettings)
            // Additional: CreateProcessorAsync(LocationName, Processor, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Processor processor = new gcdv::Processor();
            // Make the request
            gcdv::Processor response = await documentProcessorServiceClient.CreateProcessorAsync(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessorRequestObject()
        {
            // Snippet: DeleteProcessor(DeleteProcessorRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteProcessorRequest request = new gcdv::DeleteProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorRequestObjectAsync()
        {
            // Snippet: DeleteProcessorAsync(DeleteProcessorRequest, CallSettings)
            // Additional: DeleteProcessorAsync(DeleteProcessorRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteProcessorRequest request = new gcdv::DeleteProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessor()
        {
            // Snippet: DeleteProcessor(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorAsync()
        {
            // Snippet: DeleteProcessorAsync(string, CallSettings)
            // Additional: DeleteProcessorAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessorResourceNames()
        {
            // Snippet: DeleteProcessor(ProcessorName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorName name = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessorAsync</summary>
        public async Task DeleteProcessorResourceNamesAsync()
        {
            // Snippet: DeleteProcessorAsync(ProcessorName, CallSettings)
            // Additional: DeleteProcessorAsync(ProcessorName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorName name = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, gcdv::DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableProcessor</summary>
        public void EnableProcessorRequestObject()
        {
            // Snippet: EnableProcessor(EnableProcessorRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EnableProcessorRequest request = new gcdv::EnableProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> response = documentProcessorServiceClient.EnableProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EnableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEnableProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EnableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableProcessorAsync</summary>
        public async Task EnableProcessorRequestObjectAsync()
        {
            // Snippet: EnableProcessorAsync(EnableProcessorRequest, CallSettings)
            // Additional: EnableProcessorAsync(EnableProcessorRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EnableProcessorRequest request = new gcdv::EnableProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> response = await documentProcessorServiceClient.EnableProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EnableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EnableProcessorResponse, gcdv::EnableProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEnableProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EnableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableProcessor</summary>
        public void DisableProcessorRequestObject()
        {
            // Snippet: DisableProcessor(DisableProcessorRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DisableProcessorRequest request = new gcdv::DisableProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> response = documentProcessorServiceClient.DisableProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::DisableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDisableProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DisableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableProcessorAsync</summary>
        public async Task DisableProcessorRequestObjectAsync()
        {
            // Snippet: DisableProcessorAsync(DisableProcessorRequest, CallSettings)
            // Additional: DisableProcessorAsync(DisableProcessorRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DisableProcessorRequest request = new gcdv::DisableProcessorRequest
            {
                ProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> response = await documentProcessorServiceClient.DisableProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::DisableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::DisableProcessorResponse, gcdv::DisableProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDisableProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::DisableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultProcessorVersion</summary>
        public void SetDefaultProcessorVersionRequestObject()
        {
            // Snippet: SetDefaultProcessorVersion(SetDefaultProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::SetDefaultProcessorVersionRequest request = new gcdv::SetDefaultProcessorVersionRequest
            {
                ProcessorAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DefaultProcessorVersionAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> response = documentProcessorServiceClient.SetDefaultProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::SetDefaultProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceSetDefaultProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::SetDefaultProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultProcessorVersionAsync</summary>
        public async Task SetDefaultProcessorVersionRequestObjectAsync()
        {
            // Snippet: SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest, CallSettings)
            // Additional: SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::SetDefaultProcessorVersionRequest request = new gcdv::SetDefaultProcessorVersionRequest
            {
                ProcessorAsProcessorName = gcdv::ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DefaultProcessorVersionAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> response = await documentProcessorServiceClient.SetDefaultProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::SetDefaultProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::SetDefaultProcessorVersionResponse, gcdv::SetDefaultProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceSetDefaultProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::SetDefaultProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocumentRequestObject()
        {
            // Snippet: ReviewDocument(ReviewDocumentRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ReviewDocumentRequest request = new gcdv::ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gcdv::HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                EnableSchemaValidation = false,
                InlineDocument = new gcdv::Document(),
                Priority = gcdv::ReviewDocumentRequest.Types.Priority.Default,
                DocumentSchema = new gcdv::DocumentSchema(),
            };
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentRequestObjectAsync()
        {
            // Snippet: ReviewDocumentAsync(ReviewDocumentRequest, CallSettings)
            // Additional: ReviewDocumentAsync(ReviewDocumentRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ReviewDocumentRequest request = new gcdv::ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gcdv::HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                EnableSchemaValidation = false,
                InlineDocument = new gcdv::Document(),
                Priority = gcdv::ReviewDocumentRequest.Types.Priority.Default,
                DocumentSchema = new gcdv::DocumentSchema(),
            };
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocument()
        {
            // Snippet: ReviewDocument(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string humanReviewConfig = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/humanReviewConfig";
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentAsync()
        {
            // Snippet: ReviewDocumentAsync(string, CallSettings)
            // Additional: ReviewDocumentAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string humanReviewConfig = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/humanReviewConfig";
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocumentResourceNames()
        {
            // Snippet: ReviewDocument(HumanReviewConfigName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::HumanReviewConfigName humanReviewConfig = gcdv::HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentResourceNamesAsync()
        {
            // Snippet: ReviewDocumentAsync(HumanReviewConfigName, CallSettings)
            // Additional: ReviewDocumentAsync(HumanReviewConfigName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::HumanReviewConfigName humanReviewConfig = gcdv::HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::ReviewDocumentResponse, gcdv::ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersionRequestObject()
        {
            // Snippet: EvaluateProcessorVersion(EvaluateProcessorVersionRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EvaluateProcessorVersionRequest request = new gcdv::EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                EvaluationDocuments = new gcdv::BatchDocumentsInputConfig(),
            };
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionRequestObjectAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EvaluateProcessorVersionRequest request = new gcdv::EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                EvaluationDocuments = new gcdv::BatchDocumentsInputConfig(),
            };
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersion()
        {
            // Snippet: EvaluateProcessorVersion(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string processorVersion = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(string, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string processorVersion = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersionResourceNames()
        {
            // Snippet: EvaluateProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName processorVersion = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionResourceNamesAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName processorVersion = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::EvaluateProcessorVersionResponse, gcdv::EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEvaluationRequest request = new gcdv::GetEvaluationRequest
            {
                EvaluationName = gcdv::EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]"),
            };
            // Make the request
            gcdv::Evaluation response = documentProcessorServiceClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEvaluationRequest request = new gcdv::GetEvaluationRequest
            {
                EvaluationName = gcdv::EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]"),
            };
            // Make the request
            gcdv::Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]/evaluations/[EVALUATION]";
            // Make the request
            gcdv::Evaluation response = documentProcessorServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]/evaluations/[EVALUATION]";
            // Make the request
            gcdv::Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EvaluationName name = gcdv::EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]");
            // Make the request
            gcdv::Evaluation response = documentProcessorServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EvaluationName name = gcdv::EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]");
            // Make the request
            gcdv::Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsRequestObject()
        {
            // Snippet: ListEvaluations(ListEvaluationsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEvaluationsRequest request = new gcdv::ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsRequestObjectAsync()
        {
            // Snippet: ListEvaluationsAsync(ListEvaluationsRequest, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEvaluationsRequest request = new gcdv::ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluations()
        {
            // Snippet: ListEvaluations(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            PagedEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsAsync()
        {
            // Snippet: ListEvaluationsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsResourceNames()
        {
            // Snippet: ListEvaluations(ProcessorVersionName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = gcdv::DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName parent = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            PagedEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvaluationsAsync</summary>
        public async Task ListEvaluationsResourceNamesAsync()
        {
            // Snippet: ListEvaluationsAsync(ProcessorVersionName, string, int?, CallSettings)
            // Create client
            gcdv::DocumentProcessorServiceClient documentProcessorServiceClient = await gcdv::DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ProcessorVersionName parent = gcdv::ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEvaluationsResponse, gcdv::Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Evaluation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
