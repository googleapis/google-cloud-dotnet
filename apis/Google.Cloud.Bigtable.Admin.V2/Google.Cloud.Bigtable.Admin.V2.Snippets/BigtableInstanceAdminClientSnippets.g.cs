// Copyright 2019 Google LLC
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

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Iam.V1;
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
            // Additional: GetInstanceAsync(GetInstanceRequest,CancellationToken)
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
            // Additional: ListInstancesAsync(ListInstancesRequest,CancellationToken)
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

        /// <summary>Snippet for PartialUpdateInstanceAsync</summary>
        public async Task PartialUpdateInstanceAsync()
        {
            // Snippet: PartialUpdateInstanceAsync(Instance,FieldMask,CallSettings)
            // Additional: PartialUpdateInstanceAsync(Instance,FieldMask,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response =
                await bigtableInstanceAdminClient.PartialUpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOncePartialUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstance</summary>
        public void PartialUpdateInstance()
        {
            // Snippet: PartialUpdateInstance(Instance,FieldMask,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response =
                bigtableInstanceAdminClient.PartialUpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOncePartialUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstanceAsync</summary>
        public async Task PartialUpdateInstanceAsync_RequestObject()
        {
            // Snippet: PartialUpdateInstanceAsync(PartialUpdateInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            PartialUpdateInstanceRequest request = new PartialUpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response =
                await bigtableInstanceAdminClient.PartialUpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOncePartialUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstance</summary>
        public void PartialUpdateInstance_RequestObject()
        {
            // Snippet: PartialUpdateInstance(PartialUpdateInstanceRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            PartialUpdateInstanceRequest request = new PartialUpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response =
                bigtableInstanceAdminClient.PartialUpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOncePartialUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
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
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest,CancellationToken)
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
            // Additional: GetClusterAsync(GetClusterRequest,CancellationToken)
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
            // Additional: ListClustersAsync(ListClustersRequest,CancellationToken)
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
        public async Task UpdateClusterAsync_RequestObject()
        {
            // Snippet: UpdateClusterAsync(Cluster,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                ServeNodes = 0,
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
                ServeNodes = 0,
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
            // Additional: DeleteClusterAsync(DeleteClusterRequest,CancellationToken)
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

        /// <summary>Snippet for CreateAppProfileAsync</summary>
        public async Task CreateAppProfileAsync()
        {
            // Snippet: CreateAppProfileAsync(InstanceName,string,AppProfile,CallSettings)
            // Additional: CreateAppProfileAsync(InstanceName,string,AppProfile,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.CreateAppProfileAsync(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfile</summary>
        public void CreateAppProfile()
        {
            // Snippet: CreateAppProfile(InstanceName,string,AppProfile,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.CreateAppProfile(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfileAsync</summary>
        public async Task CreateAppProfileAsync_RequestObject()
        {
            // Snippet: CreateAppProfileAsync(CreateAppProfileRequest,CallSettings)
            // Additional: CreateAppProfileAsync(CreateAppProfileRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                AppProfile = new AppProfile(),
            };
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.CreateAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfile</summary>
        public void CreateAppProfile_RequestObject()
        {
            // Snippet: CreateAppProfile(CreateAppProfileRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                AppProfile = new AppProfile(),
            };
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.CreateAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfileAsync</summary>
        public async Task GetAppProfileAsync()
        {
            // Snippet: GetAppProfileAsync(AppProfileName,CallSettings)
            // Additional: GetAppProfileAsync(AppProfileName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.GetAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfile</summary>
        public void GetAppProfile()
        {
            // Snippet: GetAppProfile(AppProfileName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.GetAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfileAsync</summary>
        public async Task GetAppProfileAsync_RequestObject()
        {
            // Snippet: GetAppProfileAsync(GetAppProfileRequest,CallSettings)
            // Additional: GetAppProfileAsync(GetAppProfileRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.GetAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfile</summary>
        public void GetAppProfile_RequestObject()
        {
            // Snippet: GetAppProfile(GetAppProfileRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.GetAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for ListAppProfilesAsync</summary>
        public async Task ListAppProfilesAsync()
        {
            // Snippet: ListAppProfilesAsync(InstanceName,string,int?,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> response =
                bigtableInstanceAdminClient.ListAppProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppProfile item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppProfile item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfiles</summary>
        public void ListAppProfiles()
        {
            // Snippet: ListAppProfiles(InstanceName,string,int?,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListAppProfilesResponse, AppProfile> response =
                bigtableInstanceAdminClient.ListAppProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppProfile item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppProfile item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfilesAsync</summary>
        public async Task ListAppProfilesAsync_RequestObject()
        {
            // Snippet: ListAppProfilesAsync(ListAppProfilesRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> response =
                bigtableInstanceAdminClient.ListAppProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AppProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAppProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppProfile item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppProfile item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfiles</summary>
        public void ListAppProfiles_RequestObject()
        {
            // Snippet: ListAppProfiles(ListAppProfilesRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListAppProfilesResponse, AppProfile> response =
                bigtableInstanceAdminClient.ListAppProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AppProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAppProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AppProfile item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AppProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AppProfile item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfileAsync</summary>
        public async Task UpdateAppProfileAsync()
        {
            // Snippet: UpdateAppProfileAsync(AppProfile,FieldMask,CallSettings)
            // Additional: UpdateAppProfileAsync(AppProfile,FieldMask,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfile appProfile = new AppProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response =
                await bigtableInstanceAdminClient.UpdateAppProfileAsync(appProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceUpdateAppProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfile</summary>
        public void UpdateAppProfile()
        {
            // Snippet: UpdateAppProfile(AppProfile,FieldMask,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfile appProfile = new AppProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response =
                bigtableInstanceAdminClient.UpdateAppProfile(appProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceUpdateAppProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfileAsync</summary>
        public async Task UpdateAppProfileAsync_RequestObject()
        {
            // Snippet: UpdateAppProfileAsync(UpdateAppProfileRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAppProfileRequest request = new UpdateAppProfileRequest
            {
                AppProfile = new AppProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response =
                await bigtableInstanceAdminClient.UpdateAppProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse =
                await bigtableInstanceAdminClient.PollOnceUpdateAppProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfile</summary>
        public void UpdateAppProfile_RequestObject()
        {
            // Snippet: UpdateAppProfile(UpdateAppProfileRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateAppProfileRequest request = new UpdateAppProfileRequest
            {
                AppProfile = new AppProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response =
                bigtableInstanceAdminClient.UpdateAppProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse =
                bigtableInstanceAdminClient.PollOnceUpdateAppProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfileAsync</summary>
        public async Task DeleteAppProfileAsync()
        {
            // Snippet: DeleteAppProfileAsync(AppProfileName,CallSettings)
            // Additional: DeleteAppProfileAsync(AppProfileName,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfile</summary>
        public void DeleteAppProfile()
        {
            // Snippet: DeleteAppProfile(AppProfileName,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfileName name = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            bigtableInstanceAdminClient.DeleteAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfileAsync</summary>
        public async Task DeleteAppProfileAsync_RequestObject()
        {
            // Snippet: DeleteAppProfileAsync(DeleteAppProfileRequest,CallSettings)
            // Additional: DeleteAppProfileAsync(DeleteAppProfileRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = false,
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfile</summary>
        public void DeleteAppProfile_RequestObject()
        {
            // Snippet: DeleteAppProfile(DeleteAppProfileRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = new AppProfileName("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = false,
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            Policy response = await bigtableInstanceAdminClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            // Make the request
            Policy response = bigtableInstanceAdminClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Policy response = await bigtableInstanceAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Policy response = bigtableInstanceAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableInstanceAdminClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableInstanceAdminClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await bigtableInstanceAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = bigtableInstanceAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await bigtableInstanceAdminClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = bigtableInstanceAdminClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await bigtableInstanceAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new InstanceName("[PROJECT]", "[INSTANCE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = bigtableInstanceAdminClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
