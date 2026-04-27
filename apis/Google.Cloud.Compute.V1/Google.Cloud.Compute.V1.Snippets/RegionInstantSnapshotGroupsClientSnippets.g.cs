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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstantSnapshotGroupsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstantSnapshotGroupRequest request = new DeleteRegionInstantSnapshotGroupRequest
            {
                RequestId = "",
                Region = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotGroupsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstantSnapshotGroupRequest request = new DeleteRegionInstantSnapshotGroupRequest
            {
                RequestId = "",
                Region = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshotGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotGroupsClient.Delete(project, region, instantSnapshotGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotGroupsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshotGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotGroupsClient.DeleteAsync(project, region, instantSnapshotGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            GetRegionInstantSnapshotGroupRequest request = new GetRegionInstantSnapshotGroupRequest
            {
                Region = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            InstantSnapshotGroup response = regionInstantSnapshotGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstantSnapshotGroupRequest request = new GetRegionInstantSnapshotGroupRequest
            {
                Region = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            InstantSnapshotGroup response = await regionInstantSnapshotGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshotGroup = "";
            // Make the request
            InstantSnapshotGroup response = regionInstantSnapshotGroupsClient.Get(project, region, instantSnapshotGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshotGroup = "";
            // Make the request
            InstantSnapshotGroup response = await regionInstantSnapshotGroupsClient.GetAsync(project, region, instantSnapshotGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionInstantSnapshotGroupRequest request = new GetIamPolicyRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionInstantSnapshotGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionInstantSnapshotGroupRequest request = new GetIamPolicyRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionInstantSnapshotGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionInstantSnapshotGroupsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionInstantSnapshotGroupsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            InsertRegionInstantSnapshotGroupRequest request = new InsertRegionInstantSnapshotGroupRequest
            {
                RequestId = "",
                Region = "",
                InstantSnapshotGroupResource = new InstantSnapshotGroup(),
                Project = "",
                SourceConsistencyGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotGroupsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstantSnapshotGroupRequest request = new InsertRegionInstantSnapshotGroupRequest
            {
                RequestId = "",
                Region = "",
                InstantSnapshotGroupResource = new InstantSnapshotGroup(),
                Project = "",
                SourceConsistencyGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotGroupsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InstantSnapshotGroup, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstantSnapshotGroup instantSnapshotGroupResource = new InstantSnapshotGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotGroupsClient.Insert(project, region, instantSnapshotGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotGroupsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InstantSnapshotGroup, CallSettings)
            // Additional: InsertAsync(string, string, InstantSnapshotGroup, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstantSnapshotGroup instantSnapshotGroupResource = new InstantSnapshotGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotGroupsClient.InsertAsync(project, region, instantSnapshotGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotGroupsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionInstantSnapshotGroupsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            ListRegionInstantSnapshotGroupsRequest request = new ListRegionInstantSnapshotGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = regionInstantSnapshotGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshotGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstantSnapshotGroups page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshotGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshotGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshotGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionInstantSnapshotGroupsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstantSnapshotGroupsRequest request = new ListRegionInstantSnapshotGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = regionInstantSnapshotGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InstantSnapshotGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInstantSnapshotGroups page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshotGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshotGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshotGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = regionInstantSnapshotGroupsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshotGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstantSnapshotGroups page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshotGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshotGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshotGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = regionInstantSnapshotGroupsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InstantSnapshotGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInstantSnapshotGroups page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshotGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshotGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshotGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionInstantSnapshotGroupRequest request = new SetIamPolicyRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionInstantSnapshotGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionInstantSnapshotGroupRequest request = new SetIamPolicyRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionInstantSnapshotGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionInstantSnapshotGroupsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionInstantSnapshotGroupsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRegionInstantSnapshotGroupRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionInstantSnapshotGroupRequest request = new TestIamPermissionsRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionInstantSnapshotGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionInstantSnapshotGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionInstantSnapshotGroupRequest request = new TestIamPermissionsRegionInstantSnapshotGroupRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionInstantSnapshotGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = RegionInstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionInstantSnapshotGroupsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotGroupsClient regionInstantSnapshotGroupsClient = await RegionInstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionInstantSnapshotGroupsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
