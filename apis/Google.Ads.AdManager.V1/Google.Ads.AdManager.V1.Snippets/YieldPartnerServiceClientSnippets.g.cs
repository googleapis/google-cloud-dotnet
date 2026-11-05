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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedYieldPartnerServiceClientSnippets
    {
        /// <summary>Snippet for GetYieldPartner</summary>
        public void GetYieldPartnerRequestObject()
        {
            // Snippet: GetYieldPartner(GetYieldPartnerRequest, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            GetYieldPartnerRequest request = new GetYieldPartnerRequest
            {
                YieldPartnerName = YieldPartnerName.FromNetworkCodeYieldPartner("[NETWORK_CODE]", "[YIELD_PARTNER]"),
            };
            // Make the request
            YieldPartner response = yieldPartnerServiceClient.GetYieldPartner(request);
            // End snippet
        }

        /// <summary>Snippet for GetYieldPartnerAsync</summary>
        public async Task GetYieldPartnerRequestObjectAsync()
        {
            // Snippet: GetYieldPartnerAsync(GetYieldPartnerRequest, CallSettings)
            // Additional: GetYieldPartnerAsync(GetYieldPartnerRequest, CancellationToken)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetYieldPartnerRequest request = new GetYieldPartnerRequest
            {
                YieldPartnerName = YieldPartnerName.FromNetworkCodeYieldPartner("[NETWORK_CODE]", "[YIELD_PARTNER]"),
            };
            // Make the request
            YieldPartner response = await yieldPartnerServiceClient.GetYieldPartnerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetYieldPartner</summary>
        public void GetYieldPartner()
        {
            // Snippet: GetYieldPartner(string, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/yieldPartners/[YIELD_PARTNER]";
            // Make the request
            YieldPartner response = yieldPartnerServiceClient.GetYieldPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldPartnerAsync</summary>
        public async Task GetYieldPartnerAsync()
        {
            // Snippet: GetYieldPartnerAsync(string, CallSettings)
            // Additional: GetYieldPartnerAsync(string, CancellationToken)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/yieldPartners/[YIELD_PARTNER]";
            // Make the request
            YieldPartner response = await yieldPartnerServiceClient.GetYieldPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldPartner</summary>
        public void GetYieldPartnerResourceNames()
        {
            // Snippet: GetYieldPartner(YieldPartnerName, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            YieldPartnerName name = YieldPartnerName.FromNetworkCodeYieldPartner("[NETWORK_CODE]", "[YIELD_PARTNER]");
            // Make the request
            YieldPartner response = yieldPartnerServiceClient.GetYieldPartner(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldPartnerAsync</summary>
        public async Task GetYieldPartnerResourceNamesAsync()
        {
            // Snippet: GetYieldPartnerAsync(YieldPartnerName, CallSettings)
            // Additional: GetYieldPartnerAsync(YieldPartnerName, CancellationToken)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            YieldPartnerName name = YieldPartnerName.FromNetworkCodeYieldPartner("[NETWORK_CODE]", "[YIELD_PARTNER]");
            // Make the request
            YieldPartner response = await yieldPartnerServiceClient.GetYieldPartnerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartners</summary>
        public void ListYieldPartnersRequestObject()
        {
            // Snippet: ListYieldPartners(ListYieldPartnersRequest, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartners(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartnersAsync</summary>
        public async Task ListYieldPartnersRequestObjectAsync()
        {
            // Snippet: ListYieldPartnersAsync(ListYieldPartnersRequest, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListYieldPartnersRequest request = new ListYieldPartnersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartnersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartners</summary>
        public void ListYieldPartners()
        {
            // Snippet: ListYieldPartners(string, string, int?, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartners(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartnersAsync</summary>
        public async Task ListYieldPartnersAsync()
        {
            // Snippet: ListYieldPartnersAsync(string, string, int?, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartnersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartners</summary>
        public void ListYieldPartnersResourceNames()
        {
            // Snippet: ListYieldPartners(NetworkName, string, int?, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = YieldPartnerServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartners(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldPartnersAsync</summary>
        public async Task ListYieldPartnersResourceNamesAsync()
        {
            // Snippet: ListYieldPartnersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            YieldPartnerServiceClient yieldPartnerServiceClient = await YieldPartnerServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListYieldPartnersResponse, YieldPartner> response = yieldPartnerServiceClient.ListYieldPartnersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldPartner item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldPartnersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldPartner item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldPartner> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldPartner item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
