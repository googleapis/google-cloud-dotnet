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

namespace GoogleCSharpSnippets
{
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNodeGroupControllerClientSnippets
    {
        /// <summary>Snippet for CreateNodeGroup</summary>
        public void CreateNodeGroupRequestObject()
        {
            // Snippet: CreateNodeGroup(CreateNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            CreateNodeGroupRequest request = new CreateNodeGroupRequest
            {
                ParentAsClusterRegionName = ClusterRegionName.FromProjectRegionCluster("[PROJECT]", "[REGION]", "[CLUSTER]"),
                NodeGroup = new NodeGroup(),
                RequestId = "",
                NodeGroupId = "",
            };
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = nodeGroupControllerClient.CreateNodeGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = nodeGroupControllerClient.PollOnceCreateNodeGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeGroupAsync</summary>
        public async Task CreateNodeGroupRequestObjectAsync()
        {
            // Snippet: CreateNodeGroupAsync(CreateNodeGroupRequest, CallSettings)
            // Additional: CreateNodeGroupAsync(CreateNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            CreateNodeGroupRequest request = new CreateNodeGroupRequest
            {
                ParentAsClusterRegionName = ClusterRegionName.FromProjectRegionCluster("[PROJECT]", "[REGION]", "[CLUSTER]"),
                NodeGroup = new NodeGroup(),
                RequestId = "",
                NodeGroupId = "",
            };
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.CreateNodeGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceCreateNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeGroup</summary>
        public void CreateNodeGroup()
        {
            // Snippet: CreateNodeGroup(string, NodeGroup, string, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/clusters/[CLUSTER]";
            NodeGroup nodeGroup = new NodeGroup();
            string nodeGroupId = "";
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = nodeGroupControllerClient.CreateNodeGroup(parent, nodeGroup, nodeGroupId);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = nodeGroupControllerClient.PollOnceCreateNodeGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeGroupAsync</summary>
        public async Task CreateNodeGroupAsync()
        {
            // Snippet: CreateNodeGroupAsync(string, NodeGroup, string, CallSettings)
            // Additional: CreateNodeGroupAsync(string, NodeGroup, string, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/regions/[REGION]/clusters/[CLUSTER]";
            NodeGroup nodeGroup = new NodeGroup();
            string nodeGroupId = "";
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.CreateNodeGroupAsync(parent, nodeGroup, nodeGroupId);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceCreateNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeGroup</summary>
        public void CreateNodeGroupResourceNames()
        {
            // Snippet: CreateNodeGroup(ClusterRegionName, NodeGroup, string, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            ClusterRegionName parent = ClusterRegionName.FromProjectRegionCluster("[PROJECT]", "[REGION]", "[CLUSTER]");
            NodeGroup nodeGroup = new NodeGroup();
            string nodeGroupId = "";
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = nodeGroupControllerClient.CreateNodeGroup(parent, nodeGroup, nodeGroupId);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = nodeGroupControllerClient.PollOnceCreateNodeGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNodeGroupAsync</summary>
        public async Task CreateNodeGroupResourceNamesAsync()
        {
            // Snippet: CreateNodeGroupAsync(ClusterRegionName, NodeGroup, string, CallSettings)
            // Additional: CreateNodeGroupAsync(ClusterRegionName, NodeGroup, string, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            ClusterRegionName parent = ClusterRegionName.FromProjectRegionCluster("[PROJECT]", "[REGION]", "[CLUSTER]");
            NodeGroup nodeGroup = new NodeGroup();
            string nodeGroupId = "";
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.CreateNodeGroupAsync(parent, nodeGroup, nodeGroupId);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceCreateNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeNodeGroup</summary>
        public void ResizeNodeGroupRequestObject()
        {
            // Snippet: ResizeNodeGroup(ResizeNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            ResizeNodeGroupRequest request = new ResizeNodeGroupRequest
            {
                Name = "",
                Size = 0,
                RequestId = "",
                GracefulDecommissionTimeout = new Duration(),
            };
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = nodeGroupControllerClient.ResizeNodeGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = nodeGroupControllerClient.PollOnceResizeNodeGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeNodeGroupAsync</summary>
        public async Task ResizeNodeGroupRequestObjectAsync()
        {
            // Snippet: ResizeNodeGroupAsync(ResizeNodeGroupRequest, CallSettings)
            // Additional: ResizeNodeGroupAsync(ResizeNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            ResizeNodeGroupRequest request = new ResizeNodeGroupRequest
            {
                Name = "",
                Size = 0,
                RequestId = "",
                GracefulDecommissionTimeout = new Duration(),
            };
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.ResizeNodeGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceResizeNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeNodeGroup</summary>
        public void ResizeNodeGroup()
        {
            // Snippet: ResizeNodeGroup(string, int, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            string name = "";
            int size = 0;
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = nodeGroupControllerClient.ResizeNodeGroup(name, size);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = nodeGroupControllerClient.PollOnceResizeNodeGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeNodeGroupAsync</summary>
        public async Task ResizeNodeGroupAsync()
        {
            // Snippet: ResizeNodeGroupAsync(string, int, CallSettings)
            // Additional: ResizeNodeGroupAsync(string, int, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            int size = 0;
            // Make the request
            Operation<NodeGroup, NodeGroupOperationMetadata> response = await nodeGroupControllerClient.ResizeNodeGroupAsync(name, size);

            // Poll until the returned long-running operation is complete
            Operation<NodeGroup, NodeGroupOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            NodeGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<NodeGroup, NodeGroupOperationMetadata> retrievedResponse = await nodeGroupControllerClient.PollOnceResizeNodeGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                NodeGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroup</summary>
        public void GetNodeGroupRequestObject()
        {
            // Snippet: GetNodeGroup(GetNodeGroupRequest, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                NodeGroupName = NodeGroupName.FromProjectRegionClusterNodeGroup("[PROJECT]", "[REGION]", "[CLUSTER]", "[NODE_GROUP]"),
            };
            // Make the request
            NodeGroup response = nodeGroupControllerClient.GetNodeGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroupAsync</summary>
        public async Task GetNodeGroupRequestObjectAsync()
        {
            // Snippet: GetNodeGroupAsync(GetNodeGroupRequest, CallSettings)
            // Additional: GetNodeGroupAsync(GetNodeGroupRequest, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetNodeGroupRequest request = new GetNodeGroupRequest
            {
                NodeGroupName = NodeGroupName.FromProjectRegionClusterNodeGroup("[PROJECT]", "[REGION]", "[CLUSTER]", "[NODE_GROUP]"),
            };
            // Make the request
            NodeGroup response = await nodeGroupControllerClient.GetNodeGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroup</summary>
        public void GetNodeGroup()
        {
            // Snippet: GetNodeGroup(string, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/clusters/[CLUSTER]/nodeGroups/[NODE_GROUP]";
            // Make the request
            NodeGroup response = nodeGroupControllerClient.GetNodeGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroupAsync</summary>
        public async Task GetNodeGroupAsync()
        {
            // Snippet: GetNodeGroupAsync(string, CallSettings)
            // Additional: GetNodeGroupAsync(string, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/regions/[REGION]/clusters/[CLUSTER]/nodeGroups/[NODE_GROUP]";
            // Make the request
            NodeGroup response = await nodeGroupControllerClient.GetNodeGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroup</summary>
        public void GetNodeGroupResourceNames()
        {
            // Snippet: GetNodeGroup(NodeGroupName, CallSettings)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = NodeGroupControllerClient.Create();
            // Initialize request argument(s)
            NodeGroupName name = NodeGroupName.FromProjectRegionClusterNodeGroup("[PROJECT]", "[REGION]", "[CLUSTER]", "[NODE_GROUP]");
            // Make the request
            NodeGroup response = nodeGroupControllerClient.GetNodeGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetNodeGroupAsync</summary>
        public async Task GetNodeGroupResourceNamesAsync()
        {
            // Snippet: GetNodeGroupAsync(NodeGroupName, CallSettings)
            // Additional: GetNodeGroupAsync(NodeGroupName, CancellationToken)
            // Create client
            NodeGroupControllerClient nodeGroupControllerClient = await NodeGroupControllerClient.CreateAsync();
            // Initialize request argument(s)
            NodeGroupName name = NodeGroupName.FromProjectRegionClusterNodeGroup("[PROJECT]", "[REGION]", "[CLUSTER]", "[NODE_GROUP]");
            // Make the request
            NodeGroup response = await nodeGroupControllerClient.GetNodeGroupAsync(name);
            // End snippet
        }
    }
}
