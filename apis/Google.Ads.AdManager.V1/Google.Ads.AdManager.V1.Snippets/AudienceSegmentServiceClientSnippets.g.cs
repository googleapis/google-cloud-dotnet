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
    public sealed class AllGeneratedAudienceSegmentServiceClientSnippets
    {
        /// <summary>Snippet for GetAudienceSegment</summary>
        public void GetAudienceSegmentRequestObject()
        {
            // Snippet: GetAudienceSegment(GetAudienceSegmentRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            GetAudienceSegmentRequest request = new GetAudienceSegmentRequest
            {
                AudienceSegmentName = AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            AudienceSegment response = audienceSegmentServiceClient.GetAudienceSegment(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentAsync</summary>
        public async Task GetAudienceSegmentRequestObjectAsync()
        {
            // Snippet: GetAudienceSegmentAsync(GetAudienceSegmentRequest, CallSettings)
            // Additional: GetAudienceSegmentAsync(GetAudienceSegmentRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAudienceSegmentRequest request = new GetAudienceSegmentRequest
            {
                AudienceSegmentName = AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            AudienceSegment response = await audienceSegmentServiceClient.GetAudienceSegmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegment</summary>
        public void GetAudienceSegment()
        {
            // Snippet: GetAudienceSegment(string, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]";
            // Make the request
            AudienceSegment response = audienceSegmentServiceClient.GetAudienceSegment(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentAsync</summary>
        public async Task GetAudienceSegmentAsync()
        {
            // Snippet: GetAudienceSegmentAsync(string, CallSettings)
            // Additional: GetAudienceSegmentAsync(string, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]";
            // Make the request
            AudienceSegment response = await audienceSegmentServiceClient.GetAudienceSegmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegment</summary>
        public void GetAudienceSegmentResourceNames()
        {
            // Snippet: GetAudienceSegment(AudienceSegmentName, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            AudienceSegmentName name = AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]");
            // Make the request
            AudienceSegment response = audienceSegmentServiceClient.GetAudienceSegment(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentAsync</summary>
        public async Task GetAudienceSegmentResourceNamesAsync()
        {
            // Snippet: GetAudienceSegmentAsync(AudienceSegmentName, CallSettings)
            // Additional: GetAudienceSegmentAsync(AudienceSegmentName, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            AudienceSegmentName name = AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]");
            // Make the request
            AudienceSegment response = await audienceSegmentServiceClient.GetAudienceSegmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegments</summary>
        public void ListAudienceSegmentsRequestObject()
        {
            // Snippet: ListAudienceSegments(ListAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentsAsync</summary>
        public async Task ListAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: ListAudienceSegmentsAsync(ListAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAudienceSegmentsRequest request = new ListAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceSegment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceSegmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegments</summary>
        public void ListAudienceSegments()
        {
            // Snippet: ListAudienceSegments(string, string, int?, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentsAsync</summary>
        public async Task ListAudienceSegmentsAsync()
        {
            // Snippet: ListAudienceSegmentsAsync(string, string, int?, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceSegment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceSegmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegments</summary>
        public void ListAudienceSegmentsResourceNames()
        {
            // Snippet: ListAudienceSegments(NetworkName, string, int?, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentsAsync</summary>
        public async Task ListAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: ListAudienceSegmentsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentsResponse, AudienceSegment> response = audienceSegmentServiceClient.ListAudienceSegmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AudienceSegment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudienceSegmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegment item in singlePage)
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
