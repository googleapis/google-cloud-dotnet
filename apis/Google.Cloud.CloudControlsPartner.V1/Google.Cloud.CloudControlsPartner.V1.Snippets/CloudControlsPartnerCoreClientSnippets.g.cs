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
    using Google.Cloud.CloudControlsPartner.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudControlsPartnerCoreClientSnippets
    {
        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadRequestObject()
        {
            // Snippet: GetWorkload(GetWorkloadRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = cloudControlsPartnerCoreClient.GetWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadRequestObjectAsync()
        {
            // Snippet: GetWorkloadAsync(GetWorkloadRequest, CallSettings)
            // Additional: GetWorkloadAsync(GetWorkloadRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = await cloudControlsPartnerCoreClient.GetWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkload()
        {
            // Snippet: GetWorkload(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = cloudControlsPartnerCoreClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadAsync()
        {
            // Snippet: GetWorkloadAsync(string, CallSettings)
            // Additional: GetWorkloadAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = await cloudControlsPartnerCoreClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadResourceNames()
        {
            // Snippet: GetWorkload(WorkloadName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            Workload response = cloudControlsPartnerCoreClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadResourceNamesAsync()
        {
            // Snippet: GetWorkloadAsync(WorkloadName, CallSettings)
            // Additional: GetWorkloadAsync(WorkloadName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            Workload response = await cloudControlsPartnerCoreClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsRequestObject()
        {
            // Snippet: ListWorkloads(ListWorkloadsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsCustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloads(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsRequestObjectAsync()
        {
            // Snippet: ListWorkloadsAsync(ListWorkloadsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsCustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloadsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloads()
        {
            // Snippet: ListWorkloads(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsAsync()
        {
            // Snippet: ListWorkloadsAsync(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsResourceNames()
        {
            // Snippet: ListWorkloads(CustomerName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            CustomerName parent = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsResourceNamesAsync()
        {
            // Snippet: ListWorkloadsAsync(CustomerName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName parent = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = cloudControlsPartnerCoreClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerRequestObject()
        {
            // Snippet: GetCustomer(GetCustomerRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
            };
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.GetCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerRequestObjectAsync()
        {
            // Snippet: GetCustomerAsync(GetCustomerRequest, CallSettings)
            // Additional: GetCustomerAsync(GetCustomerRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomerRequest request = new GetCustomerRequest
            {
                CustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
            };
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.GetCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomer()
        {
            // Snippet: GetCustomer(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.GetCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerAsync()
        {
            // Snippet: GetCustomerAsync(string, CallSettings)
            // Additional: GetCustomerAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.GetCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomer</summary>
        public void GetCustomerResourceNames()
        {
            // Snippet: GetCustomer(CustomerName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.GetCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomerAsync</summary>
        public async Task GetCustomerResourceNamesAsync()
        {
            // Snippet: GetCustomerAsync(CustomerName, CallSettings)
            // Additional: GetCustomerAsync(CustomerName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.GetCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomers</summary>
        public void ListCustomersRequestObject()
        {
            // Snippet: ListCustomers(ListCustomersRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            ListCustomersRequest request = new ListCustomersRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Customer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomersAsync</summary>
        public async Task ListCustomersRequestObjectAsync()
        {
            // Snippet: ListCustomersAsync(ListCustomersRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomersRequest request = new ListCustomersRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Customer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomers</summary>
        public void ListCustomers()
        {
            // Snippet: ListCustomers(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Customer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomersAsync</summary>
        public async Task ListCustomersAsync()
        {
            // Snippet: ListCustomersAsync(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Customer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomers</summary>
        public void ListCustomersResourceNames()
        {
            // Snippet: ListCustomers(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Customer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomersAsync</summary>
        public async Task ListCustomersResourceNamesAsync()
        {
            // Snippet: ListCustomersAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCustomersResponse, Customer> response = cloudControlsPartnerCoreClient.ListCustomersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Customer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Customer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Customer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Customer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnections</summary>
        public void GetEkmConnectionsRequestObject()
        {
            // Snippet: GetEkmConnections(GetEkmConnectionsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            GetEkmConnectionsRequest request = new GetEkmConnectionsRequest
            {
                EkmConnectionsName = EkmConnectionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            EkmConnections response = cloudControlsPartnerCoreClient.GetEkmConnections(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionsAsync</summary>
        public async Task GetEkmConnectionsRequestObjectAsync()
        {
            // Snippet: GetEkmConnectionsAsync(GetEkmConnectionsRequest, CallSettings)
            // Additional: GetEkmConnectionsAsync(GetEkmConnectionsRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            GetEkmConnectionsRequest request = new GetEkmConnectionsRequest
            {
                EkmConnectionsName = EkmConnectionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            EkmConnections response = await cloudControlsPartnerCoreClient.GetEkmConnectionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnections</summary>
        public void GetEkmConnections()
        {
            // Snippet: GetEkmConnections(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/ekmConnections";
            // Make the request
            EkmConnections response = cloudControlsPartnerCoreClient.GetEkmConnections(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionsAsync</summary>
        public async Task GetEkmConnectionsAsync()
        {
            // Snippet: GetEkmConnectionsAsync(string, CallSettings)
            // Additional: GetEkmConnectionsAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/ekmConnections";
            // Make the request
            EkmConnections response = await cloudControlsPartnerCoreClient.GetEkmConnectionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnections</summary>
        public void GetEkmConnectionsResourceNames()
        {
            // Snippet: GetEkmConnections(EkmConnectionsName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            EkmConnectionsName name = EkmConnectionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            EkmConnections response = cloudControlsPartnerCoreClient.GetEkmConnections(name);
            // End snippet
        }

        /// <summary>Snippet for GetEkmConnectionsAsync</summary>
        public async Task GetEkmConnectionsResourceNamesAsync()
        {
            // Snippet: GetEkmConnectionsAsync(EkmConnectionsName, CallSettings)
            // Additional: GetEkmConnectionsAsync(EkmConnectionsName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            EkmConnectionsName name = EkmConnectionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            EkmConnections response = await cloudControlsPartnerCoreClient.GetEkmConnectionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissions</summary>
        public void GetPartnerPermissionsRequestObject()
        {
            // Snippet: GetPartnerPermissions(GetPartnerPermissionsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            GetPartnerPermissionsRequest request = new GetPartnerPermissionsRequest
            {
                PartnerPermissionsName = PartnerPermissionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            PartnerPermissions response = cloudControlsPartnerCoreClient.GetPartnerPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissionsAsync</summary>
        public async Task GetPartnerPermissionsRequestObjectAsync()
        {
            // Snippet: GetPartnerPermissionsAsync(GetPartnerPermissionsRequest, CallSettings)
            // Additional: GetPartnerPermissionsAsync(GetPartnerPermissionsRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            GetPartnerPermissionsRequest request = new GetPartnerPermissionsRequest
            {
                PartnerPermissionsName = PartnerPermissionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
            };
            // Make the request
            PartnerPermissions response = await cloudControlsPartnerCoreClient.GetPartnerPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissions</summary>
        public void GetPartnerPermissions()
        {
            // Snippet: GetPartnerPermissions(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/partnerPermissions";
            // Make the request
            PartnerPermissions response = cloudControlsPartnerCoreClient.GetPartnerPermissions(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissionsAsync</summary>
        public async Task GetPartnerPermissionsAsync()
        {
            // Snippet: GetPartnerPermissionsAsync(string, CallSettings)
            // Additional: GetPartnerPermissionsAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]/partnerPermissions";
            // Make the request
            PartnerPermissions response = await cloudControlsPartnerCoreClient.GetPartnerPermissionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissions</summary>
        public void GetPartnerPermissionsResourceNames()
        {
            // Snippet: GetPartnerPermissions(PartnerPermissionsName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            PartnerPermissionsName name = PartnerPermissionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            PartnerPermissions response = cloudControlsPartnerCoreClient.GetPartnerPermissions(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerPermissionsAsync</summary>
        public async Task GetPartnerPermissionsResourceNamesAsync()
        {
            // Snippet: GetPartnerPermissionsAsync(PartnerPermissionsName, CallSettings)
            // Additional: GetPartnerPermissionsAsync(PartnerPermissionsName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            PartnerPermissionsName name = PartnerPermissionsName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
            PartnerPermissions response = await cloudControlsPartnerCoreClient.GetPartnerPermissionsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequests</summary>
        public void ListAccessApprovalRequestsRequestObject()
        {
            // Snippet: ListAccessApprovalRequests(ListAccessApprovalRequestsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequests(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequestsAsync</summary>
        public async Task ListAccessApprovalRequestsRequestObjectAsync()
        {
            // Snippet: ListAccessApprovalRequestsAsync(ListAccessApprovalRequestsRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessApprovalRequestsRequest request = new ListAccessApprovalRequestsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequestsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequests</summary>
        public void ListAccessApprovalRequests()
        {
            // Snippet: ListAccessApprovalRequests(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequests(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequestsAsync</summary>
        public async Task ListAccessApprovalRequestsAsync()
        {
            // Snippet: ListAccessApprovalRequestsAsync(string, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]/workloads/[WORKLOAD]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequestsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequests</summary>
        public void ListAccessApprovalRequestsResourceNames()
        {
            // Snippet: ListAccessApprovalRequests(WorkloadName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequests(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessApprovalRequestsAsync</summary>
        public async Task ListAccessApprovalRequestsResourceNamesAsync()
        {
            // Snippet: ListAccessApprovalRequestsAsync(WorkloadName, string, int?, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationCustomerWorkload("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]", "[WORKLOAD]");
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAccessApprovalRequestsResponse, AccessApprovalRequest> response = cloudControlsPartnerCoreClient.ListAccessApprovalRequestsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPartner</summary>
        public void GetPartnerRequestObject()
        {
            // Snippet: GetPartner(GetPartnerRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            GetPartnerRequest request = new GetPartnerRequest
            {
                PartnerName = PartnerName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            Partner response = cloudControlsPartnerCoreClient.GetPartner(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerRequestObjectAsync()
        {
            // Snippet: GetPartnerAsync(GetPartnerRequest, CallSettings)
            // Additional: GetPartnerAsync(GetPartnerRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            GetPartnerRequest request = new GetPartnerRequest
            {
                PartnerName = PartnerName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            Partner response = await cloudControlsPartnerCoreClient.GetPartnerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPartner</summary>
        public void GetPartner()
        {
            // Snippet: GetPartner(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/partner";
            // Make the request
            Partner response = cloudControlsPartnerCoreClient.GetPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerAsync()
        {
            // Snippet: GetPartnerAsync(string, CallSettings)
            // Additional: GetPartnerAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/partner";
            // Make the request
            Partner response = await cloudControlsPartnerCoreClient.GetPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartner</summary>
        public void GetPartnerResourceNames()
        {
            // Snippet: GetPartner(PartnerName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            PartnerName name = PartnerName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            Partner response = cloudControlsPartnerCoreClient.GetPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetPartnerAsync</summary>
        public async Task GetPartnerResourceNamesAsync()
        {
            // Snippet: GetPartnerAsync(PartnerName, CallSettings)
            // Additional: GetPartnerAsync(PartnerName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            PartnerName name = PartnerName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            Partner response = await cloudControlsPartnerCoreClient.GetPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomer</summary>
        public void CreateCustomerRequestObject()
        {
            // Snippet: CreateCustomer(CreateCustomerRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Customer = new Customer(),
                CustomerId = "",
            };
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.CreateCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerAsync</summary>
        public async Task CreateCustomerRequestObjectAsync()
        {
            // Snippet: CreateCustomerAsync(CreateCustomerRequest, CallSettings)
            // Additional: CreateCustomerAsync(CreateCustomerRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomerRequest request = new CreateCustomerRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Customer = new Customer(),
                CustomerId = "",
            };
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.CreateCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomer</summary>
        public void CreateCustomer()
        {
            // Snippet: CreateCustomer(string, Customer, string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Customer customer = new Customer();
            string customerId = "";
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.CreateCustomer(parent, customer, customerId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerAsync</summary>
        public async Task CreateCustomerAsync()
        {
            // Snippet: CreateCustomerAsync(string, Customer, string, CallSettings)
            // Additional: CreateCustomerAsync(string, Customer, string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Customer customer = new Customer();
            string customerId = "";
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.CreateCustomerAsync(parent, customer, customerId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomer</summary>
        public void CreateCustomerResourceNames()
        {
            // Snippet: CreateCustomer(OrganizationLocationName, Customer, string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Customer customer = new Customer();
            string customerId = "";
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.CreateCustomer(parent, customer, customerId);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomerAsync</summary>
        public async Task CreateCustomerResourceNamesAsync()
        {
            // Snippet: CreateCustomerAsync(OrganizationLocationName, Customer, string, CallSettings)
            // Additional: CreateCustomerAsync(OrganizationLocationName, Customer, string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Customer customer = new Customer();
            string customerId = "";
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.CreateCustomerAsync(parent, customer, customerId);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomer</summary>
        public void UpdateCustomerRequestObject()
        {
            // Snippet: UpdateCustomer(UpdateCustomerRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.UpdateCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomerAsync</summary>
        public async Task UpdateCustomerRequestObjectAsync()
        {
            // Snippet: UpdateCustomerAsync(UpdateCustomerRequest, CallSettings)
            // Additional: UpdateCustomerAsync(UpdateCustomerRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomerRequest request = new UpdateCustomerRequest
            {
                Customer = new Customer(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.UpdateCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomer</summary>
        public void UpdateCustomer()
        {
            // Snippet: UpdateCustomer(Customer, FieldMask, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            Customer customer = new Customer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Customer response = cloudControlsPartnerCoreClient.UpdateCustomer(customer, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomerAsync</summary>
        public async Task UpdateCustomerAsync()
        {
            // Snippet: UpdateCustomerAsync(Customer, FieldMask, CallSettings)
            // Additional: UpdateCustomerAsync(Customer, FieldMask, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            Customer customer = new Customer();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Customer response = await cloudControlsPartnerCoreClient.UpdateCustomerAsync(customer, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomerRequestObject()
        {
            // Snippet: DeleteCustomer(DeleteCustomerRequest, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
            };
            // Make the request
            cloudControlsPartnerCoreClient.DeleteCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerRequestObjectAsync()
        {
            // Snippet: DeleteCustomerAsync(DeleteCustomerRequest, CallSettings)
            // Additional: DeleteCustomerAsync(DeleteCustomerRequest, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomerRequest request = new DeleteCustomerRequest
            {
                CustomerName = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]"),
            };
            // Make the request
            await cloudControlsPartnerCoreClient.DeleteCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomer()
        {
            // Snippet: DeleteCustomer(string, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            cloudControlsPartnerCoreClient.DeleteCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerAsync()
        {
            // Snippet: DeleteCustomerAsync(string, CallSettings)
            // Additional: DeleteCustomerAsync(string, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/customers/[CUSTOMER]";
            // Make the request
            await cloudControlsPartnerCoreClient.DeleteCustomerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomer</summary>
        public void DeleteCustomerResourceNames()
        {
            // Snippet: DeleteCustomer(CustomerName, CallSettings)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = CloudControlsPartnerCoreClient.Create();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            cloudControlsPartnerCoreClient.DeleteCustomer(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomerAsync</summary>
        public async Task DeleteCustomerResourceNamesAsync()
        {
            // Snippet: DeleteCustomerAsync(CustomerName, CallSettings)
            // Additional: DeleteCustomerAsync(CustomerName, CancellationToken)
            // Create client
            CloudControlsPartnerCoreClient cloudControlsPartnerCoreClient = await CloudControlsPartnerCoreClient.CreateAsync();
            // Initialize request argument(s)
            CustomerName name = CustomerName.FromOrganizationLocationCustomer("[ORGANIZATION]", "[LOCATION]", "[CUSTOMER]");
            // Make the request
            await cloudControlsPartnerCoreClient.DeleteCustomerAsync(name);
            // End snippet
        }
    }
}
