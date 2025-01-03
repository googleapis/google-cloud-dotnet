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
    using Google.Cloud.AssuredWorkloads.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAssuredWorkloadsServiceClientSnippets
    {
        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkloadRequestObject()
        {
            // Snippet: CreateWorkload(CreateWorkloadRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Workload = new Workload(),
                ExternalId = "",
            };
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = assuredWorkloadsServiceClient.CreateWorkload(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = assuredWorkloadsServiceClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadRequestObjectAsync()
        {
            // Snippet: CreateWorkloadAsync(CreateWorkloadRequest, CallSettings)
            // Additional: CreateWorkloadAsync(CreateWorkloadRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkloadRequest request = new CreateWorkloadRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Workload = new Workload(),
                ExternalId = "",
            };
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = await assuredWorkloadsServiceClient.CreateWorkloadAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = await assuredWorkloadsServiceClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkload()
        {
            // Snippet: CreateWorkload(string, Workload, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Workload workload = new Workload();
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = assuredWorkloadsServiceClient.CreateWorkload(parent, workload);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = assuredWorkloadsServiceClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadAsync()
        {
            // Snippet: CreateWorkloadAsync(string, Workload, CallSettings)
            // Additional: CreateWorkloadAsync(string, Workload, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            Workload workload = new Workload();
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = await assuredWorkloadsServiceClient.CreateWorkloadAsync(parent, workload);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = await assuredWorkloadsServiceClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkload</summary>
        public void CreateWorkloadResourceNames()
        {
            // Snippet: CreateWorkload(LocationName, Workload, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Workload workload = new Workload();
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = assuredWorkloadsServiceClient.CreateWorkload(parent, workload);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = assuredWorkloadsServiceClient.PollOnceCreateWorkload(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkloadAsync</summary>
        public async Task CreateWorkloadResourceNamesAsync()
        {
            // Snippet: CreateWorkloadAsync(LocationName, Workload, CallSettings)
            // Additional: CreateWorkloadAsync(LocationName, Workload, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Workload workload = new Workload();
            // Make the request
            Operation<Workload, CreateWorkloadOperationMetadata> response = await assuredWorkloadsServiceClient.CreateWorkloadAsync(parent, workload);

            // Poll until the returned long-running operation is complete
            Operation<Workload, CreateWorkloadOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workload result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workload, CreateWorkloadOperationMetadata> retrievedResponse = await assuredWorkloadsServiceClient.PollOnceCreateWorkloadAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workload retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkload</summary>
        public void UpdateWorkloadRequestObject()
        {
            // Snippet: UpdateWorkload(UpdateWorkloadRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Workload response = assuredWorkloadsServiceClient.UpdateWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadAsync</summary>
        public async Task UpdateWorkloadRequestObjectAsync()
        {
            // Snippet: UpdateWorkloadAsync(UpdateWorkloadRequest, CallSettings)
            // Additional: UpdateWorkloadAsync(UpdateWorkloadRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkloadRequest request = new UpdateWorkloadRequest
            {
                Workload = new Workload(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.UpdateWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkload</summary>
        public void UpdateWorkload()
        {
            // Snippet: UpdateWorkload(Workload, FieldMask, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            Workload workload = new Workload();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Workload response = assuredWorkloadsServiceClient.UpdateWorkload(workload, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkloadAsync</summary>
        public async Task UpdateWorkloadAsync()
        {
            // Snippet: UpdateWorkloadAsync(Workload, FieldMask, CallSettings)
            // Additional: UpdateWorkloadAsync(Workload, FieldMask, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Workload workload = new Workload();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.UpdateWorkloadAsync(workload, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RestrictAllowedResources</summary>
        public void RestrictAllowedResourcesRequestObject()
        {
            // Snippet: RestrictAllowedResources(RestrictAllowedResourcesRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            RestrictAllowedResourcesRequest request = new RestrictAllowedResourcesRequest
            {
                Name = "",
                RestrictionType = RestrictAllowedResourcesRequest.Types.RestrictionType.Unspecified,
            };
            // Make the request
            RestrictAllowedResourcesResponse response = assuredWorkloadsServiceClient.RestrictAllowedResources(request);
            // End snippet
        }

        /// <summary>Snippet for RestrictAllowedResourcesAsync</summary>
        public async Task RestrictAllowedResourcesRequestObjectAsync()
        {
            // Snippet: RestrictAllowedResourcesAsync(RestrictAllowedResourcesRequest, CallSettings)
            // Additional: RestrictAllowedResourcesAsync(RestrictAllowedResourcesRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestrictAllowedResourcesRequest request = new RestrictAllowedResourcesRequest
            {
                Name = "",
                RestrictionType = RestrictAllowedResourcesRequest.Types.RestrictionType.Unspecified,
            };
            // Make the request
            RestrictAllowedResourcesResponse response = await assuredWorkloadsServiceClient.RestrictAllowedResourcesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkloadRequestObject()
        {
            // Snippet: DeleteWorkload(DeleteWorkloadRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Etag = "",
            };
            // Make the request
            assuredWorkloadsServiceClient.DeleteWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadRequestObjectAsync()
        {
            // Snippet: DeleteWorkloadAsync(DeleteWorkloadRequest, CallSettings)
            // Additional: DeleteWorkloadAsync(DeleteWorkloadRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkloadRequest request = new DeleteWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Etag = "",
            };
            // Make the request
            await assuredWorkloadsServiceClient.DeleteWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkload()
        {
            // Snippet: DeleteWorkload(string, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            assuredWorkloadsServiceClient.DeleteWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadAsync()
        {
            // Snippet: DeleteWorkloadAsync(string, CallSettings)
            // Additional: DeleteWorkloadAsync(string, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            await assuredWorkloadsServiceClient.DeleteWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkload</summary>
        public void DeleteWorkloadResourceNames()
        {
            // Snippet: DeleteWorkload(WorkloadName, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            assuredWorkloadsServiceClient.DeleteWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkloadAsync</summary>
        public async Task DeleteWorkloadResourceNamesAsync()
        {
            // Snippet: DeleteWorkloadAsync(WorkloadName, CallSettings)
            // Additional: DeleteWorkloadAsync(WorkloadName, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            await assuredWorkloadsServiceClient.DeleteWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadRequestObject()
        {
            // Snippet: GetWorkload(GetWorkloadRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = assuredWorkloadsServiceClient.GetWorkload(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadRequestObjectAsync()
        {
            // Snippet: GetWorkloadAsync(GetWorkloadRequest, CallSettings)
            // Additional: GetWorkloadAsync(GetWorkloadRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkloadRequest request = new GetWorkloadRequest
            {
                WorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
            };
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.GetWorkloadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkload()
        {
            // Snippet: GetWorkload(string, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = assuredWorkloadsServiceClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadAsync()
        {
            // Snippet: GetWorkloadAsync(string, CallSettings)
            // Additional: GetWorkloadAsync(string, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkload</summary>
        public void GetWorkloadResourceNames()
        {
            // Snippet: GetWorkload(WorkloadName, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            Workload response = assuredWorkloadsServiceClient.GetWorkload(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkloadAsync</summary>
        public async Task GetWorkloadResourceNamesAsync()
        {
            // Snippet: GetWorkloadAsync(WorkloadName, CallSettings)
            // Additional: GetWorkloadAsync(WorkloadName, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName name = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            Workload response = await assuredWorkloadsServiceClient.GetWorkloadAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsRequestObject()
        {
            // Snippet: ListWorkloads(ListWorkloadsRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloads(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsRequestObjectAsync()
        {
            // Snippet: ListWorkloadsAsync(ListWorkloadsRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkloadsRequest request = new ListWorkloadsRequest
            {
                ParentAsLocationName = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloadsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloads()
        {
            // Snippet: ListWorkloads(string, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsAsync()
        {
            // Snippet: ListWorkloadsAsync(string, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsResourceNames()
        {
            // Snippet: ListWorkloads(LocationName, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsResourceNamesAsync()
        {
            // Snippet: ListWorkloadsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListWorkloadsResponse, Workload> response = assuredWorkloadsServiceClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolations</summary>
        public void ListViolationsRequestObject()
        {
            // Snippet: ListViolations(ListViolationsRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Interval = new TimeWindow(),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsRequestObjectAsync()
        {
            // Snippet: ListViolationsAsync(ListViolationsRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListViolationsRequest request = new ListViolationsRequest
            {
                ParentAsWorkloadName = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]"),
                Interval = new TimeWindow(),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolations</summary>
        public void ListViolations()
        {
            // Snippet: ListViolations(string, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsAsync()
        {
            // Snippet: ListViolationsAsync(string, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]";
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolations</summary>
        public void ListViolationsResourceNames()
        {
            // Snippet: ListViolations(WorkloadName, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            PagedEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Violation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViolationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViolationsAsync</summary>
        public async Task ListViolationsResourceNamesAsync()
        {
            // Snippet: ListViolationsAsync(WorkloadName, string, int?, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkloadName parent = WorkloadName.FromOrganizationLocationWorkload("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]");
            // Make the request
            PagedAsyncEnumerable<ListViolationsResponse, Violation> response = assuredWorkloadsServiceClient.ListViolationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Violation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViolationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Violation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Violation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Violation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolationRequestObject()
        {
            // Snippet: GetViolation(GetViolationRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            // Make the request
            Violation response = assuredWorkloadsServiceClient.GetViolation(request);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationRequestObjectAsync()
        {
            // Snippet: GetViolationAsync(GetViolationRequest, CallSettings)
            // Additional: GetViolationAsync(GetViolationRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetViolationRequest request = new GetViolationRequest
            {
                ViolationName = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]"),
            };
            // Make the request
            Violation response = await assuredWorkloadsServiceClient.GetViolationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolation()
        {
            // Snippet: GetViolation(string, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]/violations/[VIOLATION]";
            // Make the request
            Violation response = assuredWorkloadsServiceClient.GetViolation(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationAsync()
        {
            // Snippet: GetViolationAsync(string, CallSettings)
            // Additional: GetViolationAsync(string, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/workloads/[WORKLOAD]/violations/[VIOLATION]";
            // Make the request
            Violation response = await assuredWorkloadsServiceClient.GetViolationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolation</summary>
        public void GetViolationResourceNames()
        {
            // Snippet: GetViolation(ViolationName, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            ViolationName name = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]");
            // Make the request
            Violation response = assuredWorkloadsServiceClient.GetViolation(name);
            // End snippet
        }

        /// <summary>Snippet for GetViolationAsync</summary>
        public async Task GetViolationResourceNamesAsync()
        {
            // Snippet: GetViolationAsync(ViolationName, CallSettings)
            // Additional: GetViolationAsync(ViolationName, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ViolationName name = ViolationName.FromOrganizationLocationWorkloadViolation("[ORGANIZATION]", "[LOCATION]", "[WORKLOAD]", "[VIOLATION]");
            // Make the request
            Violation response = await assuredWorkloadsServiceClient.GetViolationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeViolation</summary>
        public void AcknowledgeViolationRequestObject()
        {
            // Snippet: AcknowledgeViolation(AcknowledgeViolationRequest, CallSettings)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = AssuredWorkloadsServiceClient.Create();
            // Initialize request argument(s)
            AcknowledgeViolationRequest request = new AcknowledgeViolationRequest
            {
                Name = "",
                Comment = "",
            };
            // Make the request
            AcknowledgeViolationResponse response = assuredWorkloadsServiceClient.AcknowledgeViolation(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeViolationAsync</summary>
        public async Task AcknowledgeViolationRequestObjectAsync()
        {
            // Snippet: AcknowledgeViolationAsync(AcknowledgeViolationRequest, CallSettings)
            // Additional: AcknowledgeViolationAsync(AcknowledgeViolationRequest, CancellationToken)
            // Create client
            AssuredWorkloadsServiceClient assuredWorkloadsServiceClient = await AssuredWorkloadsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeViolationRequest request = new AcknowledgeViolationRequest
            {
                Name = "",
                Comment = "",
            };
            // Make the request
            AcknowledgeViolationResponse response = await assuredWorkloadsServiceClient.AcknowledgeViolationAsync(request);
            // End snippet
        }
    }
}
