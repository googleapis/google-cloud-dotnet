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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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

        /// <summary>Snippet for CreateLineItemCreativeAssociation</summary>
        public void CreateLineItemCreativeAssociationRequestObject()
        {
            // Snippet: CreateLineItemCreativeAssociation(CreateLineItemCreativeAssociationRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            CreateLineItemCreativeAssociationRequest request = new CreateLineItemCreativeAssociationRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociation = new LineItemCreativeAssociation(),
            };
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemCreativeAssociationAsync</summary>
        public async Task CreateLineItemCreativeAssociationRequestObjectAsync()
        {
            // Snippet: CreateLineItemCreativeAssociationAsync(CreateLineItemCreativeAssociationRequest, CallSettings)
            // Additional: CreateLineItemCreativeAssociationAsync(CreateLineItemCreativeAssociationRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLineItemCreativeAssociationRequest request = new CreateLineItemCreativeAssociationRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociation = new LineItemCreativeAssociation(),
            };
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemCreativeAssociation</summary>
        public void CreateLineItemCreativeAssociation()
        {
            // Snippet: CreateLineItemCreativeAssociation(string, LineItemCreativeAssociation, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociation(parent, lineItemCreativeAssociation);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemCreativeAssociationAsync</summary>
        public async Task CreateLineItemCreativeAssociationAsync()
        {
            // Snippet: CreateLineItemCreativeAssociationAsync(string, LineItemCreativeAssociation, CallSettings)
            // Additional: CreateLineItemCreativeAssociationAsync(string, LineItemCreativeAssociation, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociationAsync(parent, lineItemCreativeAssociation);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemCreativeAssociation</summary>
        public void CreateLineItemCreativeAssociationResourceNames()
        {
            // Snippet: CreateLineItemCreativeAssociation(LineItemName, LineItemCreativeAssociation, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociation(parent, lineItemCreativeAssociation);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemCreativeAssociationAsync</summary>
        public async Task CreateLineItemCreativeAssociationResourceNamesAsync()
        {
            // Snippet: CreateLineItemCreativeAssociationAsync(LineItemName, LineItemCreativeAssociation, CallSettings)
            // Additional: CreateLineItemCreativeAssociationAsync(LineItemName, LineItemCreativeAssociation, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.CreateLineItemCreativeAssociationAsync(parent, lineItemCreativeAssociation);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociations</summary>
        public void BatchCreateLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: BatchCreateLineItemCreativeAssociations(BatchCreateLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateLineItemCreativeAssociationsRequest request = new BatchCreateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Requests =
                {
                    new CreateLineItemCreativeAssociationRequest(),
                },
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchCreateLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: BatchCreateLineItemCreativeAssociationsAsync(BatchCreateLineItemCreativeAssociationsRequest, CallSettings)
            // Additional: BatchCreateLineItemCreativeAssociationsAsync(BatchCreateLineItemCreativeAssociationsRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateLineItemCreativeAssociationsRequest request = new BatchCreateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Requests =
                {
                    new CreateLineItemCreativeAssociationRequest(),
                },
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociations</summary>
        public void BatchCreateLineItemCreativeAssociations()
        {
            // Snippet: BatchCreateLineItemCreativeAssociations(string, IEnumerable<CreateLineItemCreativeAssociationRequest>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<CreateLineItemCreativeAssociationRequest> requests = new CreateLineItemCreativeAssociationRequest[]
            {
                new CreateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociations(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchCreateLineItemCreativeAssociationsAsync()
        {
            // Snippet: BatchCreateLineItemCreativeAssociationsAsync(string, IEnumerable<CreateLineItemCreativeAssociationRequest>, CallSettings)
            // Additional: BatchCreateLineItemCreativeAssociationsAsync(string, IEnumerable<CreateLineItemCreativeAssociationRequest>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<CreateLineItemCreativeAssociationRequest> requests = new CreateLineItemCreativeAssociationRequest[]
            {
                new CreateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociations</summary>
        public void BatchCreateLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: BatchCreateLineItemCreativeAssociations(LineItemName, IEnumerable<CreateLineItemCreativeAssociationRequest>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<CreateLineItemCreativeAssociationRequest> requests = new CreateLineItemCreativeAssociationRequest[]
            {
                new CreateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociations(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchCreateLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: BatchCreateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<CreateLineItemCreativeAssociationRequest>, CallSettings)
            // Additional: BatchCreateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<CreateLineItemCreativeAssociationRequest>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<CreateLineItemCreativeAssociationRequest> requests = new CreateLineItemCreativeAssociationRequest[]
            {
                new CreateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchCreateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchCreateLineItemCreativeAssociationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemCreativeAssociation</summary>
        public void UpdateLineItemCreativeAssociationRequestObject()
        {
            // Snippet: UpdateLineItemCreativeAssociation(UpdateLineItemCreativeAssociationRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            UpdateLineItemCreativeAssociationRequest request = new UpdateLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociation = new LineItemCreativeAssociation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemCreativeAssociationAsync</summary>
        public async Task UpdateLineItemCreativeAssociationRequestObjectAsync()
        {
            // Snippet: UpdateLineItemCreativeAssociationAsync(UpdateLineItemCreativeAssociationRequest, CallSettings)
            // Additional: UpdateLineItemCreativeAssociationAsync(UpdateLineItemCreativeAssociationRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLineItemCreativeAssociationRequest request = new UpdateLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociation = new LineItemCreativeAssociation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemCreativeAssociation</summary>
        public void UpdateLineItemCreativeAssociation()
        {
            // Snippet: UpdateLineItemCreativeAssociation(LineItemCreativeAssociation, FieldMask, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LineItemCreativeAssociation response = lineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociation(lineItemCreativeAssociation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemCreativeAssociationAsync</summary>
        public async Task UpdateLineItemCreativeAssociationAsync()
        {
            // Snippet: UpdateLineItemCreativeAssociationAsync(LineItemCreativeAssociation, FieldMask, CallSettings)
            // Additional: UpdateLineItemCreativeAssociationAsync(LineItemCreativeAssociation, FieldMask, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemCreativeAssociation lineItemCreativeAssociation = new LineItemCreativeAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LineItemCreativeAssociation response = await lineItemCreativeAssociationServiceClient.UpdateLineItemCreativeAssociationAsync(lineItemCreativeAssociation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociations</summary>
        public void BatchUpdateLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociations(BatchUpdateLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateLineItemCreativeAssociationsRequest request = new BatchUpdateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Requests =
                {
                    new UpdateLineItemCreativeAssociationRequest(),
                },
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchUpdateLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociationsAsync(BatchUpdateLineItemCreativeAssociationsRequest, CallSettings)
            // Additional: BatchUpdateLineItemCreativeAssociationsAsync(BatchUpdateLineItemCreativeAssociationsRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateLineItemCreativeAssociationsRequest request = new BatchUpdateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                Requests =
                {
                    new UpdateLineItemCreativeAssociationRequest(),
                },
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociations</summary>
        public void BatchUpdateLineItemCreativeAssociations()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociations(string, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<UpdateLineItemCreativeAssociationRequest> requests = new UpdateLineItemCreativeAssociationRequest[]
            {
                new UpdateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociations(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchUpdateLineItemCreativeAssociationsAsync()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociationsAsync(string, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CallSettings)
            // Additional: BatchUpdateLineItemCreativeAssociationsAsync(string, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<UpdateLineItemCreativeAssociationRequest> requests = new UpdateLineItemCreativeAssociationRequest[]
            {
                new UpdateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociations</summary>
        public void BatchUpdateLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociations(LineItemName, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<UpdateLineItemCreativeAssociationRequest> requests = new UpdateLineItemCreativeAssociationRequest[]
            {
                new UpdateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociations(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchUpdateLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: BatchUpdateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CallSettings)
            // Additional: BatchUpdateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<UpdateLineItemCreativeAssociationRequest>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<UpdateLineItemCreativeAssociationRequest> requests = new UpdateLineItemCreativeAssociationRequest[]
            {
                new UpdateLineItemCreativeAssociationRequest(),
            };
            // Make the request
            BatchUpdateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchUpdateLineItemCreativeAssociationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociations</summary>
        public void BatchActivateLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: BatchActivateLineItemCreativeAssociations(BatchActivateLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateLineItemCreativeAssociationsRequest request = new BatchActivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchActivateLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: BatchActivateLineItemCreativeAssociationsAsync(BatchActivateLineItemCreativeAssociationsRequest, CallSettings)
            // Additional: BatchActivateLineItemCreativeAssociationsAsync(BatchActivateLineItemCreativeAssociationsRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateLineItemCreativeAssociationsRequest request = new BatchActivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociations</summary>
        public void BatchActivateLineItemCreativeAssociations()
        {
            // Snippet: BatchActivateLineItemCreativeAssociations(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchActivateLineItemCreativeAssociationsAsync()
        {
            // Snippet: BatchActivateLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociations</summary>
        public void BatchActivateLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: BatchActivateLineItemCreativeAssociations(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchActivateLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: BatchActivateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Additional: BatchActivateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            BatchActivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchActivateLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociations</summary>
        public void BatchDeactivateLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociations(BatchDeactivateLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateLineItemCreativeAssociationsRequest request = new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeactivateLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociationsAsync(BatchDeactivateLineItemCreativeAssociationsRequest, CallSettings)
            // Additional: BatchDeactivateLineItemCreativeAssociationsAsync(BatchDeactivateLineItemCreativeAssociationsRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateLineItemCreativeAssociationsRequest request = new BatchDeactivateLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociations</summary>
        public void BatchDeactivateLineItemCreativeAssociations()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociations(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeactivateLineItemCreativeAssociationsAsync()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociations</summary>
        public void BatchDeactivateLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociations(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeactivateLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Additional: BatchDeactivateLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            BatchDeactivateLineItemCreativeAssociationsResponse response = await lineItemCreativeAssociationServiceClient.BatchDeactivateLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociations</summary>
        public void BatchDeleteLineItemCreativeAssociationsRequestObject()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociations(BatchDeleteLineItemCreativeAssociationsRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteLineItemCreativeAssociationsRequest request = new BatchDeleteLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeleteLineItemCreativeAssociationsRequestObjectAsync()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociationsAsync(BatchDeleteLineItemCreativeAssociationsRequest, CallSettings)
            // Additional: BatchDeleteLineItemCreativeAssociationsAsync(BatchDeleteLineItemCreativeAssociationsRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteLineItemCreativeAssociationsRequest request = new BatchDeleteLineItemCreativeAssociationsRequest
            {
                ParentAsLineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                LineItemCreativeAssociationNames =
                {
                    LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                },
            };
            // Make the request
            await lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociations</summary>
        public void BatchDeleteLineItemCreativeAssociations()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociations(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeleteLineItemCreativeAssociationsAsync()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteLineItemCreativeAssociationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]",
            };
            // Make the request
            await lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociations</summary>
        public void BatchDeleteLineItemCreativeAssociationsResourceNames()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociations(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociations(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemCreativeAssociationsAsync</summary>
        public async Task BatchDeleteLineItemCreativeAssociationsResourceNamesAsync()
        {
            // Snippet: BatchDeleteLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CallSettings)
            // Additional: BatchDeleteLineItemCreativeAssociationsAsync(LineItemName, IEnumerable<LineItemCreativeAssociationName>, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName parent = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            IEnumerable<LineItemCreativeAssociationName> names = new LineItemCreativeAssociationName[]
            {
                LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
            };
            // Make the request
            await lineItemCreativeAssociationServiceClient.BatchDeleteLineItemCreativeAssociationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociation</summary>
        public void PreviewLineItemCreativeAssociationRequestObject()
        {
            // Snippet: PreviewLineItemCreativeAssociation(PreviewLineItemCreativeAssociationRequest, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            PreviewLineItemCreativeAssociationRequest request = new PreviewLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                SiteUrl = "",
            };
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociationAsync</summary>
        public async Task PreviewLineItemCreativeAssociationRequestObjectAsync()
        {
            // Snippet: PreviewLineItemCreativeAssociationAsync(PreviewLineItemCreativeAssociationRequest, CallSettings)
            // Additional: PreviewLineItemCreativeAssociationAsync(PreviewLineItemCreativeAssociationRequest, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewLineItemCreativeAssociationRequest request = new PreviewLineItemCreativeAssociationRequest
            {
                LineItemCreativeAssociationName = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]"),
                SiteUrl = "",
            };
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = await lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociation</summary>
        public void PreviewLineItemCreativeAssociation()
        {
            // Snippet: PreviewLineItemCreativeAssociation(string, string, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]";
            string siteUrl = "";
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociation(name, siteUrl);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociationAsync</summary>
        public async Task PreviewLineItemCreativeAssociationAsync()
        {
            // Snippet: PreviewLineItemCreativeAssociationAsync(string, string, CallSettings)
            // Additional: PreviewLineItemCreativeAssociationAsync(string, string, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]/creatives/[CREATIVE]";
            string siteUrl = "";
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = await lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociationAsync(name, siteUrl);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociation</summary>
        public void PreviewLineItemCreativeAssociationResourceNames()
        {
            // Snippet: PreviewLineItemCreativeAssociation(LineItemCreativeAssociationName, string, CallSettings)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = LineItemCreativeAssociationServiceClient.Create();
            // Initialize request argument(s)
            LineItemCreativeAssociationName name = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]");
            string siteUrl = "";
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociation(name, siteUrl);
            // End snippet
        }

        /// <summary>Snippet for PreviewLineItemCreativeAssociationAsync</summary>
        public async Task PreviewLineItemCreativeAssociationResourceNamesAsync()
        {
            // Snippet: PreviewLineItemCreativeAssociationAsync(LineItemCreativeAssociationName, string, CallSettings)
            // Additional: PreviewLineItemCreativeAssociationAsync(LineItemCreativeAssociationName, string, CancellationToken)
            // Create client
            LineItemCreativeAssociationServiceClient lineItemCreativeAssociationServiceClient = await LineItemCreativeAssociationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemCreativeAssociationName name = LineItemCreativeAssociationName.FromNetworkCodeLineItemCreative("[NETWORK_CODE]", "[LINE_ITEM]", "[CREATIVE]");
            string siteUrl = "";
            // Make the request
            PreviewLineItemCreativeAssociationResponse response = await lineItemCreativeAssociationServiceClient.PreviewLineItemCreativeAssociationAsync(name, siteUrl);
            // End snippet
        }
    }
}
