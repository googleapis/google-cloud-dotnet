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
    public sealed class AllGeneratedInstantSnapshotGroupsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            DeleteInstantSnapshotGroupRequest request = new DeleteInstantSnapshotGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInstantSnapshotGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstantSnapshotGroupRequest request = new DeleteInstantSnapshotGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotGroupsClient.PollOnceDeleteAsync(operationName);
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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshotGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotGroupsClient.Delete(project, zone, instantSnapshotGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotGroupsClient.PollOnceDelete(operationName);
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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshotGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotGroupsClient.DeleteAsync(project, zone, instantSnapshotGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            GetInstantSnapshotGroupRequest request = new GetInstantSnapshotGroupRequest
            {
                Zone = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            InstantSnapshotGroup response = instantSnapshotGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstantSnapshotGroupRequest, CallSettings)
            // Additional: GetAsync(GetInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetInstantSnapshotGroupRequest request = new GetInstantSnapshotGroupRequest
            {
                Zone = "",
                InstantSnapshotGroup = "",
                Project = "",
            };
            // Make the request
            InstantSnapshotGroup response = await instantSnapshotGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshotGroup = "";
            // Make the request
            InstantSnapshotGroup response = instantSnapshotGroupsClient.Get(project, zone, instantSnapshotGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshotGroup = "";
            // Make the request
            InstantSnapshotGroup response = await instantSnapshotGroupsClient.GetAsync(project, zone, instantSnapshotGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyInstantSnapshotGroupRequest request = new GetIamPolicyInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = instantSnapshotGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyInstantSnapshotGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyInstantSnapshotGroupRequest request = new GetIamPolicyInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await instantSnapshotGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = instantSnapshotGroupsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await instantSnapshotGroupsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            InsertInstantSnapshotGroupRequest request = new InsertInstantSnapshotGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstantSnapshotGroupResource = new InstantSnapshotGroup(),
                Project = "",
                SourceConsistencyGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInstantSnapshotGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstantSnapshotGroupRequest request = new InsertInstantSnapshotGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstantSnapshotGroupResource = new InstantSnapshotGroup(),
                Project = "",
                SourceConsistencyGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotGroupsClient.PollOnceInsertAsync(operationName);
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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstantSnapshotGroup instantSnapshotGroupResource = new InstantSnapshotGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotGroupsClient.Insert(project, zone, instantSnapshotGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotGroupsClient.PollOnceInsert(operationName);
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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstantSnapshotGroup instantSnapshotGroupResource = new InstantSnapshotGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotGroupsClient.InsertAsync(project, zone, instantSnapshotGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInstantSnapshotGroupsRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            ListInstantSnapshotGroupsRequest request = new ListInstantSnapshotGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = instantSnapshotGroupsClient.List(request);

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
            // Snippet: ListAsync(ListInstantSnapshotGroupsRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstantSnapshotGroupsRequest request = new ListInstantSnapshotGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = instantSnapshotGroupsClient.ListAsync(request);

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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = instantSnapshotGroupsClient.List(project, zone);

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
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<ListInstantSnapshotGroups, InstantSnapshotGroup> response = instantSnapshotGroupsClient.ListAsync(project, zone);

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
            // Snippet: SetIamPolicy(SetIamPolicyInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyInstantSnapshotGroupRequest request = new SetIamPolicyInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = instantSnapshotGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyInstantSnapshotGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyInstantSnapshotGroupRequest request = new SetIamPolicyInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await instantSnapshotGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = instantSnapshotGroupsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await instantSnapshotGroupsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsInstantSnapshotGroupRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsInstantSnapshotGroupRequest request = new TestIamPermissionsInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = instantSnapshotGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsInstantSnapshotGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsInstantSnapshotGroupRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsInstantSnapshotGroupRequest request = new TestIamPermissionsInstantSnapshotGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await instantSnapshotGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = InstantSnapshotGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = instantSnapshotGroupsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            InstantSnapshotGroupsClient instantSnapshotGroupsClient = await InstantSnapshotGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await instantSnapshotGroupsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
