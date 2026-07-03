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
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFindingsRefinementServiceClientSnippets
    {
        /// <summary>Snippet for GetFindingsRefinement</summary>
        public void GetFindingsRefinementRequestObject()
        {
            // Snippet: GetFindingsRefinement(GetFindingsRefinementRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            GetFindingsRefinementRequest request = new GetFindingsRefinementRequest
            {
                FindingsRefinementName = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
            };
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.GetFindingsRefinement(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementAsync</summary>
        public async Task GetFindingsRefinementRequestObjectAsync()
        {
            // Snippet: GetFindingsRefinementAsync(GetFindingsRefinementRequest, CallSettings)
            // Additional: GetFindingsRefinementAsync(GetFindingsRefinementRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFindingsRefinementRequest request = new GetFindingsRefinementRequest
            {
                FindingsRefinementName = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
            };
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.GetFindingsRefinementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinement</summary>
        public void GetFindingsRefinement()
        {
            // Snippet: GetFindingsRefinement(string, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]";
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.GetFindingsRefinement(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementAsync</summary>
        public async Task GetFindingsRefinementAsync()
        {
            // Snippet: GetFindingsRefinementAsync(string, CallSettings)
            // Additional: GetFindingsRefinementAsync(string, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]";
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.GetFindingsRefinementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinement</summary>
        public void GetFindingsRefinementResourceNames()
        {
            // Snippet: GetFindingsRefinement(FindingsRefinementName, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            FindingsRefinementName name = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.GetFindingsRefinement(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementAsync</summary>
        public async Task GetFindingsRefinementResourceNamesAsync()
        {
            // Snippet: GetFindingsRefinementAsync(FindingsRefinementName, CallSettings)
            // Additional: GetFindingsRefinementAsync(FindingsRefinementName, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindingsRefinementName name = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.GetFindingsRefinementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinements</summary>
        public void ListFindingsRefinementsRequestObject()
        {
            // Snippet: ListFindingsRefinements(ListFindingsRefinementsRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinementsAsync</summary>
        public async Task ListFindingsRefinementsRequestObjectAsync()
        {
            // Snippet: ListFindingsRefinementsAsync(ListFindingsRefinementsRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingsRefinementsRequest request = new ListFindingsRefinementsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinements</summary>
        public void ListFindingsRefinements()
        {
            // Snippet: ListFindingsRefinements(string, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinementsAsync</summary>
        public async Task ListFindingsRefinementsAsync()
        {
            // Snippet: ListFindingsRefinementsAsync(string, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinements</summary>
        public void ListFindingsRefinementsResourceNames()
        {
            // Snippet: ListFindingsRefinements(InstanceName, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingsRefinementsAsync</summary>
        public async Task ListFindingsRefinementsResourceNamesAsync()
        {
            // Snippet: ListFindingsRefinementsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListFindingsRefinementsResponse, FindingsRefinement> response = findingsRefinementServiceClient.ListFindingsRefinementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListFindingsRefinementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinement</summary>
        public void CreateFindingsRefinementRequestObject()
        {
            // Snippet: CreateFindingsRefinement(CreateFindingsRefinementRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            CreateFindingsRefinementRequest request = new CreateFindingsRefinementRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                FindingsRefinement = new FindingsRefinement(),
            };
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.CreateFindingsRefinement(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinementAsync</summary>
        public async Task CreateFindingsRefinementRequestObjectAsync()
        {
            // Snippet: CreateFindingsRefinementAsync(CreateFindingsRefinementRequest, CallSettings)
            // Additional: CreateFindingsRefinementAsync(CreateFindingsRefinementRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFindingsRefinementRequest request = new CreateFindingsRefinementRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                FindingsRefinement = new FindingsRefinement(),
            };
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.CreateFindingsRefinementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinement</summary>
        public void CreateFindingsRefinement()
        {
            // Snippet: CreateFindingsRefinement(string, FindingsRefinement, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.CreateFindingsRefinement(parent, findingsRefinement);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinementAsync</summary>
        public async Task CreateFindingsRefinementAsync()
        {
            // Snippet: CreateFindingsRefinementAsync(string, FindingsRefinement, CallSettings)
            // Additional: CreateFindingsRefinementAsync(string, FindingsRefinement, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.CreateFindingsRefinementAsync(parent, findingsRefinement);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinement</summary>
        public void CreateFindingsRefinementResourceNames()
        {
            // Snippet: CreateFindingsRefinement(InstanceName, FindingsRefinement, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.CreateFindingsRefinement(parent, findingsRefinement);
            // End snippet
        }

        /// <summary>Snippet for CreateFindingsRefinementAsync</summary>
        public async Task CreateFindingsRefinementResourceNamesAsync()
        {
            // Snippet: CreateFindingsRefinementAsync(InstanceName, FindingsRefinement, CallSettings)
            // Additional: CreateFindingsRefinementAsync(InstanceName, FindingsRefinement, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.CreateFindingsRefinementAsync(parent, findingsRefinement);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinement</summary>
        public void UpdateFindingsRefinementRequestObject()
        {
            // Snippet: UpdateFindingsRefinement(UpdateFindingsRefinementRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            UpdateFindingsRefinementRequest request = new UpdateFindingsRefinementRequest
            {
                FindingsRefinement = new FindingsRefinement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.UpdateFindingsRefinement(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementAsync</summary>
        public async Task UpdateFindingsRefinementRequestObjectAsync()
        {
            // Snippet: UpdateFindingsRefinementAsync(UpdateFindingsRefinementRequest, CallSettings)
            // Additional: UpdateFindingsRefinementAsync(UpdateFindingsRefinementRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFindingsRefinementRequest request = new UpdateFindingsRefinementRequest
            {
                FindingsRefinement = new FindingsRefinement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.UpdateFindingsRefinementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinement</summary>
        public void UpdateFindingsRefinement()
        {
            // Snippet: UpdateFindingsRefinement(FindingsRefinement, FieldMask, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FindingsRefinement response = findingsRefinementServiceClient.UpdateFindingsRefinement(findingsRefinement, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementAsync</summary>
        public async Task UpdateFindingsRefinementAsync()
        {
            // Snippet: UpdateFindingsRefinementAsync(FindingsRefinement, FieldMask, CallSettings)
            // Additional: UpdateFindingsRefinementAsync(FindingsRefinement, FieldMask, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindingsRefinement findingsRefinement = new FindingsRefinement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FindingsRefinement response = await findingsRefinementServiceClient.UpdateFindingsRefinementAsync(findingsRefinement, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeployment</summary>
        public void GetFindingsRefinementDeploymentRequestObject()
        {
            // Snippet: GetFindingsRefinementDeployment(GetFindingsRefinementDeploymentRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            GetFindingsRefinementDeploymentRequest request = new GetFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeploymentName = FindingsRefinementDeploymentName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
            };
            // Make the request
            FindingsRefinementDeployment response = findingsRefinementServiceClient.GetFindingsRefinementDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeploymentAsync</summary>
        public async Task GetFindingsRefinementDeploymentRequestObjectAsync()
        {
            // Snippet: GetFindingsRefinementDeploymentAsync(GetFindingsRefinementDeploymentRequest, CallSettings)
            // Additional: GetFindingsRefinementDeploymentAsync(GetFindingsRefinementDeploymentRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFindingsRefinementDeploymentRequest request = new GetFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeploymentName = FindingsRefinementDeploymentName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
            };
            // Make the request
            FindingsRefinementDeployment response = await findingsRefinementServiceClient.GetFindingsRefinementDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeployment</summary>
        public void GetFindingsRefinementDeployment()
        {
            // Snippet: GetFindingsRefinementDeployment(string, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]/deployment";
            // Make the request
            FindingsRefinementDeployment response = findingsRefinementServiceClient.GetFindingsRefinementDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeploymentAsync</summary>
        public async Task GetFindingsRefinementDeploymentAsync()
        {
            // Snippet: GetFindingsRefinementDeploymentAsync(string, CallSettings)
            // Additional: GetFindingsRefinementDeploymentAsync(string, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]/deployment";
            // Make the request
            FindingsRefinementDeployment response = await findingsRefinementServiceClient.GetFindingsRefinementDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeployment</summary>
        public void GetFindingsRefinementDeploymentResourceNames()
        {
            // Snippet: GetFindingsRefinementDeployment(FindingsRefinementDeploymentName, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            FindingsRefinementDeploymentName name = FindingsRefinementDeploymentName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            FindingsRefinementDeployment response = findingsRefinementServiceClient.GetFindingsRefinementDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetFindingsRefinementDeploymentAsync</summary>
        public async Task GetFindingsRefinementDeploymentResourceNamesAsync()
        {
            // Snippet: GetFindingsRefinementDeploymentAsync(FindingsRefinementDeploymentName, CallSettings)
            // Additional: GetFindingsRefinementDeploymentAsync(FindingsRefinementDeploymentName, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindingsRefinementDeploymentName name = FindingsRefinementDeploymentName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            FindingsRefinementDeployment response = await findingsRefinementServiceClient.GetFindingsRefinementDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementDeployment</summary>
        public void UpdateFindingsRefinementDeploymentRequestObject()
        {
            // Snippet: UpdateFindingsRefinementDeployment(UpdateFindingsRefinementDeploymentRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            UpdateFindingsRefinementDeploymentRequest request = new UpdateFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeployment = new FindingsRefinementDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FindingsRefinementDeployment response = findingsRefinementServiceClient.UpdateFindingsRefinementDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementDeploymentAsync</summary>
        public async Task UpdateFindingsRefinementDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateFindingsRefinementDeploymentAsync(UpdateFindingsRefinementDeploymentRequest, CallSettings)
            // Additional: UpdateFindingsRefinementDeploymentAsync(UpdateFindingsRefinementDeploymentRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFindingsRefinementDeploymentRequest request = new UpdateFindingsRefinementDeploymentRequest
            {
                FindingsRefinementDeployment = new FindingsRefinementDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FindingsRefinementDeployment response = await findingsRefinementServiceClient.UpdateFindingsRefinementDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementDeployment</summary>
        public void UpdateFindingsRefinementDeployment()
        {
            // Snippet: UpdateFindingsRefinementDeployment(FindingsRefinementDeployment, FieldMask, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            FindingsRefinementDeployment findingsRefinementDeployment = new FindingsRefinementDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FindingsRefinementDeployment response = findingsRefinementServiceClient.UpdateFindingsRefinementDeployment(findingsRefinementDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFindingsRefinementDeploymentAsync</summary>
        public async Task UpdateFindingsRefinementDeploymentAsync()
        {
            // Snippet: UpdateFindingsRefinementDeploymentAsync(FindingsRefinementDeployment, FieldMask, CallSettings)
            // Additional: UpdateFindingsRefinementDeploymentAsync(FindingsRefinementDeployment, FieldMask, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindingsRefinementDeployment findingsRefinementDeployment = new FindingsRefinementDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FindingsRefinementDeployment response = await findingsRefinementServiceClient.UpdateFindingsRefinementDeploymentAsync(findingsRefinementDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeployments</summary>
        public void ListAllFindingsRefinementDeploymentsRequestObject()
        {
            // Snippet: ListAllFindingsRefinementDeployments(ListAllFindingsRefinementDeploymentsRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeploymentsAsync</summary>
        public async Task ListAllFindingsRefinementDeploymentsRequestObjectAsync()
        {
            // Snippet: ListAllFindingsRefinementDeploymentsAsync(ListAllFindingsRefinementDeploymentsRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAllFindingsRefinementDeploymentsRequest request = new ListAllFindingsRefinementDeploymentsRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeployments</summary>
        public void ListAllFindingsRefinementDeployments()
        {
            // Snippet: ListAllFindingsRefinementDeployments(string, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeployments(instance);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeploymentsAsync</summary>
        public async Task ListAllFindingsRefinementDeploymentsAsync()
        {
            // Snippet: ListAllFindingsRefinementDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeploymentsAsync(instance);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeployments</summary>
        public void ListAllFindingsRefinementDeploymentsResourceNames()
        {
            // Snippet: ListAllFindingsRefinementDeployments(InstanceName, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeployments(instance);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAllFindingsRefinementDeploymentsAsync</summary>
        public async Task ListAllFindingsRefinementDeploymentsResourceNamesAsync()
        {
            // Snippet: ListAllFindingsRefinementDeploymentsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListAllFindingsRefinementDeploymentsResponse, FindingsRefinementDeployment> response = findingsRefinementServiceClient.ListAllFindingsRefinementDeploymentsAsync(instance);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (FindingsRefinementDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAllFindingsRefinementDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingsRefinementDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingsRefinementDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingsRefinementDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivity</summary>
        public void ComputeFindingsRefinementActivityRequestObject()
        {
            // Snippet: ComputeFindingsRefinementActivity(ComputeFindingsRefinementActivityRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            ComputeFindingsRefinementActivityRequest request = new ComputeFindingsRefinementActivityRequest
            {
                FindingsRefinementName = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
                Interval = new Interval(),
            };
            // Make the request
            ComputeFindingsRefinementActivityResponse response = findingsRefinementServiceClient.ComputeFindingsRefinementActivity(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivityAsync</summary>
        public async Task ComputeFindingsRefinementActivityRequestObjectAsync()
        {
            // Snippet: ComputeFindingsRefinementActivityAsync(ComputeFindingsRefinementActivityRequest, CallSettings)
            // Additional: ComputeFindingsRefinementActivityAsync(ComputeFindingsRefinementActivityRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeFindingsRefinementActivityRequest request = new ComputeFindingsRefinementActivityRequest
            {
                FindingsRefinementName = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]"),
                Interval = new Interval(),
            };
            // Make the request
            ComputeFindingsRefinementActivityResponse response = await findingsRefinementServiceClient.ComputeFindingsRefinementActivityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivity</summary>
        public void ComputeFindingsRefinementActivity()
        {
            // Snippet: ComputeFindingsRefinementActivity(string, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]";
            // Make the request
            ComputeFindingsRefinementActivityResponse response = findingsRefinementServiceClient.ComputeFindingsRefinementActivity(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivityAsync</summary>
        public async Task ComputeFindingsRefinementActivityAsync()
        {
            // Snippet: ComputeFindingsRefinementActivityAsync(string, CallSettings)
            // Additional: ComputeFindingsRefinementActivityAsync(string, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/findingsRefinements/[FINDINGS_REFINEMENT]";
            // Make the request
            ComputeFindingsRefinementActivityResponse response = await findingsRefinementServiceClient.ComputeFindingsRefinementActivityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivity</summary>
        public void ComputeFindingsRefinementActivityResourceNames()
        {
            // Snippet: ComputeFindingsRefinementActivity(FindingsRefinementName, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            FindingsRefinementName name = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            ComputeFindingsRefinementActivityResponse response = findingsRefinementServiceClient.ComputeFindingsRefinementActivity(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeFindingsRefinementActivityAsync</summary>
        public async Task ComputeFindingsRefinementActivityResourceNamesAsync()
        {
            // Snippet: ComputeFindingsRefinementActivityAsync(FindingsRefinementName, CallSettings)
            // Additional: ComputeFindingsRefinementActivityAsync(FindingsRefinementName, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindingsRefinementName name = FindingsRefinementName.FromProjectLocationInstanceFindingsRefinement("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[FINDINGS_REFINEMENT]");
            // Make the request
            ComputeFindingsRefinementActivityResponse response = await findingsRefinementServiceClient.ComputeFindingsRefinementActivityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivities</summary>
        public void ComputeAllFindingsRefinementActivitiesRequestObject()
        {
            // Snippet: ComputeAllFindingsRefinementActivities(ComputeAllFindingsRefinementActivitiesRequest, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            ComputeAllFindingsRefinementActivitiesRequest request = new ComputeAllFindingsRefinementActivitiesRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Interval = new Interval(),
            };
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = findingsRefinementServiceClient.ComputeAllFindingsRefinementActivities(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivitiesAsync</summary>
        public async Task ComputeAllFindingsRefinementActivitiesRequestObjectAsync()
        {
            // Snippet: ComputeAllFindingsRefinementActivitiesAsync(ComputeAllFindingsRefinementActivitiesRequest, CallSettings)
            // Additional: ComputeAllFindingsRefinementActivitiesAsync(ComputeAllFindingsRefinementActivitiesRequest, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ComputeAllFindingsRefinementActivitiesRequest request = new ComputeAllFindingsRefinementActivitiesRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Interval = new Interval(),
            };
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = await findingsRefinementServiceClient.ComputeAllFindingsRefinementActivitiesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivities</summary>
        public void ComputeAllFindingsRefinementActivities()
        {
            // Snippet: ComputeAllFindingsRefinementActivities(string, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = findingsRefinementServiceClient.ComputeAllFindingsRefinementActivities(instance);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivitiesAsync</summary>
        public async Task ComputeAllFindingsRefinementActivitiesAsync()
        {
            // Snippet: ComputeAllFindingsRefinementActivitiesAsync(string, CallSettings)
            // Additional: ComputeAllFindingsRefinementActivitiesAsync(string, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = await findingsRefinementServiceClient.ComputeAllFindingsRefinementActivitiesAsync(instance);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivities</summary>
        public void ComputeAllFindingsRefinementActivitiesResourceNames()
        {
            // Snippet: ComputeAllFindingsRefinementActivities(InstanceName, CallSettings)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = FindingsRefinementServiceClient.Create();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = findingsRefinementServiceClient.ComputeAllFindingsRefinementActivities(instance);
            // End snippet
        }

        /// <summary>Snippet for ComputeAllFindingsRefinementActivitiesAsync</summary>
        public async Task ComputeAllFindingsRefinementActivitiesResourceNamesAsync()
        {
            // Snippet: ComputeAllFindingsRefinementActivitiesAsync(InstanceName, CallSettings)
            // Additional: ComputeAllFindingsRefinementActivitiesAsync(InstanceName, CancellationToken)
            // Create client
            FindingsRefinementServiceClient findingsRefinementServiceClient = await FindingsRefinementServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            ComputeAllFindingsRefinementActivitiesResponse response = await findingsRefinementServiceClient.ComputeAllFindingsRefinementActivitiesAsync(instance);
            // End snippet
        }
    }
}
