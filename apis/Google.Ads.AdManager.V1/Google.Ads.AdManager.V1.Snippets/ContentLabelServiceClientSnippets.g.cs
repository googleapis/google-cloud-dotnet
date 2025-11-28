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
    public sealed class AllGeneratedContentLabelServiceClientSnippets
    {
        /// <summary>Snippet for GetContentLabel</summary>
        public void GetContentLabelRequestObject()
        {
            // Snippet: GetContentLabel(GetContentLabelRequest, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            GetContentLabelRequest request = new GetContentLabelRequest
            {
                ContentLabelName = ContentLabelName.FromNetworkCodeContentLabel("[NETWORK_CODE]", "[CONTENT_LABEL]"),
            };
            // Make the request
            ContentLabel response = contentLabelServiceClient.GetContentLabel(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentLabelAsync</summary>
        public async Task GetContentLabelRequestObjectAsync()
        {
            // Snippet: GetContentLabelAsync(GetContentLabelRequest, CallSettings)
            // Additional: GetContentLabelAsync(GetContentLabelRequest, CancellationToken)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetContentLabelRequest request = new GetContentLabelRequest
            {
                ContentLabelName = ContentLabelName.FromNetworkCodeContentLabel("[NETWORK_CODE]", "[CONTENT_LABEL]"),
            };
            // Make the request
            ContentLabel response = await contentLabelServiceClient.GetContentLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetContentLabel</summary>
        public void GetContentLabel()
        {
            // Snippet: GetContentLabel(string, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contentLabels/[CONTENT_LABEL]";
            // Make the request
            ContentLabel response = contentLabelServiceClient.GetContentLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentLabelAsync</summary>
        public async Task GetContentLabelAsync()
        {
            // Snippet: GetContentLabelAsync(string, CallSettings)
            // Additional: GetContentLabelAsync(string, CancellationToken)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/contentLabels/[CONTENT_LABEL]";
            // Make the request
            ContentLabel response = await contentLabelServiceClient.GetContentLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentLabel</summary>
        public void GetContentLabelResourceNames()
        {
            // Snippet: GetContentLabel(ContentLabelName, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            ContentLabelName name = ContentLabelName.FromNetworkCodeContentLabel("[NETWORK_CODE]", "[CONTENT_LABEL]");
            // Make the request
            ContentLabel response = contentLabelServiceClient.GetContentLabel(name);
            // End snippet
        }

        /// <summary>Snippet for GetContentLabelAsync</summary>
        public async Task GetContentLabelResourceNamesAsync()
        {
            // Snippet: GetContentLabelAsync(ContentLabelName, CallSettings)
            // Additional: GetContentLabelAsync(ContentLabelName, CancellationToken)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ContentLabelName name = ContentLabelName.FromNetworkCodeContentLabel("[NETWORK_CODE]", "[CONTENT_LABEL]");
            // Make the request
            ContentLabel response = await contentLabelServiceClient.GetContentLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListContentLabels</summary>
        public void ListContentLabelsRequestObject()
        {
            // Snippet: ListContentLabels(ListContentLabelsRequest, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            ListContentLabelsRequest request = new ListContentLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentLabelsAsync</summary>
        public async Task ListContentLabelsRequestObjectAsync()
        {
            // Snippet: ListContentLabelsAsync(ListContentLabelsRequest, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListContentLabelsRequest request = new ListContentLabelsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentLabels</summary>
        public void ListContentLabels()
        {
            // Snippet: ListContentLabels(string, string, int?, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentLabelsAsync</summary>
        public async Task ListContentLabelsAsync()
        {
            // Snippet: ListContentLabelsAsync(string, string, int?, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentLabels</summary>
        public void ListContentLabelsResourceNames()
        {
            // Snippet: ListContentLabels(NetworkName, string, int?, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = ContentLabelServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ContentLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContentLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContentLabelsAsync</summary>
        public async Task ListContentLabelsResourceNamesAsync()
        {
            // Snippet: ListContentLabelsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ContentLabelServiceClient contentLabelServiceClient = await ContentLabelServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListContentLabelsResponse, ContentLabel> response = contentLabelServiceClient.ListContentLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ContentLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContentLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ContentLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ContentLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ContentLabel item in singlePage)
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
