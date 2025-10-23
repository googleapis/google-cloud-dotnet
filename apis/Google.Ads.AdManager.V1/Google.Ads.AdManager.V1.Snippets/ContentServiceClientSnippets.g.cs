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
    public sealed class AllGeneratedContentServiceClientSnippets
    {
        /// <summary>Snippet for GetContent</summary>
        public void GetContentRequestObject()
        {
            // Snippet: GetContent(GetContentRequest, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromNetworkCodeContent("[NETWORK_CODE]", "[CONTENT]"),
            };
            // Make the request
            Content response = contentServiceClient.GetContent(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentRequestObjectAsync()
        {
            // Snippet: GetContentAsync(GetContentRequest, CallSettings)
            // Additional: GetContentAsync(GetContentRequest, CancellationToken)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContentRequest request = new GetContentRequest
            {
                ContentName = ContentName.FromNetworkCodeContent("[NETWORK_CODE]", "[CONTENT]"),
            };
            // Make the request
            Content response = await contentServiceClient.GetContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContent</summary>
        public void GetContent()
        {
            // Snippet: GetContent(string, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/content/[CONTENT]";
            // Make the request
            Content response = contentServiceClient.GetContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentAsync()
        {
            // Snippet: GetContentAsync(string, CallSettings)
            // Additional: GetContentAsync(string, CancellationToken)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/content/[CONTENT]";
            // Make the request
            Content response = await contentServiceClient.GetContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContent</summary>
        public void GetContentResourceNames()
        {
            // Snippet: GetContent(ContentName, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            ContentName name = ContentName.FromNetworkCodeContent("[NETWORK_CODE]", "[CONTENT]");
            // Make the request
            Content response = contentServiceClient.GetContent(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentAsync</summary>
        public async Task GetContentResourceNamesAsync()
        {
            // Snippet: GetContentAsync(ContentName, CallSettings)
            // Additional: GetContentAsync(ContentName, CancellationToken)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContentName name = ContentName.FromNetworkCodeContent("[NETWORK_CODE]", "[CONTENT]");
            // Make the request
            Content response = await contentServiceClient.GetContentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContentRequestObject()
        {
            // Snippet: ListContent(ListContentRequest, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            ListContentRequest request = new ListContentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContent(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentRequestObjectAsync()
        {
            // Snippet: ListContentAsync(ListContentRequest, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContentRequest request = new ListContentRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContentAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContent()
        {
            // Snippet: ListContent(string, string, int?, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContent(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentAsync()
        {
            // Snippet: ListContentAsync(string, string, int?, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContentAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContent</summary>
        public void ListContentResourceNames()
        {
            // Snippet: ListContent(NetworkName, string, int?, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = ContentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContent(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Content item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentAsync</summary>
        public async Task ListContentResourceNamesAsync()
        {
            // Snippet: ListContentAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ContentServiceClient contentServiceClient = await ContentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListContentResponse, Content> response = contentServiceClient.ListContentAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Content item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Content item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Content> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Content item in singlePage)
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
