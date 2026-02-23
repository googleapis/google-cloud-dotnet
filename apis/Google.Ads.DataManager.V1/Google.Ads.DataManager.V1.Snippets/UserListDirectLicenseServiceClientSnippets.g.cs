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
    public sealed class AllGeneratedUserListDirectLicenseServiceClientSnippets
    {
        /// <summary>Snippet for CreateUserListDirectLicense</summary>
        public void CreateUserListDirectLicenseRequestObject()
        {
            // Snippet: CreateUserListDirectLicense(CreateUserListDirectLicenseRequest, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            CreateUserListDirectLicenseRequest request = new CreateUserListDirectLicenseRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserListDirectLicense = new UserListDirectLicense(),
            };
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.CreateUserListDirectLicense(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListDirectLicenseAsync</summary>
        public async Task CreateUserListDirectLicenseRequestObjectAsync()
        {
            // Snippet: CreateUserListDirectLicenseAsync(CreateUserListDirectLicenseRequest, CallSettings)
            // Additional: CreateUserListDirectLicenseAsync(CreateUserListDirectLicenseRequest, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserListDirectLicenseRequest request = new CreateUserListDirectLicenseRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserListDirectLicense = new UserListDirectLicense(),
            };
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.CreateUserListDirectLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListDirectLicense</summary>
        public void CreateUserListDirectLicense()
        {
            // Snippet: CreateUserListDirectLicense(string, UserListDirectLicense, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.CreateUserListDirectLicense(parent, userListDirectLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListDirectLicenseAsync</summary>
        public async Task CreateUserListDirectLicenseAsync()
        {
            // Snippet: CreateUserListDirectLicenseAsync(string, UserListDirectLicense, CallSettings)
            // Additional: CreateUserListDirectLicenseAsync(string, UserListDirectLicense, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.CreateUserListDirectLicenseAsync(parent, userListDirectLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListDirectLicense</summary>
        public void CreateUserListDirectLicenseResourceNames()
        {
            // Snippet: CreateUserListDirectLicense(AccountName, UserListDirectLicense, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.CreateUserListDirectLicense(parent, userListDirectLicense);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListDirectLicenseAsync</summary>
        public async Task CreateUserListDirectLicenseResourceNamesAsync()
        {
            // Snippet: CreateUserListDirectLicenseAsync(AccountName, UserListDirectLicense, CallSettings)
            // Additional: CreateUserListDirectLicenseAsync(AccountName, UserListDirectLicense, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.CreateUserListDirectLicenseAsync(parent, userListDirectLicense);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicense</summary>
        public void GetUserListDirectLicenseRequestObject()
        {
            // Snippet: GetUserListDirectLicense(GetUserListDirectLicenseRequest, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            GetUserListDirectLicenseRequest request = new GetUserListDirectLicenseRequest
            {
                UserListDirectLicenseName = UserListDirectLicenseName.FromAccountTypeAccountUserListDirectLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_DIRECT_LICENSE]"),
            };
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.GetUserListDirectLicense(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicenseAsync</summary>
        public async Task GetUserListDirectLicenseRequestObjectAsync()
        {
            // Snippet: GetUserListDirectLicenseAsync(GetUserListDirectLicenseRequest, CallSettings)
            // Additional: GetUserListDirectLicenseAsync(GetUserListDirectLicenseRequest, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserListDirectLicenseRequest request = new GetUserListDirectLicenseRequest
            {
                UserListDirectLicenseName = UserListDirectLicenseName.FromAccountTypeAccountUserListDirectLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_DIRECT_LICENSE]"),
            };
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.GetUserListDirectLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicense</summary>
        public void GetUserListDirectLicense()
        {
            // Snippet: GetUserListDirectLicense(string, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListDirectLicenses/[USER_LIST_DIRECT_LICENSE]";
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.GetUserListDirectLicense(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicenseAsync</summary>
        public async Task GetUserListDirectLicenseAsync()
        {
            // Snippet: GetUserListDirectLicenseAsync(string, CallSettings)
            // Additional: GetUserListDirectLicenseAsync(string, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userListDirectLicenses/[USER_LIST_DIRECT_LICENSE]";
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.GetUserListDirectLicenseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicense</summary>
        public void GetUserListDirectLicenseResourceNames()
        {
            // Snippet: GetUserListDirectLicense(UserListDirectLicenseName, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserListDirectLicenseName name = UserListDirectLicenseName.FromAccountTypeAccountUserListDirectLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_DIRECT_LICENSE]");
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.GetUserListDirectLicense(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListDirectLicenseAsync</summary>
        public async Task GetUserListDirectLicenseResourceNamesAsync()
        {
            // Snippet: GetUserListDirectLicenseAsync(UserListDirectLicenseName, CallSettings)
            // Additional: GetUserListDirectLicenseAsync(UserListDirectLicenseName, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListDirectLicenseName name = UserListDirectLicenseName.FromAccountTypeAccountUserListDirectLicense("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST_DIRECT_LICENSE]");
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.GetUserListDirectLicenseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListDirectLicense</summary>
        public void UpdateUserListDirectLicenseRequestObject()
        {
            // Snippet: UpdateUserListDirectLicense(UpdateUserListDirectLicenseRequest, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserListDirectLicenseRequest request = new UpdateUserListDirectLicenseRequest
            {
                UserListDirectLicense = new UserListDirectLicense(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.UpdateUserListDirectLicense(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListDirectLicenseAsync</summary>
        public async Task UpdateUserListDirectLicenseRequestObjectAsync()
        {
            // Snippet: UpdateUserListDirectLicenseAsync(UpdateUserListDirectLicenseRequest, CallSettings)
            // Additional: UpdateUserListDirectLicenseAsync(UpdateUserListDirectLicenseRequest, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserListDirectLicenseRequest request = new UpdateUserListDirectLicenseRequest
            {
                UserListDirectLicense = new UserListDirectLicense(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.UpdateUserListDirectLicenseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListDirectLicense</summary>
        public void UpdateUserListDirectLicense()
        {
            // Snippet: UpdateUserListDirectLicense(UserListDirectLicense, FieldMask, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserListDirectLicense response = userListDirectLicenseServiceClient.UpdateUserListDirectLicense(userListDirectLicense, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListDirectLicenseAsync</summary>
        public async Task UpdateUserListDirectLicenseAsync()
        {
            // Snippet: UpdateUserListDirectLicenseAsync(UserListDirectLicense, FieldMask, CallSettings)
            // Additional: UpdateUserListDirectLicenseAsync(UserListDirectLicense, FieldMask, CancellationToken)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListDirectLicense userListDirectLicense = new UserListDirectLicense();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserListDirectLicense response = await userListDirectLicenseServiceClient.UpdateUserListDirectLicenseAsync(userListDirectLicense, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicenses</summary>
        public void ListUserListDirectLicensesRequestObject()
        {
            // Snippet: ListUserListDirectLicenses(ListUserListDirectLicensesRequest, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicenses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicensesAsync</summary>
        public async Task ListUserListDirectLicensesRequestObjectAsync()
        {
            // Snippet: ListUserListDirectLicensesAsync(ListUserListDirectLicensesRequest, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserListDirectLicensesRequest request = new ListUserListDirectLicensesRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicensesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicenses</summary>
        public void ListUserListDirectLicenses()
        {
            // Snippet: ListUserListDirectLicenses(string, string, int?, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicensesAsync</summary>
        public async Task ListUserListDirectLicensesAsync()
        {
            // Snippet: ListUserListDirectLicensesAsync(string, string, int?, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicenses</summary>
        public void ListUserListDirectLicensesResourceNames()
        {
            // Snippet: ListUserListDirectLicenses(AccountName, string, int?, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = UserListDirectLicenseServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListDirectLicensesAsync</summary>
        public async Task ListUserListDirectLicensesResourceNamesAsync()
        {
            // Snippet: ListUserListDirectLicensesAsync(AccountName, string, int?, CallSettings)
            // Create client
            UserListDirectLicenseServiceClient userListDirectLicenseServiceClient = await UserListDirectLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListUserListDirectLicensesResponse, UserListDirectLicense> response = userListDirectLicenseServiceClient.ListUserListDirectLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserListDirectLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListDirectLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserListDirectLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserListDirectLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserListDirectLicense item in singlePage)
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
