// Copyright 2024 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DocumentAI.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDocumentProcessorServiceClientSnippets
    {
        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentRequestObject()
        {
            // Snippet: ProcessDocument(ProcessRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InlineDocument = new Document(),
                FieldMask = new FieldMask(),
                ProcessOptions = new ProcessOptions(),
                Labels = { { "", "" }, },
                ImagelessMode = false,
            };
            // Make the request
            ProcessResponse response = documentProcessorServiceClient.ProcessDocument(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentRequestObjectAsync()
        {
            // Snippet: ProcessDocumentAsync(ProcessRequest, CallSettings)
            // Additional: ProcessDocumentAsync(ProcessRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessRequest request = new ProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InlineDocument = new Document(),
                FieldMask = new FieldMask(),
                ProcessOptions = new ProcessOptions(),
                Labels = { { "", "" }, },
                ImagelessMode = false,
            };
            // Make the request
            ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocument()
        {
            // Snippet: ProcessDocument(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            ProcessResponse response = documentProcessorServiceClient.ProcessDocument(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentAsync()
        {
            // Snippet: ProcessDocumentAsync(string, CallSettings)
            // Additional: ProcessDocumentAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentResourceNames()
        {
            // Snippet: ProcessDocument(IResourceName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            ProcessResponse response = documentProcessorServiceClient.ProcessDocument(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentResourceNamesAsync()
        {
            // Snippet: ProcessDocumentAsync(IResourceName, CallSettings)
            // Additional: ProcessDocumentAsync(IResourceName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocumentsRequestObject()
        {
            // Snippet: BatchProcessDocuments(BatchProcessRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            BatchProcessRequest request = new BatchProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InputDocuments = new BatchDocumentsInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
                ProcessOptions = new ProcessOptions(),
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsRequestObjectAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(BatchProcessRequest, CallSettings)
            // Additional: BatchProcessDocumentsAsync(BatchProcessRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchProcessRequest request = new BatchProcessRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                SkipHumanReview = false,
                InputDocuments = new BatchDocumentsInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
                ProcessOptions = new ProcessOptions(),
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocuments()
        {
            // Snippet: BatchProcessDocuments(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(string, CallSettings)
            // Additional: BatchProcessDocumentsAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "a/wildcard/resource";
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocumentsResourceNames()
        {
            // Snippet: BatchProcessDocuments(IResourceName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = documentProcessorServiceClient.BatchProcessDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsResourceNamesAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(IResourceName, CallSettings)
            // Additional: BatchProcessDocumentsAsync(IResourceName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Operation<BatchProcessResponse, BatchProcessMetadata> response = await documentProcessorServiceClient.BatchProcessDocumentsAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessResponse, BatchProcessMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessResponse, BatchProcessMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypesRequestObject()
        {
            // Snippet: FetchProcessorTypes(FetchProcessorTypesRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(request);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesRequestObjectAsync()
        {
            // Snippet: FetchProcessorTypesAsync(FetchProcessorTypesRequest, CallSettings)
            // Additional: FetchProcessorTypesAsync(FetchProcessorTypesRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchProcessorTypesRequest request = new FetchProcessorTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypes()
        {
            // Snippet: FetchProcessorTypes(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesAsync()
        {
            // Snippet: FetchProcessorTypesAsync(string, CallSettings)
            // Additional: FetchProcessorTypesAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypes</summary>
        public void FetchProcessorTypesResourceNames()
        {
            // Snippet: FetchProcessorTypes(LocationName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            FetchProcessorTypesResponse response = documentProcessorServiceClient.FetchProcessorTypes(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchProcessorTypesAsync</summary>
        public async Task FetchProcessorTypesResourceNamesAsync()
        {
            // Snippet: FetchProcessorTypesAsync(LocationName, CallSettings)
            // Additional: FetchProcessorTypesAsync(LocationName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            FetchProcessorTypesResponse response = await documentProcessorServiceClient.FetchProcessorTypesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypesRequestObject()
        {
            // Snippet: ListProcessorTypes(ListProcessorTypesRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypes</summary>
        public void ListProcessorTypesResourceNames()
        {
            // Snippet: ListProcessorTypes(LocationName, string, int?, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorTypesAsync</summary>
        public async Task ListProcessorTypesResourceNamesAsync()
        {
            // Snippet: ListProcessorTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> response = documentProcessorServiceClient.ListProcessorTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorType item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            GetProcessorTypeRequest request = new GetProcessorTypeRequest
            {
                ProcessorTypeName = ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]"),
            };
            // Make the request
            ProcessorType response = documentProcessorServiceClient.GetProcessorType(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeRequestObjectAsync()
        {
            // Snippet: GetProcessorTypeAsync(GetProcessorTypeRequest, CallSettings)
            // Additional: GetProcessorTypeAsync(GetProcessorTypeRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessorTypeRequest request = new GetProcessorTypeRequest
            {
                ProcessorTypeName = ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]"),
            };
            // Make the request
            ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorType</summary>
        public void GetProcessorType()
        {
            // Snippet: GetProcessorType(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processorTypes/[PROCESSOR_TYPE]";
            // Make the request
            ProcessorType response = documentProcessorServiceClient.GetProcessorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeAsync()
        {
            // Snippet: GetProcessorTypeAsync(string, CallSettings)
            // Additional: GetProcessorTypeAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processorTypes/[PROCESSOR_TYPE]";
            // Make the request
            ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorType</summary>
        public void GetProcessorTypeResourceNames()
        {
            // Snippet: GetProcessorType(ProcessorTypeName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorTypeName name = ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]");
            // Make the request
            ProcessorType response = documentProcessorServiceClient.GetProcessorType(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorTypeAsync</summary>
        public async Task GetProcessorTypeResourceNamesAsync()
        {
            // Snippet: GetProcessorTypeAsync(ProcessorTypeName, CallSettings)
            // Additional: GetProcessorTypeAsync(ProcessorTypeName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorTypeName name = ProcessorTypeName.FromProjectLocationProcessorType("[PROJECT]", "[LOCATION]", "[PROCESSOR_TYPE]");
            // Make the request
            ProcessorType response = await documentProcessorServiceClient.GetProcessorTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsRequestObject()
        {
            // Snippet: ListProcessors(ListProcessorsRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ListProcessorsRequest request = new ListProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessorsRequest request = new ListProcessorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessors</summary>
        public void ListProcessorsResourceNames()
        {
            // Snippet: ListProcessors(LocationName, string, int?, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Processor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessorsAsync</summary>
        public async Task ListProcessorsResourceNamesAsync()
        {
            // Snippet: ListProcessorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProcessorsResponse, Processor> response = documentProcessorServiceClient.ListProcessorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Processor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Processor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Processor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Processor item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Processor response = documentProcessorServiceClient.GetProcessor(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorRequestObjectAsync()
        {
            // Snippet: GetProcessorAsync(GetProcessorRequest, CallSettings)
            // Additional: GetProcessorAsync(GetProcessorRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessorRequest request = new GetProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Processor response = await documentProcessorServiceClient.GetProcessorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessor()
        {
            // Snippet: GetProcessor(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Processor response = documentProcessorServiceClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorAsync()
        {
            // Snippet: GetProcessorAsync(string, CallSettings)
            // Additional: GetProcessorAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Processor response = await documentProcessorServiceClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessor</summary>
        public void GetProcessorResourceNames()
        {
            // Snippet: GetProcessor(ProcessorName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Processor response = documentProcessorServiceClient.GetProcessor(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorAsync</summary>
        public async Task GetProcessorResourceNamesAsync()
        {
            // Snippet: GetProcessorAsync(ProcessorName, CallSettings)
            // Additional: GetProcessorAsync(ProcessorName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Processor response = await documentProcessorServiceClient.GetProcessorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersionRequestObject()
        {
            // Snippet: TrainProcessorVersion(TrainProcessorVersionRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            TrainProcessorVersionRequest request = new TrainProcessorVersionRequest
            {
                ParentAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                ProcessorVersion = new ProcessorVersion(),
                InputData = new TrainProcessorVersionRequest.Types.InputData(),
                CustomDocumentExtractionOptions = new TrainProcessorVersionRequest.Types.CustomDocumentExtractionOptions(),
                BaseProcessorVersion = "",
                DocumentSchema = new DocumentSchema(),
            };
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionRequestObjectAsync()
        {
            // Snippet: TrainProcessorVersionAsync(TrainProcessorVersionRequest, CallSettings)
            // Additional: TrainProcessorVersionAsync(TrainProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrainProcessorVersionRequest request = new TrainProcessorVersionRequest
            {
                ParentAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                ProcessorVersion = new ProcessorVersion(),
                InputData = new TrainProcessorVersionRequest.Types.InputData(),
                CustomDocumentExtractionOptions = new TrainProcessorVersionRequest.Types.CustomDocumentExtractionOptions(),
                BaseProcessorVersion = "",
                DocumentSchema = new DocumentSchema(),
            };
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersion()
        {
            // Snippet: TrainProcessorVersion(string, ProcessorVersion, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            ProcessorVersion processorVersion = new ProcessorVersion();
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionAsync()
        {
            // Snippet: TrainProcessorVersionAsync(string, ProcessorVersion, CallSettings)
            // Additional: TrainProcessorVersionAsync(string, ProcessorVersion, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            ProcessorVersion processorVersion = new ProcessorVersion();
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersion</summary>
        public void TrainProcessorVersionResourceNames()
        {
            // Snippet: TrainProcessorVersion(ProcessorName, ProcessorVersion, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName parent = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            ProcessorVersion processorVersion = new ProcessorVersion();
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = documentProcessorServiceClient.TrainProcessorVersion(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceTrainProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainProcessorVersionAsync</summary>
        public async Task TrainProcessorVersionResourceNamesAsync()
        {
            // Snippet: TrainProcessorVersionAsync(ProcessorName, ProcessorVersion, CallSettings)
            // Additional: TrainProcessorVersionAsync(ProcessorName, ProcessorVersion, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName parent = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            ProcessorVersion processorVersion = new ProcessorVersion();
            // Make the request
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> response = await documentProcessorServiceClient.TrainProcessorVersionAsync(parent, processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TrainProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceTrainProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersionRequestObject()
        {
            // Snippet: GetProcessorVersion(GetProcessorVersionRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionRequestObjectAsync()
        {
            // Snippet: GetProcessorVersionAsync(GetProcessorVersionRequest, CallSettings)
            // Additional: GetProcessorVersionAsync(GetProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessorVersionRequest request = new GetProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersion()
        {
            // Snippet: GetProcessorVersion(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionAsync()
        {
            // Snippet: GetProcessorVersionAsync(string, CallSettings)
            // Additional: GetProcessorVersionAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersion</summary>
        public void GetProcessorVersionResourceNames()
        {
            // Snippet: GetProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            ProcessorVersion response = documentProcessorServiceClient.GetProcessorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessorVersionAsync</summary>
        public async Task GetProcessorVersionResourceNamesAsync()
        {
            // Snippet: GetProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: GetProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            ProcessorVersion response = await documentProcessorServiceClient.GetProcessorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProcessorVersions</summary>
        public void ListProcessorVersionsRequestObject()
        {
            // Snippet: ListProcessorVersions(ListProcessorVersionsRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
            {
                ParentAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
            {
                ParentAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName parent = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProcessorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName parent = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> response = documentProcessorServiceClient.ListProcessorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProcessorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProcessorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProcessorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProcessorVersion item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            DeleteProcessorVersionRequest request = new DeleteProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProcessorVersionRequest request = new DeleteProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = documentProcessorServiceClient.DeleteProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessorVersion(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<Empty, DeleteProcessorVersionMetadata> response = await documentProcessorServiceClient.DeleteProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorVersionAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            DeployProcessorVersionRequest request = new DeployProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionRequestObjectAsync()
        {
            // Snippet: DeployProcessorVersionAsync(DeployProcessorVersionRequest, CallSettings)
            // Additional: DeployProcessorVersionAsync(DeployProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployProcessorVersionRequest request = new DeployProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersion</summary>
        public void DeployProcessorVersion()
        {
            // Snippet: DeployProcessorVersion(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionAsync()
        {
            // Snippet: DeployProcessorVersionAsync(string, CallSettings)
            // Additional: DeployProcessorVersionAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersion</summary>
        public void DeployProcessorVersionResourceNames()
        {
            // Snippet: DeployProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = documentProcessorServiceClient.DeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        public async Task DeployProcessorVersionResourceNamesAsync()
        {
            // Snippet: DeployProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: DeployProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersionRequestObject()
        {
            // Snippet: UndeployProcessorVersion(UndeployProcessorVersionRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            UndeployProcessorVersionRequest request = new UndeployProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionRequestObjectAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(UndeployProcessorVersionRequest, CallSettings)
            // Additional: UndeployProcessorVersionAsync(UndeployProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            UndeployProcessorVersionRequest request = new UndeployProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersion()
        {
            // Snippet: UndeployProcessorVersion(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(string, CallSettings)
            // Additional: UndeployProcessorVersionAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersion</summary>
        public void UndeployProcessorVersionResourceNames()
        {
            // Snippet: UndeployProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = documentProcessorServiceClient.UndeployProcessorVersion(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceUndeployProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployProcessorVersionAsync</summary>
        public async Task UndeployProcessorVersionResourceNamesAsync()
        {
            // Snippet: UndeployProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: UndeployProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName name = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> response = await documentProcessorServiceClient.UndeployProcessorVersionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceUndeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorRequestObject()
        {
            // Snippet: CreateProcessor(CreateProcessorRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            // Make the request
            Processor response = documentProcessorServiceClient.CreateProcessor(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorRequestObjectAsync()
        {
            // Snippet: CreateProcessorAsync(CreateProcessorRequest, CallSettings)
            // Additional: CreateProcessorAsync(CreateProcessorRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProcessorRequest request = new CreateProcessorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Processor = new Processor(),
            };
            // Make the request
            Processor response = await documentProcessorServiceClient.CreateProcessorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessor()
        {
            // Snippet: CreateProcessor(string, Processor, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Processor processor = new Processor();
            // Make the request
            Processor response = documentProcessorServiceClient.CreateProcessor(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorAsync()
        {
            // Snippet: CreateProcessorAsync(string, Processor, CallSettings)
            // Additional: CreateProcessorAsync(string, Processor, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Processor processor = new Processor();
            // Make the request
            Processor response = await documentProcessorServiceClient.CreateProcessorAsync(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessor</summary>
        public void CreateProcessorResourceNames()
        {
            // Snippet: CreateProcessor(LocationName, Processor, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Processor processor = new Processor();
            // Make the request
            Processor response = documentProcessorServiceClient.CreateProcessor(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for CreateProcessorAsync</summary>
        public async Task CreateProcessorResourceNamesAsync()
        {
            // Snippet: CreateProcessorAsync(LocationName, Processor, CallSettings)
            // Additional: CreateProcessorAsync(LocationName, Processor, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Processor processor = new Processor();
            // Make the request
            Processor response = await documentProcessorServiceClient.CreateProcessorAsync(parent, processor);
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessor</summary>
        public void DeleteProcessorRequestObject()
        {
            // Snippet: DeleteProcessor(DeleteProcessorRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            DeleteProcessorRequest request = new DeleteProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProcessorRequest request = new DeleteProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = documentProcessorServiceClient.DeleteProcessor(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDeleteProcessor(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<Empty, DeleteProcessorMetadata> response = await documentProcessorServiceClient.DeleteProcessorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeleteProcessorAsync(operationName);
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            EnableProcessorRequest request = new EnableProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<EnableProcessorResponse, EnableProcessorMetadata> response = documentProcessorServiceClient.EnableProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableProcessorResponse, EnableProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EnableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableProcessorResponse, EnableProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEnableProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EnableProcessorAsync</summary>
        public async Task EnableProcessorRequestObjectAsync()
        {
            // Snippet: EnableProcessorAsync(EnableProcessorRequest, CallSettings)
            // Additional: EnableProcessorAsync(EnableProcessorRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableProcessorRequest request = new EnableProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<EnableProcessorResponse, EnableProcessorMetadata> response = await documentProcessorServiceClient.EnableProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EnableProcessorResponse, EnableProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EnableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EnableProcessorResponse, EnableProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEnableProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EnableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableProcessor</summary>
        public void DisableProcessorRequestObject()
        {
            // Snippet: DisableProcessor(DisableProcessorRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            DisableProcessorRequest request = new DisableProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<DisableProcessorResponse, DisableProcessorMetadata> response = documentProcessorServiceClient.DisableProcessor(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableProcessorResponse, DisableProcessorMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DisableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableProcessorResponse, DisableProcessorMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceDisableProcessor(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DisableProcessorAsync</summary>
        public async Task DisableProcessorRequestObjectAsync()
        {
            // Snippet: DisableProcessorAsync(DisableProcessorRequest, CallSettings)
            // Additional: DisableProcessorAsync(DisableProcessorRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableProcessorRequest request = new DisableProcessorRequest
            {
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
            };
            // Make the request
            Operation<DisableProcessorResponse, DisableProcessorMetadata> response = await documentProcessorServiceClient.DisableProcessorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DisableProcessorResponse, DisableProcessorMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DisableProcessorResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DisableProcessorResponse, DisableProcessorMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDisableProcessorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DisableProcessorResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultProcessorVersion</summary>
        public void SetDefaultProcessorVersionRequestObject()
        {
            // Snippet: SetDefaultProcessorVersion(SetDefaultProcessorVersionRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            SetDefaultProcessorVersionRequest request = new SetDefaultProcessorVersionRequest
            {
                ProcessorAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> response = documentProcessorServiceClient.SetDefaultProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetDefaultProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceSetDefaultProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetDefaultProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetDefaultProcessorVersionAsync</summary>
        public async Task SetDefaultProcessorVersionRequestObjectAsync()
        {
            // Snippet: SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest, CallSettings)
            // Additional: SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetDefaultProcessorVersionRequest request = new SetDefaultProcessorVersionRequest
            {
                ProcessorAsProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                DefaultProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> response = await documentProcessorServiceClient.SetDefaultProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetDefaultProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceSetDefaultProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetDefaultProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocumentRequestObject()
        {
            // Snippet: ReviewDocument(ReviewDocumentRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ReviewDocumentRequest request = new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                EnableSchemaValidation = false,
                InlineDocument = new Document(),
                Priority = ReviewDocumentRequest.Types.Priority.Default,
                DocumentSchema = new DocumentSchema(),
            };
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(request);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentRequestObjectAsync()
        {
            // Snippet: ReviewDocumentAsync(ReviewDocumentRequest, CallSettings)
            // Additional: ReviewDocumentAsync(ReviewDocumentRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReviewDocumentRequest request = new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                EnableSchemaValidation = false,
                InlineDocument = new Document(),
                Priority = ReviewDocumentRequest.Types.Priority.Default,
                DocumentSchema = new DocumentSchema(),
            };
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocument()
        {
            // Snippet: ReviewDocument(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string humanReviewConfig = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/humanReviewConfig";
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentAsync()
        {
            // Snippet: ReviewDocumentAsync(string, CallSettings)
            // Additional: ReviewDocumentAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string humanReviewConfig = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/humanReviewConfig";
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocument</summary>
        public void ReviewDocumentResourceNames()
        {
            // Snippet: ReviewDocument(HumanReviewConfigName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            HumanReviewConfigName humanReviewConfig = HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = documentProcessorServiceClient.ReviewDocument(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceReviewDocument(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReviewDocumentAsync</summary>
        public async Task ReviewDocumentResourceNamesAsync()
        {
            // Snippet: ReviewDocumentAsync(HumanReviewConfigName, CallSettings)
            // Additional: ReviewDocumentAsync(HumanReviewConfigName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            HumanReviewConfigName humanReviewConfig = HumanReviewConfigName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> response = await documentProcessorServiceClient.ReviewDocumentAsync(humanReviewConfig);

            // Poll until the returned long-running operation is complete
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReviewDocumentResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceReviewDocumentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReviewDocumentResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersionRequestObject()
        {
            // Snippet: EvaluateProcessorVersion(EvaluateProcessorVersionRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            EvaluateProcessorVersionRequest request = new EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                EvaluationDocuments = new BatchDocumentsInputConfig(),
            };
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(request);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionRequestObjectAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluateProcessorVersionRequest request = new EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
                EvaluationDocuments = new BatchDocumentsInputConfig(),
            };
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersion()
        {
            // Snippet: EvaluateProcessorVersion(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string processorVersion = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(string, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string processorVersion = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersion</summary>
        public void EvaluateProcessorVersionResourceNames()
        {
            // Snippet: EvaluateProcessorVersion(ProcessorVersionName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName processorVersion = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = documentProcessorServiceClient.EvaluateProcessorVersion(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = documentProcessorServiceClient.PollOnceEvaluateProcessorVersion(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateProcessorVersionAsync</summary>
        public async Task EvaluateProcessorVersionResourceNamesAsync()
        {
            // Snippet: EvaluateProcessorVersionAsync(ProcessorVersionName, CallSettings)
            // Additional: EvaluateProcessorVersionAsync(ProcessorVersionName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName processorVersion = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> response = await documentProcessorServiceClient.EvaluateProcessorVersionAsync(processorVersion);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EvaluateProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceEvaluateProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationRequestObject()
        {
            // Snippet: GetEvaluation(GetEvaluationRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = documentProcessorServiceClient.GetEvaluation(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationRequestObjectAsync()
        {
            // Snippet: GetEvaluationAsync(GetEvaluationRequest, CallSettings)
            // Additional: GetEvaluationAsync(GetEvaluationRequest, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEvaluationRequest request = new GetEvaluationRequest
            {
                EvaluationName = EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]"),
            };
            // Make the request
            Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluation()
        {
            // Snippet: GetEvaluation(string, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = documentProcessorServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationAsync()
        {
            // Snippet: GetEvaluationAsync(string, CallSettings)
            // Additional: GetEvaluationAsync(string, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]/evaluations/[EVALUATION]";
            // Make the request
            Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluation</summary>
        public void GetEvaluationResourceNames()
        {
            // Snippet: GetEvaluation(EvaluationName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]");
            // Make the request
            Evaluation response = documentProcessorServiceClient.GetEvaluation(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvaluationAsync</summary>
        public async Task GetEvaluationResourceNamesAsync()
        {
            // Snippet: GetEvaluationAsync(EvaluationName, CallSettings)
            // Additional: GetEvaluationAsync(EvaluationName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluationName name = EvaluationName.FromProjectLocationProcessorProcessorVersionEvaluation("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]", "[EVALUATION]");
            // Make the request
            Evaluation response = await documentProcessorServiceClient.GetEvaluationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEvaluations</summary>
        public void ListEvaluationsRequestObject()
        {
            // Snippet: ListEvaluations(ListEvaluationsRequest, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]/processorVersions/[PROCESSOR_VERSION]";
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorVersionName parent = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            PagedEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Evaluation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEvaluationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorVersionName parent = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]");
            // Make the request
            PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> response = documentProcessorServiceClient.ListEvaluationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Evaluation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEvaluationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Evaluation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Evaluation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Evaluation item in singlePage)
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
