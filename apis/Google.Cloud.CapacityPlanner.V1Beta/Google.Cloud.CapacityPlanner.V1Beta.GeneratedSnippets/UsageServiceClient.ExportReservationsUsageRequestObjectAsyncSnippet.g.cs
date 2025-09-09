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
    // [START capacityplanner_v1beta_generated_UsageService_ExportReservationsUsage_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CapacityPlanner.V1Beta;
    using Google.LongRunning;
    using Google.Type;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUsageServiceClientSnippets
    {
        /// <summary>Snippet for ExportReservationsUsageAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExportReservationsUsageRequestObjectAsync()
        {
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportReservationsUsageRequest request = new ExportReservationsUsageRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                ShareType = ExportReservationsUsageRequest.Types.ShareType.Unspecified,
                StartDate = new Date(),
                EndDate = new Date(),
                OutputConfig = new OutputConfig(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
            };
            // Make the request
            Operation<ExportReservationsUsageResponse, OperationMetadata> response = await usageServiceClient.ExportReservationsUsageAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportReservationsUsageResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportReservationsUsageResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportReservationsUsageResponse, OperationMetadata> retrievedResponse = await usageServiceClient.PollOnceExportReservationsUsageAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportReservationsUsageResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END capacityplanner_v1beta_generated_UsageService_ExportReservationsUsage_async]
}
