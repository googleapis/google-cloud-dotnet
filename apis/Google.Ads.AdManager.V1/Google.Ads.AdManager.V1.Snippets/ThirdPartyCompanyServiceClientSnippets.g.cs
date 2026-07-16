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
    public sealed class AllGeneratedThirdPartyCompanyServiceClientSnippets
    {
        /// <summary>Snippet for GetThirdPartyCompany</summary>
        public void GetThirdPartyCompanyRequestObject()
        {
            // Snippet: GetThirdPartyCompany(GetThirdPartyCompanyRequest, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            GetThirdPartyCompanyRequest request = new GetThirdPartyCompanyRequest
            {
                ThirdPartyCompanyName = ThirdPartyCompanyName.FromNetworkCodeThirdPartyCompany("[NETWORK_CODE]", "[THIRD_PARTY_COMPANY]"),
            };
            // Make the request
            ThirdPartyCompany response = thirdPartyCompanyServiceClient.GetThirdPartyCompany(request);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyCompanyAsync</summary>
        public async Task GetThirdPartyCompanyRequestObjectAsync()
        {
            // Snippet: GetThirdPartyCompanyAsync(GetThirdPartyCompanyRequest, CallSettings)
            // Additional: GetThirdPartyCompanyAsync(GetThirdPartyCompanyRequest, CancellationToken)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetThirdPartyCompanyRequest request = new GetThirdPartyCompanyRequest
            {
                ThirdPartyCompanyName = ThirdPartyCompanyName.FromNetworkCodeThirdPartyCompany("[NETWORK_CODE]", "[THIRD_PARTY_COMPANY]"),
            };
            // Make the request
            ThirdPartyCompany response = await thirdPartyCompanyServiceClient.GetThirdPartyCompanyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyCompany</summary>
        public void GetThirdPartyCompany()
        {
            // Snippet: GetThirdPartyCompany(string, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/thirdPartyCompanies/[THIRD_PARTY_COMPANY]";
            // Make the request
            ThirdPartyCompany response = thirdPartyCompanyServiceClient.GetThirdPartyCompany(name);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyCompanyAsync</summary>
        public async Task GetThirdPartyCompanyAsync()
        {
            // Snippet: GetThirdPartyCompanyAsync(string, CallSettings)
            // Additional: GetThirdPartyCompanyAsync(string, CancellationToken)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/thirdPartyCompanies/[THIRD_PARTY_COMPANY]";
            // Make the request
            ThirdPartyCompany response = await thirdPartyCompanyServiceClient.GetThirdPartyCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyCompany</summary>
        public void GetThirdPartyCompanyResourceNames()
        {
            // Snippet: GetThirdPartyCompany(ThirdPartyCompanyName, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            ThirdPartyCompanyName name = ThirdPartyCompanyName.FromNetworkCodeThirdPartyCompany("[NETWORK_CODE]", "[THIRD_PARTY_COMPANY]");
            // Make the request
            ThirdPartyCompany response = thirdPartyCompanyServiceClient.GetThirdPartyCompany(name);
            // End snippet
        }

        /// <summary>Snippet for GetThirdPartyCompanyAsync</summary>
        public async Task GetThirdPartyCompanyResourceNamesAsync()
        {
            // Snippet: GetThirdPartyCompanyAsync(ThirdPartyCompanyName, CallSettings)
            // Additional: GetThirdPartyCompanyAsync(ThirdPartyCompanyName, CancellationToken)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ThirdPartyCompanyName name = ThirdPartyCompanyName.FromNetworkCodeThirdPartyCompany("[NETWORK_CODE]", "[THIRD_PARTY_COMPANY]");
            // Make the request
            ThirdPartyCompany response = await thirdPartyCompanyServiceClient.GetThirdPartyCompanyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompanies</summary>
        public void ListThirdPartyCompaniesRequestObject()
        {
            // Snippet: ListThirdPartyCompanies(ListThirdPartyCompaniesRequest, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            ListThirdPartyCompaniesRequest request = new ListThirdPartyCompaniesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompanies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompaniesAsync</summary>
        public async Task ListThirdPartyCompaniesRequestObjectAsync()
        {
            // Snippet: ListThirdPartyCompaniesAsync(ListThirdPartyCompaniesRequest, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListThirdPartyCompaniesRequest request = new ListThirdPartyCompaniesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompaniesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompanies</summary>
        public void ListThirdPartyCompanies()
        {
            // Snippet: ListThirdPartyCompanies(string, string, int?, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompanies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompaniesAsync</summary>
        public async Task ListThirdPartyCompaniesAsync()
        {
            // Snippet: ListThirdPartyCompaniesAsync(string, string, int?, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompaniesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompanies</summary>
        public void ListThirdPartyCompaniesResourceNames()
        {
            // Snippet: ListThirdPartyCompanies(NetworkName, string, int?, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = ThirdPartyCompanyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompanies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListThirdPartyCompaniesAsync</summary>
        public async Task ListThirdPartyCompaniesResourceNamesAsync()
        {
            // Snippet: ListThirdPartyCompaniesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ThirdPartyCompanyServiceClient thirdPartyCompanyServiceClient = await ThirdPartyCompanyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListThirdPartyCompaniesResponse, ThirdPartyCompany> response = thirdPartyCompanyServiceClient.ListThirdPartyCompaniesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ThirdPartyCompany item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListThirdPartyCompaniesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ThirdPartyCompany item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ThirdPartyCompany> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ThirdPartyCompany item in singlePage)
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
