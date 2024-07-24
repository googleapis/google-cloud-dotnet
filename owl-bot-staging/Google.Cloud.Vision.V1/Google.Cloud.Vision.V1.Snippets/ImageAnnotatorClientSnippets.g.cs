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
    using Google.Cloud.Vision.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedImageAnnotatorClientSnippets
    {
        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImagesRequestObject()
        {
            // Snippet: BatchAnnotateImages(BatchAnnotateImagesRequest, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchAnnotateImagesResponse response = imageAnnotatorClient.BatchAnnotateImages(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImagesAsync</summary>
        public async Task BatchAnnotateImagesRequestObjectAsync()
        {
            // Snippet: BatchAnnotateImagesAsync(BatchAnnotateImagesRequest, CallSettings)
            // Additional: BatchAnnotateImagesAsync(BatchAnnotateImagesRequest, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchAnnotateImagesResponse response = await imageAnnotatorClient.BatchAnnotateImagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImages()
        {
            // Snippet: BatchAnnotateImages(IEnumerable<AnnotateImageRequest>, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new AnnotateImageRequest[]
            {
                new AnnotateImageRequest(),
            };
            // Make the request
            BatchAnnotateImagesResponse response = imageAnnotatorClient.BatchAnnotateImages(requests);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImagesAsync</summary>
        public async Task BatchAnnotateImagesAsync()
        {
            // Snippet: BatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>, CallSettings)
            // Additional: BatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new AnnotateImageRequest[]
            {
                new AnnotateImageRequest(),
            };
            // Make the request
            BatchAnnotateImagesResponse response = await imageAnnotatorClient.BatchAnnotateImagesAsync(requests);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateFiles</summary>
        public void BatchAnnotateFilesRequestObject()
        {
            // Snippet: BatchAnnotateFiles(BatchAnnotateFilesRequest, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchAnnotateFilesResponse response = imageAnnotatorClient.BatchAnnotateFiles(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateFilesAsync</summary>
        public async Task BatchAnnotateFilesRequestObjectAsync()
        {
            // Snippet: BatchAnnotateFilesAsync(BatchAnnotateFilesRequest, CallSettings)
            // Additional: BatchAnnotateFilesAsync(BatchAnnotateFilesRequest, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            BatchAnnotateFilesResponse response = await imageAnnotatorClient.BatchAnnotateFilesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateFiles</summary>
        public void BatchAnnotateFiles()
        {
            // Snippet: BatchAnnotateFiles(IEnumerable<AnnotateFileRequest>, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AnnotateFileRequest> requests = new AnnotateFileRequest[]
            {
                new AnnotateFileRequest(),
            };
            // Make the request
            BatchAnnotateFilesResponse response = imageAnnotatorClient.BatchAnnotateFiles(requests);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateFilesAsync</summary>
        public async Task BatchAnnotateFilesAsync()
        {
            // Snippet: BatchAnnotateFilesAsync(IEnumerable<AnnotateFileRequest>, CallSettings)
            // Additional: BatchAnnotateFilesAsync(IEnumerable<AnnotateFileRequest>, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AnnotateFileRequest> requests = new AnnotateFileRequest[]
            {
                new AnnotateFileRequest(),
            };
            // Make the request
            BatchAnnotateFilesResponse response = await imageAnnotatorClient.BatchAnnotateFilesAsync(requests);
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateImages</summary>
        public void AsyncBatchAnnotateImagesRequestObject()
        {
            // Snippet: AsyncBatchAnnotateImages(AsyncBatchAnnotateImagesRequest, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            AsyncBatchAnnotateImagesRequest request = new AsyncBatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                OutputConfig = new OutputConfig(),
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> response = imageAnnotatorClient.AsyncBatchAnnotateImages(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateImagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> retrievedResponse = imageAnnotatorClient.PollOnceAsyncBatchAnnotateImages(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateImagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateImagesAsync</summary>
        public async Task AsyncBatchAnnotateImagesRequestObjectAsync()
        {
            // Snippet: AsyncBatchAnnotateImagesAsync(AsyncBatchAnnotateImagesRequest, CallSettings)
            // Additional: AsyncBatchAnnotateImagesAsync(AsyncBatchAnnotateImagesRequest, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            AsyncBatchAnnotateImagesRequest request = new AsyncBatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest(),
                },
                OutputConfig = new OutputConfig(),
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> response = await imageAnnotatorClient.AsyncBatchAnnotateImagesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateImagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> retrievedResponse = await imageAnnotatorClient.PollOnceAsyncBatchAnnotateImagesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateImagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateImages</summary>
        public void AsyncBatchAnnotateImages()
        {
            // Snippet: AsyncBatchAnnotateImages(IEnumerable<AnnotateImageRequest>, OutputConfig, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new AnnotateImageRequest[]
            {
                new AnnotateImageRequest(),
            };
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> response = imageAnnotatorClient.AsyncBatchAnnotateImages(requests, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateImagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> retrievedResponse = imageAnnotatorClient.PollOnceAsyncBatchAnnotateImages(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateImagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateImagesAsync</summary>
        public async Task AsyncBatchAnnotateImagesAsync()
        {
            // Snippet: AsyncBatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>, OutputConfig, CallSettings)
            // Additional: AsyncBatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>, OutputConfig, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new AnnotateImageRequest[]
            {
                new AnnotateImageRequest(),
            };
            OutputConfig outputConfig = new OutputConfig();
            // Make the request
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> response = await imageAnnotatorClient.AsyncBatchAnnotateImagesAsync(requests, outputConfig);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateImagesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateImagesResponse, OperationMetadata> retrievedResponse = await imageAnnotatorClient.PollOnceAsyncBatchAnnotateImagesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateImagesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFiles</summary>
        public void AsyncBatchAnnotateFilesRequestObject()
        {
            // Snippet: AsyncBatchAnnotateFiles(AsyncBatchAnnotateFilesRequest, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            AsyncBatchAnnotateFilesRequest request = new AsyncBatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AsyncAnnotateFileRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response = imageAnnotatorClient.AsyncBatchAnnotateFiles(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse = imageAnnotatorClient.PollOnceAsyncBatchAnnotateFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFilesAsync</summary>
        public async Task AsyncBatchAnnotateFilesRequestObjectAsync()
        {
            // Snippet: AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest, CallSettings)
            // Additional: AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            AsyncBatchAnnotateFilesRequest request = new AsyncBatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AsyncAnnotateFileRequest(),
                },
                Parent = "",
                Labels = { { "", "" }, },
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response = await imageAnnotatorClient.AsyncBatchAnnotateFilesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse = await imageAnnotatorClient.PollOnceAsyncBatchAnnotateFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFiles</summary>
        public void AsyncBatchAnnotateFiles()
        {
            // Snippet: AsyncBatchAnnotateFiles(IEnumerable<AsyncAnnotateFileRequest>, CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AsyncAnnotateFileRequest> requests = new AsyncAnnotateFileRequest[]
            {
                new AsyncAnnotateFileRequest(),
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response = imageAnnotatorClient.AsyncBatchAnnotateFiles(requests);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse = imageAnnotatorClient.PollOnceAsyncBatchAnnotateFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFilesAsync</summary>
        public async Task AsyncBatchAnnotateFilesAsync()
        {
            // Snippet: AsyncBatchAnnotateFilesAsync(IEnumerable<AsyncAnnotateFileRequest>, CallSettings)
            // Additional: AsyncBatchAnnotateFilesAsync(IEnumerable<AsyncAnnotateFileRequest>, CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AsyncAnnotateFileRequest> requests = new AsyncAnnotateFileRequest[]
            {
                new AsyncAnnotateFileRequest(),
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response = await imageAnnotatorClient.AsyncBatchAnnotateFilesAsync(requests);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse = await imageAnnotatorClient.PollOnceAsyncBatchAnnotateFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
