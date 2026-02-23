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
    using Google.Ads.DataManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserListGlobalLicenseServiceClientSnippets
    {
        /// <summary>Snippet for CreateUserListGlobalLicense</summary>
        public void CreateUserListGlobalLicenseRequestObject()
        {
            // Snippet: CreateUserListGlobalLicense(CreateUserListGlobalLicenseRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            CreateUserListGlobalLicenseRequest request = new CreateUserListGlobalLicenseRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserListGlobalLicense = new UserListGlobalLicense(),
            };
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.CreateUserListGlobalLicense(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListGlobalLicenseAsync</summary>
        public async Task CreateUserListGlobalLicenseRequestObjectAsync()
        {
            // Snippet: CreateUserListGlobalLicenseAsync(CreateUserListGlobalLicenseRequest, CallSettings)
            // Additional: CreateUserListGlobalLicenseAsync(CreateUserListGlobalLicenseRequest, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserListGlobalLicenseRequest request = new CreateUserListGlobalLicenseRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserListGlobalLicense = new UserListGlobalLicense(),
            };
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.CreateUserListGlobalLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListGlobalLicense</summary>
        public void CreateUserListGlobalLicense()
        {
            // Snippet: CreateUserListGlobalLicense(string, UserListGlobalLicense, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.CreateUserListGlobalLicense(parent, userListGlobalLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListGlobalLicenseAsync</summary>
        public async Task CreateUserListGlobalLicenseAsync()
        {
            // Snippet: CreateUserListGlobalLicenseAsync(string, UserListGlobalLicense, CallSettings)
            // Additional: CreateUserListGlobalLicenseAsync(string, UserListGlobalLicense, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.CreateUserListGlobalLicenseAsync(parent, userListGlobalLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListGlobalLicense</summary>
        public void CreateUserListGlobalLicenseResourceNames()
        {
            // Snippet: CreateUserListGlobalLicense(AccountName, UserListGlobalLicense, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.CreateUserListGlobalLicense(parent, userListGlobalLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListGlobalLicenseAsync</summary>
        public async Task CreateUserListGlobalLicenseResourceNamesAsync()
        {
            // Snippet: CreateUserListGlobalLicenseAsync(AccountName, UserListGlobalLicense, CallSettings)
            // Additional: CreateUserListGlobalLicenseAsync(AccountName, UserListGlobalLicense, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.CreateUserListGlobalLicenseAsync(parent, userListGlobalLicense);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListGlobalLicense</summary>
        public void UpdateUserListGlobalLicenseRequestObject()
        {
            // Snippet: UpdateUserListGlobalLicense(UpdateUserListGlobalLicenseRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserListGlobalLicenseRequest request = new UpdateUserListGlobalLicenseRequest
            {
                UserListGlobalLicense = new UserListGlobalLicense(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.UpdateUserListGlobalLicense(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListGlobalLicenseAsync</summary>
        public async Task UpdateUserListGlobalLicenseRequestObjectAsync()
        {
            // Snippet: UpdateUserListGlobalLicenseAsync(UpdateUserListGlobalLicenseRequest, CallSettings)
            // Additional: UpdateUserListGlobalLicenseAsync(UpdateUserListGlobalLicenseRequest, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserListGlobalLicenseRequest request = new UpdateUserListGlobalLicenseRequest
            {
                UserListGlobalLicense = new UserListGlobalLicense(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.UpdateUserListGlobalLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListGlobalLicense</summary>
        public void UpdateUserListGlobalLicense()
        {
            // Snippet: UpdateUserListGlobalLicense(UserListGlobalLicense, FieldMask, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.UpdateUserListGlobalLicense(userListGlobalLicense, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListGlobalLicenseAsync</summary>
        public async Task UpdateUserListGlobalLicenseAsync()
        {
            // Snippet: UpdateUserListGlobalLicenseAsync(UserListGlobalLicense, FieldMask, CallSettings)
            // Additional: UpdateUserListGlobalLicenseAsync(UserListGlobalLicense, FieldMask, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListGlobalLicense userListGlobalLicense = new UserListGlobalLicense();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.UpdateUserListGlobalLicenseAsync(userListGlobalLicense, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicense</summary>
        public void GetUserListGlobalLicenseRequestObject()
        {
            // Snippet: GetUserListGlobalLicense(GetUserListGlobalLicenseRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            GetUserListGlobalLicenseRequest request = new GetUserListGlobalLicenseRequest
            {
                UserListGlobalLicenseName = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]"),
            };
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.GetUserListGlobalLicense(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicenseAsync</summary>
        public async Task GetUserListGlobalLicenseRequestObjectAsync()
        {
            // Snippet: GetUserListGlobalLicenseAsync(GetUserListGlobalLicenseRequest, CallSettings)
            // Additional: GetUserListGlobalLicenseAsync(GetUserListGlobalLicenseRequest, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserListGlobalLicenseRequest request = new GetUserListGlobalLicenseRequest
            {
                UserListGlobalLicenseName = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]"),
            };
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.GetUserListGlobalLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicense</summary>
        public void GetUserListGlobalLicense()
        {
            // Snippet: GetUserListGlobalLicense(string, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListGlobalLicenses/[USER_LIST_GLOBAL_LICENSE]";
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.GetUserListGlobalLicense(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicenseAsync</summary>
        public async Task GetUserListGlobalLicenseAsync()
        {
            // Snippet: GetUserListGlobalLicenseAsync(string, CallSettings)
            // Additional: GetUserListGlobalLicenseAsync(string, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListGlobalLicenses/[USER_LIST_GLOBAL_LICENSE]";
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.GetUserListGlobalLicenseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicense</summary>
        public void GetUserListGlobalLicenseResourceNames()
        {
            // Snippet: GetUserListGlobalLicense(UserListGlobalLicenseName, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserListGlobalLicenseName name = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]");
            // Make the request
            UserListGlobalLicense response = userListGlobalLicenseServiceClient.GetUserListGlobalLicense(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListGlobalLicenseAsync</summary>
        public async Task GetUserListGlobalLicenseResourceNamesAsync()
        {
            // Snippet: GetUserListGlobalLicenseAsync(UserListGlobalLicenseName, CallSettings)
            // Additional: GetUserListGlobalLicenseAsync(UserListGlobalLicenseName, CancellationToken)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListGlobalLicenseName name = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]");
            // Make the request
            UserListGlobalLicense response = await userListGlobalLicenseServiceClient.GetUserListGlobalLicenseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenses</summary>
        public void ListUserListGlobalLicensesRequestObject()
        {
            // Snippet: ListUserListGlobalLicenses(ListUserListGlobalLicensesRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicensesAsync</summary>
        public async Task ListUserListGlobalLicensesRequestObjectAsync()
        {
            // Snippet: ListUserListGlobalLicensesAsync(ListUserListGlobalLicensesRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserListGlobalLicensesRequest request = new ListUserListGlobalLicensesRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicensesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenses</summary>
        public void ListUserListGlobalLicenses()
        {
            // Snippet: ListUserListGlobalLicenses(string, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicensesAsync</summary>
        public async Task ListUserListGlobalLicensesAsync()
        {
            // Snippet: ListUserListGlobalLicensesAsync(string, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenses</summary>
        public void ListUserListGlobalLicensesResourceNames()
        {
            // Snippet: ListUserListGlobalLicenses(AccountName, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicensesAsync</summary>
        public async Task ListUserListGlobalLicensesResourceNamesAsync()
        {
            // Snippet: ListUserListGlobalLicensesAsync(AccountName, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicensesResponse, UserListGlobalLicense> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfos</summary>
        public void ListUserListGlobalLicenseCustomerInfosRequestObject()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfos(ListUserListGlobalLicenseCustomerInfosRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
            {
                ParentAsUserListGlobalLicenseName = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfos(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfosAsync</summary>
        public async Task ListUserListGlobalLicenseCustomerInfosRequestObjectAsync()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfosAsync(ListUserListGlobalLicenseCustomerInfosRequest, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserListGlobalLicenseCustomerInfosRequest request = new ListUserListGlobalLicenseCustomerInfosRequest
            {
                ParentAsUserListGlobalLicenseName = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfosAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfos</summary>
        public void ListUserListGlobalLicenseCustomerInfos()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfos(string, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListGlobalLicenses/[USER_LIST_GLOBAL_LICENSE]";
            // Make the request
            PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfos(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfosAsync</summary>
        public async Task ListUserListGlobalLicenseCustomerInfosAsync()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfosAsync(string, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListGlobalLicenses/[USER_LIST_GLOBAL_LICENSE]";
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfosAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfos</summary>
        public void ListUserListGlobalLicenseCustomerInfosResourceNames()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfos(UserListGlobalLicenseName, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = UserListGlobalLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserListGlobalLicenseName parent = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]");
            // Make the request
            PagedEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfos(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListGlobalLicenseCustomerInfosAsync</summary>
        public async Task ListUserListGlobalLicenseCustomerInfosResourceNamesAsync()
        {
            // Snippet: ListUserListGlobalLicenseCustomerInfosAsync(UserListGlobalLicenseName, string, int?, CallSettings)
            // Create client
            UserListGlobalLicenseServiceClient userListGlobalLicenseServiceClient = await UserListGlobalLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListGlobalLicenseName parent = UserListGlobalLicenseName.FromAccountTypeAccountUserListGlobalLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_GLOBAL_LICENSE]");
            // Make the request
            PagedAsyncEnumerable<ListUserListGlobalLicenseCustomerInfosResponse, UserListGlobalLicenseCustomerInfo> response = userListGlobalLicenseServiceClient.ListUserListGlobalLicenseCustomerInfosAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListGlobalLicenseCustomerInfo item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListGlobalLicenseCustomerInfosResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListGlobalLicenseCustomerInfo item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListGlobalLicenseCustomerInfo> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListGlobalLicenseCustomerInfo item in singlePage)
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
