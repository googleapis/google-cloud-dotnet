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
    using Google.Cloud.GkeHub.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGkeHubClientSnippets
    {
        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsRequestObject()
        {
            // Snippet: ListMemberships(ListMembershipsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsRequestObjectAsync()
        {
            // Snippet: ListMembershipsAsync(ListMembershipsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMemberships()
        {
            // Snippet: ListMemberships(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsAsync()
        {
            // Snippet: ListMembershipsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsResourceNames()
        {
            // Snippet: ListMemberships(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsResourceNamesAsync()
        {
            // Snippet: ListMembershipsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = gkeHubClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMemberships</summary>
        public void ListBoundMembershipsRequestObject()
        {
            // Snippet: ListBoundMemberships(ListBoundMembershipsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeNameAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMembershipsAsync</summary>
        public async Task ListBoundMembershipsRequestObjectAsync()
        {
            // Snippet: ListBoundMembershipsAsync(ListBoundMembershipsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListBoundMembershipsRequest request = new ListBoundMembershipsRequest
            {
                ScopeNameAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMemberships</summary>
        public void ListBoundMemberships()
        {
            // Snippet: ListBoundMemberships(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string scopeName = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMemberships(scopeName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMembershipsAsync</summary>
        public async Task ListBoundMembershipsAsync()
        {
            // Snippet: ListBoundMembershipsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string scopeName = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMembershipsAsync(scopeName);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMemberships</summary>
        public void ListBoundMembershipsResourceNames()
        {
            // Snippet: ListBoundMemberships(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName scopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMemberships(scopeName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBoundMembershipsAsync</summary>
        public async Task ListBoundMembershipsResourceNamesAsync()
        {
            // Snippet: ListBoundMembershipsAsync(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName scopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedAsyncEnumerable<ListBoundMembershipsResponse, Membership> response = gkeHubClient.ListBoundMembershipsAsync(scopeName);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListBoundMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesRequestObject()
        {
            // Snippet: ListFeatures(ListFeaturesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeatures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesRequestObjectAsync()
        {
            // Snippet: ListFeaturesAsync(ListFeaturesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListFeaturesRequest request = new ListFeaturesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeaturesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeatures()
        {
            // Snippet: ListFeatures(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesAsync()
        {
            // Snippet: ListFeaturesAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeatures</summary>
        public void ListFeaturesResourceNames()
        {
            // Snippet: ListFeatures(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeatures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturesAsync</summary>
        public async Task ListFeaturesResourceNamesAsync()
        {
            // Snippet: ListFeaturesAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturesResponse, Feature> response = gkeHubClient.ListFeaturesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feature item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feature item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feature> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feature item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipRequestObject()
        {
            // Snippet: GetMembership(GetMembershipRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            // Make the request
            Membership response = gkeHubClient.GetMembership(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipRequestObjectAsync()
        {
            // Snippet: GetMembershipAsync(GetMembershipRequest, CallSettings)
            // Additional: GetMembershipAsync(GetMembershipRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
            };
            // Make the request
            Membership response = await gkeHubClient.GetMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembership()
        {
            // Snippet: GetMembership(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Membership response = gkeHubClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipAsync()
        {
            // Snippet: GetMembershipAsync(string, CallSettings)
            // Additional: GetMembershipAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Membership response = await gkeHubClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipResourceNames()
        {
            // Snippet: GetMembership(MembershipName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Membership response = gkeHubClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipResourceNamesAsync()
        {
            // Snippet: GetMembershipAsync(MembershipName, CallSettings)
            // Additional: GetMembershipAsync(MembershipName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Membership response = await gkeHubClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureRequestObject()
        {
            // Snippet: GetFeature(GetFeatureRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            Feature response = gkeHubClient.GetFeature(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureRequestObjectAsync()
        {
            // Snippet: GetFeatureAsync(GetFeatureRequest, CallSettings)
            // Additional: GetFeatureAsync(GetFeatureRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetFeatureRequest request = new GetFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            Feature response = await gkeHubClient.GetFeatureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeature()
        {
            // Snippet: GetFeature(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            // Make the request
            Feature response = gkeHubClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureAsync()
        {
            // Snippet: GetFeatureAsync(string, CallSettings)
            // Additional: GetFeatureAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            // Make the request
            Feature response = await gkeHubClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeature</summary>
        public void GetFeatureResourceNames()
        {
            // Snippet: GetFeature(FeatureName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            // Make the request
            Feature response = gkeHubClient.GetFeature(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeatureAsync</summary>
        public async Task GetFeatureResourceNamesAsync()
        {
            // Snippet: GetFeatureAsync(FeatureName, CallSettings)
            // Additional: GetFeatureAsync(FeatureName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            // Make the request
            Feature response = await gkeHubClient.GetFeatureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipRequestObject()
        {
            // Snippet: CreateMembership(CreateMembershipRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MembershipId = "",
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.CreateMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipRequestObjectAsync()
        {
            // Snippet: CreateMembershipAsync(CreateMembershipRequest, CallSettings)
            // Additional: CreateMembershipAsync(CreateMembershipRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MembershipId = "",
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.CreateMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembership()
        {
            // Snippet: CreateMembership(string, Membership, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.CreateMembership(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipAsync()
        {
            // Snippet: CreateMembershipAsync(string, Membership, string, CallSettings)
            // Additional: CreateMembershipAsync(string, Membership, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.CreateMembershipAsync(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipResourceNames()
        {
            // Snippet: CreateMembership(LocationName, Membership, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.CreateMembership(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipResourceNamesAsync()
        {
            // Snippet: CreateMembershipAsync(LocationName, Membership, string, CallSettings)
            // Additional: CreateMembershipAsync(LocationName, Membership, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Membership resource = new Membership();
            string membershipId = "";
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.CreateMembershipAsync(parent, resource, membershipId);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureRequestObject()
        {
            // Snippet: CreateFeature(CreateFeatureRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureId = "",
                Resource = new Feature(),
                RequestId = "",
            };
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.CreateFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureRequestObjectAsync()
        {
            // Snippet: CreateFeatureAsync(CreateFeatureRequest, CallSettings)
            // Additional: CreateFeatureAsync(CreateFeatureRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureRequest request = new CreateFeatureRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureId = "",
                Resource = new Feature(),
                RequestId = "",
            };
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.CreateFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeature()
        {
            // Snippet: CreateFeature(string, Feature, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Feature resource = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.CreateFeature(parent, resource, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureAsync()
        {
            // Snippet: CreateFeatureAsync(string, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(string, Feature, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Feature resource = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.CreateFeatureAsync(parent, resource, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeature</summary>
        public void CreateFeatureResourceNames()
        {
            // Snippet: CreateFeature(LocationName, Feature, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Feature resource = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.CreateFeature(parent, resource, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFeatureAsync</summary>
        public async Task CreateFeatureResourceNamesAsync()
        {
            // Snippet: CreateFeatureAsync(LocationName, Feature, string, CallSettings)
            // Additional: CreateFeatureAsync(LocationName, Feature, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Feature resource = new Feature();
            string featureId = "";
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.CreateFeatureAsync(parent, resource, featureId);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipRequestObject()
        {
            // Snippet: DeleteMembership(DeleteMembershipRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipRequestObjectAsync()
        {
            // Snippet: DeleteMembershipAsync(DeleteMembershipRequest, CallSettings)
            // Additional: DeleteMembershipAsync(DeleteMembershipRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembership()
        {
            // Snippet: DeleteMembership(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembership(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipAsync()
        {
            // Snippet: DeleteMembershipAsync(string, CallSettings)
            // Additional: DeleteMembershipAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipResourceNames()
        {
            // Snippet: DeleteMembership(MembershipName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembership(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipResourceNamesAsync()
        {
            // Snippet: DeleteMembershipAsync(MembershipName, CallSettings)
            // Additional: DeleteMembershipAsync(MembershipName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureRequestObject()
        {
            // Snippet: DeleteFeature(DeleteFeatureRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Force = false,
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureRequestObjectAsync()
        {
            // Snippet: DeleteFeatureAsync(DeleteFeatureRequest, CallSettings)
            // Additional: DeleteFeatureAsync(DeleteFeatureRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureRequest request = new DeleteFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                Force = false,
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeature()
        {
            // Snippet: DeleteFeature(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureAsync()
        {
            // Snippet: DeleteFeatureAsync(string, CallSettings)
            // Additional: DeleteFeatureAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeature</summary>
        public void DeleteFeatureResourceNames()
        {
            // Snippet: DeleteFeature(FeatureName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFeature(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFeatureAsync</summary>
        public async Task DeleteFeatureResourceNamesAsync()
        {
            // Snippet: DeleteFeatureAsync(FeatureName, CallSettings)
            // Additional: DeleteFeatureAsync(FeatureName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFeatureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembershipRequestObject()
        {
            // Snippet: UpdateMembership(UpdateMembershipRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                UpdateMask = new FieldMask(),
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.UpdateMembership(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipRequestObjectAsync()
        {
            // Snippet: UpdateMembershipAsync(UpdateMembershipRequest, CallSettings)
            // Additional: UpdateMembershipAsync(UpdateMembershipRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                UpdateMask = new FieldMask(),
                Resource = new Membership(),
                RequestId = "",
            };
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.UpdateMembershipAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembership()
        {
            // Snippet: UpdateMembership(string, Membership, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.UpdateMembership(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipAsync()
        {
            // Snippet: UpdateMembershipAsync(string, Membership, FieldMask, CallSettings)
            // Additional: UpdateMembershipAsync(string, Membership, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.UpdateMembershipAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembershipResourceNames()
        {
            // Snippet: UpdateMembership(MembershipName, Membership, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = gkeHubClient.UpdateMembership(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembership(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipResourceNamesAsync()
        {
            // Snippet: UpdateMembershipAsync(MembershipName, Membership, FieldMask, CallSettings)
            // Additional: UpdateMembershipAsync(MembershipName, Membership, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            Membership resource = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Membership, OperationMetadata> response = await gkeHubClient.UpdateMembershipAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Membership, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Membership result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Membership, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Membership retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeatureRequestObject()
        {
            // Snippet: UpdateFeature(UpdateFeatureRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                UpdateMask = new FieldMask(),
                Resource = new Feature(),
                RequestId = "",
            };
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.UpdateFeature(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureRequestObjectAsync()
        {
            // Snippet: UpdateFeatureAsync(UpdateFeatureRequest, CallSettings)
            // Additional: UpdateFeatureAsync(UpdateFeatureRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeatureRequest request = new UpdateFeatureRequest
            {
                FeatureName = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]"),
                UpdateMask = new FieldMask(),
                Resource = new Feature(),
                RequestId = "",
            };
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.UpdateFeatureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeature()
        {
            // Snippet: UpdateFeature(string, Feature, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            Feature resource = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.UpdateFeature(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureAsync()
        {
            // Snippet: UpdateFeatureAsync(string, Feature, FieldMask, CallSettings)
            // Additional: UpdateFeatureAsync(string, Feature, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/features/[FEATURE]";
            Feature resource = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.UpdateFeatureAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeature</summary>
        public void UpdateFeatureResourceNames()
        {
            // Snippet: UpdateFeature(FeatureName, Feature, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            Feature resource = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, OperationMetadata> response = gkeHubClient.UpdateFeature(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateFeature(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFeatureAsync</summary>
        public async Task UpdateFeatureResourceNamesAsync()
        {
            // Snippet: UpdateFeatureAsync(FeatureName, Feature, FieldMask, CallSettings)
            // Additional: UpdateFeatureAsync(FeatureName, Feature, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            Feature resource = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.UpdateFeatureAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateConnectManifest</summary>
        public void GenerateConnectManifestRequestObject()
        {
            // Snippet: GenerateConnectManifest(GenerateConnectManifestRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Namespace = "",
                Proxy = ByteString.Empty,
                Version = "",
                IsUpgrade = false,
                Registry = "",
                ImagePullSecretContent = ByteString.Empty,
            };
            // Make the request
            GenerateConnectManifestResponse response = gkeHubClient.GenerateConnectManifest(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConnectManifestAsync</summary>
        public async Task GenerateConnectManifestRequestObjectAsync()
        {
            // Snippet: GenerateConnectManifestAsync(GenerateConnectManifestRequest, CallSettings)
            // Additional: GenerateConnectManifestAsync(GenerateConnectManifestRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GenerateConnectManifestRequest request = new GenerateConnectManifestRequest
            {
                MembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Namespace = "",
                Proxy = ByteString.Empty,
                Version = "",
                IsUpgrade = false,
                Registry = "",
                ImagePullSecretContent = ByteString.Empty,
            };
            // Make the request
            GenerateConnectManifestResponse response = await gkeHubClient.GenerateConnectManifestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFleet</summary>
        public void CreateFleetRequestObject()
        {
            // Snippet: CreateFleet(CreateFleetRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateFleetRequest request = new CreateFleetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Fleet = new Fleet(),
            };
            // Make the request
            Operation<Fleet, OperationMetadata> response = gkeHubClient.CreateFleet(request);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetAsync</summary>
        public async Task CreateFleetRequestObjectAsync()
        {
            // Snippet: CreateFleetAsync(CreateFleetRequest, CallSettings)
            // Additional: CreateFleetAsync(CreateFleetRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateFleetRequest request = new CreateFleetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Fleet = new Fleet(),
            };
            // Make the request
            Operation<Fleet, OperationMetadata> response = await gkeHubClient.CreateFleetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleet</summary>
        public void CreateFleet()
        {
            // Snippet: CreateFleet(string, Fleet, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Fleet fleet = new Fleet();
            // Make the request
            Operation<Fleet, OperationMetadata> response = gkeHubClient.CreateFleet(parent, fleet);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetAsync</summary>
        public async Task CreateFleetAsync()
        {
            // Snippet: CreateFleetAsync(string, Fleet, CallSettings)
            // Additional: CreateFleetAsync(string, Fleet, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Fleet fleet = new Fleet();
            // Make the request
            Operation<Fleet, OperationMetadata> response = await gkeHubClient.CreateFleetAsync(parent, fleet);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleet</summary>
        public void CreateFleetResourceNames()
        {
            // Snippet: CreateFleet(LocationName, Fleet, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Fleet fleet = new Fleet();
            // Make the request
            Operation<Fleet, OperationMetadata> response = gkeHubClient.CreateFleet(parent, fleet);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFleetAsync</summary>
        public async Task CreateFleetResourceNamesAsync()
        {
            // Snippet: CreateFleetAsync(LocationName, Fleet, CallSettings)
            // Additional: CreateFleetAsync(LocationName, Fleet, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Fleet fleet = new Fleet();
            // Make the request
            Operation<Fleet, OperationMetadata> response = await gkeHubClient.CreateFleetAsync(parent, fleet);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetFleet</summary>
        public void GetFleetRequestObject()
        {
            // Snippet: GetFleet(GetFleetRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetFleetRequest request = new GetFleetRequest
            {
                FleetName = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]"),
            };
            // Make the request
            Fleet response = gkeHubClient.GetFleet(request);
            // End snippet
        }

        /// <summary>Snippet for GetFleetAsync</summary>
        public async Task GetFleetRequestObjectAsync()
        {
            // Snippet: GetFleetAsync(GetFleetRequest, CallSettings)
            // Additional: GetFleetAsync(GetFleetRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetFleetRequest request = new GetFleetRequest
            {
                FleetName = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]"),
            };
            // Make the request
            Fleet response = await gkeHubClient.GetFleetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFleet</summary>
        public void GetFleet()
        {
            // Snippet: GetFleet(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleets/[FLEET]";
            // Make the request
            Fleet response = gkeHubClient.GetFleet(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleetAsync</summary>
        public async Task GetFleetAsync()
        {
            // Snippet: GetFleetAsync(string, CallSettings)
            // Additional: GetFleetAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleets/[FLEET]";
            // Make the request
            Fleet response = await gkeHubClient.GetFleetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleet</summary>
        public void GetFleetResourceNames()
        {
            // Snippet: GetFleet(FleetName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            FleetName name = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]");
            // Make the request
            Fleet response = gkeHubClient.GetFleet(name);
            // End snippet
        }

        /// <summary>Snippet for GetFleetAsync</summary>
        public async Task GetFleetResourceNamesAsync()
        {
            // Snippet: GetFleetAsync(FleetName, CallSettings)
            // Additional: GetFleetAsync(FleetName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FleetName name = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]");
            // Make the request
            Fleet response = await gkeHubClient.GetFleetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFleet</summary>
        public void UpdateFleetRequestObject()
        {
            // Snippet: UpdateFleet(UpdateFleetRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateFleetRequest request = new UpdateFleetRequest
            {
                Fleet = new Fleet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Fleet, OperationMetadata> response = gkeHubClient.UpdateFleet(request);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetAsync</summary>
        public async Task UpdateFleetRequestObjectAsync()
        {
            // Snippet: UpdateFleetAsync(UpdateFleetRequest, CallSettings)
            // Additional: UpdateFleetAsync(UpdateFleetRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFleetRequest request = new UpdateFleetRequest
            {
                Fleet = new Fleet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Fleet, OperationMetadata> response = await gkeHubClient.UpdateFleetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleet</summary>
        public void UpdateFleet()
        {
            // Snippet: UpdateFleet(Fleet, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            Fleet fleet = new Fleet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Fleet, OperationMetadata> response = gkeHubClient.UpdateFleet(fleet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFleetAsync</summary>
        public async Task UpdateFleetAsync()
        {
            // Snippet: UpdateFleetAsync(Fleet, FieldMask, CallSettings)
            // Additional: UpdateFleetAsync(Fleet, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            Fleet fleet = new Fleet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Fleet, OperationMetadata> response = await gkeHubClient.UpdateFleetAsync(fleet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Fleet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Fleet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Fleet, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Fleet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleet</summary>
        public void DeleteFleetRequestObject()
        {
            // Snippet: DeleteFleet(DeleteFleetRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteFleetRequest request = new DeleteFleetRequest
            {
                FleetName = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFleet(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetAsync</summary>
        public async Task DeleteFleetRequestObjectAsync()
        {
            // Snippet: DeleteFleetAsync(DeleteFleetRequest, CallSettings)
            // Additional: DeleteFleetAsync(DeleteFleetRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFleetRequest request = new DeleteFleetRequest
            {
                FleetName = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFleetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleet</summary>
        public void DeleteFleet()
        {
            // Snippet: DeleteFleet(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleets/[FLEET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFleet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetAsync</summary>
        public async Task DeleteFleetAsync()
        {
            // Snippet: DeleteFleetAsync(string, CallSettings)
            // Additional: DeleteFleetAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/fleets/[FLEET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFleetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleet</summary>
        public void DeleteFleetResourceNames()
        {
            // Snippet: DeleteFleet(FleetName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            FleetName name = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteFleet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteFleet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFleetAsync</summary>
        public async Task DeleteFleetResourceNamesAsync()
        {
            // Snippet: DeleteFleetAsync(FleetName, CallSettings)
            // Additional: DeleteFleetAsync(FleetName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FleetName name = FleetName.FromProjectLocationFleet("[PROJECT]", "[LOCATION]", "[FLEET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteFleetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteFleetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFleets</summary>
        public void ListFleetsRequestObject()
        {
            // Snippet: ListFleets(ListFleetsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListFleetsRequest request = new ListFleetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetsAsync</summary>
        public async Task ListFleetsRequestObjectAsync()
        {
            // Snippet: ListFleetsAsync(ListFleetsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListFleetsRequest request = new ListFleetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleets</summary>
        public void ListFleets()
        {
            // Snippet: ListFleets(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetsAsync</summary>
        public async Task ListFleetsAsync()
        {
            // Snippet: ListFleetsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleets</summary>
        public void ListFleetsResourceNames()
        {
            // Snippet: ListFleets(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFleetsAsync</summary>
        public async Task ListFleetsResourceNamesAsync()
        {
            // Snippet: ListFleetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFleetsResponse, Fleet> response = gkeHubClient.ListFleetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Fleet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFleetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Fleet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Fleet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Fleet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespace</summary>
        public void GetScopeNamespaceRequestObject()
        {
            // Snippet: GetScopeNamespace(GetScopeNamespaceRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetScopeNamespaceRequest request = new GetScopeNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]"),
            };
            // Make the request
            Namespace response = gkeHubClient.GetScopeNamespace(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespaceAsync</summary>
        public async Task GetScopeNamespaceRequestObjectAsync()
        {
            // Snippet: GetScopeNamespaceAsync(GetScopeNamespaceRequest, CallSettings)
            // Additional: GetScopeNamespaceAsync(GetScopeNamespaceRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetScopeNamespaceRequest request = new GetScopeNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]"),
            };
            // Make the request
            Namespace response = await gkeHubClient.GetScopeNamespaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespace</summary>
        public void GetScopeNamespace()
        {
            // Snippet: GetScopeNamespace(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/namespaces/[NAMESPACE]";
            // Make the request
            Namespace response = gkeHubClient.GetScopeNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespaceAsync</summary>
        public async Task GetScopeNamespaceAsync()
        {
            // Snippet: GetScopeNamespaceAsync(string, CallSettings)
            // Additional: GetScopeNamespaceAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/namespaces/[NAMESPACE]";
            // Make the request
            Namespace response = await gkeHubClient.GetScopeNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespace</summary>
        public void GetScopeNamespaceResourceNames()
        {
            // Snippet: GetScopeNamespace(NamespaceName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]");
            // Make the request
            Namespace response = gkeHubClient.GetScopeNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeNamespaceAsync</summary>
        public async Task GetScopeNamespaceResourceNamesAsync()
        {
            // Snippet: GetScopeNamespaceAsync(NamespaceName, CallSettings)
            // Additional: GetScopeNamespaceAsync(NamespaceName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]");
            // Make the request
            Namespace response = await gkeHubClient.GetScopeNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespace</summary>
        public void CreateScopeNamespaceRequestObject()
        {
            // Snippet: CreateScopeNamespace(CreateScopeNamespaceRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateScopeNamespaceRequest request = new CreateScopeNamespaceRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                ScopeNamespaceId = "",
                ScopeNamespace = new Namespace(),
            };
            // Make the request
            Operation<Namespace, OperationMetadata> response = gkeHubClient.CreateScopeNamespace(request);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespaceAsync</summary>
        public async Task CreateScopeNamespaceRequestObjectAsync()
        {
            // Snippet: CreateScopeNamespaceAsync(CreateScopeNamespaceRequest, CallSettings)
            // Additional: CreateScopeNamespaceAsync(CreateScopeNamespaceRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateScopeNamespaceRequest request = new CreateScopeNamespaceRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                ScopeNamespaceId = "",
                ScopeNamespace = new Namespace(),
            };
            // Make the request
            Operation<Namespace, OperationMetadata> response = await gkeHubClient.CreateScopeNamespaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespace</summary>
        public void CreateScopeNamespace()
        {
            // Snippet: CreateScopeNamespace(string, Namespace, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            Namespace scopeNamespace = new Namespace();
            string scopeNamespaceId = "";
            // Make the request
            Operation<Namespace, OperationMetadata> response = gkeHubClient.CreateScopeNamespace(parent, scopeNamespace, scopeNamespaceId);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespaceAsync</summary>
        public async Task CreateScopeNamespaceAsync()
        {
            // Snippet: CreateScopeNamespaceAsync(string, Namespace, string, CallSettings)
            // Additional: CreateScopeNamespaceAsync(string, Namespace, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            Namespace scopeNamespace = new Namespace();
            string scopeNamespaceId = "";
            // Make the request
            Operation<Namespace, OperationMetadata> response = await gkeHubClient.CreateScopeNamespaceAsync(parent, scopeNamespace, scopeNamespaceId);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespace</summary>
        public void CreateScopeNamespaceResourceNames()
        {
            // Snippet: CreateScopeNamespace(ScopeName, Namespace, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            Namespace scopeNamespace = new Namespace();
            string scopeNamespaceId = "";
            // Make the request
            Operation<Namespace, OperationMetadata> response = gkeHubClient.CreateScopeNamespace(parent, scopeNamespace, scopeNamespaceId);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeNamespaceAsync</summary>
        public async Task CreateScopeNamespaceResourceNamesAsync()
        {
            // Snippet: CreateScopeNamespaceAsync(ScopeName, Namespace, string, CallSettings)
            // Additional: CreateScopeNamespaceAsync(ScopeName, Namespace, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            Namespace scopeNamespace = new Namespace();
            string scopeNamespaceId = "";
            // Make the request
            Operation<Namespace, OperationMetadata> response = await gkeHubClient.CreateScopeNamespaceAsync(parent, scopeNamespace, scopeNamespaceId);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeNamespace</summary>
        public void UpdateScopeNamespaceRequestObject()
        {
            // Snippet: UpdateScopeNamespace(UpdateScopeNamespaceRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateScopeNamespaceRequest request = new UpdateScopeNamespaceRequest
            {
                ScopeNamespace = new Namespace(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Namespace, OperationMetadata> response = gkeHubClient.UpdateScopeNamespace(request);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeNamespaceAsync</summary>
        public async Task UpdateScopeNamespaceRequestObjectAsync()
        {
            // Snippet: UpdateScopeNamespaceAsync(UpdateScopeNamespaceRequest, CallSettings)
            // Additional: UpdateScopeNamespaceAsync(UpdateScopeNamespaceRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScopeNamespaceRequest request = new UpdateScopeNamespaceRequest
            {
                ScopeNamespace = new Namespace(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Namespace, OperationMetadata> response = await gkeHubClient.UpdateScopeNamespaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeNamespace</summary>
        public void UpdateScopeNamespace()
        {
            // Snippet: UpdateScopeNamespace(Namespace, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            Namespace scopeNamespace = new Namespace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Namespace, OperationMetadata> response = gkeHubClient.UpdateScopeNamespace(scopeNamespace, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeNamespaceAsync</summary>
        public async Task UpdateScopeNamespaceAsync()
        {
            // Snippet: UpdateScopeNamespaceAsync(Namespace, FieldMask, CallSettings)
            // Additional: UpdateScopeNamespaceAsync(Namespace, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            Namespace scopeNamespace = new Namespace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Namespace, OperationMetadata> response = await gkeHubClient.UpdateScopeNamespaceAsync(scopeNamespace, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Namespace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Namespace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Namespace, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Namespace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespace</summary>
        public void DeleteScopeNamespaceRequestObject()
        {
            // Snippet: DeleteScopeNamespace(DeleteScopeNamespaceRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteScopeNamespaceRequest request = new DeleteScopeNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeNamespace(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespaceAsync</summary>
        public async Task DeleteScopeNamespaceRequestObjectAsync()
        {
            // Snippet: DeleteScopeNamespaceAsync(DeleteScopeNamespaceRequest, CallSettings)
            // Additional: DeleteScopeNamespaceAsync(DeleteScopeNamespaceRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScopeNamespaceRequest request = new DeleteScopeNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeNamespaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespace</summary>
        public void DeleteScopeNamespace()
        {
            // Snippet: DeleteScopeNamespace(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/namespaces/[NAMESPACE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeNamespace(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespaceAsync</summary>
        public async Task DeleteScopeNamespaceAsync()
        {
            // Snippet: DeleteScopeNamespaceAsync(string, CallSettings)
            // Additional: DeleteScopeNamespaceAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/namespaces/[NAMESPACE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeNamespaceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespace</summary>
        public void DeleteScopeNamespaceResourceNames()
        {
            // Snippet: DeleteScopeNamespace(NamespaceName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeNamespace(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeNamespace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeNamespaceAsync</summary>
        public async Task DeleteScopeNamespaceResourceNamesAsync()
        {
            // Snippet: DeleteScopeNamespaceAsync(NamespaceName, CallSettings)
            // Additional: DeleteScopeNamespaceAsync(NamespaceName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationScopeNamespace("[PROJECT]", "[LOCATION]", "[SCOPE]", "[NAMESPACE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeNamespaceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeNamespaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespaces</summary>
        public void ListScopeNamespacesRequestObject()
        {
            // Snippet: ListScopeNamespaces(ListScopeNamespacesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespacesAsync</summary>
        public async Task ListScopeNamespacesRequestObjectAsync()
        {
            // Snippet: ListScopeNamespacesAsync(ListScopeNamespacesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListScopeNamespacesRequest request = new ListScopeNamespacesRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespaces</summary>
        public void ListScopeNamespaces()
        {
            // Snippet: ListScopeNamespaces(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespacesAsync</summary>
        public async Task ListScopeNamespacesAsync()
        {
            // Snippet: ListScopeNamespacesAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespaces</summary>
        public void ListScopeNamespacesResourceNames()
        {
            // Snippet: ListScopeNamespaces(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeNamespacesAsync</summary>
        public async Task ListScopeNamespacesResourceNamesAsync()
        {
            // Snippet: ListScopeNamespacesAsync(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedAsyncEnumerable<ListScopeNamespacesResponse, Namespace> response = gkeHubClient.ListScopeNamespacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBinding</summary>
        public void GetScopeRBACRoleBindingRequestObject()
        {
            // Snippet: GetScopeRBACRoleBinding(GetScopeRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetScopeRBACRoleBindingRequest request = new GetScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetScopeRBACRoleBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBindingAsync</summary>
        public async Task GetScopeRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: GetScopeRBACRoleBindingAsync(GetScopeRBACRoleBindingRequest, CallSettings)
            // Additional: GetScopeRBACRoleBindingAsync(GetScopeRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetScopeRBACRoleBindingRequest request = new GetScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetScopeRBACRoleBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBinding</summary>
        public void GetScopeRBACRoleBinding()
        {
            // Snippet: GetScopeRBACRoleBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetScopeRBACRoleBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBindingAsync</summary>
        public async Task GetScopeRBACRoleBindingAsync()
        {
            // Snippet: GetScopeRBACRoleBindingAsync(string, CallSettings)
            // Additional: GetScopeRBACRoleBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetScopeRBACRoleBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBinding</summary>
        public void GetScopeRBACRoleBindingResourceNames()
        {
            // Snippet: GetScopeRBACRoleBinding(RBACRoleBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetScopeRBACRoleBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeRBACRoleBindingAsync</summary>
        public async Task GetScopeRBACRoleBindingResourceNamesAsync()
        {
            // Snippet: GetScopeRBACRoleBindingAsync(RBACRoleBindingName, CallSettings)
            // Additional: GetScopeRBACRoleBindingAsync(RBACRoleBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetScopeRBACRoleBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBinding</summary>
        public void CreateScopeRBACRoleBindingRequestObject()
        {
            // Snippet: CreateScopeRBACRoleBinding(CreateScopeRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateScopeRBACRoleBindingRequest request = new CreateScopeRBACRoleBindingRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateScopeRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBindingAsync</summary>
        public async Task CreateScopeRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: CreateScopeRBACRoleBindingAsync(CreateScopeRBACRoleBindingRequest, CallSettings)
            // Additional: CreateScopeRBACRoleBindingAsync(CreateScopeRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateScopeRBACRoleBindingRequest request = new CreateScopeRBACRoleBindingRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateScopeRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBinding</summary>
        public void CreateScopeRBACRoleBinding()
        {
            // Snippet: CreateScopeRBACRoleBinding(string, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateScopeRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBindingAsync</summary>
        public async Task CreateScopeRBACRoleBindingAsync()
        {
            // Snippet: CreateScopeRBACRoleBindingAsync(string, RBACRoleBinding, string, CallSettings)
            // Additional: CreateScopeRBACRoleBindingAsync(string, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBinding</summary>
        public void CreateScopeRBACRoleBindingResourceNames1()
        {
            // Snippet: CreateScopeRBACRoleBinding(ScopeName, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateScopeRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBindingAsync</summary>
        public async Task CreateScopeRBACRoleBindingResourceNames1Async()
        {
            // Snippet: CreateScopeRBACRoleBindingAsync(ScopeName, RBACRoleBinding, string, CallSettings)
            // Additional: CreateScopeRBACRoleBindingAsync(ScopeName, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBinding</summary>
        public void CreateScopeRBACRoleBindingResourceNames2()
        {
            // Snippet: CreateScopeRBACRoleBinding(MembershipName, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateScopeRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeRBACRoleBindingAsync</summary>
        public async Task CreateScopeRBACRoleBindingResourceNames2Async()
        {
            // Snippet: CreateScopeRBACRoleBindingAsync(MembershipName, RBACRoleBinding, string, CallSettings)
            // Additional: CreateScopeRBACRoleBindingAsync(MembershipName, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateScopeRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeRBACRoleBinding</summary>
        public void UpdateScopeRBACRoleBindingRequestObject()
        {
            // Snippet: UpdateScopeRBACRoleBinding(UpdateScopeRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateScopeRBACRoleBindingRequest request = new UpdateScopeRBACRoleBindingRequest
            {
                Rbacrolebinding = new RBACRoleBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.UpdateScopeRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeRBACRoleBindingAsync</summary>
        public async Task UpdateScopeRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: UpdateScopeRBACRoleBindingAsync(UpdateScopeRBACRoleBindingRequest, CallSettings)
            // Additional: UpdateScopeRBACRoleBindingAsync(UpdateScopeRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScopeRBACRoleBindingRequest request = new UpdateScopeRBACRoleBindingRequest
            {
                Rbacrolebinding = new RBACRoleBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.UpdateScopeRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeRBACRoleBinding</summary>
        public void UpdateScopeRBACRoleBinding()
        {
            // Snippet: UpdateScopeRBACRoleBinding(RBACRoleBinding, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.UpdateScopeRBACRoleBinding(rbacrolebinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeRBACRoleBindingAsync</summary>
        public async Task UpdateScopeRBACRoleBindingAsync()
        {
            // Snippet: UpdateScopeRBACRoleBindingAsync(RBACRoleBinding, FieldMask, CallSettings)
            // Additional: UpdateScopeRBACRoleBindingAsync(RBACRoleBinding, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.UpdateScopeRBACRoleBindingAsync(rbacrolebinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBinding</summary>
        public void DeleteScopeRBACRoleBindingRequestObject()
        {
            // Snippet: DeleteScopeRBACRoleBinding(DeleteScopeRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteScopeRBACRoleBindingRequest request = new DeleteScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBindingAsync</summary>
        public async Task DeleteScopeRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: DeleteScopeRBACRoleBindingAsync(DeleteScopeRBACRoleBindingRequest, CallSettings)
            // Additional: DeleteScopeRBACRoleBindingAsync(DeleteScopeRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScopeRBACRoleBindingRequest request = new DeleteScopeRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBinding</summary>
        public void DeleteScopeRBACRoleBinding()
        {
            // Snippet: DeleteScopeRBACRoleBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeRBACRoleBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBindingAsync</summary>
        public async Task DeleteScopeRBACRoleBindingAsync()
        {
            // Snippet: DeleteScopeRBACRoleBindingAsync(string, CallSettings)
            // Additional: DeleteScopeRBACRoleBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeRBACRoleBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBinding</summary>
        public void DeleteScopeRBACRoleBindingResourceNames()
        {
            // Snippet: DeleteScopeRBACRoleBinding(RBACRoleBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScopeRBACRoleBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScopeRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeRBACRoleBindingAsync</summary>
        public async Task DeleteScopeRBACRoleBindingResourceNamesAsync()
        {
            // Snippet: DeleteScopeRBACRoleBindingAsync(RBACRoleBindingName, CallSettings)
            // Additional: DeleteScopeRBACRoleBindingAsync(RBACRoleBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeRBACRoleBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindings</summary>
        public void ListScopeRBACRoleBindingsRequestObject()
        {
            // Snippet: ListScopeRBACRoleBindings(ListScopeRBACRoleBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindingsAsync</summary>
        public async Task ListScopeRBACRoleBindingsRequestObjectAsync()
        {
            // Snippet: ListScopeRBACRoleBindingsAsync(ListScopeRBACRoleBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListScopeRBACRoleBindingsRequest request = new ListScopeRBACRoleBindingsRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindings</summary>
        public void ListScopeRBACRoleBindings()
        {
            // Snippet: ListScopeRBACRoleBindings(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindingsAsync</summary>
        public async Task ListScopeRBACRoleBindingsAsync()
        {
            // Snippet: ListScopeRBACRoleBindingsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindings</summary>
        public void ListScopeRBACRoleBindingsResourceNames1()
        {
            // Snippet: ListScopeRBACRoleBindings(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindingsAsync</summary>
        public async Task ListScopeRBACRoleBindingsResourceNames1Async()
        {
            // Snippet: ListScopeRBACRoleBindingsAsync(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindings</summary>
        public void ListScopeRBACRoleBindingsResourceNames2()
        {
            // Snippet: ListScopeRBACRoleBindings(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopeRBACRoleBindingsAsync</summary>
        public async Task ListScopeRBACRoleBindingsResourceNames2Async()
        {
            // Snippet: ListScopeRBACRoleBindingsAsync(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedAsyncEnumerable<ListScopeRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListScopeRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopeRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetScope</summary>
        public void GetScopeRequestObject()
        {
            // Snippet: GetScope(GetScopeRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetScopeRequest request = new GetScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Scope response = gkeHubClient.GetScope(request);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeRequestObjectAsync()
        {
            // Snippet: GetScopeAsync(GetScopeRequest, CallSettings)
            // Additional: GetScopeAsync(GetScopeRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetScopeRequest request = new GetScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Scope response = await gkeHubClient.GetScopeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetScope</summary>
        public void GetScope()
        {
            // Snippet: GetScope(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Scope response = gkeHubClient.GetScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeAsync()
        {
            // Snippet: GetScopeAsync(string, CallSettings)
            // Additional: GetScopeAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Scope response = await gkeHubClient.GetScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetScope</summary>
        public void GetScopeResourceNames()
        {
            // Snippet: GetScope(ScopeName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Scope response = gkeHubClient.GetScope(name);
            // End snippet
        }

        /// <summary>Snippet for GetScopeAsync</summary>
        public async Task GetScopeResourceNamesAsync()
        {
            // Snippet: GetScopeAsync(ScopeName, CallSettings)
            // Additional: GetScopeAsync(ScopeName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Scope response = await gkeHubClient.GetScopeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateScope</summary>
        public void CreateScopeRequestObject()
        {
            // Snippet: CreateScope(CreateScopeRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateScopeRequest request = new CreateScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ScopeId = "",
                Scope = new Scope(),
            };
            // Make the request
            Operation<Scope, OperationMetadata> response = gkeHubClient.CreateScope(request);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeAsync</summary>
        public async Task CreateScopeRequestObjectAsync()
        {
            // Snippet: CreateScopeAsync(CreateScopeRequest, CallSettings)
            // Additional: CreateScopeAsync(CreateScopeRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateScopeRequest request = new CreateScopeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ScopeId = "",
                Scope = new Scope(),
            };
            // Make the request
            Operation<Scope, OperationMetadata> response = await gkeHubClient.CreateScopeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScope</summary>
        public void CreateScope()
        {
            // Snippet: CreateScope(string, Scope, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Scope scope = new Scope();
            string scopeId = "";
            // Make the request
            Operation<Scope, OperationMetadata> response = gkeHubClient.CreateScope(parent, scope, scopeId);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeAsync</summary>
        public async Task CreateScopeAsync()
        {
            // Snippet: CreateScopeAsync(string, Scope, string, CallSettings)
            // Additional: CreateScopeAsync(string, Scope, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Scope scope = new Scope();
            string scopeId = "";
            // Make the request
            Operation<Scope, OperationMetadata> response = await gkeHubClient.CreateScopeAsync(parent, scope, scopeId);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScope</summary>
        public void CreateScopeResourceNames()
        {
            // Snippet: CreateScope(LocationName, Scope, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Scope scope = new Scope();
            string scopeId = "";
            // Make the request
            Operation<Scope, OperationMetadata> response = gkeHubClient.CreateScope(parent, scope, scopeId);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateScopeAsync</summary>
        public async Task CreateScopeResourceNamesAsync()
        {
            // Snippet: CreateScopeAsync(LocationName, Scope, string, CallSettings)
            // Additional: CreateScopeAsync(LocationName, Scope, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Scope scope = new Scope();
            string scopeId = "";
            // Make the request
            Operation<Scope, OperationMetadata> response = await gkeHubClient.CreateScopeAsync(parent, scope, scopeId);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScope</summary>
        public void UpdateScopeRequestObject()
        {
            // Snippet: UpdateScope(UpdateScopeRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateScopeRequest request = new UpdateScopeRequest
            {
                Scope = new Scope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Scope, OperationMetadata> response = gkeHubClient.UpdateScope(request);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeAsync</summary>
        public async Task UpdateScopeRequestObjectAsync()
        {
            // Snippet: UpdateScopeAsync(UpdateScopeRequest, CallSettings)
            // Additional: UpdateScopeAsync(UpdateScopeRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateScopeRequest request = new UpdateScopeRequest
            {
                Scope = new Scope(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Scope, OperationMetadata> response = await gkeHubClient.UpdateScopeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScope</summary>
        public void UpdateScope()
        {
            // Snippet: UpdateScope(Scope, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            Scope scope = new Scope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Scope, OperationMetadata> response = gkeHubClient.UpdateScope(scope, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateScopeAsync</summary>
        public async Task UpdateScopeAsync()
        {
            // Snippet: UpdateScopeAsync(Scope, FieldMask, CallSettings)
            // Additional: UpdateScopeAsync(Scope, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            Scope scope = new Scope();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Scope, OperationMetadata> response = await gkeHubClient.UpdateScopeAsync(scope, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Scope, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Scope result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Scope, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Scope retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScope</summary>
        public void DeleteScopeRequestObject()
        {
            // Snippet: DeleteScope(DeleteScopeRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteScopeRequest request = new DeleteScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScope(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeAsync</summary>
        public async Task DeleteScopeRequestObjectAsync()
        {
            // Snippet: DeleteScopeAsync(DeleteScopeRequest, CallSettings)
            // Additional: DeleteScopeAsync(DeleteScopeRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteScopeRequest request = new DeleteScopeRequest
            {
                ScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScope</summary>
        public void DeleteScope()
        {
            // Snippet: DeleteScope(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScope(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeAsync</summary>
        public async Task DeleteScopeAsync()
        {
            // Snippet: DeleteScopeAsync(string, CallSettings)
            // Additional: DeleteScopeAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScope</summary>
        public void DeleteScopeResourceNames()
        {
            // Snippet: DeleteScope(ScopeName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteScope(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteScope(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteScopeAsync</summary>
        public async Task DeleteScopeResourceNamesAsync()
        {
            // Snippet: DeleteScopeAsync(ScopeName, CallSettings)
            // Additional: DeleteScopeAsync(ScopeName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName name = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteScopeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteScopeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListScopes</summary>
        public void ListScopesRequestObject()
        {
            // Snippet: ListScopes(ListScopesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListScopesRequest request = new ListScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopesAsync</summary>
        public async Task ListScopesRequestObjectAsync()
        {
            // Snippet: ListScopesAsync(ListScopesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListScopesRequest request = new ListScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopes</summary>
        public void ListScopes()
        {
            // Snippet: ListScopes(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopesAsync</summary>
        public async Task ListScopesAsync()
        {
            // Snippet: ListScopesAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopes</summary>
        public void ListScopesResourceNames()
        {
            // Snippet: ListScopes(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListScopesAsync</summary>
        public async Task ListScopesResourceNamesAsync()
        {
            // Snippet: ListScopesAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListScopesResponse, Scope> response = gkeHubClient.ListScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopes</summary>
        public void ListPermittedScopesRequestObject()
        {
            // Snippet: ListPermittedScopes(ListPermittedScopesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopesAsync</summary>
        public async Task ListPermittedScopesRequestObjectAsync()
        {
            // Snippet: ListPermittedScopesAsync(ListPermittedScopesRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListPermittedScopesRequest request = new ListPermittedScopesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopes</summary>
        public void ListPermittedScopes()
        {
            // Snippet: ListPermittedScopes(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopesAsync</summary>
        public async Task ListPermittedScopesAsync()
        {
            // Snippet: ListPermittedScopesAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopes</summary>
        public void ListPermittedScopesResourceNames()
        {
            // Snippet: ListPermittedScopes(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPermittedScopesAsync</summary>
        public async Task ListPermittedScopesResourceNamesAsync()
        {
            // Snippet: ListPermittedScopesAsync(LocationName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPermittedScopesResponse, Scope> response = gkeHubClient.ListPermittedScopesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Scope item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListPermittedScopesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Scope item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Scope> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Scope item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBinding</summary>
        public void GetMembershipBindingRequestObject()
        {
            // Snippet: GetMembershipBinding(GetMembershipBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetMembershipBindingRequest request = new GetMembershipBindingRequest
            {
                MembershipBindingName = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]"),
            };
            // Make the request
            MembershipBinding response = gkeHubClient.GetMembershipBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBindingAsync</summary>
        public async Task GetMembershipBindingRequestObjectAsync()
        {
            // Snippet: GetMembershipBindingAsync(GetMembershipBindingRequest, CallSettings)
            // Additional: GetMembershipBindingAsync(GetMembershipBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetMembershipBindingRequest request = new GetMembershipBindingRequest
            {
                MembershipBindingName = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]"),
            };
            // Make the request
            MembershipBinding response = await gkeHubClient.GetMembershipBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBinding</summary>
        public void GetMembershipBinding()
        {
            // Snippet: GetMembershipBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]/bindings/[MEMBERSHIPBINDING]";
            // Make the request
            MembershipBinding response = gkeHubClient.GetMembershipBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBindingAsync</summary>
        public async Task GetMembershipBindingAsync()
        {
            // Snippet: GetMembershipBindingAsync(string, CallSettings)
            // Additional: GetMembershipBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]/bindings/[MEMBERSHIPBINDING]";
            // Make the request
            MembershipBinding response = await gkeHubClient.GetMembershipBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBinding</summary>
        public void GetMembershipBindingResourceNames()
        {
            // Snippet: GetMembershipBinding(MembershipBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipBindingName name = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]");
            // Make the request
            MembershipBinding response = gkeHubClient.GetMembershipBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipBindingAsync</summary>
        public async Task GetMembershipBindingResourceNamesAsync()
        {
            // Snippet: GetMembershipBindingAsync(MembershipBindingName, CallSettings)
            // Additional: GetMembershipBindingAsync(MembershipBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipBindingName name = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]");
            // Make the request
            MembershipBinding response = await gkeHubClient.GetMembershipBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBinding</summary>
        public void CreateMembershipBindingRequestObject()
        {
            // Snippet: CreateMembershipBinding(CreateMembershipBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateMembershipBindingRequest request = new CreateMembershipBindingRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                MembershipBinding = new MembershipBinding(),
                MembershipBindingId = "",
            };
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = gkeHubClient.CreateMembershipBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBindingAsync</summary>
        public async Task CreateMembershipBindingRequestObjectAsync()
        {
            // Snippet: CreateMembershipBindingAsync(CreateMembershipBindingRequest, CallSettings)
            // Additional: CreateMembershipBindingAsync(CreateMembershipBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipBindingRequest request = new CreateMembershipBindingRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                MembershipBinding = new MembershipBinding(),
                MembershipBindingId = "",
            };
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBinding</summary>
        public void CreateMembershipBinding()
        {
            // Snippet: CreateMembershipBinding(string, MembershipBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            MembershipBinding membershipBinding = new MembershipBinding();
            string membershipBindingId = "";
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = gkeHubClient.CreateMembershipBinding(parent, membershipBinding, membershipBindingId);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBindingAsync</summary>
        public async Task CreateMembershipBindingAsync()
        {
            // Snippet: CreateMembershipBindingAsync(string, MembershipBinding, string, CallSettings)
            // Additional: CreateMembershipBindingAsync(string, MembershipBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            MembershipBinding membershipBinding = new MembershipBinding();
            string membershipBindingId = "";
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipBindingAsync(parent, membershipBinding, membershipBindingId);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBinding</summary>
        public void CreateMembershipBindingResourceNames()
        {
            // Snippet: CreateMembershipBinding(MembershipName, MembershipBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            MembershipBinding membershipBinding = new MembershipBinding();
            string membershipBindingId = "";
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = gkeHubClient.CreateMembershipBinding(parent, membershipBinding, membershipBindingId);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipBindingAsync</summary>
        public async Task CreateMembershipBindingResourceNamesAsync()
        {
            // Snippet: CreateMembershipBindingAsync(MembershipName, MembershipBinding, string, CallSettings)
            // Additional: CreateMembershipBindingAsync(MembershipName, MembershipBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            MembershipBinding membershipBinding = new MembershipBinding();
            string membershipBindingId = "";
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipBindingAsync(parent, membershipBinding, membershipBindingId);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipBinding</summary>
        public void UpdateMembershipBindingRequestObject()
        {
            // Snippet: UpdateMembershipBinding(UpdateMembershipBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateMembershipBindingRequest request = new UpdateMembershipBindingRequest
            {
                MembershipBinding = new MembershipBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = gkeHubClient.UpdateMembershipBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipBindingAsync</summary>
        public async Task UpdateMembershipBindingRequestObjectAsync()
        {
            // Snippet: UpdateMembershipBindingAsync(UpdateMembershipBindingRequest, CallSettings)
            // Additional: UpdateMembershipBindingAsync(UpdateMembershipBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMembershipBindingRequest request = new UpdateMembershipBindingRequest
            {
                MembershipBinding = new MembershipBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = await gkeHubClient.UpdateMembershipBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipBinding</summary>
        public void UpdateMembershipBinding()
        {
            // Snippet: UpdateMembershipBinding(MembershipBinding, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipBinding membershipBinding = new MembershipBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = gkeHubClient.UpdateMembershipBinding(membershipBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipBindingAsync</summary>
        public async Task UpdateMembershipBindingAsync()
        {
            // Snippet: UpdateMembershipBindingAsync(MembershipBinding, FieldMask, CallSettings)
            // Additional: UpdateMembershipBindingAsync(MembershipBinding, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipBinding membershipBinding = new MembershipBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MembershipBinding, OperationMetadata> response = await gkeHubClient.UpdateMembershipBindingAsync(membershipBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MembershipBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MembershipBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MembershipBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MembershipBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBinding</summary>
        public void DeleteMembershipBindingRequestObject()
        {
            // Snippet: DeleteMembershipBinding(DeleteMembershipBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteMembershipBindingRequest request = new DeleteMembershipBindingRequest
            {
                MembershipBindingName = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBindingAsync</summary>
        public async Task DeleteMembershipBindingRequestObjectAsync()
        {
            // Snippet: DeleteMembershipBindingAsync(DeleteMembershipBindingRequest, CallSettings)
            // Additional: DeleteMembershipBindingAsync(DeleteMembershipBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMembershipBindingRequest request = new DeleteMembershipBindingRequest
            {
                MembershipBindingName = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBinding</summary>
        public void DeleteMembershipBinding()
        {
            // Snippet: DeleteMembershipBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]/bindings/[MEMBERSHIPBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBindingAsync</summary>
        public async Task DeleteMembershipBindingAsync()
        {
            // Snippet: DeleteMembershipBindingAsync(string, CallSettings)
            // Additional: DeleteMembershipBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]/bindings/[MEMBERSHIPBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBinding</summary>
        public void DeleteMembershipBindingResourceNames()
        {
            // Snippet: DeleteMembershipBinding(MembershipBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipBindingName name = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipBindingAsync</summary>
        public async Task DeleteMembershipBindingResourceNamesAsync()
        {
            // Snippet: DeleteMembershipBindingAsync(MembershipBindingName, CallSettings)
            // Additional: DeleteMembershipBindingAsync(MembershipBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipBindingName name = MembershipBindingName.FromProjectLocationMembershipMembershipbinding("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]", "[MEMBERSHIPBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindings</summary>
        public void ListMembershipBindingsRequestObject()
        {
            // Snippet: ListMembershipBindings(ListMembershipBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindingsAsync</summary>
        public async Task ListMembershipBindingsRequestObjectAsync()
        {
            // Snippet: ListMembershipBindingsAsync(ListMembershipBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListMembershipBindingsRequest request = new ListMembershipBindingsRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindings</summary>
        public void ListMembershipBindings()
        {
            // Snippet: ListMembershipBindings(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindingsAsync</summary>
        public async Task ListMembershipBindingsAsync()
        {
            // Snippet: ListMembershipBindingsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/memberships/[MEMBERSHIP]";
            // Make the request
            PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindings</summary>
        public void ListMembershipBindingsResourceNames()
        {
            // Snippet: ListMembershipBindings(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipBindingsAsync</summary>
        public async Task ListMembershipBindingsResourceNamesAsync()
        {
            // Snippet: ListMembershipBindingsAsync(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipBindingsResponse, MembershipBinding> response = gkeHubClient.ListMembershipBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MembershipBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MembershipBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MembershipBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MembershipBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBinding</summary>
        public void GetMembershipRBACRoleBindingRequestObject()
        {
            // Snippet: GetMembershipRBACRoleBinding(GetMembershipRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GetMembershipRBACRoleBindingRequest request = new GetMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetMembershipRBACRoleBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBindingAsync</summary>
        public async Task GetMembershipRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: GetMembershipRBACRoleBindingAsync(GetMembershipRBACRoleBindingRequest, CallSettings)
            // Additional: GetMembershipRBACRoleBindingAsync(GetMembershipRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GetMembershipRBACRoleBindingRequest request = new GetMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetMembershipRBACRoleBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBinding</summary>
        public void GetMembershipRBACRoleBinding()
        {
            // Snippet: GetMembershipRBACRoleBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetMembershipRBACRoleBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBindingAsync</summary>
        public async Task GetMembershipRBACRoleBindingAsync()
        {
            // Snippet: GetMembershipRBACRoleBindingAsync(string, CallSettings)
            // Additional: GetMembershipRBACRoleBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetMembershipRBACRoleBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBinding</summary>
        public void GetMembershipRBACRoleBindingResourceNames()
        {
            // Snippet: GetMembershipRBACRoleBinding(RBACRoleBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            RBACRoleBinding response = gkeHubClient.GetMembershipRBACRoleBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipRBACRoleBindingAsync</summary>
        public async Task GetMembershipRBACRoleBindingResourceNamesAsync()
        {
            // Snippet: GetMembershipRBACRoleBindingAsync(RBACRoleBindingName, CallSettings)
            // Additional: GetMembershipRBACRoleBindingAsync(RBACRoleBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            RBACRoleBinding response = await gkeHubClient.GetMembershipRBACRoleBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBinding</summary>
        public void CreateMembershipRBACRoleBindingRequestObject()
        {
            // Snippet: CreateMembershipRBACRoleBinding(CreateMembershipRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            CreateMembershipRBACRoleBindingRequest request = new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateMembershipRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBindingAsync</summary>
        public async Task CreateMembershipRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: CreateMembershipRBACRoleBindingAsync(CreateMembershipRBACRoleBindingRequest, CallSettings)
            // Additional: CreateMembershipRBACRoleBindingAsync(CreateMembershipRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipRBACRoleBindingRequest request = new CreateMembershipRBACRoleBindingRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBinding</summary>
        public void CreateMembershipRBACRoleBinding()
        {
            // Snippet: CreateMembershipRBACRoleBinding(string, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateMembershipRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBindingAsync</summary>
        public async Task CreateMembershipRBACRoleBindingAsync()
        {
            // Snippet: CreateMembershipRBACRoleBindingAsync(string, RBACRoleBinding, string, CallSettings)
            // Additional: CreateMembershipRBACRoleBindingAsync(string, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBinding</summary>
        public void CreateMembershipRBACRoleBindingResourceNames1()
        {
            // Snippet: CreateMembershipRBACRoleBinding(ScopeName, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateMembershipRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBindingAsync</summary>
        public async Task CreateMembershipRBACRoleBindingResourceNames1Async()
        {
            // Snippet: CreateMembershipRBACRoleBindingAsync(ScopeName, RBACRoleBinding, string, CallSettings)
            // Additional: CreateMembershipRBACRoleBindingAsync(ScopeName, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBinding</summary>
        public void CreateMembershipRBACRoleBindingResourceNames2()
        {
            // Snippet: CreateMembershipRBACRoleBinding(MembershipName, RBACRoleBinding, string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.CreateMembershipRBACRoleBinding(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceCreateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipRBACRoleBindingAsync</summary>
        public async Task CreateMembershipRBACRoleBindingResourceNames2Async()
        {
            // Snippet: CreateMembershipRBACRoleBindingAsync(MembershipName, RBACRoleBinding, string, CallSettings)
            // Additional: CreateMembershipRBACRoleBindingAsync(MembershipName, RBACRoleBinding, string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            string rbacrolebindingId = "";
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.CreateMembershipRBACRoleBindingAsync(parent, rbacrolebinding, rbacrolebindingId);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceCreateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipRBACRoleBinding</summary>
        public void UpdateMembershipRBACRoleBindingRequestObject()
        {
            // Snippet: UpdateMembershipRBACRoleBinding(UpdateMembershipRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            UpdateMembershipRBACRoleBindingRequest request = new UpdateMembershipRBACRoleBindingRequest
            {
                Rbacrolebinding = new RBACRoleBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.UpdateMembershipRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipRBACRoleBindingAsync</summary>
        public async Task UpdateMembershipRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: UpdateMembershipRBACRoleBindingAsync(UpdateMembershipRBACRoleBindingRequest, CallSettings)
            // Additional: UpdateMembershipRBACRoleBindingAsync(UpdateMembershipRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMembershipRBACRoleBindingRequest request = new UpdateMembershipRBACRoleBindingRequest
            {
                Rbacrolebinding = new RBACRoleBinding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.UpdateMembershipRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipRBACRoleBinding</summary>
        public void UpdateMembershipRBACRoleBinding()
        {
            // Snippet: UpdateMembershipRBACRoleBinding(RBACRoleBinding, FieldMask, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = gkeHubClient.UpdateMembershipRBACRoleBinding(rbacrolebinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceUpdateMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipRBACRoleBindingAsync</summary>
        public async Task UpdateMembershipRBACRoleBindingAsync()
        {
            // Snippet: UpdateMembershipRBACRoleBindingAsync(RBACRoleBinding, FieldMask, CallSettings)
            // Additional: UpdateMembershipRBACRoleBindingAsync(RBACRoleBinding, FieldMask, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBinding rbacrolebinding = new RBACRoleBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<RBACRoleBinding, OperationMetadata> response = await gkeHubClient.UpdateMembershipRBACRoleBindingAsync(rbacrolebinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<RBACRoleBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RBACRoleBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RBACRoleBinding, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RBACRoleBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBinding</summary>
        public void DeleteMembershipRBACRoleBindingRequestObject()
        {
            // Snippet: DeleteMembershipRBACRoleBinding(DeleteMembershipRBACRoleBindingRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            DeleteMembershipRBACRoleBindingRequest request = new DeleteMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipRBACRoleBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBindingAsync</summary>
        public async Task DeleteMembershipRBACRoleBindingRequestObjectAsync()
        {
            // Snippet: DeleteMembershipRBACRoleBindingAsync(DeleteMembershipRBACRoleBindingRequest, CallSettings)
            // Additional: DeleteMembershipRBACRoleBindingAsync(DeleteMembershipRBACRoleBindingRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMembershipRBACRoleBindingRequest request = new DeleteMembershipRBACRoleBindingRequest
            {
                RBACRoleBindingName = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipRBACRoleBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBinding</summary>
        public void DeleteMembershipRBACRoleBinding()
        {
            // Snippet: DeleteMembershipRBACRoleBinding(string, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipRBACRoleBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBindingAsync</summary>
        public async Task DeleteMembershipRBACRoleBindingAsync()
        {
            // Snippet: DeleteMembershipRBACRoleBindingAsync(string, CallSettings)
            // Additional: DeleteMembershipRBACRoleBindingAsync(string, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]/rbacrolebindings/[RBACROLEBINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipRBACRoleBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBinding</summary>
        public void DeleteMembershipRBACRoleBindingResourceNames()
        {
            // Snippet: DeleteMembershipRBACRoleBinding(RBACRoleBindingName, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gkeHubClient.DeleteMembershipRBACRoleBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gkeHubClient.PollOnceDeleteMembershipRBACRoleBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipRBACRoleBindingAsync</summary>
        public async Task DeleteMembershipRBACRoleBindingResourceNamesAsync()
        {
            // Snippet: DeleteMembershipRBACRoleBindingAsync(RBACRoleBindingName, CallSettings)
            // Additional: DeleteMembershipRBACRoleBindingAsync(RBACRoleBindingName, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            RBACRoleBindingName name = RBACRoleBindingName.FromProjectLocationScopeRbacrolebinding("[PROJECT]", "[LOCATION]", "[SCOPE]", "[RBACROLEBINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gkeHubClient.DeleteMembershipRBACRoleBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceDeleteMembershipRBACRoleBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindings</summary>
        public void ListMembershipRBACRoleBindingsRequestObject()
        {
            // Snippet: ListMembershipRBACRoleBindings(ListMembershipRBACRoleBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindingsAsync</summary>
        public async Task ListMembershipRBACRoleBindingsRequestObjectAsync()
        {
            // Snippet: ListMembershipRBACRoleBindingsAsync(ListMembershipRBACRoleBindingsRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ListMembershipRBACRoleBindingsRequest request = new ListMembershipRBACRoleBindingsRequest
            {
                ParentAsScopeName = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindings</summary>
        public void ListMembershipRBACRoleBindings()
        {
            // Snippet: ListMembershipRBACRoleBindings(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindingsAsync</summary>
        public async Task ListMembershipRBACRoleBindingsAsync()
        {
            // Snippet: ListMembershipRBACRoleBindingsAsync(string, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/scopes/[SCOPE]";
            // Make the request
            PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindings</summary>
        public void ListMembershipRBACRoleBindingsResourceNames1()
        {
            // Snippet: ListMembershipRBACRoleBindings(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindingsAsync</summary>
        public async Task ListMembershipRBACRoleBindingsResourceNames1Async()
        {
            // Snippet: ListMembershipRBACRoleBindingsAsync(ScopeName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            ScopeName parent = ScopeName.FromProjectLocationScope("[PROJECT]", "[LOCATION]", "[SCOPE]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindings</summary>
        public void ListMembershipRBACRoleBindingsResourceNames2()
        {
            // Snippet: ListMembershipRBACRoleBindings(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipRBACRoleBindingsAsync</summary>
        public async Task ListMembershipRBACRoleBindingsResourceNames2Async()
        {
            // Snippet: ListMembershipRBACRoleBindingsAsync(MembershipName, string, int?, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName parent = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipRBACRoleBindingsResponse, RBACRoleBinding> response = gkeHubClient.ListMembershipRBACRoleBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RBACRoleBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMembershipRBACRoleBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RBACRoleBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RBACRoleBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RBACRoleBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateMembershipRBACRoleBindingYAML</summary>
        public void GenerateMembershipRBACRoleBindingYAMLRequestObject()
        {
            // Snippet: GenerateMembershipRBACRoleBindingYAML(GenerateMembershipRBACRoleBindingYAMLRequest, CallSettings)
            // Create client
            GkeHubClient gkeHubClient = GkeHubClient.Create();
            // Initialize request argument(s)
            GenerateMembershipRBACRoleBindingYAMLRequest request = new GenerateMembershipRBACRoleBindingYAMLRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            GenerateMembershipRBACRoleBindingYAMLResponse response = gkeHubClient.GenerateMembershipRBACRoleBindingYAML(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateMembershipRBACRoleBindingYAMLAsync</summary>
        public async Task GenerateMembershipRBACRoleBindingYAMLRequestObjectAsync()
        {
            // Snippet: GenerateMembershipRBACRoleBindingYAMLAsync(GenerateMembershipRBACRoleBindingYAMLRequest, CallSettings)
            // Additional: GenerateMembershipRBACRoleBindingYAMLAsync(GenerateMembershipRBACRoleBindingYAMLRequest, CancellationToken)
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            GenerateMembershipRBACRoleBindingYAMLRequest request = new GenerateMembershipRBACRoleBindingYAMLRequest
            {
                ParentAsMembershipName = MembershipName.FromProjectLocationMembership("[PROJECT]", "[LOCATION]", "[MEMBERSHIP]"),
                RbacrolebindingId = "",
                Rbacrolebinding = new RBACRoleBinding(),
            };
            // Make the request
            GenerateMembershipRBACRoleBindingYAMLResponse response = await gkeHubClient.GenerateMembershipRBACRoleBindingYAMLAsync(request);
            // End snippet
        }
    }
}
