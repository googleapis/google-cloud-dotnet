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
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAnalyticsServiceClientSnippets
    {
        /// <summary>Snippet for ExportAnalyticsMetrics</summary>
        public void ExportAnalyticsMetricsRequestObject()
        {
            // Snippet: ExportAnalyticsMetrics(ExportAnalyticsMetricsRequest, CallSettings)
            // Create client
            AnalyticsServiceClient analyticsServiceClient = AnalyticsServiceClient.Create();
            // Initialize request argument(s)
            ExportAnalyticsMetricsRequest request = new ExportAnalyticsMetricsRequest
            {
                Catalog = "",
                OutputConfig = new OutputConfig(),
                Filter = "",
            };
            // Make the request
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> response = analyticsServiceClient.ExportAnalyticsMetrics(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAnalyticsMetricsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> retrievedResponse = analyticsServiceClient.PollOnceExportAnalyticsMetrics(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAnalyticsMetricsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAnalyticsMetricsAsync</summary>
        public async Task ExportAnalyticsMetricsRequestObjectAsync()
        {
            // Snippet: ExportAnalyticsMetricsAsync(ExportAnalyticsMetricsRequest, CallSettings)
            // Additional: ExportAnalyticsMetricsAsync(ExportAnalyticsMetricsRequest, CancellationToken)
            // Create client
            AnalyticsServiceClient analyticsServiceClient = await AnalyticsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportAnalyticsMetricsRequest request = new ExportAnalyticsMetricsRequest
            {
                Catalog = "",
                OutputConfig = new OutputConfig(),
                Filter = "",
            };
            // Make the request
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> response = await analyticsServiceClient.ExportAnalyticsMetricsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAnalyticsMetricsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAnalyticsMetricsResponse, ExportMetadata> retrievedResponse = await analyticsServiceClient.PollOnceExportAnalyticsMetricsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAnalyticsMetricsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
