
namespace Google.Cloud.Vision.V1
{
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedImageAnnotatorSnippets
    {
        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImages_RequestObject()
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
            };
            // Make the request
            BatchAnnotateImagesResponse response = imageAnnotatorClient.BatchAnnotateImages(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImagesAsync</summary>
        public async Task BatchAnnotateImagesAsync_RequestObject()
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
            };
            // Make the request
            BatchAnnotateImagesResponse response = await imageAnnotatorClient.BatchAnnotateImagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchAnnotateImages</summary>
        public void BatchAnnotateImages()
        {
            // Snippet: BatchAnnotateImages(IEnumerable, CallSettings)
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
            // Snippet: BatchAnnotateImagesAsync(IEnumerable, CallSettings)
            // Additional: BatchAnnotateImagesAsync(IEnumerable, CancellationToken)
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

        /// <summary>Snippet for AsyncBatchAnnotateFiles</summary>
        public void AsyncBatchAnnotateFiles_RequestObject()
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
        public async Task AsyncBatchAnnotateFilesAsync_RequestObject()
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
            // Snippet: AsyncBatchAnnotateFiles(IEnumerable, CallSettings)
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
            // Snippet: AsyncBatchAnnotateFilesAsync(IEnumerable, CallSettings)
            // Additional: AsyncBatchAnnotateFilesAsync(IEnumerable, CancellationToken)
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
