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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigtableInstanceAdminClientSnippets
    {
        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
                Clusters = { { "", new Cluster() }, },
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = bigtableInstanceAdminClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                InstanceId = "",
                Instance = new Instance(),
                Clusters = { { "", new Cluster() }, },
            };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await bigtableInstanceAdminClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateInstanceAsync(operationName);
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
            // Snippet: CreateInstance(string, string, Instance, IDictionary<string,Cluster>, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster> { { "", new Cluster() }, };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = bigtableInstanceAdminClient.CreateInstance(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, string, Instance, IDictionary<string,Cluster>, CallSettings)
            // Additional: CreateInstanceAsync(string, string, Instance, IDictionary<string,Cluster>, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster> { { "", new Cluster() }, };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await bigtableInstanceAdminClient.CreateInstanceAsync(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceResourceNames()
        {
            // Snippet: CreateInstance(ProjectName, string, Instance, IDictionary<string,Cluster>, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster> { { "", new Cluster() }, };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = bigtableInstanceAdminClient.CreateInstance(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceResourceNamesAsync()
        {
            // Snippet: CreateInstanceAsync(ProjectName, string, Instance, IDictionary<string,Cluster>, CallSettings)
            // Additional: CreateInstanceAsync(ProjectName, string, Instance, IDictionary<string,Cluster>, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string instanceId = "";
            Instance instance = new Instance();
            IDictionary<string, Cluster> clusters = new Dictionary<string, Cluster> { { "", new Cluster() }, };
            // Make the request
            Operation<Instance, CreateInstanceMetadata> response = await bigtableInstanceAdminClient.CreateInstanceAsync(parent, instanceId, instance, clusters);

            // Poll until the returned long-running operation is complete
            Operation<Instance, CreateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, CreateInstanceMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = bigtableInstanceAdminClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            Instance response = bigtableInstanceAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = bigtableInstanceAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            Instance response = await bigtableInstanceAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PageToken = "",
            };
            // Make the request
            ListInstancesResponse response = bigtableInstanceAdminClient.ListInstances(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Additional: ListInstancesAsync(ListInstancesRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PageToken = "",
            };
            // Make the request
            ListInstancesResponse response = await bigtableInstanceAdminClient.ListInstancesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ListInstancesResponse response = bigtableInstanceAdminClient.ListInstances(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, CallSettings)
            // Additional: ListInstancesAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            ListInstancesResponse response = await bigtableInstanceAdminClient.ListInstancesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(ProjectName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ListInstancesResponse response = bigtableInstanceAdminClient.ListInstances(parent);
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(ProjectName, CallSettings)
            // Additional: ListInstancesAsync(ProjectName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            ListInstancesResponse response = await bigtableInstanceAdminClient.ListInstancesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstanceRequestObject()
        {
            // Snippet: UpdateInstance(Instance, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance request = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels = { { "", "" }, },
                CreateTime = new Timestamp(),
                SatisfiesPzs = false,
            };
            // Make the request
            Instance response = bigtableInstanceAdminClient.UpdateInstance(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceRequestObjectAsync()
        {
            // Snippet: UpdateInstanceAsync(Instance, CallSettings)
            // Additional: UpdateInstanceAsync(Instance, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance request = new Instance
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DisplayName = "",
                State = Instance.Types.State.NotKnown,
                Type = Instance.Types.Type.Unspecified,
                Labels = { { "", "" }, },
                CreateTime = new Timestamp(),
                SatisfiesPzs = false,
            };
            // Make the request
            Instance response = await bigtableInstanceAdminClient.UpdateInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstance</summary>
        public void PartialUpdateInstanceRequestObject()
        {
            // Snippet: PartialUpdateInstance(PartialUpdateInstanceRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            PartialUpdateInstanceRequest request = new PartialUpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = bigtableInstanceAdminClient.PartialUpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOncePartialUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstanceAsync</summary>
        public async Task PartialUpdateInstanceRequestObjectAsync()
        {
            // Snippet: PartialUpdateInstanceAsync(PartialUpdateInstanceRequest, CallSettings)
            // Additional: PartialUpdateInstanceAsync(PartialUpdateInstanceRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            PartialUpdateInstanceRequest request = new PartialUpdateInstanceRequest
            {
                Instance = new Instance(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = await bigtableInstanceAdminClient.PartialUpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOncePartialUpdateInstanceAsync(operationName);
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
            // Snippet: PartialUpdateInstance(Instance, FieldMask, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = bigtableInstanceAdminClient.PartialUpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOncePartialUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateInstanceAsync</summary>
        public async Task PartialUpdateInstanceAsync()
        {
            // Snippet: PartialUpdateInstanceAsync(Instance, FieldMask, CallSettings)
            // Additional: PartialUpdateInstanceAsync(Instance, FieldMask, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, UpdateInstanceMetadata> response = await bigtableInstanceAdminClient.PartialUpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, UpdateInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, UpdateInstanceMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOncePartialUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteInstance(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceRequestObjectAsync()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest, CallSettings)
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            bigtableInstanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string, CallSettings)
            // Additional: DeleteInstanceAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            await bigtableInstanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceResourceNames()
        {
            // Snippet: DeleteInstance(InstanceName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            bigtableInstanceAdminClient.DeleteInstance(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceResourceNamesAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName, CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ClusterId = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = bigtableInstanceAdminClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterRequestObjectAsync()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ClusterId = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = await bigtableInstanceAdminClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateClusterAsync(operationName);
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
            // Snippet: CreateCluster(string, string, Cluster, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = bigtableInstanceAdminClient.CreateCluster(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string, string, Cluster, CallSettings)
            // Additional: CreateClusterAsync(string, string, Cluster, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = await bigtableInstanceAdminClient.CreateClusterAsync(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterResourceNames()
        {
            // Snippet: CreateCluster(InstanceName, string, Cluster, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = bigtableInstanceAdminClient.CreateCluster(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterResourceNamesAsync()
        {
            // Snippet: CreateClusterAsync(InstanceName, string, Cluster, CallSettings)
            // Additional: CreateClusterAsync(InstanceName, string, Cluster, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string clusterId = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, CreateClusterMetadata> response = await bigtableInstanceAdminClient.CreateClusterAsync(parent, clusterId, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, CreateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, CreateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterRequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = bigtableInstanceAdminClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await bigtableInstanceAdminClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = bigtableInstanceAdminClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await bigtableInstanceAdminClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            Cluster response = bigtableInstanceAdminClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            Cluster response = await bigtableInstanceAdminClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                PageToken = "",
            };
            // Make the request
            ListClustersResponse response = bigtableInstanceAdminClient.ListClusters(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersRequestObjectAsync()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Additional: ListClustersAsync(ListClustersRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                PageToken = "",
            };
            // Make the request
            ListClustersResponse response = await bigtableInstanceAdminClient.ListClustersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            ListClustersResponse response = bigtableInstanceAdminClient.ListClusters(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(string, CallSettings)
            // Additional: ListClustersAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            ListClustersResponse response = await bigtableInstanceAdminClient.ListClustersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersResourceNames()
        {
            // Snippet: ListClusters(InstanceName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            ListClustersResponse response = bigtableInstanceAdminClient.ListClusters(parent);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersResourceNamesAsync()
        {
            // Snippet: ListClustersAsync(InstanceName, CallSettings)
            // Additional: ListClustersAsync(InstanceName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            ListClustersResponse response = await bigtableInstanceAdminClient.ListClustersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(Cluster, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.NotKnown,
                ServeNodes = 0,
                DefaultStorageType = StorageType.Unspecified,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
                NodeScalingFactor = Cluster.Types.NodeScalingFactor.Unspecified,
            };
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response = bigtableInstanceAdminClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterRequestObjectAsync()
        {
            // Snippet: UpdateClusterAsync(Cluster, CallSettings)
            // Additional: UpdateClusterAsync(Cluster, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Cluster request = new Cluster
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                State = Cluster.Types.State.NotKnown,
                ServeNodes = 0,
                DefaultStorageType = StorageType.Unspecified,
                EncryptionConfig = new Cluster.Types.EncryptionConfig(),
                ClusterConfig = new Cluster.Types.ClusterConfig(),
                NodeScalingFactor = Cluster.Types.NodeScalingFactor.Unspecified,
            };
            // Make the request
            Operation<Cluster, UpdateClusterMetadata> response = await bigtableInstanceAdminClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, UpdateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, UpdateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateCluster</summary>
        public void PartialUpdateClusterRequestObject()
        {
            // Snippet: PartialUpdateCluster(PartialUpdateClusterRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            PartialUpdateClusterRequest request = new PartialUpdateClusterRequest
            {
                Cluster = new Cluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Cluster, PartialUpdateClusterMetadata> response = bigtableInstanceAdminClient.PartialUpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, PartialUpdateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, PartialUpdateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOncePartialUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateClusterAsync</summary>
        public async Task PartialUpdateClusterRequestObjectAsync()
        {
            // Snippet: PartialUpdateClusterAsync(PartialUpdateClusterRequest, CallSettings)
            // Additional: PartialUpdateClusterAsync(PartialUpdateClusterRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            PartialUpdateClusterRequest request = new PartialUpdateClusterRequest
            {
                Cluster = new Cluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Cluster, PartialUpdateClusterMetadata> response = await bigtableInstanceAdminClient.PartialUpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, PartialUpdateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, PartialUpdateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOncePartialUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateCluster</summary>
        public void PartialUpdateCluster()
        {
            // Snippet: PartialUpdateCluster(Cluster, FieldMask, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, PartialUpdateClusterMetadata> response = bigtableInstanceAdminClient.PartialUpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, PartialUpdateClusterMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, PartialUpdateClusterMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOncePartialUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PartialUpdateClusterAsync</summary>
        public async Task PartialUpdateClusterAsync()
        {
            // Snippet: PartialUpdateClusterAsync(Cluster, FieldMask, CallSettings)
            // Additional: PartialUpdateClusterAsync(Cluster, FieldMask, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, PartialUpdateClusterMetadata> response = await bigtableInstanceAdminClient.PartialUpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, PartialUpdateClusterMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, PartialUpdateClusterMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOncePartialUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteCluster(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterRequestObjectAsync()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            bigtableInstanceAdminClient.DeleteCluster(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string, CallSettings)
            // Additional: DeleteClusterAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            await bigtableInstanceAdminClient.DeleteClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterResourceNames()
        {
            // Snippet: DeleteCluster(ClusterName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            bigtableInstanceAdminClient.DeleteCluster(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterResourceNamesAsync()
        {
            // Snippet: DeleteClusterAsync(ClusterName, CallSettings)
            // Additional: DeleteClusterAsync(ClusterName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfile</summary>
        public void CreateAppProfileRequestObject()
        {
            // Snippet: CreateAppProfile(CreateAppProfileRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                AppProfile = new AppProfile(),
                IgnoreWarnings = false,
            };
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.CreateAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfileAsync</summary>
        public async Task CreateAppProfileRequestObjectAsync()
        {
            // Snippet: CreateAppProfileAsync(CreateAppProfileRequest, CallSettings)
            // Additional: CreateAppProfileAsync(CreateAppProfileRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateAppProfileRequest request = new CreateAppProfileRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                AppProfileId = "",
                AppProfile = new AppProfile(),
                IgnoreWarnings = false,
            };
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.CreateAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfile</summary>
        public void CreateAppProfile()
        {
            // Snippet: CreateAppProfile(string, string, AppProfile, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.CreateAppProfile(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfileAsync</summary>
        public async Task CreateAppProfileAsync()
        {
            // Snippet: CreateAppProfileAsync(string, string, AppProfile, CallSettings)
            // Additional: CreateAppProfileAsync(string, string, AppProfile, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.CreateAppProfileAsync(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfile</summary>
        public void CreateAppProfileResourceNames()
        {
            // Snippet: CreateAppProfile(InstanceName, string, AppProfile, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.CreateAppProfile(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateAppProfileAsync</summary>
        public async Task CreateAppProfileResourceNamesAsync()
        {
            // Snippet: CreateAppProfileAsync(InstanceName, string, AppProfile, CallSettings)
            // Additional: CreateAppProfileAsync(InstanceName, string, AppProfile, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string appProfileId = "";
            AppProfile appProfile = new AppProfile();
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.CreateAppProfileAsync(parent, appProfileId, appProfile);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfile</summary>
        public void GetAppProfileRequestObject()
        {
            // Snippet: GetAppProfile(GetAppProfileRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.GetAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfileAsync</summary>
        public async Task GetAppProfileRequestObjectAsync()
        {
            // Snippet: GetAppProfileAsync(GetAppProfileRequest, CallSettings)
            // Additional: GetAppProfileAsync(GetAppProfileRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetAppProfileRequest request = new GetAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
            };
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.GetAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfile</summary>
        public void GetAppProfile()
        {
            // Snippet: GetAppProfile(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/appProfiles/[APP_PROFILE]";
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.GetAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfileAsync</summary>
        public async Task GetAppProfileAsync()
        {
            // Snippet: GetAppProfileAsync(string, CallSettings)
            // Additional: GetAppProfileAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/appProfiles/[APP_PROFILE]";
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.GetAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfile</summary>
        public void GetAppProfileResourceNames()
        {
            // Snippet: GetAppProfile(AppProfileName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfileName name = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            AppProfile response = bigtableInstanceAdminClient.GetAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetAppProfileAsync</summary>
        public async Task GetAppProfileResourceNamesAsync()
        {
            // Snippet: GetAppProfileAsync(AppProfileName, CallSettings)
            // Additional: GetAppProfileAsync(AppProfileName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfileName name = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            AppProfile response = await bigtableInstanceAdminClient.GetAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAppProfiles</summary>
        public void ListAppProfilesRequestObject()
        {
            // Snippet: ListAppProfiles(ListAppProfilesRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfiles(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfilesAsync</summary>
        public async Task ListAppProfilesRequestObjectAsync()
        {
            // Snippet: ListAppProfilesAsync(ListAppProfilesRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListAppProfilesRequest request = new ListAppProfilesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfilesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfiles</summary>
        public void ListAppProfiles()
        {
            // Snippet: ListAppProfiles(string, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfiles(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfilesAsync</summary>
        public async Task ListAppProfilesAsync()
        {
            // Snippet: ListAppProfilesAsync(string, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfilesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfiles</summary>
        public void ListAppProfilesResourceNames()
        {
            // Snippet: ListAppProfiles(InstanceName, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfiles(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAppProfilesAsync</summary>
        public async Task ListAppProfilesResourceNamesAsync()
        {
            // Snippet: ListAppProfilesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListAppProfilesResponse, AppProfile> response = bigtableInstanceAdminClient.ListAppProfilesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfile</summary>
        public void UpdateAppProfileRequestObject()
        {
            // Snippet: UpdateAppProfile(UpdateAppProfileRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            UpdateAppProfileRequest request = new UpdateAppProfileRequest
            {
                AppProfile = new AppProfile(),
                UpdateMask = new FieldMask(),
                IgnoreWarnings = false,
            };
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response = bigtableInstanceAdminClient.UpdateAppProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceUpdateAppProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfileAsync</summary>
        public async Task UpdateAppProfileRequestObjectAsync()
        {
            // Snippet: UpdateAppProfileAsync(UpdateAppProfileRequest, CallSettings)
            // Additional: UpdateAppProfileAsync(UpdateAppProfileRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAppProfileRequest request = new UpdateAppProfileRequest
            {
                AppProfile = new AppProfile(),
                UpdateMask = new FieldMask(),
                IgnoreWarnings = false,
            };
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response = await bigtableInstanceAdminClient.UpdateAppProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceUpdateAppProfileAsync(operationName);
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
            // Snippet: UpdateAppProfile(AppProfile, FieldMask, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfile appProfile = new AppProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response = bigtableInstanceAdminClient.UpdateAppProfile(appProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceUpdateAppProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAppProfileAsync</summary>
        public async Task UpdateAppProfileAsync()
        {
            // Snippet: UpdateAppProfileAsync(AppProfile, FieldMask, CallSettings)
            // Additional: UpdateAppProfileAsync(AppProfile, FieldMask, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfile appProfile = new AppProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AppProfile, UpdateAppProfileMetadata> response = await bigtableInstanceAdminClient.UpdateAppProfileAsync(appProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AppProfile, UpdateAppProfileMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AppProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AppProfile, UpdateAppProfileMetadata> retrievedResponse = await bigtableInstanceAdminClient.PollOnceUpdateAppProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AppProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfile</summary>
        public void DeleteAppProfileRequestObject()
        {
            // Snippet: DeleteAppProfile(DeleteAppProfileRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = false,
            };
            // Make the request
            bigtableInstanceAdminClient.DeleteAppProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfileAsync</summary>
        public async Task DeleteAppProfileRequestObjectAsync()
        {
            // Snippet: DeleteAppProfileAsync(DeleteAppProfileRequest, CallSettings)
            // Additional: DeleteAppProfileAsync(DeleteAppProfileRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAppProfileRequest request = new DeleteAppProfileRequest
            {
                AppProfileName = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]"),
                IgnoreWarnings = false,
            };
            // Make the request
            await bigtableInstanceAdminClient.DeleteAppProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfile</summary>
        public void DeleteAppProfile()
        {
            // Snippet: DeleteAppProfile(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/appProfiles/[APP_PROFILE]";
            // Make the request
            bigtableInstanceAdminClient.DeleteAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfileAsync</summary>
        public async Task DeleteAppProfileAsync()
        {
            // Snippet: DeleteAppProfileAsync(string, CallSettings)
            // Additional: DeleteAppProfileAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/appProfiles/[APP_PROFILE]";
            // Make the request
            await bigtableInstanceAdminClient.DeleteAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfile</summary>
        public void DeleteAppProfileResourceNames()
        {
            // Snippet: DeleteAppProfile(AppProfileName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            AppProfileName name = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            bigtableInstanceAdminClient.DeleteAppProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAppProfileAsync</summary>
        public async Task DeleteAppProfileResourceNamesAsync()
        {
            // Snippet: DeleteAppProfileAsync(AppProfileName, CallSettings)
            // Additional: DeleteAppProfileAsync(AppProfileName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            AppProfileName name = AppProfileName.FromProjectInstanceAppProfile("[PROJECT]", "[INSTANCE]", "[APP_PROFILE]");
            // Make the request
            await bigtableInstanceAdminClient.DeleteAppProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = bigtableInstanceAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await bigtableInstanceAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = bigtableInstanceAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await bigtableInstanceAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = bigtableInstanceAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await bigtableInstanceAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = bigtableInstanceAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await bigtableInstanceAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableInstanceAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableInstanceAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableInstanceAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableInstanceAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = bigtableInstanceAdminClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await bigtableInstanceAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = bigtableInstanceAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await bigtableInstanceAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = bigtableInstanceAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await bigtableInstanceAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for ListHotTablets</summary>
        public void ListHotTabletsRequestObject()
        {
            // Snippet: ListHotTablets(ListHotTabletsRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ListHotTabletsRequest request = new ListHotTabletsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTablets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HotTablet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHotTabletsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHotTabletsAsync</summary>
        public async Task ListHotTabletsRequestObjectAsync()
        {
            // Snippet: ListHotTabletsAsync(ListHotTabletsRequest, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListHotTabletsRequest request = new ListHotTabletsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTabletsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HotTablet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHotTabletsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHotTablets</summary>
        public void ListHotTablets()
        {
            // Snippet: ListHotTablets(string, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTablets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HotTablet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHotTabletsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHotTabletsAsync</summary>
        public async Task ListHotTabletsAsync()
        {
            // Snippet: ListHotTabletsAsync(string, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTabletsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HotTablet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHotTabletsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHotTablets</summary>
        public void ListHotTabletsResourceNames()
        {
            // Snippet: ListHotTablets(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTablets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HotTablet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHotTabletsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHotTabletsAsync</summary>
        public async Task ListHotTabletsResourceNamesAsync()
        {
            // Snippet: ListHotTabletsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = await BigtableInstanceAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListHotTabletsResponse, HotTablet> response = bigtableInstanceAdminClient.ListHotTabletsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HotTablet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHotTabletsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HotTablet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HotTablet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HotTablet item in singlePage)
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
