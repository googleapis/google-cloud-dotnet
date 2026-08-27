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
    using System.Collections.Generic;
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
            await foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
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
            await foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
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
            await foreach (AudienceSegment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for BatchActivateAudienceSegments</summary>
        public void BatchActivateAudienceSegmentsRequestObject()
        {
            // Snippet: BatchActivateAudienceSegments(BatchActivateAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateAudienceSegmentsRequest request = new BatchActivateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchActivateAudienceSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAudienceSegmentsAsync</summary>
        public async Task BatchActivateAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: BatchActivateAudienceSegmentsAsync(BatchActivateAudienceSegmentsRequest, CallSettings)
            // Additional: BatchActivateAudienceSegmentsAsync(BatchActivateAudienceSegmentsRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateAudienceSegmentsRequest request = new BatchActivateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchActivateAudienceSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAudienceSegments</summary>
        public void BatchActivateAudienceSegments()
        {
            // Snippet: BatchActivateAudienceSegments(string, IEnumerable<string>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchActivateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAudienceSegmentsAsync</summary>
        public async Task BatchActivateAudienceSegmentsAsync()
        {
            // Snippet: BatchActivateAudienceSegmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateAudienceSegmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchActivateAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAudienceSegments</summary>
        public void BatchActivateAudienceSegmentsResourceNames()
        {
            // Snippet: BatchActivateAudienceSegments(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchActivateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAudienceSegmentsAsync</summary>
        public async Task BatchActivateAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: BatchActivateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Additional: BatchActivateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchActivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchActivateAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegments</summary>
        public void BatchDeactivateAudienceSegmentsRequestObject()
        {
            // Snippet: BatchDeactivateAudienceSegments(BatchDeactivateAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateAudienceSegmentsRequest request = new BatchDeactivateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchDeactivateAudienceSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegmentsAsync</summary>
        public async Task BatchDeactivateAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateAudienceSegmentsAsync(BatchDeactivateAudienceSegmentsRequest, CallSettings)
            // Additional: BatchDeactivateAudienceSegmentsAsync(BatchDeactivateAudienceSegmentsRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateAudienceSegmentsRequest request = new BatchDeactivateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchDeactivateAudienceSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegments</summary>
        public void BatchDeactivateAudienceSegments()
        {
            // Snippet: BatchDeactivateAudienceSegments(string, IEnumerable<string>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchDeactivateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegmentsAsync</summary>
        public async Task BatchDeactivateAudienceSegmentsAsync()
        {
            // Snippet: BatchDeactivateAudienceSegmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateAudienceSegmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchDeactivateAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegments</summary>
        public void BatchDeactivateAudienceSegmentsResourceNames()
        {
            // Snippet: BatchDeactivateAudienceSegments(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchDeactivateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAudienceSegmentsAsync</summary>
        public async Task BatchDeactivateAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Additional: BatchDeactivateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchDeactivateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchDeactivateAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegments</summary>
        public void BatchApproveAudienceSegmentsRequestObject()
        {
            // Snippet: BatchApproveAudienceSegments(BatchApproveAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchApproveAudienceSegmentsRequest request = new BatchApproveAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchApproveAudienceSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegmentsAsync</summary>
        public async Task BatchApproveAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: BatchApproveAudienceSegmentsAsync(BatchApproveAudienceSegmentsRequest, CallSettings)
            // Additional: BatchApproveAudienceSegmentsAsync(BatchApproveAudienceSegmentsRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchApproveAudienceSegmentsRequest request = new BatchApproveAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchApproveAudienceSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegments</summary>
        public void BatchApproveAudienceSegments()
        {
            // Snippet: BatchApproveAudienceSegments(string, IEnumerable<string>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchApproveAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegmentsAsync</summary>
        public async Task BatchApproveAudienceSegmentsAsync()
        {
            // Snippet: BatchApproveAudienceSegmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchApproveAudienceSegmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchApproveAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegments</summary>
        public void BatchApproveAudienceSegmentsResourceNames()
        {
            // Snippet: BatchApproveAudienceSegments(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchApproveAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAudienceSegmentsAsync</summary>
        public async Task BatchApproveAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: BatchApproveAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Additional: BatchApproveAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchApproveAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchApproveAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegments</summary>
        public void BatchRejectAudienceSegmentsRequestObject()
        {
            // Snippet: BatchRejectAudienceSegments(BatchRejectAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchRejectAudienceSegmentsRequest request = new BatchRejectAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchRejectAudienceSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegmentsAsync</summary>
        public async Task BatchRejectAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: BatchRejectAudienceSegmentsAsync(BatchRejectAudienceSegmentsRequest, CallSettings)
            // Additional: BatchRejectAudienceSegmentsAsync(BatchRejectAudienceSegmentsRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRejectAudienceSegmentsRequest request = new BatchRejectAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchRejectAudienceSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegments</summary>
        public void BatchRejectAudienceSegments()
        {
            // Snippet: BatchRejectAudienceSegments(string, IEnumerable<string>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchRejectAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegmentsAsync</summary>
        public async Task BatchRejectAudienceSegmentsAsync()
        {
            // Snippet: BatchRejectAudienceSegmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRejectAudienceSegmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchRejectAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegments</summary>
        public void BatchRejectAudienceSegmentsResourceNames()
        {
            // Snippet: BatchRejectAudienceSegments(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchRejectAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectAudienceSegmentsAsync</summary>
        public async Task BatchRejectAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: BatchRejectAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Additional: BatchRejectAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchRejectAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchRejectAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegments</summary>
        public void BatchPopulateAudienceSegmentsRequestObject()
        {
            // Snippet: BatchPopulateAudienceSegments(BatchPopulateAudienceSegmentsRequest, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            BatchPopulateAudienceSegmentsRequest request = new BatchPopulateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchPopulateAudienceSegments(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegmentsAsync</summary>
        public async Task BatchPopulateAudienceSegmentsRequestObjectAsync()
        {
            // Snippet: BatchPopulateAudienceSegmentsAsync(BatchPopulateAudienceSegmentsRequest, CallSettings)
            // Additional: BatchPopulateAudienceSegmentsAsync(BatchPopulateAudienceSegmentsRequest, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPopulateAudienceSegmentsRequest request = new BatchPopulateAudienceSegmentsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AudienceSegmentNames =
                {
                    AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
                },
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchPopulateAudienceSegmentsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegments</summary>
        public void BatchPopulateAudienceSegments()
        {
            // Snippet: BatchPopulateAudienceSegments(string, IEnumerable<string>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchPopulateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegmentsAsync</summary>
        public async Task BatchPopulateAudienceSegmentsAsync()
        {
            // Snippet: BatchPopulateAudienceSegmentsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPopulateAudienceSegmentsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/audienceSegments/[AUDIENCE_SEGMENT]",
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchPopulateAudienceSegmentsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegments</summary>
        public void BatchPopulateAudienceSegmentsResourceNames()
        {
            // Snippet: BatchPopulateAudienceSegments(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = AudienceSegmentServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = audienceSegmentServiceClient.BatchPopulateAudienceSegments(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPopulateAudienceSegmentsAsync</summary>
        public async Task BatchPopulateAudienceSegmentsResourceNamesAsync()
        {
            // Snippet: BatchPopulateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CallSettings)
            // Additional: BatchPopulateAudienceSegmentsAsync(NetworkName, IEnumerable<AudienceSegmentName>, CancellationToken)
            // Create client
            AudienceSegmentServiceClient audienceSegmentServiceClient = await AudienceSegmentServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AudienceSegmentName> names = new AudienceSegmentName[]
            {
                AudienceSegmentName.FromNetworkCodeAudienceSegment("[NETWORK_CODE]", "[AUDIENCE_SEGMENT]"),
            };
            // Make the request
            BatchPopulateAudienceSegmentsResponse response = await audienceSegmentServiceClient.BatchPopulateAudienceSegmentsAsync(parent, names);
            // End snippet
        }
    }
}
