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
    using Google.Cloud.Chronicle.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDashboardChartServiceClientSnippets
    {
        /// <summary>Snippet for GetDashboardChart</summary>
        public void GetDashboardChartRequestObject()
        {
            // Snippet: GetDashboardChart(GetDashboardChartRequest, CallSettings)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            GetDashboardChartRequest request = new GetDashboardChartRequest
            {
                DashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            DashboardChart response = dashboardChartServiceClient.GetDashboardChart(request);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardChartAsync</summary>
        public async Task GetDashboardChartRequestObjectAsync()
        {
            // Snippet: GetDashboardChartAsync(GetDashboardChartRequest, CallSettings)
            // Additional: GetDashboardChartAsync(GetDashboardChartRequest, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDashboardChartRequest request = new GetDashboardChartRequest
            {
                DashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            DashboardChart response = await dashboardChartServiceClient.GetDashboardChartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardChart</summary>
        public void GetDashboardChart()
        {
            // Snippet: GetDashboardChart(string, CallSettings)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardCharts/[CHART]";
            // Make the request
            DashboardChart response = dashboardChartServiceClient.GetDashboardChart(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardChartAsync</summary>
        public async Task GetDashboardChartAsync()
        {
            // Snippet: GetDashboardChartAsync(string, CallSettings)
            // Additional: GetDashboardChartAsync(string, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardCharts/[CHART]";
            // Make the request
            DashboardChart response = await dashboardChartServiceClient.GetDashboardChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardChart</summary>
        public void GetDashboardChartResourceNames()
        {
            // Snippet: GetDashboardChart(DashboardChartName, CallSettings)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            DashboardChartName name = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]");
            // Make the request
            DashboardChart response = dashboardChartServiceClient.GetDashboardChart(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardChartAsync</summary>
        public async Task GetDashboardChartResourceNamesAsync()
        {
            // Snippet: GetDashboardChartAsync(DashboardChartName, CallSettings)
            // Additional: GetDashboardChartAsync(DashboardChartName, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            DashboardChartName name = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]");
            // Make the request
            DashboardChart response = await dashboardChartServiceClient.GetDashboardChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardCharts</summary>
        public void BatchGetDashboardChartsRequestObject()
        {
            // Snippet: BatchGetDashboardCharts(BatchGetDashboardChartsRequest, CallSettings)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            BatchGetDashboardChartsRequest request = new BatchGetDashboardChartsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DashboardChartNames =
                {
                    DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
                },
            };
            // Make the request
            BatchGetDashboardChartsResponse response = dashboardChartServiceClient.BatchGetDashboardCharts(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardChartsAsync</summary>
        public async Task BatchGetDashboardChartsRequestObjectAsync()
        {
            // Snippet: BatchGetDashboardChartsAsync(BatchGetDashboardChartsRequest, CallSettings)
            // Additional: BatchGetDashboardChartsAsync(BatchGetDashboardChartsRequest, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetDashboardChartsRequest request = new BatchGetDashboardChartsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DashboardChartNames =
                {
                    DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
                },
            };
            // Make the request
            BatchGetDashboardChartsResponse response = await dashboardChartServiceClient.BatchGetDashboardChartsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardCharts</summary>
        public void BatchGetDashboardCharts()
        {
            // Snippet: BatchGetDashboardCharts(string, IEnumerable<string>, CallSettings)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = DashboardChartServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardCharts/[CHART]",
            };
            // Make the request
            BatchGetDashboardChartsResponse response = dashboardChartServiceClient.BatchGetDashboardCharts(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardChartsAsync</summary>
        public async Task BatchGetDashboardChartsAsync()
        {
            // Snippet: BatchGetDashboardChartsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchGetDashboardChartsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            IEnumerable<string> names = new string[]
            {
                "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardCharts/[CHART]",
            };
            // Make the request
            BatchGetDashboardChartsResponse response = await dashboardChartServiceClient.BatchGetDashboardChartsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardCharts</summary>
        public void BatchGetDashboardChartsResourceNames()
        {
            // Snippet: BatchGetDashboardCharts(InstanceName, IEnumerable<DashboardChartName>, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for BatchGetDashboardChartsAsync</summary>
        public async Task BatchGetDashboardChartsResourceNamesAsync()
        {
            // Snippet: BatchGetDashboardChartsAsync(InstanceName, IEnumerable<DashboardChartName>, CallSettings)
            // Additional: BatchGetDashboardChartsAsync(InstanceName, IEnumerable<DashboardChartName>, CancellationToken)
            // Create client
            DashboardChartServiceClient dashboardChartServiceClient = await DashboardChartServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            IEnumerable<DashboardChartName> names = new DashboardChartName[]
            {
                DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            BatchGetDashboardChartsResponse response = await dashboardChartServiceClient.BatchGetDashboardChartsAsync(parent, names);
            // End snippet
        }
    }
}
