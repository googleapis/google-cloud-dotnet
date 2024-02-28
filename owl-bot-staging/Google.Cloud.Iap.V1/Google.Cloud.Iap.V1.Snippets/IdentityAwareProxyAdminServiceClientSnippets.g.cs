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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.Iap.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIdentityAwareProxyAdminServiceClientSnippets
    {
        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = identityAwareProxyAdminServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await identityAwareProxyAdminServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = identityAwareProxyAdminServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await identityAwareProxyAdminServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = identityAwareProxyAdminServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await identityAwareProxyAdminServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIapSettings</summary>
        public void GetIapSettingsRequestObject()
        {
            // Snippet: GetIapSettings(GetIapSettingsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            GetIapSettingsRequest request = new GetIapSettingsRequest { Name = "", };
            // Make the request
            IapSettings response = identityAwareProxyAdminServiceClient.GetIapSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetIapSettingsAsync</summary>
        public async Task GetIapSettingsRequestObjectAsync()
        {
            // Snippet: GetIapSettingsAsync(GetIapSettingsRequest, CallSettings)
            // Additional: GetIapSettingsAsync(GetIapSettingsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIapSettingsRequest request = new GetIapSettingsRequest { Name = "", };
            // Make the request
            IapSettings response = await identityAwareProxyAdminServiceClient.GetIapSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIapSettings</summary>
        public void UpdateIapSettingsRequestObject()
        {
            // Snippet: UpdateIapSettings(UpdateIapSettingsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IapSettings response = identityAwareProxyAdminServiceClient.UpdateIapSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIapSettingsAsync</summary>
        public async Task UpdateIapSettingsRequestObjectAsync()
        {
            // Snippet: UpdateIapSettingsAsync(UpdateIapSettingsRequest, CallSettings)
            // Additional: UpdateIapSettingsAsync(UpdateIapSettingsRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIapSettingsRequest request = new UpdateIapSettingsRequest
            {
                IapSettings = new IapSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IapSettings response = await identityAwareProxyAdminServiceClient.UpdateIapSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroups</summary>
        public void ListTunnelDestGroupsRequestObject()
        {
            // Snippet: ListTunnelDestGroups(ListTunnelDestGroupsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            ListTunnelDestGroupsRequest request = new ListTunnelDestGroupsRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TunnelDestGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTunnelDestGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroupsAsync</summary>
        public async Task ListTunnelDestGroupsRequestObjectAsync()
        {
            // Snippet: ListTunnelDestGroupsAsync(ListTunnelDestGroupsRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTunnelDestGroupsRequest request = new ListTunnelDestGroupsRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TunnelDestGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTunnelDestGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroups</summary>
        public void ListTunnelDestGroups()
        {
            // Snippet: ListTunnelDestGroups(string, string, int?, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TunnelDestGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTunnelDestGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroupsAsync</summary>
        public async Task ListTunnelDestGroupsAsync()
        {
            // Snippet: ListTunnelDestGroupsAsync(string, string, int?, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TunnelDestGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTunnelDestGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroups</summary>
        public void ListTunnelDestGroupsResourceNames()
        {
            // Snippet: ListTunnelDestGroups(TunnelLocationName, string, int?, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TunnelLocationName parent = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TunnelDestGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTunnelDestGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTunnelDestGroupsAsync</summary>
        public async Task ListTunnelDestGroupsResourceNamesAsync()
        {
            // Snippet: ListTunnelDestGroupsAsync(TunnelLocationName, string, int?, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TunnelLocationName parent = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTunnelDestGroupsResponse, TunnelDestGroup> response = identityAwareProxyAdminServiceClient.ListTunnelDestGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TunnelDestGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTunnelDestGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TunnelDestGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TunnelDestGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TunnelDestGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroup</summary>
        public void CreateTunnelDestGroupRequestObject()
        {
            // Snippet: CreateTunnelDestGroup(CreateTunnelDestGroupRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "",
            };
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.CreateTunnelDestGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroupAsync</summary>
        public async Task CreateTunnelDestGroupRequestObjectAsync()
        {
            // Snippet: CreateTunnelDestGroupAsync(CreateTunnelDestGroupRequest, CallSettings)
            // Additional: CreateTunnelDestGroupAsync(CreateTunnelDestGroupRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTunnelDestGroupRequest request = new CreateTunnelDestGroupRequest
            {
                ParentAsTunnelLocationName = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TunnelDestGroup = new TunnelDestGroup(),
                TunnelDestGroupId = "",
            };
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.CreateTunnelDestGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroup</summary>
        public void CreateTunnelDestGroup()
        {
            // Snippet: CreateTunnelDestGroup(string, TunnelDestGroup, string, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]";
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            string tunnelDestGroupId = "";
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.CreateTunnelDestGroup(parent, tunnelDestGroup, tunnelDestGroupId);
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroupAsync</summary>
        public async Task CreateTunnelDestGroupAsync()
        {
            // Snippet: CreateTunnelDestGroupAsync(string, TunnelDestGroup, string, CallSettings)
            // Additional: CreateTunnelDestGroupAsync(string, TunnelDestGroup, string, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]";
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            string tunnelDestGroupId = "";
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.CreateTunnelDestGroupAsync(parent, tunnelDestGroup, tunnelDestGroupId);
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroup</summary>
        public void CreateTunnelDestGroupResourceNames()
        {
            // Snippet: CreateTunnelDestGroup(TunnelLocationName, TunnelDestGroup, string, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TunnelLocationName parent = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            string tunnelDestGroupId = "";
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.CreateTunnelDestGroup(parent, tunnelDestGroup, tunnelDestGroupId);
            // End snippet
        }

        /// <summary>Snippet for CreateTunnelDestGroupAsync</summary>
        public async Task CreateTunnelDestGroupResourceNamesAsync()
        {
            // Snippet: CreateTunnelDestGroupAsync(TunnelLocationName, TunnelDestGroup, string, CallSettings)
            // Additional: CreateTunnelDestGroupAsync(TunnelLocationName, TunnelDestGroup, string, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TunnelLocationName parent = TunnelLocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            string tunnelDestGroupId = "";
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.CreateTunnelDestGroupAsync(parent, tunnelDestGroup, tunnelDestGroupId);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroup</summary>
        public void GetTunnelDestGroupRequestObject()
        {
            // Snippet: GetTunnelDestGroup(GetTunnelDestGroupRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.GetTunnelDestGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroupAsync</summary>
        public async Task GetTunnelDestGroupRequestObjectAsync()
        {
            // Snippet: GetTunnelDestGroupAsync(GetTunnelDestGroupRequest, CallSettings)
            // Additional: GetTunnelDestGroupAsync(GetTunnelDestGroupRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTunnelDestGroupRequest request = new GetTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.GetTunnelDestGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroup</summary>
        public void GetTunnelDestGroup()
        {
            // Snippet: GetTunnelDestGroup(string, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]/destGroups/[DEST_GROUP]";
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.GetTunnelDestGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroupAsync</summary>
        public async Task GetTunnelDestGroupAsync()
        {
            // Snippet: GetTunnelDestGroupAsync(string, CallSettings)
            // Additional: GetTunnelDestGroupAsync(string, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]/destGroups/[DEST_GROUP]";
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.GetTunnelDestGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroup</summary>
        public void GetTunnelDestGroupResourceNames()
        {
            // Snippet: GetTunnelDestGroup(TunnelDestGroupName, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TunnelDestGroupName name = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]");
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.GetTunnelDestGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetTunnelDestGroupAsync</summary>
        public async Task GetTunnelDestGroupResourceNamesAsync()
        {
            // Snippet: GetTunnelDestGroupAsync(TunnelDestGroupName, CallSettings)
            // Additional: GetTunnelDestGroupAsync(TunnelDestGroupName, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TunnelDestGroupName name = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]");
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.GetTunnelDestGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroup</summary>
        public void DeleteTunnelDestGroupRequestObject()
        {
            // Snippet: DeleteTunnelDestGroup(DeleteTunnelDestGroupRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            // Make the request
            identityAwareProxyAdminServiceClient.DeleteTunnelDestGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroupAsync</summary>
        public async Task DeleteTunnelDestGroupRequestObjectAsync()
        {
            // Snippet: DeleteTunnelDestGroupAsync(DeleteTunnelDestGroupRequest, CallSettings)
            // Additional: DeleteTunnelDestGroupAsync(DeleteTunnelDestGroupRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTunnelDestGroupRequest request = new DeleteTunnelDestGroupRequest
            {
                TunnelDestGroupName = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]"),
            };
            // Make the request
            await identityAwareProxyAdminServiceClient.DeleteTunnelDestGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroup</summary>
        public void DeleteTunnelDestGroup()
        {
            // Snippet: DeleteTunnelDestGroup(string, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]/destGroups/[DEST_GROUP]";
            // Make the request
            identityAwareProxyAdminServiceClient.DeleteTunnelDestGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroupAsync</summary>
        public async Task DeleteTunnelDestGroupAsync()
        {
            // Snippet: DeleteTunnelDestGroupAsync(string, CallSettings)
            // Additional: DeleteTunnelDestGroupAsync(string, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/iap_tunnel/locations/[LOCATION]/destGroups/[DEST_GROUP]";
            // Make the request
            await identityAwareProxyAdminServiceClient.DeleteTunnelDestGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroup</summary>
        public void DeleteTunnelDestGroupResourceNames()
        {
            // Snippet: DeleteTunnelDestGroup(TunnelDestGroupName, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TunnelDestGroupName name = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]");
            // Make the request
            identityAwareProxyAdminServiceClient.DeleteTunnelDestGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTunnelDestGroupAsync</summary>
        public async Task DeleteTunnelDestGroupResourceNamesAsync()
        {
            // Snippet: DeleteTunnelDestGroupAsync(TunnelDestGroupName, CallSettings)
            // Additional: DeleteTunnelDestGroupAsync(TunnelDestGroupName, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TunnelDestGroupName name = TunnelDestGroupName.FromProjectLocationDestGroup("[PROJECT]", "[LOCATION]", "[DEST_GROUP]");
            // Make the request
            await identityAwareProxyAdminServiceClient.DeleteTunnelDestGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTunnelDestGroup</summary>
        public void UpdateTunnelDestGroupRequestObject()
        {
            // Snippet: UpdateTunnelDestGroup(UpdateTunnelDestGroupRequest, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.UpdateTunnelDestGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTunnelDestGroupAsync</summary>
        public async Task UpdateTunnelDestGroupRequestObjectAsync()
        {
            // Snippet: UpdateTunnelDestGroupAsync(UpdateTunnelDestGroupRequest, CallSettings)
            // Additional: UpdateTunnelDestGroupAsync(UpdateTunnelDestGroupRequest, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTunnelDestGroupRequest request = new UpdateTunnelDestGroupRequest
            {
                TunnelDestGroup = new TunnelDestGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.UpdateTunnelDestGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTunnelDestGroup</summary>
        public void UpdateTunnelDestGroup()
        {
            // Snippet: UpdateTunnelDestGroup(TunnelDestGroup, FieldMask, CallSettings)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = IdentityAwareProxyAdminServiceClient.Create();
            // Initialize request argument(s)
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TunnelDestGroup response = identityAwareProxyAdminServiceClient.UpdateTunnelDestGroup(tunnelDestGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTunnelDestGroupAsync</summary>
        public async Task UpdateTunnelDestGroupAsync()
        {
            // Snippet: UpdateTunnelDestGroupAsync(TunnelDestGroup, FieldMask, CallSettings)
            // Additional: UpdateTunnelDestGroupAsync(TunnelDestGroup, FieldMask, CancellationToken)
            // Create client
            IdentityAwareProxyAdminServiceClient identityAwareProxyAdminServiceClient = await IdentityAwareProxyAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            TunnelDestGroup tunnelDestGroup = new TunnelDestGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TunnelDestGroup response = await identityAwareProxyAdminServiceClient.UpdateTunnelDestGroupAsync(tunnelDestGroup, updateMask);
            // End snippet
        }
    }
}
