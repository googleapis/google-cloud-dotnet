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
    // [START capacityplanner_v1beta_generated_UsageService_QueryUsageHistories_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CapacityPlanner.V1Beta;
    using Google.Type;
    using System.Threading.Tasks;

    public sealed partial class GeneratedUsageServiceClientSnippets
    {
        /// <summary>Snippet for QueryUsageHistoriesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task QueryUsageHistoriesRequestObjectAsync()
        {
            // Create client
            UsageServiceClient usageServiceClient = await UsageServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryUsageHistoriesRequest request = new QueryUsageHistoriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MachineFamily = "",
                CloudResourceType = "",
                UsageAggregationMethod = UsageHistory.Types.AggregationMethod.Unspecified,
                DiskType = "",
                GpuType = "",
                StartDate = new Date(),
                EndDate = new Date(),
                LocationLevel = TimeSeries.Types.LocationType.Unspecified,
                TpuType = "",
                MachineShape = new MachineShape(),
                IsSpot = false,
                ConfidentialMode = false,
            };
            // Make the request
            QueryUsageHistoriesResponse response = await usageServiceClient.QueryUsageHistoriesAsync(request);
        }
    }
    // [END capacityplanner_v1beta_generated_UsageService_QueryUsageHistories_async]
}
