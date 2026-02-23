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
    public sealed class AllGeneratedUserListServiceClientSnippets
    {
        /// <summary>Snippet for GetUserList</summary>
        public void GetUserListRequestObject()
        {
            // Snippet: GetUserList(GetUserListRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            GetUserListRequest request = new GetUserListRequest
            {
                UserListName = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]"),
            };
            // Make the request
            UserList response = userListServiceClient.GetUserList(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListRequestObjectAsync()
        {
            // Snippet: GetUserListAsync(GetUserListRequest, CallSettings)
            // Additional: GetUserListAsync(GetUserListRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserListRequest request = new GetUserListRequest
            {
                UserListName = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]"),
            };
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserList</summary>
        public void GetUserList()
        {
            // Snippet: GetUserList(string, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userLists/[USER_LIST]";
            // Make the request
            UserList response = userListServiceClient.GetUserList(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListAsync()
        {
            // Snippet: GetUserListAsync(string, CallSettings)
            // Additional: GetUserListAsync(string, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userLists/[USER_LIST]";
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserList</summary>
        public void GetUserListResourceNames()
        {
            // Snippet: GetUserList(UserListName, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            UserListName name = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]");
            // Make the request
            UserList response = userListServiceClient.GetUserList(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserListAsync</summary>
        public async Task GetUserListResourceNamesAsync()
        {
            // Snippet: GetUserListAsync(UserListName, CallSettings)
            // Additional: GetUserListAsync(UserListName, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListName name = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]");
            // Make the request
            UserList response = await userListServiceClient.GetUserListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserLists</summary>
        public void ListUserListsRequestObject()
        {
            // Snippet: ListUserLists(ListUserListsRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            ListUserListsRequest request = new ListUserListsRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserLists(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListsAsync</summary>
        public async Task ListUserListsRequestObjectAsync()
        {
            // Snippet: ListUserListsAsync(ListUserListsRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserListsRequest request = new ListUserListsRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserListsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLists</summary>
        public void ListUserLists()
        {
            // Snippet: ListUserLists(string, string, int?, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListsAsync</summary>
        public async Task ListUserListsAsync()
        {
            // Snippet: ListUserListsAsync(string, string, int?, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLists</summary>
        public void ListUserListsResourceNames()
        {
            // Snippet: ListUserLists(AccountName, string, int?, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserListsAsync</summary>
        public async Task ListUserListsResourceNamesAsync()
        {
            // Snippet: ListUserListsAsync(AccountName, string, int?, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListUserListsResponse, UserList> response = userListServiceClient.ListUserListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (UserList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUserListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateUserList</summary>
        public void CreateUserListRequestObject()
        {
            // Snippet: CreateUserList(CreateUserListRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            CreateUserListRequest request = new CreateUserListRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserList = new UserList(),
                ValidateOnly = false,
            };
            // Make the request
            UserList response = userListServiceClient.CreateUserList(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListAsync</summary>
        public async Task CreateUserListRequestObjectAsync()
        {
            // Snippet: CreateUserListAsync(CreateUserListRequest, CallSettings)
            // Additional: CreateUserListAsync(CreateUserListRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserListRequest request = new CreateUserListRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                UserList = new UserList(),
                ValidateOnly = false,
            };
            // Make the request
            UserList response = await userListServiceClient.CreateUserListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserList</summary>
        public void CreateUserList()
        {
            // Snippet: CreateUserList(string, UserList, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserList userList = new UserList();
            // Make the request
            UserList response = userListServiceClient.CreateUserList(parent, userList);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListAsync</summary>
        public async Task CreateUserListAsync()
        {
            // Snippet: CreateUserListAsync(string, UserList, CallSettings)
            // Additional: CreateUserListAsync(string, UserList, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            UserList userList = new UserList();
            // Make the request
            UserList response = await userListServiceClient.CreateUserListAsync(parent, userList);
            // End snippet
        }

        /// <summary>Snippet for CreateUserList</summary>
        public void CreateUserListResourceNames()
        {
            // Snippet: CreateUserList(AccountName, UserList, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserList userList = new UserList();
            // Make the request
            UserList response = userListServiceClient.CreateUserList(parent, userList);
            // End snippet
        }

        /// <summary>Snippet for CreateUserListAsync</summary>
        public async Task CreateUserListResourceNamesAsync()
        {
            // Snippet: CreateUserListAsync(AccountName, UserList, CallSettings)
            // Additional: CreateUserListAsync(AccountName, UserList, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            UserList userList = new UserList();
            // Make the request
            UserList response = await userListServiceClient.CreateUserListAsync(parent, userList);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserList</summary>
        public void UpdateUserListRequestObject()
        {
            // Snippet: UpdateUserList(UpdateUserListRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserListRequest request = new UpdateUserListRequest
            {
                UserList = new UserList(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            UserList response = userListServiceClient.UpdateUserList(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListAsync</summary>
        public async Task UpdateUserListRequestObjectAsync()
        {
            // Snippet: UpdateUserListAsync(UpdateUserListRequest, CallSettings)
            // Additional: UpdateUserListAsync(UpdateUserListRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserListRequest request = new UpdateUserListRequest
            {
                UserList = new UserList(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
            };
            // Make the request
            UserList response = await userListServiceClient.UpdateUserListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserList</summary>
        public void UpdateUserList()
        {
            // Snippet: UpdateUserList(UserList, FieldMask, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            UserList userList = new UserList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserList response = userListServiceClient.UpdateUserList(userList, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserListAsync</summary>
        public async Task UpdateUserListAsync()
        {
            // Snippet: UpdateUserListAsync(UserList, FieldMask, CallSettings)
            // Additional: UpdateUserListAsync(UserList, FieldMask, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserList userList = new UserList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            UserList response = await userListServiceClient.UpdateUserListAsync(userList, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserList</summary>
        public void DeleteUserListRequestObject()
        {
            // Snippet: DeleteUserList(DeleteUserListRequest, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            DeleteUserListRequest request = new DeleteUserListRequest
            {
                UserListName = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]"),
                ValidateOnly = false,
            };
            // Make the request
            userListServiceClient.DeleteUserList(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserListAsync</summary>
        public async Task DeleteUserListRequestObjectAsync()
        {
            // Snippet: DeleteUserListAsync(DeleteUserListRequest, CallSettings)
            // Additional: DeleteUserListAsync(DeleteUserListRequest, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserListRequest request = new DeleteUserListRequest
            {
                UserListName = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]"),
                ValidateOnly = false,
            };
            // Make the request
            await userListServiceClient.DeleteUserListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserList</summary>
        public void DeleteUserList()
        {
            // Snippet: DeleteUserList(string, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userLists/[USER_LIST]";
            // Make the request
            userListServiceClient.DeleteUserList(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserListAsync</summary>
        public async Task DeleteUserListAsync()
        {
            // Snippet: DeleteUserListAsync(string, CallSettings)
            // Additional: DeleteUserListAsync(string, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/userLists/[USER_LIST]";
            // Make the request
            await userListServiceClient.DeleteUserListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserList</summary>
        public void DeleteUserListResourceNames()
        {
            // Snippet: DeleteUserList(UserListName, CallSettings)
            // Create client
            UserListServiceClient userListServiceClient = UserListServiceClient.Create();
            // Initialize request argument(s)
            UserListName name = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]");
            // Make the request
            userListServiceClient.DeleteUserList(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserListAsync</summary>
        public async Task DeleteUserListResourceNamesAsync()
        {
            // Snippet: DeleteUserListAsync(UserListName, CallSettings)
            // Additional: DeleteUserListAsync(UserListName, CancellationToken)
            // Create client
            UserListServiceClient userListServiceClient = await UserListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserListName name = UserListName.FromAccountTypeAccountUserList("[ACCOUNT_TYPE]", "[ACCOUNT]", "[USER_LIST]");
            // Make the request
            await userListServiceClient.DeleteUserListAsync(name);
            // End snippet
        }
    }
}
