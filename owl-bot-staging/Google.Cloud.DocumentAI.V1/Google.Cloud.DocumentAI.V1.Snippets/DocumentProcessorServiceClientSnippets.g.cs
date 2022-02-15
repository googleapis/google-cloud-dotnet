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

namespace Google.Cloud.DocumentAI.V1.Snippets
{
    using Google.LongRunning;
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
