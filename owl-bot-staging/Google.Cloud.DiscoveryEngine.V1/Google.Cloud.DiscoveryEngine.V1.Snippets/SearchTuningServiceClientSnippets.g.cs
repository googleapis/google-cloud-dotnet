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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSearchTuningServiceClientSnippets
    {
        /// <summary>Snippet for TrainCustomModel</summary>
        public void TrainCustomModelRequestObject()
        {
            // Snippet: TrainCustomModel(TrainCustomModelRequest, CallSettings)
            // Create client
            SearchTuningServiceClient searchTuningServiceClient = SearchTuningServiceClient.Create();
            // Initialize request argument(s)
            TrainCustomModelRequest request = new TrainCustomModelRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                GcsTrainingInput = new TrainCustomModelRequest.Types.GcsTrainingInput(),
                ModelType = "",
                ErrorConfig = new ImportErrorConfig(),
                ModelId = "",
            };
            // Make the request
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> response = searchTuningServiceClient.TrainCustomModel(request);

            // Poll until the returned long-running operation is complete
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            TrainCustomModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> retrievedResponse = searchTuningServiceClient.PollOnceTrainCustomModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainCustomModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TrainCustomModelAsync</summary>
        public async Task TrainCustomModelRequestObjectAsync()
        {
            // Snippet: TrainCustomModelAsync(TrainCustomModelRequest, CallSettings)
            // Additional: TrainCustomModelAsync(TrainCustomModelRequest, CancellationToken)
            // Create client
            SearchTuningServiceClient searchTuningServiceClient = await SearchTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            TrainCustomModelRequest request = new TrainCustomModelRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                GcsTrainingInput = new TrainCustomModelRequest.Types.GcsTrainingInput(),
                ModelType = "",
                ErrorConfig = new ImportErrorConfig(),
                ModelId = "",
            };
            // Make the request
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> response = await searchTuningServiceClient.TrainCustomModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            TrainCustomModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<TrainCustomModelResponse, TrainCustomModelMetadata> retrievedResponse = await searchTuningServiceClient.PollOnceTrainCustomModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                TrainCustomModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCustomModels</summary>
        public void ListCustomModelsRequestObject()
        {
            // Snippet: ListCustomModels(ListCustomModelsRequest, CallSettings)
            // Create client
            SearchTuningServiceClient searchTuningServiceClient = SearchTuningServiceClient.Create();
            // Initialize request argument(s)
            ListCustomModelsRequest request = new ListCustomModelsRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            ListCustomModelsResponse response = searchTuningServiceClient.ListCustomModels(request);
            // End snippet
        }

        /// <summary>Snippet for ListCustomModelsAsync</summary>
        public async Task ListCustomModelsRequestObjectAsync()
        {
            // Snippet: ListCustomModelsAsync(ListCustomModelsRequest, CallSettings)
            // Additional: ListCustomModelsAsync(ListCustomModelsRequest, CancellationToken)
            // Create client
            SearchTuningServiceClient searchTuningServiceClient = await SearchTuningServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomModelsRequest request = new ListCustomModelsRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
            };
            // Make the request
            ListCustomModelsResponse response = await searchTuningServiceClient.ListCustomModelsAsync(request);
            // End snippet
        }
    }
}
