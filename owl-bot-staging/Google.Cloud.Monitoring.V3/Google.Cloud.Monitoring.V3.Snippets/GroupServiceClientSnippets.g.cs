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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Monitoring.V3;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGroupServiceClientSnippets
    {
        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsRequestObject()
        {
            // Snippet: ListGroups(ListGroupsRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ChildrenOfGroupAsGroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsRequestObjectAsync()
        {
            // Snippet: ListGroupsAsync(ListGroupsRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupsRequest request = new ListGroupsRequest
            {
                ChildrenOfGroupAsGroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroups()
        {
            // Snippet: ListGroups(string, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsAsync()
        {
            // Snippet: ListGroupsAsync(string, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames1()
        {
            // Snippet: ListGroups(ProjectName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNames1Async()
        {
            // Snippet: ListGroupsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames2()
        {
            // Snippet: ListGroups(OrganizationName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNames2Async()
        {
            // Snippet: ListGroupsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames3()
        {
            // Snippet: ListGroups(FolderName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNames3Async()
        {
            // Snippet: ListGroupsAsync(FolderName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroups</summary>
        public void ListGroupsResourceNames4()
        {
            // Snippet: ListGroups(IResourceName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroups(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Group item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupsAsync</summary>
        public async Task ListGroupsResourceNames4Async()
        {
            // Snippet: ListGroupsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListGroupsResponse, Group> response = groupServiceClient.ListGroupsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Group item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Group item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Group> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Group item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupRequestObject()
        {
            // Snippet: GetGroup(GetGroupRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            Group response = groupServiceClient.GetGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupRequestObjectAsync()
        {
            // Snippet: GetGroupAsync(GetGroupRequest, CallSettings)
            // Additional: GetGroupAsync(GetGroupRequest, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            Group response = await groupServiceClient.GetGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroup()
        {
            // Snippet: GetGroup(string, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            Group response = groupServiceClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupAsync()
        {
            // Snippet: GetGroupAsync(string, CallSettings)
            // Additional: GetGroupAsync(string, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            Group response = await groupServiceClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupResourceNames1()
        {
            // Snippet: GetGroup(GroupName, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            Group response = groupServiceClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupResourceNames1Async()
        {
            // Snippet: GetGroupAsync(GroupName, CallSettings)
            // Additional: GetGroupAsync(GroupName, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            Group response = await groupServiceClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroup</summary>
        public void GetGroupResourceNames2()
        {
            // Snippet: GetGroup(IResourceName, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Group response = groupServiceClient.GetGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetGroupAsync</summary>
        public async Task GetGroupResourceNames2Async()
        {
            // Snippet: GetGroupAsync(IResourceName, CallSettings)
            // Additional: GetGroupAsync(IResourceName, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Group response = await groupServiceClient.GetGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupRequestObject()
        {
            // Snippet: CreateGroup(CreateGroupRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = false,
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Group response = groupServiceClient.CreateGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupRequestObjectAsync()
        {
            // Snippet: CreateGroupAsync(CreateGroupRequest, CallSettings)
            // Additional: CreateGroupAsync(CreateGroupRequest, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = false,
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroup()
        {
            // Snippet: CreateGroup(string, Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupAsync()
        {
            // Snippet: CreateGroupAsync(string, Group, CallSettings)
            // Additional: CreateGroupAsync(string, Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames1()
        {
            // Snippet: CreateGroup(ProjectName, Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNames1Async()
        {
            // Snippet: CreateGroupAsync(ProjectName, Group, CallSettings)
            // Additional: CreateGroupAsync(ProjectName, Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames2()
        {
            // Snippet: CreateGroup(OrganizationName, Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNames2Async()
        {
            // Snippet: CreateGroupAsync(OrganizationName, Group, CallSettings)
            // Additional: CreateGroupAsync(OrganizationName, Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames3()
        {
            // Snippet: CreateGroup(FolderName, Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNames3Async()
        {
            // Snippet: CreateGroupAsync(FolderName, Group, CallSettings)
            // Additional: CreateGroupAsync(FolderName, Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroup</summary>
        public void CreateGroupResourceNames4()
        {
            // Snippet: CreateGroup(IResourceName, Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.CreateGroup(name, group);
            // End snippet
        }

        /// <summary>Snippet for CreateGroupAsync</summary>
        public async Task CreateGroupResourceNames4Async()
        {
            // Snippet: CreateGroupAsync(IResourceName, Group, CallSettings)
            // Additional: CreateGroupAsync(IResourceName, Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.CreateGroupAsync(name, group);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroupRequestObject()
        {
            // Snippet: UpdateGroup(UpdateGroupRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = false,
            };
            // Make the request
            Group response = groupServiceClient.UpdateGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupRequestObjectAsync()
        {
            // Snippet: UpdateGroupAsync(UpdateGroupRequest, CallSettings)
            // Additional: UpdateGroupAsync(UpdateGroupRequest, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = false,
            };
            // Make the request
            Group response = await groupServiceClient.UpdateGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroup</summary>
        public void UpdateGroup()
        {
            // Snippet: UpdateGroup(Group, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            Group group = new Group();
            // Make the request
            Group response = groupServiceClient.UpdateGroup(group);
            // End snippet
        }

        /// <summary>Snippet for UpdateGroupAsync</summary>
        public async Task UpdateGroupAsync()
        {
            // Snippet: UpdateGroupAsync(Group, CallSettings)
            // Additional: UpdateGroupAsync(Group, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            Group group = new Group();
            // Make the request
            Group response = await groupServiceClient.UpdateGroupAsync(group);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupRequestObject()
        {
            // Snippet: DeleteGroup(DeleteGroupRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                Recursive = false,
            };
            // Make the request
            groupServiceClient.DeleteGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupRequestObjectAsync()
        {
            // Snippet: DeleteGroupAsync(DeleteGroupRequest, CallSettings)
            // Additional: DeleteGroupAsync(DeleteGroupRequest, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                Recursive = false,
            };
            // Make the request
            await groupServiceClient.DeleteGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroup()
        {
            // Snippet: DeleteGroup(string, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            groupServiceClient.DeleteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupAsync()
        {
            // Snippet: DeleteGroupAsync(string, CallSettings)
            // Additional: DeleteGroupAsync(string, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            await groupServiceClient.DeleteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupResourceNames1()
        {
            // Snippet: DeleteGroup(GroupName, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            groupServiceClient.DeleteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupResourceNames1Async()
        {
            // Snippet: DeleteGroupAsync(GroupName, CallSettings)
            // Additional: DeleteGroupAsync(GroupName, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            await groupServiceClient.DeleteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroup</summary>
        public void DeleteGroupResourceNames2()
        {
            // Snippet: DeleteGroup(IResourceName, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            groupServiceClient.DeleteGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGroupAsync</summary>
        public async Task DeleteGroupResourceNames2Async()
        {
            // Snippet: DeleteGroupAsync(IResourceName, CallSettings)
            // Additional: DeleteGroupAsync(IResourceName, CancellationToken)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await groupServiceClient.DeleteGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembers</summary>
        public void ListGroupMembersRequestObject()
        {
            // Snippet: ListGroupMembers(ListGroupMembersRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                Filter = "",
                Interval = new TimeInterval(),
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            PagedEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembersAsync</summary>
        public async Task ListGroupMembersRequestObjectAsync()
        {
            // Snippet: ListGroupMembersAsync(ListGroupMembersRequest, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupMembersRequest request = new ListGroupMembersRequest
            {
                Filter = "",
                Interval = new TimeInterval(),
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembers</summary>
        public void ListGroupMembers()
        {
            // Snippet: ListGroupMembers(string, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            PagedEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembers(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembersAsync</summary>
        public async Task ListGroupMembersAsync()
        {
            // Snippet: ListGroupMembersAsync(string, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/groups/[GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembersAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembers</summary>
        public void ListGroupMembersResourceNames1()
        {
            // Snippet: ListGroupMembers(GroupName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            PagedEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembers(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembersAsync</summary>
        public async Task ListGroupMembersResourceNames1Async()
        {
            // Snippet: ListGroupMembersAsync(GroupName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GroupName name = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembersAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembers</summary>
        public void ListGroupMembersResourceNames2()
        {
            // Snippet: ListGroupMembers(IResourceName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = GroupServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembers(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupMembersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupMembersAsync</summary>
        public async Task ListGroupMembersResourceNames2Async()
        {
            // Snippet: ListGroupMembersAsync(IResourceName, string, int?, CallSettings)
            // Create client
            GroupServiceClient groupServiceClient = await GroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListGroupMembersResponse, MonitoredResource> response = groupServiceClient.ListGroupMembersAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupMembersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResource item in singlePage)
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
