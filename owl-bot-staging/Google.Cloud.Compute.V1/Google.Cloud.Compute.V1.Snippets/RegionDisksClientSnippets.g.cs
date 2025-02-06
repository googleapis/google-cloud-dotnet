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
    public sealed class AllGeneratedRegionDisksClientSnippets
    {
        /// <summary>Snippet for AddResourcePolicies</summary>
        public void AddResourcePoliciesRequestObject()
        {
            // Snippet: AddResourcePolicies(AddResourcePoliciesRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            AddResourcePoliciesRegionDiskRequest request = new AddResourcePoliciesRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksAddResourcePoliciesRequestResource = new RegionDisksAddResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.AddResourcePolicies(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceAddResourcePolicies(operationName);
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
            // Snippet: AddResourcePoliciesAsync(AddResourcePoliciesRegionDiskRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(AddResourcePoliciesRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            AddResourcePoliciesRegionDiskRequest request = new AddResourcePoliciesRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksAddResourcePoliciesRequestResource = new RegionDisksAddResourcePoliciesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.AddResourcePoliciesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceAddResourcePoliciesAsync(operationName);
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
            // Snippet: AddResourcePolicies(string, string, string, RegionDisksAddResourcePoliciesRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksAddResourcePoliciesRequest regionDisksAddResourcePoliciesRequestResource = new RegionDisksAddResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.AddResourcePolicies(project, region, disk, regionDisksAddResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceAddResourcePolicies(operationName);
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
            // Snippet: AddResourcePoliciesAsync(string, string, string, RegionDisksAddResourcePoliciesRequest, CallSettings)
            // Additional: AddResourcePoliciesAsync(string, string, string, RegionDisksAddResourcePoliciesRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksAddResourcePoliciesRequest regionDisksAddResourcePoliciesRequestResource = new RegionDisksAddResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.AddResourcePoliciesAsync(project, region, disk, regionDisksAddResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceAddResourcePoliciesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkInsert</summary>
        public void BulkInsertRequestObject()
        {
            // Snippet: BulkInsert(BulkInsertRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            BulkInsertRegionDiskRequest request = new BulkInsertRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BulkInsertDiskResourceResource = new BulkInsertDiskResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.BulkInsert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceBulkInsert(operationName);
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
            // Snippet: BulkInsertAsync(BulkInsertRegionDiskRequest, CallSettings)
            // Additional: BulkInsertAsync(BulkInsertRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            BulkInsertRegionDiskRequest request = new BulkInsertRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                BulkInsertDiskResourceResource = new BulkInsertDiskResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.BulkInsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceBulkInsertAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BulkInsertDiskResource bulkInsertDiskResourceResource = new BulkInsertDiskResource();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.BulkInsert(project, region, bulkInsertDiskResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceBulkInsert(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            BulkInsertDiskResource bulkInsertDiskResourceResource = new BulkInsertDiskResource();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.BulkInsertAsync(project, region, bulkInsertDiskResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceBulkInsertAsync(operationName);
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
            // Snippet: CreateSnapshot(CreateSnapshotRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            CreateSnapshotRegionDiskRequest request = new CreateSnapshotRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.CreateSnapshot(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceCreateSnapshot(operationName);
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
            // Snippet: CreateSnapshotAsync(CreateSnapshotRegionDiskRequest, CallSettings)
            // Additional: CreateSnapshotAsync(CreateSnapshotRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            CreateSnapshotRegionDiskRequest request = new CreateSnapshotRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                SnapshotResource = new Snapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.CreateSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceCreateSnapshotAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.CreateSnapshot(project, region, disk, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceCreateSnapshot(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            Snapshot snapshotResource = new Snapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.CreateSnapshotAsync(project, region, disk, snapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceCreateSnapshotAsync(operationName);
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
            // Snippet: Delete(DeleteRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            DeleteRegionDiskRequest request = new DeleteRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionDiskRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionDiskRequest request = new DeleteRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceDeleteAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Delete(project, region, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceDelete(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.DeleteAsync(project, region, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            GetRegionDiskRequest request = new GetRegionDiskRequest
            {
                Disk = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Disk response = regionDisksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionDiskRequest, CallSettings)
            // Additional: GetAsync(GetRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionDiskRequest request = new GetRegionDiskRequest
            {
                Disk = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Disk response = await regionDisksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            Disk response = regionDisksClient.Get(project, region, disk);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            Disk response = await regionDisksClient.GetAsync(project, region, disk);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionDiskRequest request = new GetIamPolicyRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionDisksClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionDiskRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionDiskRequest request = new GetIamPolicyRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionDisksClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionDisksClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionDisksClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            InsertRegionDiskRequest request = new InsertRegionDiskRequest
            {
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionDiskRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionDiskRequest request = new InsertRegionDiskRequest
            {
                DiskResource = new Disk(),
                RequestId = "",
                SourceImage = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceInsertAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Insert(project, region, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceInsert(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.InsertAsync(project, region, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionDisksRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            ListRegionDisksRequest request = new ListRegionDisksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<DiskList, Disk> response = regionDisksClient.List(request);

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
            // Snippet: ListAsync(ListRegionDisksRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionDisksRequest request = new ListRegionDisksRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<DiskList, Disk> response = regionDisksClient.ListAsync(request);

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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<DiskList, Disk> response = regionDisksClient.List(project, region);

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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<DiskList, Disk> response = regionDisksClient.ListAsync(project, region);

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
            // Snippet: RemoveResourcePolicies(RemoveResourcePoliciesRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            RemoveResourcePoliciesRegionDiskRequest request = new RemoveResourcePoliciesRegionDiskRequest
            {
                Disk = "",
                RegionDisksRemoveResourcePoliciesRequestResource = new RegionDisksRemoveResourcePoliciesRequest(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.RemoveResourcePolicies(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceRemoveResourcePolicies(operationName);
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
            // Snippet: RemoveResourcePoliciesAsync(RemoveResourcePoliciesRegionDiskRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(RemoveResourcePoliciesRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            RemoveResourcePoliciesRegionDiskRequest request = new RemoveResourcePoliciesRegionDiskRequest
            {
                Disk = "",
                RegionDisksRemoveResourcePoliciesRequestResource = new RegionDisksRemoveResourcePoliciesRequest(),
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.RemoveResourcePoliciesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceRemoveResourcePoliciesAsync(operationName);
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
            // Snippet: RemoveResourcePolicies(string, string, string, RegionDisksRemoveResourcePoliciesRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksRemoveResourcePoliciesRequest regionDisksRemoveResourcePoliciesRequestResource = new RegionDisksRemoveResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.RemoveResourcePolicies(project, region, disk, regionDisksRemoveResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceRemoveResourcePolicies(operationName);
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
            // Snippet: RemoveResourcePoliciesAsync(string, string, string, RegionDisksRemoveResourcePoliciesRequest, CallSettings)
            // Additional: RemoveResourcePoliciesAsync(string, string, string, RegionDisksRemoveResourcePoliciesRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksRemoveResourcePoliciesRequest regionDisksRemoveResourcePoliciesRequestResource = new RegionDisksRemoveResourcePoliciesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.RemoveResourcePoliciesAsync(project, region, disk, regionDisksRemoveResourcePoliciesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceRemoveResourcePoliciesAsync(operationName);
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
            // Snippet: Resize(ResizeRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            ResizeRegionDiskRequest request = new ResizeRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksResizeRequestResource = new RegionDisksResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Resize(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceResize(operationName);
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
            // Snippet: ResizeAsync(ResizeRegionDiskRequest, CallSettings)
            // Additional: ResizeAsync(ResizeRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            ResizeRegionDiskRequest request = new ResizeRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksResizeRequestResource = new RegionDisksResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.ResizeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceResizeAsync(operationName);
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
            // Snippet: Resize(string, string, string, RegionDisksResizeRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksResizeRequest regionDisksResizeRequestResource = new RegionDisksResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Resize(project, region, disk, regionDisksResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceResize(operationName);
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
            // Snippet: ResizeAsync(string, string, string, RegionDisksResizeRequest, CallSettings)
            // Additional: ResizeAsync(string, string, string, RegionDisksResizeRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksResizeRequest regionDisksResizeRequestResource = new RegionDisksResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.ResizeAsync(project, region, disk, regionDisksResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceResizeAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionDiskRequest request = new SetIamPolicyRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionDisksClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionDiskRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionDiskRequest request = new SetIamPolicyRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionDisksClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionDisksClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionDisksClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            SetLabelsRegionDiskRequest request = new SetLabelsRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceSetLabels(operationName);
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
            // Snippet: SetLabelsAsync(SetLabelsRegionDiskRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsRegionDiskRequest request = new SetLabelsRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Resource = "",
                Project = "",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceSetLabelsAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.SetLabels(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceSetLabels(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetLabelsRequest regionSetLabelsRequestResource = new RegionSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.SetLabelsAsync(project, region, resource, regionSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceSetLabelsAsync(operationName);
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
            // Snippet: StartAsyncReplication(StartAsyncReplicationRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            StartAsyncReplicationRegionDiskRequest request = new StartAsyncReplicationRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksStartAsyncReplicationRequestResource = new RegionDisksStartAsyncReplicationRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StartAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStartAsyncReplication(operationName);
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
            // Snippet: StartAsyncReplicationAsync(StartAsyncReplicationRegionDiskRequest, CallSettings)
            // Additional: StartAsyncReplicationAsync(StartAsyncReplicationRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            StartAsyncReplicationRegionDiskRequest request = new StartAsyncReplicationRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
                RegionDisksStartAsyncReplicationRequestResource = new RegionDisksStartAsyncReplicationRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StartAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStartAsyncReplicationAsync(operationName);
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
            // Snippet: StartAsyncReplication(string, string, string, RegionDisksStartAsyncReplicationRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksStartAsyncReplicationRequest regionDisksStartAsyncReplicationRequestResource = new RegionDisksStartAsyncReplicationRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StartAsyncReplication(project, region, disk, regionDisksStartAsyncReplicationRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStartAsyncReplication(operationName);
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
            // Snippet: StartAsyncReplicationAsync(string, string, string, RegionDisksStartAsyncReplicationRequest, CallSettings)
            // Additional: StartAsyncReplicationAsync(string, string, string, RegionDisksStartAsyncReplicationRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            RegionDisksStartAsyncReplicationRequest regionDisksStartAsyncReplicationRequestResource = new RegionDisksStartAsyncReplicationRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StartAsyncReplicationAsync(project, region, disk, regionDisksStartAsyncReplicationRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStartAsyncReplicationAsync(operationName);
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
            // Snippet: StopAsyncReplication(StopAsyncReplicationRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            StopAsyncReplicationRegionDiskRequest request = new StopAsyncReplicationRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StopAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStopAsyncReplication(operationName);
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
            // Snippet: StopAsyncReplicationAsync(StopAsyncReplicationRegionDiskRequest, CallSettings)
            // Additional: StopAsyncReplicationAsync(StopAsyncReplicationRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            StopAsyncReplicationRegionDiskRequest request = new StopAsyncReplicationRegionDiskRequest
            {
                Disk = "",
                RequestId = "",
                Region = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StopAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStopAsyncReplicationAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StopAsyncReplication(project, region, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStopAsyncReplication(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StopAsyncReplicationAsync(project, region, disk);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStopAsyncReplicationAsync(operationName);
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
            // Snippet: StopGroupAsyncReplication(StopGroupAsyncReplicationRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            StopGroupAsyncReplicationRegionDiskRequest request = new StopGroupAsyncReplicationRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                DisksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StopGroupAsyncReplication(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStopGroupAsyncReplication(operationName);
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
            // Snippet: StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationRegionDiskRequest, CallSettings)
            // Additional: StopGroupAsyncReplicationAsync(StopGroupAsyncReplicationRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            StopGroupAsyncReplicationRegionDiskRequest request = new StopGroupAsyncReplicationRegionDiskRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                DisksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StopGroupAsyncReplicationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStopGroupAsyncReplicationAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.StopGroupAsyncReplication(project, region, disksStopGroupAsyncReplicationResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceStopGroupAsyncReplication(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            DisksStopGroupAsyncReplicationResource disksStopGroupAsyncReplicationResourceResource = new DisksStopGroupAsyncReplicationResource();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.StopGroupAsyncReplicationAsync(project, region, disksStopGroupAsyncReplicationResourceResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceStopGroupAsyncReplicationAsync(operationName);
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
            // Snippet: TestIamPermissions(TestIamPermissionsRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionDiskRequest request = new TestIamPermissionsRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionDisksClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionDiskRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionDiskRequest request = new TestIamPermissionsRegionDiskRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionDisksClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionDisksClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionDisksClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateRegionDiskRequest, CallSettings)
            // Create client
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            UpdateRegionDiskRequest request = new UpdateRegionDiskRequest
            {
                Disk = "",
                DiskResource = new Disk(),
                RequestId = "",
                Paths = "",
                Region = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateRegionDiskRequest, CallSettings)
            // Additional: UpdateAsync(UpdateRegionDiskRequest, CancellationToken)
            // Create client
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRegionDiskRequest request = new UpdateRegionDiskRequest
            {
                Disk = "",
                DiskResource = new Disk(),
                RequestId = "",
                Paths = "",
                Region = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceUpdateAsync(operationName);
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
            RegionDisksClient regionDisksClient = RegionDisksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = regionDisksClient.Update(project, region, disk, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionDisksClient.PollOnceUpdate(operationName);
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
            RegionDisksClient regionDisksClient = await RegionDisksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string disk = "";
            Disk diskResource = new Disk();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionDisksClient.UpdateAsync(project, region, disk, diskResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionDisksClient.PollOnceUpdateAsync(operationName);
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
