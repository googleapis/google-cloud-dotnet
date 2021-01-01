// Copyright 2021 Google LLC
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

namespace Google.Cloud.DocumentAI.V1Beta2.Snippets
{
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDocumentUnderstandingServiceClientSnippets
    {
        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocumentsRequestObject()
        {
            // Snippet: BatchProcessDocuments(BatchProcessDocumentsRequest, CallSettings)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = DocumentUnderstandingServiceClient.Create();
            // Initialize request argument(s)
            BatchProcessDocumentsRequest request = new BatchProcessDocumentsRequest
            {
                Requests =
                {
                    new ProcessDocumentRequest(),
                },
                Parent = "",
            };
            // Make the request
            Operation<BatchProcessDocumentsResponse, OperationMetadata> response = documentUnderstandingServiceClient.BatchProcessDocuments(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessDocumentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchProcessDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessDocumentsResponse, OperationMetadata> retrievedResponse = documentUnderstandingServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsRequestObjectAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(BatchProcessDocumentsRequest, CallSettings)
            // Additional: BatchProcessDocumentsAsync(BatchProcessDocumentsRequest, CancellationToken)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = await DocumentUnderstandingServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchProcessDocumentsRequest request = new BatchProcessDocumentsRequest
            {
                Requests =
                {
                    new ProcessDocumentRequest(),
                },
                Parent = "",
            };
            // Make the request
            Operation<BatchProcessDocumentsResponse, OperationMetadata> response = await documentUnderstandingServiceClient.BatchProcessDocumentsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessDocumentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchProcessDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessDocumentsResponse, OperationMetadata> retrievedResponse = await documentUnderstandingServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocuments</summary>
        public void BatchProcessDocuments()
        {
            // Snippet: BatchProcessDocuments(IEnumerable<ProcessDocumentRequest>, CallSettings)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = DocumentUnderstandingServiceClient.Create();
            // Initialize request argument(s)
            IEnumerable<ProcessDocumentRequest> requests = new ProcessDocumentRequest[]
            {
                new ProcessDocumentRequest(),
            };
            // Make the request
            Operation<BatchProcessDocumentsResponse, OperationMetadata> response = documentUnderstandingServiceClient.BatchProcessDocuments(requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessDocumentsResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchProcessDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessDocumentsResponse, OperationMetadata> retrievedResponse = documentUnderstandingServiceClient.PollOnceBatchProcessDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchProcessDocumentsAsync</summary>
        public async Task BatchProcessDocumentsAsync()
        {
            // Snippet: BatchProcessDocumentsAsync(IEnumerable<ProcessDocumentRequest>, CallSettings)
            // Additional: BatchProcessDocumentsAsync(IEnumerable<ProcessDocumentRequest>, CancellationToken)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = await DocumentUnderstandingServiceClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<ProcessDocumentRequest> requests = new ProcessDocumentRequest[]
            {
                new ProcessDocumentRequest(),
            };
            // Make the request
            Operation<BatchProcessDocumentsResponse, OperationMetadata> response = await documentUnderstandingServiceClient.BatchProcessDocumentsAsync(requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchProcessDocumentsResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchProcessDocumentsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchProcessDocumentsResponse, OperationMetadata> retrievedResponse = await documentUnderstandingServiceClient.PollOnceBatchProcessDocumentsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchProcessDocumentsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ProcessDocument</summary>
        public void ProcessDocumentRequestObject()
        {
            // Snippet: ProcessDocument(ProcessDocumentRequest, CallSettings)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = DocumentUnderstandingServiceClient.Create();
            // Initialize request argument(s)
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                DocumentType = "",
                TableExtractionParams = new TableExtractionParams(),
                FormExtractionParams = new FormExtractionParams(),
                EntityExtractionParams = new EntityExtractionParams(),
                OcrParams = new OcrParams(),
                AutomlParams = new AutoMlParams(),
                Parent = "",
            };
            // Make the request
            Document response = documentUnderstandingServiceClient.ProcessDocument(request);
            // End snippet
        }

        /// <summary>Snippet for ProcessDocumentAsync</summary>
        public async Task ProcessDocumentRequestObjectAsync()
        {
            // Snippet: ProcessDocumentAsync(ProcessDocumentRequest, CallSettings)
            // Additional: ProcessDocumentAsync(ProcessDocumentRequest, CancellationToken)
            // Create client
            DocumentUnderstandingServiceClient documentUnderstandingServiceClient = await DocumentUnderstandingServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                DocumentType = "",
                TableExtractionParams = new TableExtractionParams(),
                FormExtractionParams = new FormExtractionParams(),
                EntityExtractionParams = new EntityExtractionParams(),
                OcrParams = new OcrParams(),
                AutomlParams = new AutoMlParams(),
                Parent = "",
            };
            // Make the request
            Document response = await documentUnderstandingServiceClient.ProcessDocumentAsync(request);
            // End snippet
        }
    }
}
