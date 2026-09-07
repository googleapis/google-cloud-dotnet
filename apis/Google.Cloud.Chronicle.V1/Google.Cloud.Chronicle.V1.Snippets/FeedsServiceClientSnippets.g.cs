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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFeedsServiceClientSnippets
    {
        /// <summary>Snippet for FetchServiceAccountForCustomer</summary>
        public void FetchServiceAccountForCustomerRequestObject()
        {
            // Snippet: FetchServiceAccountForCustomer(FetchServiceAccountForCustomerRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FetchServiceAccountForCustomerRequest request = new FetchServiceAccountForCustomerRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            FeedServiceAccount response = feedsServiceClient.FetchServiceAccountForCustomer(request);
            // End snippet
        }

        /// <summary>Snippet for FetchServiceAccountForCustomerAsync</summary>
        public async Task FetchServiceAccountForCustomerRequestObjectAsync()
        {
            // Snippet: FetchServiceAccountForCustomerAsync(FetchServiceAccountForCustomerRequest, CallSettings)
            // Additional: FetchServiceAccountForCustomerAsync(FetchServiceAccountForCustomerRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchServiceAccountForCustomerRequest request = new FetchServiceAccountForCustomerRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            FeedServiceAccount response = await feedsServiceClient.FetchServiceAccountForCustomerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchServiceAccountForCustomer</summary>
        public void FetchServiceAccountForCustomer()
        {
            // Snippet: FetchServiceAccountForCustomer(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            FeedServiceAccount response = feedsServiceClient.FetchServiceAccountForCustomer(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchServiceAccountForCustomerAsync</summary>
        public async Task FetchServiceAccountForCustomerAsync()
        {
            // Snippet: FetchServiceAccountForCustomerAsync(string, CallSettings)
            // Additional: FetchServiceAccountForCustomerAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            FeedServiceAccount response = await feedsServiceClient.FetchServiceAccountForCustomerAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchServiceAccountForCustomer</summary>
        public void FetchServiceAccountForCustomerResourceNames()
        {
            // Snippet: FetchServiceAccountForCustomer(InstanceName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            FeedServiceAccount response = feedsServiceClient.FetchServiceAccountForCustomer(parent);
            // End snippet
        }

        /// <summary>Snippet for FetchServiceAccountForCustomerAsync</summary>
        public async Task FetchServiceAccountForCustomerResourceNamesAsync()
        {
            // Snippet: FetchServiceAccountForCustomerAsync(InstanceName, CallSettings)
            // Additional: FetchServiceAccountForCustomerAsync(InstanceName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            FeedServiceAccount response = await feedsServiceClient.FetchServiceAccountForCustomerAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeedRequestObject()
        {
            // Snippet: CreateFeed(CreateFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Feed = new Feed(),
            };
            // Make the request
            Feed response = feedsServiceClient.CreateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedRequestObjectAsync()
        {
            // Snippet: CreateFeedAsync(CreateFeedRequest, CallSettings)
            // Additional: CreateFeedAsync(CreateFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Feed = new Feed(),
            };
            // Make the request
            Feed response = await feedsServiceClient.CreateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeed()
        {
            // Snippet: CreateFeed(string, Feed, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Feed feed = new Feed();
            // Make the request
            Feed response = feedsServiceClient.CreateFeed(parent, feed);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedAsync()
        {
            // Snippet: CreateFeedAsync(string, Feed, CallSettings)
            // Additional: CreateFeedAsync(string, Feed, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Feed feed = new Feed();
            // Make the request
            Feed response = await feedsServiceClient.CreateFeedAsync(parent, feed);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeedResourceNames()
        {
            // Snippet: CreateFeed(InstanceName, Feed, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Feed feed = new Feed();
            // Make the request
            Feed response = feedsServiceClient.CreateFeed(parent, feed);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedResourceNamesAsync()
        {
            // Snippet: CreateFeedAsync(InstanceName, Feed, CallSettings)
            // Additional: CreateFeedAsync(InstanceName, Feed, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Feed feed = new Feed();
            // Make the request
            Feed response = await feedsServiceClient.CreateFeedAsync(parent, feed);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedRequestObject()
        {
            // Snippet: GetFeed(GetFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = feedsServiceClient.GetFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedRequestObjectAsync()
        {
            // Snippet: GetFeedAsync(GetFeedRequest, CallSettings)
            // Additional: GetFeedAsync(GetFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = await feedsServiceClient.GetFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeed()
        {
            // Snippet: GetFeed(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = feedsServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedAsync()
        {
            // Snippet: GetFeedAsync(string, CallSettings)
            // Additional: GetFeedAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = await feedsServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedResourceNames()
        {
            // Snippet: GetFeed(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = feedsServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedResourceNamesAsync()
        {
            // Snippet: GetFeedAsync(FeedName, CallSettings)
            // Additional: GetFeedAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = await feedsServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedRequestObject()
        {
            // Snippet: DeleteFeed(DeleteFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
                DeleteBacklog = false,
            };
            // Make the request
            feedsServiceClient.DeleteFeed(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedRequestObjectAsync()
        {
            // Snippet: DeleteFeedAsync(DeleteFeedRequest, CallSettings)
            // Additional: DeleteFeedAsync(DeleteFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
                DeleteBacklog = false,
            };
            // Make the request
            await feedsServiceClient.DeleteFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeed()
        {
            // Snippet: DeleteFeed(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            feedsServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedAsync()
        {
            // Snippet: DeleteFeedAsync(string, CallSettings)
            // Additional: DeleteFeedAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            await feedsServiceClient.DeleteFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedResourceNames()
        {
            // Snippet: DeleteFeed(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            feedsServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedResourceNamesAsync()
        {
            // Snippet: DeleteFeedAsync(FeedName, CallSettings)
            // Additional: DeleteFeedAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            await feedsServiceClient.DeleteFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableFeed</summary>
        public void EnableFeedRequestObject()
        {
            // Snippet: EnableFeed(EnableFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            EnableFeedRequest request = new EnableFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = feedsServiceClient.EnableFeed(request);
            // End snippet
        }

        /// <summary>Snippet for EnableFeedAsync</summary>
        public async Task EnableFeedRequestObjectAsync()
        {
            // Snippet: EnableFeedAsync(EnableFeedRequest, CallSettings)
            // Additional: EnableFeedAsync(EnableFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnableFeedRequest request = new EnableFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = await feedsServiceClient.EnableFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnableFeed</summary>
        public void EnableFeed()
        {
            // Snippet: EnableFeed(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = feedsServiceClient.EnableFeed(name);
            // End snippet
        }

        /// <summary>Snippet for EnableFeedAsync</summary>
        public async Task EnableFeedAsync()
        {
            // Snippet: EnableFeedAsync(string, CallSettings)
            // Additional: EnableFeedAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = await feedsServiceClient.EnableFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableFeed</summary>
        public void EnableFeedResourceNames()
        {
            // Snippet: EnableFeed(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = feedsServiceClient.EnableFeed(name);
            // End snippet
        }

        /// <summary>Snippet for EnableFeedAsync</summary>
        public async Task EnableFeedResourceNamesAsync()
        {
            // Snippet: EnableFeedAsync(FeedName, CallSettings)
            // Additional: EnableFeedAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = await feedsServiceClient.EnableFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableFeed</summary>
        public void DisableFeedRequestObject()
        {
            // Snippet: DisableFeed(DisableFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            DisableFeedRequest request = new DisableFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = feedsServiceClient.DisableFeed(request);
            // End snippet
        }

        /// <summary>Snippet for DisableFeedAsync</summary>
        public async Task DisableFeedRequestObjectAsync()
        {
            // Snippet: DisableFeedAsync(DisableFeedRequest, CallSettings)
            // Additional: DisableFeedAsync(DisableFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisableFeedRequest request = new DisableFeedRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            Feed response = await feedsServiceClient.DisableFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableFeed</summary>
        public void DisableFeed()
        {
            // Snippet: DisableFeed(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = feedsServiceClient.DisableFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DisableFeedAsync</summary>
        public async Task DisableFeedAsync()
        {
            // Snippet: DisableFeedAsync(string, CallSettings)
            // Additional: DisableFeedAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            Feed response = await feedsServiceClient.DisableFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableFeed</summary>
        public void DisableFeedResourceNames()
        {
            // Snippet: DisableFeed(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = feedsServiceClient.DisableFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DisableFeedAsync</summary>
        public async Task DisableFeedResourceNamesAsync()
        {
            // Snippet: DisableFeedAsync(FeedName, CallSettings)
            // Additional: DisableFeedAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            Feed response = await feedsServiceClient.DisableFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeedsRequestObject()
        {
            // Snippet: ListFeeds(ListFeedsRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeeds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsRequestObjectAsync()
        {
            // Snippet: ListFeedsAsync(ListFeedsRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeedsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeeds()
        {
            // Snippet: ListFeeds(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeeds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsAsync()
        {
            // Snippet: ListFeedsAsync(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeedsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeedsResourceNames()
        {
            // Snippet: ListFeeds(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeeds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsResourceNamesAsync()
        {
            // Snippet: ListFeedsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListFeedsResponse, Feed> response = feedsServiceClient.ListFeedsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Feed item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Feed item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Feed> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Feed item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacks</summary>
        public void ListFeedPacksRequestObject()
        {
            // Snippet: ListFeedPacks(ListFeedPacksRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            ListFeedPacksRequest request = new ListFeedPacksRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacksAsync</summary>
        public async Task ListFeedPacksRequestObjectAsync()
        {
            // Snippet: ListFeedPacksAsync(ListFeedPacksRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeedPacksRequest request = new ListFeedPacksRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacks</summary>
        public void ListFeedPacks()
        {
            // Snippet: ListFeedPacks(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacksAsync</summary>
        public async Task ListFeedPacksAsync()
        {
            // Snippet: ListFeedPacksAsync(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacks</summary>
        public void ListFeedPacksResourceNames()
        {
            // Snippet: ListFeedPacks(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedPacksAsync</summary>
        public async Task ListFeedPacksResourceNamesAsync()
        {
            // Snippet: ListFeedPacksAsync(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListFeedPacksResponse, FeedPack> response = feedsServiceClient.ListFeedPacksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedPack item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedPacksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedPack item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedPack> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedPack item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFeedPack</summary>
        public void GetFeedPackRequestObject()
        {
            // Snippet: GetFeedPack(GetFeedPackRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            GetFeedPackRequest request = new GetFeedPackRequest
            {
                FeedPackName = FeedPackName.FromProjectLocationInstanceFeedPack("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_PACK]"),
            };
            // Make the request
            FeedPack response = feedsServiceClient.GetFeedPack(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPackAsync</summary>
        public async Task GetFeedPackRequestObjectAsync()
        {
            // Snippet: GetFeedPackAsync(GetFeedPackRequest, CallSettings)
            // Additional: GetFeedPackAsync(GetFeedPackRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedPackRequest request = new GetFeedPackRequest
            {
                FeedPackName = FeedPackName.FromProjectLocationInstanceFeedPack("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_PACK]"),
            };
            // Make the request
            FeedPack response = await feedsServiceClient.GetFeedPackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPack</summary>
        public void GetFeedPack()
        {
            // Snippet: GetFeedPack(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feedPacks/[FEED_PACK]";
            // Make the request
            FeedPack response = feedsServiceClient.GetFeedPack(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPackAsync</summary>
        public async Task GetFeedPackAsync()
        {
            // Snippet: GetFeedPackAsync(string, CallSettings)
            // Additional: GetFeedPackAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feedPacks/[FEED_PACK]";
            // Make the request
            FeedPack response = await feedsServiceClient.GetFeedPackAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPack</summary>
        public void GetFeedPackResourceNames()
        {
            // Snippet: GetFeedPack(FeedPackName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedPackName name = FeedPackName.FromProjectLocationInstanceFeedPack("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_PACK]");
            // Make the request
            FeedPack response = feedsServiceClient.GetFeedPack(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedPackAsync</summary>
        public async Task GetFeedPackResourceNamesAsync()
        {
            // Snippet: GetFeedPackAsync(FeedPackName, CallSettings)
            // Additional: GetFeedPackAsync(FeedPackName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedPackName name = FeedPackName.FromProjectLocationInstanceFeedPack("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_PACK]");
            // Make the request
            FeedPack response = await feedsServiceClient.GetFeedPackAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeedRequestObject()
        {
            // Snippet: UpdateFeed(UpdateFeedRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = feedsServiceClient.UpdateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedRequestObjectAsync()
        {
            // Snippet: UpdateFeedAsync(UpdateFeedRequest, CallSettings)
            // Additional: UpdateFeedAsync(UpdateFeedRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = await feedsServiceClient.UpdateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeed()
        {
            // Snippet: UpdateFeed(Feed, FieldMask, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            Feed feed = new Feed();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Feed response = feedsServiceClient.UpdateFeed(feed, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedAsync()
        {
            // Snippet: UpdateFeedAsync(Feed, FieldMask, CallSettings)
            // Additional: UpdateFeedAsync(Feed, FieldMask, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Feed feed = new Feed();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Feed response = await feedsServiceClient.UpdateFeedAsync(feed, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemas</summary>
        public void ListFeedSourceTypeSchemasRequestObject()
        {
            // Snippet: ListFeedSourceTypeSchemas(ListFeedSourceTypeSchemasRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemasAsync</summary>
        public async Task ListFeedSourceTypeSchemasRequestObjectAsync()
        {
            // Snippet: ListFeedSourceTypeSchemasAsync(ListFeedSourceTypeSchemasRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeedSourceTypeSchemasRequest request = new ListFeedSourceTypeSchemasRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemas</summary>
        public void ListFeedSourceTypeSchemas()
        {
            // Snippet: ListFeedSourceTypeSchemas(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemasAsync</summary>
        public async Task ListFeedSourceTypeSchemasAsync()
        {
            // Snippet: ListFeedSourceTypeSchemasAsync(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemas</summary>
        public void ListFeedSourceTypeSchemasResourceNames()
        {
            // Snippet: ListFeedSourceTypeSchemas(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFeedSourceTypeSchemasAsync</summary>
        public async Task ListFeedSourceTypeSchemasResourceNamesAsync()
        {
            // Snippet: ListFeedSourceTypeSchemasAsync(InstanceName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListFeedSourceTypeSchemasResponse, FeedSourceTypeSchema> response = feedsServiceClient.ListFeedSourceTypeSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FeedSourceTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFeedSourceTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FeedSourceTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FeedSourceTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FeedSourceTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemas</summary>
        public void ListLogTypeSchemasRequestObject()
        {
            // Snippet: ListLogTypeSchemas(ListLogTypeSchemasRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
            {
                ParentAsFeedSourceTypeSchemaName = FeedSourceTypeSchemaName.FromProjectLocationInstanceFeedSourceType("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_SOURCE_TYPE]"),
            };
            // Make the request
            PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemasAsync</summary>
        public async Task ListLogTypeSchemasRequestObjectAsync()
        {
            // Snippet: ListLogTypeSchemasAsync(ListLogTypeSchemasRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLogTypeSchemasRequest request = new ListLogTypeSchemasRequest
            {
                ParentAsFeedSourceTypeSchemaName = FeedSourceTypeSchemaName.FromProjectLocationInstanceFeedSourceType("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_SOURCE_TYPE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemas</summary>
        public void ListLogTypeSchemas()
        {
            // Snippet: ListLogTypeSchemas(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feedSourceTypeSchemas/[FEED_SOURCE_TYPE]";
            // Make the request
            PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemasAsync</summary>
        public async Task ListLogTypeSchemasAsync()
        {
            // Snippet: ListLogTypeSchemasAsync(string, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feedSourceTypeSchemas/[FEED_SOURCE_TYPE]";
            // Make the request
            PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemas</summary>
        public void ListLogTypeSchemasResourceNames()
        {
            // Snippet: ListLogTypeSchemas(FeedSourceTypeSchemaName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedSourceTypeSchemaName parent = FeedSourceTypeSchemaName.FromProjectLocationInstanceFeedSourceType("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_SOURCE_TYPE]");
            // Make the request
            PagedEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogTypeSchemasAsync</summary>
        public async Task ListLogTypeSchemasResourceNamesAsync()
        {
            // Snippet: ListLogTypeSchemasAsync(FeedSourceTypeSchemaName, string, int?, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedSourceTypeSchemaName parent = FeedSourceTypeSchemaName.FromProjectLocationInstanceFeedSourceType("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED_SOURCE_TYPE]");
            // Make the request
            PagedAsyncEnumerable<ListLogTypeSchemasResponse, LogTypeSchema> response = feedsServiceClient.ListLogTypeSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogTypeSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogTypeSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogTypeSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogTypeSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogTypeSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogs</summary>
        public void ImportPushLogsRequestObject()
        {
            // Snippet: ImportPushLogs(ImportPushLogsRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            ImportPushLogsRequest request = new ImportPushLogsRequest
            {
                ParentAsFeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
                HttpBody = new HttpBody(),
                Secret = "",
            };
            // Make the request
            HttpBody response = feedsServiceClient.ImportPushLogs(request);
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogsAsync</summary>
        public async Task ImportPushLogsRequestObjectAsync()
        {
            // Snippet: ImportPushLogsAsync(ImportPushLogsRequest, CallSettings)
            // Additional: ImportPushLogsAsync(ImportPushLogsRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportPushLogsRequest request = new ImportPushLogsRequest
            {
                ParentAsFeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
                HttpBody = new HttpBody(),
                Secret = "",
            };
            // Make the request
            HttpBody response = await feedsServiceClient.ImportPushLogsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogs</summary>
        public void ImportPushLogs()
        {
            // Snippet: ImportPushLogs(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            HttpBody response = feedsServiceClient.ImportPushLogs(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogsAsync</summary>
        public async Task ImportPushLogsAsync()
        {
            // Snippet: ImportPushLogsAsync(string, CallSettings)
            // Additional: ImportPushLogsAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            HttpBody response = await feedsServiceClient.ImportPushLogsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogs</summary>
        public void ImportPushLogsResourceNames()
        {
            // Snippet: ImportPushLogs(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName parent = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            HttpBody response = feedsServiceClient.ImportPushLogs(parent);
            // End snippet
        }

        /// <summary>Snippet for ImportPushLogsAsync</summary>
        public async Task ImportPushLogsResourceNamesAsync()
        {
            // Snippet: ImportPushLogsAsync(FeedName, CallSettings)
            // Additional: ImportPushLogsAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName parent = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            HttpBody response = await feedsServiceClient.ImportPushLogsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecret</summary>
        public void GenerateSecretRequestObject()
        {
            // Snippet: GenerateSecret(GenerateSecretRequest, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            GenerateSecretRequest request = new GenerateSecretRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            GenerateSecretResponse response = feedsServiceClient.GenerateSecret(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecretAsync</summary>
        public async Task GenerateSecretRequestObjectAsync()
        {
            // Snippet: GenerateSecretAsync(GenerateSecretRequest, CallSettings)
            // Additional: GenerateSecretAsync(GenerateSecretRequest, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateSecretRequest request = new GenerateSecretRequest
            {
                FeedName = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]"),
            };
            // Make the request
            GenerateSecretResponse response = await feedsServiceClient.GenerateSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecret</summary>
        public void GenerateSecret()
        {
            // Snippet: GenerateSecret(string, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            GenerateSecretResponse response = feedsServiceClient.GenerateSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecretAsync</summary>
        public async Task GenerateSecretAsync()
        {
            // Snippet: GenerateSecretAsync(string, CallSettings)
            // Additional: GenerateSecretAsync(string, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/feeds/[FEED]";
            // Make the request
            GenerateSecretResponse response = await feedsServiceClient.GenerateSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecret</summary>
        public void GenerateSecretResourceNames()
        {
            // Snippet: GenerateSecret(FeedName, CallSettings)
            // Create client
            FeedsServiceClient feedsServiceClient = FeedsServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            GenerateSecretResponse response = feedsServiceClient.GenerateSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateSecretAsync</summary>
        public async Task GenerateSecretResourceNamesAsync()
        {
            // Snippet: GenerateSecretAsync(FeedName, CallSettings)
            // Additional: GenerateSecretAsync(FeedName, CancellationToken)
            // Create client
            FeedsServiceClient feedsServiceClient = await FeedsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectLocationInstanceFeed("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FEED]");
            // Make the request
            GenerateSecretResponse response = await feedsServiceClient.GenerateSecretAsync(name);
            // End snippet
        }
    }
}
