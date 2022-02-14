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

namespace Google.Cloud.DocumentAI.V1Beta3.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
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
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                SkipHumanReview = false,
                InlineDocument = new Document(),
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
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                SkipHumanReview = false,
                InlineDocument = new Document(),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
            // Make the request
            ProcessResponse response = await documentProcessorServiceClient.ProcessDocumentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentResourceNames()
        {
            // Snippet: ProcessDocument(ProcessorName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
            // Make the request
            ProcessResponse response = documentProcessorServiceClient.ProcessDocument(name);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentResourceNamesAsync()
        {
            // Snippet: ProcessDocumentAsync(ProcessorName, CallSettings)
            // Additional: ProcessDocumentAsync(ProcessorName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
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
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                SkipHumanReview = false,
                InputDocuments = new BatchDocumentsInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
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
                ProcessorName = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]"),
                SkipHumanReview = false,
                InputDocuments = new BatchDocumentsInputConfig(),
                DocumentOutputConfig = new DocumentOutputConfig(),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/processors/[PROCESSOR]";
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
            // Snippet: BatchProcessDocuments(ProcessorName, CallSettings)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = DocumentProcessorServiceClient.Create();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
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
            // Snippet: BatchProcessDocumentsAsync(ProcessorName, CallSettings)
            // Additional: BatchProcessDocumentsAsync(ProcessorName, CancellationToken)
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessorName name = ProcessorName.FromProjectLocationProcessor("[PROJECT]", "[LOCATION]", "[PROCESSOR]");
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
    }
}
