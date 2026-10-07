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
    public sealed class AllGeneratedLineItemCreativeAssociationServiceClientSnippets
    {
        /// <summary>Snippet for GetLineItemCreativeAssociation</summary>
        public void GetLineItemCreativeAssociationRequestObject()
        {
            // Snippet: GetLineItemCreativeAssociation(GetLineItemCreativeAssociationRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            GetLineItemCreativeAssociationRequest request = new GetLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemCreativeAssociationAsync</summary>
        public async Task GetLineItemCreativeAssociationRequestObjectAsync()
        {
            // Snippet: GetLineItemCreativeAssociationAsync(GetLineItemCreativeAssociationRequest, CallSettings)
            // Additional: GetLineItemCreativeAssociationAsync(GetLineItemCreativeAssociationRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLineItemCreativeAssociationRequest request = new GetLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemCreativeAssociation</summary>
        public void GetLineItemCreativeAssociation()
        {
            // Snippet: GetLineItemCreativeAssociation(string, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]";
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemCreativeAssociationAsync</summary>
        public async Task GetLineItemCreativeAssociationAsync()
        {
            // Snippet: GetLineItemCreativeAssociationAsync(string, CallSettings)
            // Additional: GetLineItemCreativeAssociationAsync(string, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]";
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemCreativeAssociation</summary>
        public void GetLineItemCreativeAssociationResourceNames()
        {
            // Snippet: GetLineItemCreativeAssociation(LineItemCreativeAssociationName, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemCreativeAssociationName name = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]");
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemCreativeAssociationAsync</summary>
        public async Task GetLineItemCreativeAssociationResourceNamesAsync()
        {
            // Snippet: GetLineItemCreativeAssociationAsync(LineItemCreativeAssociationName, CallSettings)
            // Additional: GetLineItemCreativeAssociationAsync(LineItemCreativeAssociationName, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemCreativeAssociationName name = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]");
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.GetLineItemCreativeAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociations</summary>
        public void ListLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: ListLineItemCreativeAssociations(ListLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociationsAsync</summary>
        public async Task ListLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: ListLineItemCreativeAssociationsAsync(ListLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLineItemCreativeAssociationsRequest request = new ListLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociations</summary>
        public void ListLineItemCreativeAssociations()
        {
            // Snippet: ListLineItemCreativeAssociations(string, string, int?, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            // Make the request
            PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociationsAsync</summary>
        public async Task ListLineItemCreativeAssociationsAsync()
        {
            // Snippet: ListLineItemCreativeAssociationsAsync(string, string, int?, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            // Make the request
            PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociations</summary>
        public void ListLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: ListLineItemCreativeAssociations(LineItemName, string, int?, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            // Make the request
            PagedEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemCreativeAssociationsAsync</summary>
        public async Task ListLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: ListLineItemCreativeAssociationsAsync(LineItemName, string, int?, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            // Make the request
            PagedAsyncEnumerable<ListLineItemCreativeAssociationsResponse, LineItemCreativeAssociation> response = lineItemCreativeAssociationServiceClient.ListLineItemCreativeAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LineItemCreativeAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemCreativeAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItemCreativeAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItemCreativeAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItemCreativeAssociation item in singlePage)
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
