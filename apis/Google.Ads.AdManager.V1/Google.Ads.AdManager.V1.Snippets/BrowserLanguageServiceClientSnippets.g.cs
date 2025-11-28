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
    public sealed class AllGeneratedBrowserLanguageServiceClientSnippets
    {
        /// <summary>Snippet for GetBrowserLanguage</summary>
        public void GetBrowserLanguageRequestObject()
        {
            // Snippet: GetBrowserLanguage(GetBrowserLanguageRequest, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            GetBrowserLanguageRequest request = new GetBrowserLanguageRequest
            {
                BrowserLanguageName = BrowserLanguageName.FromNetworkCodeBrowserLanguage("[NETWORK_CODE]", "[BROWSER_LANGUAGE]"),
            };
            // Make the request
            BrowserLanguage response = browserLanguageServiceClient.GetBrowserLanguage(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserLanguageAsync</summary>
        public async Task GetBrowserLanguageRequestObjectAsync()
        {
            // Snippet: GetBrowserLanguageAsync(GetBrowserLanguageRequest, CallSettings)
            // Additional: GetBrowserLanguageAsync(GetBrowserLanguageRequest, CancellationToken)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBrowserLanguageRequest request = new GetBrowserLanguageRequest
            {
                BrowserLanguageName = BrowserLanguageName.FromNetworkCodeBrowserLanguage("[NETWORK_CODE]", "[BROWSER_LANGUAGE]"),
            };
            // Make the request
            BrowserLanguage response = await browserLanguageServiceClient.GetBrowserLanguageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserLanguage</summary>
        public void GetBrowserLanguage()
        {
            // Snippet: GetBrowserLanguage(string, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/browserLanguages/[BROWSER_LANGUAGE]";
            // Make the request
            BrowserLanguage response = browserLanguageServiceClient.GetBrowserLanguage(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserLanguageAsync</summary>
        public async Task GetBrowserLanguageAsync()
        {
            // Snippet: GetBrowserLanguageAsync(string, CallSettings)
            // Additional: GetBrowserLanguageAsync(string, CancellationToken)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/browserLanguages/[BROWSER_LANGUAGE]";
            // Make the request
            BrowserLanguage response = await browserLanguageServiceClient.GetBrowserLanguageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserLanguage</summary>
        public void GetBrowserLanguageResourceNames()
        {
            // Snippet: GetBrowserLanguage(BrowserLanguageName, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            BrowserLanguageName name = BrowserLanguageName.FromNetworkCodeBrowserLanguage("[NETWORK_CODE]", "[BROWSER_LANGUAGE]");
            // Make the request
            BrowserLanguage response = browserLanguageServiceClient.GetBrowserLanguage(name);
            // End snippet
        }

        /// <summary>Snippet for GetBrowserLanguageAsync</summary>
        public async Task GetBrowserLanguageResourceNamesAsync()
        {
            // Snippet: GetBrowserLanguageAsync(BrowserLanguageName, CallSettings)
            // Additional: GetBrowserLanguageAsync(BrowserLanguageName, CancellationToken)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            BrowserLanguageName name = BrowserLanguageName.FromNetworkCodeBrowserLanguage("[NETWORK_CODE]", "[BROWSER_LANGUAGE]");
            // Make the request
            BrowserLanguage response = await browserLanguageServiceClient.GetBrowserLanguageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguages</summary>
        public void ListBrowserLanguagesRequestObject()
        {
            // Snippet: ListBrowserLanguages(ListBrowserLanguagesRequest, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BrowserLanguage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowserLanguagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguagesAsync</summary>
        public async Task ListBrowserLanguagesRequestObjectAsync()
        {
            // Snippet: ListBrowserLanguagesAsync(ListBrowserLanguagesRequest, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBrowserLanguagesRequest request = new ListBrowserLanguagesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BrowserLanguage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowserLanguagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguages</summary>
        public void ListBrowserLanguages()
        {
            // Snippet: ListBrowserLanguages(string, string, int?, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BrowserLanguage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowserLanguagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguagesAsync</summary>
        public async Task ListBrowserLanguagesAsync()
        {
            // Snippet: ListBrowserLanguagesAsync(string, string, int?, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BrowserLanguage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowserLanguagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguages</summary>
        public void ListBrowserLanguagesResourceNames()
        {
            // Snippet: ListBrowserLanguages(NetworkName, string, int?, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = BrowserLanguageServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BrowserLanguage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBrowserLanguagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBrowserLanguagesAsync</summary>
        public async Task ListBrowserLanguagesResourceNamesAsync()
        {
            // Snippet: ListBrowserLanguagesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            BrowserLanguageServiceClient browserLanguageServiceClient = await BrowserLanguageServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListBrowserLanguagesResponse, BrowserLanguage> response = browserLanguageServiceClient.ListBrowserLanguagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BrowserLanguage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBrowserLanguagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BrowserLanguage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BrowserLanguage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BrowserLanguage item in singlePage)
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
