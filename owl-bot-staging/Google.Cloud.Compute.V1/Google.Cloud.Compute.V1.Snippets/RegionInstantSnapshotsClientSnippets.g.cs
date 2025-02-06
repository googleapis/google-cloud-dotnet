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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionInstantSnapshotsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            DeleteRegionInstantSnapshotRequest request = new DeleteRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionInstantSnapshotRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionInstantSnapshotRequest request = new DeleteRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.Delete(project, region, instantSnapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceDelete(operationName);
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.DeleteAsync(project, region, instantSnapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            GetRegionInstantSnapshotRequest request = new GetRegionInstantSnapshotRequest
            {
                Region = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            InstantSnapshot response = regionInstantSnapshotsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstantSnapshotRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstantSnapshotRequest request = new GetRegionInstantSnapshotRequest
            {
                Region = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            InstantSnapshot response = await regionInstantSnapshotsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshot = "";
            // Make the request
            InstantSnapshot response = regionInstantSnapshotsClient.Get(project, region, instantSnapshot);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instantSnapshot = "";
            // Make the request
            InstantSnapshot response = await regionInstantSnapshotsClient.GetAsync(project, region, instantSnapshot);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionInstantSnapshotRequest request = new GetIamPolicyRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionInstantSnapshotsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionInstantSnapshotRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionInstantSnapshotRequest request = new GetIamPolicyRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionInstantSnapshotsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionInstantSnapshotsClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionInstantSnapshotsClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            InsertRegionInstantSnapshotRequest request = new InsertRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstantSnapshotResource = new InstantSnapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionInstantSnapshotRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionInstantSnapshotRequest request = new InsertRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                InstantSnapshotResource = new InstantSnapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InstantSnapshot, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstantSnapshot instantSnapshotResource = new InstantSnapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.Insert(project, region, instantSnapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InstantSnapshot, CallSettings)
            // Additional: InsertAsync(string, string, InstantSnapshot, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            InstantSnapshot instantSnapshotResource = new InstantSnapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.InsertAsync(project, region, instantSnapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionInstantSnapshotsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            ListRegionInstantSnapshotsRequest request = new ListRegionInstantSnapshotsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstantSnapshotList, InstantSnapshot> response = regionInstantSnapshotsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            // Snippet: ListAsync(ListRegionInstantSnapshotsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstantSnapshotsRequest request = new ListRegionInstantSnapshotsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotList, InstantSnapshot> response = regionInstantSnapshotsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstantSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<InstantSnapshotList, InstantSnapshot> response = regionInstantSnapshotsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotList, InstantSnapshot> response = regionInstantSnapshotsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstantSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            // Snippet: SetIamPolicy(SetIamPolicyRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionInstantSnapshotRequest request = new SetIamPolicyRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionInstantSnapshotsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionInstantSnapshotRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionInstantSnapshotRequest request = new SetIamPolicyRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionInstantSnapshotsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionInstantSnapshotsClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionInstantSnapshotsClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            SetLabelsRegionInstantSnapshotRequest request = new SetLabelsRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsRegionInstantSnapshotRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRegionInstantSnapshotRequest request = new SetLabelsRegionInstantSnapshotRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceSetLabelsAsync(operationName);
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionInstantSnapshotsClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionInstantSnapshotsClient.PollOnceSetLabels(operationName);
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
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionInstantSnapshotsClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionInstantSnapshotsClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsRegionInstantSnapshotRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionInstantSnapshotRequest request = new TestIamPermissionsRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionInstantSnapshotsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionInstantSnapshotRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionInstantSnapshotRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionInstantSnapshotRequest request = new TestIamPermissionsRegionInstantSnapshotRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionInstantSnapshotsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = RegionInstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionInstantSnapshotsClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionInstantSnapshotsClient regionInstantSnapshotsClient = await RegionInstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionInstantSnapshotsClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
