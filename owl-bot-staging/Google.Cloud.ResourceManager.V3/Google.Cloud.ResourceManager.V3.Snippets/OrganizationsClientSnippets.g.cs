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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ResourceManager.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOrganizationsClientSnippets
    {
        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationRequestObject()
        {
            // Snippet: GetOrganization(GetOrganizationRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            GetOrganizationRequest request = new GetOrganizationRequest
            {
                OrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Organization response = organizationsClient.GetOrganization(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationRequestObjectAsync()
        {
            // Snippet: GetOrganizationAsync(GetOrganizationRequest, CallSettings)
            // Additional: GetOrganizationAsync(GetOrganizationRequest, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationRequest request = new GetOrganizationRequest
            {
                OrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Organization response = await organizationsClient.GetOrganizationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganization()
        {
            // Snippet: GetOrganization(string, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            Organization response = organizationsClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationAsync()
        {
            // Snippet: GetOrganizationAsync(string, CallSettings)
            // Additional: GetOrganizationAsync(string, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]";
            // Make the request
            Organization response = await organizationsClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganization</summary>
        public void GetOrganizationResourceNames()
        {
            // Snippet: GetOrganization(OrganizationName, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Organization response = organizationsClient.GetOrganization(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationAsync</summary>
        public async Task GetOrganizationResourceNamesAsync()
        {
            // Snippet: GetOrganizationAsync(OrganizationName, CallSettings)
            // Additional: GetOrganizationAsync(OrganizationName, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Organization response = await organizationsClient.GetOrganizationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchOrganizations</summary>
        public void SearchOrganizationsRequestObject()
        {
            // Snippet: SearchOrganizations(SearchOrganizationsRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            SearchOrganizationsRequest request = new SearchOrganizationsRequest { Query = "", };
            // Make the request
            PagedEnumerable<SearchOrganizationsResponse, Organization> response = organizationsClient.SearchOrganizations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Organization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchOrganizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchOrganizationsAsync</summary>
        public async Task SearchOrganizationsRequestObjectAsync()
        {
            // Snippet: SearchOrganizationsAsync(SearchOrganizationsRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            SearchOrganizationsRequest request = new SearchOrganizationsRequest { Query = "", };
            // Make the request
            PagedAsyncEnumerable<SearchOrganizationsResponse, Organization> response = organizationsClient.SearchOrganizationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Organization item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchOrganizationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchOrganizations</summary>
        public void SearchOrganizations()
        {
            // Snippet: SearchOrganizations(string, string, int?, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedEnumerable<SearchOrganizationsResponse, Organization> response = organizationsClient.SearchOrganizations(query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Organization item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchOrganizationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchOrganizationsAsync</summary>
        public async Task SearchOrganizationsAsync()
        {
            // Snippet: SearchOrganizationsAsync(string, string, int?, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchOrganizationsResponse, Organization> response = organizationsClient.SearchOrganizationsAsync(query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Organization item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchOrganizationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Organization item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Organization> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Organization item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = organizationsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await organizationsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = organizationsClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await organizationsClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = organizationsClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await organizationsClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = organizationsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await organizationsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = organizationsClient.SetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, CallSettings)
            // Additional: SetIamPolicyAsync(string, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await organizationsClient.SetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = organizationsClient.SetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await organizationsClient.SetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = organizationsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await organizationsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = organizationsClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await organizationsClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationsClient organizationsClient = OrganizationsClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = organizationsClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationsClient organizationsClient = await OrganizationsClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await organizationsClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
