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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserServiceClientSnippets
    {
        /// <summary>Snippet for GetUser</summary>
        public void GetUserRequestObject()
        {
            // Snippet: GetUser(GetUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            User response = userServiceClient.GetUser(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserRequestObjectAsync()
        {
            // Snippet: GetUserAsync(GetUserRequest, CallSettings)
            // Additional: GetUserAsync(GetUserRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            User response = await userServiceClient.GetUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUser()
        {
            // Snippet: GetUser(string, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]";
            // Make the request
            User response = userServiceClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserAsync()
        {
            // Snippet: GetUserAsync(string, CallSettings)
            // Additional: GetUserAsync(string, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]";
            // Make the request
            User response = await userServiceClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUserResourceNames()
        {
            // Snippet: GetUser(UserName, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            User response = userServiceClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserResourceNamesAsync()
        {
            // Snippet: GetUserAsync(UserName, CallSettings)
            // Additional: GetUserAsync(UserName, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            User response = await userServiceClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserRequestObject()
        {
            // Snippet: CreateUser(CreateUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserId = "",
                User = new User(),
            };
            // Make the request
            User response = userServiceClient.CreateUser(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserRequestObjectAsync()
        {
            // Snippet: CreateUserAsync(CreateUserRequest, CallSettings)
            // Additional: CreateUserAsync(CreateUserRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserId = "",
                User = new User(),
            };
            // Make the request
            User response = await userServiceClient.CreateUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUser()
        {
            // Snippet: CreateUser(string, User, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            User user = new User();
            // Make the request
            User response = userServiceClient.CreateUser(parent, user);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserAsync()
        {
            // Snippet: CreateUserAsync(string, User, CallSettings)
            // Additional: CreateUserAsync(string, User, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            User user = new User();
            // Make the request
            User response = await userServiceClient.CreateUserAsync(parent, user);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserResourceNames()
        {
            // Snippet: CreateUser(AccountName, User, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            User user = new User();
            // Make the request
            User response = userServiceClient.CreateUser(parent, user);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserResourceNamesAsync()
        {
            // Snippet: CreateUserAsync(AccountName, User, CallSettings)
            // Additional: CreateUserAsync(AccountName, User, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            User user = new User();
            // Make the request
            User response = await userServiceClient.CreateUserAsync(parent, user);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserRequestObject()
        {
            // Snippet: DeleteUser(DeleteUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            userServiceClient.DeleteUser(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserRequestObjectAsync()
        {
            // Snippet: DeleteUserAsync(DeleteUserRequest, CallSettings)
            // Additional: DeleteUserAsync(DeleteUserRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]"),
            };
            // Make the request
            await userServiceClient.DeleteUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUser()
        {
            // Snippet: DeleteUser(string, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]";
            // Make the request
            userServiceClient.DeleteUser(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserAsync()
        {
            // Snippet: DeleteUserAsync(string, CallSettings)
            // Additional: DeleteUserAsync(string, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/users/[EMAIL]";
            // Make the request
            await userServiceClient.DeleteUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserResourceNames()
        {
            // Snippet: DeleteUser(UserName, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            userServiceClient.DeleteUser(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserResourceNamesAsync()
        {
            // Snippet: DeleteUserAsync(UserName, CallSettings)
            // Additional: DeleteUserAsync(UserName, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromAccountEmail("[ACCOUNT]", "[EMAIL]");
            // Make the request
            await userServiceClient.DeleteUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUserRequestObject()
        {
            // Snippet: UpdateUser(UpdateUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                User = new User(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            User response = userServiceClient.UpdateUser(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserRequestObjectAsync()
        {
            // Snippet: UpdateUserAsync(UpdateUserRequest, CallSettings)
            // Additional: UpdateUserAsync(UpdateUserRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                User = new User(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            User response = await userServiceClient.UpdateUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUser()
        {
            // Snippet: UpdateUser(User, FieldMask, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            User response = userServiceClient.UpdateUser(user, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserAsync()
        {
            // Snippet: UpdateUserAsync(User, FieldMask, CallSettings)
            // Additional: UpdateUserAsync(User, FieldMask, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            User response = await userServiceClient.UpdateUserAsync(user, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersRequestObject()
        {
            // Snippet: ListUsers(ListUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersRequestObjectAsync()
        {
            // Snippet: ListUsersAsync(ListUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsers()
        {
            // Snippet: ListUsers(string, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersAsync()
        {
            // Snippet: ListUsersAsync(string, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersResourceNames()
        {
            // Snippet: ListUsers(AccountName, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersResourceNamesAsync()
        {
            // Snippet: ListUsersAsync(AccountName, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
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
