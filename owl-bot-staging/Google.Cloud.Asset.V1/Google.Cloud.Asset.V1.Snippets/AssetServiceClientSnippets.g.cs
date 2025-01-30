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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Asset.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAssetServiceClientSnippets
    {
        /// <summary>Snippet for ExportAssets</summary>
        public void ExportAssetsRequestObject()
        {
            // Snippet: ExportAssets(ExportAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                OutputConfig = new OutputConfig(),
                RelationshipTypes = { "", },
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response = assetServiceClient.ExportAssets(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse = assetServiceClient.PollOnceExportAssets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportAssetsAsync</summary>
        public async Task ExportAssetsRequestObjectAsync()
        {
            // Snippet: ExportAssetsAsync(ExportAssetsRequest, CallSettings)
            // Additional: ExportAssetsAsync(ExportAssetsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportAssetsRequest request = new ExportAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                OutputConfig = new OutputConfig(),
                RelationshipTypes = { "", },
            };
            // Make the request
            Operation<ExportAssetsResponse, ExportAssetsRequest> response = await assetServiceClient.ExportAssetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportAssetsResponse, ExportAssetsRequest> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportAssetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportAssetsResponse, ExportAssetsRequest> retrievedResponse = await assetServiceClient.PollOnceExportAssetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportAssetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsRequestObject()
        {
            // Snippet: ListAssets(ListAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                RelationshipTypes = { "", },
            };
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsRequestObjectAsync()
        {
            // Snippet: ListAssetsAsync(ListAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ReadTime = new Timestamp(),
                AssetTypes = { "", },
                ContentType = ContentType.Unspecified,
                RelationshipTypes = { "", },
            };
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssets()
        {
            // Snippet: ListAssets(string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsAsync()
        {
            // Snippet: ListAssetsAsync(string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "a/wildcard/resource";
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsResourceNames()
        {
            // Snippet: ListAssets(IResourceName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsResourceNamesAsync()
        {
            // Snippet: ListAssetsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = assetServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistory</summary>
        public void BatchGetAssetsHistoryRequestObject()
        {
            // Snippet: BatchGetAssetsHistory(BatchGetAssetsHistoryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                AssetNames = { "", },
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
                RelationshipTypes = { "", },
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = assetServiceClient.BatchGetAssetsHistory(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetAssetsHistoryAsync</summary>
        public async Task BatchGetAssetsHistoryRequestObjectAsync()
        {
            // Snippet: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest, CallSettings)
            // Additional: BatchGetAssetsHistoryAsync(BatchGetAssetsHistoryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                AssetNames = { "", },
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
                RelationshipTypes = { "", },
            };
            // Make the request
            BatchGetAssetsHistoryResponse response = await assetServiceClient.BatchGetAssetsHistoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeedRequestObject()
        {
            // Snippet: CreateFeed(CreateFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "",
                FeedId = "",
                Feed = new Feed(),
            };
            // Make the request
            Feed response = assetServiceClient.CreateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedRequestObjectAsync()
        {
            // Snippet: CreateFeedAsync(CreateFeedRequest, CallSettings)
            // Additional: CreateFeedAsync(CreateFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "",
                FeedId = "",
                Feed = new Feed(),
            };
            // Make the request
            Feed response = await assetServiceClient.CreateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFeed</summary>
        public void CreateFeed()
        {
            // Snippet: CreateFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Feed response = assetServiceClient.CreateFeed(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateFeedAsync</summary>
        public async Task CreateFeedAsync()
        {
            // Snippet: CreateFeedAsync(string, CallSettings)
            // Additional: CreateFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            Feed response = await assetServiceClient.CreateFeedAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedRequestObject()
        {
            // Snippet: GetFeed(GetFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            Feed response = assetServiceClient.GetFeed(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedRequestObjectAsync()
        {
            // Snippet: GetFeedAsync(GetFeedRequest, CallSettings)
            // Additional: GetFeedAsync(GetFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeed()
        {
            // Snippet: GetFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            Feed response = assetServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedAsync()
        {
            // Snippet: GetFeedAsync(string, CallSettings)
            // Additional: GetFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeed</summary>
        public void GetFeedResourceNames()
        {
            // Snippet: GetFeed(FeedName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            Feed response = assetServiceClient.GetFeed(name);
            // End snippet
        }

        /// <summary>Snippet for GetFeedAsync</summary>
        public async Task GetFeedResourceNamesAsync()
        {
            // Snippet: GetFeedAsync(FeedName, CallSettings)
            // Additional: GetFeedAsync(FeedName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            Feed response = await assetServiceClient.GetFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeedsRequestObject()
        {
            // Snippet: ListFeeds(ListFeedsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest { Parent = "", };
            // Make the request
            ListFeedsResponse response = assetServiceClient.ListFeeds(request);
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsRequestObjectAsync()
        {
            // Snippet: ListFeedsAsync(ListFeedsRequest, CallSettings)
            // Additional: ListFeedsAsync(ListFeedsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFeedsRequest request = new ListFeedsRequest { Parent = "", };
            // Make the request
            ListFeedsResponse response = await assetServiceClient.ListFeedsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListFeeds</summary>
        public void ListFeeds()
        {
            // Snippet: ListFeeds(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListFeedsResponse response = assetServiceClient.ListFeeds(parent);
            // End snippet
        }

        /// <summary>Snippet for ListFeedsAsync</summary>
        public async Task ListFeedsAsync()
        {
            // Snippet: ListFeedsAsync(string, CallSettings)
            // Additional: ListFeedsAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            ListFeedsResponse response = await assetServiceClient.ListFeedsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeedRequestObject()
        {
            // Snippet: UpdateFeed(UpdateFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = assetServiceClient.UpdateFeed(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedRequestObjectAsync()
        {
            // Snippet: UpdateFeedAsync(UpdateFeedRequest, CallSettings)
            // Additional: UpdateFeedAsync(UpdateFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Feed response = await assetServiceClient.UpdateFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeed</summary>
        public void UpdateFeed()
        {
            // Snippet: UpdateFeed(Feed, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            Feed feed = new Feed();
            // Make the request
            Feed response = assetServiceClient.UpdateFeed(feed);
            // End snippet
        }

        /// <summary>Snippet for UpdateFeedAsync</summary>
        public async Task UpdateFeedAsync()
        {
            // Snippet: UpdateFeedAsync(Feed, CallSettings)
            // Additional: UpdateFeedAsync(Feed, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            Feed feed = new Feed();
            // Make the request
            Feed response = await assetServiceClient.UpdateFeedAsync(feed);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedRequestObject()
        {
            // Snippet: DeleteFeed(DeleteFeedRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            assetServiceClient.DeleteFeed(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedRequestObjectAsync()
        {
            // Snippet: DeleteFeedAsync(DeleteFeedRequest, CallSettings)
            // Additional: DeleteFeedAsync(DeleteFeedRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            // Make the request
            await assetServiceClient.DeleteFeedAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeed()
        {
            // Snippet: DeleteFeed(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            assetServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedAsync()
        {
            // Snippet: DeleteFeedAsync(string, CallSettings)
            // Additional: DeleteFeedAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/feeds/[FEED]";
            // Make the request
            await assetServiceClient.DeleteFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeed</summary>
        public void DeleteFeedResourceNames()
        {
            // Snippet: DeleteFeed(FeedName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            assetServiceClient.DeleteFeed(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFeedAsync</summary>
        public async Task DeleteFeedResourceNamesAsync()
        {
            // Snippet: DeleteFeedAsync(FeedName, CallSettings)
            // Additional: DeleteFeedAsync(FeedName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FeedName name = FeedName.FromProjectFeed("[PROJECT]", "[FEED]");
            // Make the request
            await assetServiceClient.DeleteFeedAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchAllResources</summary>
        public void SearchAllResourcesRequestObject()
        {
            // Snippet: SearchAllResources(SearchAllResourcesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SearchAllResourcesRequest request = new SearchAllResourcesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<SearchAllResourcesResponse, ResourceSearchResult> response = assetServiceClient.SearchAllResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceSearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceSearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResourcesAsync</summary>
        public async Task SearchAllResourcesRequestObjectAsync()
        {
            // Snippet: SearchAllResourcesAsync(SearchAllResourcesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAllResourcesRequest request = new SearchAllResourcesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchAllResourcesResponse, ResourceSearchResult> response = assetServiceClient.SearchAllResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceSearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceSearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResources</summary>
        public void SearchAllResources()
        {
            // Snippet: SearchAllResources(string, string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            IEnumerable<string> assetTypes = new string[] { "", };
            // Make the request
            PagedEnumerable<SearchAllResourcesResponse, ResourceSearchResult> response = assetServiceClient.SearchAllResources(scope, query, assetTypes);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceSearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceSearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllResourcesAsync</summary>
        public async Task SearchAllResourcesAsync()
        {
            // Snippet: SearchAllResourcesAsync(string, string, IEnumerable<string>, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            IEnumerable<string> assetTypes = new string[] { "", };
            // Make the request
            PagedAsyncEnumerable<SearchAllResourcesResponse, ResourceSearchResult> response = assetServiceClient.SearchAllResourcesAsync(scope, query, assetTypes);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceSearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceSearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceSearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceSearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPolicies</summary>
        public void SearchAllIamPoliciesRequestObject()
        {
            // Snippet: SearchAllIamPolicies(SearchAllIamPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SearchAllIamPoliciesRequest request = new SearchAllIamPoliciesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IamPolicySearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllIamPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPoliciesAsync</summary>
        public async Task SearchAllIamPoliciesRequestObjectAsync()
        {
            // Snippet: SearchAllIamPoliciesAsync(SearchAllIamPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAllIamPoliciesRequest request = new SearchAllIamPoliciesRequest
            {
                Scope = "",
                Query = "",
                AssetTypes = { "", },
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IamPolicySearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllIamPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPolicies</summary>
        public void SearchAllIamPolicies()
        {
            // Snippet: SearchAllIamPolicies(string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            // Make the request
            PagedEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPolicies(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IamPolicySearchResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAllIamPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAllIamPoliciesAsync</summary>
        public async Task SearchAllIamPoliciesAsync()
        {
            // Snippet: SearchAllIamPoliciesAsync(string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchAllIamPoliciesResponse, IamPolicySearchResult> response = assetServiceClient.SearchAllIamPoliciesAsync(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IamPolicySearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAllIamPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IamPolicySearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IamPolicySearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IamPolicySearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeIamPolicy</summary>
        public void AnalyzeIamPolicyRequestObject()
        {
            // Snippet: AnalyzeIamPolicy(AnalyzeIamPolicyRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                ExecutionTimeout = new Duration(),
                SavedAnalysisQuery = "",
            };
            // Make the request
            AnalyzeIamPolicyResponse response = assetServiceClient.AnalyzeIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeIamPolicyAsync</summary>
        public async Task AnalyzeIamPolicyRequestObjectAsync()
        {
            // Snippet: AnalyzeIamPolicyAsync(AnalyzeIamPolicyRequest, CallSettings)
            // Additional: AnalyzeIamPolicyAsync(AnalyzeIamPolicyRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                ExecutionTimeout = new Duration(),
                SavedAnalysisQuery = "",
            };
            // Make the request
            AnalyzeIamPolicyResponse response = await assetServiceClient.AnalyzeIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeIamPolicyLongrunning</summary>
        public void AnalyzeIamPolicyLongrunningRequestObject()
        {
            // Snippet: AnalyzeIamPolicyLongrunning(AnalyzeIamPolicyLongrunningRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeIamPolicyLongrunningRequest request = new AnalyzeIamPolicyLongrunningRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                OutputConfig = new IamPolicyAnalysisOutputConfig(),
                SavedAnalysisQuery = "",
            };
            // Make the request
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> response = assetServiceClient.AnalyzeIamPolicyLongrunning(request);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AnalyzeIamPolicyLongrunningResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> retrievedResponse = assetServiceClient.PollOnceAnalyzeIamPolicyLongrunning(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzeIamPolicyLongrunningResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeIamPolicyLongrunningAsync</summary>
        public async Task AnalyzeIamPolicyLongrunningRequestObjectAsync()
        {
            // Snippet: AnalyzeIamPolicyLongrunningAsync(AnalyzeIamPolicyLongrunningRequest, CallSettings)
            // Additional: AnalyzeIamPolicyLongrunningAsync(AnalyzeIamPolicyLongrunningRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeIamPolicyLongrunningRequest request = new AnalyzeIamPolicyLongrunningRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                OutputConfig = new IamPolicyAnalysisOutputConfig(),
                SavedAnalysisQuery = "",
            };
            // Make the request
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> response = await assetServiceClient.AnalyzeIamPolicyLongrunningAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AnalyzeIamPolicyLongrunningResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AnalyzeIamPolicyLongrunningResponse, AnalyzeIamPolicyLongrunningMetadata> retrievedResponse = await assetServiceClient.PollOnceAnalyzeIamPolicyLongrunningAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AnalyzeIamPolicyLongrunningResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AnalyzeMove</summary>
        public void AnalyzeMoveRequestObject()
        {
            // Snippet: AnalyzeMove(AnalyzeMoveRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeMoveRequest request = new AnalyzeMoveRequest
            {
                ResourceAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = AnalyzeMoveRequest.Types.AnalysisView.Unspecified,
            };
            // Make the request
            AnalyzeMoveResponse response = assetServiceClient.AnalyzeMove(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeMoveAsync</summary>
        public async Task AnalyzeMoveRequestObjectAsync()
        {
            // Snippet: AnalyzeMoveAsync(AnalyzeMoveRequest, CallSettings)
            // Additional: AnalyzeMoveAsync(AnalyzeMoveRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeMoveRequest request = new AnalyzeMoveRequest
            {
                ResourceAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DestinationParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = AnalyzeMoveRequest.Types.AnalysisView.Unspecified,
            };
            // Make the request
            AnalyzeMoveResponse response = await assetServiceClient.AnalyzeMoveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAssets</summary>
        public void QueryAssetsRequestObject()
        {
            // Snippet: QueryAssets(QueryAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            QueryAssetsRequest request = new QueryAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Statement = "",
                PageSize = 0,
                PageToken = "",
                Timeout = new Duration(),
                ReadTimeWindow = new TimeWindow(),
                OutputConfig = new QueryAssetsOutputConfig(),
            };
            // Make the request
            QueryAssetsResponse response = assetServiceClient.QueryAssets(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAssetsAsync</summary>
        public async Task QueryAssetsRequestObjectAsync()
        {
            // Snippet: QueryAssetsAsync(QueryAssetsRequest, CallSettings)
            // Additional: QueryAssetsAsync(QueryAssetsRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryAssetsRequest request = new QueryAssetsRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Statement = "",
                PageSize = 0,
                PageToken = "",
                Timeout = new Duration(),
                ReadTimeWindow = new TimeWindow(),
                OutputConfig = new QueryAssetsOutputConfig(),
            };
            // Make the request
            QueryAssetsResponse response = await assetServiceClient.QueryAssetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQuery</summary>
        public void CreateSavedQueryRequestObject()
        {
            // Snippet: CreateSavedQuery(CreateSavedQueryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "",
            };
            // Make the request
            SavedQuery response = assetServiceClient.CreateSavedQuery(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQueryAsync</summary>
        public async Task CreateSavedQueryRequestObjectAsync()
        {
            // Snippet: CreateSavedQueryAsync(CreateSavedQueryRequest, CallSettings)
            // Additional: CreateSavedQueryAsync(CreateSavedQueryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "",
            };
            // Make the request
            SavedQuery response = await assetServiceClient.CreateSavedQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQuery</summary>
        public void CreateSavedQuery()
        {
            // Snippet: CreateSavedQuery(string, SavedQuery, string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = assetServiceClient.CreateSavedQuery(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQueryAsync</summary>
        public async Task CreateSavedQueryAsync()
        {
            // Snippet: CreateSavedQueryAsync(string, SavedQuery, string, CallSettings)
            // Additional: CreateSavedQueryAsync(string, SavedQuery, string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = await assetServiceClient.CreateSavedQueryAsync(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQuery</summary>
        public void CreateSavedQueryResourceNames1()
        {
            // Snippet: CreateSavedQuery(ProjectName, SavedQuery, string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = assetServiceClient.CreateSavedQuery(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQueryAsync</summary>
        public async Task CreateSavedQueryResourceNames1Async()
        {
            // Snippet: CreateSavedQueryAsync(ProjectName, SavedQuery, string, CallSettings)
            // Additional: CreateSavedQueryAsync(ProjectName, SavedQuery, string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = await assetServiceClient.CreateSavedQueryAsync(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQuery</summary>
        public void CreateSavedQueryResourceNames2()
        {
            // Snippet: CreateSavedQuery(FolderName, SavedQuery, string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = assetServiceClient.CreateSavedQuery(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQueryAsync</summary>
        public async Task CreateSavedQueryResourceNames2Async()
        {
            // Snippet: CreateSavedQueryAsync(FolderName, SavedQuery, string, CallSettings)
            // Additional: CreateSavedQueryAsync(FolderName, SavedQuery, string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = await assetServiceClient.CreateSavedQueryAsync(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQuery</summary>
        public void CreateSavedQueryResourceNames3()
        {
            // Snippet: CreateSavedQuery(OrganizationName, SavedQuery, string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = assetServiceClient.CreateSavedQuery(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for CreateSavedQueryAsync</summary>
        public async Task CreateSavedQueryResourceNames3Async()
        {
            // Snippet: CreateSavedQueryAsync(OrganizationName, SavedQuery, string, CallSettings)
            // Additional: CreateSavedQueryAsync(OrganizationName, SavedQuery, string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            SavedQuery savedQuery = new SavedQuery();
            string savedQueryId = "";
            // Make the request
            SavedQuery response = await assetServiceClient.CreateSavedQueryAsync(parent, savedQuery, savedQueryId);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQuery</summary>
        public void GetSavedQueryRequestObject()
        {
            // Snippet: GetSavedQuery(GetSavedQueryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            // Make the request
            SavedQuery response = assetServiceClient.GetSavedQuery(request);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQueryAsync</summary>
        public async Task GetSavedQueryRequestObjectAsync()
        {
            // Snippet: GetSavedQueryAsync(GetSavedQueryRequest, CallSettings)
            // Additional: GetSavedQueryAsync(GetSavedQueryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            // Make the request
            SavedQuery response = await assetServiceClient.GetSavedQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQuery</summary>
        public void GetSavedQuery()
        {
            // Snippet: GetSavedQuery(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/savedQueries/[SAVED_QUERY]";
            // Make the request
            SavedQuery response = assetServiceClient.GetSavedQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQueryAsync</summary>
        public async Task GetSavedQueryAsync()
        {
            // Snippet: GetSavedQueryAsync(string, CallSettings)
            // Additional: GetSavedQueryAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/savedQueries/[SAVED_QUERY]";
            // Make the request
            SavedQuery response = await assetServiceClient.GetSavedQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQuery</summary>
        public void GetSavedQueryResourceNames()
        {
            // Snippet: GetSavedQuery(SavedQueryName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]");
            // Make the request
            SavedQuery response = assetServiceClient.GetSavedQuery(name);
            // End snippet
        }

        /// <summary>Snippet for GetSavedQueryAsync</summary>
        public async Task GetSavedQueryResourceNamesAsync()
        {
            // Snippet: GetSavedQueryAsync(SavedQueryName, CallSettings)
            // Additional: GetSavedQueryAsync(SavedQueryName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]");
            // Make the request
            SavedQuery response = await assetServiceClient.GetSavedQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesRequestObject()
        {
            // Snippet: ListSavedQueries(ListSavedQueriesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ListSavedQueriesRequest request = new ListSavedQueriesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesRequestObjectAsync()
        {
            // Snippet: ListSavedQueriesAsync(ListSavedQueriesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSavedQueriesRequest request = new ListSavedQueriesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueries()
        {
            // Snippet: ListSavedQueries(string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesAsync()
        {
            // Snippet: ListSavedQueriesAsync(string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesResourceNames1()
        {
            // Snippet: ListSavedQueries(ProjectName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesResourceNames1Async()
        {
            // Snippet: ListSavedQueriesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesResourceNames2()
        {
            // Snippet: ListSavedQueries(FolderName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesResourceNames2Async()
        {
            // Snippet: ListSavedQueriesAsync(FolderName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueries</summary>
        public void ListSavedQueriesResourceNames3()
        {
            // Snippet: ListSavedQueries(OrganizationName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SavedQuery item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSavedQueriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSavedQueriesAsync</summary>
        public async Task ListSavedQueriesResourceNames3Async()
        {
            // Snippet: ListSavedQueriesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListSavedQueriesResponse, SavedQuery> response = assetServiceClient.ListSavedQueriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SavedQuery item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSavedQueriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SavedQuery item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SavedQuery> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SavedQuery item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSavedQuery</summary>
        public void UpdateSavedQueryRequestObject()
        {
            // Snippet: UpdateSavedQuery(UpdateSavedQueryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SavedQuery response = assetServiceClient.UpdateSavedQuery(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSavedQueryAsync</summary>
        public async Task UpdateSavedQueryRequestObjectAsync()
        {
            // Snippet: UpdateSavedQueryAsync(UpdateSavedQueryRequest, CallSettings)
            // Additional: UpdateSavedQueryAsync(UpdateSavedQueryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SavedQuery response = await assetServiceClient.UpdateSavedQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSavedQuery</summary>
        public void UpdateSavedQuery()
        {
            // Snippet: UpdateSavedQuery(SavedQuery, FieldMask, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SavedQuery savedQuery = new SavedQuery();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SavedQuery response = assetServiceClient.UpdateSavedQuery(savedQuery, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSavedQueryAsync</summary>
        public async Task UpdateSavedQueryAsync()
        {
            // Snippet: UpdateSavedQueryAsync(SavedQuery, FieldMask, CallSettings)
            // Additional: UpdateSavedQueryAsync(SavedQuery, FieldMask, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SavedQuery savedQuery = new SavedQuery();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SavedQuery response = await assetServiceClient.UpdateSavedQueryAsync(savedQuery, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQueryRequestObject()
        {
            // Snippet: DeleteSavedQuery(DeleteSavedQueryRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            // Make the request
            assetServiceClient.DeleteSavedQuery(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryRequestObjectAsync()
        {
            // Snippet: DeleteSavedQueryAsync(DeleteSavedQueryRequest, CallSettings)
            // Additional: DeleteSavedQueryAsync(DeleteSavedQueryRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            // Make the request
            await assetServiceClient.DeleteSavedQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQuery()
        {
            // Snippet: DeleteSavedQuery(string, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/savedQueries/[SAVED_QUERY]";
            // Make the request
            assetServiceClient.DeleteSavedQuery(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryAsync()
        {
            // Snippet: DeleteSavedQueryAsync(string, CallSettings)
            // Additional: DeleteSavedQueryAsync(string, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/savedQueries/[SAVED_QUERY]";
            // Make the request
            await assetServiceClient.DeleteSavedQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQuery</summary>
        public void DeleteSavedQueryResourceNames()
        {
            // Snippet: DeleteSavedQuery(SavedQueryName, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]");
            // Make the request
            assetServiceClient.DeleteSavedQuery(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSavedQueryAsync</summary>
        public async Task DeleteSavedQueryResourceNamesAsync()
        {
            // Snippet: DeleteSavedQueryAsync(SavedQueryName, CallSettings)
            // Additional: DeleteSavedQueryAsync(SavedQueryName, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            SavedQueryName name = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]");
            // Make the request
            await assetServiceClient.DeleteSavedQueryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchGetEffectiveIamPolicies</summary>
        public void BatchGetEffectiveIamPoliciesRequestObject()
        {
            // Snippet: BatchGetEffectiveIamPolicies(BatchGetEffectiveIamPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            BatchGetEffectiveIamPoliciesRequest request = new BatchGetEffectiveIamPoliciesRequest
            {
                ScopeAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ResourceNames =
                {
                    new UnparsedResourceName("a/wildcard/resource"),
                },
            };
            // Make the request
            BatchGetEffectiveIamPoliciesResponse response = assetServiceClient.BatchGetEffectiveIamPolicies(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetEffectiveIamPoliciesAsync</summary>
        public async Task BatchGetEffectiveIamPoliciesRequestObjectAsync()
        {
            // Snippet: BatchGetEffectiveIamPoliciesAsync(BatchGetEffectiveIamPoliciesRequest, CallSettings)
            // Additional: BatchGetEffectiveIamPoliciesAsync(BatchGetEffectiveIamPoliciesRequest, CancellationToken)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetEffectiveIamPoliciesRequest request = new BatchGetEffectiveIamPoliciesRequest
            {
                ScopeAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                ResourceNames =
                {
                    new UnparsedResourceName("a/wildcard/resource"),
                },
            };
            // Make the request
            BatchGetEffectiveIamPoliciesResponse response = await assetServiceClient.BatchGetEffectiveIamPoliciesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicies</summary>
        public void AnalyzeOrgPoliciesRequestObject()
        {
            // Snippet: AnalyzeOrgPolicies(AnalyzeOrgPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeOrgPoliciesRequest request = new AnalyzeOrgPoliciesRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<AnalyzeOrgPoliciesResponse, AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> response = assetServiceClient.AnalyzeOrgPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPoliciesAsync</summary>
        public async Task AnalyzeOrgPoliciesRequestObjectAsync()
        {
            // Snippet: AnalyzeOrgPoliciesAsync(AnalyzeOrgPoliciesRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeOrgPoliciesRequest request = new AnalyzeOrgPoliciesRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPoliciesResponse, AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> response = assetServiceClient.AnalyzeOrgPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicies</summary>
        public void AnalyzeOrgPolicies()
        {
            // Snippet: AnalyzeOrgPolicies(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedEnumerable<AnalyzeOrgPoliciesResponse, AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> response = assetServiceClient.AnalyzeOrgPolicies(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPoliciesAsync</summary>
        public async Task AnalyzeOrgPoliciesAsync()
        {
            // Snippet: AnalyzeOrgPoliciesAsync(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPoliciesResponse, AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> response = assetServiceClient.AnalyzeOrgPoliciesAsync(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPoliciesResponse.Types.OrgPolicyResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedContainers</summary>
        public void AnalyzeOrgPolicyGovernedContainersRequestObject()
        {
            // Snippet: AnalyzeOrgPolicyGovernedContainers(AnalyzeOrgPolicyGovernedContainersRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeOrgPolicyGovernedContainersRequest request = new AnalyzeOrgPolicyGovernedContainersRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<AnalyzeOrgPolicyGovernedContainersResponse, AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> response = assetServiceClient.AnalyzeOrgPolicyGovernedContainers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPolicyGovernedContainersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedContainersAsync</summary>
        public async Task AnalyzeOrgPolicyGovernedContainersRequestObjectAsync()
        {
            // Snippet: AnalyzeOrgPolicyGovernedContainersAsync(AnalyzeOrgPolicyGovernedContainersRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeOrgPolicyGovernedContainersRequest request = new AnalyzeOrgPolicyGovernedContainersRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPolicyGovernedContainersResponse, AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> response = assetServiceClient.AnalyzeOrgPolicyGovernedContainersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPolicyGovernedContainersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedContainers</summary>
        public void AnalyzeOrgPolicyGovernedContainers()
        {
            // Snippet: AnalyzeOrgPolicyGovernedContainers(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedEnumerable<AnalyzeOrgPolicyGovernedContainersResponse, AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> response = assetServiceClient.AnalyzeOrgPolicyGovernedContainers(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPolicyGovernedContainersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedContainersAsync</summary>
        public async Task AnalyzeOrgPolicyGovernedContainersAsync()
        {
            // Snippet: AnalyzeOrgPolicyGovernedContainersAsync(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPolicyGovernedContainersResponse, AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> response = assetServiceClient.AnalyzeOrgPolicyGovernedContainersAsync(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPolicyGovernedContainersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedContainersResponse.Types.GovernedContainer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedAssets</summary>
        public void AnalyzeOrgPolicyGovernedAssetsRequestObject()
        {
            // Snippet: AnalyzeOrgPolicyGovernedAssets(AnalyzeOrgPolicyGovernedAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            AnalyzeOrgPolicyGovernedAssetsRequest request = new AnalyzeOrgPolicyGovernedAssetsRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<AnalyzeOrgPolicyGovernedAssetsResponse, AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> response = assetServiceClient.AnalyzeOrgPolicyGovernedAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedAssetsAsync</summary>
        public async Task AnalyzeOrgPolicyGovernedAssetsRequestObjectAsync()
        {
            // Snippet: AnalyzeOrgPolicyGovernedAssetsAsync(AnalyzeOrgPolicyGovernedAssetsRequest, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeOrgPolicyGovernedAssetsRequest request = new AnalyzeOrgPolicyGovernedAssetsRequest
            {
                Scope = "",
                Constraint = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPolicyGovernedAssetsResponse, AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> response = assetServiceClient.AnalyzeOrgPolicyGovernedAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPolicyGovernedAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedAssets</summary>
        public void AnalyzeOrgPolicyGovernedAssets()
        {
            // Snippet: AnalyzeOrgPolicyGovernedAssets(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = AssetServiceClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedEnumerable<AnalyzeOrgPolicyGovernedAssetsResponse, AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> response = assetServiceClient.AnalyzeOrgPolicyGovernedAssets(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AnalyzeOrgPolicyGovernedAssetsAsync</summary>
        public async Task AnalyzeOrgPolicyGovernedAssetsAsync()
        {
            // Snippet: AnalyzeOrgPolicyGovernedAssetsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            AssetServiceClient assetServiceClient = await AssetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string constraint = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<AnalyzeOrgPolicyGovernedAssetsResponse, AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> response = assetServiceClient.AnalyzeOrgPolicyGovernedAssetsAsync(scope, constraint, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AnalyzeOrgPolicyGovernedAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AnalyzeOrgPolicyGovernedAssetsResponse.Types.GovernedAsset item in singlePage)
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
