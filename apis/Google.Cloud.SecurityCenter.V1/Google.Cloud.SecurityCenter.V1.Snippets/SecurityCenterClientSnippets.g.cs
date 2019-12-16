// Copyright 2019 Google LLC
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

namespace Google.Cloud.SecurityCenter.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSecurityCenterClientSnippets
    {
        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource_RequestObject()
        {
            // Snippet: CreateSource(CreateSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            // Make the request
            Source response = securityCenterClient.CreateSource(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync_RequestObject()
        {
            // Snippet: CreateSourceAsync(CreateSourceRequest, CallSettings)
            // Additional: CreateSourceAsync(CreateSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateSourceRequest request = new CreateSourceRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Source = new Source(),
            };
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource()
        {
            // Snippet: CreateSource(string, Source, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Source source = new Source();
            // Make the request
            Source response = securityCenterClient.CreateSource(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync()
        {
            // Snippet: CreateSourceAsync(string, Source, CallSettings)
            // Additional: CreateSourceAsync(string, Source, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            Source source = new Source();
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSource</summary>
        public void CreateSource_ResourceNames()
        {
            // Snippet: CreateSource(OrganizationName, Source, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Source source = new Source();
            // Make the request
            Source response = securityCenterClient.CreateSource(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateSourceAsync</summary>
        public async Task CreateSourceAsync_ResourceNames()
        {
            // Snippet: CreateSourceAsync(OrganizationName, Source, CallSettings)
            // Additional: CreateSourceAsync(OrganizationName, Source, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Source source = new Source();
            // Make the request
            Source response = await securityCenterClient.CreateSourceAsync(parent, source);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFinding_RequestObject()
        {
            // Snippet: CreateFinding(CreateFindingRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "",
                Finding = new Finding(),
            };
            // Make the request
            Finding response = securityCenterClient.CreateFinding(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingAsync_RequestObject()
        {
            // Snippet: CreateFindingAsync(CreateFindingRequest, CallSettings)
            // Additional: CreateFindingAsync(CreateFindingRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            CreateFindingRequest request = new CreateFindingRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                FindingId = "",
                Finding = new Finding(),
            };
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFinding()
        {
            // Snippet: CreateFinding(string, string, Finding, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string findingId = "";
            Finding finding = new Finding();
            // Make the request
            Finding response = securityCenterClient.CreateFinding(parent, findingId, finding);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingAsync()
        {
            // Snippet: CreateFindingAsync(string, string, Finding, CallSettings)
            // Additional: CreateFindingAsync(string, string, Finding, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string findingId = "";
            Finding finding = new Finding();
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(parent, findingId, finding);
            // End snippet
        }

        /// <summary>Snippet for CreateFinding</summary>
        public void CreateFinding_ResourceNames()
        {
            // Snippet: CreateFinding(SourceName, string, Finding, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string findingId = "";
            Finding finding = new Finding();
            // Make the request
            Finding response = securityCenterClient.CreateFinding(parent, findingId, finding);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingAsync</summary>
        public async Task CreateFindingAsync_ResourceNames()
        {
            // Snippet: CreateFindingAsync(SourceName, string, Finding, CallSettings)
            // Additional: CreateFindingAsync(SourceName, string, Finding, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string findingId = "";
            Finding finding = new Finding();
            // Make the request
            Finding response = await securityCenterClient.CreateFindingAsync(parent, findingId, finding);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_ResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = securityCenterClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_ResourceNames()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await securityCenterClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettings</summary>
        public void GetOrganizationSettings_RequestObject()
        {
            // Snippet: GetOrganizationSettings(GetOrganizationSettingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            OrganizationSettings response = securityCenterClient.GetOrganizationSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettingsAsync</summary>
        public async Task GetOrganizationSettingsAsync_RequestObject()
        {
            // Snippet: GetOrganizationSettingsAsync(GetOrganizationSettingsRequest, CallSettings)
            // Additional: GetOrganizationSettingsAsync(GetOrganizationSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationSettingsRequest request = new GetOrganizationSettingsRequest
            {
                OrganizationSettingsName = OrganizationSettingsName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            OrganizationSettings response = await securityCenterClient.GetOrganizationSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettings</summary>
        public void GetOrganizationSettings()
        {
            // Snippet: GetOrganizationSettings(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/organizationSettings";
            // Make the request
            OrganizationSettings response = securityCenterClient.GetOrganizationSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettingsAsync</summary>
        public async Task GetOrganizationSettingsAsync()
        {
            // Snippet: GetOrganizationSettingsAsync(string, CallSettings)
            // Additional: GetOrganizationSettingsAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/organizationSettings";
            // Make the request
            OrganizationSettings response = await securityCenterClient.GetOrganizationSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettings</summary>
        public void GetOrganizationSettings_ResourceNames()
        {
            // Snippet: GetOrganizationSettings(OrganizationSettingsName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationSettingsName name = OrganizationSettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            OrganizationSettings response = securityCenterClient.GetOrganizationSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrganizationSettingsAsync</summary>
        public async Task GetOrganizationSettingsAsync_ResourceNames()
        {
            // Snippet: GetOrganizationSettingsAsync(OrganizationSettingsName, CallSettings)
            // Additional: GetOrganizationSettingsAsync(OrganizationSettingsName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationSettingsName name = OrganizationSettingsName.FromOrganization("[ORGANIZATION]");
            // Make the request
            OrganizationSettings response = await securityCenterClient.GetOrganizationSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource_RequestObject()
        {
            // Snippet: GetSource(GetSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = securityCenterClient.GetSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync_RequestObject()
        {
            // Snippet: GetSourceAsync(GetSourceRequest, CallSettings)
            // Additional: GetSourceAsync(GetSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GetSourceRequest request = new GetSourceRequest
            {
                SourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
            };
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource()
        {
            // Snippet: GetSource(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            Source response = securityCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync()
        {
            // Snippet: GetSourceAsync(string, CallSettings)
            // Additional: GetSourceAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSource</summary>
        public void GetSource_ResourceNames()
        {
            // Snippet: GetSource(SourceName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName name = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            Source response = securityCenterClient.GetSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetSourceAsync</summary>
        public async Task GetSourceAsync_ResourceNames()
        {
            // Snippet: GetSourceAsync(SourceName, CallSettings)
            // Additional: GetSourceAsync(SourceName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName name = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            // Make the request
            Source response = await securityCenterClient.GetSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GroupAssets</summary>
        public void GroupAssets_RequestObject()
        {
            // Snippet: GroupAssets(GroupAssetsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GroupAssetsRequest request = new GroupAssetsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                GroupBy = "",
                CompareDuration = new Duration(),
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<GroupAssetsResponse, GroupResult> response = securityCenterClient.GroupAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupAssets</summary>
        public async Task GroupAssetsAsync_RequestObject()
        {
            // Snippet: GroupAssetsAsync(GroupAssetsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupAssetsRequest request = new GroupAssetsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                GroupBy = "",
                CompareDuration = new Duration(),
                ReadTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<GroupAssetsResponse, GroupResult> response = securityCenterClient.GroupAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindings_RequestObject()
        {
            // Snippet: GroupFindings(GroupFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                GroupBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
            };
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public async Task GroupFindingsAsync_RequestObject()
        {
            // Snippet: GroupFindingsAsync(GroupFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                GroupBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
            };
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindings()
        {
            // Snippet: GroupFindings(string, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string groupBy = "";
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public async Task GroupFindingsAsync()
        {
            // Snippet: GroupFindingsAsync(string, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/sources/[SOURCE]";
            string groupBy = "";
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public void GroupFindings_ResourceNames()
        {
            // Snippet: GroupFindings(SourceName, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string groupBy = "";
            // Make the request
            PagedEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindings(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GroupResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GroupFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GroupFindings</summary>
        public async Task GroupFindingsAsync_ResourceNames()
        {
            // Snippet: GroupFindingsAsync(SourceName, string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]");
            string groupBy = "";
            // Make the request
            PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> response = securityCenterClient.GroupFindingsAsync(parent, groupBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GroupResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((GroupFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GroupResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GroupResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GroupResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssets_RequestObject()
        {
            // Snippet: ListAssets(ListAssetsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                OrderBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> response = securityCenterClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListAssetsResponse.Types.ListAssetsResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAssetsResponse.Types.ListAssetsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAssetsResponse.Types.ListAssetsResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAssetsResponse.Types.ListAssetsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public async Task ListAssetsAsync_RequestObject()
        {
            // Snippet: ListAssetsAsync(ListAssetsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
                Filter = "",
                OrderBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, ListAssetsResponse.Types.ListAssetsResult> response = securityCenterClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListAssetsResponse.Types.ListAssetsResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAssetsResponse.Types.ListAssetsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAssetsResponse.Types.ListAssetsResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAssetsResponse.Types.ListAssetsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public void ListFindings_RequestObject()
        {
            // Snippet: ListFindings(ListFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListFindingsResponse.Types.ListFindingsResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindings</summary>
        public async Task ListFindingsAsync_RequestObject()
        {
            // Snippet: ListFindingsAsync(ListFindingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = SourceName.FromOrganizationSource("[ORGANIZATION]", "[SOURCE]"),
                Filter = "",
                OrderBy = "",
                ReadTime = new Timestamp(),
                CompareDuration = new Duration(),
                FieldMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> response = securityCenterClient.ListFindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ListFindingsResponse.Types.ListFindingsResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListFindingsResponse.Types.ListFindingsResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListFindingsResponse.Types.ListFindingsResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListFindingsResponse.Types.ListFindingsResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources_RequestObject()
        {
            // Snippet: ListSources(ListSourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public async Task ListSourcesAsync_RequestObject()
        {
            // Snippet: ListSourcesAsync(ListSourcesRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources()
        {
            // Snippet: ListSources(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public async Task ListSourcesAsync()
        {
            // Snippet: ListSourcesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public void ListSources_ResourceNames()
        {
            // Snippet: ListSources(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Source item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSources</summary>
        public async Task ListSourcesAsync_ResourceNames()
        {
            // Snippet: ListSourcesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListSourcesResponse, Source> response = securityCenterClient.ListSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Source item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Source item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Source> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Source item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscovery</summary>
        public void RunAssetDiscovery_RequestObject()
        {
            // Snippet: RunAssetDiscovery(RunAssetDiscoveryRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            RunAssetDiscoveryRequest request = new RunAssetDiscoveryRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = securityCenterClient.RunAssetDiscovery(request);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = securityCenterClient.PollOnceRunAssetDiscovery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscoveryAsync</summary>
        public async Task RunAssetDiscoveryAsync_RequestObject()
        {
            // Snippet: RunAssetDiscoveryAsync(RunAssetDiscoveryRequest, CallSettings)
            // Additional: RunAssetDiscoveryAsync(RunAssetDiscoveryRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            RunAssetDiscoveryRequest request = new RunAssetDiscoveryRequest
            {
                ParentAsOrganizationName = OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = await securityCenterClient.RunAssetDiscoveryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceRunAssetDiscoveryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscovery</summary>
        public void RunAssetDiscovery()
        {
            // Snippet: RunAssetDiscovery(string, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = securityCenterClient.RunAssetDiscovery(parent);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = securityCenterClient.PollOnceRunAssetDiscovery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscoveryAsync</summary>
        public async Task RunAssetDiscoveryAsync()
        {
            // Snippet: RunAssetDiscoveryAsync(string, CallSettings)
            // Additional: RunAssetDiscoveryAsync(string, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]";
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = await securityCenterClient.RunAssetDiscoveryAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceRunAssetDiscoveryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscovery</summary>
        public void RunAssetDiscovery_ResourceNames()
        {
            // Snippet: RunAssetDiscovery(OrganizationName, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = securityCenterClient.RunAssetDiscovery(parent);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = securityCenterClient.PollOnceRunAssetDiscovery(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunAssetDiscoveryAsync</summary>
        public async Task RunAssetDiscoveryAsync_ResourceNames()
        {
            // Snippet: RunAssetDiscoveryAsync(OrganizationName, CallSettings)
            // Additional: RunAssetDiscoveryAsync(OrganizationName, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            Operation<RunAssetDiscoveryResponse, Empty> response = await securityCenterClient.RunAssetDiscoveryAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<RunAssetDiscoveryResponse, Empty> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunAssetDiscoveryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunAssetDiscoveryResponse, Empty> retrievedResponse = await securityCenterClient.PollOnceRunAssetDiscoveryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunAssetDiscoveryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingState_RequestObject()
        {
            // Snippet: SetFindingState(SetFindingStateRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            // Make the request
            Finding response = securityCenterClient.SetFindingState(request);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateAsync_RequestObject()
        {
            // Snippet: SetFindingStateAsync(SetFindingStateRequest, CallSettings)
            // Additional: SetFindingStateAsync(SetFindingStateRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetFindingStateRequest request = new SetFindingStateRequest
            {
                FindingName = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]"),
                State = Finding.Types.State.Unspecified,
                StartTime = new Timestamp(),
            };
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingState()
        {
            // Snippet: SetFindingState(string, Finding.Types.State, Timestamp, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            // Make the request
            Finding response = securityCenterClient.SetFindingState(name, state, startTime);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateAsync()
        {
            // Snippet: SetFindingStateAsync(string, Finding.Types.State, Timestamp, CallSettings)
            // Additional: SetFindingStateAsync(string, Finding.Types.State, Timestamp, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/sources/[SOURCE]/findings/[FINDING]";
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(name, state, startTime);
            // End snippet
        }

        /// <summary>Snippet for SetFindingState</summary>
        public void SetFindingState_ResourceNames()
        {
            // Snippet: SetFindingState(FindingName, Finding.Types.State, Timestamp, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            // Make the request
            Finding response = securityCenterClient.SetFindingState(name, state, startTime);
            // End snippet
        }

        /// <summary>Snippet for SetFindingStateAsync</summary>
        public async Task SetFindingStateAsync_ResourceNames()
        {
            // Snippet: SetFindingStateAsync(FindingName, Finding.Types.State, Timestamp, CallSettings)
            // Additional: SetFindingStateAsync(FindingName, Finding.Types.State, Timestamp, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            FindingName name = FindingName.FromOrganizationSourceFinding("[ORGANIZATION]", "[SOURCE]", "[FINDING]");
            Finding.Types.State state = Finding.Types.State.Unspecified;
            Timestamp startTime = new Timestamp();
            // Make the request
            Finding response = await securityCenterClient.SetFindingStateAsync(name, state, startTime);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_ResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = securityCenterClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_ResourceNames()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await securityCenterClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_ResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = securityCenterClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_ResourceNames()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await securityCenterClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for UpdateFinding</summary>
        public void UpdateFinding_RequestObject()
        {
            // Snippet: UpdateFinding(UpdateFindingRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Finding response = securityCenterClient.UpdateFinding(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingAsync</summary>
        public async Task UpdateFindingAsync_RequestObject()
        {
            // Snippet: UpdateFindingAsync(UpdateFindingRequest, CallSettings)
            // Additional: UpdateFindingAsync(UpdateFindingRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFindingRequest request = new UpdateFindingRequest
            {
                Finding = new Finding(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Finding response = await securityCenterClient.UpdateFindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFinding</summary>
        public void UpdateFinding()
        {
            // Snippet: UpdateFinding(Finding, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            Finding finding = new Finding();
            // Make the request
            Finding response = securityCenterClient.UpdateFinding(finding);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingAsync</summary>
        public async Task UpdateFindingAsync()
        {
            // Snippet: UpdateFindingAsync(Finding, CallSettings)
            // Additional: UpdateFindingAsync(Finding, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            Finding finding = new Finding();
            // Make the request
            Finding response = await securityCenterClient.UpdateFindingAsync(finding);
            // End snippet
        }

        /// <summary>Snippet for UpdateOrganizationSettings</summary>
        public void UpdateOrganizationSettings_RequestObject()
        {
            // Snippet: UpdateOrganizationSettings(UpdateOrganizationSettingsRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OrganizationSettings response = securityCenterClient.UpdateOrganizationSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOrganizationSettingsAsync</summary>
        public async Task UpdateOrganizationSettingsAsync_RequestObject()
        {
            // Snippet: UpdateOrganizationSettingsAsync(UpdateOrganizationSettingsRequest, CallSettings)
            // Additional: UpdateOrganizationSettingsAsync(UpdateOrganizationSettingsRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOrganizationSettingsRequest request = new UpdateOrganizationSettingsRequest
            {
                OrganizationSettings = new OrganizationSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OrganizationSettings response = await securityCenterClient.UpdateOrganizationSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOrganizationSettings</summary>
        public void UpdateOrganizationSettings()
        {
            // Snippet: UpdateOrganizationSettings(OrganizationSettings, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            OrganizationSettings organizationSettings = new OrganizationSettings();
            // Make the request
            OrganizationSettings response = securityCenterClient.UpdateOrganizationSettings(organizationSettings);
            // End snippet
        }

        /// <summary>Snippet for UpdateOrganizationSettingsAsync</summary>
        public async Task UpdateOrganizationSettingsAsync()
        {
            // Snippet: UpdateOrganizationSettingsAsync(OrganizationSettings, CallSettings)
            // Additional: UpdateOrganizationSettingsAsync(OrganizationSettings, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationSettings organizationSettings = new OrganizationSettings();
            // Make the request
            OrganizationSettings response = await securityCenterClient.UpdateOrganizationSettingsAsync(organizationSettings);
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSource_RequestObject()
        {
            // Snippet: UpdateSource(UpdateSourceRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Source response = securityCenterClient.UpdateSource(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceAsync_RequestObject()
        {
            // Snippet: UpdateSourceAsync(UpdateSourceRequest, CallSettings)
            // Additional: UpdateSourceAsync(UpdateSourceRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSourceRequest request = new UpdateSourceRequest
            {
                Source = new Source(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Source response = await securityCenterClient.UpdateSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSource</summary>
        public void UpdateSource()
        {
            // Snippet: UpdateSource(Source, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            Source source = new Source();
            // Make the request
            Source response = securityCenterClient.UpdateSource(source);
            // End snippet
        }

        /// <summary>Snippet for UpdateSourceAsync</summary>
        public async Task UpdateSourceAsync()
        {
            // Snippet: UpdateSourceAsync(Source, CallSettings)
            // Additional: UpdateSourceAsync(Source, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            Source source = new Source();
            // Make the request
            Source response = await securityCenterClient.UpdateSourceAsync(source);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarks</summary>
        public void UpdateSecurityMarks_RequestObject()
        {
            // Snippet: UpdateSecurityMarks(UpdateSecurityMarksRequest, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new FieldMask(),
                StartTime = new Timestamp(),
            };
            // Make the request
            SecurityMarks response = securityCenterClient.UpdateSecurityMarks(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarksAsync</summary>
        public async Task UpdateSecurityMarksAsync_RequestObject()
        {
            // Snippet: UpdateSecurityMarksAsync(UpdateSecurityMarksRequest, CallSettings)
            // Additional: UpdateSecurityMarksAsync(UpdateSecurityMarksRequest, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityMarksRequest request = new UpdateSecurityMarksRequest
            {
                SecurityMarks = new SecurityMarks(),
                UpdateMask = new FieldMask(),
                StartTime = new Timestamp(),
            };
            // Make the request
            SecurityMarks response = await securityCenterClient.UpdateSecurityMarksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarks</summary>
        public void UpdateSecurityMarks()
        {
            // Snippet: UpdateSecurityMarks(SecurityMarks, CallSettings)
            // Create client
            SecurityCenterClient securityCenterClient = SecurityCenterClient.Create();
            // Initialize request argument(s)
            SecurityMarks securityMarks = new SecurityMarks();
            // Make the request
            SecurityMarks response = securityCenterClient.UpdateSecurityMarks(securityMarks);
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityMarksAsync</summary>
        public async Task UpdateSecurityMarksAsync()
        {
            // Snippet: UpdateSecurityMarksAsync(SecurityMarks, CallSettings)
            // Additional: UpdateSecurityMarksAsync(SecurityMarks, CancellationToken)
            // Create client
            SecurityCenterClient securityCenterClient = await SecurityCenterClient.CreateAsync();
            // Initialize request argument(s)
            SecurityMarks securityMarks = new SecurityMarks();
            // Make the request
            SecurityMarks response = await securityCenterClient.UpdateSecurityMarksAsync(securityMarks);
            // End snippet
        }
    }
}
