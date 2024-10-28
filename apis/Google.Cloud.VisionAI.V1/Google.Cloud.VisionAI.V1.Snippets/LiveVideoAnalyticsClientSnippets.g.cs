// Copyright 2024 Google LLC
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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.VisionAI.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLiveVideoAnalyticsClientSnippets
    {
        /// <summary>Snippet for ListPublicOperators</summary>
        public void ListPublicOperatorsRequestObject()
        {
            // Snippet: ListPublicOperators(ListPublicOperatorsRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperators(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicOperatorsAsync</summary>
        public async Task ListPublicOperatorsRequestObjectAsync()
        {
            // Snippet: ListPublicOperatorsAsync(ListPublicOperatorsRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperatorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicOperators</summary>
        public void ListPublicOperators()
        {
            // Snippet: ListPublicOperators(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicOperatorsAsync</summary>
        public async Task ListPublicOperatorsAsync()
        {
            // Snippet: ListPublicOperatorsAsync(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicOperators</summary>
        public void ListPublicOperatorsResourceNames()
        {
            // Snippet: ListPublicOperators(LocationName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicOperatorsAsync</summary>
        public async Task ListPublicOperatorsResourceNamesAsync()
        {
            // Snippet: ListPublicOperatorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListPublicOperatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfo</summary>
        public void ResolveOperatorInfoRequestObject()
        {
            // Snippet: ResolveOperatorInfo(ResolveOperatorInfoRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ResolveOperatorInfoRequest request = new ResolveOperatorInfoRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queries =
                {
                    new OperatorQuery(),
                },
            };
            // Make the request
            ResolveOperatorInfoResponse response = liveVideoAnalyticsClient.ResolveOperatorInfo(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfoAsync</summary>
        public async Task ResolveOperatorInfoRequestObjectAsync()
        {
            // Snippet: ResolveOperatorInfoAsync(ResolveOperatorInfoRequest, CallSettings)
            // Additional: ResolveOperatorInfoAsync(ResolveOperatorInfoRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ResolveOperatorInfoRequest request = new ResolveOperatorInfoRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Queries =
                {
                    new OperatorQuery(),
                },
            };
            // Make the request
            ResolveOperatorInfoResponse response = await liveVideoAnalyticsClient.ResolveOperatorInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfo</summary>
        public void ResolveOperatorInfo()
        {
            // Snippet: ResolveOperatorInfo(string, IEnumerable<OperatorQuery>, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<OperatorQuery> queries = new OperatorQuery[]
            {
                new OperatorQuery(),
            };
            // Make the request
            ResolveOperatorInfoResponse response = liveVideoAnalyticsClient.ResolveOperatorInfo(parent, queries);
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfoAsync</summary>
        public async Task ResolveOperatorInfoAsync()
        {
            // Snippet: ResolveOperatorInfoAsync(string, IEnumerable<OperatorQuery>, CallSettings)
            // Additional: ResolveOperatorInfoAsync(string, IEnumerable<OperatorQuery>, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<OperatorQuery> queries = new OperatorQuery[]
            {
                new OperatorQuery(),
            };
            // Make the request
            ResolveOperatorInfoResponse response = await liveVideoAnalyticsClient.ResolveOperatorInfoAsync(parent, queries);
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfo</summary>
        public void ResolveOperatorInfoResourceNames()
        {
            // Snippet: ResolveOperatorInfo(LocationName, IEnumerable<OperatorQuery>, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<OperatorQuery> queries = new OperatorQuery[]
            {
                new OperatorQuery(),
            };
            // Make the request
            ResolveOperatorInfoResponse response = liveVideoAnalyticsClient.ResolveOperatorInfo(parent, queries);
            // End snippet
        }

        /// <summary>Snippet for ResolveOperatorInfoAsync</summary>
        public async Task ResolveOperatorInfoResourceNamesAsync()
        {
            // Snippet: ResolveOperatorInfoAsync(LocationName, IEnumerable<OperatorQuery>, CallSettings)
            // Additional: ResolveOperatorInfoAsync(LocationName, IEnumerable<OperatorQuery>, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<OperatorQuery> queries = new OperatorQuery[]
            {
                new OperatorQuery(),
            };
            // Make the request
            ResolveOperatorInfoResponse response = await liveVideoAnalyticsClient.ResolveOperatorInfoAsync(parent, queries);
            // End snippet
        }

        /// <summary>Snippet for ListOperators</summary>
        public void ListOperatorsRequestObject()
        {
            // Snippet: ListOperators(ListOperatorsRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ListOperatorsRequest request = new ListOperatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperators(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatorsAsync</summary>
        public async Task ListOperatorsRequestObjectAsync()
        {
            // Snippet: ListOperatorsAsync(ListOperatorsRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ListOperatorsRequest request = new ListOperatorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperatorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperators</summary>
        public void ListOperators()
        {
            // Snippet: ListOperators(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatorsAsync</summary>
        public async Task ListOperatorsAsync()
        {
            // Snippet: ListOperatorsAsync(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperators</summary>
        public void ListOperatorsResourceNames()
        {
            // Snippet: ListOperators(LocationName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperators(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operator item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatorsAsync</summary>
        public async Task ListOperatorsResourceNamesAsync()
        {
            // Snippet: ListOperatorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOperatorsResponse, Operator> response = liveVideoAnalyticsClient.ListOperatorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operator item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operator item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operator> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operator item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOperator</summary>
        public void GetOperatorRequestObject()
        {
            // Snippet: GetOperator(GetOperatorRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            GetOperatorRequest request = new GetOperatorRequest
            {
                OperatorName = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]"),
            };
            // Make the request
            Operator response = liveVideoAnalyticsClient.GetOperator(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatorAsync</summary>
        public async Task GetOperatorRequestObjectAsync()
        {
            // Snippet: GetOperatorAsync(GetOperatorRequest, CallSettings)
            // Additional: GetOperatorAsync(GetOperatorRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            GetOperatorRequest request = new GetOperatorRequest
            {
                OperatorName = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]"),
            };
            // Make the request
            Operator response = await liveVideoAnalyticsClient.GetOperatorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperator</summary>
        public void GetOperator()
        {
            // Snippet: GetOperator(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/operators/[OPERATOR]";
            // Make the request
            Operator response = liveVideoAnalyticsClient.GetOperator(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatorAsync</summary>
        public async Task GetOperatorAsync()
        {
            // Snippet: GetOperatorAsync(string, CallSettings)
            // Additional: GetOperatorAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/operators/[OPERATOR]";
            // Make the request
            Operator response = await liveVideoAnalyticsClient.GetOperatorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperator</summary>
        public void GetOperatorResourceNames()
        {
            // Snippet: GetOperator(OperatorName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            OperatorName name = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]");
            // Make the request
            Operator response = liveVideoAnalyticsClient.GetOperator(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatorAsync</summary>
        public async Task GetOperatorResourceNamesAsync()
        {
            // Snippet: GetOperatorAsync(OperatorName, CallSettings)
            // Additional: GetOperatorAsync(OperatorName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            OperatorName name = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]");
            // Make the request
            Operator response = await liveVideoAnalyticsClient.GetOperatorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOperator</summary>
        public void CreateOperatorRequestObject()
        {
            // Snippet: CreateOperator(CreateOperatorRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            CreateOperatorRequest request = new CreateOperatorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OperatorId = "",
                Operator = new Operator(),
                RequestId = "",
            };
            // Make the request
            Operation<Operator, OperationMetadata> response = liveVideoAnalyticsClient.CreateOperator(request);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOperatorAsync</summary>
        public async Task CreateOperatorRequestObjectAsync()
        {
            // Snippet: CreateOperatorAsync(CreateOperatorRequest, CallSettings)
            // Additional: CreateOperatorAsync(CreateOperatorRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            CreateOperatorRequest request = new CreateOperatorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OperatorId = "",
                Operator = new Operator(),
                RequestId = "",
            };
            // Make the request
            Operation<Operator, OperationMetadata> response = await liveVideoAnalyticsClient.CreateOperatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOperator</summary>
        public void CreateOperator()
        {
            // Snippet: CreateOperator(string, Operator, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Operator @operator = new Operator();
            string operatorId = "";
            // Make the request
            Operation<Operator, OperationMetadata> response = liveVideoAnalyticsClient.CreateOperator(parent, @operator, operatorId);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOperatorAsync</summary>
        public async Task CreateOperatorAsync()
        {
            // Snippet: CreateOperatorAsync(string, Operator, string, CallSettings)
            // Additional: CreateOperatorAsync(string, Operator, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Operator @operator = new Operator();
            string operatorId = "";
            // Make the request
            Operation<Operator, OperationMetadata> response = await liveVideoAnalyticsClient.CreateOperatorAsync(parent, @operator, operatorId);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOperator</summary>
        public void CreateOperatorResourceNames()
        {
            // Snippet: CreateOperator(LocationName, Operator, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Operator @operator = new Operator();
            string operatorId = "";
            // Make the request
            Operation<Operator, OperationMetadata> response = liveVideoAnalyticsClient.CreateOperator(parent, @operator, operatorId);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOperatorAsync</summary>
        public async Task CreateOperatorResourceNamesAsync()
        {
            // Snippet: CreateOperatorAsync(LocationName, Operator, string, CallSettings)
            // Additional: CreateOperatorAsync(LocationName, Operator, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Operator @operator = new Operator();
            string operatorId = "";
            // Make the request
            Operation<Operator, OperationMetadata> response = await liveVideoAnalyticsClient.CreateOperatorAsync(parent, @operator, operatorId);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOperator</summary>
        public void UpdateOperatorRequestObject()
        {
            // Snippet: UpdateOperator(UpdateOperatorRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            UpdateOperatorRequest request = new UpdateOperatorRequest
            {
                UpdateMask = new FieldMask(),
                Operator = new Operator(),
                RequestId = "",
            };
            // Make the request
            Operation<Operator, OperationMetadata> response = liveVideoAnalyticsClient.UpdateOperator(request);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOperatorAsync</summary>
        public async Task UpdateOperatorRequestObjectAsync()
        {
            // Snippet: UpdateOperatorAsync(UpdateOperatorRequest, CallSettings)
            // Additional: UpdateOperatorAsync(UpdateOperatorRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOperatorRequest request = new UpdateOperatorRequest
            {
                UpdateMask = new FieldMask(),
                Operator = new Operator(),
                RequestId = "",
            };
            // Make the request
            Operation<Operator, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateOperatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOperator</summary>
        public void UpdateOperator()
        {
            // Snippet: UpdateOperator(Operator, FieldMask, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            Operator @operator = new Operator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Operator, OperationMetadata> response = liveVideoAnalyticsClient.UpdateOperator(@operator, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOperatorAsync</summary>
        public async Task UpdateOperatorAsync()
        {
            // Snippet: UpdateOperatorAsync(Operator, FieldMask, CallSettings)
            // Additional: UpdateOperatorAsync(Operator, FieldMask, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            Operator @operator = new Operator();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Operator, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateOperatorAsync(@operator, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Operator, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operator result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Operator, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operator retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperator</summary>
        public void DeleteOperatorRequestObject()
        {
            // Snippet: DeleteOperator(DeleteOperatorRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            DeleteOperatorRequest request = new DeleteOperatorRequest
            {
                OperatorName = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteOperator(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperatorAsync</summary>
        public async Task DeleteOperatorRequestObjectAsync()
        {
            // Snippet: DeleteOperatorAsync(DeleteOperatorRequest, CallSettings)
            // Additional: DeleteOperatorAsync(DeleteOperatorRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOperatorRequest request = new DeleteOperatorRequest
            {
                OperatorName = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteOperatorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperator</summary>
        public void DeleteOperator()
        {
            // Snippet: DeleteOperator(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/operators/[OPERATOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteOperator(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperatorAsync</summary>
        public async Task DeleteOperatorAsync()
        {
            // Snippet: DeleteOperatorAsync(string, CallSettings)
            // Additional: DeleteOperatorAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/operators/[OPERATOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteOperatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperator</summary>
        public void DeleteOperatorResourceNames()
        {
            // Snippet: DeleteOperator(OperatorName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            OperatorName name = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteOperator(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteOperator(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOperatorAsync</summary>
        public async Task DeleteOperatorResourceNamesAsync()
        {
            // Snippet: DeleteOperatorAsync(OperatorName, CallSettings)
            // Additional: DeleteOperatorAsync(OperatorName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            OperatorName name = OperatorName.FromProjectLocationOperator("[PROJECT]", "[LOCATION]", "[OPERATOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteOperatorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteOperatorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalysesRequestObject()
        {
            // Snippet: ListAnalyses(ListAnalysesRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalyses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesRequestObjectAsync()
        {
            // Snippet: ListAnalysesAsync(ListAnalysesRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalysesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalyses()
        {
            // Snippet: ListAnalyses(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalyses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesAsync()
        {
            // Snippet: ListAnalysesAsync(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalysesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalysesResourceNames()
        {
            // Snippet: ListAnalyses(ClusterName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalyses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesResourceNamesAsync()
        {
            // Snippet: ListAnalysesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = liveVideoAnalyticsClient.ListAnalysesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysisRequestObject()
        {
            // Snippet: GetAnalysis(GetAnalysisRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]"),
            };
            // Make the request
            Analysis response = liveVideoAnalyticsClient.GetAnalysis(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisRequestObjectAsync()
        {
            // Snippet: GetAnalysisAsync(GetAnalysisRequest, CallSettings)
            // Additional: GetAnalysisAsync(GetAnalysisRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]"),
            };
            // Make the request
            Analysis response = await liveVideoAnalyticsClient.GetAnalysisAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysis()
        {
            // Snippet: GetAnalysis(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/analyses/[ANALYSIS]";
            // Make the request
            Analysis response = liveVideoAnalyticsClient.GetAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisAsync()
        {
            // Snippet: GetAnalysisAsync(string, CallSettings)
            // Additional: GetAnalysisAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/analyses/[ANALYSIS]";
            // Make the request
            Analysis response = await liveVideoAnalyticsClient.GetAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysisResourceNames()
        {
            // Snippet: GetAnalysis(AnalysisName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]");
            // Make the request
            Analysis response = liveVideoAnalyticsClient.GetAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisResourceNamesAsync()
        {
            // Snippet: GetAnalysisAsync(AnalysisName, CallSettings)
            // Additional: GetAnalysisAsync(AnalysisName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]");
            // Make the request
            Analysis response = await liveVideoAnalyticsClient.GetAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysisRequestObject()
        {
            // Snippet: CreateAnalysis(CreateAnalysisRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            CreateAnalysisRequest request = new CreateAnalysisRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                AnalysisId = "",
                Analysis = new Analysis(),
                RequestId = "",
            };
            // Make the request
            Operation<Analysis, OperationMetadata> response = liveVideoAnalyticsClient.CreateAnalysis(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisRequestObjectAsync()
        {
            // Snippet: CreateAnalysisAsync(CreateAnalysisRequest, CallSettings)
            // Additional: CreateAnalysisAsync(CreateAnalysisRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnalysisRequest request = new CreateAnalysisRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                AnalysisId = "",
                Analysis = new Analysis(),
                RequestId = "",
            };
            // Make the request
            Operation<Analysis, OperationMetadata> response = await liveVideoAnalyticsClient.CreateAnalysisAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysis()
        {
            // Snippet: CreateAnalysis(string, Analysis, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Analysis analysis = new Analysis();
            string analysisId = "";
            // Make the request
            Operation<Analysis, OperationMetadata> response = liveVideoAnalyticsClient.CreateAnalysis(parent, analysis, analysisId);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisAsync()
        {
            // Snippet: CreateAnalysisAsync(string, Analysis, string, CallSettings)
            // Additional: CreateAnalysisAsync(string, Analysis, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Analysis analysis = new Analysis();
            string analysisId = "";
            // Make the request
            Operation<Analysis, OperationMetadata> response = await liveVideoAnalyticsClient.CreateAnalysisAsync(parent, analysis, analysisId);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysisResourceNames()
        {
            // Snippet: CreateAnalysis(ClusterName, Analysis, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Analysis analysis = new Analysis();
            string analysisId = "";
            // Make the request
            Operation<Analysis, OperationMetadata> response = liveVideoAnalyticsClient.CreateAnalysis(parent, analysis, analysisId);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisResourceNamesAsync()
        {
            // Snippet: CreateAnalysisAsync(ClusterName, Analysis, string, CallSettings)
            // Additional: CreateAnalysisAsync(ClusterName, Analysis, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Analysis analysis = new Analysis();
            string analysisId = "";
            // Make the request
            Operation<Analysis, OperationMetadata> response = await liveVideoAnalyticsClient.CreateAnalysisAsync(parent, analysis, analysisId);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnalysis</summary>
        public void UpdateAnalysisRequestObject()
        {
            // Snippet: UpdateAnalysis(UpdateAnalysisRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            UpdateAnalysisRequest request = new UpdateAnalysisRequest
            {
                UpdateMask = new FieldMask(),
                Analysis = new Analysis(),
                RequestId = "",
            };
            // Make the request
            Operation<Analysis, OperationMetadata> response = liveVideoAnalyticsClient.UpdateAnalysis(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnalysisAsync</summary>
        public async Task UpdateAnalysisRequestObjectAsync()
        {
            // Snippet: UpdateAnalysisAsync(UpdateAnalysisRequest, CallSettings)
            // Additional: UpdateAnalysisAsync(UpdateAnalysisRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAnalysisRequest request = new UpdateAnalysisRequest
            {
                UpdateMask = new FieldMask(),
                Analysis = new Analysis(),
                RequestId = "",
            };
            // Make the request
            Operation<Analysis, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateAnalysisAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnalysis</summary>
        public void UpdateAnalysis()
        {
            // Snippet: UpdateAnalysis(Analysis, FieldMask, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            Analysis analysis = new Analysis();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Analysis, OperationMetadata> response = liveVideoAnalyticsClient.UpdateAnalysis(analysis, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAnalysisAsync</summary>
        public async Task UpdateAnalysisAsync()
        {
            // Snippet: UpdateAnalysisAsync(Analysis, FieldMask, CallSettings)
            // Additional: UpdateAnalysisAsync(Analysis, FieldMask, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            Analysis analysis = new Analysis();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Analysis, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateAnalysisAsync(analysis, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysisRequestObject()
        {
            // Snippet: DeleteAnalysis(DeleteAnalysisRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteAnalysis(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisRequestObjectAsync()
        {
            // Snippet: DeleteAnalysisAsync(DeleteAnalysisRequest, CallSettings)
            // Additional: DeleteAnalysisAsync(DeleteAnalysisRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteAnalysisAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysis()
        {
            // Snippet: DeleteAnalysis(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/analyses/[ANALYSIS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteAnalysis(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisAsync()
        {
            // Snippet: DeleteAnalysisAsync(string, CallSettings)
            // Additional: DeleteAnalysisAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/analyses/[ANALYSIS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteAnalysisAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysisResourceNames()
        {
            // Snippet: DeleteAnalysis(AnalysisName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteAnalysis(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisResourceNamesAsync()
        {
            // Snippet: DeleteAnalysisAsync(AnalysisName, CallSettings)
            // Additional: DeleteAnalysisAsync(AnalysisName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationClusterAnalysis("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ANALYSIS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteAnalysisAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcessesRequestObject()
        {
            // Snippet: ListProcesses(ListProcessesRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcesses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesRequestObjectAsync()
        {
            // Snippet: ListProcessesAsync(ListProcessesRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcessesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcesses()
        {
            // Snippet: ListProcesses(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcesses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesAsync()
        {
            // Snippet: ListProcessesAsync(string, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcessesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcesses</summary>
        public void ListProcessesResourceNames()
        {
            // Snippet: ListProcesses(ClusterName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcesses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Process item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProcessesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProcessesAsync</summary>
        public async Task ListProcessesResourceNamesAsync()
        {
            // Snippet: ListProcessesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListProcessesResponse, Process> response = liveVideoAnalyticsClient.ListProcessesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Process item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProcessesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Process item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Process> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Process item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcessRequestObject()
        {
            // Snippet: GetProcess(GetProcessRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            GetProcessRequest request = new GetProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]"),
            };
            // Make the request
            Process response = liveVideoAnalyticsClient.GetProcess(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessRequestObjectAsync()
        {
            // Snippet: GetProcessAsync(GetProcessRequest, CallSettings)
            // Additional: GetProcessAsync(GetProcessRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            GetProcessRequest request = new GetProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]"),
            };
            // Make the request
            Process response = await liveVideoAnalyticsClient.GetProcessAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcess()
        {
            // Snippet: GetProcess(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/processes/[PROCESS]";
            // Make the request
            Process response = liveVideoAnalyticsClient.GetProcess(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessAsync()
        {
            // Snippet: GetProcessAsync(string, CallSettings)
            // Additional: GetProcessAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/processes/[PROCESS]";
            // Make the request
            Process response = await liveVideoAnalyticsClient.GetProcessAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcess</summary>
        public void GetProcessResourceNames()
        {
            // Snippet: GetProcess(ProcessName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]");
            // Make the request
            Process response = liveVideoAnalyticsClient.GetProcess(name);
            // End snippet
        }

        /// <summary>Snippet for GetProcessAsync</summary>
        public async Task GetProcessResourceNamesAsync()
        {
            // Snippet: GetProcessAsync(ProcessName, CallSettings)
            // Additional: GetProcessAsync(ProcessName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]");
            // Make the request
            Process response = await liveVideoAnalyticsClient.GetProcessAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcessRequestObject()
        {
            // Snippet: CreateProcess(CreateProcessRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            CreateProcessRequest request = new CreateProcessRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                ProcessId = "",
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Operation<Process, OperationMetadata> response = liveVideoAnalyticsClient.CreateProcess(request);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessRequestObjectAsync()
        {
            // Snippet: CreateProcessAsync(CreateProcessRequest, CallSettings)
            // Additional: CreateProcessAsync(CreateProcessRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            CreateProcessRequest request = new CreateProcessRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                ProcessId = "",
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Operation<Process, OperationMetadata> response = await liveVideoAnalyticsClient.CreateProcessAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcess()
        {
            // Snippet: CreateProcess(string, Process, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Process process = new Process();
            string processId = "";
            // Make the request
            Operation<Process, OperationMetadata> response = liveVideoAnalyticsClient.CreateProcess(parent, process, processId);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessAsync()
        {
            // Snippet: CreateProcessAsync(string, Process, string, CallSettings)
            // Additional: CreateProcessAsync(string, Process, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Process process = new Process();
            string processId = "";
            // Make the request
            Operation<Process, OperationMetadata> response = await liveVideoAnalyticsClient.CreateProcessAsync(parent, process, processId);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcess</summary>
        public void CreateProcessResourceNames()
        {
            // Snippet: CreateProcess(ClusterName, Process, string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Process process = new Process();
            string processId = "";
            // Make the request
            Operation<Process, OperationMetadata> response = liveVideoAnalyticsClient.CreateProcess(parent, process, processId);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceCreateProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateProcessAsync</summary>
        public async Task CreateProcessResourceNamesAsync()
        {
            // Snippet: CreateProcessAsync(ClusterName, Process, string, CallSettings)
            // Additional: CreateProcessAsync(ClusterName, Process, string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Process process = new Process();
            string processId = "";
            // Make the request
            Operation<Process, OperationMetadata> response = await liveVideoAnalyticsClient.CreateProcessAsync(parent, process, processId);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceCreateProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcess</summary>
        public void UpdateProcessRequestObject()
        {
            // Snippet: UpdateProcess(UpdateProcessRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            UpdateProcessRequest request = new UpdateProcessRequest
            {
                UpdateMask = new FieldMask(),
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Operation<Process, OperationMetadata> response = liveVideoAnalyticsClient.UpdateProcess(request);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessAsync</summary>
        public async Task UpdateProcessRequestObjectAsync()
        {
            // Snippet: UpdateProcessAsync(UpdateProcessRequest, CallSettings)
            // Additional: UpdateProcessAsync(UpdateProcessRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProcessRequest request = new UpdateProcessRequest
            {
                UpdateMask = new FieldMask(),
                Process = new Process(),
                RequestId = "",
            };
            // Make the request
            Operation<Process, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateProcessAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcess</summary>
        public void UpdateProcess()
        {
            // Snippet: UpdateProcess(Process, FieldMask, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            Process process = new Process();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Process, OperationMetadata> response = liveVideoAnalyticsClient.UpdateProcess(process, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceUpdateProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateProcessAsync</summary>
        public async Task UpdateProcessAsync()
        {
            // Snippet: UpdateProcessAsync(Process, FieldMask, CallSettings)
            // Additional: UpdateProcessAsync(Process, FieldMask, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            Process process = new Process();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Process, OperationMetadata> response = await liveVideoAnalyticsClient.UpdateProcessAsync(process, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Process, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Process result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Process, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceUpdateProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Process retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcessRequestObject()
        {
            // Snippet: DeleteProcess(DeleteProcessRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            DeleteProcessRequest request = new DeleteProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteProcess(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessRequestObjectAsync()
        {
            // Snippet: DeleteProcessAsync(DeleteProcessRequest, CallSettings)
            // Additional: DeleteProcessAsync(DeleteProcessRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProcessRequest request = new DeleteProcessRequest
            {
                ProcessName = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteProcessAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcess()
        {
            // Snippet: DeleteProcess(string, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/processes/[PROCESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteProcess(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessAsync()
        {
            // Snippet: DeleteProcessAsync(string, CallSettings)
            // Additional: DeleteProcessAsync(string, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/processes/[PROCESS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteProcessAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcess</summary>
        public void DeleteProcessResourceNames()
        {
            // Snippet: DeleteProcess(ProcessName, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = liveVideoAnalyticsClient.DeleteProcess(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceDeleteProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteProcessAsync</summary>
        public async Task DeleteProcessResourceNamesAsync()
        {
            // Snippet: DeleteProcessAsync(ProcessName, CallSettings)
            // Additional: DeleteProcessAsync(ProcessName, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ProcessName name = ProcessName.FromProjectLocationClusterProcess("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[PROCESS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await liveVideoAnalyticsClient.DeleteProcessAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceDeleteProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcess</summary>
        public void BatchRunProcessRequestObject()
        {
            // Snippet: BatchRunProcess(BatchRunProcessRequest, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            BatchRunProcessRequest request = new BatchRunProcessRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Requests =
                {
                    new CreateProcessRequest(),
                },
                Options = new BatchRunProcessRequest.Types.BatchRunProcessOptions(),
                BatchId = "",
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = liveVideoAnalyticsClient.BatchRunProcess(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceBatchRunProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcessAsync</summary>
        public async Task BatchRunProcessRequestObjectAsync()
        {
            // Snippet: BatchRunProcessAsync(BatchRunProcessRequest, CallSettings)
            // Additional: BatchRunProcessAsync(BatchRunProcessRequest, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            BatchRunProcessRequest request = new BatchRunProcessRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Requests =
                {
                    new CreateProcessRequest(),
                },
                Options = new BatchRunProcessRequest.Types.BatchRunProcessOptions(),
                BatchId = "",
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = await liveVideoAnalyticsClient.BatchRunProcessAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceBatchRunProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcess</summary>
        public void BatchRunProcess()
        {
            // Snippet: BatchRunProcess(string, IEnumerable<CreateProcessRequest>, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            IEnumerable<CreateProcessRequest> requests = new CreateProcessRequest[]
            {
                new CreateProcessRequest(),
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = liveVideoAnalyticsClient.BatchRunProcess(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceBatchRunProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcessAsync</summary>
        public async Task BatchRunProcessAsync()
        {
            // Snippet: BatchRunProcessAsync(string, IEnumerable<CreateProcessRequest>, CallSettings)
            // Additional: BatchRunProcessAsync(string, IEnumerable<CreateProcessRequest>, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            IEnumerable<CreateProcessRequest> requests = new CreateProcessRequest[]
            {
                new CreateProcessRequest(),
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = await liveVideoAnalyticsClient.BatchRunProcessAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceBatchRunProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcess</summary>
        public void BatchRunProcessResourceNames()
        {
            // Snippet: BatchRunProcess(ClusterName, IEnumerable<CreateProcessRequest>, CallSettings)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = LiveVideoAnalyticsClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            IEnumerable<CreateProcessRequest> requests = new CreateProcessRequest[]
            {
                new CreateProcessRequest(),
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = liveVideoAnalyticsClient.BatchRunProcess(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = liveVideoAnalyticsClient.PollOnceBatchRunProcess(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchRunProcessAsync</summary>
        public async Task BatchRunProcessResourceNamesAsync()
        {
            // Snippet: BatchRunProcessAsync(ClusterName, IEnumerable<CreateProcessRequest>, CallSettings)
            // Additional: BatchRunProcessAsync(ClusterName, IEnumerable<CreateProcessRequest>, CancellationToken)
            // Create client
            LiveVideoAnalyticsClient liveVideoAnalyticsClient = await LiveVideoAnalyticsClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            IEnumerable<CreateProcessRequest> requests = new CreateProcessRequest[]
            {
                new CreateProcessRequest(),
            };
            // Make the request
            Operation<BatchRunProcessResponse, OperationMetadata> response = await liveVideoAnalyticsClient.BatchRunProcessAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchRunProcessResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchRunProcessResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchRunProcessResponse, OperationMetadata> retrievedResponse = await liveVideoAnalyticsClient.PollOnceBatchRunProcessAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchRunProcessResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
