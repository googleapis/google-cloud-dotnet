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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDisksClientSnippets
    {
        /// <summary>Snippet for AddResourcePolicies</summary>
        public void AddResourcePoliciesRequestObject()
        {
            // Snippet: AddResourcePolicies(AddResourcePoliciesDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            AddResourcePoliciesDiskRequest request = new AddResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.AddResourcePolicies(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceAddResourcePolicies(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddResourcePoliciesAsync</summary>
        public async Task AddResourcePoliciesRequestObjectAsync()
        {
            // Snippet: AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(AddResourcePoliciesDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            AddResourcePoliciesDiskRequest request = new AddResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.AddResourcePoliciesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceAddResourcePoliciesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddResourcePolicies</summary>
        public void AddResourcePolicies()
        {
            // Snippet: AddResourcePolicies(string, string, string, DisksAddResourcePoliciesRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.AddResourcePolicies(project, zone, disk, disksAddResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceAddResourcePolicies(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddResourcePoliciesAsync</summary>
        public async Task AddResourcePoliciesAsync()
        {
            // Snippet: AddResourcePoliciesAsync(string, string, string, DisksAddResourcePoliciesRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(string, string, string, DisksAddResourcePoliciesRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksAddResourcePoliciesRequest disksAddResourcePoliciesRequestResource = new DisksAddResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.AddResourcePoliciesAsync(project, zone, disk, disksAddResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceAddResourcePoliciesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<DiskAggregatedList, KeyValuePair<string, DisksScopedList>> response = disksClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, DisksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (DiskAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, DisksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, DisksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, DisksScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListDisksRequest request = new AggregatedListDisksRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<DiskAggregatedList, KeyValuePair<string, DisksScopedList>> response = disksClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, DisksScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((DiskAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, DisksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, DisksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, DisksScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<DiskAggregatedList, KeyValuePair<string, DisksScopedList>> response = disksClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, DisksScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (DiskAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, DisksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, DisksScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, DisksScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<DiskAggregatedList, KeyValuePair<string, DisksScopedList>> response = disksClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, DisksScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((DiskAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, DisksScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, DisksScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, DisksScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BulkInsert</summary>
        public void BulkInsertRequestObject()
        {
            // Snippet: BulkInsert(BulkInsertDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            BulkInsertDiskRequest request = new BulkInsertDiskRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                BulkInsertDiskResourceResource = new BulkInsertDiskResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.BulkInsert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceBulkInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsertAsync</summary>
        public async Task BulkInsertRequestObjectAsync()
        {
            // Snippet: BulkInsertAsync(BulkInsertDiskRequest, CallSettings)
            // Additional: BulkInsertAsync(BulkInsertDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            BulkInsertDiskRequest request = new BulkInsertDiskRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                BulkInsertDiskResourceResource = new BulkInsertDiskResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.BulkInsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceBulkInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsert</summary>
        public void BulkInsert()
        {
            // Snippet: BulkInsert(string, string, BulkInsertDiskResource, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            BulkInsertDiskResource bulkInsertDiskResourceResource = new BulkInsertDiskResource();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.BulkInsert(project, zone, bulkInsertDiskResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceBulkInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsertAsync</summary>
        public async Task BulkInsertAsync()
        {
            // Snippet: BulkInsertAsync(string, string, BulkInsertDiskResource, CallSettings)
            // Additional: BulkInsertAsync(string, string, BulkInsertDiskResource, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            BulkInsertDiskResource bulkInsertDiskResourceResource = new BulkInsertDiskResource();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.BulkInsertAsync(project, zone, bulkInsertDiskResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceBulkInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshotRequestObject()
        {
            // Snippet: CreateSnapshot(CreateSnapshotDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            CreateSnapshotDiskRequest request = new CreateSnapshotDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                GuestFlush = false,
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.CreateSnapshot(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceCreateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotRequestObjectAsync()
        {
            // Snippet: CreateSnapshotAsync(CreateSnapshotDiskRequest, CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotDiskRequest request = new CreateSnapshotDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                GuestFlush = false,
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.CreateSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceCreateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshot</summary>
        public void CreateSnapshot()
        {
            // Snippet: CreateSnapshot(string, string, string, Snapshot, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.CreateSnapshot(project, zone, disk, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceCreateSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSnapshotAsync</summary>
        public async Task CreateSnapshotAsync()
        {
            // Snippet: CreateSnapshotAsync(string, string, string, Snapshot, CallSettings)
            // Additional: CreateSnapshotAsync(string, string, string, Snapshot, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.CreateSnapshotAsync(project, zone, disk, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceCreateSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            DeleteDiskRequest request = new DeleteDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteDiskRequest, CallSettings)
            // Additional: DeleteAsync(DeleteDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDiskRequest request = new DeleteDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceDeleteAsync(operationName);
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
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Delete(project, zone, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceDelete(operationName);
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
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.DeleteAsync(project, zone, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "",
                Zone = "",
                Project = "",
            };
            // Make the request
            Disk response = disksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetDiskRequest, CallSettings)
            // Additional: GetAsync(GetDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            GetDiskRequest request = new GetDiskRequest
            {
                Disk = "",
                Zone = "",
                Project = "",
            };
            // Make the request
            Disk response = await disksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Disk response = disksClient.Get(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            Disk response = await disksClient.GetAsync(project, zone, disk);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = disksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyDiskRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyDiskRequest request = new GetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await disksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = disksClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await disksClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertDiskRequest, CallSettings)
            // Additional: InsertAsync(InsertDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            InsertDiskRequest request = new InsertDiskRequest
            {
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Disk, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Insert(project, zone, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Disk, CallSettings)
            // Additional: InsertAsync(string, string, Disk, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.InsertAsync(project, zone, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            ListDisksRequest request = new ListDisksRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<DiskList, Disk> response = disksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Disk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (DiskList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Disk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Disk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Disk item in singlePage)
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
            // Snippet: ListAsync(ListDisksRequest, CallSettings)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            ListDisksRequest request = new ListDisksRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<DiskList, Disk> response = disksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Disk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((DiskList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Disk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Disk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Disk item in singlePage)
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
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<DiskList, Disk> response = disksClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Disk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (DiskList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Disk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Disk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Disk item in singlePage)
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
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<DiskList, Disk> response = disksClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Disk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((DiskList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Disk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Disk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Disk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePolicies</summary>
        public void RemoveResourcePoliciesRequestObject()
        {
            // Snippet: RemoveResourcePolicies(RemoveResourcePoliciesDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            RemoveResourcePoliciesDiskRequest request = new RemoveResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.RemoveResourcePolicies(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceRemoveResourcePolicies(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePoliciesAsync</summary>
        public async Task RemoveResourcePoliciesRequestObjectAsync()
        {
            // Snippet: RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(RemoveResourcePoliciesDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            RemoveResourcePoliciesDiskRequest request = new RemoveResourcePoliciesDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.RemoveResourcePoliciesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceRemoveResourcePoliciesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePolicies</summary>
        public void RemoveResourcePolicies()
        {
            // Snippet: RemoveResourcePolicies(string, string, string, DisksRemoveResourcePoliciesRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.RemoveResourcePolicies(project, zone, disk, disksRemoveResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceRemoveResourcePolicies(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveResourcePoliciesAsync</summary>
        public async Task RemoveResourcePoliciesAsync()
        {
            // Snippet: RemoveResourcePoliciesAsync(string, string, string, DisksRemoveResourcePoliciesRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(string, string, string, DisksRemoveResourcePoliciesRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksRemoveResourcePoliciesRequest disksRemoveResourcePoliciesRequestResource = new DisksRemoveResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.RemoveResourcePoliciesAsync(project, zone, disk, disksRemoveResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceRemoveResourcePoliciesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            ResizeDiskRequest request = new ResizeDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksResizeRequestResource = new DisksResizeRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Resize(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeDiskRequest, CallSettings)
            // Additional: ResizeAsync(ResizeDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            ResizeDiskRequest request = new ResizeDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                DisksResizeRequestResource = new DisksResizeRequest(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.ResizeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, DisksResizeRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksResizeRequest disksResizeRequestResource = new DisksResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Resize(project, zone, disk, disksResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, DisksResizeRequest, CallSettings)
            // Additional: ResizeAsync(string, string, string, DisksResizeRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksResizeRequest disksResizeRequestResource = new DisksResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.ResizeAsync(project, zone, disk, disksResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = disksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyDiskRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyDiskRequest request = new SetIamPolicyDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await disksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = disksClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await disksClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            SetLabelsDiskRequest request = new SetLabelsDiskRequest
            {
                Zone = "",
                RequestId = "",
                Resource = "",
                Project = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsDiskRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsDiskRequest request = new SetLabelsDiskRequest
            {
                Zone = "",
                RequestId = "",
                Resource = "",
                Project = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: SetLabels(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.SetLabels(project, zone, resource, zoneSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.SetLabelsAsync(project, zone, resource, zoneSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAsyncReplication</summary>
        public void StartAsyncReplicationRequestObject()
        {
            // Snippet: StartAsyncReplication(StartAsyncReplicationDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            StartAsyncReplicationDiskRequest request = new StartAsyncReplicationDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksStartAsyncReplicationRequestResource = new DisksStartAsyncReplicationRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StartAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStartAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAsyncReplicationAsync</summary>
        public async Task StartAsyncReplicationRequestObjectAsync()
        {
            // Snippet: StartAsyncReplicationAsync(StartAsyncReplicationDiskRequest, CallSettings)
            // Additional: StartAsyncReplicationAsync(StartAsyncReplicationDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            StartAsyncReplicationDiskRequest request = new StartAsyncReplicationDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
                DisksStartAsyncReplicationRequestResource = new DisksStartAsyncReplicationRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StartAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStartAsyncReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAsyncReplication</summary>
        public void StartAsyncReplication()
        {
            // Snippet: StartAsyncReplication(string, string, string, DisksStartAsyncReplicationRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksStartAsyncReplicationRequest disksStartAsyncReplicationRequestResource = new DisksStartAsyncReplicationRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StartAsyncReplication(project, zone, disk, disksStartAsyncReplicationRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStartAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAsyncReplicationAsync</summary>
        public async Task StartAsyncReplicationAsync()
        {
            // Snippet: StartAsyncReplicationAsync(string, string, string, DisksStartAsyncReplicationRequest, CallSettings)
            // Additional: StartAsyncReplicationAsync(string, string, string, DisksStartAsyncReplicationRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            DisksStartAsyncReplicationRequest disksStartAsyncReplicationRequestResource = new DisksStartAsyncReplicationRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StartAsyncReplicationAsync(project, zone, disk, disksStartAsyncReplicationRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStartAsyncReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAsyncReplication</summary>
        public void StopAsyncReplicationRequestObject()
        {
            // Snippet: StopAsyncReplication(StopAsyncReplicationDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            StopAsyncReplicationDiskRequest request = new StopAsyncReplicationDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StopAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStopAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAsyncReplicationAsync</summary>
        public async Task StopAsyncReplicationRequestObjectAsync()
        {
            // Snippet: StopAsyncReplicationAsync(StopAsyncReplicationDiskRequest, CallSettings)
            // Additional: StopAsyncReplicationAsync(StopAsyncReplicationDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            StopAsyncReplicationDiskRequest request = new StopAsyncReplicationDiskRequest
            {
                Disk = "",
                Zone = "",
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StopAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStopAsyncReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAsyncReplication</summary>
        public void StopAsyncReplication()
        {
            // Snippet: StopAsyncReplication(string, string, string, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StopAsyncReplication(project, zone, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStopAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAsyncReplicationAsync</summary>
        public async Task StopAsyncReplicationAsync()
        {
            // Snippet: StopAsyncReplicationAsync(string, string, string, CallSettings)
            // Additional: StopAsyncReplicationAsync(string, string, string, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StopAsyncReplicationAsync(project, zone, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStopAsyncReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopGroupAsyncReplication</summary>
        public void StopGroupAsyncReplicationRequestObject()
        {
            // Snippet: StopGroupAsyncReplication(StopGroupAsyncReplicationDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            StopGroupAsyncReplicationDiskRequest request = new StopGroupAsyncReplicationDiskRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                DisksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StopGroupAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStopGroupAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopGroupAsyncReplicationAsync</summary>
        public async Task StopGroupAsyncReplicationRequestObjectAsync()
        {
            // Snippet: StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationDiskRequest, CallSettings)
            // Additional: StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            StopGroupAsyncReplicationDiskRequest request = new StopGroupAsyncReplicationDiskRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                DisksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StopGroupAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStopGroupAsyncReplicationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopGroupAsyncReplication</summary>
        public void StopGroupAsyncReplication()
        {
            // Snippet: StopGroupAsyncReplication(string, string, DisksStopGroupAsyncReplicationResource, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.StopGroupAsyncReplication(project, zone, disksStopGroupAsyncReplicationResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceStopGroupAsyncReplication(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopGroupAsyncReplicationAsync</summary>
        public async Task StopGroupAsyncReplicationAsync()
        {
            // Snippet: StopGroupAsyncReplicationAsync(string, string, DisksStopGroupAsyncReplicationResource, CallSettings)
            // Additional: StopGroupAsyncReplicationAsync(string, string, DisksStopGroupAsyncReplicationResource, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.StopGroupAsyncReplicationAsync(project, zone, disksStopGroupAsyncReplicationResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceStopGroupAsyncReplicationAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = disksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsDiskRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsDiskRequest request = new TestIamPermissionsDiskRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await disksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = disksClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await disksClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateDiskRequest, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            UpdateDiskRequest request = new UpdateDiskRequest
            {
                Disk = "",
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                Paths = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateDiskRequest, CallSettings)
            // Additional: UpdateAsync(UpdateDiskRequest, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDiskRequest request = new UpdateDiskRequest
            {
                Disk = "",
                Zone = "",
                DiskResource = new Disk(),
                RequestId = "",
                Paths = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, string, Disk, CallSettings)
            // Create client
            DisksClient disksClient = DisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = disksClient.Update(project, zone, disk, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = disksClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, string, Disk, CallSettings)
            // Additional: UpdateAsync(string, string, string, Disk, CancellationToken)
            // Create client
            DisksClient disksClient = await DisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string disk = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = await disksClient.UpdateAsync(project, zone, disk, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await disksClient.PollOnceUpdateAsync(operationName);
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
