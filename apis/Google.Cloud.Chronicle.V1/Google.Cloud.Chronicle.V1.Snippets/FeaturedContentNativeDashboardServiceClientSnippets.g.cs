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
    using Google.Cloud.Chronicle.V1;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeaturedContentNativeDashboardServiceClientSnippets
    {
        /// <summary>Snippet for GetFeaturedContentNativeDashboard</summary>
        public void GetFeaturedContentNativeDashboardRequestObject()
        {
            // Snippet: GetFeaturedContentNativeDashboard(GetFeaturedContentNativeDashboardRequest, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            GetFeaturedContentNativeDashboardRequest request = new GetFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]"),
            };
            // Make the request
            FeaturedContentNativeDashboard response = featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturedContentNativeDashboardAsync</summary>
        public async Task GetFeaturedContentNativeDashboardRequestObjectAsync()
        {
            // Snippet: GetFeaturedContentNativeDashboardAsync(GetFeaturedContentNativeDashboardRequest, CallSettings)
            // Additional: GetFeaturedContentNativeDashboardAsync(GetFeaturedContentNativeDashboardRequest, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeaturedContentNativeDashboardRequest request = new GetFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]"),
            };
            // Make the request
            FeaturedContentNativeDashboard response = await featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturedContentNativeDashboard</summary>
        public void GetFeaturedContentNativeDashboard()
        {
            // Snippet: GetFeaturedContentNativeDashboard(string, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub/featuredContentNativeDashboards/[FEATURED_CONTENT_NATIVE_DASHBOARD]";
            // Make the request
            FeaturedContentNativeDashboard response = featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturedContentNativeDashboardAsync</summary>
        public async Task GetFeaturedContentNativeDashboardAsync()
        {
            // Snippet: GetFeaturedContentNativeDashboardAsync(string, CallSettings)
            // Additional: GetFeaturedContentNativeDashboardAsync(string, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub/featuredContentNativeDashboards/[FEATURED_CONTENT_NATIVE_DASHBOARD]";
            // Make the request
            FeaturedContentNativeDashboard response = await featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturedContentNativeDashboard</summary>
        public void GetFeaturedContentNativeDashboardResourceNames()
        {
            // Snippet: GetFeaturedContentNativeDashboard(FeaturedContentNativeDashboardName, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            FeaturedContentNativeDashboardName name = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]");
            // Make the request
            FeaturedContentNativeDashboard response = featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeaturedContentNativeDashboardAsync</summary>
        public async Task GetFeaturedContentNativeDashboardResourceNamesAsync()
        {
            // Snippet: GetFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName, CallSettings)
            // Additional: GetFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturedContentNativeDashboardName name = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]");
            // Make the request
            FeaturedContentNativeDashboard response = await featuredContentNativeDashboardServiceClient.GetFeaturedContentNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboards</summary>
        public void ListFeaturedContentNativeDashboardsRequestObject()
        {
            // Snippet: ListFeaturedContentNativeDashboards(ListFeaturedContentNativeDashboardsRequest, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
            {
                ParentAsContentHubName = ContentHubName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboards(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboardsAsync</summary>
        public async Task ListFeaturedContentNativeDashboardsRequestObjectAsync()
        {
            // Snippet: ListFeaturedContentNativeDashboardsAsync(ListFeaturedContentNativeDashboardsRequest, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeaturedContentNativeDashboardsRequest request = new ListFeaturedContentNativeDashboardsRequest
            {
                ParentAsContentHubName = ContentHubName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboardsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboards</summary>
        public void ListFeaturedContentNativeDashboards()
        {
            // Snippet: ListFeaturedContentNativeDashboards(string, string, int?, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub";
            // Make the request
            PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboardsAsync</summary>
        public async Task ListFeaturedContentNativeDashboardsAsync()
        {
            // Snippet: ListFeaturedContentNativeDashboardsAsync(string, string, int?, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub";
            // Make the request
            PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboards</summary>
        public void ListFeaturedContentNativeDashboardsResourceNames()
        {
            // Snippet: ListFeaturedContentNativeDashboards(ContentHubName, string, int?, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            ContentHubName parent = ContentHubName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeaturedContentNativeDashboardsAsync</summary>
        public async Task ListFeaturedContentNativeDashboardsResourceNamesAsync()
        {
            // Snippet: ListFeaturedContentNativeDashboardsAsync(ContentHubName, string, int?, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContentHubName parent = ContentHubName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListFeaturedContentNativeDashboardsResponse, FeaturedContentNativeDashboard> response = featuredContentNativeDashboardServiceClient.ListFeaturedContentNativeDashboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeaturedContentNativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeaturedContentNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeaturedContentNativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeaturedContentNativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeaturedContentNativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboard</summary>
        public void InstallFeaturedContentNativeDashboardRequestObject()
        {
            // Snippet: InstallFeaturedContentNativeDashboard(InstallFeaturedContentNativeDashboardRequest, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            InstallFeaturedContentNativeDashboardRequest request = new InstallFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]"),
                FeaturedContentNativeDashboard = new FeaturedContentNativeDashboard(),
            };
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboardAsync</summary>
        public async Task InstallFeaturedContentNativeDashboardRequestObjectAsync()
        {
            // Snippet: InstallFeaturedContentNativeDashboardAsync(InstallFeaturedContentNativeDashboardRequest, CallSettings)
            // Additional: InstallFeaturedContentNativeDashboardAsync(InstallFeaturedContentNativeDashboardRequest, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstallFeaturedContentNativeDashboardRequest request = new InstallFeaturedContentNativeDashboardRequest
            {
                FeaturedContentNativeDashboardName = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]"),
                FeaturedContentNativeDashboard = new FeaturedContentNativeDashboard(),
            };
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = await featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboard</summary>
        public void InstallFeaturedContentNativeDashboard()
        {
            // Snippet: InstallFeaturedContentNativeDashboard(string, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub/featuredContentNativeDashboards/[FEATURED_CONTENT_NATIVE_DASHBOARD]";
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboardAsync</summary>
        public async Task InstallFeaturedContentNativeDashboardAsync()
        {
            // Snippet: InstallFeaturedContentNativeDashboardAsync(string, CallSettings)
            // Additional: InstallFeaturedContentNativeDashboardAsync(string, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/contentHub/featuredContentNativeDashboards/[FEATURED_CONTENT_NATIVE_DASHBOARD]";
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = await featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboard</summary>
        public void InstallFeaturedContentNativeDashboardResourceNames()
        {
            // Snippet: InstallFeaturedContentNativeDashboard(FeaturedContentNativeDashboardName, CallSettings)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = FeaturedContentNativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            FeaturedContentNativeDashboardName name = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]");
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for InstallFeaturedContentNativeDashboardAsync</summary>
        public async Task InstallFeaturedContentNativeDashboardResourceNamesAsync()
        {
            // Snippet: InstallFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName, CallSettings)
            // Additional: InstallFeaturedContentNativeDashboardAsync(FeaturedContentNativeDashboardName, CancellationToken)
            // Create client
            FeaturedContentNativeDashboardServiceClient featuredContentNativeDashboardServiceClient = await FeaturedContentNativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeaturedContentNativeDashboardName name = FeaturedContentNativeDashboardName.FromProjectLocationInstanceFeaturedContentNativeDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEATURED_CONTENT_NATIVE_DASHBOARD]");
            // Make the request
            InstallFeaturedContentNativeDashboardResponse response = await featuredContentNativeDashboardServiceClient.InstallFeaturedContentNativeDashboardAsync(name);
            // End snippet
        }
    }
}
