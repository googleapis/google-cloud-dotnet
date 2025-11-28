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
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContentBundleServiceClientSnippets
    {
        /// <summary>Snippet for GetContentBundle</summary>
        public void GetContentBundleRequestObject()
        {
            // Snippet: GetContentBundle(GetContentBundleRequest, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            GetContentBundleRequest request = new GetContentBundleRequest
            {
                ContentBundleName = ContentBundleName.FromNetworkCodeContentBundle("[NETWORK_CODE]", "[CONTENT_BUNDLE]"),
            };
            // Make the request
            ContentBundle response = contentBundleServiceClient.GetContentBundle(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentBundleAsync</summary>
        public async Task GetContentBundleRequestObjectAsync()
        {
            // Snippet: GetContentBundleAsync(GetContentBundleRequest, CallSettings)
            // Additional: GetContentBundleAsync(GetContentBundleRequest, CancellationToken)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContentBundleRequest request = new GetContentBundleRequest
            {
                ContentBundleName = ContentBundleName.FromNetworkCodeContentBundle("[NETWORK_CODE]", "[CONTENT_BUNDLE]"),
            };
            // Make the request
            ContentBundle response = await contentBundleServiceClient.GetContentBundleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentBundle</summary>
        public void GetContentBundle()
        {
            // Snippet: GetContentBundle(string, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contentBundles/[CONTENT_BUNDLE]";
            // Make the request
            ContentBundle response = contentBundleServiceClient.GetContentBundle(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentBundleAsync</summary>
        public async Task GetContentBundleAsync()
        {
            // Snippet: GetContentBundleAsync(string, CallSettings)
            // Additional: GetContentBundleAsync(string, CancellationToken)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contentBundles/[CONTENT_BUNDLE]";
            // Make the request
            ContentBundle response = await contentBundleServiceClient.GetContentBundleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentBundle</summary>
        public void GetContentBundleResourceNames()
        {
            // Snippet: GetContentBundle(ContentBundleName, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            ContentBundleName name = ContentBundleName.FromNetworkCodeContentBundle("[NETWORK_CODE]", "[CONTENT_BUNDLE]");
            // Make the request
            ContentBundle response = contentBundleServiceClient.GetContentBundle(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentBundleAsync</summary>
        public async Task GetContentBundleResourceNamesAsync()
        {
            // Snippet: GetContentBundleAsync(ContentBundleName, CallSettings)
            // Additional: GetContentBundleAsync(ContentBundleName, CancellationToken)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContentBundleName name = ContentBundleName.FromNetworkCodeContentBundle("[NETWORK_CODE]", "[CONTENT_BUNDLE]");
            // Make the request
            ContentBundle response = await contentBundleServiceClient.GetContentBundleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListContentBundles</summary>
        public void ListContentBundlesRequestObject()
        {
            // Snippet: ListContentBundles(ListContentBundlesRequest, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            ListContentBundlesRequest request = new ListContentBundlesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentBundlesAsync</summary>
        public async Task ListContentBundlesRequestObjectAsync()
        {
            // Snippet: ListContentBundlesAsync(ListContentBundlesRequest, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContentBundlesRequest request = new ListContentBundlesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundlesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentBundles</summary>
        public void ListContentBundles()
        {
            // Snippet: ListContentBundles(string, string, int?, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentBundlesAsync</summary>
        public async Task ListContentBundlesAsync()
        {
            // Snippet: ListContentBundlesAsync(string, string, int?, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentBundles</summary>
        public void ListContentBundlesResourceNames()
        {
            // Snippet: ListContentBundles(NetworkName, string, int?, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = ContentBundleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentBundle item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentBundlesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentBundlesAsync</summary>
        public async Task ListContentBundlesResourceNamesAsync()
        {
            // Snippet: ListContentBundlesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ContentBundleServiceClient contentBundleServiceClient = await ContentBundleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListContentBundlesResponse, ContentBundle> response = contentBundleServiceClient.ListContentBundlesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentBundle item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentBundlesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentBundle item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentBundle> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentBundle item in singlePage)
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
