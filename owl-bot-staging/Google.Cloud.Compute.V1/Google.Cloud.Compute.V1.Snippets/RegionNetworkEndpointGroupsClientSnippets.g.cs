// Copyright 2024 Google LLC
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
    public sealed class AllGeneratedRegionNetworkEndpointGroupsClientSnippets
    {
        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpointsRequestObject()
        {
            // Snippet: AttachNetworkEndpoints(AttachNetworkEndpointsRegionNetworkEndpointGroupRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AttachNetworkEndpointsRegionNetworkEndpointGroupRequest request = new AttachNetworkEndpointsRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionNetworkEndpointGroupsAttachEndpointsRequestResource = new RegionNetworkEndpointGroupsAttachEndpointsRequest(),
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.AttachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(AttachNetworkEndpointsRegionNetworkEndpointGroupRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(AttachNetworkEndpointsRegionNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AttachNetworkEndpointsRegionNetworkEndpointGroupRequest request = new AttachNetworkEndpointsRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionNetworkEndpointGroupsAttachEndpointsRequestResource = new RegionNetworkEndpointGroupsAttachEndpointsRequest(),
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpoints()
        {
            // Snippet: AttachNetworkEndpoints(string, string, string, RegionNetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            RegionNetworkEndpointGroupsAttachEndpointsRequest regionNetworkEndpointGroupsAttachEndpointsRequestResource = new RegionNetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.AttachNetworkEndpoints(project, region, networkEndpointGroup, regionNetworkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AttachNetworkEndpointsAsync</summary>
        public async Task AttachNetworkEndpointsAsync()
        {
            // Snippet: AttachNetworkEndpointsAsync(string, string, string, RegionNetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(string, string, string, RegionNetworkEndpointGroupsAttachEndpointsRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            RegionNetworkEndpointGroupsAttachEndpointsRequest regionNetworkEndpointGroupsAttachEndpointsRequestResource = new RegionNetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(project, region, networkEndpointGroup, regionNetworkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
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
            // Snippet: Delete(DeleteRegionNetworkEndpointGroupRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionNetworkEndpointGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionNetworkEndpointGroupRequest request = new DeleteRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
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
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.Delete(project, region, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceDelete(operationName);
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
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.DeleteAsync(project, region, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpointsRequestObject()
        {
            // Snippet: DetachNetworkEndpoints(DetachNetworkEndpointsRegionNetworkEndpointGroupRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DetachNetworkEndpointsRegionNetworkEndpointGroupRequest request = new DetachNetworkEndpointsRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionNetworkEndpointGroupsDetachEndpointsRequestResource = new RegionNetworkEndpointGroupsDetachEndpointsRequest(),
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.DetachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(DetachNetworkEndpointsRegionNetworkEndpointGroupRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(DetachNetworkEndpointsRegionNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DetachNetworkEndpointsRegionNetworkEndpointGroupRequest request = new DetachNetworkEndpointsRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                RegionNetworkEndpointGroupsDetachEndpointsRequestResource = new RegionNetworkEndpointGroupsDetachEndpointsRequest(),
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpoints</summary>
        public void DetachNetworkEndpoints()
        {
            // Snippet: DetachNetworkEndpoints(string, string, string, RegionNetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            RegionNetworkEndpointGroupsDetachEndpointsRequest regionNetworkEndpointGroupsDetachEndpointsRequestResource = new RegionNetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.DetachNetworkEndpoints(project, region, networkEndpointGroup, regionNetworkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DetachNetworkEndpointsAsync</summary>
        public async Task DetachNetworkEndpointsAsync()
        {
            // Snippet: DetachNetworkEndpointsAsync(string, string, string, RegionNetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(string, string, string, RegionNetworkEndpointGroupsDetachEndpointsRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            RegionNetworkEndpointGroupsDetachEndpointsRequest regionNetworkEndpointGroupsDetachEndpointsRequestResource = new RegionNetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(project, region, networkEndpointGroup, regionNetworkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
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
            // Snippet: Get(GetRegionNetworkEndpointGroupRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = regionNetworkEndpointGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionNetworkEndpointGroupRequest, CallSettings)
            // Additional: GetAsync(GetRegionNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionNetworkEndpointGroupRequest request = new GetRegionNetworkEndpointGroupRequest
            {
                Region = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = await regionNetworkEndpointGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = regionNetworkEndpointGroupsClient.Get(project, region, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = await regionNetworkEndpointGroupsClient.GetAsync(project, region, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionNetworkEndpointGroupRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionNetworkEndpointGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionNetworkEndpointGroupRequest request = new InsertRegionNetworkEndpointGroupRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, NetworkEndpointGroup, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkEndpointGroupsClient.Insert(project, region, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, NetworkEndpointGroup, CallSettings)
            // Additional: InsertAsync(string, string, NetworkEndpointGroup, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkEndpointGroupsClient.InsertAsync(project, region, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = regionNetworkEndpointGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            // Snippet: ListAsync(ListRegionNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = regionNetworkEndpointGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = regionNetworkEndpointGroupsClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
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
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = regionNetworkEndpointGroupsClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpointsRequestObject()
        {
            // Snippet: ListNetworkEndpoints(ListNetworkEndpointsRegionNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointsRegionNetworkEndpointGroupsRequest request = new ListNetworkEndpointsRegionNetworkEndpointGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = regionNetworkEndpointGroupsClient.ListNetworkEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointWithHealthStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupsListNetworkEndpoints page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(ListNetworkEndpointsRegionNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointsRegionNetworkEndpointGroupsRequest request = new ListNetworkEndpointsRegionNetworkEndpointGroupsRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = regionNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointWithHealthStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupsListNetworkEndpoints page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpoints()
        {
            // Snippet: ListNetworkEndpoints(string, string, string, string, int?, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = regionNetworkEndpointGroupsClient.ListNetworkEndpoints(project, region, networkEndpointGroup);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NetworkEndpointWithHealthStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkEndpointGroupsListNetworkEndpoints page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string networkEndpointGroup = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = regionNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(project, region, networkEndpointGroup);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((NetworkEndpointWithHealthStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkEndpointGroupsListNetworkEndpoints page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NetworkEndpointWithHealthStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NetworkEndpointWithHealthStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NetworkEndpointWithHealthStatus item in singlePage)
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
