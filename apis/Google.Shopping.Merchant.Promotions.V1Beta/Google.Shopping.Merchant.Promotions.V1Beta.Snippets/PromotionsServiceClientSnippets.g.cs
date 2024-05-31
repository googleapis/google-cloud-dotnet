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
    using Google.Shopping.Merchant.Promotions.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPromotionsServiceClientSnippets
    {
        /// <summary>Snippet for InsertPromotion</summary>
        public void InsertPromotionRequestObject()
        {
            // Snippet: InsertPromotion(InsertPromotionRequest, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            InsertPromotionRequest request = new InsertPromotionRequest
            {
                Parent = "",
                Promotion = new Promotion(),
                DataSource = "",
            };
            // Make the request
            Promotion response = promotionsServiceClient.InsertPromotion(request);
            // End snippet
        }

        /// <summary>Snippet for InsertPromotionAsync</summary>
        public async Task InsertPromotionRequestObjectAsync()
        {
            // Snippet: InsertPromotionAsync(InsertPromotionRequest, CallSettings)
            // Additional: InsertPromotionAsync(InsertPromotionRequest, CancellationToken)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertPromotionRequest request = new InsertPromotionRequest
            {
                Parent = "",
                Promotion = new Promotion(),
                DataSource = "",
            };
            // Make the request
            Promotion response = await promotionsServiceClient.InsertPromotionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPromotion</summary>
        public void GetPromotionRequestObject()
        {
            // Snippet: GetPromotion(GetPromotionRequest, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            GetPromotionRequest request = new GetPromotionRequest
            {
                PromotionName = PromotionName.FromAccountPromotion("[ACCOUNT]", "[PROMOTION]"),
            };
            // Make the request
            Promotion response = promotionsServiceClient.GetPromotion(request);
            // End snippet
        }

        /// <summary>Snippet for GetPromotionAsync</summary>
        public async Task GetPromotionRequestObjectAsync()
        {
            // Snippet: GetPromotionAsync(GetPromotionRequest, CallSettings)
            // Additional: GetPromotionAsync(GetPromotionRequest, CancellationToken)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPromotionRequest request = new GetPromotionRequest
            {
                PromotionName = PromotionName.FromAccountPromotion("[ACCOUNT]", "[PROMOTION]"),
            };
            // Make the request
            Promotion response = await promotionsServiceClient.GetPromotionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPromotion</summary>
        public void GetPromotion()
        {
            // Snippet: GetPromotion(string, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/promotions/[PROMOTION]";
            // Make the request
            Promotion response = promotionsServiceClient.GetPromotion(name);
            // End snippet
        }

        /// <summary>Snippet for GetPromotionAsync</summary>
        public async Task GetPromotionAsync()
        {
            // Snippet: GetPromotionAsync(string, CallSettings)
            // Additional: GetPromotionAsync(string, CancellationToken)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/promotions/[PROMOTION]";
            // Make the request
            Promotion response = await promotionsServiceClient.GetPromotionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPromotion</summary>
        public void GetPromotionResourceNames()
        {
            // Snippet: GetPromotion(PromotionName, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            PromotionName name = PromotionName.FromAccountPromotion("[ACCOUNT]", "[PROMOTION]");
            // Make the request
            Promotion response = promotionsServiceClient.GetPromotion(name);
            // End snippet
        }

        /// <summary>Snippet for GetPromotionAsync</summary>
        public async Task GetPromotionResourceNamesAsync()
        {
            // Snippet: GetPromotionAsync(PromotionName, CallSettings)
            // Additional: GetPromotionAsync(PromotionName, CancellationToken)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PromotionName name = PromotionName.FromAccountPromotion("[ACCOUNT]", "[PROMOTION]");
            // Make the request
            Promotion response = await promotionsServiceClient.GetPromotionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPromotions</summary>
        public void ListPromotionsRequestObject()
        {
            // Snippet: ListPromotions(ListPromotionsRequest, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            ListPromotionsRequest request = new ListPromotionsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListPromotionsResponse, Promotion> response = promotionsServiceClient.ListPromotions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Promotion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPromotionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Promotion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Promotion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Promotion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPromotionsAsync</summary>
        public async Task ListPromotionsRequestObjectAsync()
        {
            // Snippet: ListPromotionsAsync(ListPromotionsRequest, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPromotionsRequest request = new ListPromotionsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListPromotionsResponse, Promotion> response = promotionsServiceClient.ListPromotionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Promotion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPromotionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Promotion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Promotion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Promotion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPromotions</summary>
        public void ListPromotions()
        {
            // Snippet: ListPromotions(string, string, int?, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = PromotionsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListPromotionsResponse, Promotion> response = promotionsServiceClient.ListPromotions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Promotion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPromotionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Promotion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Promotion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Promotion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPromotionsAsync</summary>
        public async Task ListPromotionsAsync()
        {
            // Snippet: ListPromotionsAsync(string, string, int?, CallSettings)
            // Create client
            PromotionsServiceClient promotionsServiceClient = await PromotionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListPromotionsResponse, Promotion> response = promotionsServiceClient.ListPromotionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Promotion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPromotionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Promotion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Promotion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Promotion item in singlePage)
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
