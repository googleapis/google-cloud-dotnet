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
    public sealed class AllGeneratedRegionSnapshotsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            DeleteRegionSnapshotRequest request = new DeleteRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Snapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionSnapshotRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionSnapshotRequest request = new DeleteRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Snapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.Delete(project, region, snapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceDelete(operationName);
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
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.DeleteAsync(project, region, snapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            GetRegionSnapshotRequest request = new GetRegionSnapshotRequest
            {
                Region = "",
                Project = "",
                Snapshot = "",
            };
            // Make the request
            Snapshot response = regionSnapshotsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionSnapshotRequest, CallSettings)
            // Additional: GetAsync(GetRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionSnapshotRequest request = new GetRegionSnapshotRequest
            {
                Region = "",
                Project = "",
                Snapshot = "",
            };
            // Make the request
            Snapshot response = await regionSnapshotsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            // Make the request
            Snapshot response = regionSnapshotsClient.Get(project, region, snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            // Make the request
            Snapshot response = await regionSnapshotsClient.GetAsync(project, region, snapshot);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionSnapshotRequest request = new GetIamPolicyRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionSnapshotsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionSnapshotRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionSnapshotRequest request = new GetIamPolicyRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionSnapshotsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionSnapshotsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionSnapshotsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            InsertRegionSnapshotRequest request = new InsertRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionSnapshotRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionSnapshotRequest request = new InsertRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Snapshot, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.Insert(project, region, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Snapshot, CallSettings)
            // Additional: InsertAsync(string, string, Snapshot, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.InsertAsync(project, region, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionSnapshotsRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            ListRegionSnapshotsRequest request = new ListRegionSnapshotsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SnapshotList, Snapshot> response = regionSnapshotsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
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
            // Snippet: ListAsync(ListRegionSnapshotsRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionSnapshotsRequest request = new ListRegionSnapshotsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SnapshotList, Snapshot> response = regionSnapshotsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
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
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<SnapshotList, Snapshot> response = regionSnapshotsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
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
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<SnapshotList, Snapshot> response = regionSnapshotsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
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
            // Snippet: SetIamPolicy(SetIamPolicyRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionSnapshotRequest request = new SetIamPolicyRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionSnapshotsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionSnapshotRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionSnapshotRequest request = new SetIamPolicyRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionSnapshotsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionSnapshotsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionSnapshotsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            SetLabelsRegionSnapshotRequest request = new SetLabelsRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsRegionSnapshotRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRegionSnapshotRequest request = new SetLabelsRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, RegionSetLabelsRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionSnapshotRequest request = new TestIamPermissionsRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionSnapshotsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionSnapshotRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionSnapshotRequest request = new TestIamPermissionsRegionSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionSnapshotsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionSnapshotsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionSnapshotsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsKey</summary>
        public void UpdateKmsKeyRequestObject()
        {
            // Snippet: UpdateKmsKey(UpdateKmsKeyRegionSnapshotRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            UpdateKmsKeyRegionSnapshotRequest request = new UpdateKmsKeyRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionSnapshotUpdateKmsKeyRequestResource = new RegionSnapshotUpdateKmsKeyRequest(),
                Snapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.UpdateKmsKey(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceUpdateKmsKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsKeyAsync</summary>
        public async Task UpdateKmsKeyRequestObjectAsync()
        {
            // Snippet: UpdateKmsKeyAsync(UpdateKmsKeyRegionSnapshotRequest, CallSettings)
            // Additional: UpdateKmsKeyAsync(UpdateKmsKeyRegionSnapshotRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKmsKeyRegionSnapshotRequest request = new UpdateKmsKeyRegionSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionSnapshotUpdateKmsKeyRequestResource = new RegionSnapshotUpdateKmsKeyRequest(),
                Snapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.UpdateKmsKeyAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceUpdateKmsKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsKey</summary>
        public void UpdateKmsKey()
        {
            // Snippet: UpdateKmsKey(string, string, string, RegionSnapshotUpdateKmsKeyRequest, CallSettings)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = RegionSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            RegionSnapshotUpdateKmsKeyRequest regionSnapshotUpdateKmsKeyRequestResource = new RegionSnapshotUpdateKmsKeyRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionSnapshotsClient.UpdateKmsKey(project, region, snapshot, regionSnapshotUpdateKmsKeyRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionSnapshotsClient.PollOnceUpdateKmsKey(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateKmsKeyAsync</summary>
        public async Task UpdateKmsKeyAsync()
        {
            // Snippet: UpdateKmsKeyAsync(string, string, string, RegionSnapshotUpdateKmsKeyRequest, CallSettings)
            // Additional: UpdateKmsKeyAsync(string, string, string, RegionSnapshotUpdateKmsKeyRequest, CancellationToken)
            // Create client
            RegionSnapshotsClient regionSnapshotsClient = await RegionSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string snapshot = "";
            RegionSnapshotUpdateKmsKeyRequest regionSnapshotUpdateKmsKeyRequestResource = new RegionSnapshotUpdateKmsKeyRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionSnapshotsClient.UpdateKmsKeyAsync(project, region, snapshot, regionSnapshotUpdateKmsKeyRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionSnapshotsClient.PollOnceUpdateKmsKeyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
