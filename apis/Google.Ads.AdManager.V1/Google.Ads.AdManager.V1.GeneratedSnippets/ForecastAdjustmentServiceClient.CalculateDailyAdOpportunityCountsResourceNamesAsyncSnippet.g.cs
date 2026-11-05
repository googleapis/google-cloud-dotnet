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
    // [START admanager_v1_generated_ForecastAdjustmentService_CalculateDailyAdOpportunityCounts_async_flattened_resourceNames]
    using Google.Ads.AdManager.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedForecastAdjustmentServiceClientSnippets
    {
        /// <summary>Snippet for CalculateDailyAdOpportunityCountsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CalculateDailyAdOpportunityCountsResourceNamesAsync()
        {
            // Create client
            ForecastAdjustmentServiceClient forecastAdjustmentServiceClient = await ForecastAdjustmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ForecastAdjustment forecastAdjustment = new ForecastAdjustment();
            // Make the request
            CalculateDailyAdOpportunityCountsResponse response = await forecastAdjustmentServiceClient.CalculateDailyAdOpportunityCountsAsync(parent, forecastAdjustment);
        }
    }
    // [END admanager_v1_generated_ForecastAdjustmentService_CalculateDailyAdOpportunityCounts_async_flattened_resourceNames]
}
