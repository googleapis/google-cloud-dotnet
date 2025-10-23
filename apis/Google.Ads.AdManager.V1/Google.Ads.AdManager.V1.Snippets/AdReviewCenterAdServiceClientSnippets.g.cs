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
    using Google.LongRunning;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdReviewCenterAdServiceClientSnippets
    {
        /// <summary>Snippet for SearchAdReviewCenterAds</summary>
        public void SearchAdReviewCenterAdsRequestObject()
        {
            // Snippet: SearchAdReviewCenterAds(SearchAdReviewCenterAdsRequest, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                Status = AdReviewCenterAdStatusEnum.Types.AdReviewCenterAdStatus.Unspecified,
                AdReviewCenterAdId = { "", },
                DateTimeRange = new Interval(),
                SearchText = { "", },
                BuyerAccountId = { 0L, },
            };
            // Make the request
            PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAds(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdReviewCenterAd item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAdReviewCenterAdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAdReviewCenterAdsAsync</summary>
        public async Task SearchAdReviewCenterAdsRequestObjectAsync()
        {
            // Snippet: SearchAdReviewCenterAdsAsync(SearchAdReviewCenterAdsRequest, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAdReviewCenterAdsRequest request = new SearchAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                Status = AdReviewCenterAdStatusEnum.Types.AdReviewCenterAdStatus.Unspecified,
                AdReviewCenterAdId = { "", },
                DateTimeRange = new Interval(),
                SearchText = { "", },
                BuyerAccountId = { 0L, },
            };
            // Make the request
            PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAdsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdReviewCenterAd item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAdReviewCenterAdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAdReviewCenterAds</summary>
        public void SearchAdReviewCenterAds()
        {
            // Snippet: SearchAdReviewCenterAds(string, string, int?, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdReviewCenterAd item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAdReviewCenterAdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAdReviewCenterAdsAsync</summary>
        public async Task SearchAdReviewCenterAdsAsync()
        {
            // Snippet: SearchAdReviewCenterAdsAsync(string, string, int?, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAdsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdReviewCenterAd item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAdReviewCenterAdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAdReviewCenterAds</summary>
        public void SearchAdReviewCenterAdsResourceNames()
        {
            // Snippet: SearchAdReviewCenterAds(WebPropertyName, string, int?, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            PagedEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAds(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdReviewCenterAd item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAdReviewCenterAdsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAdReviewCenterAdsAsync</summary>
        public async Task SearchAdReviewCenterAdsResourceNamesAsync()
        {
            // Snippet: SearchAdReviewCenterAdsAsync(WebPropertyName, string, int?, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<SearchAdReviewCenterAdsResponse, AdReviewCenterAd> response = adReviewCenterAdServiceClient.SearchAdReviewCenterAdsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdReviewCenterAd item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchAdReviewCenterAdsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdReviewCenterAd item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdReviewCenterAd> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdReviewCenterAd item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAds</summary>
        public void BatchAllowAdReviewCenterAdsRequestObject()
        {
            // Snippet: BatchAllowAdReviewCenterAds(BatchAllowAdReviewCenterAdsRequest, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            BatchAllowAdReviewCenterAdsRequest request = new BatchAllowAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                AdReviewCenterAdNames =
                {
                    AdReviewCenterAdName.FromNetworkCodeWebPropertyCodeAdReviewCenterAd("[NETWORK_CODE]", "[WEB_PROPERTY_CODE]", "[AD_REVIEW_CENTER_AD]"),
                },
            };
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAds(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAdsAsync</summary>
        public async Task BatchAllowAdReviewCenterAdsRequestObjectAsync()
        {
            // Snippet: BatchAllowAdReviewCenterAdsAsync(BatchAllowAdReviewCenterAdsRequest, CallSettings)
            // Additional: BatchAllowAdReviewCenterAdsAsync(BatchAllowAdReviewCenterAdsRequest, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchAllowAdReviewCenterAdsRequest request = new BatchAllowAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                AdReviewCenterAdNames =
                {
                    AdReviewCenterAdName.FromNetworkCodeWebPropertyCodeAdReviewCenterAd("[NETWORK_CODE]", "[WEB_PROPERTY_CODE]", "[AD_REVIEW_CENTER_AD]"),
                },
            };
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAdsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAds</summary>
        public void BatchAllowAdReviewCenterAds()
        {
            // Snippet: BatchAllowAdReviewCenterAds(string, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAds(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAdsAsync</summary>
        public async Task BatchAllowAdReviewCenterAdsAsync()
        {
            // Snippet: BatchAllowAdReviewCenterAdsAsync(string, CallSettings)
            // Additional: BatchAllowAdReviewCenterAdsAsync(string, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAdsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAds</summary>
        public void BatchAllowAdReviewCenterAdsResourceNames()
        {
            // Snippet: BatchAllowAdReviewCenterAds(WebPropertyName, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAds(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchAllowAdReviewCenterAdsAsync</summary>
        public async Task BatchAllowAdReviewCenterAdsResourceNamesAsync()
        {
            // Snippet: BatchAllowAdReviewCenterAdsAsync(WebPropertyName, CallSettings)
            // Additional: BatchAllowAdReviewCenterAdsAsync(WebPropertyName, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchAllowAdReviewCenterAdsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchAllowAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchAllowAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchAllowAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchAllowAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAds</summary>
        public void BatchBlockAdReviewCenterAdsRequestObject()
        {
            // Snippet: BatchBlockAdReviewCenterAds(BatchBlockAdReviewCenterAdsRequest, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            BatchBlockAdReviewCenterAdsRequest request = new BatchBlockAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                AdReviewCenterAdNames =
                {
                    AdReviewCenterAdName.FromNetworkCodeWebPropertyCodeAdReviewCenterAd("[NETWORK_CODE]", "[WEB_PROPERTY_CODE]", "[AD_REVIEW_CENTER_AD]"),
                },
            };
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAds(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAdsAsync</summary>
        public async Task BatchBlockAdReviewCenterAdsRequestObjectAsync()
        {
            // Snippet: BatchBlockAdReviewCenterAdsAsync(BatchBlockAdReviewCenterAdsRequest, CallSettings)
            // Additional: BatchBlockAdReviewCenterAdsAsync(BatchBlockAdReviewCenterAdsRequest, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchBlockAdReviewCenterAdsRequest request = new BatchBlockAdReviewCenterAdsRequest
            {
                ParentAsWebPropertyName = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]"),
                AdReviewCenterAdNames =
                {
                    AdReviewCenterAdName.FromNetworkCodeWebPropertyCodeAdReviewCenterAd("[NETWORK_CODE]", "[WEB_PROPERTY_CODE]", "[AD_REVIEW_CENTER_AD]"),
                },
            };
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAdsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAds</summary>
        public void BatchBlockAdReviewCenterAds()
        {
            // Snippet: BatchBlockAdReviewCenterAds(string, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAds(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAdsAsync</summary>
        public async Task BatchBlockAdReviewCenterAdsAsync()
        {
            // Snippet: BatchBlockAdReviewCenterAdsAsync(string, CallSettings)
            // Additional: BatchBlockAdReviewCenterAdsAsync(string, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]/webProperties/[WEB_PROPERTY]";
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAdsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAds</summary>
        public void BatchBlockAdReviewCenterAdsResourceNames()
        {
            // Snippet: BatchBlockAdReviewCenterAds(WebPropertyName, CallSettings)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = AdReviewCenterAdServiceClient.Create();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAds(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAds(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchBlockAdReviewCenterAdsAsync</summary>
        public async Task BatchBlockAdReviewCenterAdsResourceNamesAsync()
        {
            // Snippet: BatchBlockAdReviewCenterAdsAsync(WebPropertyName, CallSettings)
            // Additional: BatchBlockAdReviewCenterAdsAsync(WebPropertyName, CancellationToken)
            // Create client
            AdReviewCenterAdServiceClient adReviewCenterAdServiceClient = await AdReviewCenterAdServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebPropertyName parent = WebPropertyName.FromNetworkCodeWebProperty("[NETWORK_CODE]", "[WEB_PROPERTY]");
            // Make the request
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> response = await adReviewCenterAdServiceClient.BatchBlockAdReviewCenterAdsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchBlockAdReviewCenterAdsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchBlockAdReviewCenterAdsResponse, BatchAdReviewCenterAdsOperationMetadata> retrievedResponse = await adReviewCenterAdServiceClient.PollOnceBatchBlockAdReviewCenterAdsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchBlockAdReviewCenterAdsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
