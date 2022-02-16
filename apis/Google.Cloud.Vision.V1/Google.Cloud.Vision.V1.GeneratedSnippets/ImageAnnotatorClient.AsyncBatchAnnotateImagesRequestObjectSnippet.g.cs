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

namespace Google.Cloud.Vision.V1.Snippets
{
    // [START vision_v1_generated_ImageAnnotator_AsyncBatchAnnotateImages_sync]
    using Google.Cloud.Vision.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedImageAnnotatorClientSnippets
    {
        /// <summary>Snippet for AsyncBatchAnnotateImages</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void AsyncBatchAnnotateImagesRequestObject()
        {
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
        }
    }
    // [END vision_v1_generated_ImageAnnotator_AsyncBatchAnnotateImages_sync]
}
