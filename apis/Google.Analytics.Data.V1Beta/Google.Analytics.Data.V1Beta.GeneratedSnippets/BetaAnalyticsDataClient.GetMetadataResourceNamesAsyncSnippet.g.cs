// Copyright 2022 Google LLC
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

namespace Google.Analytics.Data.V1Beta.Snippets
{
    // [START analyticsdata_v1beta_generated_BetaAnalyticsData_GetMetadata_async_flattened_resourceNames]
    using Google.Analytics.Data.V1Beta;
    using System.Threading.Tasks;

    public sealed partial class GeneratedBetaAnalyticsDataClientSnippets
    {
        /// <summary>Snippet for GetMetadataAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetMetadataResourceNamesAsync()
        {
            // Create client
            BetaAnalyticsDataClient betaAnalyticsDataClient = await BetaAnalyticsDataClient.CreateAsync();
            // Initialize request argument(s)
            MetadataName name = MetadataName.FromProperty("[PROPERTY]");
            // Make the request
            Metadata response = await betaAnalyticsDataClient.GetMetadataAsync(name);
        }
    }
    // [END analyticsdata_v1beta_generated_BetaAnalyticsData_GetMetadata_async_flattened_resourceNames]
}
