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
    public sealed class AllGeneratedBrowserServiceClientSnippets
    {
        /// <summary>Snippet for GetBrowser</summary>
        public void GetBrowserRequestObject()
        {
            // Snippet: GetBrowser(GetBrowserRequest, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            GetBrowserRequest request = new GetBrowserRequest
            {
                BrowserName = BrowserName.FromNetworkCodeBrowser("[NETWORK_CODE]", "[BROWSER]"),
            };
            // Make the request
            Browser response = browserServiceClient.GetBrowser(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserAsync</summary>
        public async Task GetBrowserRequestObjectAsync()
        {
            // Snippet: GetBrowserAsync(GetBrowserRequest, CallSettings)
            // Additional: GetBrowserAsync(GetBrowserRequest, CancellationToken)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBrowserRequest request = new GetBrowserRequest
            {
                BrowserName = BrowserName.FromNetworkCodeBrowser("[NETWORK_CODE]", "[BROWSER]"),
            };
            // Make the request
            Browser response = await browserServiceClient.GetBrowserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrowser</summary>
        public void GetBrowser()
        {
            // Snippet: GetBrowser(string, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/browsers/[BROWSER]";
            // Make the request
            Browser response = browserServiceClient.GetBrowser(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserAsync</summary>
        public async Task GetBrowserAsync()
        {
            // Snippet: GetBrowserAsync(string, CallSettings)
            // Additional: GetBrowserAsync(string, CancellationToken)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/browsers/[BROWSER]";
            // Make the request
            Browser response = await browserServiceClient.GetBrowserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowser</summary>
        public void GetBrowserResourceNames()
        {
            // Snippet: GetBrowser(BrowserName, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            BrowserName name = BrowserName.FromNetworkCodeBrowser("[NETWORK_CODE]", "[BROWSER]");
            // Make the request
            Browser response = browserServiceClient.GetBrowser(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserAsync</summary>
        public async Task GetBrowserResourceNamesAsync()
        {
            // Snippet: GetBrowserAsync(BrowserName, CallSettings)
            // Additional: GetBrowserAsync(BrowserName, CancellationToken)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            BrowserName name = BrowserName.FromNetworkCodeBrowser("[NETWORK_CODE]", "[BROWSER]");
            // Make the request
            Browser response = await browserServiceClient.GetBrowserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBrowsers</summary>
        public void ListBrowsersRequestObject()
        {
            // Snippet: ListBrowsers(ListBrowsersRequest, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            ListBrowsersRequest request = new ListBrowsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Browser item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowsersAsync</summary>
        public async Task ListBrowsersRequestObjectAsync()
        {
            // Snippet: ListBrowsersAsync(ListBrowsersRequest, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBrowsersRequest request = new ListBrowsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Browser item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowsers</summary>
        public void ListBrowsers()
        {
            // Snippet: ListBrowsers(string, string, int?, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Browser item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowsersAsync</summary>
        public async Task ListBrowsersAsync()
        {
            // Snippet: ListBrowsersAsync(string, string, int?, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Browser item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowsers</summary>
        public void ListBrowsersResourceNames()
        {
            // Snippet: ListBrowsers(NetworkName, string, int?, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = BrowserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Browser item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowsersAsync</summary>
        public async Task ListBrowsersResourceNamesAsync()
        {
            // Snippet: ListBrowsersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            BrowserServiceClient browserServiceClient = await BrowserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListBrowsersResponse, Browser> response = browserServiceClient.ListBrowsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Browser item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Browser item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Browser> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Browser item in singlePage)
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
