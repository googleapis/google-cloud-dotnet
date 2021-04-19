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
    public sealed class GeneratedInstanceGroupsClientSnippets
    {
        /// <summary>Snippet for AddInstances</summary>
        public void AddInstancesRequestObject()
        {
            // Snippet: AddInstances(AddInstancesInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = instanceGroupsClient.AddInstances(request);
            // End snippet
        }

        /// <summary>Snippet for AddInstancesAsync</summary>
        public async Task AddInstancesRequestObjectAsync()
        {
            // Snippet: AddInstancesAsync(AddInstancesInstanceGroupRequest, CallSettings)
            // Additional: AddInstancesAsync(AddInstancesInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await instanceGroupsClient.AddInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddInstances</summary>
        public void AddInstances()
        {
            // Snippet: AddInstances(string, string, string, InstanceGroupsAddInstancesRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest();
            // Make the request
            Operation response = instanceGroupsClient.AddInstances(project, zone, instanceGroup, instanceGroupsAddInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddInstancesAsync</summary>
        public async Task AddInstancesAsync()
        {
            // Snippet: AddInstancesAsync(string, string, string, InstanceGroupsAddInstancesRequest, CallSettings)
            // Additional: AddInstancesAsync(string, string, string, InstanceGroupsAddInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest();
            // Make the request
            Operation response = await instanceGroupsClient.AddInstancesAsync(project, zone, instanceGroup, instanceGroupsAddInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupAggregatedList response = instanceGroupsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListInstanceGroupsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListInstanceGroupsRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                IncludeAllScopes = false,
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupAggregatedList response = await instanceGroupsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceGroupAggregatedList response = instanceGroupsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            InstanceGroupAggregatedList response = await instanceGroupsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = instanceGroupsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInstanceGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await instanceGroupsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            Operation response = instanceGroupsClient.Delete(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            Operation response = await instanceGroupsClient.DeleteAsync(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = instanceGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceGroupRequest, CallSettings)
            // Additional: GetAsync(GetInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = await instanceGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = instanceGroupsClient.Get(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = await instanceGroupsClient.GetAsync(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "",
                InstanceGroupResource = new InstanceGroup(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = instanceGroupsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInstanceGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "",
                InstanceGroupResource = new InstanceGroup(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            Operation response = await instanceGroupsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, InstanceGroup, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroup instanceGroupResource = new InstanceGroup();
            // Make the request
            Operation response = instanceGroupsClient.Insert(project, zone, instanceGroupResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, InstanceGroup, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroup, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroup instanceGroupResource = new InstanceGroup();
            // Make the request
            Operation response = await instanceGroupsClient.InsertAsync(project, zone, instanceGroupResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupList response = instanceGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInstanceGroupsRequest, CallSettings)
            // Additional: ListAsync(ListInstanceGroupsRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupList response = await instanceGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceGroupList response = instanceGroupsClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            InstanceGroupList response = await instanceGroupsClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                InstanceGroup = "",
                OrderBy = "",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupsListInstances response = instanceGroupsClient.ListInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesInstanceGroupsRequest, CallSettings)
            // Additional: ListInstancesAsync(ListInstancesInstanceGroupsRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                InstanceGroup = "",
                OrderBy = "",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            InstanceGroupsListInstances response = await instanceGroupsClient.ListInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, string, InstanceGroupsListInstancesRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest();
            // Make the request
            InstanceGroupsListInstances response = instanceGroupsClient.ListInstances(project, zone, instanceGroup, instanceGroupsListInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, string, InstanceGroupsListInstancesRequest, CallSettings)
            // Additional: ListInstancesAsync(string, string, string, InstanceGroupsListInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest();
            // Make the request
            InstanceGroupsListInstances response = await instanceGroupsClient.ListInstancesAsync(project, zone, instanceGroup, instanceGroupsListInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstances</summary>
        public void RemoveInstancesRequestObject()
        {
            // Snippet: RemoveInstances(RemoveInstancesInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = instanceGroupsClient.RemoveInstances(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstancesAsync</summary>
        public async Task RemoveInstancesRequestObjectAsync()
        {
            // Snippet: RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest, CallSettings)
            // Additional: RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await instanceGroupsClient.RemoveInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstances</summary>
        public void RemoveInstances()
        {
            // Snippet: RemoveInstances(string, string, string, InstanceGroupsRemoveInstancesRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest();
            // Make the request
            Operation response = instanceGroupsClient.RemoveInstances(project, zone, instanceGroup, instanceGroupsRemoveInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for RemoveInstancesAsync</summary>
        public async Task RemoveInstancesAsync()
        {
            // Snippet: RemoveInstancesAsync(string, string, string, InstanceGroupsRemoveInstancesRequest, CallSettings)
            // Additional: RemoveInstancesAsync(string, string, string, InstanceGroupsRemoveInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest();
            // Make the request
            Operation response = await instanceGroupsClient.RemoveInstancesAsync(project, zone, instanceGroup, instanceGroupsRemoveInstancesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPortsRequestObject()
        {
            // Snippet: SetNamedPorts(SetNamedPortsInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
                Project = "",
            };
            // Make the request
            Operation response = instanceGroupsClient.SetNamedPorts(request);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsRequestObjectAsync()
        {
            // Snippet: SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest, CallSettings)
            // Additional: SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
                Project = "",
            };
            // Make the request
            Operation response = await instanceGroupsClient.SetNamedPortsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPorts()
        {
            // Snippet: SetNamedPorts(string, string, string, InstanceGroupsSetNamedPortsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest();
            // Make the request
            Operation response = instanceGroupsClient.SetNamedPorts(project, zone, instanceGroup, instanceGroupsSetNamedPortsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsAsync()
        {
            // Snippet: SetNamedPortsAsync(string, string, string, InstanceGroupsSetNamedPortsRequest, CallSettings)
            // Additional: SetNamedPortsAsync(string, string, string, InstanceGroupsSetNamedPortsRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest();
            // Make the request
            Operation response = await instanceGroupsClient.SetNamedPortsAsync(project, zone, instanceGroup, instanceGroupsSetNamedPortsRequestResource);
            // End snippet
        }
    }
}
