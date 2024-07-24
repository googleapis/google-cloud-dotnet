// Copyright 2024 Google LLC
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
    using Google.Cloud.CloudControlsPartner.V1;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudControlsPartnerMonitoringClientSnippets
    {
        /// <summary>Snippet for ListViolations</summary>
        public void ListViolationsRequestObject()
        {
            // Snippet: ListViolations(ListViolationsRequest, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
                Filter = "",
                OrderBy = "",
                Interval = new Interval(),
            };
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsRequestObjectAsync()
        {
            // Snippet: ListViolationsAsync(ListViolationsRequest, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
                Filter = "",
                OrderBy = "",
                Interval = new Interval(),
            };
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolations</summary>
        public void ListViolations()
        {
            // Snippet: ListViolations(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsAsync()
        {
            // Snippet: ListViolationsAsync(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolations</summary>
        public void ListViolationsResourceNames()
        {
            // Snippet: ListViolations(WorkloadName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsResourceNamesAsync()
        {
            // Snippet: ListViolationsAsync(WorkloadName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = cloudControlsPartnerMonitoringClient.ListViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolationRequestObject()
        {
            // Snippet: GetViolation(GetViolationRequest, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationCustomerWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]", "[VIOLATION]"),
            };
            // Make the request
            Violation response = cloudControlsPartnerMonitoringClient.GetViolation(request);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationRequestObjectAsync()
        {
            // Snippet: GetViolationAsync(GetViolationRequest, CallSettings)
            // Additional: GetViolationAsync(GetViolationRequest, CancellationToken)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationCustomerWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]", "[VIOLATION]"),
            };
            // Make the request
            Violation response = await cloudControlsPartnerMonitoringClient.GetViolationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolation()
        {
            // Snippet: GetViolation(string, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/violations/[VIOLATION]";
            // Make the request
            Violation response = cloudControlsPartnerMonitoringClient.GetViolation(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationAsync()
        {
            // Snippet: GetViolationAsync(string, CallSettings)
            // Additional: GetViolationAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/violations/[VIOLATION]";
            // Make the request
            Violation response = await cloudControlsPartnerMonitoringClient.GetViolationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolationResourceNames()
        {
            // Snippet: GetViolation(ViolationName, CallSettings)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = CloudControlsPartnerMonitoringClient.Create();
            // Initialize request argument(s)
            ViolationName name = ViolationName.FromOrganizationLocationCustomerWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]", "[VIOLATION]");
            // Make the request
            Violation response = cloudControlsPartnerMonitoringClient.GetViolation(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationResourceNamesAsync()
        {
            // Snippet: GetViolationAsync(ViolationName, CallSettings)
            // Additional: GetViolationAsync(ViolationName, CancellationToken)
            // Create client
            CloudControlsPartnerMonitoringClient cloudControlsPartnerMonitoringClient = await CloudControlsPartnerMonitoringClient.CreateAsync();
            // Initialize request argument(s)
            ViolationName name = ViolationName.FromOrganizationLocationCustomerWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]", "[VIOLATION]");
            // Make the request
            Violation response = await cloudControlsPartnerMonitoringClient.GetViolationAsync(name);
            // End snippet
        }
    }
}
