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
    public sealed class AllGeneratedGlobalNetworkEndpointGroupsClientSnippets
    {
        /// <summary>Snippet for AttachNetworkEndpoints</summary>
        public void AttachNetworkEndpointsRequestObject()
        {
            // Snippet: AttachNetworkEndpoints(AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.AttachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
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
            // Snippet: AttachNetworkEndpointsAsync(AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new AttachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest(),
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
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
            // Snippet: AttachNetworkEndpoints(string, string, GlobalNetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            GlobalNetworkEndpointGroupsAttachEndpointsRequest globalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.AttachNetworkEndpoints(project, networkEndpointGroup, globalNetworkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpoints(operationName);
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
            // Snippet: AttachNetworkEndpointsAsync(string, string, GlobalNetworkEndpointGroupsAttachEndpointsRequest, CallSettings)
            // Additional: AttachNetworkEndpointsAsync(string, string, GlobalNetworkEndpointGroupsAttachEndpointsRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            GlobalNetworkEndpointGroupsAttachEndpointsRequest globalNetworkEndpointGroupsAttachEndpointsRequestResource = new GlobalNetworkEndpointGroupsAttachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(project, networkEndpointGroup, globalNetworkEndpointGroupsAttachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceAttachNetworkEndpointsAsync(operationName);
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
            // Snippet: Delete(DeleteGlobalNetworkEndpointGroupRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteGlobalNetworkEndpointGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalNetworkEndpointGroupRequest request = new DeleteGlobalNetworkEndpointGroupRequest
            {
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.Delete(project, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.DeleteAsync(project, networkEndpointGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: DetachNetworkEndpoints(DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.DetachNetworkEndpoints(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
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
            // Snippet: DetachNetworkEndpointsAsync(DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest request = new DetachNetworkEndpointsGlobalNetworkEndpointGroupRequest
            {
                GlobalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest(),
                RequestId = "",
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
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
            // Snippet: DetachNetworkEndpoints(string, string, GlobalNetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            GlobalNetworkEndpointGroupsDetachEndpointsRequest globalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.DetachNetworkEndpoints(project, networkEndpointGroup, globalNetworkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpoints(operationName);
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
            // Snippet: DetachNetworkEndpointsAsync(string, string, GlobalNetworkEndpointGroupsDetachEndpointsRequest, CallSettings)
            // Additional: DetachNetworkEndpointsAsync(string, string, GlobalNetworkEndpointGroupsDetachEndpointsRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            GlobalNetworkEndpointGroupsDetachEndpointsRequest globalNetworkEndpointGroupsDetachEndpointsRequestResource = new GlobalNetworkEndpointGroupsDetachEndpointsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(project, networkEndpointGroup, globalNetworkEndpointGroupsDetachEndpointsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceDetachNetworkEndpointsAsync(operationName);
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
            // Snippet: Get(GetGlobalNetworkEndpointGroupRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = globalNetworkEndpointGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalNetworkEndpointGroupRequest, CallSettings)
            // Additional: GetAsync(GetGlobalNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalNetworkEndpointGroupRequest request = new GetGlobalNetworkEndpointGroupRequest
            {
                Project = "",
                NetworkEndpointGroup = "",
            };
            // Make the request
            NetworkEndpointGroup response = await globalNetworkEndpointGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = globalNetworkEndpointGroupsClient.Get(project, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroup response = await globalNetworkEndpointGroupsClient.GetAsync(project, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalNetworkEndpointGroupRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertGlobalNetworkEndpointGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalNetworkEndpointGroupRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalNetworkEndpointGroupRequest request = new InsertGlobalNetworkEndpointGroupRequest
            {
                RequestId = "",
                Project = "",
                NetworkEndpointGroupResource = new NetworkEndpointGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, NetworkEndpointGroup, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = globalNetworkEndpointGroupsClient.Insert(project, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalNetworkEndpointGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, NetworkEndpointGroup, CallSettings)
            // Additional: InsertAsync(string, NetworkEndpointGroup, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            NetworkEndpointGroup networkEndpointGroupResource = new NetworkEndpointGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalNetworkEndpointGroupsClient.InsertAsync(project, networkEndpointGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalNetworkEndpointGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListGlobalNetworkEndpointGroupsRequest request = new ListGlobalNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = globalNetworkEndpointGroupsClient.List(request);

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
            // Snippet: ListAsync(ListGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalNetworkEndpointGroupsRequest request = new ListGlobalNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = globalNetworkEndpointGroupsClient.ListAsync(request);

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
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = globalNetworkEndpointGroupsClient.List(project);

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
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> response = globalNetworkEndpointGroupsClient.ListAsync(project);

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
            // Snippet: ListNetworkEndpoints(ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest request = new ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = globalNetworkEndpointGroupsClient.ListNetworkEndpoints(request);

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
            // Snippet: ListNetworkEndpointsAsync(ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest request = new ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                NetworkEndpointGroup = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = globalNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(request);

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
            // Snippet: ListNetworkEndpoints(string, string, string, int?, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            PagedEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = globalNetworkEndpointGroupsClient.ListNetworkEndpoints(project, networkEndpointGroup);

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
            // Snippet: ListNetworkEndpointsAsync(string, string, string, int?, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            PagedAsyncEnumerable<NetworkEndpointGroupsListNetworkEndpoints, NetworkEndpointWithHealthStatus> response = globalNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(project, networkEndpointGroup);

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
