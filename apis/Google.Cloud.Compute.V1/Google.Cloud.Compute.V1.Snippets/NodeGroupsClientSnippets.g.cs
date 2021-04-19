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
    public sealed class GeneratedNodeGroupsClientSnippets
    {
        /// <summary>Snippet for AddNodes</summary>
        public void AddNodesRequestObject()
        {
            // Snippet: AddNodes(AddNodesNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            AddNodesNodeGroupRequest request = new AddNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeGroupsClient.AddNodes(request);
            // End snippet
        }

        /// <summary>Snippet for AddNodesAsync</summary>
        public async Task AddNodesRequestObjectAsync()
        {
            // Snippet: AddNodesAsync(AddNodesNodeGroupRequest, CallSettings)
            // Additional: AddNodesAsync(AddNodesNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AddNodesNodeGroupRequest request = new AddNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeGroupsClient.AddNodesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddNodes</summary>
        public void AddNodes()
        {
            // Snippet: AddNodes(string, string, string, NodeGroupsAddNodesRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsAddNodesRequest nodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest();
            // Make the request
            Operation response = nodeGroupsClient.AddNodes(project, zone, nodeGroup, nodeGroupsAddNodesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AddNodesAsync</summary>
        public async Task AddNodesAsync()
        {
            // Snippet: AddNodesAsync(string, string, string, NodeGroupsAddNodesRequest, CallSettings)
            // Additional: AddNodesAsync(string, string, string, NodeGroupsAddNodesRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsAddNodesRequest nodeGroupsAddNodesRequestResource = new NodeGroupsAddNodesRequest();
            // Make the request
            Operation response = await nodeGroupsClient.AddNodesAsync(project, zone, nodeGroup, nodeGroupsAddNodesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListNodeGroupsRequest request = new AggregatedListNodeGroupsRequest
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
            NodeGroupAggregatedList response = nodeGroupsClient.AggregatedList(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNodeGroupsRequest, CallSettings)
            // Additional: AggregatedListAsync(AggregatedListNodeGroupsRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNodeGroupsRequest request = new AggregatedListNodeGroupsRequest
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
            NodeGroupAggregatedList response = await nodeGroupsClient.AggregatedListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeGroupAggregatedList response = nodeGroupsClient.AggregatedList(project);
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, CallSettings)
            // Additional: AggregatedListAsync(string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            NodeGroupAggregatedList response = await nodeGroupsClient.AggregatedListAsync(project);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNodeGroupRequest request = new DeleteNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeGroupsClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNodeGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodeGroupRequest request = new DeleteNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeGroupsClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            Operation response = nodeGroupsClient.Delete(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            Operation response = await nodeGroupsClient.DeleteAsync(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodes</summary>
        public void DeleteNodesRequestObject()
        {
            // Snippet: DeleteNodes(DeleteNodesNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            DeleteNodesNodeGroupRequest request = new DeleteNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeGroupsClient.DeleteNodes(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodesAsync</summary>
        public async Task DeleteNodesRequestObjectAsync()
        {
            // Snippet: DeleteNodesAsync(DeleteNodesNodeGroupRequest, CallSettings)
            // Additional: DeleteNodesAsync(DeleteNodesNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNodesNodeGroupRequest request = new DeleteNodesNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeGroupsClient.DeleteNodesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodes</summary>
        public void DeleteNodes()
        {
            // Snippet: DeleteNodes(string, string, string, NodeGroupsDeleteNodesRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsDeleteNodesRequest nodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest();
            // Make the request
            Operation response = nodeGroupsClient.DeleteNodes(project, zone, nodeGroup, nodeGroupsDeleteNodesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for DeleteNodesAsync</summary>
        public async Task DeleteNodesAsync()
        {
            // Snippet: DeleteNodesAsync(string, string, string, NodeGroupsDeleteNodesRequest, CallSettings)
            // Additional: DeleteNodesAsync(string, string, string, NodeGroupsDeleteNodesRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsDeleteNodesRequest nodeGroupsDeleteNodesRequestResource = new NodeGroupsDeleteNodesRequest();
            // Make the request
            Operation response = await nodeGroupsClient.DeleteNodesAsync(project, zone, nodeGroup, nodeGroupsDeleteNodesRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "",
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            NodeGroup response = nodeGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNodeGroupRequest, CallSettings)
            // Additional: GetAsync(GetNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                Zone = "",
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            NodeGroup response = await nodeGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroup response = nodeGroupsClient.Get(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroup response = await nodeGroupsClient.GetAsync(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = nodeGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyNodeGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyNodeGroupRequest request = new GetIamPolicyNodeGroupRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await nodeGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = nodeGroupsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await nodeGroupsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            InsertNodeGroupRequest request = new InsertNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                InitialNodeCount = 0,
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            Operation response = nodeGroupsClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNodeGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertNodeGroupRequest request = new InsertNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                InitialNodeCount = 0,
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            Operation response = await nodeGroupsClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, string, int, NodeGroup, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            int initialNodeCount = 0;
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            Operation response = nodeGroupsClient.Insert(project, zone, initialNodeCount, nodeGroupResource);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, string, int, NodeGroup, CallSettings)
            // Additional: InsertAsync(string, string, int, NodeGroup, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            int initialNodeCount = 0;
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            Operation response = await nodeGroupsClient.InsertAsync(project, zone, initialNodeCount, nodeGroupResource);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            ListNodeGroupsRequest request = new ListNodeGroupsRequest
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
            NodeGroupList response = nodeGroupsClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListNodeGroupsRequest, CallSettings)
            // Additional: ListAsync(ListNodeGroupsRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNodeGroupsRequest request = new ListNodeGroupsRequest
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
            NodeGroupList response = await nodeGroupsClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NodeGroupList response = nodeGroupsClient.List(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, CallSettings)
            // Additional: ListAsync(string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            NodeGroupList response = await nodeGroupsClient.ListAsync(project, zone);
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodesRequestObject()
        {
            // Snippet: ListNodes(ListNodesNodeGroupsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            ListNodesNodeGroupsRequest request = new ListNodesNodeGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                NodeGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NodeGroupsListNodes response = nodeGroupsClient.ListNodes(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesRequestObjectAsync()
        {
            // Snippet: ListNodesAsync(ListNodesNodeGroupsRequest, CallSettings)
            // Additional: ListNodesAsync(ListNodesNodeGroupsRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListNodesNodeGroupsRequest request = new ListNodesNodeGroupsRequest
            {
                Zone = "",
                PageToken = "",
                MaxResults = 0U,
                Filter = "",
                OrderBy = "",
                NodeGroup = "",
                Project = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            NodeGroupsListNodes response = await nodeGroupsClient.ListNodesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListNodes</summary>
        public void ListNodes()
        {
            // Snippet: ListNodes(string, string, string, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroupsListNodes response = nodeGroupsClient.ListNodes(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for ListNodesAsync</summary>
        public async Task ListNodesAsync()
        {
            // Snippet: ListNodesAsync(string, string, string, CallSettings)
            // Additional: ListNodesAsync(string, string, string, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            // Make the request
            NodeGroupsListNodes response = await nodeGroupsClient.ListNodesAsync(project, zone, nodeGroup);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            PatchNodeGroupRequest request = new PatchNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroup = "",
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            Operation response = nodeGroupsClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchNodeGroupRequest, CallSettings)
            // Additional: PatchAsync(PatchNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PatchNodeGroupRequest request = new PatchNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroup = "",
                Project = "",
                NodeGroupResource = new NodeGroup(),
            };
            // Make the request
            Operation response = await nodeGroupsClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, string, NodeGroup, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            Operation response = nodeGroupsClient.Patch(project, zone, nodeGroup, nodeGroupResource);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, string, NodeGroup, CallSettings)
            // Additional: PatchAsync(string, string, string, NodeGroup, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroup nodeGroupResource = new NodeGroup();
            // Make the request
            Operation response = await nodeGroupsClient.PatchAsync(project, zone, nodeGroup, nodeGroupResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = nodeGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyNodeGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyNodeGroupRequest request = new SetIamPolicyNodeGroupRequest
            {
                Zone = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            Policy response = await nodeGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = nodeGroupsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await nodeGroupsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplate</summary>
        public void SetNodeTemplateRequestObject()
        {
            // Snippet: SetNodeTemplate(SetNodeTemplateNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            SetNodeTemplateNodeGroupRequest request = new SetNodeTemplateNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = nodeGroupsClient.SetNodeTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplateAsync</summary>
        public async Task SetNodeTemplateRequestObjectAsync()
        {
            // Snippet: SetNodeTemplateAsync(SetNodeTemplateNodeGroupRequest, CallSettings)
            // Additional: SetNodeTemplateAsync(SetNodeTemplateNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNodeTemplateNodeGroupRequest request = new SetNodeTemplateNodeGroupRequest
            {
                Zone = "",
                RequestId = "",
                NodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest(),
                NodeGroup = "",
                Project = "",
            };
            // Make the request
            Operation response = await nodeGroupsClient.SetNodeTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplate</summary>
        public void SetNodeTemplate()
        {
            // Snippet: SetNodeTemplate(string, string, string, NodeGroupsSetNodeTemplateRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSetNodeTemplateRequest nodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest();
            // Make the request
            Operation response = nodeGroupsClient.SetNodeTemplate(project, zone, nodeGroup, nodeGroupsSetNodeTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetNodeTemplateAsync</summary>
        public async Task SetNodeTemplateAsync()
        {
            // Snippet: SetNodeTemplateAsync(string, string, string, NodeGroupsSetNodeTemplateRequest, CallSettings)
            // Additional: SetNodeTemplateAsync(string, string, string, NodeGroupsSetNodeTemplateRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string nodeGroup = "";
            NodeGroupsSetNodeTemplateRequest nodeGroupsSetNodeTemplateRequestResource = new NodeGroupsSetNodeTemplateRequest();
            // Make the request
            Operation response = await nodeGroupsClient.SetNodeTemplateAsync(project, zone, nodeGroup, nodeGroupsSetNodeTemplateRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = nodeGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNodeGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNodeGroupRequest request = new TestIamPermissionsNodeGroupRequest
            {
                Zone = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
                Resource = "",
                Project = "",
            };
            // Make the request
            TestPermissionsResponse response = await nodeGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NodeGroupsClient nodeGroupsClient = NodeGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = nodeGroupsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NodeGroupsClient nodeGroupsClient = await NodeGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await nodeGroupsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
