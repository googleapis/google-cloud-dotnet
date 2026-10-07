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
    public sealed class AllGeneratedLineItemTemplateServiceClientSnippets
    {
        /// <summary>Snippet for GetLineItemTemplate</summary>
        public void GetLineItemTemplateRequestObject()
        {
            // Snippet: GetLineItemTemplate(GetLineItemTemplateRequest, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            GetLineItemTemplateRequest request = new GetLineItemTemplateRequest
            {
                LineItemTemplateName = LineItemTemplateName.FromNetworkCodeLineItemTemplate("[NETWORK_CODE]", "[LINE_ITEM_TEMPLATE]"),
            };
            // Make the request
            LineItemTemplate response = lineItemTemplateServiceClient.GetLineItemTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemTemplateAsync</summary>
        public async Task GetLineItemTemplateRequestObjectAsync()
        {
            // Snippet: GetLineItemTemplateAsync(GetLineItemTemplateRequest, CallSettings)
            // Additional: GetLineItemTemplateAsync(GetLineItemTemplateRequest, CancellationToken)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLineItemTemplateRequest request = new GetLineItemTemplateRequest
            {
                LineItemTemplateName = LineItemTemplateName.FromNetworkCodeLineItemTemplate("[NETWORK_CODE]", "[LINE_ITEM_TEMPLATE]"),
            };
            // Make the request
            LineItemTemplate response = await lineItemTemplateServiceClient.GetLineItemTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemTemplate</summary>
        public void GetLineItemTemplate()
        {
            // Snippet: GetLineItemTemplate(string, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItemTemplates/[LINE_ITEM_TEMPLATE]";
            // Make the request
            LineItemTemplate response = lineItemTemplateServiceClient.GetLineItemTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemTemplateAsync</summary>
        public async Task GetLineItemTemplateAsync()
        {
            // Snippet: GetLineItemTemplateAsync(string, CallSettings)
            // Additional: GetLineItemTemplateAsync(string, CancellationToken)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItemTemplates/[LINE_ITEM_TEMPLATE]";
            // Make the request
            LineItemTemplate response = await lineItemTemplateServiceClient.GetLineItemTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemTemplate</summary>
        public void GetLineItemTemplateResourceNames()
        {
            // Snippet: GetLineItemTemplate(LineItemTemplateName, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            LineItemTemplateName name = LineItemTemplateName.FromNetworkCodeLineItemTemplate("[NETWORK_CODE]", "[LINE_ITEM_TEMPLATE]");
            // Make the request
            LineItemTemplate response = lineItemTemplateServiceClient.GetLineItemTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemTemplateAsync</summary>
        public async Task GetLineItemTemplateResourceNamesAsync()
        {
            // Snippet: GetLineItemTemplateAsync(LineItemTemplateName, CallSettings)
            // Additional: GetLineItemTemplateAsync(LineItemTemplateName, CancellationToken)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemTemplateName name = LineItemTemplateName.FromNetworkCodeLineItemTemplate("[NETWORK_CODE]", "[LINE_ITEM_TEMPLATE]");
            // Make the request
            LineItemTemplate response = await lineItemTemplateServiceClient.GetLineItemTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplates</summary>
        public void ListLineItemTemplatesRequestObject()
        {
            // Snippet: ListLineItemTemplates(ListLineItemTemplatesRequest, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplatesAsync</summary>
        public async Task ListLineItemTemplatesRequestObjectAsync()
        {
            // Snippet: ListLineItemTemplatesAsync(ListLineItemTemplatesRequest, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLineItemTemplatesRequest request = new ListLineItemTemplatesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplates</summary>
        public void ListLineItemTemplates()
        {
            // Snippet: ListLineItemTemplates(string, string, int?, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplatesAsync</summary>
        public async Task ListLineItemTemplatesAsync()
        {
            // Snippet: ListLineItemTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplates</summary>
        public void ListLineItemTemplatesResourceNames()
        {
            // Snippet: ListLineItemTemplates(NetworkName, string, int?, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = LineItemTemplateServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemTemplatesAsync</summary>
        public async Task ListLineItemTemplatesResourceNamesAsync()
        {
            // Snippet: ListLineItemTemplatesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            LineItemTemplateServiceClient lineItemTemplateServiceClient = await LineItemTemplateServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListLineItemTemplatesResponse, LineItemTemplate> response = lineItemTemplateServiceClient.ListLineItemTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemTemplate item in singlePage)
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
