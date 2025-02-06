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
    using Google.Api.Gax;
    using Google.Cloud;
    using Google.Cloud.CloudQuotas.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudQuotasClientSnippets
    {
        /// <summary>Snippet for ListQuotaInfos</summary>
        public void ListQuotaInfosRequestObject()
        {
            // Snippet: ListQuotaInfos(ListQuotaInfosRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfos(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaInfosAsync</summary>
        public async Task ListQuotaInfosRequestObjectAsync()
        {
            // Snippet: ListQuotaInfosAsync(ListQuotaInfosRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            ListQuotaInfosRequest request = new ListQuotaInfosRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfosAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaInfosResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaInfos</summary>
        public void ListQuotaInfos()
        {
            // Snippet: ListQuotaInfos(string, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfos(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaInfosAsync</summary>
        public async Task ListQuotaInfosAsync()
        {
            // Snippet: ListQuotaInfosAsync(string, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfosAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaInfosResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaInfos</summary>
        public void ListQuotaInfosResourceNames()
        {
            // Snippet: ListQuotaInfos(ServiceName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfos(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaInfosAsync</summary>
        public async Task ListQuotaInfosResourceNamesAsync()
        {
            // Snippet: ListQuotaInfosAsync(ServiceName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListQuotaInfosResponse, QuotaInfo> response = cloudQuotasClient.ListQuotaInfosAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaInfosResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfo</summary>
        public void GetQuotaInfoRequestObject()
        {
            // Snippet: GetQuotaInfo(GetQuotaInfoRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            GetQuotaInfoRequest request = new GetQuotaInfoRequest
            {
                QuotaInfoName = QuotaInfoName.FromProjectLocationServiceQuotaInfo("[PROJECT]", "[LOCATION]", "[SERVICE]", "[QUOTA_INFO]"),
            };
            // Make the request
            QuotaInfo response = cloudQuotasClient.GetQuotaInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfoAsync</summary>
        public async Task GetQuotaInfoRequestObjectAsync()
        {
            // Snippet: GetQuotaInfoAsync(GetQuotaInfoRequest, CallSettings)
            // Additional: GetQuotaInfoAsync(GetQuotaInfoRequest, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            GetQuotaInfoRequest request = new GetQuotaInfoRequest
            {
                QuotaInfoName = QuotaInfoName.FromProjectLocationServiceQuotaInfo("[PROJECT]", "[LOCATION]", "[SERVICE]", "[QUOTA_INFO]"),
            };
            // Make the request
            QuotaInfo response = await cloudQuotasClient.GetQuotaInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfo</summary>
        public void GetQuotaInfo()
        {
            // Snippet: GetQuotaInfo(string, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/quotaInfos/[QUOTA_INFO]";
            // Make the request
            QuotaInfo response = cloudQuotasClient.GetQuotaInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfoAsync</summary>
        public async Task GetQuotaInfoAsync()
        {
            // Snippet: GetQuotaInfoAsync(string, CallSettings)
            // Additional: GetQuotaInfoAsync(string, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]/quotaInfos/[QUOTA_INFO]";
            // Make the request
            QuotaInfo response = await cloudQuotasClient.GetQuotaInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfo</summary>
        public void GetQuotaInfoResourceNames()
        {
            // Snippet: GetQuotaInfo(QuotaInfoName, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            QuotaInfoName name = QuotaInfoName.FromProjectLocationServiceQuotaInfo("[PROJECT]", "[LOCATION]", "[SERVICE]", "[QUOTA_INFO]");
            // Make the request
            QuotaInfo response = cloudQuotasClient.GetQuotaInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaInfoAsync</summary>
        public async Task GetQuotaInfoResourceNamesAsync()
        {
            // Snippet: GetQuotaInfoAsync(QuotaInfoName, CallSettings)
            // Additional: GetQuotaInfoAsync(QuotaInfoName, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            QuotaInfoName name = QuotaInfoName.FromProjectLocationServiceQuotaInfo("[PROJECT]", "[LOCATION]", "[SERVICE]", "[QUOTA_INFO]");
            // Make the request
            QuotaInfo response = await cloudQuotasClient.GetQuotaInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferences</summary>
        public void ListQuotaPreferencesRequestObject()
        {
            // Snippet: ListQuotaPreferences(ListQuotaPreferencesRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaPreference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaPreferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferencesAsync</summary>
        public async Task ListQuotaPreferencesRequestObjectAsync()
        {
            // Snippet: ListQuotaPreferencesAsync(ListQuotaPreferencesRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            ListQuotaPreferencesRequest request = new ListQuotaPreferencesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaPreference item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaPreferencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferences</summary>
        public void ListQuotaPreferences()
        {
            // Snippet: ListQuotaPreferences(string, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaPreference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaPreferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferencesAsync</summary>
        public async Task ListQuotaPreferencesAsync()
        {
            // Snippet: ListQuotaPreferencesAsync(string, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaPreference item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaPreferencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferences</summary>
        public void ListQuotaPreferencesResourceNames1()
        {
            // Snippet: ListQuotaPreferences(LocationName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaPreference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaPreferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferencesAsync</summary>
        public async Task ListQuotaPreferencesResourceNames1Async()
        {
            // Snippet: ListQuotaPreferencesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaPreference item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaPreferencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferences</summary>
        public void ListQuotaPreferencesResourceNames2()
        {
            // Snippet: ListQuotaPreferences(LocationName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaPreference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaPreferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaPreferencesAsync</summary>
        public async Task ListQuotaPreferencesResourceNames2Async()
        {
            // Snippet: ListQuotaPreferencesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListQuotaPreferencesResponse, QuotaPreference> response = cloudQuotasClient.ListQuotaPreferencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaPreference item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaPreferencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaPreference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaPreference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaPreference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreference</summary>
        public void GetQuotaPreferenceRequestObject()
        {
            // Snippet: GetQuotaPreference(GetQuotaPreferenceRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            GetQuotaPreferenceRequest request = new GetQuotaPreferenceRequest
            {
                QuotaPreferenceName = QuotaPreferenceName.FromProjectLocationQuotaPreference("[PROJECT]", "[LOCATION]", "[QUOTA_PREFERENCE]"),
            };
            // Make the request
            QuotaPreference response = cloudQuotasClient.GetQuotaPreference(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreferenceAsync</summary>
        public async Task GetQuotaPreferenceRequestObjectAsync()
        {
            // Snippet: GetQuotaPreferenceAsync(GetQuotaPreferenceRequest, CallSettings)
            // Additional: GetQuotaPreferenceAsync(GetQuotaPreferenceRequest, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            GetQuotaPreferenceRequest request = new GetQuotaPreferenceRequest
            {
                QuotaPreferenceName = QuotaPreferenceName.FromProjectLocationQuotaPreference("[PROJECT]", "[LOCATION]", "[QUOTA_PREFERENCE]"),
            };
            // Make the request
            QuotaPreference response = await cloudQuotasClient.GetQuotaPreferenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreference</summary>
        public void GetQuotaPreference()
        {
            // Snippet: GetQuotaPreference(string, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/quotaPreferences/[QUOTA_PREFERENCE]";
            // Make the request
            QuotaPreference response = cloudQuotasClient.GetQuotaPreference(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreferenceAsync</summary>
        public async Task GetQuotaPreferenceAsync()
        {
            // Snippet: GetQuotaPreferenceAsync(string, CallSettings)
            // Additional: GetQuotaPreferenceAsync(string, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/quotaPreferences/[QUOTA_PREFERENCE]";
            // Make the request
            QuotaPreference response = await cloudQuotasClient.GetQuotaPreferenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreference</summary>
        public void GetQuotaPreferenceResourceNames()
        {
            // Snippet: GetQuotaPreference(QuotaPreferenceName, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            QuotaPreferenceName name = QuotaPreferenceName.FromProjectLocationQuotaPreference("[PROJECT]", "[LOCATION]", "[QUOTA_PREFERENCE]");
            // Make the request
            QuotaPreference response = cloudQuotasClient.GetQuotaPreference(name);
            // End snippet
        }

        /// <summary>Snippet for GetQuotaPreferenceAsync</summary>
        public async Task GetQuotaPreferenceResourceNamesAsync()
        {
            // Snippet: GetQuotaPreferenceAsync(QuotaPreferenceName, CallSettings)
            // Additional: GetQuotaPreferenceAsync(QuotaPreferenceName, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            QuotaPreferenceName name = QuotaPreferenceName.FromProjectLocationQuotaPreference("[PROJECT]", "[LOCATION]", "[QUOTA_PREFERENCE]");
            // Make the request
            QuotaPreference response = await cloudQuotasClient.GetQuotaPreferenceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreferenceRequestObject()
        {
            // Snippet: CreateQuotaPreference(CreateQuotaPreferenceRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            CreateQuotaPreferenceRequest request = new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                QuotaPreferenceId = "",
                QuotaPreference = new QuotaPreference(),
                IgnoreSafetyChecks =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreferenceRequestObjectAsync()
        {
            // Snippet: CreateQuotaPreferenceAsync(CreateQuotaPreferenceRequest, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(CreateQuotaPreferenceRequest, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            CreateQuotaPreferenceRequest request = new CreateQuotaPreferenceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                QuotaPreferenceId = "",
                QuotaPreference = new QuotaPreference(),
                IgnoreSafetyChecks =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference1()
        {
            // Snippet: CreateQuotaPreference(string, QuotaPreference, string, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference1Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(string, QuotaPreference, string, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(string, QuotaPreference, string, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference1ResourceNames1()
        {
            // Snippet: CreateQuotaPreference(LocationName, QuotaPreference, string, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference1ResourceNames1Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, string, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, string, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference1ResourceNames2()
        {
            // Snippet: CreateQuotaPreference(LocationName, QuotaPreference, string, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference1ResourceNames2Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, string, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, string, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            string quotaPreferenceId = "";
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference, quotaPreferenceId);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference2()
        {
            // Snippet: CreateQuotaPreference(string, QuotaPreference, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference2Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(string, QuotaPreference, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(string, QuotaPreference, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference2ResourceNames1()
        {
            // Snippet: CreateQuotaPreference(LocationName, QuotaPreference, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference2ResourceNames1Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreference</summary>
        public void CreateQuotaPreference2ResourceNames2()
        {
            // Snippet: CreateQuotaPreference(LocationName, QuotaPreference, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = cloudQuotasClient.CreateQuotaPreference(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for CreateQuotaPreferenceAsync</summary>
        public async Task CreateQuotaPreference2ResourceNames2Async()
        {
            // Snippet: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, CallSettings)
            // Additional: CreateQuotaPreferenceAsync(LocationName, QuotaPreference, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            QuotaPreference quotaPreference = new QuotaPreference();
            // Make the request
            QuotaPreference response = await cloudQuotasClient.CreateQuotaPreferenceAsync(parent, quotaPreference);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaPreference</summary>
        public void UpdateQuotaPreferenceRequestObject()
        {
            // Snippet: UpdateQuotaPreference(UpdateQuotaPreferenceRequest, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            UpdateQuotaPreferenceRequest request = new UpdateQuotaPreferenceRequest
            {
                UpdateMask = new FieldMask(),
                QuotaPreference = new QuotaPreference(),
                AllowMissing = false,
                ValidateOnly = false,
                IgnoreSafetyChecks =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            QuotaPreference response = cloudQuotasClient.UpdateQuotaPreference(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaPreferenceAsync</summary>
        public async Task UpdateQuotaPreferenceRequestObjectAsync()
        {
            // Snippet: UpdateQuotaPreferenceAsync(UpdateQuotaPreferenceRequest, CallSettings)
            // Additional: UpdateQuotaPreferenceAsync(UpdateQuotaPreferenceRequest, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            UpdateQuotaPreferenceRequest request = new UpdateQuotaPreferenceRequest
            {
                UpdateMask = new FieldMask(),
                QuotaPreference = new QuotaPreference(),
                AllowMissing = false,
                ValidateOnly = false,
                IgnoreSafetyChecks =
                {
                    QuotaSafetyCheck.Unspecified,
                },
            };
            // Make the request
            QuotaPreference response = await cloudQuotasClient.UpdateQuotaPreferenceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaPreference</summary>
        public void UpdateQuotaPreference()
        {
            // Snippet: UpdateQuotaPreference(QuotaPreference, FieldMask, CallSettings)
            // Create client
            CloudQuotasClient cloudQuotasClient = CloudQuotasClient.Create();
            // Initialize request argument(s)
            QuotaPreference quotaPreference = new QuotaPreference();
            FieldMask updateMask = new FieldMask();
            // Make the request
            QuotaPreference response = cloudQuotasClient.UpdateQuotaPreference(quotaPreference, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateQuotaPreferenceAsync</summary>
        public async Task UpdateQuotaPreferenceAsync()
        {
            // Snippet: UpdateQuotaPreferenceAsync(QuotaPreference, FieldMask, CallSettings)
            // Additional: UpdateQuotaPreferenceAsync(QuotaPreference, FieldMask, CancellationToken)
            // Create client
            CloudQuotasClient cloudQuotasClient = await CloudQuotasClient.CreateAsync();
            // Initialize request argument(s)
            QuotaPreference quotaPreference = new QuotaPreference();
            FieldMask updateMask = new FieldMask();
            // Make the request
            QuotaPreference response = await cloudQuotasClient.UpdateQuotaPreferenceAsync(quotaPreference, updateMask);
            // End snippet
        }
    }
}
