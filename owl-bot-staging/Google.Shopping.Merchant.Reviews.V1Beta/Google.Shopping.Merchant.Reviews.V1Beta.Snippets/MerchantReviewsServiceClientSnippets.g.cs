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
    using Google.Shopping.Merchant.Reviews.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMerchantReviewsServiceClientSnippets
    {
        /// <summary>Snippet for GetMerchantReview</summary>
        public void GetMerchantReviewRequestObject()
        {
            // Snippet: GetMerchantReview(GetMerchantReviewRequest, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            GetMerchantReviewRequest request = new GetMerchantReviewRequest
            {
                MerchantReviewName = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]"),
            };
            // Make the request
            MerchantReview response = merchantReviewsServiceClient.GetMerchantReview(request);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantReviewAsync</summary>
        public async Task GetMerchantReviewRequestObjectAsync()
        {
            // Snippet: GetMerchantReviewAsync(GetMerchantReviewRequest, CallSettings)
            // Additional: GetMerchantReviewAsync(GetMerchantReviewRequest, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMerchantReviewRequest request = new GetMerchantReviewRequest
            {
                MerchantReviewName = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]"),
            };
            // Make the request
            MerchantReview response = await merchantReviewsServiceClient.GetMerchantReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantReview</summary>
        public void GetMerchantReview()
        {
            // Snippet: GetMerchantReview(string, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/merchantReviews/[NAME]";
            // Make the request
            MerchantReview response = merchantReviewsServiceClient.GetMerchantReview(name);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantReviewAsync</summary>
        public async Task GetMerchantReviewAsync()
        {
            // Snippet: GetMerchantReviewAsync(string, CallSettings)
            // Additional: GetMerchantReviewAsync(string, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/merchantReviews/[NAME]";
            // Make the request
            MerchantReview response = await merchantReviewsServiceClient.GetMerchantReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantReview</summary>
        public void GetMerchantReviewResourceNames()
        {
            // Snippet: GetMerchantReview(MerchantReviewName, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            MerchantReviewName name = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]");
            // Make the request
            MerchantReview response = merchantReviewsServiceClient.GetMerchantReview(name);
            // End snippet
        }

        /// <summary>Snippet for GetMerchantReviewAsync</summary>
        public async Task GetMerchantReviewResourceNamesAsync()
        {
            // Snippet: GetMerchantReviewAsync(MerchantReviewName, CallSettings)
            // Additional: GetMerchantReviewAsync(MerchantReviewName, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            MerchantReviewName name = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]");
            // Make the request
            MerchantReview response = await merchantReviewsServiceClient.GetMerchantReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviews</summary>
        public void ListMerchantReviewsRequestObject()
        {
            // Snippet: ListMerchantReviews(ListMerchantReviewsRequest, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MerchantReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMerchantReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviewsAsync</summary>
        public async Task ListMerchantReviewsRequestObjectAsync()
        {
            // Snippet: ListMerchantReviewsAsync(ListMerchantReviewsRequest, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMerchantReviewsRequest request = new ListMerchantReviewsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MerchantReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMerchantReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviews</summary>
        public void ListMerchantReviews()
        {
            // Snippet: ListMerchantReviews(string, string, int?, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MerchantReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMerchantReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviewsAsync</summary>
        public async Task ListMerchantReviewsAsync()
        {
            // Snippet: ListMerchantReviewsAsync(string, string, int?, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MerchantReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMerchantReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviews</summary>
        public void ListMerchantReviewsResourceNames()
        {
            // Snippet: ListMerchantReviews(AccountName, string, int?, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MerchantReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMerchantReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMerchantReviewsAsync</summary>
        public async Task ListMerchantReviewsResourceNamesAsync()
        {
            // Snippet: ListMerchantReviewsAsync(AccountName, string, int?, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListMerchantReviewsResponse, MerchantReview> response = merchantReviewsServiceClient.ListMerchantReviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MerchantReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMerchantReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MerchantReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MerchantReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MerchantReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for InsertMerchantReview</summary>
        public void InsertMerchantReviewRequestObject()
        {
            // Snippet: InsertMerchantReview(InsertMerchantReviewRequest, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            InsertMerchantReviewRequest request = new InsertMerchantReviewRequest
            {
                Parent = "",
                MerchantReview = new MerchantReview(),
                DataSource = "",
            };
            // Make the request
            MerchantReview response = merchantReviewsServiceClient.InsertMerchantReview(request);
            // End snippet
        }

        /// <summary>Snippet for InsertMerchantReviewAsync</summary>
        public async Task InsertMerchantReviewRequestObjectAsync()
        {
            // Snippet: InsertMerchantReviewAsync(InsertMerchantReviewRequest, CallSettings)
            // Additional: InsertMerchantReviewAsync(InsertMerchantReviewRequest, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertMerchantReviewRequest request = new InsertMerchantReviewRequest
            {
                Parent = "",
                MerchantReview = new MerchantReview(),
                DataSource = "",
            };
            // Make the request
            MerchantReview response = await merchantReviewsServiceClient.InsertMerchantReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReview</summary>
        public void DeleteMerchantReviewRequestObject()
        {
            // Snippet: DeleteMerchantReview(DeleteMerchantReviewRequest, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            DeleteMerchantReviewRequest request = new DeleteMerchantReviewRequest
            {
                MerchantReviewName = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]"),
            };
            // Make the request
            merchantReviewsServiceClient.DeleteMerchantReview(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReviewAsync</summary>
        public async Task DeleteMerchantReviewRequestObjectAsync()
        {
            // Snippet: DeleteMerchantReviewAsync(DeleteMerchantReviewRequest, CallSettings)
            // Additional: DeleteMerchantReviewAsync(DeleteMerchantReviewRequest, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMerchantReviewRequest request = new DeleteMerchantReviewRequest
            {
                MerchantReviewName = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]"),
            };
            // Make the request
            await merchantReviewsServiceClient.DeleteMerchantReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReview</summary>
        public void DeleteMerchantReview()
        {
            // Snippet: DeleteMerchantReview(string, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/merchantReviews/[NAME]";
            // Make the request
            merchantReviewsServiceClient.DeleteMerchantReview(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReviewAsync</summary>
        public async Task DeleteMerchantReviewAsync()
        {
            // Snippet: DeleteMerchantReviewAsync(string, CallSettings)
            // Additional: DeleteMerchantReviewAsync(string, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/merchantReviews/[NAME]";
            // Make the request
            await merchantReviewsServiceClient.DeleteMerchantReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReview</summary>
        public void DeleteMerchantReviewResourceNames()
        {
            // Snippet: DeleteMerchantReview(MerchantReviewName, CallSettings)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = MerchantReviewsServiceClient.Create();
            // Initialize request argument(s)
            MerchantReviewName name = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]");
            // Make the request
            merchantReviewsServiceClient.DeleteMerchantReview(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMerchantReviewAsync</summary>
        public async Task DeleteMerchantReviewResourceNamesAsync()
        {
            // Snippet: DeleteMerchantReviewAsync(MerchantReviewName, CallSettings)
            // Additional: DeleteMerchantReviewAsync(MerchantReviewName, CancellationToken)
            // Create client
            MerchantReviewsServiceClient merchantReviewsServiceClient = await MerchantReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            MerchantReviewName name = MerchantReviewName.FromAccountName("[ACCOUNT]", "[NAME]");
            // Make the request
            await merchantReviewsServiceClient.DeleteMerchantReviewAsync(name);
            // End snippet
        }
    }
}
