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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRoleServiceClientSnippets
    {
        /// <summary>Snippet for GetRole</summary>
        public void GetRoleRequestObject()
        {
            // Snippet: GetRole(GetRoleRequest, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            GetRoleRequest request = new GetRoleRequest
            {
                RoleName = RoleName.FromNetworkCodeRole("[NETWORK_CODE]", "[ROLE]"),
            };
            // Make the request
            Role response = roleServiceClient.GetRole(request);
            // End snippet
        }

        /// <summary>Snippet for GetRoleAsync</summary>
        public async Task GetRoleRequestObjectAsync()
        {
            // Snippet: GetRoleAsync(GetRoleRequest, CallSettings)
            // Additional: GetRoleAsync(GetRoleRequest, CancellationToken)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRoleRequest request = new GetRoleRequest
            {
                RoleName = RoleName.FromNetworkCodeRole("[NETWORK_CODE]", "[ROLE]"),
            };
            // Make the request
            Role response = await roleServiceClient.GetRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRole</summary>
        public void GetRole()
        {
            // Snippet: GetRole(string, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/roles/[ROLE]";
            // Make the request
            Role response = roleServiceClient.GetRole(name);
            // End snippet
        }

        /// <summary>Snippet for GetRoleAsync</summary>
        public async Task GetRoleAsync()
        {
            // Snippet: GetRoleAsync(string, CallSettings)
            // Additional: GetRoleAsync(string, CancellationToken)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/roles/[ROLE]";
            // Make the request
            Role response = await roleServiceClient.GetRoleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRole</summary>
        public void GetRoleResourceNames()
        {
            // Snippet: GetRole(RoleName, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            RoleName name = RoleName.FromNetworkCodeRole("[NETWORK_CODE]", "[ROLE]");
            // Make the request
            Role response = roleServiceClient.GetRole(name);
            // End snippet
        }

        /// <summary>Snippet for GetRoleAsync</summary>
        public async Task GetRoleResourceNamesAsync()
        {
            // Snippet: GetRoleAsync(RoleName, CallSettings)
            // Additional: GetRoleAsync(RoleName, CancellationToken)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RoleName name = RoleName.FromNetworkCodeRole("[NETWORK_CODE]", "[ROLE]");
            // Make the request
            Role response = await roleServiceClient.GetRoleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRoles</summary>
        public void ListRolesRequestObject()
        {
            // Snippet: ListRoles(ListRolesRequest, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            ListRolesRequest request = new ListRolesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRoles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolesAsync</summary>
        public async Task ListRolesRequestObjectAsync()
        {
            // Snippet: ListRolesAsync(ListRolesRequest, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRolesRequest request = new ListRolesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRolesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoles</summary>
        public void ListRoles()
        {
            // Snippet: ListRoles(string, string, int?, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRoles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolesAsync</summary>
        public async Task ListRolesAsync()
        {
            // Snippet: ListRolesAsync(string, string, int?, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRolesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoles</summary>
        public void ListRolesResourceNames()
        {
            // Snippet: ListRoles(NetworkName, string, int?, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = RoleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRoles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolesAsync</summary>
        public async Task ListRolesResourceNamesAsync()
        {
            // Snippet: ListRolesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            RoleServiceClient roleServiceClient = await RoleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListRolesResponse, Role> response = roleServiceClient.ListRolesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
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
