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
    // [START capacityplanner_v1beta_generated_UsageService_ExportUsageHistories_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CapacityPlanner.V1Beta;
    using Google.LongRunning;
    using Google.Type;

    public sealed partial class GeneratedUsageServiceClientSnippets
    {
        /// <summary>Snippet for ExportUsageHistories</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ExportUsageHistoriesRequestObject()
        {
            // Create client
            UsageServiceClient usageServiceClient = UsageServiceClient.Create();
            // Initialize request argument(s)
            ExportUsageHistoriesRequest request = new ExportUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                DiskType = "",
                ResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                GpuType = "",
                TpuType = "",
                IsSpot = false,
                MachineShape = new MachineShape(),
            };
            // Make the request
            Operation<ExportUsageHistoriesResponse, OperationMetadata> response = usageServiceClient.ExportUsageHistories(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportUsageHistoriesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportUsageHistoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportUsageHistoriesResponse, OperationMetadata> retrievedResponse = usageServiceClient.PollOnceExportUsageHistories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportUsageHistoriesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END capacityplanner_v1beta_generated_UsageService_ExportUsageHistories_sync]
}
