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
    using Google.Cloud.Billing.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudBillingClientSnippets
    {
        /// <summary>Snippet for GetBillingAccount</summary>
        public void GetBillingAccountRequestObject()
        {
            // Snippet: GetBillingAccount(GetBillingAccountRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            // Make the request
            BillingAccount response = cloudBillingClient.GetBillingAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetBillingAccountAsync</summary>
        public async Task GetBillingAccountRequestObjectAsync()
        {
            // Snippet: GetBillingAccountAsync(GetBillingAccountRequest, CallSettings)
            // Additional: GetBillingAccountAsync(GetBillingAccountRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            GetBillingAccountRequest request = new GetBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            // Make the request
            BillingAccount response = await cloudBillingClient.GetBillingAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBillingAccount</summary>
        public void GetBillingAccount()
        {
            // Snippet: GetBillingAccount(string, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            // Make the request
            BillingAccount response = cloudBillingClient.GetBillingAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetBillingAccountAsync</summary>
        public async Task GetBillingAccountAsync()
        {
            // Snippet: GetBillingAccountAsync(string, CallSettings)
            // Additional: GetBillingAccountAsync(string, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            // Make the request
            BillingAccount response = await cloudBillingClient.GetBillingAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBillingAccount</summary>
        public void GetBillingAccountResourceNames()
        {
            // Snippet: GetBillingAccount(BillingAccountName, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            BillingAccount response = cloudBillingClient.GetBillingAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetBillingAccountAsync</summary>
        public async Task GetBillingAccountResourceNamesAsync()
        {
            // Snippet: GetBillingAccountAsync(BillingAccountName, CallSettings)
            // Additional: GetBillingAccountAsync(BillingAccountName, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            BillingAccount response = await cloudBillingClient.GetBillingAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccounts</summary>
        public void ListBillingAccountsRequestObject()
        {
            // Snippet: ListBillingAccounts(ListBillingAccountsRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            ListBillingAccountsRequest request = new ListBillingAccountsRequest
            {
                Filter = "",
                Parent = "",
            };
            // Make the request
            PagedEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BillingAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBillingAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccountsAsync</summary>
        public async Task ListBillingAccountsRequestObjectAsync()
        {
            // Snippet: ListBillingAccountsAsync(ListBillingAccountsRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            ListBillingAccountsRequest request = new ListBillingAccountsRequest
            {
                Filter = "",
                Parent = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BillingAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBillingAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccounts</summary>
        public void ListBillingAccounts1()
        {
            // Snippet: ListBillingAccounts(string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Make the request
            PagedEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccounts();

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BillingAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBillingAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccountsAsync</summary>
        public async Task ListBillingAccounts1Async()
        {
            // Snippet: ListBillingAccountsAsync(string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccountsAsync();

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BillingAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBillingAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccounts</summary>
        public void ListBillingAccounts2()
        {
            // Snippet: ListBillingAccounts(string, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccounts(parent: parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BillingAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBillingAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBillingAccountsAsync</summary>
        public async Task ListBillingAccounts2Async()
        {
            // Snippet: ListBillingAccountsAsync(string, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListBillingAccountsResponse, BillingAccount> response = cloudBillingClient.ListBillingAccountsAsync(parent: parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BillingAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBillingAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BillingAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BillingAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BillingAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccount</summary>
        public void UpdateBillingAccountRequestObject()
        {
            // Snippet: UpdateBillingAccount(UpdateBillingAccountRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BillingAccount response = cloudBillingClient.UpdateBillingAccount(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccountAsync</summary>
        public async Task UpdateBillingAccountRequestObjectAsync()
        {
            // Snippet: UpdateBillingAccountAsync(UpdateBillingAccountRequest, CallSettings)
            // Additional: UpdateBillingAccountAsync(UpdateBillingAccountRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBillingAccountRequest request = new UpdateBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                Account = new BillingAccount(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BillingAccount response = await cloudBillingClient.UpdateBillingAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccount</summary>
        public void UpdateBillingAccount()
        {
            // Snippet: UpdateBillingAccount(string, BillingAccount, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            BillingAccount account = new BillingAccount();
            // Make the request
            BillingAccount response = cloudBillingClient.UpdateBillingAccount(name, account);
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccountAsync</summary>
        public async Task UpdateBillingAccountAsync()
        {
            // Snippet: UpdateBillingAccountAsync(string, BillingAccount, CallSettings)
            // Additional: UpdateBillingAccountAsync(string, BillingAccount, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            BillingAccount account = new BillingAccount();
            // Make the request
            BillingAccount response = await cloudBillingClient.UpdateBillingAccountAsync(name, account);
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccount</summary>
        public void UpdateBillingAccountResourceNames()
        {
            // Snippet: UpdateBillingAccount(BillingAccountName, BillingAccount, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            BillingAccount account = new BillingAccount();
            // Make the request
            BillingAccount response = cloudBillingClient.UpdateBillingAccount(name, account);
            // End snippet
        }

        /// <summary>Snippet for UpdateBillingAccountAsync</summary>
        public async Task UpdateBillingAccountResourceNamesAsync()
        {
            // Snippet: UpdateBillingAccountAsync(BillingAccountName, BillingAccount, CallSettings)
            // Additional: UpdateBillingAccountAsync(BillingAccountName, BillingAccount, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            BillingAccount account = new BillingAccount();
            // Make the request
            BillingAccount response = await cloudBillingClient.UpdateBillingAccountAsync(name, account);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccount</summary>
        public void CreateBillingAccountRequestObject()
        {
            // Snippet: CreateBillingAccount(CreateBillingAccountRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
                Parent = "",
            };
            // Make the request
            BillingAccount response = cloudBillingClient.CreateBillingAccount(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccountAsync</summary>
        public async Task CreateBillingAccountRequestObjectAsync()
        {
            // Snippet: CreateBillingAccountAsync(CreateBillingAccountRequest, CallSettings)
            // Additional: CreateBillingAccountAsync(CreateBillingAccountRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            CreateBillingAccountRequest request = new CreateBillingAccountRequest
            {
                BillingAccount = new BillingAccount(),
                Parent = "",
            };
            // Make the request
            BillingAccount response = await cloudBillingClient.CreateBillingAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccount</summary>
        public void CreateBillingAccount1()
        {
            // Snippet: CreateBillingAccount(BillingAccount, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            BillingAccount billingAccount = new BillingAccount();
            // Make the request
            BillingAccount response = cloudBillingClient.CreateBillingAccount(billingAccount);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccountAsync</summary>
        public async Task CreateBillingAccount1Async()
        {
            // Snippet: CreateBillingAccountAsync(BillingAccount, CallSettings)
            // Additional: CreateBillingAccountAsync(BillingAccount, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccount billingAccount = new BillingAccount();
            // Make the request
            BillingAccount response = await cloudBillingClient.CreateBillingAccountAsync(billingAccount);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccount</summary>
        public void CreateBillingAccount2()
        {
            // Snippet: CreateBillingAccount(BillingAccount, string, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            BillingAccount billingAccount = new BillingAccount();
            string parent = "";
            // Make the request
            BillingAccount response = cloudBillingClient.CreateBillingAccount(billingAccount, parent);
            // End snippet
        }

        /// <summary>Snippet for CreateBillingAccountAsync</summary>
        public async Task CreateBillingAccount2Async()
        {
            // Snippet: CreateBillingAccountAsync(BillingAccount, string, CallSettings)
            // Additional: CreateBillingAccountAsync(BillingAccount, string, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccount billingAccount = new BillingAccount();
            string parent = "";
            // Make the request
            BillingAccount response = await cloudBillingClient.CreateBillingAccountAsync(billingAccount, parent);
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfo</summary>
        public void ListProjectBillingInfoRequestObject()
        {
            // Snippet: ListProjectBillingInfo(ListProjectBillingInfoRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfo(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectBillingInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectBillingInfoResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfoAsync</summary>
        public async Task ListProjectBillingInfoRequestObjectAsync()
        {
            // Snippet: ListProjectBillingInfoAsync(ListProjectBillingInfoRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            ListProjectBillingInfoRequest request = new ListProjectBillingInfoRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfoAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectBillingInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectBillingInfoResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfo</summary>
        public void ListProjectBillingInfo()
        {
            // Snippet: ListProjectBillingInfo(string, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            // Make the request
            PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfo(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectBillingInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectBillingInfoResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfoAsync</summary>
        public async Task ListProjectBillingInfoAsync()
        {
            // Snippet: ListProjectBillingInfoAsync(string, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string name = "billingAccounts/[BILLING_ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfoAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectBillingInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectBillingInfoResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfo</summary>
        public void ListProjectBillingInfoResourceNames()
        {
            // Snippet: ListProjectBillingInfo(BillingAccountName, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfo(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProjectBillingInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProjectBillingInfoResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProjectBillingInfoAsync</summary>
        public async Task ListProjectBillingInfoResourceNamesAsync()
        {
            // Snippet: ListProjectBillingInfoAsync(BillingAccountName, string, int?, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName name = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListProjectBillingInfoResponse, ProjectBillingInfo> response = cloudBillingClient.ListProjectBillingInfoAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProjectBillingInfo item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProjectBillingInfoResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProjectBillingInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProjectBillingInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProjectBillingInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfo</summary>
        public void GetProjectBillingInfoRequestObject()
        {
            // Snippet: GetProjectBillingInfo(GetProjectBillingInfoRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ProjectBillingInfo response = cloudBillingClient.GetProjectBillingInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfoAsync</summary>
        public async Task GetProjectBillingInfoRequestObjectAsync()
        {
            // Snippet: GetProjectBillingInfoAsync(GetProjectBillingInfoRequest, CallSettings)
            // Additional: GetProjectBillingInfoAsync(GetProjectBillingInfoRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            GetProjectBillingInfoRequest request = new GetProjectBillingInfoRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            ProjectBillingInfo response = await cloudBillingClient.GetProjectBillingInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfo</summary>
        public void GetProjectBillingInfo()
        {
            // Snippet: GetProjectBillingInfo(string, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            ProjectBillingInfo response = cloudBillingClient.GetProjectBillingInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfoAsync</summary>
        public async Task GetProjectBillingInfoAsync()
        {
            // Snippet: GetProjectBillingInfoAsync(string, CallSettings)
            // Additional: GetProjectBillingInfoAsync(string, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            ProjectBillingInfo response = await cloudBillingClient.GetProjectBillingInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfo</summary>
        public void GetProjectBillingInfoResourceNames()
        {
            // Snippet: GetProjectBillingInfo(ProjectName, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ProjectBillingInfo response = cloudBillingClient.GetProjectBillingInfo(name);
            // End snippet
        }

        /// <summary>Snippet for GetProjectBillingInfoAsync</summary>
        public async Task GetProjectBillingInfoResourceNamesAsync()
        {
            // Snippet: GetProjectBillingInfoAsync(ProjectName, CallSettings)
            // Additional: GetProjectBillingInfoAsync(ProjectName, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ProjectBillingInfo response = await cloudBillingClient.GetProjectBillingInfoAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectBillingInfo</summary>
        public void UpdateProjectBillingInfoRequestObject()
        {
            // Snippet: UpdateProjectBillingInfo(UpdateProjectBillingInfoRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            // Make the request
            ProjectBillingInfo response = cloudBillingClient.UpdateProjectBillingInfo(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectBillingInfoAsync</summary>
        public async Task UpdateProjectBillingInfoRequestObjectAsync()
        {
            // Snippet: UpdateProjectBillingInfoAsync(UpdateProjectBillingInfoRequest, CallSettings)
            // Additional: UpdateProjectBillingInfoAsync(UpdateProjectBillingInfoRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProjectBillingInfoRequest request = new UpdateProjectBillingInfoRequest
            {
                Name = "",
                ProjectBillingInfo = new ProjectBillingInfo(),
            };
            // Make the request
            ProjectBillingInfo response = await cloudBillingClient.UpdateProjectBillingInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectBillingInfo</summary>
        public void UpdateProjectBillingInfo()
        {
            // Snippet: UpdateProjectBillingInfo(string, ProjectBillingInfo, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string name = "";
            ProjectBillingInfo projectBillingInfo = new ProjectBillingInfo();
            // Make the request
            ProjectBillingInfo response = cloudBillingClient.UpdateProjectBillingInfo(name, projectBillingInfo);
            // End snippet
        }

        /// <summary>Snippet for UpdateProjectBillingInfoAsync</summary>
        public async Task UpdateProjectBillingInfoAsync()
        {
            // Snippet: UpdateProjectBillingInfoAsync(string, ProjectBillingInfo, CallSettings)
            // Additional: UpdateProjectBillingInfoAsync(string, ProjectBillingInfo, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            ProjectBillingInfo projectBillingInfo = new ProjectBillingInfo();
            // Make the request
            ProjectBillingInfo response = await cloudBillingClient.UpdateProjectBillingInfoAsync(name, projectBillingInfo);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = cloudBillingClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await cloudBillingClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = cloudBillingClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await cloudBillingClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = cloudBillingClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await cloudBillingClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = cloudBillingClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await cloudBillingClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudBillingClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudBillingClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = cloudBillingClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await cloudBillingClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudBillingClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await cloudBillingClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudBillingClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudBillingClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = cloudBillingClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await cloudBillingClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for MoveBillingAccount</summary>
        public void MoveBillingAccountRequestObject()
        {
            // Snippet: MoveBillingAccount(MoveBillingAccountRequest, CallSettings)
            // Create client
            CloudBillingClient cloudBillingClient = CloudBillingClient.Create();
            // Initialize request argument(s)
            MoveBillingAccountRequest request = new MoveBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                DestinationParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            BillingAccount response = cloudBillingClient.MoveBillingAccount(request);
            // End snippet
        }

        /// <summary>Snippet for MoveBillingAccountAsync</summary>
        public async Task MoveBillingAccountRequestObjectAsync()
        {
            // Snippet: MoveBillingAccountAsync(MoveBillingAccountRequest, CallSettings)
            // Additional: MoveBillingAccountAsync(MoveBillingAccountRequest, CancellationToken)
            // Create client
            CloudBillingClient cloudBillingClient = await CloudBillingClient.CreateAsync();
            // Initialize request argument(s)
            MoveBillingAccountRequest request = new MoveBillingAccountRequest
            {
                BillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                DestinationParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            BillingAccount response = await cloudBillingClient.MoveBillingAccountAsync(request);
            // End snippet
        }
    }
}
