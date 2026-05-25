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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSecurityProfileGroupServiceClientSnippets
    {
        /// <summary>Snippet for ListSecurityProfileGroups</summary>
        public void ListSecurityProfileGroupsRequestObject()
        {
            // Snippet: ListSecurityProfileGroups(ListSecurityProfileGroupsRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroupsAsync</summary>
        public async Task ListSecurityProfileGroupsRequestObjectAsync()
        {
            // Snippet: ListSecurityProfileGroupsAsync(ListSecurityProfileGroupsRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSecurityProfileGroupsRequest request = new ListSecurityProfileGroupsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroups</summary>
        public void ListSecurityProfileGroups()
        {
            // Snippet: ListSecurityProfileGroups(string, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroupsAsync</summary>
        public async Task ListSecurityProfileGroupsAsync()
        {
            // Snippet: ListSecurityProfileGroupsAsync(string, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroups</summary>
        public void ListSecurityProfileGroupsResourceNames1()
        {
            // Snippet: ListSecurityProfileGroups(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroupsAsync</summary>
        public async Task ListSecurityProfileGroupsResourceNames1Async()
        {
            // Snippet: ListSecurityProfileGroupsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroups</summary>
        public void ListSecurityProfileGroupsResourceNames2()
        {
            // Snippet: ListSecurityProfileGroups(LocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfileGroupsAsync</summary>
        public async Task ListSecurityProfileGroupsResourceNames2Async()
        {
            // Snippet: ListSecurityProfileGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfileGroupsResponse, SecurityProfileGroup> response = securityProfileGroupServiceClient.ListSecurityProfileGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfileGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfileGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfileGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfileGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfileGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroup</summary>
        public void GetSecurityProfileGroupRequestObject()
        {
            // Snippet: GetSecurityProfileGroup(GetSecurityProfileGroupRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            GetSecurityProfileGroupRequest request = new GetSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]"),
            };
            // Make the request
            SecurityProfileGroup response = securityProfileGroupServiceClient.GetSecurityProfileGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroupAsync</summary>
        public async Task GetSecurityProfileGroupRequestObjectAsync()
        {
            // Snippet: GetSecurityProfileGroupAsync(GetSecurityProfileGroupRequest, CallSettings)
            // Additional: GetSecurityProfileGroupAsync(GetSecurityProfileGroupRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSecurityProfileGroupRequest request = new GetSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]"),
            };
            // Make the request
            SecurityProfileGroup response = await securityProfileGroupServiceClient.GetSecurityProfileGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroup</summary>
        public void GetSecurityProfileGroup()
        {
            // Snippet: GetSecurityProfileGroup(string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfileGroups/[SECURITY_PROFILE_GROUP]";
            // Make the request
            SecurityProfileGroup response = securityProfileGroupServiceClient.GetSecurityProfileGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroupAsync</summary>
        public async Task GetSecurityProfileGroupAsync()
        {
            // Snippet: GetSecurityProfileGroupAsync(string, CallSettings)
            // Additional: GetSecurityProfileGroupAsync(string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfileGroups/[SECURITY_PROFILE_GROUP]";
            // Make the request
            SecurityProfileGroup response = await securityProfileGroupServiceClient.GetSecurityProfileGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroup</summary>
        public void GetSecurityProfileGroupResourceNames()
        {
            // Snippet: GetSecurityProfileGroup(SecurityProfileGroupName, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfileGroupName name = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]");
            // Make the request
            SecurityProfileGroup response = securityProfileGroupServiceClient.GetSecurityProfileGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileGroupAsync</summary>
        public async Task GetSecurityProfileGroupResourceNamesAsync()
        {
            // Snippet: GetSecurityProfileGroupAsync(SecurityProfileGroupName, CallSettings)
            // Additional: GetSecurityProfileGroupAsync(SecurityProfileGroupName, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfileGroupName name = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]");
            // Make the request
            SecurityProfileGroup response = await securityProfileGroupServiceClient.GetSecurityProfileGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroup</summary>
        public void CreateSecurityProfileGroupRequestObject()
        {
            // Snippet: CreateSecurityProfileGroup(CreateSecurityProfileGroupRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            CreateSecurityProfileGroupRequest request = new CreateSecurityProfileGroupRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityProfileGroupId = "",
                SecurityProfileGroup = new SecurityProfileGroup(),
            };
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfileGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroupAsync</summary>
        public async Task CreateSecurityProfileGroupRequestObjectAsync()
        {
            // Snippet: CreateSecurityProfileGroupAsync(CreateSecurityProfileGroupRequest, CallSettings)
            // Additional: CreateSecurityProfileGroupAsync(CreateSecurityProfileGroupRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecurityProfileGroupRequest request = new CreateSecurityProfileGroupRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityProfileGroupId = "",
                SecurityProfileGroup = new SecurityProfileGroup(),
            };
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroup</summary>
        public void CreateSecurityProfileGroup()
        {
            // Snippet: CreateSecurityProfileGroup(string, SecurityProfileGroup, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfileGroup(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroupAsync</summary>
        public async Task CreateSecurityProfileGroupAsync()
        {
            // Snippet: CreateSecurityProfileGroupAsync(string, SecurityProfileGroup, string, CallSettings)
            // Additional: CreateSecurityProfileGroupAsync(string, SecurityProfileGroup, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroup</summary>
        public void CreateSecurityProfileGroupResourceNames1()
        {
            // Snippet: CreateSecurityProfileGroup(OrganizationLocationName, SecurityProfileGroup, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfileGroup(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroupAsync</summary>
        public async Task CreateSecurityProfileGroupResourceNames1Async()
        {
            // Snippet: CreateSecurityProfileGroupAsync(OrganizationLocationName, SecurityProfileGroup, string, CallSettings)
            // Additional: CreateSecurityProfileGroupAsync(OrganizationLocationName, SecurityProfileGroup, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroup</summary>
        public void CreateSecurityProfileGroupResourceNames2()
        {
            // Snippet: CreateSecurityProfileGroup(LocationName, SecurityProfileGroup, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfileGroup(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileGroupAsync</summary>
        public async Task CreateSecurityProfileGroupResourceNames2Async()
        {
            // Snippet: CreateSecurityProfileGroupAsync(LocationName, SecurityProfileGroup, string, CallSettings)
            // Additional: CreateSecurityProfileGroupAsync(LocationName, SecurityProfileGroup, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            string securityProfileGroupId = "";
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileGroupAsync(parent, securityProfileGroup, securityProfileGroupId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileGroup</summary>
        public void UpdateSecurityProfileGroupRequestObject()
        {
            // Snippet: UpdateSecurityProfileGroup(UpdateSecurityProfileGroupRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateSecurityProfileGroupRequest request = new UpdateSecurityProfileGroupRequest
            {
                UpdateMask = new FieldMask(),
                SecurityProfileGroup = new SecurityProfileGroup(),
            };
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.UpdateSecurityProfileGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileGroupAsync</summary>
        public async Task UpdateSecurityProfileGroupRequestObjectAsync()
        {
            // Snippet: UpdateSecurityProfileGroupAsync(UpdateSecurityProfileGroupRequest, CallSettings)
            // Additional: UpdateSecurityProfileGroupAsync(UpdateSecurityProfileGroupRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityProfileGroupRequest request = new UpdateSecurityProfileGroupRequest
            {
                UpdateMask = new FieldMask(),
                SecurityProfileGroup = new SecurityProfileGroup(),
            };
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.UpdateSecurityProfileGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileGroup</summary>
        public void UpdateSecurityProfileGroup()
        {
            // Snippet: UpdateSecurityProfileGroup(SecurityProfileGroup, FieldMask, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = securityProfileGroupServiceClient.UpdateSecurityProfileGroup(securityProfileGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileGroupAsync</summary>
        public async Task UpdateSecurityProfileGroupAsync()
        {
            // Snippet: UpdateSecurityProfileGroupAsync(SecurityProfileGroup, FieldMask, CallSettings)
            // Additional: UpdateSecurityProfileGroupAsync(SecurityProfileGroup, FieldMask, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfileGroup securityProfileGroup = new SecurityProfileGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SecurityProfileGroup, OperationMetadata> response = await securityProfileGroupServiceClient.UpdateSecurityProfileGroupAsync(securityProfileGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfileGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfileGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfileGroup, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfileGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroup</summary>
        public void DeleteSecurityProfileGroupRequestObject()
        {
            // Snippet: DeleteSecurityProfileGroup(DeleteSecurityProfileGroupRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            DeleteSecurityProfileGroupRequest request = new DeleteSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfileGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroupAsync</summary>
        public async Task DeleteSecurityProfileGroupRequestObjectAsync()
        {
            // Snippet: DeleteSecurityProfileGroupAsync(DeleteSecurityProfileGroupRequest, CallSettings)
            // Additional: DeleteSecurityProfileGroupAsync(DeleteSecurityProfileGroupRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecurityProfileGroupRequest request = new DeleteSecurityProfileGroupRequest
            {
                SecurityProfileGroupName = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroup</summary>
        public void DeleteSecurityProfileGroup()
        {
            // Snippet: DeleteSecurityProfileGroup(string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfileGroups/[SECURITY_PROFILE_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfileGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroupAsync</summary>
        public async Task DeleteSecurityProfileGroupAsync()
        {
            // Snippet: DeleteSecurityProfileGroupAsync(string, CallSettings)
            // Additional: DeleteSecurityProfileGroupAsync(string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfileGroups/[SECURITY_PROFILE_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroup</summary>
        public void DeleteSecurityProfileGroupResourceNames()
        {
            // Snippet: DeleteSecurityProfileGroup(SecurityProfileGroupName, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfileGroupName name = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfileGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileGroupAsync</summary>
        public async Task DeleteSecurityProfileGroupResourceNamesAsync()
        {
            // Snippet: DeleteSecurityProfileGroupAsync(SecurityProfileGroupName, CallSettings)
            // Additional: DeleteSecurityProfileGroupAsync(SecurityProfileGroupName, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfileGroupName name = SecurityProfileGroupName.FromOrganizationLocationSecurityProfileGroup("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfiles</summary>
        public void ListSecurityProfilesRequestObject()
        {
            // Snippet: ListSecurityProfiles(ListSecurityProfilesRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfilesAsync</summary>
        public async Task ListSecurityProfilesRequestObjectAsync()
        {
            // Snippet: ListSecurityProfilesAsync(ListSecurityProfilesRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSecurityProfilesRequest request = new ListSecurityProfilesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfiles</summary>
        public void ListSecurityProfiles()
        {
            // Snippet: ListSecurityProfiles(string, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfilesAsync</summary>
        public async Task ListSecurityProfilesAsync()
        {
            // Snippet: ListSecurityProfilesAsync(string, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfiles</summary>
        public void ListSecurityProfilesResourceNames1()
        {
            // Snippet: ListSecurityProfiles(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfilesAsync</summary>
        public async Task ListSecurityProfilesResourceNames1Async()
        {
            // Snippet: ListSecurityProfilesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfiles</summary>
        public void ListSecurityProfilesResourceNames2()
        {
            // Snippet: ListSecurityProfiles(LocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSecurityProfilesAsync</summary>
        public async Task ListSecurityProfilesResourceNames2Async()
        {
            // Snippet: ListSecurityProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSecurityProfilesResponse, SecurityProfile> response = securityProfileGroupServiceClient.ListSecurityProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SecurityProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSecurityProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfile</summary>
        public void GetSecurityProfileRequestObject()
        {
            // Snippet: GetSecurityProfile(GetSecurityProfileRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            GetSecurityProfileRequest request = new GetSecurityProfileRequest
            {
                SecurityProfileName = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]"),
            };
            // Make the request
            SecurityProfile response = securityProfileGroupServiceClient.GetSecurityProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileAsync</summary>
        public async Task GetSecurityProfileRequestObjectAsync()
        {
            // Snippet: GetSecurityProfileAsync(GetSecurityProfileRequest, CallSettings)
            // Additional: GetSecurityProfileAsync(GetSecurityProfileRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSecurityProfileRequest request = new GetSecurityProfileRequest
            {
                SecurityProfileName = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]"),
            };
            // Make the request
            SecurityProfile response = await securityProfileGroupServiceClient.GetSecurityProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfile</summary>
        public void GetSecurityProfile()
        {
            // Snippet: GetSecurityProfile(string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfiles/[SECURITY_PROFILE]";
            // Make the request
            SecurityProfile response = securityProfileGroupServiceClient.GetSecurityProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileAsync</summary>
        public async Task GetSecurityProfileAsync()
        {
            // Snippet: GetSecurityProfileAsync(string, CallSettings)
            // Additional: GetSecurityProfileAsync(string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfiles/[SECURITY_PROFILE]";
            // Make the request
            SecurityProfile response = await securityProfileGroupServiceClient.GetSecurityProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfile</summary>
        public void GetSecurityProfileResourceNames()
        {
            // Snippet: GetSecurityProfile(SecurityProfileName, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfileName name = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]");
            // Make the request
            SecurityProfile response = securityProfileGroupServiceClient.GetSecurityProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetSecurityProfileAsync</summary>
        public async Task GetSecurityProfileResourceNamesAsync()
        {
            // Snippet: GetSecurityProfileAsync(SecurityProfileName, CallSettings)
            // Additional: GetSecurityProfileAsync(SecurityProfileName, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfileName name = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]");
            // Make the request
            SecurityProfile response = await securityProfileGroupServiceClient.GetSecurityProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfile</summary>
        public void CreateSecurityProfileRequestObject()
        {
            // Snippet: CreateSecurityProfile(CreateSecurityProfileRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            CreateSecurityProfileRequest request = new CreateSecurityProfileRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityProfileId = "",
                SecurityProfile = new SecurityProfile(),
            };
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileAsync</summary>
        public async Task CreateSecurityProfileRequestObjectAsync()
        {
            // Snippet: CreateSecurityProfileAsync(CreateSecurityProfileRequest, CallSettings)
            // Additional: CreateSecurityProfileAsync(CreateSecurityProfileRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecurityProfileRequest request = new CreateSecurityProfileRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                SecurityProfileId = "",
                SecurityProfile = new SecurityProfile(),
            };
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfile</summary>
        public void CreateSecurityProfile()
        {
            // Snippet: CreateSecurityProfile(string, SecurityProfile, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfile(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileAsync</summary>
        public async Task CreateSecurityProfileAsync()
        {
            // Snippet: CreateSecurityProfileAsync(string, SecurityProfile, string, CallSettings)
            // Additional: CreateSecurityProfileAsync(string, SecurityProfile, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileAsync(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfile</summary>
        public void CreateSecurityProfileResourceNames1()
        {
            // Snippet: CreateSecurityProfile(OrganizationLocationName, SecurityProfile, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfile(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileAsync</summary>
        public async Task CreateSecurityProfileResourceNames1Async()
        {
            // Snippet: CreateSecurityProfileAsync(OrganizationLocationName, SecurityProfile, string, CallSettings)
            // Additional: CreateSecurityProfileAsync(OrganizationLocationName, SecurityProfile, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileAsync(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfile</summary>
        public void CreateSecurityProfileResourceNames2()
        {
            // Snippet: CreateSecurityProfile(LocationName, SecurityProfile, string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.CreateSecurityProfile(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceCreateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecurityProfileAsync</summary>
        public async Task CreateSecurityProfileResourceNames2Async()
        {
            // Snippet: CreateSecurityProfileAsync(LocationName, SecurityProfile, string, CallSettings)
            // Additional: CreateSecurityProfileAsync(LocationName, SecurityProfile, string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SecurityProfile securityProfile = new SecurityProfile();
            string securityProfileId = "";
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.CreateSecurityProfileAsync(parent, securityProfile, securityProfileId);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceCreateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfile</summary>
        public void UpdateSecurityProfileRequestObject()
        {
            // Snippet: UpdateSecurityProfile(UpdateSecurityProfileRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateSecurityProfileRequest request = new UpdateSecurityProfileRequest
            {
                UpdateMask = new FieldMask(),
                SecurityProfile = new SecurityProfile(),
            };
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.UpdateSecurityProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceUpdateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileAsync</summary>
        public async Task UpdateSecurityProfileRequestObjectAsync()
        {
            // Snippet: UpdateSecurityProfileAsync(UpdateSecurityProfileRequest, CallSettings)
            // Additional: UpdateSecurityProfileAsync(UpdateSecurityProfileRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityProfileRequest request = new UpdateSecurityProfileRequest
            {
                UpdateMask = new FieldMask(),
                SecurityProfile = new SecurityProfile(),
            };
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.UpdateSecurityProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfile</summary>
        public void UpdateSecurityProfile()
        {
            // Snippet: UpdateSecurityProfile(SecurityProfile, FieldMask, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfile securityProfile = new SecurityProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = securityProfileGroupServiceClient.UpdateSecurityProfile(securityProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceUpdateSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSecurityProfileAsync</summary>
        public async Task UpdateSecurityProfileAsync()
        {
            // Snippet: UpdateSecurityProfileAsync(SecurityProfile, FieldMask, CallSettings)
            // Additional: UpdateSecurityProfileAsync(SecurityProfile, FieldMask, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfile securityProfile = new SecurityProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await securityProfileGroupServiceClient.UpdateSecurityProfileAsync(securityProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceUpdateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfile</summary>
        public void DeleteSecurityProfileRequestObject()
        {
            // Snippet: DeleteSecurityProfile(DeleteSecurityProfileRequest, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            DeleteSecurityProfileRequest request = new DeleteSecurityProfileRequest
            {
                SecurityProfileName = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileAsync</summary>
        public async Task DeleteSecurityProfileRequestObjectAsync()
        {
            // Snippet: DeleteSecurityProfileAsync(DeleteSecurityProfileRequest, CallSettings)
            // Additional: DeleteSecurityProfileAsync(DeleteSecurityProfileRequest, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSecurityProfileRequest request = new DeleteSecurityProfileRequest
            {
                SecurityProfileName = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]"),
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfile</summary>
        public void DeleteSecurityProfile()
        {
            // Snippet: DeleteSecurityProfile(string, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfiles/[SECURITY_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileAsync</summary>
        public async Task DeleteSecurityProfileAsync()
        {
            // Snippet: DeleteSecurityProfileAsync(string, CallSettings)
            // Additional: DeleteSecurityProfileAsync(string, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/securityProfiles/[SECURITY_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfile</summary>
        public void DeleteSecurityProfileResourceNames()
        {
            // Snippet: DeleteSecurityProfile(SecurityProfileName, CallSettings)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = SecurityProfileGroupServiceClient.Create();
            // Initialize request argument(s)
            SecurityProfileName name = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = securityProfileGroupServiceClient.DeleteSecurityProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = securityProfileGroupServiceClient.PollOnceDeleteSecurityProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSecurityProfileAsync</summary>
        public async Task DeleteSecurityProfileResourceNamesAsync()
        {
            // Snippet: DeleteSecurityProfileAsync(SecurityProfileName, CallSettings)
            // Additional: DeleteSecurityProfileAsync(SecurityProfileName, CancellationToken)
            // Create client
            SecurityProfileGroupServiceClient securityProfileGroupServiceClient = await SecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            SecurityProfileName name = SecurityProfileName.FromOrganizationLocationSecurityProfile("[ORGANIZATION]", "[LOCATION]", "[SECURITY_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await securityProfileGroupServiceClient.DeleteSecurityProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await securityProfileGroupServiceClient.PollOnceDeleteSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
