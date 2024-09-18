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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gamav = Google.Ads.MarketingPlatform.Admin.V1Alpha;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMarketingplatformAdminServiceClientSnippets
    {
        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationRequestObject()
        {
            // Snippet: GetOrganization(GetOrganizationRequest, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::GetOrganizationRequest request = new gamav::GetOrganizationRequest
            {
                OrganizationName = gamav::OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            gamav::Organization response = marketingplatformAdminServiceClient.GetOrganization(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationRequestObjectAsync()
        {
            // Snippet: GetOrganizationAsync(GetOrganizationRequest, CallSettings)
            // Additional: GetOrganizationAsync(GetOrganizationRequest, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::GetOrganizationRequest request = new gamav::GetOrganizationRequest
            {
                OrganizationName = gamav::OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            gamav::Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganization()
        {
            // Snippet: GetOrganization(string, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            gamav::Organization response = marketingplatformAdminServiceClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationAsync()
        {
            // Snippet: GetOrganizationAsync(string, CallSettings)
            // Additional: GetOrganizationAsync(string, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            gamav::Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationResourceNames()
        {
            // Snippet: GetOrganization(OrganizationName, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::OrganizationName name = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            gamav::Organization response = marketingplatformAdminServiceClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationResourceNamesAsync()
        {
            // Snippet: GetOrganizationAsync(OrganizationName, CallSettings)
            // Additional: GetOrganizationAsync(OrganizationName, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::OrganizationName name = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            gamav::Organization response = await marketingplatformAdminServiceClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinksRequestObject()
        {
            // Snippet: ListAnalyticsAccountLinks(ListAnalyticsAccountLinksRequest, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::ListAnalyticsAccountLinksRequest request = new gamav::ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gamav::AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gamav::ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::ListAnalyticsAccountLinksRequest request = new gamav::ListAnalyticsAccountLinksRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gamav::AnalyticsAccountLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gamav::ListAnalyticsAccountLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gamav::AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gamav::ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gamav::AnalyticsAccountLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gamav::ListAnalyticsAccountLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinksResourceNames1()
        {
            // Snippet: ListAnalyticsAccountLinks(OrganizationName, string, int?, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gamav::AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gamav::ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinksAsync</summary>
        public async Task ListAnalyticsAccountLinksResourceNames1Async()
        {
            // Snippet: ListAnalyticsAccountLinksAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gamav::AnalyticsAccountLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gamav::ListAnalyticsAccountLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinks</summary>
        public void ListAnalyticsAccountLinksResourceNames2()
        {
            // Snippet: ListAnalyticsAccountLinks(OrganizationName, string, int?, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::OrganizationName parent = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gamav::AnalyticsAccountLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gamav::ListAnalyticsAccountLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyticsAccountLinksAsync</summary>
        public async Task ListAnalyticsAccountLinksResourceNames2Async()
        {
            // Snippet: ListAnalyticsAccountLinksAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::OrganizationName parent = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<gamav::ListAnalyticsAccountLinksResponse, gamav::AnalyticsAccountLink> response = marketingplatformAdminServiceClient.ListAnalyticsAccountLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gamav::AnalyticsAccountLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gamav::ListAnalyticsAccountLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gamav::AnalyticsAccountLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gamav::AnalyticsAccountLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gamav::AnalyticsAccountLink item in singlePage)
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::CreateAnalyticsAccountLinkRequest request = new gamav::CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AnalyticsAccountLink = new gamav::AnalyticsAccountLink(),
            };
            // Make the request
            gamav::AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkRequestObjectAsync()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(CreateAnalyticsAccountLinkRequest, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::CreateAnalyticsAccountLinkRequest request = new gamav::CreateAnalyticsAccountLinkRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                AnalyticsAccountLink = new gamav::AnalyticsAccountLink(),
            };
            // Make the request
            gamav::AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLink()
        {
            // Snippet: CreateAnalyticsAccountLink(string, AnalyticsAccountLink, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkAsync()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(string, AnalyticsAccountLink, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(string, AnalyticsAccountLink, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLinkResourceNames1()
        {
            // Snippet: CreateAnalyticsAccountLink(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkResourceNames1Async()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLink</summary>
        public void CreateAnalyticsAccountLinkResourceNames2()
        {
            // Snippet: CreateAnalyticsAccountLink(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::OrganizationName parent = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = marketingplatformAdminServiceClient.CreateAnalyticsAccountLink(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalyticsAccountLinkAsync</summary>
        public async Task CreateAnalyticsAccountLinkResourceNames2Async()
        {
            // Snippet: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CallSettings)
            // Additional: CreateAnalyticsAccountLinkAsync(OrganizationName, AnalyticsAccountLink, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::OrganizationName parent = gamav::OrganizationName.FromOrganization("[ORGANIZATION]");
            gamav::AnalyticsAccountLink analyticsAccountLink = new gamav::AnalyticsAccountLink();
            // Make the request
            gamav::AnalyticsAccountLink response = await marketingplatformAdminServiceClient.CreateAnalyticsAccountLinkAsync(parent, analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalyticsAccountLink</summary>
        public void DeleteAnalyticsAccountLinkRequestObject()
        {
            // Snippet: DeleteAnalyticsAccountLink(DeleteAnalyticsAccountLinkRequest, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::DeleteAnalyticsAccountLinkRequest request = new gamav::DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gamav::AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]"),
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::DeleteAnalyticsAccountLinkRequest request = new gamav::DeleteAnalyticsAccountLinkRequest
            {
                AnalyticsAccountLinkName = gamav::AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]"),
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::AnalyticsAccountLinkName name = gamav::AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]");
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
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::AnalyticsAccountLinkName name = gamav::AnalyticsAccountLinkName.FromOrganizationAnalyticsAccountLink("[ORGANIZATION]", "[ANALYTICS_ACCOUNT_LINK]");
            // Make the request
            await marketingplatformAdminServiceClient.DeleteAnalyticsAccountLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevel</summary>
        public void SetPropertyServiceLevelRequestObject()
        {
            // Snippet: SetPropertyServiceLevel(SetPropertyServiceLevelRequest, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            gamav::SetPropertyServiceLevelRequest request = new gamav::SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = "",
                AnalyticsPropertyAsPropertyName = gamav::PropertyName.FromProperty("[PROPERTY]"),
                ServiceLevel = gamav::AnalyticsServiceLevel.Unspecified,
            };
            // Make the request
            gamav::SetPropertyServiceLevelResponse response = marketingplatformAdminServiceClient.SetPropertyServiceLevel(request);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevelAsync</summary>
        public async Task SetPropertyServiceLevelRequestObjectAsync()
        {
            // Snippet: SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest, CallSettings)
            // Additional: SetPropertyServiceLevelAsync(SetPropertyServiceLevelRequest, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            gamav::SetPropertyServiceLevelRequest request = new gamav::SetPropertyServiceLevelRequest
            {
                AnalyticsAccountLink = "",
                AnalyticsPropertyAsPropertyName = gamav::PropertyName.FromProperty("[PROPERTY]"),
                ServiceLevel = gamav::AnalyticsServiceLevel.Unspecified,
            };
            // Make the request
            gamav::SetPropertyServiceLevelResponse response = await marketingplatformAdminServiceClient.SetPropertyServiceLevelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevel</summary>
        public void SetPropertyServiceLevel()
        {
            // Snippet: SetPropertyServiceLevel(string, CallSettings)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = gamav::MarketingplatformAdminServiceClient.Create();
            // Initialize request argument(s)
            string analyticsAccountLink = "";
            // Make the request
            gamav::SetPropertyServiceLevelResponse response = marketingplatformAdminServiceClient.SetPropertyServiceLevel(analyticsAccountLink);
            // End snippet
        }

        /// <summary>Snippet for SetPropertyServiceLevelAsync</summary>
        public async Task SetPropertyServiceLevelAsync()
        {
            // Snippet: SetPropertyServiceLevelAsync(string, CallSettings)
            // Additional: SetPropertyServiceLevelAsync(string, CancellationToken)
            // Create client
            gamav::MarketingplatformAdminServiceClient marketingplatformAdminServiceClient = await gamav::MarketingplatformAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string analyticsAccountLink = "";
            // Make the request
            gamav::SetPropertyServiceLevelResponse response = await marketingplatformAdminServiceClient.SetPropertyServiceLevelAsync(analyticsAccountLink);
            // End snippet
        }
    }
}
