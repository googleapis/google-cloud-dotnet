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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDashboardQueryServiceClientSnippets
    {
        /// <summary>Snippet for GetDashboardQuery</summary>
        public void GetDashboardQueryRequestObject()
        {
            // Snippet: GetDashboardQuery(GetDashboardQueryRequest, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            GetDashboardQueryRequest request = new GetDashboardQueryRequest
            {
                DashboardQueryName = DashboardQueryName.FromProjectLocationInstanceQuery("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[QUERY]"),
            };
            // Make the request
            DashboardQuery response = dashboardQueryServiceClient.GetDashboardQuery(request);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardQueryAsync</summary>
        public async Task GetDashboardQueryRequestObjectAsync()
        {
            // Snippet: GetDashboardQueryAsync(GetDashboardQueryRequest, CallSettings)
            // Additional: GetDashboardQueryAsync(GetDashboardQueryRequest, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDashboardQueryRequest request = new GetDashboardQueryRequest
            {
                DashboardQueryName = DashboardQueryName.FromProjectLocationInstanceQuery("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[QUERY]"),
            };
            // Make the request
            DashboardQuery response = await dashboardQueryServiceClient.GetDashboardQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardQuery</summary>
        public void GetDashboardQuery()
        {
            // Snippet: GetDashboardQuery(string, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardQueries/[QUERY]";
            // Make the request
            DashboardQuery response = dashboardQueryServiceClient.GetDashboardQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardQueryAsync</summary>
        public async Task GetDashboardQueryAsync()
        {
            // Snippet: GetDashboardQueryAsync(string, CallSettings)
            // Additional: GetDashboardQueryAsync(string, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dashboardQueries/[QUERY]";
            // Make the request
            DashboardQuery response = await dashboardQueryServiceClient.GetDashboardQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardQuery</summary>
        public void GetDashboardQueryResourceNames()
        {
            // Snippet: GetDashboardQuery(DashboardQueryName, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            DashboardQueryName name = DashboardQueryName.FromProjectLocationInstanceQuery("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[QUERY]");
            // Make the request
            DashboardQuery response = dashboardQueryServiceClient.GetDashboardQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetDashboardQueryAsync</summary>
        public async Task GetDashboardQueryResourceNamesAsync()
        {
            // Snippet: GetDashboardQueryAsync(DashboardQueryName, CallSettings)
            // Additional: GetDashboardQueryAsync(DashboardQueryName, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DashboardQueryName name = DashboardQueryName.FromProjectLocationInstanceQuery("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[QUERY]");
            // Make the request
            DashboardQuery response = await dashboardQueryServiceClient.GetDashboardQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQuery</summary>
        public void ExecuteDashboardQueryRequestObject()
        {
            // Snippet: ExecuteDashboardQuery(ExecuteDashboardQueryRequest, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            ExecuteDashboardQueryRequest request = new ExecuteDashboardQueryRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Query = new DashboardQuery(),
                Filters =
                {
                    new DashboardFilter(),
                },
                ClearCache = false,
                UsePreviousTimeRange = false,
            };
            // Make the request
            ExecuteDashboardQueryResponse response = dashboardQueryServiceClient.ExecuteDashboardQuery(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQueryAsync</summary>
        public async Task ExecuteDashboardQueryRequestObjectAsync()
        {
            // Snippet: ExecuteDashboardQueryAsync(ExecuteDashboardQueryRequest, CallSettings)
            // Additional: ExecuteDashboardQueryAsync(ExecuteDashboardQueryRequest, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteDashboardQueryRequest request = new ExecuteDashboardQueryRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Query = new DashboardQuery(),
                Filters =
                {
                    new DashboardFilter(),
                },
                ClearCache = false,
                UsePreviousTimeRange = false,
            };
            // Make the request
            ExecuteDashboardQueryResponse response = await dashboardQueryServiceClient.ExecuteDashboardQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQuery</summary>
        public void ExecuteDashboardQuery()
        {
            // Snippet: ExecuteDashboardQuery(string, DashboardQuery, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DashboardQuery query = new DashboardQuery();
            // Make the request
            ExecuteDashboardQueryResponse response = dashboardQueryServiceClient.ExecuteDashboardQuery(parent, query);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQueryAsync</summary>
        public async Task ExecuteDashboardQueryAsync()
        {
            // Snippet: ExecuteDashboardQueryAsync(string, DashboardQuery, CallSettings)
            // Additional: ExecuteDashboardQueryAsync(string, DashboardQuery, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DashboardQuery query = new DashboardQuery();
            // Make the request
            ExecuteDashboardQueryResponse response = await dashboardQueryServiceClient.ExecuteDashboardQueryAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQuery</summary>
        public void ExecuteDashboardQueryResourceNames()
        {
            // Snippet: ExecuteDashboardQuery(InstanceName, DashboardQuery, CallSettings)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = DashboardQueryServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DashboardQuery query = new DashboardQuery();
            // Make the request
            ExecuteDashboardQueryResponse response = dashboardQueryServiceClient.ExecuteDashboardQuery(parent, query);
            // End snippet
        }

        /// <summary>Snippet for ExecuteDashboardQueryAsync</summary>
        public async Task ExecuteDashboardQueryResourceNamesAsync()
        {
            // Snippet: ExecuteDashboardQueryAsync(InstanceName, DashboardQuery, CallSettings)
            // Additional: ExecuteDashboardQueryAsync(InstanceName, DashboardQuery, CancellationToken)
            // Create client
            DashboardQueryServiceClient dashboardQueryServiceClient = await DashboardQueryServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DashboardQuery query = new DashboardQuery();
            // Make the request
            ExecuteDashboardQueryResponse response = await dashboardQueryServiceClient.ExecuteDashboardQueryAsync(parent, query);
            // End snippet
        }
    }
}
