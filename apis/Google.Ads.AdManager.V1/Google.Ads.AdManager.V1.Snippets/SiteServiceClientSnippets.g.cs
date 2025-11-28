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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSiteServiceClientSnippets
    {
        /// <summary>Snippet for GetSite</summary>
        public void GetSiteRequestObject()
        {
            // Snippet: GetSite(GetSiteRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            GetSiteRequest request = new GetSiteRequest
            {
                SiteName = SiteName.FromNetworkCodeSite("[NETWORK_CODE]", "[SITE]"),
            };
            // Make the request
            Site response = siteServiceClient.GetSite(request);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteRequestObjectAsync()
        {
            // Snippet: GetSiteAsync(GetSiteRequest, CallSettings)
            // Additional: GetSiteAsync(GetSiteRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSiteRequest request = new GetSiteRequest
            {
                SiteName = SiteName.FromNetworkCodeSite("[NETWORK_CODE]", "[SITE]"),
            };
            // Make the request
            Site response = await siteServiceClient.GetSiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSite</summary>
        public void GetSite()
        {
            // Snippet: GetSite(string, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/sites/[SITE]";
            // Make the request
            Site response = siteServiceClient.GetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteAsync()
        {
            // Snippet: GetSiteAsync(string, CallSettings)
            // Additional: GetSiteAsync(string, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/sites/[SITE]";
            // Make the request
            Site response = await siteServiceClient.GetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSite</summary>
        public void GetSiteResourceNames()
        {
            // Snippet: GetSite(SiteName, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            SiteName name = SiteName.FromNetworkCodeSite("[NETWORK_CODE]", "[SITE]");
            // Make the request
            Site response = siteServiceClient.GetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteResourceNamesAsync()
        {
            // Snippet: GetSiteAsync(SiteName, CallSettings)
            // Additional: GetSiteAsync(SiteName, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            SiteName name = SiteName.FromNetworkCodeSite("[NETWORK_CODE]", "[SITE]");
            // Make the request
            Site response = await siteServiceClient.GetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSitesRequestObject()
        {
            // Snippet: ListSites(ListSitesRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            ListSitesRequest request = new ListSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSites(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesRequestObjectAsync()
        {
            // Snippet: ListSitesAsync(ListSitesRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSitesRequest request = new ListSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSitesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSites()
        {
            // Snippet: ListSites(string, string, int?, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesAsync()
        {
            // Snippet: ListSitesAsync(string, string, int?, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSitesResourceNames()
        {
            // Snippet: ListSites(NetworkName, string, int?, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesResourceNamesAsync()
        {
            // Snippet: ListSitesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = siteServiceClient.ListSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSiteRequestObject()
        {
            // Snippet: CreateSite(CreateSiteRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            CreateSiteRequest request = new CreateSiteRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Site = new Site(),
            };
            // Make the request
            Site response = siteServiceClient.CreateSite(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteRequestObjectAsync()
        {
            // Snippet: CreateSiteAsync(CreateSiteRequest, CallSettings)
            // Additional: CreateSiteAsync(CreateSiteRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSiteRequest request = new CreateSiteRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Site = new Site(),
            };
            // Make the request
            Site response = await siteServiceClient.CreateSiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSite()
        {
            // Snippet: CreateSite(string, Site, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Site site = new Site();
            // Make the request
            Site response = siteServiceClient.CreateSite(parent, site);
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteAsync()
        {
            // Snippet: CreateSiteAsync(string, Site, CallSettings)
            // Additional: CreateSiteAsync(string, Site, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Site site = new Site();
            // Make the request
            Site response = await siteServiceClient.CreateSiteAsync(parent, site);
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSiteResourceNames()
        {
            // Snippet: CreateSite(NetworkName, Site, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Site site = new Site();
            // Make the request
            Site response = siteServiceClient.CreateSite(parent, site);
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteResourceNamesAsync()
        {
            // Snippet: CreateSiteAsync(NetworkName, Site, CallSettings)
            // Additional: CreateSiteAsync(NetworkName, Site, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Site site = new Site();
            // Make the request
            Site response = await siteServiceClient.CreateSiteAsync(parent, site);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSites</summary>
        public void BatchCreateSitesRequestObject()
        {
            // Snippet: BatchCreateSites(BatchCreateSitesRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateSitesRequest request = new BatchCreateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateSiteRequest(),
                },
            };
            // Make the request
            BatchCreateSitesResponse response = siteServiceClient.BatchCreateSites(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSitesAsync</summary>
        public async Task BatchCreateSitesRequestObjectAsync()
        {
            // Snippet: BatchCreateSitesAsync(BatchCreateSitesRequest, CallSettings)
            // Additional: BatchCreateSitesAsync(BatchCreateSitesRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateSitesRequest request = new BatchCreateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateSiteRequest(),
                },
            };
            // Make the request
            BatchCreateSitesResponse response = await siteServiceClient.BatchCreateSitesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSites</summary>
        public void BatchCreateSites()
        {
            // Snippet: BatchCreateSites(string, IEnumerable<CreateSiteRequest>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateSiteRequest> requests = new CreateSiteRequest[]
            {
                new CreateSiteRequest(),
            };
            // Make the request
            BatchCreateSitesResponse response = siteServiceClient.BatchCreateSites(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSitesAsync</summary>
        public async Task BatchCreateSitesAsync()
        {
            // Snippet: BatchCreateSitesAsync(string, IEnumerable<CreateSiteRequest>, CallSettings)
            // Additional: BatchCreateSitesAsync(string, IEnumerable<CreateSiteRequest>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateSiteRequest> requests = new CreateSiteRequest[]
            {
                new CreateSiteRequest(),
            };
            // Make the request
            BatchCreateSitesResponse response = await siteServiceClient.BatchCreateSitesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSites</summary>
        public void BatchCreateSitesResourceNames()
        {
            // Snippet: BatchCreateSites(NetworkName, IEnumerable<CreateSiteRequest>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateSiteRequest> requests = new CreateSiteRequest[]
            {
                new CreateSiteRequest(),
            };
            // Make the request
            BatchCreateSitesResponse response = siteServiceClient.BatchCreateSites(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSitesAsync</summary>
        public async Task BatchCreateSitesResourceNamesAsync()
        {
            // Snippet: BatchCreateSitesAsync(NetworkName, IEnumerable<CreateSiteRequest>, CallSettings)
            // Additional: BatchCreateSitesAsync(NetworkName, IEnumerable<CreateSiteRequest>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateSiteRequest> requests = new CreateSiteRequest[]
            {
                new CreateSiteRequest(),
            };
            // Make the request
            BatchCreateSitesResponse response = await siteServiceClient.BatchCreateSitesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateSite</summary>
        public void UpdateSiteRequestObject()
        {
            // Snippet: UpdateSite(UpdateSiteRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            UpdateSiteRequest request = new UpdateSiteRequest
            {
                Site = new Site(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Site response = siteServiceClient.UpdateSite(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSiteAsync</summary>
        public async Task UpdateSiteRequestObjectAsync()
        {
            // Snippet: UpdateSiteAsync(UpdateSiteRequest, CallSettings)
            // Additional: UpdateSiteAsync(UpdateSiteRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSiteRequest request = new UpdateSiteRequest
            {
                Site = new Site(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Site response = await siteServiceClient.UpdateSiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSite</summary>
        public void UpdateSite()
        {
            // Snippet: UpdateSite(Site, FieldMask, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            Site site = new Site();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Site response = siteServiceClient.UpdateSite(site, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSiteAsync</summary>
        public async Task UpdateSiteAsync()
        {
            // Snippet: UpdateSiteAsync(Site, FieldMask, CallSettings)
            // Additional: UpdateSiteAsync(Site, FieldMask, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            Site site = new Site();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Site response = await siteServiceClient.UpdateSiteAsync(site, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSites</summary>
        public void BatchUpdateSitesRequestObject()
        {
            // Snippet: BatchUpdateSites(BatchUpdateSitesRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateSitesRequest request = new BatchUpdateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateSiteRequest(),
                },
            };
            // Make the request
            BatchUpdateSitesResponse response = siteServiceClient.BatchUpdateSites(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSitesAsync</summary>
        public async Task BatchUpdateSitesRequestObjectAsync()
        {
            // Snippet: BatchUpdateSitesAsync(BatchUpdateSitesRequest, CallSettings)
            // Additional: BatchUpdateSitesAsync(BatchUpdateSitesRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateSitesRequest request = new BatchUpdateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateSiteRequest(),
                },
            };
            // Make the request
            BatchUpdateSitesResponse response = await siteServiceClient.BatchUpdateSitesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSites</summary>
        public void BatchUpdateSites()
        {
            // Snippet: BatchUpdateSites(string, IEnumerable<UpdateSiteRequest>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateSiteRequest> requests = new UpdateSiteRequest[]
            {
                new UpdateSiteRequest(),
            };
            // Make the request
            BatchUpdateSitesResponse response = siteServiceClient.BatchUpdateSites(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSitesAsync</summary>
        public async Task BatchUpdateSitesAsync()
        {
            // Snippet: BatchUpdateSitesAsync(string, IEnumerable<UpdateSiteRequest>, CallSettings)
            // Additional: BatchUpdateSitesAsync(string, IEnumerable<UpdateSiteRequest>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateSiteRequest> requests = new UpdateSiteRequest[]
            {
                new UpdateSiteRequest(),
            };
            // Make the request
            BatchUpdateSitesResponse response = await siteServiceClient.BatchUpdateSitesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSites</summary>
        public void BatchUpdateSitesResourceNames()
        {
            // Snippet: BatchUpdateSites(NetworkName, IEnumerable<UpdateSiteRequest>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateSiteRequest> requests = new UpdateSiteRequest[]
            {
                new UpdateSiteRequest(),
            };
            // Make the request
            BatchUpdateSitesResponse response = siteServiceClient.BatchUpdateSites(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateSitesAsync</summary>
        public async Task BatchUpdateSitesResourceNamesAsync()
        {
            // Snippet: BatchUpdateSitesAsync(NetworkName, IEnumerable<UpdateSiteRequest>, CallSettings)
            // Additional: BatchUpdateSitesAsync(NetworkName, IEnumerable<UpdateSiteRequest>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateSiteRequest> requests = new UpdateSiteRequest[]
            {
                new UpdateSiteRequest(),
            };
            // Make the request
            BatchUpdateSitesResponse response = await siteServiceClient.BatchUpdateSitesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSites</summary>
        public void BatchDeactivateSitesRequestObject()
        {
            // Snippet: BatchDeactivateSites(BatchDeactivateSitesRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateSitesRequest request = new BatchDeactivateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateSitesResponse response = siteServiceClient.BatchDeactivateSites(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSitesAsync</summary>
        public async Task BatchDeactivateSitesRequestObjectAsync()
        {
            // Snippet: BatchDeactivateSitesAsync(BatchDeactivateSitesRequest, CallSettings)
            // Additional: BatchDeactivateSitesAsync(BatchDeactivateSitesRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateSitesRequest request = new BatchDeactivateSitesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateSitesResponse response = await siteServiceClient.BatchDeactivateSitesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSites</summary>
        public void BatchDeactivateSites()
        {
            // Snippet: BatchDeactivateSites(string, IEnumerable<string>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateSitesResponse response = siteServiceClient.BatchDeactivateSites(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSitesAsync</summary>
        public async Task BatchDeactivateSitesAsync()
        {
            // Snippet: BatchDeactivateSitesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateSitesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateSitesResponse response = await siteServiceClient.BatchDeactivateSitesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSites</summary>
        public void BatchDeactivateSitesResourceNames()
        {
            // Snippet: BatchDeactivateSites(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateSitesResponse response = siteServiceClient.BatchDeactivateSites(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateSitesAsync</summary>
        public async Task BatchDeactivateSitesResourceNamesAsync()
        {
            // Snippet: BatchDeactivateSitesAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateSitesAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateSitesResponse response = await siteServiceClient.BatchDeactivateSitesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApproval</summary>
        public void BatchSubmitSitesForApprovalRequestObject()
        {
            // Snippet: BatchSubmitSitesForApproval(BatchSubmitSitesForApprovalRequest, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            BatchSubmitSitesForApprovalRequest request = new BatchSubmitSitesForApprovalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = siteServiceClient.BatchSubmitSitesForApproval(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApprovalAsync</summary>
        public async Task BatchSubmitSitesForApprovalRequestObjectAsync()
        {
            // Snippet: BatchSubmitSitesForApprovalAsync(BatchSubmitSitesForApprovalRequest, CallSettings)
            // Additional: BatchSubmitSitesForApprovalAsync(BatchSubmitSitesForApprovalRequest, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchSubmitSitesForApprovalRequest request = new BatchSubmitSitesForApprovalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = await siteServiceClient.BatchSubmitSitesForApprovalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApproval</summary>
        public void BatchSubmitSitesForApproval()
        {
            // Snippet: BatchSubmitSitesForApproval(string, IEnumerable<string>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = siteServiceClient.BatchSubmitSitesForApproval(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApprovalAsync</summary>
        public async Task BatchSubmitSitesForApprovalAsync()
        {
            // Snippet: BatchSubmitSitesForApprovalAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchSubmitSitesForApprovalAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = await siteServiceClient.BatchSubmitSitesForApprovalAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApproval</summary>
        public void BatchSubmitSitesForApprovalResourceNames()
        {
            // Snippet: BatchSubmitSitesForApproval(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            SiteServiceClient siteServiceClient = SiteServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = siteServiceClient.BatchSubmitSitesForApproval(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitSitesForApprovalAsync</summary>
        public async Task BatchSubmitSitesForApprovalResourceNamesAsync()
        {
            // Snippet: BatchSubmitSitesForApprovalAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchSubmitSitesForApprovalAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            SiteServiceClient siteServiceClient = await SiteServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchSubmitSitesForApprovalResponse response = await siteServiceClient.BatchSubmitSitesForApprovalAsync(parent, names);
            // End snippet
        }
    }
}
