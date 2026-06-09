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
    // [START ces_v1beta_generated_EvaluationService_ExportEvaluationRuns_async]
    using Google.Cloud.Ces.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for ExportEvaluationRunsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExportEvaluationRunsRequestObjectAsync()
        {
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportEvaluationRunsRequest request = new ExportEvaluationRunsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                EvaluationRunNames =
                {
                    EvaluationRunName.FromProjectLocationAppEvaluationRun("[PROJECT]", "[LOCATION]", "[APP]", "[EVALUATION_RUN]"),
                },
                ExportOptions = new ExportOptions(),
            };
            // Make the request
            Operation<ExportEvaluationRunsResponse, ExportEvaluationRunsOperationMetadata> response = await evaluationServiceClient.ExportEvaluationRunsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportEvaluationRunsResponse, ExportEvaluationRunsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEvaluationRunsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEvaluationRunsResponse, ExportEvaluationRunsOperationMetadata> retrievedResponse = await evaluationServiceClient.PollOnceExportEvaluationRunsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEvaluationRunsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END ces_v1beta_generated_EvaluationService_ExportEvaluationRuns_async]
}
