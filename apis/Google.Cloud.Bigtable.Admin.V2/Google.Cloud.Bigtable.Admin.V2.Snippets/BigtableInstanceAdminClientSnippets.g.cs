// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Admin.V2;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedBigtableInstanceAdminClientSnippets
    {
        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(ProjectName,string,Instance,IDictionary<string, Cluster>,CallSettings)
            // Additional: CreateInstanceAsync(ProjectName,string,Instance,IDictionary<string, Cluster>,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster>();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await bigtableInstanceAdminClient.CreateInstanceAsync(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(ProjectName,string,Instance,IDictionary<string, Cluster>,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster>();
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                bigtableInstanceAdminClient.CreateInstance(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync_RequestObject()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
                Clusters = { },
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                await bigtableInstanceAdminClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance_RequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
                Clusters = { },
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response =
                bigtableInstanceAdminClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName,CallSettings)
            // Additional: GetInstanceAsync(InstanceName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(InstanceName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = bigtableInstanceAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync_RequestObject()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance_RequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = bigtableInstanceAdminClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(ProjectName,CallSettings)
            // Additional: ListInstancesAsync(ProjectName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            ListInstancesResponse response = await bigtableInstanceAdminClient.ListInstancesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(ProjectName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            ListInstancesResponse response = bigtableInstanceAdminClient.ListInstances(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync_RequestObject()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            ListInstancesResponse response = await bigtableInstanceAdminClient.ListInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances_RequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            ListInstancesResponse response = bigtableInstanceAdminClient.ListInstances(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(InstanceName,string,Instance.Types.Type,CallSettings)
            // Additional: UpdateInstanceAsync(InstanceName,string,Instance.Types.Type,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            string displayName = "";
            Instance.Types.Type type = Instance.Types.Type.Unspecified;
            // Make the request
            Instance response = await bigtableInstanceAdminClient.UpdateInstanceAsync(name, displayName, type);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(InstanceName,string,Instance.Types.Type,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            string displayName = "";
            Instance.Types.Type type = Instance.Types.Type.Unspecified;
            // Make the request
            Instance response = bigtableInstanceAdminClient.UpdateInstance(name, displayName, type);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync_RequestObject()
        {
            // Snippet: UpdateInstanceAsync(Instance,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance request = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "",
                Type = Instance.Types.Type.Unspecified,
            };
            // Make the request
            Instance response = await bigtableInstanceAdminClient.UpdateInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance_RequestObject()
        {
            // Snippet: UpdateInstance(Instance,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance request = new Instance
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                DisplayName = "",
                Type = Instance.Types.Type.Unspecified,
            };
            // Make the request
            Instance response = bigtableInstanceAdminClient.UpdateInstance(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName,CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(InstanceName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            bigtableInstanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync_RequestObject()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance_RequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteInstance(request);
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(InstanceName,string,Cluster,CallSettings)
            // Additional: CreateClusterAsync(InstanceName,string,Cluster,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response =
                await bigtableInstanceAdminClient.CreateClusterAsync(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster()
        {
            // Snippet: CreateCluster(InstanceName,string,Cluster,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response =
                bigtableInstanceAdminClient.CreateCluster(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync_RequestObject()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ClusterId = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response =
                await bigtableInstanceAdminClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster_RequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                ClusterId = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response =
                bigtableInstanceAdminClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(ClusterName,CallSettings)
            // Additional: GetClusterAsync(ClusterName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            Cluster response = await bigtableInstanceAdminClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(ClusterName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            Cluster response = bigtableInstanceAdminClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync_RequestObject()
        {
            // Snippet: GetClusterAsync(GetClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await bigtableInstanceAdminClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster_RequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = bigtableInstanceAdminClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(InstanceName,CallSettings)
            // Additional: ListClustersAsync(InstanceName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            ListClustersResponse response = await bigtableInstanceAdminClient.ListClustersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(InstanceName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            ListClustersResponse response = bigtableInstanceAdminClient.ListClusters(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync_RequestObject()
        {
            // Snippet: ListClustersAsync(ListClustersRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            ListClustersResponse response = await bigtableInstanceAdminClient.ListClustersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters_RequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            ListClustersResponse response = bigtableInstanceAdminClient.ListClusters(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync()
        {
            // Snippet: UpdateClusterAsync(ClusterName,LocationName,int,StorageType,CallSettings)
            // Additional: UpdateClusterAsync(ClusterName,LocationName,int,StorageType,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            LocationName location = new LocationName("[PROJECT]", "[LOCATION]");
            int serveNodes = 0;
            StorageType defaultStorageType = StorageType.Unspecified;
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response =
                await bigtableInstanceAdminClient.UpdateClusterAsync(name, location, serveNodes, defaultStorageType);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster()
        {
            // Snippet: UpdateCluster(ClusterName,LocationName,int,StorageType,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            LocationName location = new LocationName("[PROJECT]", "[LOCATION]");
            int serveNodes = 0;
            StorageType defaultStorageType = StorageType.Unspecified;
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response =
                bigtableInstanceAdminClient.UpdateCluster(name, location, serveNodes, defaultStorageType);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync_RequestObject()
        {
            // Snippet: UpdateClusterAsync(Cluster,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 0,
                DefaultStorageType = StorageType.Unspecified,
            };
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response =
                await bigtableInstanceAdminClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster_RequestObject()
        {
            // Snippet: UpdateCluster(Cluster,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                ServeNodes = 0,
                DefaultStorageType = StorageType.Unspecified,
            };
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response =
                bigtableInstanceAdminClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(ClusterName,CallSettings)
            // Additional: DeleteClusterAsync(ClusterName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(ClusterName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            bigtableInstanceAdminClient.DeleteCluster(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync_RequestObject()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster_RequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteCluster(request);
            // End snippet
        }

    }
}
