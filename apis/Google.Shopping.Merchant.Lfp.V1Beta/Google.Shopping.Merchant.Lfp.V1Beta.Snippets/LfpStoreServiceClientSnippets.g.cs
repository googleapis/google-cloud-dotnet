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
    using Google.Shopping.Merchant.Lfp.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLfpStoreServiceClientSnippets
    {
        /// <summary>Snippet for GetLfpStore</summary>
        public void GetLfpStoreRequestObject()
        {
            // Snippet: GetLfpStore(GetLfpStoreRequest, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            GetLfpStoreRequest request = new GetLfpStoreRequest
            {
                LfpStoreName = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]"),
            };
            // Make the request
            LfpStore response = lfpStoreServiceClient.GetLfpStore(request);
            // End snippet
        }

        /// <summary>Snippet for GetLfpStoreAsync</summary>
        public async Task GetLfpStoreRequestObjectAsync()
        {
            // Snippet: GetLfpStoreAsync(GetLfpStoreRequest, CallSettings)
            // Additional: GetLfpStoreAsync(GetLfpStoreRequest, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLfpStoreRequest request = new GetLfpStoreRequest
            {
                LfpStoreName = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]"),
            };
            // Make the request
            LfpStore response = await lfpStoreServiceClient.GetLfpStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLfpStore</summary>
        public void GetLfpStore()
        {
            // Snippet: GetLfpStore(string, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpStores/[TARGET_MERCHANT]~[STORE_CODE]";
            // Make the request
            LfpStore response = lfpStoreServiceClient.GetLfpStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpStoreAsync</summary>
        public async Task GetLfpStoreAsync()
        {
            // Snippet: GetLfpStoreAsync(string, CallSettings)
            // Additional: GetLfpStoreAsync(string, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpStores/[TARGET_MERCHANT]~[STORE_CODE]";
            // Make the request
            LfpStore response = await lfpStoreServiceClient.GetLfpStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpStore</summary>
        public void GetLfpStoreResourceNames()
        {
            // Snippet: GetLfpStore(LfpStoreName, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            LfpStoreName name = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]");
            // Make the request
            LfpStore response = lfpStoreServiceClient.GetLfpStore(name);
            // End snippet
        }

        /// <summary>Snippet for GetLfpStoreAsync</summary>
        public async Task GetLfpStoreResourceNamesAsync()
        {
            // Snippet: GetLfpStoreAsync(LfpStoreName, CallSettings)
            // Additional: GetLfpStoreAsync(LfpStoreName, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LfpStoreName name = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]");
            // Make the request
            LfpStore response = await lfpStoreServiceClient.GetLfpStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStore</summary>
        public void InsertLfpStoreRequestObject()
        {
            // Snippet: InsertLfpStore(InsertLfpStoreRequest, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            InsertLfpStoreRequest request = new InsertLfpStoreRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LfpStore = new LfpStore(),
            };
            // Make the request
            LfpStore response = lfpStoreServiceClient.InsertLfpStore(request);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStoreAsync</summary>
        public async Task InsertLfpStoreRequestObjectAsync()
        {
            // Snippet: InsertLfpStoreAsync(InsertLfpStoreRequest, CallSettings)
            // Additional: InsertLfpStoreAsync(InsertLfpStoreRequest, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertLfpStoreRequest request = new InsertLfpStoreRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LfpStore = new LfpStore(),
            };
            // Make the request
            LfpStore response = await lfpStoreServiceClient.InsertLfpStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStore</summary>
        public void InsertLfpStore()
        {
            // Snippet: InsertLfpStore(string, LfpStore, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            LfpStore lfpStore = new LfpStore();
            // Make the request
            LfpStore response = lfpStoreServiceClient.InsertLfpStore(parent, lfpStore);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStoreAsync</summary>
        public async Task InsertLfpStoreAsync()
        {
            // Snippet: InsertLfpStoreAsync(string, LfpStore, CallSettings)
            // Additional: InsertLfpStoreAsync(string, LfpStore, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            LfpStore lfpStore = new LfpStore();
            // Make the request
            LfpStore response = await lfpStoreServiceClient.InsertLfpStoreAsync(parent, lfpStore);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStore</summary>
        public void InsertLfpStoreResourceNames()
        {
            // Snippet: InsertLfpStore(AccountName, LfpStore, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            LfpStore lfpStore = new LfpStore();
            // Make the request
            LfpStore response = lfpStoreServiceClient.InsertLfpStore(parent, lfpStore);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpStoreAsync</summary>
        public async Task InsertLfpStoreResourceNamesAsync()
        {
            // Snippet: InsertLfpStoreAsync(AccountName, LfpStore, CallSettings)
            // Additional: InsertLfpStoreAsync(AccountName, LfpStore, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            LfpStore lfpStore = new LfpStore();
            // Make the request
            LfpStore response = await lfpStoreServiceClient.InsertLfpStoreAsync(parent, lfpStore);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStore</summary>
        public void DeleteLfpStoreRequestObject()
        {
            // Snippet: DeleteLfpStore(DeleteLfpStoreRequest, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            DeleteLfpStoreRequest request = new DeleteLfpStoreRequest
            {
                LfpStoreName = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]"),
            };
            // Make the request
            lfpStoreServiceClient.DeleteLfpStore(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStoreAsync</summary>
        public async Task DeleteLfpStoreRequestObjectAsync()
        {
            // Snippet: DeleteLfpStoreAsync(DeleteLfpStoreRequest, CallSettings)
            // Additional: DeleteLfpStoreAsync(DeleteLfpStoreRequest, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLfpStoreRequest request = new DeleteLfpStoreRequest
            {
                LfpStoreName = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]"),
            };
            // Make the request
            await lfpStoreServiceClient.DeleteLfpStoreAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStore</summary>
        public void DeleteLfpStore()
        {
            // Snippet: DeleteLfpStore(string, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpStores/[TARGET_MERCHANT]~[STORE_CODE]";
            // Make the request
            lfpStoreServiceClient.DeleteLfpStore(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStoreAsync</summary>
        public async Task DeleteLfpStoreAsync()
        {
            // Snippet: DeleteLfpStoreAsync(string, CallSettings)
            // Additional: DeleteLfpStoreAsync(string, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/lfpStores/[TARGET_MERCHANT]~[STORE_CODE]";
            // Make the request
            await lfpStoreServiceClient.DeleteLfpStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStore</summary>
        public void DeleteLfpStoreResourceNames()
        {
            // Snippet: DeleteLfpStore(LfpStoreName, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            LfpStoreName name = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]");
            // Make the request
            lfpStoreServiceClient.DeleteLfpStore(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteLfpStoreAsync</summary>
        public async Task DeleteLfpStoreResourceNamesAsync()
        {
            // Snippet: DeleteLfpStoreAsync(LfpStoreName, CallSettings)
            // Additional: DeleteLfpStoreAsync(LfpStoreName, CancellationToken)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            LfpStoreName name = LfpStoreName.FromAccountTargetMerchantStoreCode("[ACCOUNT]", "[TARGET_MERCHANT]", "[STORE_CODE]");
            // Make the request
            await lfpStoreServiceClient.DeleteLfpStoreAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLfpStores</summary>
        public void ListLfpStoresRequestObject()
        {
            // Snippet: ListLfpStores(ListLfpStoresRequest, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            ListLfpStoresRequest request = new ListLfpStoresRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                TargetAccount = 0L,
            };
            // Make the request
            PagedEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStores(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLfpStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLfpStoresAsync</summary>
        public async Task ListLfpStoresRequestObjectAsync()
        {
            // Snippet: ListLfpStoresAsync(ListLfpStoresRequest, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLfpStoresRequest request = new ListLfpStoresRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                TargetAccount = 0L,
            };
            // Make the request
            PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStoresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLfpStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLfpStores</summary>
        public void ListLfpStores()
        {
            // Snippet: ListLfpStores(string, string, int?, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLfpStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLfpStoresAsync</summary>
        public async Task ListLfpStoresAsync()
        {
            // Snippet: ListLfpStoresAsync(string, string, int?, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLfpStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLfpStores</summary>
        public void ListLfpStoresResourceNames()
        {
            // Snippet: ListLfpStores(AccountName, string, int?, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = LfpStoreServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStores(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LfpStore item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLfpStoresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLfpStoresAsync</summary>
        public async Task ListLfpStoresResourceNamesAsync()
        {
            // Snippet: ListLfpStoresAsync(AccountName, string, int?, CallSettings)
            // Create client
            LfpStoreServiceClient lfpStoreServiceClient = await LfpStoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListLfpStoresResponse, LfpStore> response = lfpStoreServiceClient.ListLfpStoresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LfpStore item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLfpStoresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LfpStore item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LfpStore> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LfpStore item in singlePage)
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
