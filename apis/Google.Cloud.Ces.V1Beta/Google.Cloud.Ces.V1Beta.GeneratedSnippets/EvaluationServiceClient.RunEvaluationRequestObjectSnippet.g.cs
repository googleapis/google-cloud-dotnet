// Copyright 2026 Google LLC
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
    // [START ces_v1beta_generated_EvaluationService_RunEvaluation_sync]
    using Google.Cloud.Ces.V1Beta;
    using Google.LongRunning;

    public sealed partial class GeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for RunEvaluation</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RunEvaluationRequestObject()
        {
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            RunEvaluationRequest request = new RunEvaluationRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationsAsEvaluationNames =
                {
                    EvaluationName.FromProjectLocationAppEvaluation("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION]"),
                },
                EvaluationDatasetAsEvaluationDatasetName = EvaluationDatasetName.FromProjectLocationAppEvaluationDataset("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_DATASET]"),
                DisplayName = "",
                AppVersionAsAppVersionName = AppVersionName.FromProjectLocationAppVersion("[PROJECT]", "[LOCATION]", "[APP]", "[VERSION]"),
                Config = new EvaluationConfig(),
                RunCount = 0,
                PersonaRunConfigs =
                {
                    new PersonaRunConfig(),
                },
                OptimizationConfig = new OptimizationConfig(),
                ScheduledEvaluationRunAsScheduledEvaluationRunName = ScheduledEvaluationRunName.FromProjectLocationAppScheduledEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[SCHEDULED_EVALUATION_RUN]"),
                GoldenRunMethod = GoldenRunMethod.Unspecified,
                GenerateLatencyReport = false,
            };
            // Make the request
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> response = evaluationServiceClient.RunEvaluation(request);

            // Poll until the returned long-running operation is complete
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunEvaluationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> retrievedResponse = evaluationServiceClient.PollOnceRunEvaluation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunEvaluationResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END ces_v1beta_generated_EvaluationService_RunEvaluation_sync]
}
