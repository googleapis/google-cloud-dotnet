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
    // [START chronicle_v1_generated_DashboardChartService_BatchGetDashboardCharts_sync_flattened_resourceNames]
    using Google.Cloud.Chronicle.V1;
    using System.Collections.Generic;

    public sealed partial class GeneratedDashboardChartServiceClientSnippets
    {
        /// <summary>Snippet for BatchGetDashboardCharts</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void BatchGetDashboardChartsResourceNames()
        {
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            IEnumerable<DashboardChartName> names = new DashboardChartName[]
            {
                DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            BatchGetDashboardChartsResponse response = dashboardChartServiceClient.BatchGetDashboardCharts(parent, names);
        }
    }
    // [END chronicle_v1_generated_DashboardChartService_BatchGetDashboardCharts_sync_flattened_resourceNames]
}
