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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for EvaluateInstances</summary>
        public void EvaluateInstancesRequestObject()
        {
            // Snippet: EvaluateInstances(EvaluateInstancesRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluateInstancesRequest request = new EvaluateInstancesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExactMatchInput = new ExactMatchInput(),
                AutoraterConfig = new AutoraterConfig(),
            };
            // Make the request
            EvaluateInstancesResponse response = evaluationServiceClient.EvaluateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for EvaluateInstancesAsync</summary>
        public async Task EvaluateInstancesRequestObjectAsync()
        {
            // Snippet: EvaluateInstancesAsync(EvaluateInstancesRequest, CallSettings)
            // Additional: EvaluateInstancesAsync(EvaluateInstancesRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluateInstancesRequest request = new EvaluateInstancesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExactMatchInput = new ExactMatchInput(),
                AutoraterConfig = new AutoraterConfig(),
            };
            // Make the request
            EvaluateInstancesResponse response = await evaluationServiceClient.EvaluateInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EvaluateDataset</summary>
        public void EvaluateDatasetRequestObject()
        {
            // Snippet: EvaluateDataset(EvaluateDatasetRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluateDatasetRequest request = new EvaluateDatasetRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new EvaluationDataset(),
                Metrics = { new Metric(), },
                OutputConfig = new OutputConfig(),
                AutoraterConfig = new AutoraterConfig(),
            };
            // Make the request
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> response = evaluationServiceClient.EvaluateDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EvaluateDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceEvaluateDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for EvaluateDatasetAsync</summary>
        public async Task EvaluateDatasetRequestObjectAsync()
        {
            // Snippet: EvaluateDatasetAsync(EvaluateDatasetRequest, CallSettings)
            // Additional: EvaluateDatasetAsync(EvaluateDatasetRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluateDatasetRequest request = new EvaluateDatasetRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Dataset = new EvaluationDataset(),
                Metrics = { new Metric(), },
                OutputConfig = new OutputConfig(),
                AutoraterConfig = new AutoraterConfig(),
            };
            // Make the request
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> response = await evaluationServiceClient.EvaluateDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EvaluateDatasetResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EvaluateDatasetResponse, EvaluateDatasetOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceEvaluateDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EvaluateDatasetResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
