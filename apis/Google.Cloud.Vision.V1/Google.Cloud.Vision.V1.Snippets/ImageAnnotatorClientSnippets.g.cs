// Copyright 2018 Google LLC
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

namespace Google.Cloud.Vision.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Vision.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedImageAnnotatorClientSnippets
    {
        /// <summary>Snippet for BatchAnnotateImagesAsync</summary>
        public async Task BatchAnnotateImagesAsync()
        {
            // Snippet: BatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>,CallSettings)
            // Additional: BatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest>,CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new List<AnnotateImageRequest>();
            // Make the request
            BatchAnnotateImagesResponse response = await imageAnnotatorClient.BatchAnnotateImagesAsync(requests);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImages()
        {
            // Snippet: BatchAnnotateImages(IEnumerable<AnnotateImageRequest>,CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AnnotateImageRequest> requests = new List<AnnotateImageRequest>();
            // Make the request
            BatchAnnotateImagesResponse response = imageAnnotatorClient.BatchAnnotateImages(requests);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImagesAsync</summary>
        public async Task BatchAnnotateImagesAsync_RequestObject()
        {
            // Snippet: BatchAnnotateImagesAsync(BatchAnnotateImagesRequest,CallSettings)
            // Additional: BatchAnnotateImagesAsync(BatchAnnotateImagesRequest,CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            // Make the request
            BatchAnnotateImagesResponse response = await imageAnnotatorClient.BatchAnnotateImagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImages_RequestObject()
        {
            // Snippet: BatchAnnotateImages(BatchAnnotateImagesRequest,CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests = { },
            };
            // Make the request
            BatchAnnotateImagesResponse response = imageAnnotatorClient.BatchAnnotateImages(request);
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFilesAsync</summary>
        public async Task AsyncBatchAnnotateFilesAsync()
        {
            // Snippet: AsyncBatchAnnotateFilesAsync(IEnumerable<AsyncAnnotateFileRequest>,CallSettings)
            // Additional: AsyncBatchAnnotateFilesAsync(IEnumerable<AsyncAnnotateFileRequest>,CancellationToken)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<AsyncAnnotateFileRequest> requests = new List<AsyncAnnotateFileRequest>();
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response =
                await imageAnnotatorClient.AsyncBatchAnnotateFilesAsync(requests);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse =
                await imageAnnotatorClient.PollOnceAsyncBatchAnnotateFilesAsync(operationName);
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
            // Snippet: AsyncBatchAnnotateFiles(IEnumerable<AsyncAnnotateFileRequest>,CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            IEnumerable<AsyncAnnotateFileRequest> requests = new List<AsyncAnnotateFileRequest>();
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response =
                imageAnnotatorClient.AsyncBatchAnnotateFiles(requests);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse =
                imageAnnotatorClient.PollOnceAsyncBatchAnnotateFiles(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFilesAsync</summary>
        public async Task AsyncBatchAnnotateFilesAsync_RequestObject()
        {
            // Snippet: AsyncBatchAnnotateFilesAsync(AsyncBatchAnnotateFilesRequest,CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = await ImageAnnotatorClient.CreateAsync();
            // Initialize request argument(s)
            AsyncBatchAnnotateFilesRequest request = new AsyncBatchAnnotateFilesRequest
            {
                Requests = { },
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response =
                await imageAnnotatorClient.AsyncBatchAnnotateFilesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse =
                await imageAnnotatorClient.PollOnceAsyncBatchAnnotateFilesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AsyncBatchAnnotateFilesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AsyncBatchAnnotateFiles</summary>
        public void AsyncBatchAnnotateFiles_RequestObject()
        {
            // Snippet: AsyncBatchAnnotateFiles(AsyncBatchAnnotateFilesRequest,CallSettings)
            // Create client
            ImageAnnotatorClient imageAnnotatorClient = ImageAnnotatorClient.Create();
            // Initialize request argument(s)
            AsyncBatchAnnotateFilesRequest request = new AsyncBatchAnnotateFilesRequest
            {
                Requests = { },
            };
            // Make the request
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> response =
                imageAnnotatorClient.AsyncBatchAnnotateFiles(request);

            // Poll until the returned long-running operation is complete
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AsyncBatchAnnotateFilesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AsyncBatchAnnotateFilesResponse, OperationMetadata> retrievedResponse =
                imageAnnotatorClient.PollOnceAsyncBatchAnnotateFiles(operationName);
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
