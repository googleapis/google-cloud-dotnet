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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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
                UserName = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]"),
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
                UserName = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]"),
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
            string name = "networks/[NETWORK_CODE]/users/[USER]";
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
            string name = "networks/[NETWORK_CODE]/users/[USER]";
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
            UserName name = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]");
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
            UserName name = UserName.FromNetworkCodeUser("[NETWORK_CODE]", "[USER]");
            // Make the request
            User response = await userServiceClient.GetUserAsync(name);
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
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
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
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
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
            string parent = "networks/[NETWORK_CODE]";
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
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
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
            // Snippet: ListUsers(NetworkName, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
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
            // Snippet: ListUsersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = userServiceClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserRequestObject()
        {
            // Snippet: CreateUser(CreateUserRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
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
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
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
            string parent = "networks/[NETWORK_CODE]";
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
            string parent = "networks/[NETWORK_CODE]";
            User user = new User();
            // Make the request
            User response = await userServiceClient.CreateUserAsync(parent, user);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserResourceNames()
        {
            // Snippet: CreateUser(NetworkName, User, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            User user = new User();
            // Make the request
            User response = userServiceClient.CreateUser(parent, user);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserResourceNamesAsync()
        {
            // Snippet: CreateUserAsync(NetworkName, User, CallSettings)
            // Additional: CreateUserAsync(NetworkName, User, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            User user = new User();
            // Make the request
            User response = await userServiceClient.CreateUserAsync(parent, user);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsers</summary>
        public void BatchCreateUsersRequestObject()
        {
            // Snippet: BatchCreateUsers(BatchCreateUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateUsersRequest request = new BatchCreateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateUserRequest(),
                },
            };
            // Make the request
            BatchCreateUsersResponse response = userServiceClient.BatchCreateUsers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsersAsync</summary>
        public async Task BatchCreateUsersRequestObjectAsync()
        {
            // Snippet: BatchCreateUsersAsync(BatchCreateUsersRequest, CallSettings)
            // Additional: BatchCreateUsersAsync(BatchCreateUsersRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateUsersRequest request = new BatchCreateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateUserRequest(),
                },
            };
            // Make the request
            BatchCreateUsersResponse response = await userServiceClient.BatchCreateUsersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsers</summary>
        public void BatchCreateUsers()
        {
            // Snippet: BatchCreateUsers(string, IEnumerable<CreateUserRequest>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateUserRequest> requests = new CreateUserRequest[]
            {
                new CreateUserRequest(),
            };
            // Make the request
            BatchCreateUsersResponse response = userServiceClient.BatchCreateUsers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsersAsync</summary>
        public async Task BatchCreateUsersAsync()
        {
            // Snippet: BatchCreateUsersAsync(string, IEnumerable<CreateUserRequest>, CallSettings)
            // Additional: BatchCreateUsersAsync(string, IEnumerable<CreateUserRequest>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateUserRequest> requests = new CreateUserRequest[]
            {
                new CreateUserRequest(),
            };
            // Make the request
            BatchCreateUsersResponse response = await userServiceClient.BatchCreateUsersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsers</summary>
        public void BatchCreateUsersResourceNames()
        {
            // Snippet: BatchCreateUsers(NetworkName, IEnumerable<CreateUserRequest>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateUserRequest> requests = new CreateUserRequest[]
            {
                new CreateUserRequest(),
            };
            // Make the request
            BatchCreateUsersResponse response = userServiceClient.BatchCreateUsers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUsersAsync</summary>
        public async Task BatchCreateUsersResourceNamesAsync()
        {
            // Snippet: BatchCreateUsersAsync(NetworkName, IEnumerable<CreateUserRequest>, CallSettings)
            // Additional: BatchCreateUsersAsync(NetworkName, IEnumerable<CreateUserRequest>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateUserRequest> requests = new CreateUserRequest[]
            {
                new CreateUserRequest(),
            };
            // Make the request
            BatchCreateUsersResponse response = await userServiceClient.BatchCreateUsersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsers</summary>
        public void BatchActivateUsersRequestObject()
        {
            // Snippet: BatchActivateUsers(BatchActivateUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateUsersRequest request = new BatchActivateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchActivateUsersResponse response = userServiceClient.BatchActivateUsers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsersAsync</summary>
        public async Task BatchActivateUsersRequestObjectAsync()
        {
            // Snippet: BatchActivateUsersAsync(BatchActivateUsersRequest, CallSettings)
            // Additional: BatchActivateUsersAsync(BatchActivateUsersRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateUsersRequest request = new BatchActivateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchActivateUsersResponse response = await userServiceClient.BatchActivateUsersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsers</summary>
        public void BatchActivateUsers()
        {
            // Snippet: BatchActivateUsers(string, IEnumerable<string>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateUsersResponse response = userServiceClient.BatchActivateUsers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsersAsync</summary>
        public async Task BatchActivateUsersAsync()
        {
            // Snippet: BatchActivateUsersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateUsersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateUsersResponse response = await userServiceClient.BatchActivateUsersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsers</summary>
        public void BatchActivateUsersResourceNames()
        {
            // Snippet: BatchActivateUsers(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateUsersResponse response = userServiceClient.BatchActivateUsers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateUsersAsync</summary>
        public async Task BatchActivateUsersResourceNamesAsync()
        {
            // Snippet: BatchActivateUsersAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateUsersAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchActivateUsersResponse response = await userServiceClient.BatchActivateUsersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsers</summary>
        public void BatchDeactivateUsersRequestObject()
        {
            // Snippet: BatchDeactivateUsers(BatchDeactivateUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateUsersRequest request = new BatchDeactivateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateUsersResponse response = userServiceClient.BatchDeactivateUsers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsersAsync</summary>
        public async Task BatchDeactivateUsersRequestObjectAsync()
        {
            // Snippet: BatchDeactivateUsersAsync(BatchDeactivateUsersRequest, CallSettings)
            // Additional: BatchDeactivateUsersAsync(BatchDeactivateUsersRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateUsersRequest request = new BatchDeactivateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Names = { "", },
            };
            // Make the request
            BatchDeactivateUsersResponse response = await userServiceClient.BatchDeactivateUsersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsers</summary>
        public void BatchDeactivateUsers()
        {
            // Snippet: BatchDeactivateUsers(string, IEnumerable<string>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateUsersResponse response = userServiceClient.BatchDeactivateUsers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsersAsync</summary>
        public async Task BatchDeactivateUsersAsync()
        {
            // Snippet: BatchDeactivateUsersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateUsersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateUsersResponse response = await userServiceClient.BatchDeactivateUsersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsers</summary>
        public void BatchDeactivateUsersResourceNames()
        {
            // Snippet: BatchDeactivateUsers(NetworkName, IEnumerable<string>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateUsersResponse response = userServiceClient.BatchDeactivateUsers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateUsersAsync</summary>
        public async Task BatchDeactivateUsersResourceNamesAsync()
        {
            // Snippet: BatchDeactivateUsersAsync(NetworkName, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateUsersAsync(NetworkName, IEnumerable<string>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            BatchDeactivateUsersResponse response = await userServiceClient.BatchDeactivateUsersAsync(parent, names);
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

        /// <summary>Snippet for BatchUpdateUsers</summary>
        public void BatchUpdateUsersRequestObject()
        {
            // Snippet: BatchUpdateUsers(BatchUpdateUsersRequest, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateUsersRequest request = new BatchUpdateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateUserRequest(),
                },
            };
            // Make the request
            BatchUpdateUsersResponse response = userServiceClient.BatchUpdateUsers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUsersAsync</summary>
        public async Task BatchUpdateUsersRequestObjectAsync()
        {
            // Snippet: BatchUpdateUsersAsync(BatchUpdateUsersRequest, CallSettings)
            // Additional: BatchUpdateUsersAsync(BatchUpdateUsersRequest, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateUsersRequest request = new BatchUpdateUsersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateUserRequest(),
                },
            };
            // Make the request
            BatchUpdateUsersResponse response = await userServiceClient.BatchUpdateUsersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUsers</summary>
        public void BatchUpdateUsers()
        {
            // Snippet: BatchUpdateUsers(string, IEnumerable<UpdateUserRequest>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateUserRequest> requests = new UpdateUserRequest[]
            {
                new UpdateUserRequest(),
            };
            // Make the request
            BatchUpdateUsersResponse response = userServiceClient.BatchUpdateUsers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUsersAsync</summary>
        public async Task BatchUpdateUsersAsync()
        {
            // Snippet: BatchUpdateUsersAsync(string, IEnumerable<UpdateUserRequest>, CallSettings)
            // Additional: BatchUpdateUsersAsync(string, IEnumerable<UpdateUserRequest>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateUserRequest> requests = new UpdateUserRequest[]
            {
                new UpdateUserRequest(),
            };
            // Make the request
            BatchUpdateUsersResponse response = await userServiceClient.BatchUpdateUsersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUsers</summary>
        public void BatchUpdateUsersResourceNames()
        {
            // Snippet: BatchUpdateUsers(NetworkName, IEnumerable<UpdateUserRequest>, CallSettings)
            // Create client
            UserServiceClient userServiceClient = UserServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateUserRequest> requests = new UpdateUserRequest[]
            {
                new UpdateUserRequest(),
            };
            // Make the request
            BatchUpdateUsersResponse response = userServiceClient.BatchUpdateUsers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUsersAsync</summary>
        public async Task BatchUpdateUsersResourceNamesAsync()
        {
            // Snippet: BatchUpdateUsersAsync(NetworkName, IEnumerable<UpdateUserRequest>, CallSettings)
            // Additional: BatchUpdateUsersAsync(NetworkName, IEnumerable<UpdateUserRequest>, CancellationToken)
            // Create client
            UserServiceClient userServiceClient = await UserServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateUserRequest> requests = new UpdateUserRequest[]
            {
                new UpdateUserRequest(),
            };
            // Make the request
            BatchUpdateUsersResponse response = await userServiceClient.BatchUpdateUsersAsync(parent, requests);
            // End snippet
        }
    }
}
