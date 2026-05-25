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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFirewallActivationClientSnippets
    {
        /// <summary>Snippet for ListFirewallEndpoints</summary>
        public void ListFirewallEndpointsRequestObject()
        {
            // Snippet: ListFirewallEndpoints(ListFirewallEndpointsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointsAsync</summary>
        public async Task ListFirewallEndpointsRequestObjectAsync()
        {
            // Snippet: ListFirewallEndpointsAsync(ListFirewallEndpointsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpoints</summary>
        public void ListFirewallEndpoints()
        {
            // Snippet: ListFirewallEndpoints(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointsAsync</summary>
        public async Task ListFirewallEndpointsAsync()
        {
            // Snippet: ListFirewallEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpoints</summary>
        public void ListFirewallEndpointsResourceNames1()
        {
            // Snippet: ListFirewallEndpoints(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointsAsync</summary>
        public async Task ListFirewallEndpointsResourceNames1Async()
        {
            // Snippet: ListFirewallEndpointsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpoints</summary>
        public void ListFirewallEndpointsResourceNames2()
        {
            // Snippet: ListFirewallEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointsAsync</summary>
        public async Task ListFirewallEndpointsResourceNames2Async()
        {
            // Snippet: ListFirewallEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpoints</summary>
        public void ListProjectFirewallEndpointsRequestObject()
        {
            // Snippet: ListProjectFirewallEndpoints(ListFirewallEndpointsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpointsAsync</summary>
        public async Task ListProjectFirewallEndpointsRequestObjectAsync()
        {
            // Snippet: ListProjectFirewallEndpointsAsync(ListFirewallEndpointsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallEndpointsRequest request = new ListFirewallEndpointsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpoints</summary>
        public void ListProjectFirewallEndpoints()
        {
            // Snippet: ListProjectFirewallEndpoints(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpointsAsync</summary>
        public async Task ListProjectFirewallEndpointsAsync()
        {
            // Snippet: ListProjectFirewallEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpoints</summary>
        public void ListProjectFirewallEndpointsResourceNames1()
        {
            // Snippet: ListProjectFirewallEndpoints(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpointsAsync</summary>
        public async Task ListProjectFirewallEndpointsResourceNames1Async()
        {
            // Snippet: ListProjectFirewallEndpointsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpoints</summary>
        public void ListProjectFirewallEndpointsResourceNames2()
        {
            // Snippet: ListProjectFirewallEndpoints(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectFirewallEndpointsAsync</summary>
        public async Task ListProjectFirewallEndpointsResourceNames2Async()
        {
            // Snippet: ListProjectFirewallEndpointsAsync(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointsResponse, FirewallEndpoint> response = firewallActivationClient.ListProjectFirewallEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpoint</summary>
        public void GetFirewallEndpointRequestObject()
        {
            // Snippet: GetFirewallEndpoint(GetFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            GetFirewallEndpointRequest request = new GetFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
            };
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetFirewallEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAsync</summary>
        public async Task GetFirewallEndpointRequestObjectAsync()
        {
            // Snippet: GetFirewallEndpointAsync(GetFirewallEndpointRequest, CallSettings)
            // Additional: GetFirewallEndpointAsync(GetFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallEndpointRequest request = new GetFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
            };
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetFirewallEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpoint</summary>
        public void GetFirewallEndpoint()
        {
            // Snippet: GetFirewallEndpoint(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetFirewallEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAsync</summary>
        public async Task GetFirewallEndpointAsync()
        {
            // Snippet: GetFirewallEndpointAsync(string, CallSettings)
            // Additional: GetFirewallEndpointAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetFirewallEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpoint</summary>
        public void GetFirewallEndpointResourceNames()
        {
            // Snippet: GetFirewallEndpoint(FirewallEndpointName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetFirewallEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAsync</summary>
        public async Task GetFirewallEndpointResourceNamesAsync()
        {
            // Snippet: GetFirewallEndpointAsync(FirewallEndpointName, CallSettings)
            // Additional: GetFirewallEndpointAsync(FirewallEndpointName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetFirewallEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpoint</summary>
        public void GetProjectFirewallEndpointRequestObject()
        {
            // Snippet: GetProjectFirewallEndpoint(GetFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            GetFirewallEndpointRequest request = new GetFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
            };
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetProjectFirewallEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpointAsync</summary>
        public async Task GetProjectFirewallEndpointRequestObjectAsync()
        {
            // Snippet: GetProjectFirewallEndpointAsync(GetFirewallEndpointRequest, CallSettings)
            // Additional: GetProjectFirewallEndpointAsync(GetFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallEndpointRequest request = new GetFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
            };
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetProjectFirewallEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpoint</summary>
        public void GetProjectFirewallEndpoint()
        {
            // Snippet: GetProjectFirewallEndpoint(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetProjectFirewallEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpointAsync</summary>
        public async Task GetProjectFirewallEndpointAsync()
        {
            // Snippet: GetProjectFirewallEndpointAsync(string, CallSettings)
            // Additional: GetProjectFirewallEndpointAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetProjectFirewallEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpoint</summary>
        public void GetProjectFirewallEndpointResourceNames()
        {
            // Snippet: GetProjectFirewallEndpoint(FirewallEndpointName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            FirewallEndpoint response = firewallActivationClient.GetProjectFirewallEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectFirewallEndpointAsync</summary>
        public async Task GetProjectFirewallEndpointResourceNamesAsync()
        {
            // Snippet: GetProjectFirewallEndpointAsync(FirewallEndpointName, CallSettings)
            // Additional: GetProjectFirewallEndpointAsync(FirewallEndpointName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            FirewallEndpoint response = await firewallActivationClient.GetProjectFirewallEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpoint</summary>
        public void CreateFirewallEndpointRequestObject()
        {
            // Snippet: CreateFirewallEndpoint(CreateFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            CreateFirewallEndpointRequest request = new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FirewallEndpointId = "",
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAsync</summary>
        public async Task CreateFirewallEndpointRequestObjectAsync()
        {
            // Snippet: CreateFirewallEndpointAsync(CreateFirewallEndpointRequest, CallSettings)
            // Additional: CreateFirewallEndpointAsync(CreateFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            CreateFirewallEndpointRequest request = new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FirewallEndpointId = "",
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpoint</summary>
        public void CreateFirewallEndpoint()
        {
            // Snippet: CreateFirewallEndpoint(string, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAsync</summary>
        public async Task CreateFirewallEndpointAsync()
        {
            // Snippet: CreateFirewallEndpointAsync(string, FirewallEndpoint, string, CallSettings)
            // Additional: CreateFirewallEndpointAsync(string, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpoint</summary>
        public void CreateFirewallEndpointResourceNames1()
        {
            // Snippet: CreateFirewallEndpoint(OrganizationLocationName, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAsync</summary>
        public async Task CreateFirewallEndpointResourceNames1Async()
        {
            // Snippet: CreateFirewallEndpointAsync(OrganizationLocationName, FirewallEndpoint, string, CallSettings)
            // Additional: CreateFirewallEndpointAsync(OrganizationLocationName, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpoint</summary>
        public void CreateFirewallEndpointResourceNames2()
        {
            // Snippet: CreateFirewallEndpoint(LocationName, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAsync</summary>
        public async Task CreateFirewallEndpointResourceNames2Async()
        {
            // Snippet: CreateFirewallEndpointAsync(LocationName, FirewallEndpoint, string, CallSettings)
            // Additional: CreateFirewallEndpointAsync(LocationName, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpoint</summary>
        public void CreateProjectFirewallEndpointRequestObject()
        {
            // Snippet: CreateProjectFirewallEndpoint(CreateFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            CreateFirewallEndpointRequest request = new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FirewallEndpointId = "",
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateProjectFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpointAsync</summary>
        public async Task CreateProjectFirewallEndpointRequestObjectAsync()
        {
            // Snippet: CreateProjectFirewallEndpointAsync(CreateFirewallEndpointRequest, CallSettings)
            // Additional: CreateProjectFirewallEndpointAsync(CreateFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            CreateFirewallEndpointRequest request = new CreateFirewallEndpointRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                FirewallEndpointId = "",
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateProjectFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpoint</summary>
        public void CreateProjectFirewallEndpoint()
        {
            // Snippet: CreateProjectFirewallEndpoint(string, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateProjectFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpointAsync</summary>
        public async Task CreateProjectFirewallEndpointAsync()
        {
            // Snippet: CreateProjectFirewallEndpointAsync(string, FirewallEndpoint, string, CallSettings)
            // Additional: CreateProjectFirewallEndpointAsync(string, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpoint</summary>
        public void CreateProjectFirewallEndpointResourceNames1()
        {
            // Snippet: CreateProjectFirewallEndpoint(OrganizationLocationName, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateProjectFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpointAsync</summary>
        public async Task CreateProjectFirewallEndpointResourceNames1Async()
        {
            // Snippet: CreateProjectFirewallEndpointAsync(OrganizationLocationName, FirewallEndpoint, string, CallSettings)
            // Additional: CreateProjectFirewallEndpointAsync(OrganizationLocationName, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpoint</summary>
        public void CreateProjectFirewallEndpointResourceNames2()
        {
            // Snippet: CreateProjectFirewallEndpoint(LocationName, FirewallEndpoint, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.CreateProjectFirewallEndpoint(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProjectFirewallEndpointAsync</summary>
        public async Task CreateProjectFirewallEndpointResourceNames2Async()
        {
            // Snippet: CreateProjectFirewallEndpointAsync(LocationName, FirewallEndpoint, string, CallSettings)
            // Additional: CreateProjectFirewallEndpointAsync(LocationName, FirewallEndpoint, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            string firewallEndpointId = "";
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.CreateProjectFirewallEndpointAsync(parent, firewallEndpoint, firewallEndpointId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpoint</summary>
        public void DeleteFirewallEndpointRequestObject()
        {
            // Snippet: DeleteFirewallEndpoint(DeleteFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            DeleteFirewallEndpointRequest request = new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAsync</summary>
        public async Task DeleteFirewallEndpointRequestObjectAsync()
        {
            // Snippet: DeleteFirewallEndpointAsync(DeleteFirewallEndpointRequest, CallSettings)
            // Additional: DeleteFirewallEndpointAsync(DeleteFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallEndpointRequest request = new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpoint</summary>
        public void DeleteFirewallEndpoint()
        {
            // Snippet: DeleteFirewallEndpoint(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAsync</summary>
        public async Task DeleteFirewallEndpointAsync()
        {
            // Snippet: DeleteFirewallEndpointAsync(string, CallSettings)
            // Additional: DeleteFirewallEndpointAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpoint</summary>
        public void DeleteFirewallEndpointResourceNames()
        {
            // Snippet: DeleteFirewallEndpoint(FirewallEndpointName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAsync</summary>
        public async Task DeleteFirewallEndpointResourceNamesAsync()
        {
            // Snippet: DeleteFirewallEndpointAsync(FirewallEndpointName, CallSettings)
            // Additional: DeleteFirewallEndpointAsync(FirewallEndpointName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpoint</summary>
        public void DeleteProjectFirewallEndpointRequestObject()
        {
            // Snippet: DeleteProjectFirewallEndpoint(DeleteFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            DeleteFirewallEndpointRequest request = new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteProjectFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpointAsync</summary>
        public async Task DeleteProjectFirewallEndpointRequestObjectAsync()
        {
            // Snippet: DeleteProjectFirewallEndpointAsync(DeleteFirewallEndpointRequest, CallSettings)
            // Additional: DeleteProjectFirewallEndpointAsync(DeleteFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallEndpointRequest request = new DeleteFirewallEndpointRequest
            {
                FirewallEndpointName = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteProjectFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpoint</summary>
        public void DeleteProjectFirewallEndpoint()
        {
            // Snippet: DeleteProjectFirewallEndpoint(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteProjectFirewallEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpointAsync</summary>
        public async Task DeleteProjectFirewallEndpointAsync()
        {
            // Snippet: DeleteProjectFirewallEndpointAsync(string, CallSettings)
            // Additional: DeleteProjectFirewallEndpointAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/firewallEndpoints/[FIREWALL_ENDPOINT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteProjectFirewallEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpoint</summary>
        public void DeleteProjectFirewallEndpointResourceNames()
        {
            // Snippet: DeleteProjectFirewallEndpoint(FirewallEndpointName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteProjectFirewallEndpoint(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProjectFirewallEndpointAsync</summary>
        public async Task DeleteProjectFirewallEndpointResourceNamesAsync()
        {
            // Snippet: DeleteProjectFirewallEndpointAsync(FirewallEndpointName, CallSettings)
            // Additional: DeleteProjectFirewallEndpointAsync(FirewallEndpointName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointName name = FirewallEndpointName.FromOrganizationLocationFirewallEndpoint("[ORGANIZATION]", "[LOCATION]", "[FIREWALL_ENDPOINT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteProjectFirewallEndpointAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpoint</summary>
        public void UpdateFirewallEndpointRequestObject()
        {
            // Snippet: UpdateFirewallEndpoint(UpdateFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            UpdateFirewallEndpointRequest request = new UpdateFirewallEndpointRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.UpdateFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAsync</summary>
        public async Task UpdateFirewallEndpointRequestObjectAsync()
        {
            // Snippet: UpdateFirewallEndpointAsync(UpdateFirewallEndpointRequest, CallSettings)
            // Additional: UpdateFirewallEndpointAsync(UpdateFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirewallEndpointRequest request = new UpdateFirewallEndpointRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.UpdateFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpoint</summary>
        public void UpdateFirewallEndpoint()
        {
            // Snippet: UpdateFirewallEndpoint(FirewallEndpoint, FieldMask, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.UpdateFirewallEndpoint(firewallEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAsync</summary>
        public async Task UpdateFirewallEndpointAsync()
        {
            // Snippet: UpdateFirewallEndpointAsync(FirewallEndpoint, FieldMask, CallSettings)
            // Additional: UpdateFirewallEndpointAsync(FirewallEndpoint, FieldMask, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.UpdateFirewallEndpointAsync(firewallEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectFirewallEndpoint</summary>
        public void UpdateProjectFirewallEndpointRequestObject()
        {
            // Snippet: UpdateProjectFirewallEndpoint(UpdateFirewallEndpointRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            UpdateFirewallEndpointRequest request = new UpdateFirewallEndpointRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.UpdateProjectFirewallEndpoint(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectFirewallEndpointAsync</summary>
        public async Task UpdateProjectFirewallEndpointRequestObjectAsync()
        {
            // Snippet: UpdateProjectFirewallEndpointAsync(UpdateFirewallEndpointRequest, CallSettings)
            // Additional: UpdateProjectFirewallEndpointAsync(UpdateFirewallEndpointRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirewallEndpointRequest request = new UpdateFirewallEndpointRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpoint = new FirewallEndpoint(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.UpdateProjectFirewallEndpointAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectFirewallEndpoint</summary>
        public void UpdateProjectFirewallEndpoint()
        {
            // Snippet: UpdateProjectFirewallEndpoint(FirewallEndpoint, FieldMask, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = firewallActivationClient.UpdateProjectFirewallEndpoint(firewallEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateProjectFirewallEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectFirewallEndpointAsync</summary>
        public async Task UpdateProjectFirewallEndpointAsync()
        {
            // Snippet: UpdateProjectFirewallEndpointAsync(FirewallEndpoint, FieldMask, CallSettings)
            // Additional: UpdateProjectFirewallEndpointAsync(FirewallEndpoint, FieldMask, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpoint firewallEndpoint = new FirewallEndpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpoint, OperationMetadata> response = await firewallActivationClient.UpdateProjectFirewallEndpointAsync(firewallEndpoint, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpoint, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpoint, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateProjectFirewallEndpointAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpoint retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociations</summary>
        public void ListFirewallEndpointAssociationsRequestObject()
        {
            // Snippet: ListFirewallEndpointAssociations(ListFirewallEndpointAssociationsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociationsAsync</summary>
        public async Task ListFirewallEndpointAssociationsRequestObjectAsync()
        {
            // Snippet: ListFirewallEndpointAssociationsAsync(ListFirewallEndpointAssociationsRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallEndpointAssociationsRequest request = new ListFirewallEndpointAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociations</summary>
        public void ListFirewallEndpointAssociations()
        {
            // Snippet: ListFirewallEndpointAssociations(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociationsAsync</summary>
        public async Task ListFirewallEndpointAssociationsAsync()
        {
            // Snippet: ListFirewallEndpointAssociationsAsync(string, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociations</summary>
        public void ListFirewallEndpointAssociationsResourceNames()
        {
            // Snippet: ListFirewallEndpointAssociations(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirewallEndpointAssociationsAsync</summary>
        public async Task ListFirewallEndpointAssociationsResourceNamesAsync()
        {
            // Snippet: ListFirewallEndpointAssociationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFirewallEndpointAssociationsResponse, FirewallEndpointAssociation> response = firewallActivationClient.ListFirewallEndpointAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FirewallEndpointAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFirewallEndpointAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallEndpointAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallEndpointAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallEndpointAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociation</summary>
        public void GetFirewallEndpointAssociationRequestObject()
        {
            // Snippet: GetFirewallEndpointAssociation(GetFirewallEndpointAssociationRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            GetFirewallEndpointAssociationRequest request = new GetFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]"),
            };
            // Make the request
            FirewallEndpointAssociation response = firewallActivationClient.GetFirewallEndpointAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociationAsync</summary>
        public async Task GetFirewallEndpointAssociationRequestObjectAsync()
        {
            // Snippet: GetFirewallEndpointAssociationAsync(GetFirewallEndpointAssociationRequest, CallSettings)
            // Additional: GetFirewallEndpointAssociationAsync(GetFirewallEndpointAssociationRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallEndpointAssociationRequest request = new GetFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]"),
            };
            // Make the request
            FirewallEndpointAssociation response = await firewallActivationClient.GetFirewallEndpointAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociation</summary>
        public void GetFirewallEndpointAssociation()
        {
            // Snippet: GetFirewallEndpointAssociation(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/firewallEndpointAssociations/[FIREWALL_ENDPOINT_ASSOCIATION]";
            // Make the request
            FirewallEndpointAssociation response = firewallActivationClient.GetFirewallEndpointAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociationAsync</summary>
        public async Task GetFirewallEndpointAssociationAsync()
        {
            // Snippet: GetFirewallEndpointAssociationAsync(string, CallSettings)
            // Additional: GetFirewallEndpointAssociationAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/firewallEndpointAssociations/[FIREWALL_ENDPOINT_ASSOCIATION]";
            // Make the request
            FirewallEndpointAssociation response = await firewallActivationClient.GetFirewallEndpointAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociation</summary>
        public void GetFirewallEndpointAssociationResourceNames()
        {
            // Snippet: GetFirewallEndpointAssociation(FirewallEndpointAssociationName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointAssociationName name = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]");
            // Make the request
            FirewallEndpointAssociation response = firewallActivationClient.GetFirewallEndpointAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetFirewallEndpointAssociationAsync</summary>
        public async Task GetFirewallEndpointAssociationResourceNamesAsync()
        {
            // Snippet: GetFirewallEndpointAssociationAsync(FirewallEndpointAssociationName, CallSettings)
            // Additional: GetFirewallEndpointAssociationAsync(FirewallEndpointAssociationName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointAssociationName name = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]");
            // Make the request
            FirewallEndpointAssociation response = await firewallActivationClient.GetFirewallEndpointAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociation</summary>
        public void CreateFirewallEndpointAssociationRequestObject()
        {
            // Snippet: CreateFirewallEndpointAssociation(CreateFirewallEndpointAssociationRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            CreateFirewallEndpointAssociationRequest request = new CreateFirewallEndpointAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FirewallEndpointAssociationId = "",
                FirewallEndpointAssociation = new FirewallEndpointAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpointAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociationAsync</summary>
        public async Task CreateFirewallEndpointAssociationRequestObjectAsync()
        {
            // Snippet: CreateFirewallEndpointAssociationAsync(CreateFirewallEndpointAssociationRequest, CallSettings)
            // Additional: CreateFirewallEndpointAssociationAsync(CreateFirewallEndpointAssociationRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            CreateFirewallEndpointAssociationRequest request = new CreateFirewallEndpointAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FirewallEndpointAssociationId = "",
                FirewallEndpointAssociation = new FirewallEndpointAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociation</summary>
        public void CreateFirewallEndpointAssociation()
        {
            // Snippet: CreateFirewallEndpointAssociation(string, FirewallEndpointAssociation, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            string firewallEndpointAssociationId = "";
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpointAssociation(parent, firewallEndpointAssociation, firewallEndpointAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociationAsync</summary>
        public async Task CreateFirewallEndpointAssociationAsync()
        {
            // Snippet: CreateFirewallEndpointAssociationAsync(string, FirewallEndpointAssociation, string, CallSettings)
            // Additional: CreateFirewallEndpointAssociationAsync(string, FirewallEndpointAssociation, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            string firewallEndpointAssociationId = "";
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAssociationAsync(parent, firewallEndpointAssociation, firewallEndpointAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociation</summary>
        public void CreateFirewallEndpointAssociationResourceNames()
        {
            // Snippet: CreateFirewallEndpointAssociation(LocationName, FirewallEndpointAssociation, string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            string firewallEndpointAssociationId = "";
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.CreateFirewallEndpointAssociation(parent, firewallEndpointAssociation, firewallEndpointAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceCreateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFirewallEndpointAssociationAsync</summary>
        public async Task CreateFirewallEndpointAssociationResourceNamesAsync()
        {
            // Snippet: CreateFirewallEndpointAssociationAsync(LocationName, FirewallEndpointAssociation, string, CallSettings)
            // Additional: CreateFirewallEndpointAssociationAsync(LocationName, FirewallEndpointAssociation, string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            string firewallEndpointAssociationId = "";
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = await firewallActivationClient.CreateFirewallEndpointAssociationAsync(parent, firewallEndpointAssociation, firewallEndpointAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceCreateFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociation</summary>
        public void DeleteFirewallEndpointAssociationRequestObject()
        {
            // Snippet: DeleteFirewallEndpointAssociation(DeleteFirewallEndpointAssociationRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            DeleteFirewallEndpointAssociationRequest request = new DeleteFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpointAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociationAsync</summary>
        public async Task DeleteFirewallEndpointAssociationRequestObjectAsync()
        {
            // Snippet: DeleteFirewallEndpointAssociationAsync(DeleteFirewallEndpointAssociationRequest, CallSettings)
            // Additional: DeleteFirewallEndpointAssociationAsync(DeleteFirewallEndpointAssociationRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallEndpointAssociationRequest request = new DeleteFirewallEndpointAssociationRequest
            {
                FirewallEndpointAssociationName = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociation</summary>
        public void DeleteFirewallEndpointAssociation()
        {
            // Snippet: DeleteFirewallEndpointAssociation(string, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/firewallEndpointAssociations/[FIREWALL_ENDPOINT_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpointAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociationAsync</summary>
        public async Task DeleteFirewallEndpointAssociationAsync()
        {
            // Snippet: DeleteFirewallEndpointAssociationAsync(string, CallSettings)
            // Additional: DeleteFirewallEndpointAssociationAsync(string, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/firewallEndpointAssociations/[FIREWALL_ENDPOINT_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociation</summary>
        public void DeleteFirewallEndpointAssociationResourceNames()
        {
            // Snippet: DeleteFirewallEndpointAssociation(FirewallEndpointAssociationName, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointAssociationName name = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = firewallActivationClient.DeleteFirewallEndpointAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceDeleteFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFirewallEndpointAssociationAsync</summary>
        public async Task DeleteFirewallEndpointAssociationResourceNamesAsync()
        {
            // Snippet: DeleteFirewallEndpointAssociationAsync(FirewallEndpointAssociationName, CallSettings)
            // Additional: DeleteFirewallEndpointAssociationAsync(FirewallEndpointAssociationName, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointAssociationName name = FirewallEndpointAssociationName.FromProjectLocationFirewallEndpointAssociation("[PROJECT]", "[LOCATION]", "[FIREWALL_ENDPOINT_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await firewallActivationClient.DeleteFirewallEndpointAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceDeleteFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAssociation</summary>
        public void UpdateFirewallEndpointAssociationRequestObject()
        {
            // Snippet: UpdateFirewallEndpointAssociation(UpdateFirewallEndpointAssociationRequest, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            UpdateFirewallEndpointAssociationRequest request = new UpdateFirewallEndpointAssociationRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpointAssociation = new FirewallEndpointAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.UpdateFirewallEndpointAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAssociationAsync</summary>
        public async Task UpdateFirewallEndpointAssociationRequestObjectAsync()
        {
            // Snippet: UpdateFirewallEndpointAssociationAsync(UpdateFirewallEndpointAssociationRequest, CallSettings)
            // Additional: UpdateFirewallEndpointAssociationAsync(UpdateFirewallEndpointAssociationRequest, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirewallEndpointAssociationRequest request = new UpdateFirewallEndpointAssociationRequest
            {
                UpdateMask = new FieldMask(),
                FirewallEndpointAssociation = new FirewallEndpointAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = await firewallActivationClient.UpdateFirewallEndpointAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAssociation</summary>
        public void UpdateFirewallEndpointAssociation()
        {
            // Snippet: UpdateFirewallEndpointAssociation(FirewallEndpointAssociation, FieldMask, CallSettings)
            // Create client
            FirewallActivationClient firewallActivationClient = FirewallActivationClient.Create();
            // Initialize request argument(s)
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = firewallActivationClient.UpdateFirewallEndpointAssociation(firewallEndpointAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = firewallActivationClient.PollOnceUpdateFirewallEndpointAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFirewallEndpointAssociationAsync</summary>
        public async Task UpdateFirewallEndpointAssociationAsync()
        {
            // Snippet: UpdateFirewallEndpointAssociationAsync(FirewallEndpointAssociation, FieldMask, CallSettings)
            // Additional: UpdateFirewallEndpointAssociationAsync(FirewallEndpointAssociation, FieldMask, CancellationToken)
            // Create client
            FirewallActivationClient firewallActivationClient = await FirewallActivationClient.CreateAsync();
            // Initialize request argument(s)
            FirewallEndpointAssociation firewallEndpointAssociation = new FirewallEndpointAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FirewallEndpointAssociation, OperationMetadata> response = await firewallActivationClient.UpdateFirewallEndpointAssociationAsync(firewallEndpointAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FirewallEndpointAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FirewallEndpointAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FirewallEndpointAssociation, OperationMetadata> retrievedResponse = await firewallActivationClient.PollOnceUpdateFirewallEndpointAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FirewallEndpointAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
