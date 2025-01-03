// Copyright 2025 Google LLC
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
    using Google.Cloud.AutoML.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for Predict</summary>
        public void PredictRequestObject()
        {
            // Snippet: Predict(PredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
                Params = { { "", "" }, },
            };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(request);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictRequestObjectAsync()
        {
            // Snippet: PredictAsync(PredictRequest, CallSettings)
            // Additional: PredictAsync(PredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
                Params = { { "", "" }, },
            };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void Predict()
        {
            // Snippet: Predict(string, ExamplePayload, IDictionary<string,string>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictAsync()
        {
            // Snippet: PredictAsync(string, ExamplePayload, IDictionary<string,string>, CallSettings)
            // Additional: PredictAsync(string, ExamplePayload, IDictionary<string,string>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for Predict</summary>
        public void PredictResourceNames()
        {
            // Snippet: Predict(ModelName, ExamplePayload, IDictionary<string,string>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            PredictResponse response = predictionServiceClient.Predict(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for PredictAsync</summary>
        public async Task PredictResourceNamesAsync()
        {
            // Snippet: PredictAsync(ModelName, ExamplePayload, IDictionary<string,string>, CallSettings)
            // Additional: PredictAsync(ModelName, ExamplePayload, IDictionary<string,string>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            PredictResponse response = await predictionServiceClient.PredictAsync(name, payload, @params);
            // End snippet
        }

        /// <summary>Snippet for BatchPredict</summary>
        public void BatchPredictRequestObject()
        {
            // Snippet: BatchPredict(BatchPredictRequest, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            BatchPredictRequest request = new BatchPredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictInputConfig(),
                OutputConfig = new BatchPredictOutputConfig(),
                Params = { { "", "" }, },
            };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = predictionServiceClient.BatchPredict(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = predictionServiceClient.PollOnceBatchPredict(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchPredictAsync</summary>
        public async Task BatchPredictRequestObjectAsync()
        {
            // Snippet: BatchPredictAsync(BatchPredictRequest, CallSettings)
            // Additional: BatchPredictAsync(BatchPredictRequest, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPredictRequest request = new BatchPredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                InputConfig = new BatchPredictInputConfig(),
                OutputConfig = new BatchPredictOutputConfig(),
                Params = { { "", "" }, },
            };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = await predictionServiceClient.BatchPredictAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = await predictionServiceClient.PollOnceBatchPredictAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchPredict</summary>
        public void BatchPredict()
        {
            // Snippet: BatchPredict(string, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = predictionServiceClient.BatchPredict(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = predictionServiceClient.PollOnceBatchPredict(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchPredictAsync</summary>
        public async Task BatchPredictAsync()
        {
            // Snippet: BatchPredictAsync(string, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CallSettings)
            // Additional: BatchPredictAsync(string, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/models/[MODEL]";
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = await predictionServiceClient.BatchPredictAsync(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = await predictionServiceClient.PollOnceBatchPredictAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchPredict</summary>
        public void BatchPredictResourceNames()
        {
            // Snippet: BatchPredict(ModelName, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CallSettings)
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = predictionServiceClient.BatchPredict(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = predictionServiceClient.PollOnceBatchPredict(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchPredictAsync</summary>
        public async Task BatchPredictResourceNamesAsync()
        {
            // Snippet: BatchPredictAsync(ModelName, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CallSettings)
            // Additional: BatchPredictAsync(ModelName, BatchPredictInputConfig, BatchPredictOutputConfig, IDictionary<string,string>, CancellationToken)
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]");
            BatchPredictInputConfig inputConfig = new BatchPredictInputConfig();
            BatchPredictOutputConfig outputConfig = new BatchPredictOutputConfig();
            IDictionary<string, string> @params = new Dictionary<string, string> { { "", "" }, };
            // Make the request
            Operation<BatchPredictResult, OperationMetadata> response = await predictionServiceClient.BatchPredictAsync(name, inputConfig, outputConfig, @params);

            // Poll until the returned long-running operation is complete
            Operation<BatchPredictResult, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchPredictResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchPredictResult, OperationMetadata> retrievedResponse = await predictionServiceClient.PollOnceBatchPredictAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchPredictResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
