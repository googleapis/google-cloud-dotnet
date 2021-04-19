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
    public sealed class GeneratedRegionNetworkEndpointGroupsClientSnippets
    {
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = regionNetworkEndpointGroupsClient.Delete(request);
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
                NetworkEndpointGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionNetworkEndpointGroupsClient.DeleteAsync(request);
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
            Operation response = regionNetworkEndpointGroupsClient.Delete(project, region, networkEndpointGroup);
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
            Operation response = await regionNetworkEndpointGroupsClient.DeleteAsync(project, region, networkEndpointGroup);
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
                NetworkEndpointGroup = "",
                Project = "",
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
                NetworkEndpointGroup = "",
                Project = "",
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
            Operation response = regionNetworkEndpointGroupsClient.Insert(request);
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
            Operation response = await regionNetworkEndpointGroupsClient.InsertAsync(request);
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
            Operation response = regionNetworkEndpointGroupsClient.Insert(project, region, networkEndpointGroupResource);
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
            Operation response = await regionNetworkEndpointGroupsClient.InsertAsync(project, region, networkEndpointGroupResource);
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
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupList response = regionNetworkEndpointGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionNetworkEndpointGroupsRequest, CallSettings)
            // Additional: ListAsync(ListRegionNetworkEndpointGroupsRequest, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionNetworkEndpointGroupsRequest request = new ListRegionNetworkEndpointGroupsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NetworkEndpointGroupList response = await regionNetworkEndpointGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = RegionNetworkEndpointGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NetworkEndpointGroupList response = regionNetworkEndpointGroupsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionNetworkEndpointGroupsClient regionNetworkEndpointGroupsClient = await RegionNetworkEndpointGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            NetworkEndpointGroupList response = await regionNetworkEndpointGroupsClient.ListAsync(project, region);
            // End snippet
        }
    }
}
