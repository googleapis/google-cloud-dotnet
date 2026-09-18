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
    using Google.Ads.MarketingPlatform.Admin.V1Alpha;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMarketingplatformAdminServiceClientSnippets
    {
        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationRequestObject()
        {
            // Snippet: GetOrganization(GetOrganizationRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            GetOrganizationRequest request = new GetOrganizationRequest
            {
                OrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Organization response = marketingplatformAdminServiceClient.GetOrganization(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationRequestObjectAsync()
        {
            // Snippet: GetOrganizationAsync(GetOrganizationRequest, CallSettings)
            // Additional: GetOrganizationAsync(GetOrganizationRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationRequest request = new GetOrganizationRequest
            {
                OrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganization()
        {
            // Snippet: GetOrganization(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            Organization response = marketingplatformAdminServiceClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationAsync()
        {
            // Snippet: GetOrganizationAsync(string, CallSettings)
            // Additional: GetOrganizationAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationResourceNames()
        {
            // Snippet: GetOrganization(OrganizationName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Organization response = marketingplatformAdminServiceClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationResourceNamesAsync()
        {
            // Snippet: GetOrganizationAsync(OrganizationName, CallSettings)
            // Additional: GetOrganizationAsync(OrganizationName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOrganizations</summary>
        public void ListOrganizationsRequestObject()
        {
            // Snippet: ListOrganizations(ListOrganizationsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ListOrganizationsRequest request = new ListOrganizationsRequest { };
            // Make the request
            PagedEnumerable<ListOrganizationsResponse, Organization> response = marketingplatformAdminServiceClient.ListOrganizations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Organization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrganizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrganizationsAsync</summary>
        public async Task ListOrganizationsRequestObjectAsync()
        {
            // Snippet: ListOrganizationsAsync(ListOrganizationsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrganizationsRequest request = new ListOrganizationsRequest { };
            // Make the request
            PagedAsyncEnumerable<ListOrganizationsResponse, Organization> response = marketingplatformAdminServiceClient.ListOrganizationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Organization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOrganizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FindSalesPartnerManagedClients</summary>
        public void FindSalesPartnerManagedClientsRequestObject()
        {
            // Snippet: FindSalesPartnerManagedClients(FindSalesPartnerManagedClientsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            FindSalesPartnerManagedClientsRequest request = new FindSalesPartnerManagedClientsRequest
            {
                OrganizationAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                IsActive = false,
            };
            // Make the request
            FindSalesPartnerManagedClientsResponse response = marketingplatformAdminServiceClient.FindSalesPartnerManagedClients(request);
            // End snippet
        }

        /// <summary>Snippet for FindSalesPartnerManagedClientsAsync</summary>
        public async Task FindSalesPartnerManagedClientsRequestObjectAsync()
        {
            // Snippet: FindSalesPartnerManagedClientsAsync(FindSalesPartnerManagedClientsRequest, CallSettings)
            // Additional: FindSalesPartnerManagedClientsAsync(FindSalesPartnerManagedClientsRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindSalesPartnerManagedClientsRequest request = new FindSalesPartnerManagedClientsRequest
            {
                OrganizationAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                IsActive = false,
            };
            // Make the request
            FindSalesPartnerManagedClientsResponse response = await marketingplatformAdminServiceClient.FindSalesPartnerManagedClientsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinksRequestObject()
        {
            // Snippet: ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinksAsync</summary>
        public async Task ListAnalyticsAccountLinksRequestObjectAsync()
        {
            // Snippet: ListAnalyticsAccountLinksAsync(ListAnalyticsAccountLinksRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAnalyticsAccountLinksRequest request = new ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinks()
        {
            // Snippet: ListAnalyticsAccountLinks(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinksAsync</summary>
        public async Task ListAnalyticsAccountLinksAsync()
        {
            // Snippet: ListAnalyticsAccountLinksAsync(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinksResourceNames()
        {
            // Snippet: ListAnalyticsAccountLinks(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinksAsync</summary>
        public async Task ListAnalyticsAccountLinksResourceNamesAsync()
        {
            // Snippet: ListAnalyticsAccountLinksAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListAnalyticsAccountLinksResponse, AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLinkRequestObject()
        {
            // Snippet: CreateAnalyticsAccountLink(CreateAnalyticsAccountLinkRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateAnalyticsAccountLinkRequest request = new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AnalyticsAccountLink = new AnalyticsAccountLink(),
            };
            // Make the request
            AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkRequestObjectAsync()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnalyticsAccountLinkRequest request = new CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AnalyticsAccountLink = new AnalyticsAccountLink(),
            };
            // Make the request
            AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLink()
        {
            // Snippet: CreateAnalyticsAccountLink(string, AnalyticsAccountLink, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            AnalyticsAccountLink analyticsAccountLink = new AnalyticsAccountLink();
            // Make the request
            AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkAsync()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(string, AnalyticsAccountLink, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(string, AnalyticsAccountLink, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            AnalyticsAccountLink analyticsAccountLink = new AnalyticsAccountLink();
            // Make the request
            AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLinkResourceNames()
        {
            // Snippet: CreateAnalyticsAccountLink(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            AnalyticsAccountLink analyticsAccountLink = new AnalyticsAccountLink();
            // Make the request
            AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkResourceNamesAsync()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            AnalyticsAccountLink analyticsAccountLink = new AnalyticsAccountLink();
            // Make the request
            AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLink</summary>
        public void DeleteAnalyticsAccountLinkRequestObject()
        {
            // Snippet: DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteAnalyticsAccountLinkRequest request = new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]"),
            };
            // Make the request
            marketingplatformAdminServiceClient.DeleteAnalyticsAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLinkAsync</summary>
        public async Task DeleteAnalyticsAccountLinkRequestObjectAsync()
        {
            // Snippet: DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest, CallSettings)
            // Additional: DeleteAnalyticsAccountLinkAsync(DeleteAnalyticsAccountLinkRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAnalyticsAccountLinkRequest request = new DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]"),
            };
            // Make the request
            await marketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLink</summary>
        public void DeleteAnalyticsAccountLink()
        {
            // Snippet: DeleteAnalyticsAccountLink(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/analyticsAccountLinks/[ANALYTICS_ACCOUNT_LINK]";
            // Make the request
            marketingplatformAdminServiceClient.DeleteAnalyticsAccountLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLinkAsync</summary>
        public async Task DeleteAnalyticsAccountLinkAsync()
        {
            // Snippet: DeleteAnalyticsAccountLinkAsync(string, CallSettings)
            // Additional: DeleteAnalyticsAccountLinkAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/analyticsAccountLinks/[ANALYTICS_ACCOUNT_LINK]";
            // Make the request
            await marketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLink</summary>
        public void DeleteAnalyticsAccountLinkResourceNames()
        {
            // Snippet: DeleteAnalyticsAccountLink(AnalyticsAccountLinkName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            AnalyticsAccountLinkName name = AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]");
            // Make the request
            marketingplatformAdminServiceClient.DeleteAnalyticsAccountLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLinkAsync</summary>
        public async Task DeleteAnalyticsAccountLinkResourceNamesAsync()
        {
            // Snippet: DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName, CallSettings)
            // Additional: DeleteAnalyticsAccountLinkAsync(AnalyticsAccountLinkName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyticsAccountLinkName name = AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]");
            // Make the request
            await marketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevel</summary>
        public void SetPropertyServiceLevelRequestObject()
        {
            // Snippet: SetPropertyServiceLevel(SetPropertyServiceLevelRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            SetPropertyServiceLevelRequest request = new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = "",
                AnalyticsPropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ServiceLevel = AnalyticsServiceLevel.Unspecified,
            };
            // Make the request
            SetPropertyServiceLevelResponse response = marketingplatformAdminServiceClient.SetPropertyServiceLevel(request);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevelAsync</summary>
        public async Task SetPropertyServiceLevelRequestObjectAsync()
        {
            // Snippet: SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest, CallSettings)
            // Additional: SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetPropertyServiceLevelRequest request = new SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = "",
                AnalyticsPropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ServiceLevel = AnalyticsServiceLevel.Unspecified,
            };
            // Make the request
            SetPropertyServiceLevelResponse response = await marketingplatformAdminServiceClient.SetPropertyServiceLevelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevel</summary>
        public void SetPropertyServiceLevel()
        {
            // Snippet: SetPropertyServiceLevel(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string analyticsAccountLink = "";
            // Make the request
            SetPropertyServiceLevelResponse response = marketingplatformAdminServiceClient.SetPropertyServiceLevel(analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevelAsync</summary>
        public async Task SetPropertyServiceLevelAsync()
        {
            // Snippet: SetPropertyServiceLevelAsync(string, CallSettings)
            // Additional: SetPropertyServiceLevelAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string analyticsAccountLink = "";
            // Make the request
            SetPropertyServiceLevelResponse response = await marketingplatformAdminServiceClient.SetPropertyServiceLevelAsync(analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for ReportPropertyUsage</summary>
        public void ReportPropertyUsageRequestObject()
        {
            // Snippet: ReportPropertyUsage(ReportPropertyUsageRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ReportPropertyUsageRequest request = new ReportPropertyUsageRequest
            {
                Organization = "",
                Month = "",
            };
            // Make the request
            ReportPropertyUsageResponse response = marketingplatformAdminServiceClient.ReportPropertyUsage(request);
            // End snippet
        }

        /// <summary>Snippet for ReportPropertyUsageAsync</summary>
        public async Task ReportPropertyUsageRequestObjectAsync()
        {
            // Snippet: ReportPropertyUsageAsync(ReportPropertyUsageRequest, CallSettings)
            // Additional: ReportPropertyUsageAsync(ReportPropertyUsageRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportPropertyUsageRequest request = new ReportPropertyUsageRequest
            {
                Organization = "",
                Month = "",
            };
            // Make the request
            ReportPropertyUsageResponse response = await marketingplatformAdminServiceClient.ReportPropertyUsageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReportPropertyUsage</summary>
        public void ReportPropertyUsage()
        {
            // Snippet: ReportPropertyUsage(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string organization = "";
            // Make the request
            ReportPropertyUsageResponse response = marketingplatformAdminServiceClient.ReportPropertyUsage(organization);
            // End snippet
        }

        /// <summary>Snippet for ReportPropertyUsageAsync</summary>
        public async Task ReportPropertyUsageAsync()
        {
            // Snippet: ReportPropertyUsageAsync(string, CallSettings)
            // Additional: ReportPropertyUsageAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string organization = "";
            // Make the request
            ReportPropertyUsageResponse response = await marketingplatformAdminServiceClient.ReportPropertyUsageAsync(organization);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroup</summary>
        public void GetUserGroupRequestObject()
        {
            // Snippet: GetUserGroup(GetUserGroupRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            GetUserGroupRequest request = new GetUserGroupRequest
            {
                UserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.GetUserGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupAsync</summary>
        public async Task GetUserGroupRequestObjectAsync()
        {
            // Snippet: GetUserGroupAsync(GetUserGroupRequest, CallSettings)
            // Additional: GetUserGroupAsync(GetUserGroupRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserGroupRequest request = new GetUserGroupRequest
            {
                UserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.GetUserGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroup</summary>
        public void GetUserGroup()
        {
            // Snippet: GetUserGroup(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.GetUserGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupAsync</summary>
        public async Task GetUserGroupAsync()
        {
            // Snippet: GetUserGroupAsync(string, CallSettings)
            // Additional: GetUserGroupAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.GetUserGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroup</summary>
        public void GetUserGroupResourceNames()
        {
            // Snippet: GetUserGroup(UserGroupName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupName name = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.GetUserGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupAsync</summary>
        public async Task GetUserGroupResourceNamesAsync()
        {
            // Snippet: GetUserGroupAsync(UserGroupName, CallSettings)
            // Additional: GetUserGroupAsync(UserGroupName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupName name = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.GetUserGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserGroups</summary>
        public void ListUserGroupsRequestObject()
        {
            // Snippet: ListUserGroups(ListUserGroupsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ListUserGroupsRequest request = new ListUserGroupsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupsAsync</summary>
        public async Task ListUserGroupsRequestObjectAsync()
        {
            // Snippet: ListUserGroupsAsync(ListUserGroupsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserGroupsRequest request = new ListUserGroupsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroups</summary>
        public void ListUserGroups()
        {
            // Snippet: ListUserGroups(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupsAsync</summary>
        public async Task ListUserGroupsAsync()
        {
            // Snippet: ListUserGroupsAsync(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroups</summary>
        public void ListUserGroupsResourceNames()
        {
            // Snippet: ListUserGroups(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupsAsync</summary>
        public async Task ListUserGroupsResourceNamesAsync()
        {
            // Snippet: ListUserGroupsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListUserGroupsResponse, UserGroup> response = marketingplatformAdminServiceClient.ListUserGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroup</summary>
        public void CreateUserGroupRequestObject()
        {
            // Snippet: CreateUserGroup(CreateUserGroupRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateUserGroupRequest request = new CreateUserGroupRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                UserGroup = new UserGroup(),
            };
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.CreateUserGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupAsync</summary>
        public async Task CreateUserGroupRequestObjectAsync()
        {
            // Snippet: CreateUserGroupAsync(CreateUserGroupRequest, CallSettings)
            // Additional: CreateUserGroupAsync(CreateUserGroupRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserGroupRequest request = new CreateUserGroupRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                UserGroup = new UserGroup(),
            };
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.CreateUserGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroup</summary>
        public void CreateUserGroup()
        {
            // Snippet: CreateUserGroup(string, UserGroup, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            UserGroup userGroup = new UserGroup();
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.CreateUserGroup(parent, userGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupAsync</summary>
        public async Task CreateUserGroupAsync()
        {
            // Snippet: CreateUserGroupAsync(string, UserGroup, CallSettings)
            // Additional: CreateUserGroupAsync(string, UserGroup, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            UserGroup userGroup = new UserGroup();
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.CreateUserGroupAsync(parent, userGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroup</summary>
        public void CreateUserGroupResourceNames()
        {
            // Snippet: CreateUserGroup(OrganizationName, UserGroup, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            UserGroup userGroup = new UserGroup();
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.CreateUserGroup(parent, userGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupAsync</summary>
        public async Task CreateUserGroupResourceNamesAsync()
        {
            // Snippet: CreateUserGroupAsync(OrganizationName, UserGroup, CallSettings)
            // Additional: CreateUserGroupAsync(OrganizationName, UserGroup, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            UserGroup userGroup = new UserGroup();
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.CreateUserGroupAsync(parent, userGroup);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroup</summary>
        public void UpdateUserGroupRequestObject()
        {
            // Snippet: UpdateUserGroup(UpdateUserGroupRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserGroupRequest request = new UpdateUserGroupRequest
            {
                UserGroup = new UserGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.UpdateUserGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupAsync</summary>
        public async Task UpdateUserGroupRequestObjectAsync()
        {
            // Snippet: UpdateUserGroupAsync(UpdateUserGroupRequest, CallSettings)
            // Additional: UpdateUserGroupAsync(UpdateUserGroupRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserGroupRequest request = new UpdateUserGroupRequest
            {
                UserGroup = new UserGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.UpdateUserGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroup</summary>
        public void UpdateUserGroup()
        {
            // Snippet: UpdateUserGroup(UserGroup, FieldMask, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroup userGroup = new UserGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserGroup response = marketingplatformAdminServiceClient.UpdateUserGroup(userGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupAsync</summary>
        public async Task UpdateUserGroupAsync()
        {
            // Snippet: UpdateUserGroupAsync(UserGroup, FieldMask, CallSettings)
            // Additional: UpdateUserGroupAsync(UserGroup, FieldMask, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroup userGroup = new UserGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserGroup response = await marketingplatformAdminServiceClient.UpdateUserGroupAsync(userGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroup</summary>
        public void DeleteUserGroupRequestObject()
        {
            // Snippet: DeleteUserGroup(DeleteUserGroupRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteUserGroupRequest request = new DeleteUserGroupRequest
            {
                UserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupAsync</summary>
        public async Task DeleteUserGroupRequestObjectAsync()
        {
            // Snippet: DeleteUserGroupAsync(DeleteUserGroupRequest, CallSettings)
            // Additional: DeleteUserGroupAsync(DeleteUserGroupRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserGroupRequest request = new DeleteUserGroupRequest
            {
                UserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroup</summary>
        public void DeleteUserGroup()
        {
            // Snippet: DeleteUserGroup(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupAsync</summary>
        public async Task DeleteUserGroupAsync()
        {
            // Snippet: DeleteUserGroupAsync(string, CallSettings)
            // Additional: DeleteUserGroupAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroup</summary>
        public void DeleteUserGroupResourceNames()
        {
            // Snippet: DeleteUserGroup(UserGroupName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupName name = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupAsync</summary>
        public async Task DeleteUserGroupResourceNamesAsync()
        {
            // Snippet: DeleteUserGroupAsync(UserGroupName, CallSettings)
            // Additional: DeleteUserGroupAsync(UserGroupName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupName name = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMember</summary>
        public void GetUserGroupMemberRequestObject()
        {
            // Snippet: GetUserGroupMember(GetUserGroupMemberRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            GetUserGroupMemberRequest request = new GetUserGroupMemberRequest
            {
                UserGroupMemberName = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]"),
            };
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.GetUserGroupMember(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMemberAsync</summary>
        public async Task GetUserGroupMemberRequestObjectAsync()
        {
            // Snippet: GetUserGroupMemberAsync(GetUserGroupMemberRequest, CallSettings)
            // Additional: GetUserGroupMemberAsync(GetUserGroupMemberRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserGroupMemberRequest request = new GetUserGroupMemberRequest
            {
                UserGroupMemberName = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]"),
            };
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.GetUserGroupMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMember</summary>
        public void GetUserGroupMember()
        {
            // Snippet: GetUserGroupMember(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]/members/[MEMBER]";
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.GetUserGroupMember(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMemberAsync</summary>
        public async Task GetUserGroupMemberAsync()
        {
            // Snippet: GetUserGroupMemberAsync(string, CallSettings)
            // Additional: GetUserGroupMemberAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]/members/[MEMBER]";
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.GetUserGroupMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMember</summary>
        public void GetUserGroupMemberResourceNames()
        {
            // Snippet: GetUserGroupMember(UserGroupMemberName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupMemberName name = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]");
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.GetUserGroupMember(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserGroupMemberAsync</summary>
        public async Task GetUserGroupMemberResourceNamesAsync()
        {
            // Snippet: GetUserGroupMemberAsync(UserGroupMemberName, CallSettings)
            // Additional: GetUserGroupMemberAsync(UserGroupMemberName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupMemberName name = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]");
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.GetUserGroupMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembers</summary>
        public void ListUserGroupMembersRequestObject()
        {
            // Snippet: ListUserGroupMembers(ListUserGroupMembersRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
            {
                ParentAsUserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembersAsync</summary>
        public async Task ListUserGroupMembersRequestObjectAsync()
        {
            // Snippet: ListUserGroupMembersAsync(ListUserGroupMembersRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserGroupMembersRequest request = new ListUserGroupMembersRequest
            {
                ParentAsUserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembers</summary>
        public void ListUserGroupMembers()
        {
            // Snippet: ListUserGroupMembers(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembersAsync</summary>
        public async Task ListUserGroupMembersAsync()
        {
            // Snippet: ListUserGroupMembersAsync(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembers</summary>
        public void ListUserGroupMembersResourceNames()
        {
            // Snippet: ListUserGroupMembers(UserGroupName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupName parent = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            PagedEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserGroupMembersAsync</summary>
        public async Task ListUserGroupMembersResourceNamesAsync()
        {
            // Snippet: ListUserGroupMembersAsync(UserGroupName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupName parent = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListUserGroupMembersResponse, UserGroupMember> response = marketingplatformAdminServiceClient.ListUserGroupMembersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserGroupMember item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserGroupMember item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserGroupMember> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserGroupMember item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMember</summary>
        public void CreateUserGroupMemberRequestObject()
        {
            // Snippet: CreateUserGroupMember(CreateUserGroupMemberRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateUserGroupMemberRequest request = new CreateUserGroupMemberRequest
            {
                ParentAsUserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
                UserGroupMember = new UserGroupMember(),
            };
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.CreateUserGroupMember(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMemberAsync</summary>
        public async Task CreateUserGroupMemberRequestObjectAsync()
        {
            // Snippet: CreateUserGroupMemberAsync(CreateUserGroupMemberRequest, CallSettings)
            // Additional: CreateUserGroupMemberAsync(CreateUserGroupMemberRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserGroupMemberRequest request = new CreateUserGroupMemberRequest
            {
                ParentAsUserGroupName = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]"),
                UserGroupMember = new UserGroupMember(),
            };
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.CreateUserGroupMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMember</summary>
        public void CreateUserGroupMember()
        {
            // Snippet: CreateUserGroupMember(string, UserGroupMember, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            UserGroupMember userGroupMember = new UserGroupMember();
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.CreateUserGroupMember(parent, userGroupMember);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMemberAsync</summary>
        public async Task CreateUserGroupMemberAsync()
        {
            // Snippet: CreateUserGroupMemberAsync(string, UserGroupMember, CallSettings)
            // Additional: CreateUserGroupMemberAsync(string, UserGroupMember, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]";
            UserGroupMember userGroupMember = new UserGroupMember();
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.CreateUserGroupMemberAsync(parent, userGroupMember);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMember</summary>
        public void CreateUserGroupMemberResourceNames()
        {
            // Snippet: CreateUserGroupMember(UserGroupName, UserGroupMember, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupName parent = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            UserGroupMember userGroupMember = new UserGroupMember();
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.CreateUserGroupMember(parent, userGroupMember);
            // End snippet
        }

        /// <summary>Snippet for CreateUserGroupMemberAsync</summary>
        public async Task CreateUserGroupMemberResourceNamesAsync()
        {
            // Snippet: CreateUserGroupMemberAsync(UserGroupName, UserGroupMember, CallSettings)
            // Additional: CreateUserGroupMemberAsync(UserGroupName, UserGroupMember, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupName parent = UserGroupName.FromOrganizationUserGroup("[ORGANIZATION]", "[USER_GROUP]");
            UserGroupMember userGroupMember = new UserGroupMember();
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.CreateUserGroupMemberAsync(parent, userGroupMember);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupMember</summary>
        public void UpdateUserGroupMemberRequestObject()
        {
            // Snippet: UpdateUserGroupMember(UpdateUserGroupMemberRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserGroupMemberRequest request = new UpdateUserGroupMemberRequest
            {
                UserGroupMember = new UserGroupMember(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.UpdateUserGroupMember(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupMemberAsync</summary>
        public async Task UpdateUserGroupMemberRequestObjectAsync()
        {
            // Snippet: UpdateUserGroupMemberAsync(UpdateUserGroupMemberRequest, CallSettings)
            // Additional: UpdateUserGroupMemberAsync(UpdateUserGroupMemberRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserGroupMemberRequest request = new UpdateUserGroupMemberRequest
            {
                UserGroupMember = new UserGroupMember(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.UpdateUserGroupMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupMember</summary>
        public void UpdateUserGroupMember()
        {
            // Snippet: UpdateUserGroupMember(UserGroupMember, FieldMask, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupMember userGroupMember = new UserGroupMember();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserGroupMember response = marketingplatformAdminServiceClient.UpdateUserGroupMember(userGroupMember, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserGroupMemberAsync</summary>
        public async Task UpdateUserGroupMemberAsync()
        {
            // Snippet: UpdateUserGroupMemberAsync(UserGroupMember, FieldMask, CallSettings)
            // Additional: UpdateUserGroupMemberAsync(UserGroupMember, FieldMask, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupMember userGroupMember = new UserGroupMember();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserGroupMember response = await marketingplatformAdminServiceClient.UpdateUserGroupMemberAsync(userGroupMember, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMember</summary>
        public void DeleteUserGroupMemberRequestObject()
        {
            // Snippet: DeleteUserGroupMember(DeleteUserGroupMemberRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteUserGroupMemberRequest request = new DeleteUserGroupMemberRequest
            {
                UserGroupMemberName = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]"),
            };
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroupMember(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMemberAsync</summary>
        public async Task DeleteUserGroupMemberRequestObjectAsync()
        {
            // Snippet: DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest, CallSettings)
            // Additional: DeleteUserGroupMemberAsync(DeleteUserGroupMemberRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserGroupMemberRequest request = new DeleteUserGroupMemberRequest
            {
                UserGroupMemberName = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]"),
            };
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupMemberAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMember</summary>
        public void DeleteUserGroupMember()
        {
            // Snippet: DeleteUserGroupMember(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]/members/[MEMBER]";
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroupMember(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMemberAsync</summary>
        public async Task DeleteUserGroupMemberAsync()
        {
            // Snippet: DeleteUserGroupMemberAsync(string, CallSettings)
            // Additional: DeleteUserGroupMemberAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/userGroups/[USER_GROUP]/members/[MEMBER]";
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMember</summary>
        public void DeleteUserGroupMemberResourceNames()
        {
            // Snippet: DeleteUserGroupMember(UserGroupMemberName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UserGroupMemberName name = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]");
            // Make the request
            marketingplatformAdminServiceClient.DeleteUserGroupMember(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserGroupMemberAsync</summary>
        public async Task DeleteUserGroupMemberResourceNamesAsync()
        {
            // Snippet: DeleteUserGroupMemberAsync(UserGroupMemberName, CallSettings)
            // Additional: DeleteUserGroupMemberAsync(UserGroupMemberName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserGroupMemberName name = UserGroupMemberName.FromOrganizationUserGroupMember("[ORGANIZATION]", "[USER_GROUP]", "[MEMBER]");
            // Make the request
            await marketingplatformAdminServiceClient.DeleteUserGroupMemberAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBinding</summary>
        public void GetAdminAccessBindingRequestObject()
        {
            // Snippet: GetAdminAccessBinding(GetAdminAccessBindingRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAdminAccessBindingRequest request = new GetAdminAccessBindingRequest
            {
                AdminAccessBindingName = AdminAccessBindingName.FromOrganizationAdminAccessBinding("[ORGANIZATION]", "[ADMIN_ACCESS_BINDING]"),
            };
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.GetAdminAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBindingAsync</summary>
        public async Task GetAdminAccessBindingRequestObjectAsync()
        {
            // Snippet: GetAdminAccessBindingAsync(GetAdminAccessBindingRequest, CallSettings)
            // Additional: GetAdminAccessBindingAsync(GetAdminAccessBindingRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdminAccessBindingRequest request = new GetAdminAccessBindingRequest
            {
                AdminAccessBindingName = AdminAccessBindingName.FromOrganizationAdminAccessBinding("[ORGANIZATION]", "[ADMIN_ACCESS_BINDING]"),
            };
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.GetAdminAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBinding</summary>
        public void GetAdminAccessBinding()
        {
            // Snippet: GetAdminAccessBinding(string, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/adminAccessBindings/[ADMIN_ACCESS_BINDING]";
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.GetAdminAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBindingAsync</summary>
        public async Task GetAdminAccessBindingAsync()
        {
            // Snippet: GetAdminAccessBindingAsync(string, CallSettings)
            // Additional: GetAdminAccessBindingAsync(string, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/adminAccessBindings/[ADMIN_ACCESS_BINDING]";
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.GetAdminAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBinding</summary>
        public void GetAdminAccessBindingResourceNames()
        {
            // Snippet: GetAdminAccessBinding(AdminAccessBindingName, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            AdminAccessBindingName name = AdminAccessBindingName.FromOrganizationAdminAccessBinding("[ORGANIZATION]", "[ADMIN_ACCESS_BINDING]");
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.GetAdminAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdminAccessBindingAsync</summary>
        public async Task GetAdminAccessBindingResourceNamesAsync()
        {
            // Snippet: GetAdminAccessBindingAsync(AdminAccessBindingName, CallSettings)
            // Additional: GetAdminAccessBindingAsync(AdminAccessBindingName, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdminAccessBindingName name = AdminAccessBindingName.FromOrganizationAdminAccessBinding("[ORGANIZATION]", "[ADMIN_ACCESS_BINDING]");
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.GetAdminAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindings</summary>
        public void ListAdminAccessBindingsRequestObject()
        {
            // Snippet: ListAdminAccessBindings(ListAdminAccessBindingsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindingsAsync</summary>
        public async Task ListAdminAccessBindingsRequestObjectAsync()
        {
            // Snippet: ListAdminAccessBindingsAsync(ListAdminAccessBindingsRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdminAccessBindingsRequest request = new ListAdminAccessBindingsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindings</summary>
        public void ListAdminAccessBindings()
        {
            // Snippet: ListAdminAccessBindings(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindingsAsync</summary>
        public async Task ListAdminAccessBindingsAsync()
        {
            // Snippet: ListAdminAccessBindingsAsync(string, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindings</summary>
        public void ListAdminAccessBindingsResourceNames()
        {
            // Snippet: ListAdminAccessBindings(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdminAccessBindingsAsync</summary>
        public async Task ListAdminAccessBindingsResourceNamesAsync()
        {
            // Snippet: ListAdminAccessBindingsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListAdminAccessBindingsResponse, AdminAccessBinding> response = marketingplatformAdminServiceClient.ListAdminAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdminAccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdminAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdminAccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdminAccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdminAccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBinding</summary>
        public void CreateAdminAccessBindingRequestObject()
        {
            // Snippet: CreateAdminAccessBinding(CreateAdminAccessBindingRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateAdminAccessBindingRequest request = new CreateAdminAccessBindingRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AdminAccessBinding = new AdminAccessBinding(),
            };
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.CreateAdminAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBindingAsync</summary>
        public async Task CreateAdminAccessBindingRequestObjectAsync()
        {
            // Snippet: CreateAdminAccessBindingAsync(CreateAdminAccessBindingRequest, CallSettings)
            // Additional: CreateAdminAccessBindingAsync(CreateAdminAccessBindingRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdminAccessBindingRequest request = new CreateAdminAccessBindingRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AdminAccessBinding = new AdminAccessBinding(),
            };
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.CreateAdminAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBinding</summary>
        public void CreateAdminAccessBinding()
        {
            // Snippet: CreateAdminAccessBinding(string, AdminAccessBinding, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.CreateAdminAccessBinding(parent, adminAccessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBindingAsync</summary>
        public async Task CreateAdminAccessBindingAsync()
        {
            // Snippet: CreateAdminAccessBindingAsync(string, AdminAccessBinding, CallSettings)
            // Additional: CreateAdminAccessBindingAsync(string, AdminAccessBinding, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.CreateAdminAccessBindingAsync(parent, adminAccessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBinding</summary>
        public void CreateAdminAccessBindingResourceNames()
        {
            // Snippet: CreateAdminAccessBinding(OrganizationName, AdminAccessBinding, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.CreateAdminAccessBinding(parent, adminAccessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAdminAccessBindingAsync</summary>
        public async Task CreateAdminAccessBindingResourceNamesAsync()
        {
            // Snippet: CreateAdminAccessBindingAsync(OrganizationName, AdminAccessBinding, CallSettings)
            // Additional: CreateAdminAccessBindingAsync(OrganizationName, AdminAccessBinding, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.CreateAdminAccessBindingAsync(parent, adminAccessBinding);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminAccessBinding</summary>
        public void UpdateAdminAccessBindingRequestObject()
        {
            // Snippet: UpdateAdminAccessBinding(UpdateAdminAccessBindingRequest, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAdminAccessBindingRequest request = new UpdateAdminAccessBindingRequest
            {
                AdminAccessBinding = new AdminAccessBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.UpdateAdminAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminAccessBindingAsync</summary>
        public async Task UpdateAdminAccessBindingRequestObjectAsync()
        {
            // Snippet: UpdateAdminAccessBindingAsync(UpdateAdminAccessBindingRequest, CallSettings)
            // Additional: UpdateAdminAccessBindingAsync(UpdateAdminAccessBindingRequest, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdminAccessBindingRequest request = new UpdateAdminAccessBindingRequest
            {
                AdminAccessBinding = new AdminAccessBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.UpdateAdminAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminAccessBinding</summary>
        public void UpdateAdminAccessBinding()
        {
            // Snippet: UpdateAdminAccessBinding(AdminAccessBinding, FieldMask, CallSettings)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdminAccessBinding response = marketingplatformAdminServiceClient.UpdateAdminAccessBinding(adminAccessBinding, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdminAccessBindingAsync</summary>
        public async Task UpdateAdminAccessBindingAsync()
        {
            // Snippet: UpdateAdminAccessBindingAsync(AdminAccessBinding, FieldMask, CallSettings)
            // Additional: UpdateAdminAccessBindingAsync(AdminAccessBinding, FieldMask, CancellationToken)
            // Create client
            MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdminAccessBinding adminAccessBinding = new AdminAccessBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdminAccessBinding response = await marketingplatformAdminServiceClient.UpdateAdminAccessBindingAsync(adminAccessBinding, updateMask);
            // End snippet
        }
    }
}
