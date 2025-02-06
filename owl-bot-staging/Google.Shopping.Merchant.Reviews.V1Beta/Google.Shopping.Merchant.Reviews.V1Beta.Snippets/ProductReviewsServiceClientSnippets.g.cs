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
    public sealed class AllGeneratedProductReviewsServiceClientSnippets
    {
        /// <summary>Snippet for GetProductReview</summary>
        public void GetProductReviewRequestObject()
        {
            // Snippet: GetProductReview(GetProductReviewRequest, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            GetProductReviewRequest request = new GetProductReviewRequest
            {
                ProductReviewName = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]"),
            };
            // Make the request
            ProductReview response = productReviewsServiceClient.GetProductReview(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductReviewAsync</summary>
        public async Task GetProductReviewRequestObjectAsync()
        {
            // Snippet: GetProductReviewAsync(GetProductReviewRequest, CallSettings)
            // Additional: GetProductReviewAsync(GetProductReviewRequest, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductReviewRequest request = new GetProductReviewRequest
            {
                ProductReviewName = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]"),
            };
            // Make the request
            ProductReview response = await productReviewsServiceClient.GetProductReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductReview</summary>
        public void GetProductReview()
        {
            // Snippet: GetProductReview(string, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productReviews/[PRODUCTREVIEW]";
            // Make the request
            ProductReview response = productReviewsServiceClient.GetProductReview(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductReviewAsync</summary>
        public async Task GetProductReviewAsync()
        {
            // Snippet: GetProductReviewAsync(string, CallSettings)
            // Additional: GetProductReviewAsync(string, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productReviews/[PRODUCTREVIEW]";
            // Make the request
            ProductReview response = await productReviewsServiceClient.GetProductReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductReview</summary>
        public void GetProductReviewResourceNames()
        {
            // Snippet: GetProductReview(ProductReviewName, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            ProductReviewName name = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]");
            // Make the request
            ProductReview response = productReviewsServiceClient.GetProductReview(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductReviewAsync</summary>
        public async Task GetProductReviewResourceNamesAsync()
        {
            // Snippet: GetProductReviewAsync(ProductReviewName, CallSettings)
            // Additional: GetProductReviewAsync(ProductReviewName, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductReviewName name = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]");
            // Make the request
            ProductReview response = await productReviewsServiceClient.GetProductReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProductReviews</summary>
        public void ListProductReviewsRequestObject()
        {
            // Snippet: ListProductReviews(ListProductReviewsRequest, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            ListProductReviewsRequest request = new ListProductReviewsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductReviewsAsync</summary>
        public async Task ListProductReviewsRequestObjectAsync()
        {
            // Snippet: ListProductReviewsAsync(ListProductReviewsRequest, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProductReviewsRequest request = new ListProductReviewsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductReviews</summary>
        public void ListProductReviews()
        {
            // Snippet: ListProductReviews(string, string, int?, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductReviewsAsync</summary>
        public async Task ListProductReviewsAsync()
        {
            // Snippet: ListProductReviewsAsync(string, string, int?, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductReviews</summary>
        public void ListProductReviewsResourceNames()
        {
            // Snippet: ListProductReviews(AccountName, string, int?, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductReview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductReviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductReviewsAsync</summary>
        public async Task ListProductReviewsResourceNamesAsync()
        {
            // Snippet: ListProductReviewsAsync(AccountName, string, int?, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListProductReviewsResponse, ProductReview> response = productReviewsServiceClient.ListProductReviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductReview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductReviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductReview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductReview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductReview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for InsertProductReview</summary>
        public void InsertProductReviewRequestObject()
        {
            // Snippet: InsertProductReview(InsertProductReviewRequest, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            InsertProductReviewRequest request = new InsertProductReviewRequest
            {
                Parent = "",
                ProductReview = new ProductReview(),
                DataSource = "",
            };
            // Make the request
            ProductReview response = productReviewsServiceClient.InsertProductReview(request);
            // End snippet
        }

        /// <summary>Snippet for InsertProductReviewAsync</summary>
        public async Task InsertProductReviewRequestObjectAsync()
        {
            // Snippet: InsertProductReviewAsync(InsertProductReviewRequest, CallSettings)
            // Additional: InsertProductReviewAsync(InsertProductReviewRequest, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertProductReviewRequest request = new InsertProductReviewRequest
            {
                Parent = "",
                ProductReview = new ProductReview(),
                DataSource = "",
            };
            // Make the request
            ProductReview response = await productReviewsServiceClient.InsertProductReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReview</summary>
        public void DeleteProductReviewRequestObject()
        {
            // Snippet: DeleteProductReview(DeleteProductReviewRequest, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            DeleteProductReviewRequest request = new DeleteProductReviewRequest
            {
                ProductReviewName = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]"),
            };
            // Make the request
            productReviewsServiceClient.DeleteProductReview(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReviewAsync</summary>
        public async Task DeleteProductReviewRequestObjectAsync()
        {
            // Snippet: DeleteProductReviewAsync(DeleteProductReviewRequest, CallSettings)
            // Additional: DeleteProductReviewAsync(DeleteProductReviewRequest, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductReviewRequest request = new DeleteProductReviewRequest
            {
                ProductReviewName = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]"),
            };
            // Make the request
            await productReviewsServiceClient.DeleteProductReviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReview</summary>
        public void DeleteProductReview()
        {
            // Snippet: DeleteProductReview(string, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productReviews/[PRODUCTREVIEW]";
            // Make the request
            productReviewsServiceClient.DeleteProductReview(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReviewAsync</summary>
        public async Task DeleteProductReviewAsync()
        {
            // Snippet: DeleteProductReviewAsync(string, CallSettings)
            // Additional: DeleteProductReviewAsync(string, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productReviews/[PRODUCTREVIEW]";
            // Make the request
            await productReviewsServiceClient.DeleteProductReviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReview</summary>
        public void DeleteProductReviewResourceNames()
        {
            // Snippet: DeleteProductReview(ProductReviewName, CallSettings)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = ProductReviewsServiceClient.Create();
            // Initialize request argument(s)
            ProductReviewName name = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]");
            // Make the request
            productReviewsServiceClient.DeleteProductReview(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductReviewAsync</summary>
        public async Task DeleteProductReviewResourceNamesAsync()
        {
            // Snippet: DeleteProductReviewAsync(ProductReviewName, CallSettings)
            // Additional: DeleteProductReviewAsync(ProductReviewName, CancellationToken)
            // Create client
            ProductReviewsServiceClient productReviewsServiceClient = await ProductReviewsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductReviewName name = ProductReviewName.FromAccountProductreview("[ACCOUNT]", "[PRODUCTREVIEW]");
            // Make the request
            await productReviewsServiceClient.DeleteProductReviewAsync(name);
            // End snippet
        }
    }
}
