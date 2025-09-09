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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.CapacityPlanner.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCapacityPlanningServiceClientSnippets
    {
        /// <summary>Snippet for GetCapacityPlan</summary>
        public void GetCapacityPlanRequestObject()
        {
            // Snippet: GetCapacityPlan(GetCapacityPlanRequest, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            GetCapacityPlanRequest request = new GetCapacityPlanRequest
            {
                CapacityPlanName = CapacityPlanName.FromProjectCapacityPlan("[PROJECT]", "[CAPACITY_PLAN]"),
            };
            // Make the request
            CapacityPlan response = capacityPlanningServiceClient.GetCapacityPlan(request);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityPlanAsync</summary>
        public async Task GetCapacityPlanRequestObjectAsync()
        {
            // Snippet: GetCapacityPlanAsync(GetCapacityPlanRequest, CallSettings)
            // Additional: GetCapacityPlanAsync(GetCapacityPlanRequest, CancellationToken)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCapacityPlanRequest request = new GetCapacityPlanRequest
            {
                CapacityPlanName = CapacityPlanName.FromProjectCapacityPlan("[PROJECT]", "[CAPACITY_PLAN]"),
            };
            // Make the request
            CapacityPlan response = await capacityPlanningServiceClient.GetCapacityPlanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityPlan</summary>
        public void GetCapacityPlan()
        {
            // Snippet: GetCapacityPlan(string, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/capacityPlans/[CAPACITY_PLAN]";
            // Make the request
            CapacityPlan response = capacityPlanningServiceClient.GetCapacityPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityPlanAsync</summary>
        public async Task GetCapacityPlanAsync()
        {
            // Snippet: GetCapacityPlanAsync(string, CallSettings)
            // Additional: GetCapacityPlanAsync(string, CancellationToken)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/capacityPlans/[CAPACITY_PLAN]";
            // Make the request
            CapacityPlan response = await capacityPlanningServiceClient.GetCapacityPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityPlan</summary>
        public void GetCapacityPlanResourceNames()
        {
            // Snippet: GetCapacityPlan(CapacityPlanName, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            CapacityPlanName name = CapacityPlanName.FromProjectCapacityPlan("[PROJECT]", "[CAPACITY_PLAN]");
            // Make the request
            CapacityPlan response = capacityPlanningServiceClient.GetCapacityPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetCapacityPlanAsync</summary>
        public async Task GetCapacityPlanResourceNamesAsync()
        {
            // Snippet: GetCapacityPlanAsync(CapacityPlanName, CallSettings)
            // Additional: GetCapacityPlanAsync(CapacityPlanName, CancellationToken)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            CapacityPlanName name = CapacityPlanName.FromProjectCapacityPlan("[PROJECT]", "[CAPACITY_PLAN]");
            // Make the request
            CapacityPlan response = await capacityPlanningServiceClient.GetCapacityPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlans</summary>
        public void QueryCapacityPlansRequestObject()
        {
            // Snippet: QueryCapacityPlans(QueryCapacityPlansRequest, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Location = "",
            };
            // Make the request
            PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlans(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryCapacityPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlansAsync</summary>
        public async Task QueryCapacityPlansRequestObjectAsync()
        {
            // Snippet: QueryCapacityPlansAsync(QueryCapacityPlansRequest, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryCapacityPlansRequest request = new QueryCapacityPlansRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlansAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryCapacityPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlans</summary>
        public void QueryCapacityPlans()
        {
            // Snippet: QueryCapacityPlans(string, string, int?, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryCapacityPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlansAsync</summary>
        public async Task QueryCapacityPlansAsync()
        {
            // Snippet: QueryCapacityPlansAsync(string, string, int?, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryCapacityPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlans</summary>
        public void QueryCapacityPlansResourceNames()
        {
            // Snippet: QueryCapacityPlans(ProjectName, string, int?, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CapacityPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryCapacityPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlansAsync</summary>
        public async Task QueryCapacityPlansResourceNamesAsync()
        {
            // Snippet: QueryCapacityPlansAsync(ProjectName, string, int?, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<QueryCapacityPlansResponse, CapacityPlan> response = capacityPlanningServiceClient.QueryCapacityPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CapacityPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryCapacityPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CapacityPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CapacityPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CapacityPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlanInsights</summary>
        public void QueryCapacityPlanInsightsRequestObject()
        {
            // Snippet: QueryCapacityPlanInsights(QueryCapacityPlanInsightsRequest, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            QueryCapacityPlanInsightsRequest request = new QueryCapacityPlanInsightsRequest
            {
                Parent = "",
                CapacityPlanFilters = new CapacityPlanFilters(),
            };
            // Make the request
            QueryCapacityPlanInsightsResponse response = capacityPlanningServiceClient.QueryCapacityPlanInsights(request);
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlanInsightsAsync</summary>
        public async Task QueryCapacityPlanInsightsRequestObjectAsync()
        {
            // Snippet: QueryCapacityPlanInsightsAsync(QueryCapacityPlanInsightsRequest, CallSettings)
            // Additional: QueryCapacityPlanInsightsAsync(QueryCapacityPlanInsightsRequest, CancellationToken)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryCapacityPlanInsightsRequest request = new QueryCapacityPlanInsightsRequest
            {
                Parent = "",
                CapacityPlanFilters = new CapacityPlanFilters(),
            };
            // Make the request
            QueryCapacityPlanInsightsResponse response = await capacityPlanningServiceClient.QueryCapacityPlanInsightsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlanInsights</summary>
        public void QueryCapacityPlanInsights()
        {
            // Snippet: QueryCapacityPlanInsights(string, CapacityPlanFilters, CallSettings)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = CapacityPlanningServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            CapacityPlanFilters capacityPlanFilters = new CapacityPlanFilters();
            // Make the request
            QueryCapacityPlanInsightsResponse response = capacityPlanningServiceClient.QueryCapacityPlanInsights(parent, capacityPlanFilters);
            // End snippet
        }

        /// <summary>Snippet for QueryCapacityPlanInsightsAsync</summary>
        public async Task QueryCapacityPlanInsightsAsync()
        {
            // Snippet: QueryCapacityPlanInsightsAsync(string, CapacityPlanFilters, CallSettings)
            // Additional: QueryCapacityPlanInsightsAsync(string, CapacityPlanFilters, CancellationToken)
            // Create client
            CapacityPlanningServiceClient capacityPlanningServiceClient = await CapacityPlanningServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            CapacityPlanFilters capacityPlanFilters = new CapacityPlanFilters();
            // Make the request
            QueryCapacityPlanInsightsResponse response = await capacityPlanningServiceClient.QueryCapacityPlanInsightsAsync(parent, capacityPlanFilters);
            // End snippet
        }
    }
}
