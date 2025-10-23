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
    public sealed class AllGeneratedCreativeTemplateServiceClientSnippets
    {
        /// <summary>Snippet for GetCreativeTemplate</summary>
        public void GetCreativeTemplateRequestObject()
        {
            // Snippet: GetCreativeTemplate(GetCreativeTemplateRequest, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            GetCreativeTemplateRequest request = new GetCreativeTemplateRequest
            {
                CreativeTemplateName = CreativeTemplateName.FromNetworkCodeCreativeTemplate("[NETWORK_CODE]", "[CREATIVE_TEMPLATE]"),
            };
            // Make the request
            CreativeTemplate response = creativeTemplateServiceClient.GetCreativeTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeTemplateAsync</summary>
        public async Task GetCreativeTemplateRequestObjectAsync()
        {
            // Snippet: GetCreativeTemplateAsync(GetCreativeTemplateRequest, CallSettings)
            // Additional: GetCreativeTemplateAsync(GetCreativeTemplateRequest, CancellationToken)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCreativeTemplateRequest request = new GetCreativeTemplateRequest
            {
                CreativeTemplateName = CreativeTemplateName.FromNetworkCodeCreativeTemplate("[NETWORK_CODE]", "[CREATIVE_TEMPLATE]"),
            };
            // Make the request
            CreativeTemplate response = await creativeTemplateServiceClient.GetCreativeTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeTemplate</summary>
        public void GetCreativeTemplate()
        {
            // Snippet: GetCreativeTemplate(string, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeTemplates/[CREATIVE_TEMPLATE]";
            // Make the request
            CreativeTemplate response = creativeTemplateServiceClient.GetCreativeTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeTemplateAsync</summary>
        public async Task GetCreativeTemplateAsync()
        {
            // Snippet: GetCreativeTemplateAsync(string, CallSettings)
            // Additional: GetCreativeTemplateAsync(string, CancellationToken)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeTemplates/[CREATIVE_TEMPLATE]";
            // Make the request
            CreativeTemplate response = await creativeTemplateServiceClient.GetCreativeTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeTemplate</summary>
        public void GetCreativeTemplateResourceNames()
        {
            // Snippet: GetCreativeTemplate(CreativeTemplateName, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            CreativeTemplateName name = CreativeTemplateName.FromNetworkCodeCreativeTemplate("[NETWORK_CODE]", "[CREATIVE_TEMPLATE]");
            // Make the request
            CreativeTemplate response = creativeTemplateServiceClient.GetCreativeTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeTemplateAsync</summary>
        public async Task GetCreativeTemplateResourceNamesAsync()
        {
            // Snippet: GetCreativeTemplateAsync(CreativeTemplateName, CallSettings)
            // Additional: GetCreativeTemplateAsync(CreativeTemplateName, CancellationToken)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeTemplateName name = CreativeTemplateName.FromNetworkCodeCreativeTemplate("[NETWORK_CODE]", "[CREATIVE_TEMPLATE]");
            // Make the request
            CreativeTemplate response = await creativeTemplateServiceClient.GetCreativeTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplates</summary>
        public void ListCreativeTemplatesRequestObject()
        {
            // Snippet: ListCreativeTemplates(ListCreativeTemplatesRequest, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            ListCreativeTemplatesRequest request = new ListCreativeTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplatesAsync</summary>
        public async Task ListCreativeTemplatesRequestObjectAsync()
        {
            // Snippet: ListCreativeTemplatesAsync(ListCreativeTemplatesRequest, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCreativeTemplatesRequest request = new ListCreativeTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CreativeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCreativeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplates</summary>
        public void ListCreativeTemplates()
        {
            // Snippet: ListCreativeTemplates(string, string, int?, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplatesAsync</summary>
        public async Task ListCreativeTemplatesAsync()
        {
            // Snippet: ListCreativeTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CreativeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCreativeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplates</summary>
        public void ListCreativeTemplatesResourceNames()
        {
            // Snippet: ListCreativeTemplates(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = CreativeTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeTemplatesAsync</summary>
        public async Task ListCreativeTemplatesResourceNamesAsync()
        {
            // Snippet: ListCreativeTemplatesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeTemplateServiceClient creativeTemplateServiceClient = await CreativeTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCreativeTemplatesResponse, CreativeTemplate> response = creativeTemplateServiceClient.ListCreativeTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CreativeTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCreativeTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeTemplate item in singlePage)
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
