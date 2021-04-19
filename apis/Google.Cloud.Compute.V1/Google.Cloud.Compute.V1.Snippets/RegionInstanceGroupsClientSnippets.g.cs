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
    public sealed class GeneratedRegionInstanceGroupsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionInstanceGroupRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            GetRegionInstanceGroupRequest request = new GetRegionInstanceGroupRequest
            {
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = regionInstanceGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionInstanceGroupRequest, CallSettings)
            // Additional: GetAsync(GetRegionInstanceGroupRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionInstanceGroupRequest request = new GetRegionInstanceGroupRequest
            {
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = await regionInstanceGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = regionInstanceGroupsClient.Get(project, region, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = await regionInstanceGroupsClient.GetAsync(project, region, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
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
            RegionInstanceGroupList response = regionInstanceGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionInstanceGroupsRequest, CallSettings)
            // Additional: ListAsync(ListRegionInstanceGroupsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionInstanceGroupsRequest request = new ListRegionInstanceGroupsRequest
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
            RegionInstanceGroupList response = await regionInstanceGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionInstanceGroupList response = regionInstanceGroupsClient.List(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            RegionInstanceGroupList response = await regionInstanceGroupsClient.ListAsync(project, region);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRegionInstanceGroupsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                PageToken = "",
                RegionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest(),
                MaxResults = 0U,
                Filter = "",
                InstanceGroup = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionInstanceGroupsListInstances response = regionInstanceGroupsClient.ListInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRegionInstanceGroupsRequest, CallSettings)
            // Additional: ListInstancesAsync(ListInstancesRegionInstanceGroupsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRegionInstanceGroupsRequest request = new ListInstancesRegionInstanceGroupsRequest
            {
                PageToken = "",
                RegionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest(),
                MaxResults = 0U,
                Filter = "",
                InstanceGroup = "",
                Region = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            RegionInstanceGroupsListInstances response = await regionInstanceGroupsClient.ListInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, string, RegionInstanceGroupsListInstancesRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest();
            // Make the request
            RegionInstanceGroupsListInstances response = regionInstanceGroupsClient.ListInstances(project, region, instanceGroup, regionInstanceGroupsListInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, string, RegionInstanceGroupsListInstancesRequest, CallSettings)
            // Additional: ListInstancesAsync(string, string, string, RegionInstanceGroupsListInstancesRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsListInstancesRequest regionInstanceGroupsListInstancesRequestResource = new RegionInstanceGroupsListInstancesRequest();
            // Make the request
            RegionInstanceGroupsListInstances response = await regionInstanceGroupsClient.ListInstancesAsync(project, region, instanceGroup, regionInstanceGroupsListInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPortsRequestObject()
        {
            // Snippet: SetNamedPorts(SetNamedPortsRegionInstanceGroupRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            SetNamedPortsRegionInstanceGroupRequest request = new SetNamedPortsRegionInstanceGroupRequest
            {
                RegionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest(),
                RequestId = "",
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = regionInstanceGroupsClient.SetNamedPorts(request);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsRequestObjectAsync()
        {
            // Snippet: SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest, CallSettings)
            // Additional: SetNamedPortsAsync(SetNamedPortsRegionInstanceGroupRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNamedPortsRegionInstanceGroupRequest request = new SetNamedPortsRegionInstanceGroupRequest
            {
                RegionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest(),
                RequestId = "",
                InstanceGroup = "",
                Region = "",
                Project = "",
            };
            // Make the request
            Operation response = await regionInstanceGroupsClient.SetNamedPortsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPorts()
        {
            // Snippet: SetNamedPorts(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CallSettings)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = RegionInstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest();
            // Make the request
            Operation response = regionInstanceGroupsClient.SetNamedPorts(project, region, instanceGroup, regionInstanceGroupsSetNamedPortsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsAsync()
        {
            // Snippet: SetNamedPortsAsync(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CallSettings)
            // Additional: SetNamedPortsAsync(string, string, string, RegionInstanceGroupsSetNamedPortsRequest, CancellationToken)
            // Create client
            RegionInstanceGroupsClient regionInstanceGroupsClient = await RegionInstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string instanceGroup = "";
            RegionInstanceGroupsSetNamedPortsRequest regionInstanceGroupsSetNamedPortsRequestResource = new RegionInstanceGroupsSetNamedPortsRequest();
            // Make the request
            Operation response = await regionInstanceGroupsClient.SetNamedPortsAsync(project, region, instanceGroup, regionInstanceGroupsSetNamedPortsRequestResource);
            // End snippet
        }
    }
}
