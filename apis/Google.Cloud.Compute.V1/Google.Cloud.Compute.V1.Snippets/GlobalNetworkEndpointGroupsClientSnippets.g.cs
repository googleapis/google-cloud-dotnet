// Copyright 2021 Google LLC
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

namespace Google.Cloud.Compute.V1.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedGlobalNetworkEndpointGroupsClientSnippets
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = globalNetworkEndpointGroupsClient.AttachNetworkEndpoints(request);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(request);
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
            Operation response = globalNetworkEndpointGroupsClient.AttachNetworkEndpoints(project, networkEndpointGroup, globalNetworkEndpointGroupsAttachEndpointsRequestResource);
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
            Operation response = await globalNetworkEndpointGroupsClient.AttachNetworkEndpointsAsync(project, networkEndpointGroup, globalNetworkEndpointGroupsAttachEndpointsRequestResource);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = globalNetworkEndpointGroupsClient.Delete(request);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalNetworkEndpointGroupsClient.DeleteAsync(request);
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
            Operation response = globalNetworkEndpointGroupsClient.Delete(project, networkEndpointGroup);
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
            Operation response = await globalNetworkEndpointGroupsClient.DeleteAsync(project, networkEndpointGroup);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = globalNetworkEndpointGroupsClient.DetachNetworkEndpoints(request);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await globalNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(request);
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
            Operation response = globalNetworkEndpointGroupsClient.DetachNetworkEndpoints(project, networkEndpointGroup, globalNetworkEndpointGroupsDetachEndpointsRequestResource);
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
            Operation response = await globalNetworkEndpointGroupsClient.DetachNetworkEndpointsAsync(project, networkEndpointGroup, globalNetworkEndpointGroupsDetachEndpointsRequestResource);
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
                NetworkEndpointGroup = "",
                Project = "",
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
                NetworkEndpointGroup = "",
                Project = "",
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
            Operation response = globalNetworkEndpointGroupsClient.Insert(request);
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
            Operation response = await globalNetworkEndpointGroupsClient.InsertAsync(request);
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
            Operation response = globalNetworkEndpointGroupsClient.Insert(project, networkEndpointGroupResource);
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
            Operation response = await globalNetworkEndpointGroupsClient.InsertAsync(project, networkEndpointGroupResource);
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupList response = globalNetworkEndpointGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Additional: ListAsync(ListGlobalNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalNetworkEndpointGroupsRequest request = new ListGlobalNetworkEndpointGroupsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupList response = await globalNetworkEndpointGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkEndpointGroupList response = globalNetworkEndpointGroupsClient.List(project);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, CallSettings)
            // Additional: ListAsync(string, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NetworkEndpointGroupList response = await globalNetworkEndpointGroupsClient.ListAsync(project);
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                NetworkEndpointGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = globalNetworkEndpointGroupsClient.ListNetworkEndpoints(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsRequestObjectAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest, CallSettings)
            // Additional: ListNetworkEndpointsAsync(ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest request = new ListNetworkEndpointsGlobalNetworkEndpointGroupsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                NetworkEndpointGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = await globalNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpoints</summary>
        public void ListNetworkEndpoints()
        {
            // Snippet: ListNetworkEndpoints(string, string, CallSettings)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = GlobalNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = globalNetworkEndpointGroupsClient.ListNetworkEndpoints(project, networkEndpointGroup);
            // End snippet
        }

        /// <summary>Snippet for ListNetworkEndpointsAsync</summary>
        public async Task ListNetworkEndpointsAsync()
        {
            // Snippet: ListNetworkEndpointsAsync(string, string, CallSettings)
            // Additional: ListNetworkEndpointsAsync(string, string, CancellationToken)
            // Create client
            GlobalNetworkEndpointGroupsClient globalNetworkEndpointGroupsClient = await GlobalNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string networkEndpointGroup = "";
            // Make the request
            NetworkEndpointGroupsListNetworkEndpoints response = await globalNetworkEndpointGroupsClient.ListNetworkEndpointsAsync(project, networkEndpointGroup);
            // End snippet
        }
    }
}
