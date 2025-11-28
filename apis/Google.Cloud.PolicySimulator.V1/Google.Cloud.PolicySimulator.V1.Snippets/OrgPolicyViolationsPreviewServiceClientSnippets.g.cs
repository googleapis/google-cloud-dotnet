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
    using Google.Cloud.PolicySimulator.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOrgPolicyViolationsPreviewServiceClientSnippets
    {
        /// <summary>Snippet for ListOrgPolicyViolationsPreviews</summary>
        public void ListOrgPolicyViolationsPreviewsRequestObject()
        {
            // Snippet: ListOrgPolicyViolationsPreviews(ListOrgPolicyViolationsPreviewsRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolationsPreview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsPreviewsAsync</summary>
        public async Task ListOrgPolicyViolationsPreviewsRequestObjectAsync()
        {
            // Snippet: ListOrgPolicyViolationsPreviewsAsync(ListOrgPolicyViolationsPreviewsRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrgPolicyViolationsPreviewsRequest request = new ListOrgPolicyViolationsPreviewsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolationsPreview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsPreviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsPreviews</summary>
        public void ListOrgPolicyViolationsPreviews()
        {
            // Snippet: ListOrgPolicyViolationsPreviews(string, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolationsPreview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsPreviewsAsync</summary>
        public async Task ListOrgPolicyViolationsPreviewsAsync()
        {
            // Snippet: ListOrgPolicyViolationsPreviewsAsync(string, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolationsPreview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsPreviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsPreviews</summary>
        public void ListOrgPolicyViolationsPreviewsResourceNames()
        {
            // Snippet: ListOrgPolicyViolationsPreviews(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolationsPreview item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsPreviewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsPreviewsAsync</summary>
        public async Task ListOrgPolicyViolationsPreviewsResourceNamesAsync()
        {
            // Snippet: ListOrgPolicyViolationsPreviewsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsPreviewsResponse, OrgPolicyViolationsPreview> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsPreviewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolationsPreview item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsPreviewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolationsPreview item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolationsPreview> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolationsPreview item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreview</summary>
        public void GetOrgPolicyViolationsPreviewRequestObject()
        {
            // Snippet: GetOrgPolicyViolationsPreview(GetOrgPolicyViolationsPreviewRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            GetOrgPolicyViolationsPreviewRequest request = new GetOrgPolicyViolationsPreviewRequest
            {
                OrgPolicyViolationsPreviewName = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]"),
            };
            // Make the request
            OrgPolicyViolationsPreview response = orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreview(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreviewAsync</summary>
        public async Task GetOrgPolicyViolationsPreviewRequestObjectAsync()
        {
            // Snippet: GetOrgPolicyViolationsPreviewAsync(GetOrgPolicyViolationsPreviewRequest, CallSettings)
            // Additional: GetOrgPolicyViolationsPreviewAsync(GetOrgPolicyViolationsPreviewRequest, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOrgPolicyViolationsPreviewRequest request = new GetOrgPolicyViolationsPreviewRequest
            {
                OrgPolicyViolationsPreviewName = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]"),
            };
            // Make the request
            OrgPolicyViolationsPreview response = await orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreview</summary>
        public void GetOrgPolicyViolationsPreview()
        {
            // Snippet: GetOrgPolicyViolationsPreview(string, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/orgPolicyViolationsPreviews/[ORG_POLICY_VIOLATIONS_PREVIEW]";
            // Make the request
            OrgPolicyViolationsPreview response = orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreview(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreviewAsync</summary>
        public async Task GetOrgPolicyViolationsPreviewAsync()
        {
            // Snippet: GetOrgPolicyViolationsPreviewAsync(string, CallSettings)
            // Additional: GetOrgPolicyViolationsPreviewAsync(string, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/orgPolicyViolationsPreviews/[ORG_POLICY_VIOLATIONS_PREVIEW]";
            // Make the request
            OrgPolicyViolationsPreview response = await orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreview</summary>
        public void GetOrgPolicyViolationsPreviewResourceNames()
        {
            // Snippet: GetOrgPolicyViolationsPreview(OrgPolicyViolationsPreviewName, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            OrgPolicyViolationsPreviewName name = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]");
            // Make the request
            OrgPolicyViolationsPreview response = orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreview(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrgPolicyViolationsPreviewAsync</summary>
        public async Task GetOrgPolicyViolationsPreviewResourceNamesAsync()
        {
            // Snippet: GetOrgPolicyViolationsPreviewAsync(OrgPolicyViolationsPreviewName, CallSettings)
            // Additional: GetOrgPolicyViolationsPreviewAsync(OrgPolicyViolationsPreviewName, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrgPolicyViolationsPreviewName name = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]");
            // Make the request
            OrgPolicyViolationsPreview response = await orgPolicyViolationsPreviewServiceClient.GetOrgPolicyViolationsPreviewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreview</summary>
        public void CreateOrgPolicyViolationsPreviewRequestObject()
        {
            // Snippet: CreateOrgPolicyViolationsPreview(CreateOrgPolicyViolationsPreviewRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            CreateOrgPolicyViolationsPreviewRequest request = new CreateOrgPolicyViolationsPreviewRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrgPolicyViolationsPreview = new OrgPolicyViolationsPreview(),
                OrgPolicyViolationsPreviewId = "",
            };
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreview(request);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreviewAsync</summary>
        public async Task CreateOrgPolicyViolationsPreviewRequestObjectAsync()
        {
            // Snippet: CreateOrgPolicyViolationsPreviewAsync(CreateOrgPolicyViolationsPreviewRequest, CallSettings)
            // Additional: CreateOrgPolicyViolationsPreviewAsync(CreateOrgPolicyViolationsPreviewRequest, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOrgPolicyViolationsPreviewRequest request = new CreateOrgPolicyViolationsPreviewRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                OrgPolicyViolationsPreview = new OrgPolicyViolationsPreview(),
                OrgPolicyViolationsPreviewId = "",
            };
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = await orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = await orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreview</summary>
        public void CreateOrgPolicyViolationsPreview()
        {
            // Snippet: CreateOrgPolicyViolationsPreview(string, OrgPolicyViolationsPreview, string, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            OrgPolicyViolationsPreview orgPolicyViolationsPreview = new OrgPolicyViolationsPreview();
            string orgPolicyViolationsPreviewId = "";
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreview(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreviewAsync</summary>
        public async Task CreateOrgPolicyViolationsPreviewAsync()
        {
            // Snippet: CreateOrgPolicyViolationsPreviewAsync(string, OrgPolicyViolationsPreview, string, CallSettings)
            // Additional: CreateOrgPolicyViolationsPreviewAsync(string, OrgPolicyViolationsPreview, string, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            OrgPolicyViolationsPreview orgPolicyViolationsPreview = new OrgPolicyViolationsPreview();
            string orgPolicyViolationsPreviewId = "";
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = await orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = await orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreview</summary>
        public void CreateOrgPolicyViolationsPreviewResourceNames()
        {
            // Snippet: CreateOrgPolicyViolationsPreview(OrganizationLocationName, OrgPolicyViolationsPreview, string, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            OrgPolicyViolationsPreview orgPolicyViolationsPreview = new OrgPolicyViolationsPreview();
            string orgPolicyViolationsPreviewId = "";
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreview(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreview(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrgPolicyViolationsPreviewAsync</summary>
        public async Task CreateOrgPolicyViolationsPreviewResourceNamesAsync()
        {
            // Snippet: CreateOrgPolicyViolationsPreviewAsync(OrganizationLocationName, OrgPolicyViolationsPreview, string, CallSettings)
            // Additional: CreateOrgPolicyViolationsPreviewAsync(OrganizationLocationName, OrgPolicyViolationsPreview, string, CancellationToken)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            OrgPolicyViolationsPreview orgPolicyViolationsPreview = new OrgPolicyViolationsPreview();
            string orgPolicyViolationsPreviewId = "";
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = await orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = await orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolations</summary>
        public void ListOrgPolicyViolationsRequestObject()
        {
            // Snippet: ListOrgPolicyViolations(ListOrgPolicyViolationsRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
            {
                ParentAsOrgPolicyViolationsPreviewName = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]"),
            };
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsAsync</summary>
        public async Task ListOrgPolicyViolationsRequestObjectAsync()
        {
            // Snippet: ListOrgPolicyViolationsAsync(ListOrgPolicyViolationsRequest, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrgPolicyViolationsRequest request = new ListOrgPolicyViolationsRequest
            {
                ParentAsOrgPolicyViolationsPreviewName = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolations</summary>
        public void ListOrgPolicyViolations()
        {
            // Snippet: ListOrgPolicyViolations(string, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/orgPolicyViolationsPreviews/[ORG_POLICY_VIOLATIONS_PREVIEW]";
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsAsync</summary>
        public async Task ListOrgPolicyViolationsAsync()
        {
            // Snippet: ListOrgPolicyViolationsAsync(string, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/orgPolicyViolationsPreviews/[ORG_POLICY_VIOLATIONS_PREVIEW]";
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolations</summary>
        public void ListOrgPolicyViolationsResourceNames()
        {
            // Snippet: ListOrgPolicyViolations(OrgPolicyViolationsPreviewName, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = OrgPolicyViolationsPreviewServiceClient.Create();
            // Initialize request argument(s)
            OrgPolicyViolationsPreviewName parent = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]");
            // Make the request
            PagedEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrgPolicyViolation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrgPolicyViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrgPolicyViolationsAsync</summary>
        public async Task ListOrgPolicyViolationsResourceNamesAsync()
        {
            // Snippet: ListOrgPolicyViolationsAsync(OrgPolicyViolationsPreviewName, string, int?, CallSettings)
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrgPolicyViolationsPreviewName parent = OrgPolicyViolationsPreviewName.FromOrganizationLocationOrgPolicyViolationsPreview("[ORGANIZATION]", "[LOCATION]", "[ORG_POLICY_VIOLATIONS_PREVIEW]");
            // Make the request
            PagedAsyncEnumerable<ListOrgPolicyViolationsResponse, OrgPolicyViolation> response = orgPolicyViolationsPreviewServiceClient.ListOrgPolicyViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrgPolicyViolation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrgPolicyViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrgPolicyViolation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrgPolicyViolation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrgPolicyViolation item in singlePage)
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
